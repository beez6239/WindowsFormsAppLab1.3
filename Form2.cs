using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab1._3
{
    public partial class Form2 : Form
    {



        Form1 fr1 = new Form1();

        public Form2()
        {
            InitializeComponent();

            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            (this.Owner as Form1).custom1.Enabled = true;
            (this.Owner as Form1).textBox1.Text = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public  void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
    
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                fr1.textBox1.Text = radioButton1.Text;
            }
            

        }
      
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                fr1.textBox1.Text = radioButton1.Text;
            }
            
            
        }
       
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                fr1.custom1.Text = radioButton1.Text;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                fr1.textBox1.Text = radioButton1.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
