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
    public partial class 수강학점조회 : Form
    {
        private string sql;
        private string student;
        private bool check;
        OleDbConnection conn;
        public 수강학점조회(string sql)
        {
            InitializeComponent();
            this.sql = sql;
        }

        private void 수강학점조회_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(sql);
            check = false;
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 학번 from 수강";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                //행 단위로 반복
                while (read.Read())
                {
                    for (int i = 0; i < comboBox학생.Items.Count; i++)
                    {
                        if (object.Equals(comboBox학생.Items[i], read.GetValue(0)))
                        {
                            check = true; break;
                        }
                    }
                    if (check == false)
                    {
                        comboBox학생.Items.Add(read.GetValue(0));
                    }
                    else
                    {
                        check = false;
                    }
                }

                read.Close();
                comboBox학생.Text = "선택해주세요";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void comboBox학생_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox연도.Items.Clear();
            comboBox학기.Items.Clear();
            check = false;

            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 연도 from 수강 where 학번 = '" + comboBox학생.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader();

                //행 단위로 반복
                while (read.Read())
                {
                    for (int i = 0; i < comboBox연도.Items.Count; i++)
                    {
                        if (object.Equals(comboBox연도.Items[i], read.GetValue(0)))
                        {
                            check = true; break;
                        }
                    }
                    if (check == false)
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
                comboBox학기.Text = "";
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

        private void comboBox연도_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox학기.Items.Clear();
            check = false;
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 학기 from 수강 where 학번 = '" + comboBox학생.Text + "' and 연도 = '"
                    + comboBox연도.Text + "'";
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
            int total = 0;
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT 이수학점 FROM 과목 WHERE 과목번호 IN "
                    + "(SELECT 과목번호 FROM 수강 WHERE 학번 = '" + comboBox학생.Text + "' AND 연도 = '"
                    + comboBox연도.Text + "' AND 학기 = '" + comboBox학기.Text + "')";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    total += int.Parse((string)read.GetValue(0));
                }
                read.Close();
                label5.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
    }
}
