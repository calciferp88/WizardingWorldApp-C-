using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAssignment
{
    public partial class frmUserLogin : Form
    {
        public static string email, password;

        Potter_DSTableAdapters.UserDetailsTableAdapter ut = new Potter_DSTableAdapters.UserDetailsTableAdapter();

        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void frmUserLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister f = new FrmRegister();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
           
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter Email", "Null Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }

            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Password", "Null Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = ut.UserLogin(txtEmail.Text, txtPassword.Text);
                try
                {

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Successfully Log In ! ", "Welcome");
                        email = txtEmail.Text;
                        password = txtPassword.Text;

                        this.Hide();
                        frmDelay fm = new frmDelay();
                        fm.Show();
                    }

                    else
                    {
                        MessageBox.Show("The Email or Password is wrong. Please try again ! ", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Clear();
                        txtPassword.Clear();
                        txtEmail.Focus();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Sorry ! Unknown error is occured ");
                }


            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
            frmStart fs = new frmStart();
            fs.Show();
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmRegister fr = new FrmRegister();
            fr.Show();
        }

        private void picHide_Click_1(object sender, EventArgs e)
        {
        }

        private void picUnHide_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
         
        
    }
}
