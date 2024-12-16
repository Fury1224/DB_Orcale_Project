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
    public partial class student상담조회 : Form
    {
        private string sql, ID;
        OleDbConnection conn;
        public student상담조회(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
        }


        private void student상담조회_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn = new OleDbConnection(sql);
            conn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 상담일자, 상담내용 from scott.상담 where 학번 = '" + ID + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();
                dataGridView1.ColumnCount = read.FieldCount;
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

                    dataGridView1.Rows.Add(obj);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
