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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace WindowsFormsApplication1
{
    public partial class student개설과목 : Form
    {
        private string sql, ID;
        OleDbConnection conn;
        Image image = null;
        Image thumnail_img = null;
        public student개설과목(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
            conn = new OleDbConnection(sql);
            conn.Open();
        }

        private void student개설과목_Load(object sender, EventArgs e)
        {
            dataGridView개설과목.Rows.Clear();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from scott.개설과목 where 과목번호 in " +
                    "(select 과목번호 from scott.과목 where 학과이름 = " +
                    "(select 학과이름 from scott.학생 where 학번 = '" + ID + "') and " +
                    "대상학년 = (select 학년 from scott.학생 where 학번 = '" + ID + "'))";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                dataGridView개설과목.ColumnCount = read.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Select";
                dataGridView개설과목.Columns.Insert(0, checkBoxColumn);

                //필드명 받아오는 반복문
                for (int i = 0; i < read.FieldCount; i++)
                {
                    dataGridView개설과목.Columns[i+1].Name = read.GetName(i);
                }


                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[read.FieldCount + 1]; // 필드수만큼 오브젝트 배열

                    obj[0] = false;
                    obj[1] = read.GetValue(0).ToString();
                    obj[2] = read.GetValue(1).ToString();
                    obj[3] = read.GetValue(2).ToString();
                    obj[4] = read.GetValue(3).ToString();
                    if (read.GetValue(4).ToString() == "")
                        obj[5] = "NULL";

                    dataGridView개설과목.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }
                read.Close();

                update수강();
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
        {
            // 개설 과목 클릭 시
            string sub_name;
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                sub_name = dataGridView개설과목.Rows[e.RowIndex].Cells[1].Value.ToString();
                if ((bool)dataGridView개설과목.Rows[e.RowIndex].Cells[0].Value == false)
                    dataGridView개설과목.Rows[e.RowIndex].Cells[0].Value = true;
                else
                    dataGridView개설과목.Rows[e.RowIndex].Cells[0].Value = false;
                cmd.CommandText = "SELECT * FROM scott.개설과목 WHERE 과목번호 = '" + sub_name + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read1 = cmd.ExecuteReader(); //select 결과
                while (read1.Read())
                {
                    if (read1.GetValue(4).ToString() == "")
                    {
                        MessageBox.Show("등록된 이미지가 없습니다");
                        pictureBox1.Image = null;

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

        private void button신청_Click(object sender, EventArgs e)
        {
            List<List<string>> selectedValues = new List<List<string>>();
            string value1, value2, value3;

            // DataGridView의 각 행을 반복하면서 체크된 행의 첫 번째 속성값을 가져옴
            for (int i = 0; i < dataGridView개설과목.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkBoxCell = dataGridView개설과목.Rows[i].Cells[0] as DataGridViewCheckBoxCell;

                // 체크된 행의 첫 번째 속성값 가져오기
                if (Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    value1 = dataGridView개설과목.Rows[i].Cells[1].Value.ToString();    
                    value2 = dataGridView개설과목.Rows[i].Cells[2].Value.ToString();
                    value3 = dataGridView개설과목.Rows[i].Cells[3].Value.ToString();
                    selectedValues.Add(new List<string> { value1, value2, value3 });
                }
            }
            int j = 0;
            for (int i = 0; i < dataGridView개설과목.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkBoxCell = dataGridView개설과목.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                
                OleDbCommand cmd = new OleDbCommand();
                // 체크된 행의 첫 번째 속성값 가져오기
                if (Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    try
                    {

                        cmd.CommandText = "INSERT INTO scott.수강 VALUES ('" + ID + "', '" + selectedValues[j][0] + "', '"
                        + selectedValues[j][1] + "', '" + selectedValues[j][2] + "', NULL)";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(selectedValues[j][0] + "가 수강 신청되었습니다");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                    }
                    j++;
                }
            }
            update수강();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMenu f = new studentMenu(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
        }
        private void update수강()
        {
            dataGridView수강.Rows.Clear();

            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT * FROM scott.수강 WHERE 학번 = '" + ID + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                dataGridView수강.ColumnCount = read.FieldCount; //read.FieldCount는 테이블의 컬럼 수를 말함

                //필드명 받아오는 반복문
                for (int i = 0; i < read.FieldCount; i++)
                {
                    dataGridView수강.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[read.FieldCount]; // 필드수만큼 오브젝트 배열

                   for (int i = 0; i < read.FieldCount;i++)
                    {
                        obj[i] = read.GetValue(i);
                    }

                    dataGridView수강.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
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
