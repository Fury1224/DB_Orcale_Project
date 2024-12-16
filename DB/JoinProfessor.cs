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

namespace WindowsFormsApplication1
{
    public partial class JoinProfessor : Form
    {
        OleDbConnection conn;
        private string sql;
        public JoinProfessor()
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

                OleDbDataReader read = cmd.ExecuteReader(); //select 결과


                while (read.Read())
                {
                    comboBox1.Items.Add(read.GetValue(0));
                }

                read.Close();
                comboBox1.Text = "학과를 선택해주세요";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                cmd.CommandText = "CREATE USER \"" + textBox1.Text + "\" identified by 0000 DEFAULT TABLESPACE student";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "GRANT CREATE SESSION TO \"" + textBox1.Text + "\"";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();


                this.Hide();
                Dialog f = new Dialog(textBox1.Text, textBox2.Text, comboBox1.Text, true);
                f.Closed += (s, args) => this.Close();
                f.ShowDialog();
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void createUser()
        {
            try
            {
                sql = "Provider=MSDAORA;Password=Manager7083;User ID=system";
                conn = new OleDbConnection(sql);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "CREATE USER \"" + textBox1.Text + "\" identified by 0000 DEFAULT TABLESPACE student";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
    }
}
