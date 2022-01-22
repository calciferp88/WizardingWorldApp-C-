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

    public partial class frmCreatingWait : Form
    {
        public frmCreatingWait()
        {
            InitializeComponent();
        }

        private void frmCreatingWait_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            load2.Width += 45;

            if (load2.Width >= 710)
            {
                timer1.Stop();
                this.Hide();
                frmUserLogin s = new frmUserLogin();
                s.Show();
            }
        }

        private void load2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
