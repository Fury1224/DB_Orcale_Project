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
    public partial class admin권한 : Form
    {
        private string sql;
        OleDbConnection conn;
        public admin권한(string sql)
        {
            InitializeComponent();
            this.sql = sql;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu f = new AdminMenu(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void admin권한_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn = new OleDbConnection(sql);
            conn.Open();
            updateTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "update 교수권한 set 권한 = 'TRUE' WHERE 교수번호 = '" + label2.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show(label2.Text + "의 권한이 변경되었습니다");
                updateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void updateTable()
        {
            dataGridView1.Rows.Clear ();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 교수권한";
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
    }
}
