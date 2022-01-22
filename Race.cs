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
    public partial class Race : Form
    {
        public Race()
        {
            InitializeComponent();
        }

        private void FUnn2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sonic.Location = new Point(sonic.Location.X + 18, sonic.Location.Y);
            so2.Location = new Point(so2.Location.X + 20, so2.Location.Y); 
            so3.Location = new Point(so3.Location.X + 17, so3.Location.Y);
        }

        private void so2_Click(object sender, EventArgs e)
        {

        }

        private void so3_Click(object sender, EventArgs e)
        {

        }
    }
}
