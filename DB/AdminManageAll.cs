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
using TextBox = System.Windows.Forms.TextBox;

namespace WindowsFormsApplication1
{
    public partial class AdminManageAll : Form
    {
        OleDbConnection conn;
        private string sql;
        private string table_name;
        private int table_columns;
        private string command;

        public AdminManageAll(string sql, string table_name)
        {
            InitializeComponent();
            this.sql = sql;
            this.table_name = table_name;

            conn = new OleDbConnection(sql);
            conn.Open();
            command = "select * from " + table_name;
            updatedb(command);

            setComboBox();
            
        }
        private void updatedb(string command)
        {
            Label[] labels = new Label[]
            {
                label1, label2, label3, label4, label5, label6, label7
            };
          
            try
            {
                dataGridView1.Rows.Clear();
                //conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = command;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                dataGridView1.ColumnCount = read.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함
                table_columns = read.FieldCount;
                //필드명 받아오는 반복문
                for (int i = 0; i < table_columns; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                    labels[i].Text = read.GetName(i);   // 오른쪽 라벨들을 테이블 속성으로 변경
                }
                
                // 테이블 속성이 7개 미만이면 나머지는 공백 처리
                if (table_columns < 7)
                {
                    for (int i = table_columns; i < 7; i++)
                        labels[i].Text = "";
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[table_columns]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < table_columns; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                    }

                    dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void setComboBox()
        {
            if (table_name == "학과" || table_name == "교수" || table_name == "학생")
            {
                label9.Visible = true;
                comboBox학과별.Visible = true;
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "select 학과이름 from 학과"; //테이블목록가져오기
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    OleDbDataReader read = cmd.ExecuteReader(); //select 결과

                    comboBox학과별.Items.Add("전체");
                    //행 단위로 반복
                    while (read.Read())
                    {
                        comboBox학과별.Items.Add(read.GetValue(0)); //데이터그리드뷰에 오브젝트 배열 추가
                    }

                    read.Close();
                    comboBox학과별.Text = "전체";
                }
                
                catch (Exception ex)
                {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                }
            }
            if (table_name == "학생")
            {
                label8.Visible = true;
                comboBox학년별.Visible = true;
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "select 학년 from 학생 GROUP BY 학년"; //테이블목록가져오기
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    OleDbDataReader read = cmd.ExecuteReader(); //select 결과

                    comboBox학년별.Items.Add("전체");
                    //행 단위로 반복
                    while (read.Read())
                    {
                        comboBox학년별.Items.Add(read.GetValue(0)); //데이터그리드뷰에 오브젝트 배열 추가
                    }

                    read.Close();
                    comboBox학년별.Text = "전체";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                }
            }
        }
        
        private void insertButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[]
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7
            };

