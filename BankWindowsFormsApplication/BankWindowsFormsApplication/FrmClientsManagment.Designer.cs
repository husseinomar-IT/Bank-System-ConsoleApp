namespace BankWindowsFormsApplication
{
    partial class FrmClientsManagment
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabShowClients = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbDesOrder = new System.Windows.Forms.RadioButton();
            this.rdbtnAscOrder = new System.Windows.Forms.RadioButton();
            this.dgvClientList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAddNewClient = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numClientAUpDownAddBalance = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClientAddPINCode = new System.Windows.Forms.TextBox();
            this.txtClientAddPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientAddLastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientAddAccountNumber = new System.Windows.Forms.TextBox();
            this.txtClientAddEmail = new System.Windows.Forms.TextBox();
            this.txtClientAddFirstname = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAddnewClient = new MaterialSkin.Controls.MaterialButton();
            this.UpdateTap = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.combAccountNumber = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nudUpdateClientBalnce = new System.Windows.Forms.NumericUpDown();
            this.txtClientUpdateAccountnumber = new System.Windows.Forms.TextBox();
            this.txtClientUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtClientUpdateFirstname = new System.Windows.Forms.TextBox();
            this.txtClientUpdatePINCode = new System.Windows.Forms.TextBox();
            this.txtClientUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtClientUpdateLastname = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabShowClients.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabAddNewClient.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClientAUpDownAddBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.UpdateTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateClientBalnce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabShowClients);
            this.tabControl1.Controls.Add(this.tabAddNewClient);
            this.tabControl1.Controls.Add(this.UpdateTap);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(197, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 485);
            this.tabControl1.TabIndex = 1;
            // 
            // tabShowClients
            // 
            this.tabShowClients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabShowClients.Controls.Add(this.groupBox4);
            this.tabShowClients.Controls.Add(this.groupBox3);
            this.tabShowClients.Controls.Add(this.dgvClientList);
            this.tabShowClients.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabShowClients.Location = new System.Drawing.Point(4, 28);
            this.tabShowClients.Name = "tabShowClients";
            this.tabShowClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowClients.Size = new System.Drawing.Size(792, 453);
            this.tabShowClients.TabIndex = 0;
            this.tabShowClients.Text = "Find";
            this.tabShowClients.Click += new System.EventHandler(this.tabShowClients_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.txtAccountNumber);
            this.groupBox4.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(303, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ادخل رقم الحساب ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = global::BankWindowsFormsApplication.Properties.Resources.search1;
            this.pictureBox2.Location = new System.Drawing.Point(6, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(62, 42);
            this.txtAccountNumber.Multiline = true;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(235, 28);
            this.txtAccountNumber.TabIndex = 2;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDesOrder);
            this.groupBox3.Controls.Add(this.rdbtnAscOrder);
            this.groupBox3.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(418, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(303, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ترتيب ";
            // 
            // rdbDesOrder
            // 
            this.rdbDesOrder.AutoSize = true;
            this.rdbDesOrder.Location = new System.Drawing.Point(198, 39);
            this.rdbDesOrder.Name = "rdbDesOrder";
            this.rdbDesOrder.Size = new System.Drawing.Size(67, 41);
            this.rdbDesOrder.TabIndex = 1;
            this.rdbDesOrder.TabStop = true;
            this.rdbDesOrder.Text = "تنازلي";
            this.rdbDesOrder.UseVisualStyleBackColor = true;
            this.rdbDesOrder.CheckedChanged += new System.EventHandler(this.rdbDesOrder_CheckedChanged);
            // 
            // rdbtnAscOrder
            // 
            this.rdbtnAscOrder.AutoSize = true;
            this.rdbtnAscOrder.Location = new System.Drawing.Point(30, 39);
            this.rdbtnAscOrder.Name = "rdbtnAscOrder";
            this.rdbtnAscOrder.Size = new System.Drawing.Size(92, 41);
            this.rdbtnAscOrder.TabIndex = 0;
            this.rdbtnAscOrder.TabStop = true;
            this.rdbtnAscOrder.Text = "تصاعدي";
            this.rdbtnAscOrder.UseVisualStyleBackColor = true;
            this.rdbtnAscOrder.CheckedChanged += new System.EventHandler(this.rdbtnAscOrder_CheckedChanged);
            // 
            // dgvClientList
            // 
            this.dgvClientList.AllowUserToAddRows = false;
            this.dgvClientList.AllowUserToDeleteRows = false;
            this.dgvClientList.AllowUserToOrderColumns = true;
            this.dgvClientList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvClientList.Location = new System.Drawing.Point(6, 206);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.ReadOnly = true;
            this.dgvClientList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvClientList.Size = new System.Drawing.Size(735, 247);
            this.dgvClientList.TabIndex = 0;
            this.dgvClientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientList_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::BankWindowsFormsApplication.Properties.Resources.small_Delete_Person1;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // tabAddNewClient
            // 
            this.tabAddNewClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabAddNewClient.Controls.Add(this.panel2);
            this.tabAddNewClient.Controls.Add(this.pictureBox3);
            this.tabAddNewClient.Controls.Add(this.btnAddnewClient);
            this.tabAddNewClient.Location = new System.Drawing.Point(4, 28);
            this.tabAddNewClient.Name = "tabAddNewClient";
            this.tabAddNewClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddNewClient.Size = new System.Drawing.Size(792, 453);
            this.tabAddNewClient.TabIndex = 1;
            this.tabAddNewClient.Text = "Add";
            this.tabAddNewClient.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.numClientAUpDownAddBalance);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtClientAddPINCode);
            this.panel2.Controls.Add(this.txtClientAddPhone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtClientAddLastname);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtClientAddAccountNumber);
            this.panel2.Controls.Add(this.txtClientAddEmail);
            this.panel2.Controls.Add(this.txtClientAddFirstname);
            this.panel2.Location = new System.Drawing.Point(24, 155);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(735, 248);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // numClientAUpDownAddBalance
            // 
            this.numClientAUpDownAddBalance.Location = new System.Drawing.Point(282, 204);
            this.numClientAUpDownAddBalance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numClientAUpDownAddBalance.Name = "numClientAUpDownAddBalance";
            this.numClientAUpDownAddBalance.Size = new System.Drawing.Size(214, 26);
            this.numClientAUpDownAddBalance.TabIndex = 26;
            this.numClientAUpDownAddBalance.Validating += new System.ComponentModel.CancelEventHandler(this.numClientAUpDownAddBalance_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(149, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(378, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "PINCode:";
            // 
            // txtClientAddPINCode
            // 
            this.txtClientAddPINCode.Location = new System.Drawing.Point(485, 147);
            this.txtClientAddPINCode.Multiline = true;
            this.txtClientAddPINCode.Name = "txtClientAddPINCode";
            this.txtClientAddPINCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientAddPINCode.Size = new System.Drawing.Size(214, 36);
            this.txtClientAddPINCode.TabIndex = 15;
            this.txtClientAddPINCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtClientAddPhone
            // 
            this.txtClientAddPhone.Location = new System.Drawing.Point(485, 81);
            this.txtClientAddPhone.Multiline = true;
            this.txtClientAddPhone.Name = "txtClientAddPhone";
            this.txtClientAddPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientAddPhone.Size = new System.Drawing.Size(214, 36);
            this.txtClientAddPhone.TabIndex = 14;
            this.txtClientAddPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(368, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "LastName:";
            // 
            // txtClientAddLastname
            // 
            this.txtClientAddLastname.Location = new System.Drawing.Point(485, 17);
            this.txtClientAddLastname.Multiline = true;
            this.txtClientAddLastname.Name = "txtClientAddLastname";
            this.txtClientAddLastname.Size = new System.Drawing.Size(214, 36);
            this.txtClientAddLastname.TabIndex = 13;
            this.txtClientAddLastname.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(382, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "AccNumber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "FirstName:";
            // 
            // txtClientAddAccountNumber
            // 
            this.txtClientAddAccountNumber.Location = new System.Drawing.Point(134, 147);
            this.txtClientAddAccountNumber.Multiline = true;
            this.txtClientAddAccountNumber.Name = "txtClientAddAccountNumber";
            this.txtClientAddAccountNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientAddAccountNumber.Size = new System.Drawing.Size(214, 36);
            this.txtClientAddAccountNumber.TabIndex = 18;
            this.txtClientAddAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtClientAddEmail
            // 
            this.txtClientAddEmail.Location = new System.Drawing.Point(134, 81);
            this.txtClientAddEmail.Multiline = true;
            this.txtClientAddEmail.Name = "txtClientAddEmail";
            this.txtClientAddEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientAddEmail.Size = new System.Drawing.Size(214, 36);
            this.txtClientAddEmail.TabIndex = 17;
            this.txtClientAddEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtClientAddFirstname
            // 
            this.txtClientAddFirstname.BackColor = System.Drawing.SystemColors.Window;
            this.txtClientAddFirstname.Location = new System.Drawing.Point(134, 17);
            this.txtClientAddFirstname.Multiline = true;
            this.txtClientAddFirstname.Name = "txtClientAddFirstname";
            this.txtClientAddFirstname.Size = new System.Drawing.Size(214, 36);
            this.txtClientAddFirstname.TabIndex = 16;
            this.txtClientAddFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BankWindowsFormsApplication.Properties.Resources.Add_New;
            this.pictureBox3.Location = new System.Drawing.Point(278, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 139);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // btnAddnewClient
            // 
            this.btnAddnewClient.AutoSize = false;
            this.btnAddnewClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddnewClient.Depth = 0;
            this.btnAddnewClient.DrawShadows = true;
            this.btnAddnewClient.HighEmphasis = true;
            this.btnAddnewClient.Icon = null;
            this.btnAddnewClient.Location = new System.Drawing.Point(253, 409);
            this.btnAddnewClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddnewClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddnewClient.Name = "btnAddnewClient";
            this.btnAddnewClient.Size = new System.Drawing.Size(207, 38);
            this.btnAddnewClient.TabIndex = 15;
            this.btnAddnewClient.Text = "اضافة عميل";
            this.btnAddnewClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddnewClient.UseAccentColor = false;
            this.btnAddnewClient.UseVisualStyleBackColor = true;
            this.btnAddnewClient.Click += new System.EventHandler(this.btnAddnewClient_Click);
            // 
            // UpdateTap
            // 
            this.UpdateTap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateTap.Controls.Add(this.materialButton1);
            this.UpdateTap.Controls.Add(this.pictureBox4);
            this.UpdateTap.Controls.Add(this.label16);
            this.UpdateTap.Controls.Add(this.combAccountNumber);
            this.UpdateTap.Controls.Add(this.panel3);
            this.UpdateTap.Location = new System.Drawing.Point(4, 28);
            this.UpdateTap.Name = "UpdateTap";
            this.UpdateTap.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTap.Size = new System.Drawing.Size(792, 453);
            this.UpdateTap.TabIndex = 2;
            this.UpdateTap.Text = "Update";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(281, 397);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(189, 47);
            this.materialButton1.TabIndex = 36;
            this.materialButton1.Text = "Update";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BankWindowsFormsApplication.Properties.Resources.Update_Profile_1;
            this.pictureBox4.Location = new System.Drawing.Point(324, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 96);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(20, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 22);
            this.label16.TabIndex = 34;
            this.label16.Text = "Select:";
            // 
            // combAccountNumber
            // 
            this.combAccountNumber.FormattingEnabled = true;
            this.combAccountNumber.Location = new System.Drawing.Point(97, 97);
            this.combAccountNumber.Name = "combAccountNumber";
            this.combAccountNumber.Size = new System.Drawing.Size(168, 27);
            this.combAccountNumber.TabIndex = 19;
            this.combAccountNumber.SelectedIndexChanged += new System.EventHandler(this.combAccountNumber_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.nudUpdateClientBalnce);
            this.panel3.Controls.Add(this.txtClientUpdateAccountnumber);
            this.panel3.Controls.Add(this.txtClientUpdateEmail);
            this.panel3.Controls.Add(this.txtClientUpdateFirstname);
            this.panel3.Controls.Add(this.txtClientUpdatePINCode);
            this.panel3.Controls.Add(this.txtClientUpdatePhone);
            this.panel3.Controls.Add(this.txtClientUpdateLastname);
            this.panel3.Location = new System.Drawing.Point(24, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 247);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(196, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 33;
            this.label9.Text = "Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(376, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 22);
            this.label10.TabIndex = 32;
            this.label10.Text = "PINCode:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(369, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 22);
            this.label11.TabIndex = 30;
            this.label11.Text = "LastName:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(385, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 22);
            this.label12.TabIndex = 31;
            this.label12.Text = "Phone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 22);
            this.label13.TabIndex = 29;
            this.label13.Text = "AccNumber:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(32, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 22);
            this.label14.TabIndex = 28;
            this.label14.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(14, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 22);
            this.label15.TabIndex = 27;
            this.label15.Text = "FirstName:";
            // 
            // nudUpdateClientBalnce
            // 
            this.nudUpdateClientBalnce.Location = new System.Drawing.Point(300, 212);
            this.nudUpdateClientBalnce.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudUpdateClientBalnce.Name = "nudUpdateClientBalnce";
            this.nudUpdateClientBalnce.Size = new System.Drawing.Size(214, 26);
            this.nudUpdateClientBalnce.TabIndex = 26;
            this.nudUpdateClientBalnce.Validating += new System.ComponentModel.CancelEventHandler(this.nudUpdateClientBalnce_Validating);
            // 
            // txtClientUpdateAccountnumber
            // 
            this.txtClientUpdateAccountnumber.Location = new System.Drawing.Point(135, 153);
            this.txtClientUpdateAccountnumber.Multiline = true;
            this.txtClientUpdateAccountnumber.Name = "txtClientUpdateAccountnumber";
            this.txtClientUpdateAccountnumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientUpdateAccountnumber.Size = new System.Drawing.Size(214, 36);
            this.txtClientUpdateAccountnumber.TabIndex = 18;
            // 
            // txtClientUpdateEmail
            // 
            this.txtClientUpdateEmail.Location = new System.Drawing.Point(135, 85);
            this.txtClientUpdateEmail.Multiline = true;
            this.txtClientUpdateEmail.Name = "txtClientUpdateEmail";
            this.txtClientUpdateEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientUpdateEmail.Size = new System.Drawing.Size(214, 36);
            this.txtClientUpdateEmail.TabIndex = 17;
            this.txtClientUpdateEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtClientUpdateFirstname
            // 
            this.txtClientUpdateFirstname.BackColor = System.Drawing.SystemColors.Window;
            this.txtClientUpdateFirstname.Location = new System.Drawing.Point(135, 17);
            this.txtClientUpdateFirstname.Multiline = true;
            this.txtClientUpdateFirstname.Name = "txtClientUpdateFirstname";
            this.txtClientUpdateFirstname.ReadOnly = true;
            this.txtClientUpdateFirstname.Size = new System.Drawing.Size(214, 36);
            this.txtClientUpdateFirstname.TabIndex = 16;
            this.txtClientUpdateFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtClientUpdatePINCode
            // 
            this.txtClientUpdatePINCode.Location = new System.Drawing.Point(487, 153);
            this.txtClientUpdatePINCode.Multiline = true;
            this.txtClientUpdatePINCode.Name = "txtClientUpdatePINCode";
            this.txtClientUpdatePINCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientUpdatePINCode.Size = new System.Drawing.Size(214, 36);
            this.txtClientUpdatePINCode.TabIndex = 15;
            this.txtClientUpdatePINCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtClientUpdatePhone
            // 
            this.txtClientUpdatePhone.Location = new System.Drawing.Point(487, 85);
            this.txtClientUpdatePhone.Multiline = true;
            this.txtClientUpdatePhone.Name = "txtClientUpdatePhone";
            this.txtClientUpdatePhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientUpdatePhone.Size = new System.Drawing.Size(214, 36);
            this.txtClientUpdatePhone.TabIndex = 14;
            this.txtClientUpdatePhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtClientUpdateLastname
            // 
            this.txtClientUpdateLastname.Location = new System.Drawing.Point(486, 17);
            this.txtClientUpdateLastname.Multiline = true;
            this.txtClientUpdateLastname.Name = "txtClientUpdateLastname";
            this.txtClientUpdateLastname.Size = new System.Drawing.Size(214, 36);
            this.txtClientUpdateLastname.TabIndex = 13;
            this.txtClientUpdateLastname.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // FrmClientsManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1001, 501);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmClientsManagment";
            this.Load += new System.EventHandler(this.FrmClientsManagment_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabShowClients.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabAddNewClient.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClientAUpDownAddBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.UpdateTap.ResumeLayout(false);
            this.UpdateTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateClientBalnce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabShowClients;
        private System.Windows.Forms.DataGridView dgvClientList;
        private System.Windows.Forms.TabPage tabAddNewClient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbtnAscOrder;
        private System.Windows.Forms.RadioButton rdbDesOrder;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialButton btnAddnewClient;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numClientAUpDownAddBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientAddAccountNumber;
        private System.Windows.Forms.TextBox txtClientAddEmail;
        private System.Windows.Forms.TextBox txtClientAddFirstname;
        private System.Windows.Forms.TextBox txtClientAddPINCode;
        private System.Windows.Forms.TextBox txtClientAddPhone;
        private System.Windows.Forms.TextBox txtClientAddLastname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TabPage UpdateTap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudUpdateClientBalnce;
        private System.Windows.Forms.TextBox txtClientUpdateAccountnumber;
        private System.Windows.Forms.TextBox txtClientUpdateEmail;
        private System.Windows.Forms.TextBox txtClientUpdateFirstname;
        private System.Windows.Forms.TextBox txtClientUpdatePINCode;
        private System.Windows.Forms.TextBox txtClientUpdatePhone;
        private System.Windows.Forms.TextBox txtClientUpdateLastname;
        private System.Windows.Forms.ComboBox combAccountNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label16;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
    }
}
