
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
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string content = rtContent.Text;
            string a = txtA.Text;
            string b = txtB.Text;
            string c = txtC.Text;
            string d = txtD.Text;
            string type = cbSubject.SelectedItem.ToString();
            if (type.Equals("Top Notch 1"))
                type = "TN1";
            if (type.Equals("Top Notch 2"))
                type = "TN2";
            if (type.Equals("Top Notch 3"))
                type = "TN3";
            if (type.Equals("summit 1"))
                type = "S1";
            //dap an
            string crr = "";
            if (rdA.Checked)
                crr = "_a";
            if (rdB.Checked)
                crr = "_b";
            if (rdC.Checked)
                crr = "_c";
            if (rdD.Checked)
                crr = "_d";
            DataProcess dt = new DataProcess();
            if (dt.AddQuestion(id, content, a, b, c, d, type, crr))
                MessageBox.Show("Them xong roi");
            else
                MessageBox.Show("len bang?");
        }
    }
}
