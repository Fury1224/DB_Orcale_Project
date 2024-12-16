using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
 
        OleDbConnection conn;
        string sql; // 로그인 정보
        List<string> pro_name = new List<string>(); // 교수 번호 목록
        List<string> stu_name = new List<string>();  // 학생 번호 목록
        bool check;  // true 면 교수, false 면 학생
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            sql = "Provider=OraOLEDB.Oracle;Password=" + txtBoxPW.Text + ";User ID=" + txtBoxID.Text;//oracle 서버 연결
            //연결 스트링에 대한 정보 
            //Oracle - MSDAORA 
            //MS SQL - SQLOLEDB 
            //Data Source(server) : 데이터베이스 위치 
            //User ID/Password : 인증 정보 

            conn = new OleDbConnection(sql);
            conn.Open();


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT 교수번호 FROM scott.교수";
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = conn;

            OleDbDataReader read1 = cmd.ExecuteReader();
            while (read1.Read()) // 입력된 ID가 교수 테이블에 있는지 확인
            {
                pro_name.Add((string)read1.GetValue(0));
            }

            for(int i=0; i< pro_name.Count; i++)
            {
                if (pro_name[i] == txtBoxID.Text)
                    check = true;
            }
            read1.Close();
            

            cmd.CommandText = "SELECT 학번 FROM scott.학생";
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = conn;

            OleDbDataReader read2 = cmd.ExecuteReader();
            while (read2.Read()) // 입력된 ID가 학생 테이블에 있는지 확인
            {
                stu_name.Add((string)read2.GetValue(0));
            }

            for (int i = 0; i < stu_name.Count; i++)
            {
                if (stu_name[i] == txtBoxID.Text)
                    check = false;
            }
            read2.Close();
            try
            {    
                if (txtBoxID.Text == "scott")   // 로그인 대상이 관리자
                {
                    cmd.CommandText = "SELECT 권한 FROM 교수권한";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    OleDbDataReader read3 = cmd.ExecuteReader();
                    while (read3.Read()) // 입력된 ID가 교수 테이블에 있는지 확인
                    {
                        if( (string)read3.GetValue(0) == "ING")
                        {
                            MessageBox.Show("수강명부 권한 요청이 있습니다");
                        }
                    }
                    read3.Close();

                    this.Hide();
                    AdminMenu f = new AdminMenu(sql);
                    f.Closed += (s, args) => this.Close();
                    f.ShowDialog();
                    return;
                }
                else if (check == true) // 로그인 대상이 교수
                {
                    if (txtBoxPW.Text != "0000")
                    {
                        this.Hide();
                        professorMenu f = new professorMenu(sql, txtBoxID.Text);
                        f.Closed += (s, args) => this.Close();
                        f.ShowDialog();
                        return;
                    }
                    else
                    {
                        this.Hide();
                        changePW f = new changePW(sql, txtBoxID.Text, true);
                        f.Closed += (s, args) => this.Close();
                        f.ShowDialog();
                        return;
                    }
                }
                else if (check == false) // 로그인 대상이 학생
                {
                    if(txtBoxPW.Text != "0000")
                    {
                        this.Hide();
                        studentMenu f = new studentMenu(sql, txtBoxID.Text);
                        f.Closed += (s, args) => this.Close();
                        f.ShowDialog();
                        return;
                    }
                    else
                    {
                        this.Hide();
                        changePW f = new changePW(sql, txtBoxID.Text, false);
                        f.Closed += (s, args) => this.Close();
                        f.ShowDialog();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("존재하지 않는 계정입니다");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }



 
         private void txtBoxPw_KeyDown(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.Enter)
             {
                 button1_Click(sender, e);
                 e.SuppressKeyPress = true;
             }
         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoinMenu f = new JoinMenu();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }
    }   
}

      