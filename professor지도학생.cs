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
    public partial class professor지도학생 : Form
    {
        private string sql, ID;
        OleDbConnection conn;
        bool check;
        public professor지도학생(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
        }

        private void professor지도학생_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(sql);
            conn.Open(); //데이터베이스 연결
            check = false;
            updateTable();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT 학년 FROM scott.학생 WHERE 지도교수 = '" + ID + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read1 = cmd.ExecuteReader();

                comboBox학년별.Items.Add("전체");
                while (read1.Read())
                {
                    for (int i = 0; i < comboBox학년별.Items.Count; i++)
                    {
                        if (object.Equals(comboBox학년별.Items[i], read1.GetValue(0)))
                        {
                            check = true; break;
                        }
                    }
                    if (check == false)
                    {
                        comboBox학년별.Items.Add(read1.GetValue(0));
                    }
                    else
                    {
                        check = false;
                    }
                }

                read1.Close();
                comboBox학년별.Text = "선택해주세요";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void updateTable()
        {
            dataGridView1.Rows.Clear();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT 학번, 이름, 학년, 학과이름 FROM scott.학생 WHERE 지도교수 = '" + ID + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader(); //select  결과

            dataGridView1.ColumnCount = read.FieldCount;

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

        private void comboBox학년별_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            if (comboBox학년별.Text == "전체")
            {
                updateTable();
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT 학번, 이름, 학년, 학과이름 FROM scott.학생 WHERE 지도교수 = '" + ID + "' AND 학년 = '" + comboBox학년별.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select  결과

                dataGridView1.ColumnCount = read.FieldCount;

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
