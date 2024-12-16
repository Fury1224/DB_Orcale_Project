using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class professorMenu : Form
    {
        private string sql, ID;
        public professorMenu(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {   // 담당 교과목 
            this.Hide();
            professor담당교과목 f = new professor담당교과목(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            professor상담 f = new professor상담(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            professor성적입력 f = new professor성적입력(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            professor지도학생 f = new professor지도학생(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            professor상담조회 f = new professor상담조회(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            professor수강 f = new professor수강(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }
    }
}
