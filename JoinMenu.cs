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
    public partial class JoinMenu : Form
    {
        public JoinMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoinProfessor f = new JoinProfessor();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoinStudent f = new JoinStudent();
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
