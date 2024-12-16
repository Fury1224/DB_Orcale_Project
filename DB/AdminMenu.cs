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
    public partial class AdminMenu : Form
    {
        private string sql;
        public AdminMenu(string sql)
        {
            InitializeComponent();
            this.sql = sql;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSelect f = new AdminSelect(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void manageButton_Click(object sender, EventArgs e)
        {   // 관리 버튼
            this.Hide();
            AdminManage f = new AdminManage(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }


        private void button3_Click(object sender, EventArgs e)
        {   // 과목 개설하기 버튼
            this.Hide();
            AdminManage과목 f = new AdminManage과목(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin권한 f = new admin권한(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }
    }
}
