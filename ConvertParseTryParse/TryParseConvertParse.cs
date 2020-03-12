using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertParseTryParse
{
    public partial class TryParseConvertParse : Form
    {
        public TryParseConvertParse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          int res    = int.TryParse(textBox1.Text, out res) ? res : 0;
            label1.Text = res.ToString();
        }
    }
}
