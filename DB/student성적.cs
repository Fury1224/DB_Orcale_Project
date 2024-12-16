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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApplication1
{
    public partial class student성적 : Form
    {
        private string sql, ID;
        bool check;
        OleDbConnection conn;
        public student성적(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
            conn = new OleDbConnection(sql);
            conn.Open();
        }
        private void student성적_Load(object sender, EventArgs e)
        {
            dataGridView성적.Rows.Clear();
            check = false;
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT 연도 FROM scott.수강 WHERE 학번 = '" + ID + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void comboBox연도_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox학기.Items.Clear();

            try
            {
                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandText = "SELECT 학기 FROM scott.수강 WHERE 연도 = '" + comboBox연도.Text 
                    + "' and 학번 = '" + ID + "'";
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
            dataGridView성적.Rows.Clear();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT 과목번호, 성적 FROM scott.수강 WHERE 학번 = '" + ID 
                    + "' AND 연도 = '" + comboBox연도.Text + "' AND 학기 = '" + comboBox학기.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                dataGridView성적.ColumnCount = read.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함

                //필드명 받아오는 반복문
                for (int i = 0; i < read.FieldCount; i++)
                {
                    dataGridView성적.Columns[i].Name = read.GetName(i);
                }


                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[read.FieldCount + 1]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        if (read.GetValue(i).ToString() == "")
                            obj[i] = "미입력";
                        else
                            obj[i] = read.GetValue(i);
                    }

                    dataGridView성적.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMenu f = new studentMenu(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

    }
}
