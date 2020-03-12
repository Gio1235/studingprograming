using ConvertParseTryParse;
using QueueAndStack;
using Structs;
using System;
using System.Windows.Forms;

namespace MainProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTryParse_Click(object sender, EventArgs e)
        {
            var frm = new TryParseConvertParse();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new StructForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new QueueAndStackForm();
            frm.Show();
        }
    }
}
