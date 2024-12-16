using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace WindowsFormsApplication1
{
    public partial class AdminManage과목 : Form
    {
        OleDbConnection conn;
        private string sql;
        private string pro_name;    // 교수 이름
        private string sub_name;    // 과목 이름
        private string 구분, 학과;      // 전공 구분, 학과
        Image image = null;
        Image thumnail_img = null;
        bool check = false; // true면 이미 개설됨 

        public AdminManage과목(string sql)
        {
            InitializeComponent();
            this.sql = sql;

            conn = new OleDbConnection(sql);
            conn.Open();
            try
            {
                dataGridView과목.Rows.Clear();
                //conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 과목";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                dataGridView과목.ColumnCount = read.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함
                
                //필드명 받아오는 반복문
                for (int i = 0; i < read.FieldCount; i++)
                {
                    dataGridView과목.Columns[i].Name = read.GetName(i);
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

                    dataGridView과목.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }

                read.Close();
                updateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            
        }

        private void dataGridView과목_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   // 과목 리스트 클릭 시 우측에 표시
            textBox과목번호.Text = dataGridView과목.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox과목명.Text = dataGridView과목.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox학기.Text = dataGridView과목.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox연도.Text = "";
            구분 = dataGridView과목.Rows[e.RowIndex].Cells[4].Value.ToString();
            학과 = dataGridView과목.Rows[e.RowIndex].Cells[6].Value.ToString();
            try
            {
                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandText = "SELECT 이름 FROM 교수 WHERE 학과이름 = '" 
                    + dataGridView과목.Rows[e.RowIndex].Cells[6].Value.ToString() + "'" ;
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select 결과
                comboBox교수명.Items.Clear();
                //행 단위로 반복
                while (read.Read())
                {
                    comboBox교수명.Items.Add(read.GetValue(0));
                }

                read.Close();
                comboBox교수명.Text = "선택해주세요";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void button과목개설_Click(object sender, EventArgs e)
        {   // 과목 개설하기 버튼
            try
            {
                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandText = "SELECT 과목번호 FROM 개설과목";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                textBox9.Text = cmd.CommandText;    // 텍스트박스에 명령어 출력해서 확인
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        if ((string)read.GetValue(0) == textBox과목번호.Text)
                        {   // 개설하려는 과목이 이미 개설과목 테이블에 있으면
                            check = true;
                        }
                    }
                }
                

                read.Close();


                if (check == false)
                {
                    cmd.CommandText = "SELECT * FROM 교수 WHERE 이름 = '" + comboBox교수명.Text + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    textBox9.Text = cmd.CommandText;    // 텍스트박스에 명령어 출력해서 확인
                    OleDbDataReader read1 = cmd.ExecuteReader();
                    while(read1.Read())
                        pro_name = (string)read1.GetValue(0);    // 교수명을 받아서 해당하는 교수번호 저장
                    read1.Close();
                    cmd.CommandText = "INSERT INTO 개설과목 VALUES('" + textBox과목번호.Text + "', '"
                        + textBox연도.Text + "', '" + textBox학기.Text + "', '" + pro_name + "', NULL)";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    textBox9.Text = cmd.CommandText;    // 텍스트박스에 명령어 출력해서 확인
                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                }
                else
                {
                    check = false;
                    MessageBox.Show("이미 개설된 교과목입니다");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            updateTable();
        }

        private void updateTable()
        {   // 개설 교과목 테이블 새로고침
            
            dataGridView개설과목.Rows.Clear();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT * FROM 개설과목";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                dataGridView개설과목.ColumnCount = read.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함

                //필드명 받아오는 반복문
                for (int i = 0; i < read.FieldCount; i++)
                {
                    dataGridView개설과목.Columns[i].Name = read.GetName(i);
                }


                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[read.FieldCount]; // 필드수만큼 오브젝트 배열


                    
                    obj[0] = read.GetValue(0).ToString();
                    obj[1] = read.GetValue(1).ToString();
                    obj[2] = read.GetValue(2).ToString();
                    obj[3] = read.GetValue(3).ToString();
                    if (read.GetValue(4).ToString() == "")
                        obj[4] = "NULL";
                    
                    dataGridView개설과목.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private Image ByteArrayToImage(byte[] bytes)
        {
            ImageConverter imageConverter = new ImageConverter();
            Image img = (Image)imageConverter.ConvertFrom(bytes);
            return img;
        }

        private void dataGridView개설과목_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   // 개설 과목 클릭 시
            textBox과목번호.Text = dataGridView개설과목.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox과목명.Text = "";
            textBox연도.Text = dataGridView개설과목.Rows[e.RowIndex].Cells[1].Value.ToString();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                sub_name = dataGridView개설과목.Rows[e.RowIndex].Cells[0].Value.ToString();

                cmd.CommandText = "SELECT * FROM 개설과목 WHERE 과목번호 = '" + sub_name + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read1 = cmd.ExecuteReader(); //select 결과
                while (read1.Read())
                {
                    if (read1.GetValue(4).ToString() == "")
                    {
                        MessageBox.Show("등록된 이미지가 없습니다");

                    }
                    else
                    {
                        image = ByteArrayToImage((byte[])read1.GetValue(4));
                        Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        thumnail_img = image.GetThumbnailImage(400, 400, callback, new IntPtr()); //썸네일 만들기
                        pictureBox1.Image = thumnail_img;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                
                read1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            
        }
        public bool ThumbnailCallback()
        {
            return true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManage f = new AdminManage(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminManage과목_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
