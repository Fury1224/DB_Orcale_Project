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
    public partial class studentMenu : Form
    {
        private string sql, ID;
        public studentMenu(string sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID = ID;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            student개설과목 f = new student개설과목(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            student성적 f = new student성적(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            student상담조회 f = new student상담조회(sql, ID);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void studentMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
