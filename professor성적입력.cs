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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication1
{
    public partial class professor성적입력 : Form
    {
        private string sql, ID;
        OleDbConnection conn;
        List<string> 과목 = new List<string>();
        public professor성적입력(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
        }


        private void professor성적입력_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn = new OleDbConnection(sql);
            
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT 과목번호 FROM scott.개설과목 WHERE 담당교수번호 = '" + ID + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                //행 단위로 반복
                while (read.Read())
                {
                    과목.Add(read.GetString(0));
                }
                read.Close();

                for(int i = 0; i < 과목.Count; i++)
                {
                    cmd.CommandText = "SELECT * FROM scott.수강 WHERE 과목번호 = '" + 과목[i] + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    OleDbDataReader read1 = cmd.ExecuteReader();
                    dataGridView1.ColumnCount = read1.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함
                                                                 //필드명 받아오는 반복문
                    for (int j = 0; j < read1.FieldCount; j++)
                    {
                        dataGridView1.Columns[j].Name = read1.GetName(j);
                    }

                    //행 단위로 반복
                    while (read1.Read())
                    {
                        object[] obj = new object[read1.FieldCount]; // 필드수만큼 오브젝트 배열

                        for (int j = 0; j < read1.FieldCount; j++) // 필드 수만큼 반복
                        {
                            obj[j] = new object();
                            obj[j] = read1.GetValue(j); // 오브젝트배열에 데이터 저장
                        }

                        dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                    }
                    read1.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Label[] labels = new Label[]
            {
                label6, label7, label8, label9 // 학번, 과목, 연도, 학기
            };
            for (int i = 0; i < 4; i++)
            {
                labels[i].Text = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() != "")
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else
            {
                textBox1.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE scott.수강 SET 성적 = '" + textBox1.Text + "' WHERE 학번 = '"
                    + label6.Text + "' AND 과목번호 = '" + label7.Text + "' AND 연도 = '"
                    + label8.Text + "' AND 학기 = '" + label9.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                updateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            professorMenu f = new professorMenu(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void updateTable()
        {
            dataGridView1.Rows.Clear();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                for (int i = 0; i < 과목.Count; i++)
                {
                    cmd.CommandText = "SELECT * FROM scott.수강 WHERE 과목번호 = '" + 과목[i] + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    OleDbDataReader read1 = cmd.ExecuteReader();
                    dataGridView1.ColumnCount = read1.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함
                                                                  //필드명 받아오는 반복문
                    for (int j = 0; j < read1.FieldCount; j++)
                    {
                        dataGridView1.Columns[j].Name = read1.GetName(j);
                    }

                    //행 단위로 반복
                    while (read1.Read())
                    {
                        object[] obj = new object[read1.FieldCount]; // 필드수만큼 오브젝트 배열

                        for (int j = 0; j < read1.FieldCount; j++) // 필드 수만큼 반복
                        {
                            obj[j] = new object();
                            obj[j] = read1.GetValue(j); // 오브젝트배열에 데이터 저장
                        }

                        dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                    }
                    read1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
    }
}
