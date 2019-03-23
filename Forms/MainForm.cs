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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            //loginForm.Parent = this;
            loginForm.Show();
            this.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
