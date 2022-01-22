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
    public partial class frmLOgOUtWait : Form
    {
        public frmLOgOUtWait()
        {
            InitializeComponent();
        }

        private void frmLOgOUtWait_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load2.Width += 35;

            if (load2.Width >= 710)
            {
                timer1.Stop();
                this.Hide();
                frmStart s = new frmStart();
                s.Show();
            }
        }
    }
}
