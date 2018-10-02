using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOnline
{
    public partial class Form1 : Form
    {
        private bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gia thiet loc in thanh cong
            flag = true;
            if(flag)
            {
                tpFunciton.Enabled = flag;
                tpReport.Enabled = flag;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddQuestion add = new AddQuestion();
            //add.Show();
            AddQuestion add = new AddQuestion();
            add.MdiParent = this;
            add.Show();
        }

        private void manageQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ManageQuestion mn = new ManageQuestion();
            //mn.Show();
            ManageQuestion mn = new ManageQuestion();
            mn.MdiParent = this;
            mn.Show();
        }
    }
}
