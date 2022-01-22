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

    public partial class frmMain : Form

    {
        Potter_DSTableAdapters.UserDetailsTableAdapter pf = new Potter_DSTableAdapters.UserDetailsTableAdapter();

        public frmMain()

        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void myProfile1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void setting1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLOgOUtWait l = new frmLOgOUtWait();
            l.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        { 
            DataTable dt = new DataTable();
            dt = pf.UserLogin(frmUserLogin.email, frmUserLogin.password);

            mugglename.Text = dt.Rows[0][1].ToString();
            gender.Text = dt.Rows[0][3].ToString();

            teamvv.Text = dt.Rows[0][5].ToString();
            Email.Text = dt.Rows[0][2].ToString();
            lblPanelName.Text = dt.Rows[0][0].ToString();
            llteam.Text = dt.Rows[0][5].ToString();
            lblname.Text = dt.Rows[0][0].ToString();
            team.Text = dt.Rows[0][5].ToString();

            if ( team.Text == "Gryffindor")
            {
                picGryffindor.Visible = true;
                llteam.ForeColor = Color.OrangeRed;
            }
            else if (team.Text == "Ravenclaw")
            {
                picRavenclaw.Visible = true;
                llteam.ForeColor = Color.Blue;
                
            }
            else if (  team.Text == "Hufflepuff")
            {
                picHufflepuff.Visible = true;
                llteam.ForeColor = Color.Yellow;
            }
            else if (  team.Text == "Slytherin")
            {
                picSlytherin.Visible = true;
                llteam.ForeColor = Color.DarkGreen;
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void picSlytherin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.White;
            btnNewFeed.ForeColor = Color.White;
            btnSeArch.ForeColor = Color.White;
            btnGames.ForeColor = Color.Blue;
            BtnSpell.ForeColor = Color.White;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlProfile.Visible = true;
            pnlSearch.Visible = false;

            btnProfile.ForeColor = Color.Blue;
            btnNewFeed.ForeColor = Color.White;
            btnSeArch.ForeColor = Color.White;
            btnGames.ForeColor = Color.White;
            BtnSpell.ForeColor = Color.White;

        }

        private void lblname_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLOgOUtWait l = new frmLOgOUtWait();
            l.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.White;
            btnNewFeed.ForeColor = Color.White;
            btnSeArch.ForeColor = Color.Blue;
            btnGames.ForeColor = Color.White;
            BtnSpell.ForeColor = Color.White;

            pnlSearch.Visible = true;
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnNewFeed_Click(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.White;
            btnNewFeed.ForeColor = Color.Blue;
            btnSeArch.ForeColor = Color.White;
            btnGames.ForeColor = Color.White;
            BtnSpell.ForeColor = Color.White;
        }

        private void BtnSpell_Click(object sender, EventArgs e)
        {

            btnProfile.ForeColor = Color.White;
            btnNewFeed.ForeColor = Color.White;
            btnSeArch.ForeColor = Color.White;
            btnGames.ForeColor = Color.White;
            BtnSpell.ForeColor = Color.Blue;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

            btnProfile.ForeColor = Color.White;
            btnNewFeed.ForeColor = Color.White;
            btnSeArch.ForeColor = Color.White;
            btnGames.ForeColor = Color.White;
            BtnSpell.ForeColor = Color.White;

        }
    }
}