            try
            {
                OleDbCommand cmd = new OleDbCommand();
                string 과목번호 = "";
                if(table_name == "과목")
                {
                    if (textBox5.Text == "전공")
                    {
                        과목번호 = textBox7.Text.Substring(0, textBox7.Text.Length - 1) + "_C_" + textBox1.Text;
                    }
                    else if (textBox5.Text == "교양")
                    {
                        과목번호 = "SCH_C_" + textBox1.Text;
                    }
                    else
                    {
                        MessageBox.Show("잘못된 표현입니다");
                    }
                    cmd.CommandText = "INSERT INTO " + table_name + " VALUES('";
                    for (int i = 0; i < table_columns; i++)
                    {
                        if (i == table_columns - 1)
                            cmd.CommandText += textBoxes[i].Text + "')";
                        else if (i == 0)
                            cmd.CommandText += 과목번호 + "','";
                        else
                            cmd.CommandText += textBoxes[i].Text + "','";
                    }
                }
                else
                {
                    cmd.CommandText = "INSERT INTO " + table_name + " VALUES('";
                    for (int i = 0; i < table_columns; i++)
                    {
                        if (i == table_columns - 1)
                            cmd.CommandText += textBoxes[i].Text + "')";
                        else
                            cmd.CommandText += textBoxes[i].Text + "','";
                    }
                }
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                textBox9.Text = cmd.CommandText;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                updatedb(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManage f = new AdminManage(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void AdminManage학과_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[]
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7
            };
            Label[] labels = new Label[]
            {
                label1, label2, label3, label4, label5, label6, label7
            };
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "DELETE FROM " + table_name + " WHERE ";
                switch (table_name)
                {
                    case "학과":
                        cmd.CommandText += labels[0].Text + "= '" + textBoxes[0].Text + "'";
                        break;
                    case "교수":
                        cmd.CommandText += labels[0].Text + "= '" + textBoxes[0].Text + "'";
                        break;
                    case "학생":
                        cmd.CommandText += labels[0].Text + "= '" + textBoxes[0].Text + "'";
                        break;
                    case "과목":
                        cmd.CommandText += labels[0].Text + "= '" + textBoxes[0].Text + "'";
                        break;
                    case "수강":
                        cmd.CommandText += labels[0].Text + "= '" + textBoxes[0].Text + "'"
                            + labels[1].Text + "= '" + textBoxes[1].Text + "'"
                            + labels[2].Text + "= '" + textBoxes[2].Text + "'"
                            + labels[3].Text + "= '" + textBoxes[3].Text + "'";
                        break;
                    case "상담":
                        cmd.CommandText += labels[0].Text + "= '" + textBoxes[0].Text + "'"
                            + labels[1].Text + "= '" + textBoxes[1].Text + "'";
                        break;
                }
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                textBox9.Text = cmd.CommandText;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                updatedb(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[]
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7
            };
            Label[] labels = new Label[]
            {
                label1, label2, label3, label4, label5, label6, label7
            };
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE " + table_name + " SET ";
                for (int i = 0; i < table_columns; i++)
                {
                    if (i == table_columns - 1)
                        cmd.CommandText += labels[i].Text + " = '" + textBoxes[i].Text + "'";
                    else
                        cmd.CommandText += labels[i].Text + " = '" + textBoxes[i].Text + "',";
                }
                switch (table_name)
                {
                    case "학과":
                        cmd.CommandText += " WHERE " + labels[0].Text + "= '" + textBoxes[0].Text + "'";
                        break;
                    case "교수":
                        cmd.CommandText += " WHERE " + labels[0].Text + "= '" + textBoxes[0].Text + "'";
                        break;
                    case "학생":
                        cmd.CommandText += " WHERE " + labels[0].Text + "= '" + textBoxes[0].Text + "'";
                        break;
                    case "수강":
                        cmd.CommandText += " WHERE " + labels[0].Text + "= '" + textBoxes[0].Text + "'"
                            + labels[1].Text + "= '" + textBoxes[1].Text + "'"
                            + labels[2].Text + "= '" + textBoxes[2].Text + "'"
                            + labels[3].Text + "= '" + textBoxes[3].Text + "'";
                        break;
                    case "상담":
                        cmd.CommandText += " WHERE " + labels[0].Text + "= '" + textBoxes[0].Text + "'"
                            + labels[1].Text + "= '" + textBoxes[1].Text + "'";
                        break;
                    case "과목":
                        cmd.CommandText += " WHERE " + labels[0].Text + "= '" + textBoxes[0].Text + "'";
                        break;

                }
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                textBox9.Text = cmd.CommandText;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                updatedb(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox[] textBoxes = new TextBox[]
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7
            };
            for (int i = 0; i < table_columns; i++)
            {
                textBoxes[i].Text = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
            }
        }

        private void 학과별Button_Click(object sender, EventArgs e)
        {

        }

        private void comboBox학과별_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from " + table_name;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                dataGridView1.ColumnCount = read.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함
                table_columns = read.FieldCount;
                //필드명 받아오는 반복문
                for (int i = 0; i < table_columns; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                bool check = false;
                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[table_columns]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < table_columns; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                        if ((string)obj[i] == comboBox학과별.Text || comboBox학과별.Text == "전체")
                            check = true;
                    }
                    if (check == true)
                    {
                        dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                        check = false;
                    }
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void comboBox학년별_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from " + table_name;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                dataGridView1.ColumnCount = read.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함
                table_columns = read.FieldCount;
                //필드명 받아오는 반복문
                for (int i = 0; i < table_columns; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                bool check = false;
                //행 단위로 반복
                while (read.Read())
                {

                    object[] obj = new object[table_columns]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < table_columns; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                        if ((string)obj[i] == comboBox학년별.Text || comboBox학년별.Text == "전체")
                            check = true;
                    }
                    if (check == true)
                    {
                        dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                        check = false;
                    }

                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
    }
}
