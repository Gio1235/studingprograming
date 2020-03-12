using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structs
{
    public partial class StructForm : Form
    {
        public StructForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var s = new Class1();
            //s.X = 2;
            //s.Y = 11;

            //var ob = new Struct1();
            //Struct1 a;
            //int adffd = 0;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var s = new Class1();
            textBox1.Text = s.MethodInClass(10,2).ToString();
        }
    }
}
