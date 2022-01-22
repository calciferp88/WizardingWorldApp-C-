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
    public partial class frmQuestion : Form
    {
        public frmQuestion()
        { 
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void btnpre1_Click(object sender, EventArgs e)
        {
            

        }

        private void frmQuestion_Load(object sender, EventArgs e)
        {
           
        }

        private void btnNex2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuestion_Load_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnNext_Click_2(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); 
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
    }
}
