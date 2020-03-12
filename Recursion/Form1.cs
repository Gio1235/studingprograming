using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursion
{
    public partial class Form1 : Form
    {
        private int Sum = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sum = 1;
            label1.Text = recurs((int)numericUpDown1.Value).ToString();
        }

        private int recurs(int num)
        {
            if (num == 5)
                return 5;
            return num * recurs(num-1);
        }



    }
}
