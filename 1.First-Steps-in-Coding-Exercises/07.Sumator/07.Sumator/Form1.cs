using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07.Sumator
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(this.textBox1.Text);
                int num2 = int.Parse(this.textBox2.Text);
                int sum = num1 + num2;
                textBoxSum.Text = sum.ToString();
            }
            catch(Exception)
            {
                textBoxSum.Text = "error";
            }
            

        }
    }
}
