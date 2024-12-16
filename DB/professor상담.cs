using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication1
{
    public partial class professor상담 : Form
    {
        private string sql, ID;
        OleDbConnection conn;
        public professor상담(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
            
        }

        private void professor상담_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(sql);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 학번 from scott.학생 where 지도교수 = '" + ID + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                //행 단위로 반복
                while (read.Read())
                {
                    comboBox1.Items.Add(read.GetValue(0));
                }

                read.Close();
                comboBox1.Text = "선택해주세요";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO scott.상담 VALUES ('" + comboBox1.Text
                    + "', sysdate , to_char('" + textBox1.Text + "'))";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("상담 내용이 저장되었습니다");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            textBox1.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            professorMenu f = new professorMenu(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }
    }
}
