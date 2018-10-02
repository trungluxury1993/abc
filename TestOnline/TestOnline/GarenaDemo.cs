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
    public partial class GarenaDemo : Form
    {
        public GarenaDemo()
        {
            InitializeComponent();
        }

        private void GarenaDemo_Load(object sender, EventArgs e)
        {
            Loading ld = new Loading();
            ld.ShowDialog();
        }
    }
}
