using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dataentry
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (is_validate())
            {

                errorProvider1.Clear();
                
                if (txtusername.Text.Equals("Operator") && txtpassword.Text.Equals("demo"))
                {
                    frmdataentry f1 = new frmdataentry();
                    this.Hide();
                    f1.Show();
                }
                else
                {
                    txtusername.Text = txtpassword.Text = "";
                    MessageBox.Show("Login Fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool is_validate()
        {
            errorProvider1.Clear();
            bool no_error = true;

            if (!MyErrorProvider.charOnly(errorProvider1, txtusername, txtusername.Text))
                no_error = false;
            if (!MyErrorProvider.requireField(errorProvider1, txtusername, txtusername.Text))
                no_error = false;
            if (!MyErrorProvider.requireField(errorProvider1, txtpassword, txtpassword.Text))
                no_error = false;

            return no_error;
        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

    }
}
