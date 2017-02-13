using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeInterface
{
    public partial class Version : Form
    {
        public Version()
        {
            InitializeComponent();
            label3.Text = Convert.ToChar(169) + label3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Version_Load(object sender, EventArgs e)
        {

        }
    }
}
