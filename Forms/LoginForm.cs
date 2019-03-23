using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgSolutions.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBox2.TextChanged+=textBox2_TextChanged;
            textBox1.MouseClick += textBoxMouseClick;
            textBox2.MouseClick += textBoxMouseClick;
            this.MouseClick += LoginForm_MouseClick;
        }

        void LoginForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox1.Text.Length == 0)
                textBox1.Text = "Enter your email address";
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "Enter your password";
                textBox2.UseSystemPasswordChar = false;
            }
        }

        void textBoxMouseClick(object sender, MouseEventArgs e)
        {
            if (sender.Equals(textBox1))
            {
                textBox1.Text = "";
            }
            if (sender.Equals(textBox2))
            {
                textBox2.Text = "";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MarathonContext db = new MarathonContext())
            {
                try
                {
                    User u = db.Users.Find(textBox1.Text);
                    if (u.Password.Equals(textBox2.Text))
                    {
                        MessageBox.Show("success");
                    }
                    else
                    {
                        MessageBox.Show("something's went wrong...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("something's went wrong...\nno similar email");
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }
    }
}
