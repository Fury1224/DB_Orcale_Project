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
    public partial class AdminSelect : Form
    {
        OleDbConnection conn;
        private string sql;
        private int table_columns;
        public AdminSelect(string sql)
        {
            InitializeComponent();
            this.sql = sql;

            conn = new OleDbConnection(sql);

            dataGridView1.Rows.Clear();
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select table_name from user_tables"; //테이블목록가져오기
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select 결과

                //행 단위로 반복
                while (read.Read())
                {
                    tableList.Items.Add(read.GetValue(0)); //데이터그리드뷰에 오브젝트 배열 추가
                }

                read.Close();
                tableList.Text = "테이블선택";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }



        // 테이블 리스트 콤보박스 선택 시
        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            setComboBox();

            conn = new OleDbConnection(sql);

            if(tableList.Text == "교수")
            {
                button학점.Visible = true;
            }
            else
            {
                button학점.Visible = false;
            }
            if(tableList.Text == "학생")
            {
                button수강학점.Visible = true;
            }
            else
            {
                button수강학점.Visible = false;
            }
            try
            {
                conn.Open(); //데이터베이스 연결         
                             //conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from " + tableList.Text; // from 뒤에 공백 필수!!
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                dataGridView1.ColumnCount = read.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함
                                                             //필드명 받아오는 반복문
                for (int i = 0; i < read.FieldCount; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[read.FieldCount]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < read.FieldCount; i++) // 필드 수만큼 반복
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu f = new AdminMenu(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {   // 학과별 선택 시
            try
            {
                dataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from " + tableList.Text;
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

        private void setComboBox()
        {
            if (tableList.Text == "학과" || tableList.Text == "교수" || tableList.Text == "학생")
            {
                
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "select 학과이름 from 학과"; //테이블목록가져오기
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    OleDbDataReader read = cmd.ExecuteReader(); //select 결과
                    comboBox학과별.Items.Clear();

                    comboBox학과별.Items.Add("전체");
                    //행 단위로 반복
                    while (read.Read())
                    {
                        comboBox학과별.Items.Add(read.GetValue(0)); //데이터그리드뷰에 오브젝트 배열 추가
                    }

                    read.Close();
                    comboBox학과별.Text = "선택해주세요";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                }
            }
            if (tableList.Text == "학생")
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "select 학년 from 학생 GROUP BY 학년"; //테이블목록가져오기
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    OleDbDataReader read = cmd.ExecuteReader(); //select 결과
                    comboBox학년별.Items.Clear();

                    comboBox학년별.Items.Add("전체");
                    //행 단위로 반복
                    while (read.Read())
                    {
                        comboBox학년별.Items.Add(read.GetValue(0)); //데이터그리드뷰에 오브젝트 배열 추가
                    }

                    read.Close();
                    comboBox학년별.Text = "선택해주세요";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                }
            }
        }

        private void comboBox학년별_SelectedIndexChanged(object sender, EventArgs e)
        {   // 학년별 선택시
            try
            {
                dataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from " + tableList.Text;
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
                        {
                            check = true;
                        }
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

        private void button학점_Click(object sender, EventArgs e)
        {
            this.Hide();
            강의학점조회 f = new 강의학점조회(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button수강학점_Click(object sender, EventArgs e)
        {
            this.Hide();
            수강학점조회 f = new 수강학점조회(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void AdminSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
