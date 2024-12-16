using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication1
{
    public partial class Dialog : Form
    {
        OleDbConnection conn;
        private string sql;
        private string 번호, 이름, 학과, 학년, 지도교수;
        private bool check;     // true면 교수, false면 학생
        public Dialog(string 번호, string 이름, string 학과, bool check, string 학년 = "", string 지도교수 = "")
        {
            InitializeComponent();
            this.번호 = 번호;
            this.이름 = 이름;
            this.학과 = 학과;
            this.check = check;
            this.학년 = 학년;
            this.지도교수 = 지도교수;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "Provider=MSDAORA;Password=tiger;User ID=scott";
                conn = new OleDbConnection(sql);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();

                if (check == true)  // 교수일 경우
                {
                    cmd.CommandText = "INSERT INTO 교수 VALUES ('" + 번호 + "', '" + 이름 + "', "
                    + "'0000', '" + 학과 + "')";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO 교수권한 VALUES ('" + 번호 + "'FALSE')";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "GRANT professor TO \"" + 번호 + "\"";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                }
                else    // 학생일 경우
                {
                    cmd.CommandText = "INSERT INTO 학생 VALUES ('" + 번호 + "', '" + 이름 + "', '" + 학년 + "', "
                    + "'0000', '" + 지도교수 + "', '" + 학과 + "')";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "GRANT student TO \"" + 번호 + "\"";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
                
                this.Hide();
                Login f = new Login();
                f.Closed += (s, args) => this.Close();
                f.ShowDialog();
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            
        }
    }
}
