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
    public partial class JoinStudent : Form
    {
        OleDbConnection conn;
        private string sql;
        public JoinStudent()
        {
            InitializeComponent();

            try
            {
                sql = "Provider=MSDAORA;Password=tiger;User ID=scott";
                conn = new OleDbConnection(sql);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 학과이름 from 학과"; //테이블목록가져오기
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read1 = cmd.ExecuteReader(); //select 결과


                while (read1.Read())
                {
                    comboBox학과.Items.Add(read1.GetValue(0));
                }

                read1.Close();
                comboBox학과.Text = "학과를 선택해주세요";

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            comboBox학년.Items.Add("1");
            comboBox학년.Items.Add("2");
            comboBox학년.Items.Add("3");
            comboBox학년.Items.Add("4");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   // 학과 선택 시
            
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select 교수번호 from 교수 where 학과이름 = '" + comboBox학과.Text + "'"; //테이블목록가져오기
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = conn;
            OleDbDataReader read = cmd.ExecuteReader();

            comboBox교수.Items.Clear();   // 기존 콤보박스 초기화
            
            while (read.Read())
            {
                comboBox교수.Items.Add(read.GetValue(0));
            }
            read.Close();
            comboBox교수.SelectedIndex = 0;   // 새롭게 구성된 콤보박스의 첫번째 항목 자동선택
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "Provider=MSDAORA;Password=Manager7083;User ID=system";
                conn = new OleDbConnection(sql);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "CREATE USER \"" + textBox학번.Text + "\" identified by 0000 DEFAULT TABLESPACE student";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "GRANT CREATE SESSION TO \"" + textBox학번.Text + "\"";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();


                this.Hide();
                Dialog f = new Dialog(textBox학번.Text, textBox이름.Text, comboBox학과.Text, false, comboBox학년.Text, comboBox교수.Text);
                f.Closed += (s, args) => this.Close();
                f.ShowDialog();
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoinMenu f = new JoinMenu();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void comboBox학년_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox교수_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
