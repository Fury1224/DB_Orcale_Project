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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using Image = System.Drawing.Image;

namespace WindowsFormsApplication1
{
    public partial class professor담당교과목 : Form
    {
        private string sql, ID;
        OleDbConnection conn;
        Image image = null;
        Image thumnail_img = null;
        public professor담당교과목(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
            conn = new OleDbConnection(sql);
            conn.Open();
            dataGridView개설과목.Rows.Clear();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT * FROM scott.개설과목 WHERE 담당교수번호 = '" + ID + "'";
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
                        obj[4] = "이미지 없음";
                    else
                        obj[4] = "등록됨";

                    dataGridView개설과목.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void dataGridView개설과목_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   // 테이블 값 클릭 시
            label번호.Text = dataGridView개설과목.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                //conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT * FROM scott.개설과목 WHERE 과목번호 = '" + label번호.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read1 = cmd.ExecuteReader(); //select 결과
                while (read1.Read())
                {
                    if (read1.GetValue(4).ToString() != "")
                    {
                        image = ByteArrayToImage((byte[])read1.GetValue(4));
                        Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        thumnail_img = image.GetThumbnailImage(400, 400, callback, new IntPtr()); //썸네일 만들기
                        pictureBox1.Image = thumnail_img;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }

                read1.Close();
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
        public bool ThumbnailCallback()
        {
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {   // 이미지 찾기 버튼
            string image_file = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\96965\Desktop\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image_file = openFileDialog.FileName;
                image = Bitmap.FromFile(image_file);
                Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);//썸네일 만들기
                thumnail_img = image.GetThumbnailImage(400, 400, callback, new IntPtr()); //썸네일 만들기
            }
            else if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            pictureBox1.Image = Bitmap.FromFile(image_file);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {   // 이미지 등록 버튼
            try
            {
                
                OleDbCommand cmd = new OleDbCommand();
                if (image == null)
                {
                    MessageBox.Show("선택된 이미지가 없습니다");

                }
                else
                {
                    cmd.CommandText = "UPDATE scott.개설과목 SET 교재 = " +":image_var WHERE 과목번호 = '" + label번호.Text + "'";

                    byte[] bytes = imageToByteArray(image);
                    OleDbParameter para = new OleDbParameter();
                    para.OleDbType = OleDbType.LongVarBinary;
                    para.ParameterName = ":image_var";
                    para.Direction = ParameterDirection.Input;
                    para.SourceColumn = "교재";
                    para.Size = bytes.Length;
                    para.Value = bytes;
                    cmd.Parameters.Add(para);
                }
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                cmd.Parameters.Clear();
                label번호.Text = "과목번호";
                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private byte[] imageToByteArray(Image img)
        {
            ImageConverter imageConverter = new ImageConverter();
            byte[] b = (byte[])imageConverter.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void professor담당교과목_Load(object sender, EventArgs e)
        {

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
