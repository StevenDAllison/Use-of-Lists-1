using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_of_Lists_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<int> nums = new List<int>();
            nums.Add(3);
            nums.Add(5);
            nums.Add(3);
            printNums(nums);
            nums.Remove(3);
            printNums(nums);
            nums.Add(47);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void printNums(List<int> ns)
        {
            foreach (int i in ns)
            {
                richTextBox1.AppendText(i + ", ");
                
            }
            richTextBox1.AppendText("\n===============\n");
        }
    }
}
