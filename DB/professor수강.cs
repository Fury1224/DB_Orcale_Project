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
    public partial class professor수강 : Form
    {
        private string sql, ID;
        OleDbConnection conn;
        public professor수강(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            professorMenu f = new professorMenu(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "update scott.교수권한 set 권한 = 'ING' where 교수번호 = '" + ID + "'";
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("권한을 요청했습니다");
            this.Hide();
            professorMenu f = new professorMenu(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void professor수강_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(sql);
            conn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 권한 from scott.교수권한 where 교수번호 = '" + ID + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    if (read.GetValue(0).ToString() == "FALSE")
                    {
                        MessageBox.Show("권한이 없습니다");

                    }
                    else if (read.GetValue(0).ToString() == "ING")
                    {
                        MessageBox.Show("아직 요청이 승인되지 않았습니다");
                        this.Hide();
                        professorMenu f = new professorMenu(sql, ID);
                        f.Closed += (s, args) => this.Close();
                        f.ShowDialog();
                        return;
                    }
                    else
                    {
                        this.Hide();
                        professor수강조회 f = new professor수강조회(sql, ID);
                        f.Closed += (s, args) => this.Close();
                        f.ShowDialog();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }

        }
    }
}
