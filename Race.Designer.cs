namespace FirstAssignment
{
    partial class Race
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.so3 = new System.Windows.Forms.PictureBox();
            this.sonic = new System.Windows.Forms.PictureBox();
            this.so2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.so3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.so2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // so3
            // 
            this.so3.Image = global::FirstAssignment.Properties.Resources.flash_;
            this.so3.Location = new System.Drawing.Point(-245, 414);
            this.so3.Name = "so3";
            this.so3.Size = new System.Drawing.Size(423, 302);
            this.so3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.so3.TabIndex = 5;
            this.so3.TabStop = false;
            this.so3.Click += new System.EventHandler(this.so3_Click);
            // 
            // sonic
            // 
            this.sonic.Image = global::FirstAssignment.Properties.Resources.sonic2;
            this.sonic.Location = new System.Drawing.Point(-136, 31);
            this.sonic.Name = "sonic";
            this.sonic.Size = new System.Drawing.Size(257, 186);
            this.sonic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sonic.TabIndex = 0;
            this.sonic.TabStop = false;
            // 
            // so2
            // 
            this.so2.Image = global::FirstAssignment.Properties.Resources.GoldenSnitch_PM1;
            this.so2.Location = new System.Drawing.Point(-109, 279);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(198, 109);
            this.so2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.so2.TabIndex = 2;
            this.so2.TabStop = false;
            this.so2.Click += new System.EventHandler(this.so2_Click);
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1302, 709);
            this.Controls.Add(this.so3);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.sonic);
            this.Name = "Race";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUnn2";
            this.Load += new System.EventHandler(this.FUnn2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.so3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.so2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sonic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox so3;
        private System.Windows.Forms.PictureBox so2;
    }
}