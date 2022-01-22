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
    public partial class FrmRegister : Form
    {
        public static string muggname, magname, gender, secretspell, email;
       
        public FrmRegister()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtName.Clear();
          
            txtEmail.Clear();
            txtPassword.Clear();
            txtComfirm.Clear();
        }

       

        public Boolean DataChecking()
        {
            string password = txtPassword.Text;

            if (txtName.Text == "")
            {
                MessageBox.Show(" Please enter User Name ", " Null Data ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("The password must be at least 8 characters");
                return false;
            }
            
            else if (txtEmail.Text == "")
            {
                MessageBox.Show(" Please enter Email", " NUll Data ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            else if (txtPassword.Text == "")
            {
                MessageBox.Show(" Please enter your secret spell", " NUll Data ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            else if (txtComfirm.Text == "")
            {
                MessageBox.Show(" Please Comfirm your secret spell", " NUll Data ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComfirm.Focus();
                return false;
            }

            else if (txtComfirm.Text != txtPassword.Text)
            {
                MessageBox.Show(" The spells are not march", "Not march", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            else

            {
                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void picSee_Click(object sender, EventArgs e)
        {

        }

        private void picUnsee_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)  
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DataChecking() == true)
                {

                    email = txtEmail.Text;
                    muggname = txtName.Text;
                    magname = txtWname.Text;
                    gender = cboGender.Text;
                    secretspell = txtPassword.Text;

                    MessageBox.Show("Welcome " + txtName.Text + ". Your account is created ! You have to choose your team");
                    this.Hide();
                    frmChooseTeam l = new frmChooseTeam();
                    l.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("This email already had an account !");
            }
            



        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmStart s = new frmStart();
            s.Show();
        }


    }
}