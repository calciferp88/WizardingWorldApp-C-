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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            this.Hide();
            sure s = new sure();
            s.Show();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegister a = new FrmRegister();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCreat_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmUserLogin fl = new frmUserLogin();
            fl.Show();
            this.Hide();
        }

        private void lblCreat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister fr = new FrmRegister();
            fr.Show();
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            sure s = new sure();
            s.Show();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( snitch.Location.X < -40 )
            {
                 snitch.Location = new Point(snitch.Location.X + 5, snitch.Location.Y);
            }
            else if (snitch.Location.X == 283)
            {

                snitch.Location = new Point(snitch.Location.X -5, snitch.Location.Y);
            }
        }
    }
}
