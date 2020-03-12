using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueAndStack
{
    public partial class QueueAndStackForm : Form
    {
        Queue qu = new Queue();
        Stack st = new Stack();
        Dictionary<int, string> myDict = new Dictionary<int, string>();
        LinkedList<int> llist = new LinkedList<int>();
        List<int> list = new List<int>();
        public QueueAndStackForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //qu.Enqueue(numericUpDown1.Value);
            //qu.Enqueue("string");
            st.Push(numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //textBox2.Text = qu.Peek().ToString();
            textBox2.Text = st.Peek().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            st.Pop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myDict.Add((int)numericUpDown1.Value, textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
     
                llist.AddFirst(1);
                llist.AddFirst(2);
                llist.AddLast(4);
                llist.AddBefore(llist.Find(4), 100);
  
        }
    }
}
