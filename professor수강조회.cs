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
    public partial class professor수강조회 : Form
    {
        private string sql, ID;
        OleDbConnection conn;
        public professor수강조회(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
        }

        private void professor수강조회_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(sql);
            conn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from scott.수강";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader();
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

                    for(int i = 0; i < read.FieldCount; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
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

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            professorMenu f = new professorMenu(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
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
