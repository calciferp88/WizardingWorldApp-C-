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
    public partial class frmChooseTeam : Form
    {
        public static string team;

        Potter_DSTableAdapters.UserDetailsTableAdapter ur = new Potter_DSTableAdapters.UserDetailsTableAdapter();


        public frmChooseTeam()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                team = "Gryffindor";
                ur.Insert(magname.Text, mugname.Text, email.Text, gender.Text, spell.Text, team);
                this.Hide();
                frmCreatingWait c = new frmCreatingWait();
                c.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Sorry! This email already had an account");
                MessageBox.Show("Please use a different email");
                this.Hide();
                FrmRegister r = new FrmRegister();
                r.Show();
            }
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            team = "Ravenclaw";
            ur.Insert(magname.Text, mugname.Text, email.Text, gender.Text, spell.Text, team);
            this.Hide();
            frmCreatingWait c = new frmCreatingWait();
            c.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            team = "Hufflepuff";
            ur.Insert(magname.Text, mugname.Text, email.Text, gender.Text, spell.Text, team);
            this.Hide();
            frmCreatingWait c = new frmCreatingWait();
            c.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            team = "Slytherin";
            ur.Insert(magname.Text, mugname.Text, email.Text, gender.Text, spell.Text, team);
            this.Hide();
            frmCreatingWait c = new frmCreatingWait();
            c.Show();
        }

        private void frmChooseTeam_Load(object sender, EventArgs e)
        {
            email.Text = FrmRegister.email;
            mugname.Text = FrmRegister.muggname;
            magname.Text = FrmRegister.magname;
            gender.Text = FrmRegister.gender;
            spell.Text = FrmRegister.secretspell;
        }
    }
}
