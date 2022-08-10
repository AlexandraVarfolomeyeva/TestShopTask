using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestShopTask
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(true);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(false);
            newForm.Show();
        }
    }
}
