using System;
using System.Windows.Forms;

namespace WindowsFormsAppLab1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Choose one!!",
            "Select an Item", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                textBox1.Text = "NO".ToUpper();
            }
            else if (result == DialogResult.Yes)
            {
                textBox1.Text = "YES".ToUpper();
            }
            else if (result == DialogResult.Cancel)
            {
                textBox1.Text = "Cancel".ToUpper();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Choose one!!", "Select an Item",
            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);

            if (Result == DialogResult.Abort)
            {
                textBox1.Text = "Abort".ToUpper();
            }
            else if (Result == DialogResult.Retry)
            {
                textBox1.Text = "Retry".ToUpper();
            }
            else if (Result == DialogResult.Ignore)
            {
                textBox1.Text = "Ignore".ToUpper();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = string.Empty;
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "bmp|*.bmp|gif|*.gif|jpeg|*.jpg|cpp|*.cpp|universal|*.*";
                fileDialog.InitialDirectory = "E:\\";
                fileDialog.ShowDialog();
                filename = fileDialog.SafeFileName;
                filename = fileDialog.FileName;
                textBox1.Text = filename;
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            string radiotxt = "";
            if (fr2.radioButton1.Checked == true)
            {
                radiotxt = fr2.radioButton1.Text;
            }
            else if (fr2.radioButton2.Checked == true)
            {
                radiotxt = fr2.radioButton2.Text;
            }
            else if (fr2.radioButton3.Checked == true)
            {
                radiotxt = fr2.radioButton3.Text;
            }
            else if (fr2.radioButton4.Checked == true)
            {
                radiotxt = fr2.radioButton4.Text;
            }
            textBox1.Text = radiotxt;
        }
    }
}
