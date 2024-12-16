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
    public partial class 강의학점조회 : Form
    {
        private string sql;
        private string professor;
        OleDbConnection conn;
        public 강의학점조회(string sql)
        {
            InitializeComponent();
            this.sql = sql; 
        }

        private void 강의학점수_조회_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(sql);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 이름 from 교수";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                //행 단위로 반복
                while (read.Read())
                {
                    comboBox교수.Items.Add(read.GetValue(0));
                }

                read.Close();
                comboBox교수.Text = "선택해주세요";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void comboBox교수_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OleDbConnection(sql);
            bool check = false;
            comboBox연도.Items.Clear();
            comboBox학기.Items.Clear();
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 교수번호 from 교수 where 이름 = '" + comboBox교수.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                professor = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "select 연도 from 개설과목 where 담당교수번호 = '" + professor + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader();

                //행 단위로 반복
                while (read.Read())
                {
                    for(int i = 0; i<comboBox연도.Items.Count; i++)
                    {
                        if (object.Equals(comboBox연도.Items[i], read.GetValue(0)))
                        {
                            check = true; break;
                        }
                    }
                    if(check == false)
                    {
                        comboBox연도.Items.Add(read.GetValue(0));
                    }
                    else
                    {
                        check = false;
                    }
                }

                read.Close();
                comboBox연도.Text = "선택해주세요";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void comboBox연도_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool check = false;
            conn = new OleDbConnection(sql);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 학기 from 개설과목 where 담당교수번호 = '" + professor + "' and 연도 = '"
                    +comboBox연도.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                
                OleDbDataReader read = cmd.ExecuteReader();

                //행 단위로 반복
                while (read.Read())
                {
                    for (int i = 0; i < comboBox학기.Items.Count; i++)
                    {
                        if (object.Equals(comboBox학기.Items[i], read.GetValue(0)))
                        {
                            check = true; break;
                        }
                    }
                    if (check == false)
                    {
                        comboBox학기.Items.Add(read.GetValue(0));
                    }
                    else
                    {
                        check = false;
                    }
                }

                read.Close();
                comboBox학기.Text = "선택해주세요";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void comboBox학기_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            int total = 0;
            conn = new OleDbConnection(sql);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 과목번호 from 개설과목 where 담당교수번호 = '" + professor + "' and 연도 = '"
                    + comboBox연도.Text + "' and 학기 = '" + comboBox학기.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                //행 단위로 반복
                while (read.Read())
                {
                    names.Add((string)read.GetValue(0));
                }
                read.Close();

                for(int i=0; i<names.Count; i++)
                {
                    cmd.CommandText = "select 이수학점 from 과목 where 과목번호 = '" + names[i] + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    OleDbDataReader read1 = cmd.ExecuteReader();
                    if (read1.Read())
                        total += int.Parse((string)read1.GetValue(0));
                    read1.Close();
                }
                label5.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSelect f = new AdminSelect(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }
    }
}
