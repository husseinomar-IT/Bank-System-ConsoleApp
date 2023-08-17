namespace BankWindowsFormsApplication
{
    partial class FrmTransaction
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabDeposite = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnDeposit = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDepositAmount = new System.Windows.Forms.NumericUpDown();
            this.comboboxDepositAccountNumber = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblNewBalance = new System.Windows.Forms.Label();
            this.tabWithdraw = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnWithdraw = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nudWithdrawAmount = new System.Windows.Forms.NumericUpDown();
            this.comboboxwithdraw = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultWithdraw = new System.Windows.Forms.Label();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.TabTransfer = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnTransfer = new MaterialSkin.Controls.MaterialButton();
            this.nudTransaction = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxToAcc = new System.Windows.Forms.ComboBox();
            this.comboboxFromAcc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTrasfer = new System.Windows.Forms.Panel();
            this.TabTransferLog = new System.Windows.Forms.TabPage();
            this.dgvTransferLog = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TabDeposite.SuspendLayout();
            this.panel2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositAmount)).BeginInit();
            this.tabWithdraw.SuspendLayout();
            this.panel3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdrawAmount)).BeginInit();
            this.TabTransfer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransaction)).BeginInit();
            this.TabTransferLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabDeposite);
            this.tabControl1.Controls.Add(this.tabWithdraw);
            this.tabControl1.Controls.Add(this.TabTransfer);
            this.tabControl1.Controls.Add(this.TabTransferLog);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(197, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 487);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Tag = "Deposite";
            // 
            // TabDeposite
            // 
            this.TabDeposite.Controls.Add(this.panel2);
            this.TabDeposite.Controls.Add(this.lblResult);
            this.TabDeposite.Controls.Add(this.lblNewBalance);
            this.TabDeposite.Location = new System.Drawing.Point(4, 28);
            this.TabDeposite.Name = "TabDeposite";
            this.TabDeposite.Padding = new System.Windows.Forms.Padding(3);
            this.TabDeposite.Size = new System.Drawing.Size(735, 455);
            this.TabDeposite.TabIndex = 0;
            this.TabDeposite.Text = "Deposite";
            this.TabDeposite.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.materialCard1);
            this.panel2.Controls.Add(this.comboboxDepositAccountNumber);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(185, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 339);
            this.panel2.TabIndex = 42;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnDeposit);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.nudDepositAmount);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(55, 132);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(206, 167);
            this.materialCard1.TabIndex = 37;
            // 
            // btnDeposit
            // 
            this.btnDeposit.AutoSize = false;
            this.btnDeposit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeposit.Depth = 0;
            this.btnDeposit.DrawShadows = true;
            this.btnDeposit.HighEmphasis = true;
            this.btnDeposit.Icon = null;
            this.btnDeposit.Location = new System.Drawing.Point(21, 97);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeposit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(158, 36);
            this.btnDeposit.TabIndex = 39;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeposit.UseAccentColor = false;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Deposit Amount";
            // 
            // nudDepositAmount
            // 
            this.nudDepositAmount.Location = new System.Drawing.Point(17, 51);
            this.nudDepositAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudDepositAmount.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDepositAmount.Name = "nudDepositAmount";
            this.nudDepositAmount.Size = new System.Drawing.Size(168, 26);
            this.nudDepositAmount.TabIndex = 0;
            this.nudDepositAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // comboboxDepositAccountNumber
            // 
            this.comboboxDepositAccountNumber.FormattingEnabled = true;
            this.comboboxDepositAccountNumber.Location = new System.Drawing.Point(55, 66);
            this.comboboxDepositAccountNumber.Name = "comboboxDepositAccountNumber";
            this.comboboxDepositAccountNumber.Size = new System.Drawing.Size(195, 27);
            this.comboboxDepositAccountNumber.TabIndex = 36;
            this.comboboxDepositAccountNumber.SelectedIndexChanged += new System.EventHandler(this.comboboxDepositAccountNumber_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(51, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 22);
            this.label16.TabIndex = 35;
            this.label16.Text = "Acc Number:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResult.Location = new System.Drawing.Point(46, 44);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(165, 26);
            this.lblResult.TabIndex = 41;
            this.lblResult.Text = "New Balance =";
            // 
            // lblNewBalance
            // 
            this.lblNewBalance.AutoSize = true;
            this.lblNewBalance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewBalance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewBalance.Location = new System.Drawing.Point(305, 44);
            this.lblNewBalance.Name = "lblNewBalance";
            this.lblNewBalance.Size = new System.Drawing.Size(0, 26);
            this.lblNewBalance.TabIndex = 40;
            // 
            // tabWithdraw
            // 
            this.tabWithdraw.Controls.Add(this.panel3);
            this.tabWithdraw.Controls.Add(this.lblResultWithdraw);
            this.tabWithdraw.Controls.Add(this.lblCurrentBalance);
            this.tabWithdraw.Location = new System.Drawing.Point(4, 28);
            this.tabWithdraw.Name = "tabWithdraw";
            this.tabWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabWithdraw.Size = new System.Drawing.Size(735, 455);
            this.tabWithdraw.TabIndex = 1;
            this.tabWithdraw.Text = "Withdraw";
            this.tabWithdraw.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.materialCard2);
            this.panel3.Controls.Add(this.comboboxwithdraw);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(186, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 339);
            this.panel3.TabIndex = 45;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnWithdraw);
            this.materialCard2.Controls.Add(this.label3);
            this.materialCard2.Controls.Add(this.nudWithdrawAmount);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(64, 131);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(206, 167);
            this.materialCard2.TabIndex = 37;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.AutoSize = false;
            this.btnWithdraw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWithdraw.Depth = 0;
            this.btnWithdraw.DrawShadows = true;
            this.btnWithdraw.HighEmphasis = true;
            this.btnWithdraw.Icon = null;
            this.btnWithdraw.Location = new System.Drawing.Point(21, 97);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWithdraw.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(158, 36);
            this.btnWithdraw.TabIndex = 39;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWithdraw.UseAccentColor = false;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Withdraw Amount";
            // 
            // nudWithdrawAmount
            // 
            this.nudWithdrawAmount.Location = new System.Drawing.Point(17, 51);
            this.nudWithdrawAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudWithdrawAmount.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudWithdrawAmount.Name = "nudWithdrawAmount";
            this.nudWithdrawAmount.Size = new System.Drawing.Size(168, 26);
            this.nudWithdrawAmount.TabIndex = 0;
            this.nudWithdrawAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudWithdrawAmount.Validating += new System.ComponentModel.CancelEventHandler(this.nudWithdrawAmount_Validating);
            // 
            // comboboxwithdraw
            // 
            this.comboboxwithdraw.FormattingEnabled = true;
            this.comboboxwithdraw.Location = new System.Drawing.Point(64, 55);
            this.comboboxwithdraw.Name = "comboboxwithdraw";
            this.comboboxwithdraw.Size = new System.Drawing.Size(206, 27);
            this.comboboxwithdraw.TabIndex = 36;
            this.comboboxwithdraw.SelectedIndexChanged += new System.EventHandler(this.comboboxwithdraw_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Acc Number:";
            // 
            // lblResultWithdraw
            // 
            this.lblResultWithdraw.AutoSize = true;
            this.lblResultWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.lblResultWithdraw.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResultWithdraw.Location = new System.Drawing.Point(49, 41);
            this.lblResultWithdraw.Name = "lblResultWithdraw";
            this.lblResultWithdraw.Size = new System.Drawing.Size(204, 26);
            this.lblResultWithdraw.TabIndex = 44;
            this.lblResultWithdraw.Text = "Current Balance =";
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.BackColor = System.Drawing.Color.Black;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentBalance.Location = new System.Drawing.Point(308, 41);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(0, 31);
            this.lblCurrentBalance.TabIndex = 43;
            // 
            // TabTransfer
            // 
            this.TabTransfer.Controls.Add(this.panel4);
            this.TabTransfer.Location = new System.Drawing.Point(4, 28);
            this.TabTransfer.Name = "TabTransfer";
            this.TabTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.TabTransfer.Size = new System.Drawing.Size(735, 455);
            this.TabTransfer.TabIndex = 2;
            this.TabTransfer.Text = "Transfer";
            this.TabTransfer.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.materialCard3);
            this.panel4.Location = new System.Drawing.Point(32, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(684, 427);
            this.panel4.TabIndex = 1;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnTransfer);
            this.materialCard3.Controls.Add(this.nudTransaction);
            this.materialCard3.Controls.Add(this.label7);
            this.materialCard3.Controls.Add(this.comboBoxToAcc);
            this.materialCard3.Controls.Add(this.comboboxFromAcc);
            this.materialCard3.Controls.Add(this.label6);
            this.materialCard3.Controls.Add(this.label5);
            this.materialCard3.Controls.Add(this.panelTrasfer);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(85, 37);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(508, 375);
            this.materialCard3.TabIndex = 0;
            // 
            // btnTransfer
            // 
            this.btnTransfer.AutoSize = false;
            this.btnTransfer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTransfer.Depth = 0;
            this.btnTransfer.DrawShadows = true;
            this.btnTransfer.HighEmphasis = true;
            this.btnTransfer.Icon = null;
            this.btnTransfer.Location = new System.Drawing.Point(186, 264);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTransfer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(146, 38);
            this.btnTransfer.TabIndex = 45;
            this.btnTransfer.Text = "Transfer\r\n";
            this.btnTransfer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTransfer.UseAccentColor = false;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // nudTransaction
            // 
            this.nudTransaction.Location = new System.Drawing.Point(186, 213);
            this.nudTransaction.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTransaction.Name = "nudTransaction";
            this.nudTransaction.Size = new System.Drawing.Size(146, 26);
            this.nudTransaction.TabIndex = 44;
            this.nudTransaction.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(182, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Amount";
            // 
            // comboBoxToAcc
            // 
            this.comboBoxToAcc.FormattingEnabled = true;
            this.comboBoxToAcc.Location = new System.Drawing.Point(331, 59);
            this.comboBoxToAcc.Name = "comboBoxToAcc";
            this.comboBoxToAcc.Size = new System.Drawing.Size(158, 27);
            this.comboBoxToAcc.TabIndex = 42;
            this.comboBoxToAcc.SelectedIndexChanged += new System.EventHandler(this.comboBoxToAcc_SelectedIndexChanged);
            // 
            // comboboxFromAcc
            // 
            this.comboboxFromAcc.FormattingEnabled = true;
            this.comboboxFromAcc.Location = new System.Drawing.Point(17, 59);
            this.comboboxFromAcc.Name = "comboboxFromAcc";
            this.comboboxFromAcc.Size = new System.Drawing.Size(158, 27);
            this.comboboxFromAcc.TabIndex = 41;
            this.comboboxFromAcc.SelectedIndexChanged += new System.EventHandler(this.comboboxFromAcc_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(327, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "To Acc.Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "From Acc.Number";
            // 
            // panelTrasfer
            // 
            this.panelTrasfer.BackColor = System.Drawing.Color.White;
            this.panelTrasfer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTrasfer.Location = new System.Drawing.Point(156, 154);
            this.panelTrasfer.Name = "panelTrasfer";
            this.panelTrasfer.Size = new System.Drawing.Size(200, 181);
            this.panelTrasfer.TabIndex = 46;
            // 
            // TabTransferLog
            // 
            this.TabTransferLog.Controls.Add(this.dgvTransferLog);
            this.TabTransferLog.Location = new System.Drawing.Point(4, 28);
            this.TabTransferLog.Name = "TabTransferLog";
            this.TabTransferLog.Padding = new System.Windows.Forms.Padding(3);
            this.TabTransferLog.Size = new System.Drawing.Size(735, 455);
            this.TabTransferLog.TabIndex = 3;
            this.TabTransferLog.Text = "TransferLog";
            this.TabTransferLog.UseVisualStyleBackColor = true;
            // 
            // dgvTransferLog
            // 
            this.dgvTransferLog.AllowUserToAddRows = false;
            this.dgvTransferLog.AllowUserToDeleteRows = false;
            this.dgvTransferLog.AllowUserToOrderColumns = true;
            this.dgvTransferLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferLog.Location = new System.Drawing.Point(25, 108);
            this.dgvTransferLog.Name = "dgvTransferLog";
            this.dgvTransferLog.ReadOnly = true;
            this.dgvTransferLog.Size = new System.Drawing.Size(667, 262);
            this.dgvTransferLog.TabIndex = 0;
            // 
            // FrmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(941, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmTransaction";
            this.Load += new System.EventHandler(this.FrmTransaction_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.TabDeposite.ResumeLayout(false);
            this.TabDeposite.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositAmount)).EndInit();
            this.tabWithdraw.ResumeLayout(false);
            this.tabWithdraw.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdrawAmount)).EndInit();
            this.TabTransfer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransaction)).EndInit();
            this.TabTransferLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabDeposite;
        private System.Windows.Forms.TabPage tabWithdraw;
        private System.Windows.Forms.TabPage TabTransfer;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDepositAmount;
        private System.Windows.Forms.ComboBox comboboxDepositAccountNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblNewBalance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWithdrawAmount;
        private System.Windows.Forms.ComboBox comboboxwithdraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultWithdraw;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.ComboBox comboBoxToAcc;
        private System.Windows.Forms.ComboBox comboboxFromAcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton btnTransfer;
        private System.Windows.Forms.NumericUpDown nudTransaction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelTrasfer;
        private System.Windows.Forms.TabPage TabTransferLog;
        private System.Windows.Forms.DataGridView dgvTransferLog;
    }
}
