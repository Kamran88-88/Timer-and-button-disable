using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            var result = MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result==DialogResult.Yes)
            {
                user.Name = textBox1.Text;
                user.Password = textBox2.Text;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }


        }

        int number = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (number != 0&&textBox1.Text=="")
            {
                number--;
                label3.Text = number.ToString();
            }
            else if(textBox1.Text == "")
            {
                button1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }

    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
