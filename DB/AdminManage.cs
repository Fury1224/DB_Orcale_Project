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
    public partial class AdminManage : Form
    {
        private string sql;
        public AdminManage(string sql)
        {
            InitializeComponent();
            this.sql = sql;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu f = new AdminMenu(sql);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageAll f = new AdminManageAll(sql, button1.Text);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageAll f = new AdminManageAll(sql, button2.Text);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageAll f = new AdminManageAll(sql, button3.Text);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageAll f = new AdminManageAll(sql, button4.Text);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageAll f = new AdminManageAll(sql, button6.Text);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageAll f = new AdminManageAll(sql, button7.Text);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }
    }
}
