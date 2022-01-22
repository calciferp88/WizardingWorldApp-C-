namespace FirstAssignment
{
    partial class frmLOgOUtWait
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.load2 = new System.Windows.Forms.TextBox();
            this.load1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // load2
            // 
            this.load2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.load2.Location = new System.Drawing.Point(231, -94);
            this.load2.Name = "load2";
            this.load2.Size = new System.Drawing.Size(46, 20);
            this.load2.TabIndex = 3;
            this.load2.Visible = false;
            // 
            // load1
            // 
            this.load1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.load1.Location = new System.Drawing.Point(231, -94);
            this.load1.Name = "load1";
            this.load1.Size = new System.Drawing.Size(710, 20);
            this.load1.TabIndex = 2;
            this.load1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(411, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logging out !  Please wait . . . ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstAssignment.Properties.Resources.giphy_2_4;
            this.pictureBox1.Location = new System.Drawing.Point(446, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLOgOUtWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1171, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load2);
            this.Controls.Add(this.load1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLOgOUtWait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "g";
            this.Load += new System.EventHandler(this.frmLOgOUtWait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox load2;
        private System.Windows.Forms.TextBox load1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;

    }
}