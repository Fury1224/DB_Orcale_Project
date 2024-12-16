using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class changePW : Form
    {
        private string sql, ID;
        bool check; // true면 교수, false면 학생
        bool success = false;
        OleDbConnection conn;
        public changePW(string sql, string ID, bool check)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
            this.check = check;
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // 해싱된 바이트를 문자열로 변환하여 반환
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid(textBox1.Text))
            {   // 영문, 숫자 포함 5글자 이상이면
                if (IsValid(textBox1.Text) && textBox1.Text == textBox2.Text)
                {   // 두 입력 패스워드 값이 같은지
                    try
                    {
                        
                        OleDbCommand cmd = new OleDbCommand();
                        conn = new OleDbConnection(sql);
                        conn.Open();
                        if (check == true)
                        {   // 교수면
                            cmd.CommandText = "UPDATE scott.교수 SET 비밀번호 = '" + HashPassword(textBox1.Text) + "' WHERE 교수번호 = '"
                                + ID + "'";
                        }
                        else
                        {   // 학생이면
                            cmd.CommandText = "UPDATE scott.학생 SET 비밀번호 = '" + HashPassword(textBox1.Text) + "' WHERE 학번 = '"
                                + ID + "'";
                        }
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        conn = new OleDbConnection("Provider = MSDAORA; Password = Manager7083; User ID = system");
                        conn.Open();
                        cmd.CommandText = "alter user \"" + ID + "\" identified by " + HashPassword(textBox1.Text);
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                    }
                }
                else
                {
                    MessageBox.Show("같은 비밀번호를 입력해주세요");
                }
            }
            else
            {
                MessageBox.Show("영문, 숫자 포함 5글자 이상 작성해주세요");
            }
            


            if (check == true && success == true)
            {
                change();
                MessageBox.Show("변경이 완료되었습니다");
                this.Hide();
                Login f = new Login();
                f.Closed += (s, args) => this.Close();
                f.ShowDialog();
                return;
            }
            else if (check == false && success == true)
            {
                change();
                MessageBox.Show("변경이 완료되었습니다");
                this.Hide();
                Login f = new Login();
                f.Closed += (s, args) => this.Close();
                f.ShowDialog();
                return;
            }
        }

        static bool IsValid(string input)
        {
            // 영문자와 숫자를 포함하고, 5글자 이상
            string pattern = @"^(?=.*[a-zA-Z])(?=.*\d).{5,}$";

            // 정규표현식과 비교
            return Regex.IsMatch(input, pattern);
        }

        private void change()
        {
            conn = new OleDbConnection("Provider=OraOLEDB.Oracle;Password=Manager7083;User ID=system");
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "ALTER USER \"" + ID + "\" IDENTIFIED BY \"" + textBox1.Text + "\"";
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
        }
    }
}
