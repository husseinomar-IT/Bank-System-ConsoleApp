namespace BankWindowsFormsApplication
{
    partial class FrmMainMenue
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTransactionManagment = new MaterialSkin.Controls.MaterialButton();
            this.btnClientMangment = new MaterialSkin.Controls.MaterialButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogOut = new MaterialSkin.Controls.MaterialButton();
            this.btnUsersMangment = new MaterialSkin.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(465, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 100);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Image = global::BankWindowsFormsApplication.Properties.Resources.Add_New_User1;
            this.pictureBox4.Location = new System.Drawing.Point(51, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(102, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Image = global::BankWindowsFormsApplication.Properties.Resources.Transactions;
            this.pictureBox2.Location = new System.Drawing.Point(51, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnTransactionManagment
            // 
            this.btnTransactionManagment.AutoSize = false;
            this.btnTransactionManagment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTransactionManagment.Depth = 0;
            this.btnTransactionManagment.DrawShadows = true;
            this.btnTransactionManagment.HighEmphasis = true;
            this.btnTransactionManagment.Icon = null;
            this.btnTransactionManagment.Location = new System.Drawing.Point(248, 18);
            this.btnTransactionManagment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTransactionManagment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTransactionManagment.Name = "btnTransactionManagment";
            this.btnTransactionManagment.Size = new System.Drawing.Size(168, 66);
            this.btnTransactionManagment.TabIndex = 0;
            this.btnTransactionManagment.Tag = "8";
            this.btnTransactionManagment.Text = "Transaction";
            this.btnTransactionManagment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTransactionManagment.UseAccentColor = false;
            this.btnTransactionManagment.UseVisualStyleBackColor = true;
            this.btnTransactionManagment.Click += new System.EventHandler(this.btnTransactionManagment_Click);
            // 
            // btnClientMangment
            // 
            this.btnClientMangment.AutoSize = false;
            this.btnClientMangment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientMangment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClientMangment.Depth = 0;
            this.btnClientMangment.DrawShadows = true;
            this.btnClientMangment.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientMangment.HighEmphasis = true;
            this.btnClientMangment.Icon = null;
            this.btnClientMangment.Location = new System.Drawing.Point(18, 18);
            this.btnClientMangment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClientMangment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientMangment.Name = "btnClientMangment";
            this.btnClientMangment.Size = new System.Drawing.Size(168, 66);
            this.btnClientMangment.TabIndex = 0;
            this.btnClientMangment.Tag = "2";
            this.btnClientMangment.Text = "Client Managment\r\n";
            this.btnClientMangment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClientMangment.UseAccentColor = false;
            this.btnClientMangment.UseVisualStyleBackColor = false;
            this.btnClientMangment.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.btnLogOut);
            this.panel4.Controls.Add(this.btnClientMangment);
            this.panel4.Controls.Add(this.btnUsersMangment);
            this.panel4.Controls.Add(this.btnTransactionManagment);
            this.panel4.Location = new System.Drawing.Point(207, 254);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(926, 100);
            this.panel4.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = false;
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.DrawShadows = true;
            this.btnLogOut.HighEmphasis = true;
            this.btnLogOut.Icon = null;
            this.btnLogOut.Location = new System.Drawing.Point(722, 18);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(168, 66);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Tag = "4";
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogOut.UseAccentColor = false;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUsersMangment
            // 
            this.btnUsersMangment.AutoSize = false;
            this.btnUsersMangment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsersMangment.Depth = 0;
            this.btnUsersMangment.DrawShadows = true;
            this.btnUsersMangment.HighEmphasis = true;
            this.btnUsersMangment.Icon = null;
            this.btnUsersMangment.Location = new System.Drawing.Point(485, 18);
            this.btnUsersMangment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUsersMangment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsersMangment.Name = "btnUsersMangment";
            this.btnUsersMangment.Size = new System.Drawing.Size(168, 66);
            this.btnUsersMangment.TabIndex = 0;
            this.btnUsersMangment.Tag = "4";
            this.btnUsersMangment.Text = "User Managment";
            this.btnUsersMangment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUsersMangment.UseAccentColor = false;
            this.btnUsersMangment.UseVisualStyleBackColor = true;
            this.btnUsersMangment.Click += new System.EventHandler(this.btnUsersMangment_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(210, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Location = new System.Drawing.Point(221, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 100);
            this.panel6.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 227);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Image = global::BankWindowsFormsApplication.Properties.Resources.Clients;
            this.pictureBox3.Location = new System.Drawing.Point(47, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Location = new System.Drawing.Point(207, 148);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(211, 100);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel8.Controls.Add(this.pictureBox5);
            this.panel8.Location = new System.Drawing.Point(919, 148);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(211, 100);
            this.panel8.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox5.Image = global::BankWindowsFormsApplication.Properties.Resources.Logout1;
            this.pictureBox5.Location = new System.Drawing.Point(51, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(102, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // FrmMainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 498);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "FrmMainMenue";
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.panel8, 0);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClientMangment;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialButton btnTransactionManagment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialButton btnUsersMangment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private MaterialSkin.Controls.MaterialButton btnLogOut;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox5;

    }
}
