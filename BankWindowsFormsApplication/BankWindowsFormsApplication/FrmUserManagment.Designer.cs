namespace BankWindowsFormsApplication
{
    partial class FrmUserManagment
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
            this.TabFindUser = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbDesOrder = new System.Windows.Forms.RadioButton();
            this.rdbtnAscOrder = new System.Windows.Forms.RadioButton();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.contextMenuStripUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabUpdateUser = new System.Windows.Forms.TabPage();
            this.btnUpdateUser = new MaterialSkin.Controls.MaterialButton();
            this.combUserNameList = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbUpdateSomePermission = new System.Windows.Forms.RadioButton();
            this.rdbUpdateFullPermission = new System.Windows.Forms.RadioButton();
            this.grbUpdateChkPermission = new System.Windows.Forms.GroupBox();
            this.chkUpdateClinetTransactionPermission = new System.Windows.Forms.CheckBox();
            this.checkBox2chkUpdateUserManagmentPermission = new System.Windows.Forms.CheckBox();
            this.chkUpdateClinetManagmentPermission = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdateUserPassword = new System.Windows.Forms.TextBox();
            this.txtUpdateUserPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateUserLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdateUserUserName = new System.Windows.Forms.TextBox();
            this.txtUpdateUserEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateUserFirtsName = new System.Windows.Forms.TextBox();
            this.TabAddUser = new System.Windows.Forms.TabPage();
            this.btnAddNewUser = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbSomePermission = new System.Windows.Forms.RadioButton();
            this.rdbFullPerimission = new System.Windows.Forms.RadioButton();
            this.grbAddChkPermission = new System.Windows.Forms.GroupBox();
            this.chkTransaction = new System.Windows.Forms.CheckBox();
            this.chkUserManagment = new System.Windows.Forms.CheckBox();
            this.chkClientManagment = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddUserPassword = new System.Windows.Forms.TextBox();
            this.txtAddUserPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddUserLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddUserUserName = new System.Windows.Forms.TextBox();
            this.txtAddUserEmail = new System.Windows.Forms.TextBox();
            this.txtAddUserFirstName = new System.Windows.Forms.TextBox();
            this.UserAdderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.TabFindUser.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.contextMenuStripUser.SuspendLayout();
            this.TabUpdateUser.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbUpdateChkPermission.SuspendLayout();
            this.TabAddUser.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbAddChkPermission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserAdderrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabFindUser);
            this.tabControl1.Controls.Add(this.TabUpdateUser);
            this.tabControl1.Controls.Add(this.TabAddUser);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(197, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 485);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // TabFindUser
            // 
            this.TabFindUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabFindUser.Controls.Add(this.groupBox4);
            this.TabFindUser.Controls.Add(this.groupBox3);
            this.TabFindUser.Controls.Add(this.dgvUserList);
            this.TabFindUser.Location = new System.Drawing.Point(4, 28);
            this.TabFindUser.Name = "TabFindUser";
            this.TabFindUser.Padding = new System.Windows.Forms.Padding(3);
            this.TabFindUser.Size = new System.Drawing.Size(859, 453);
            this.TabFindUser.TabIndex = 0;
            this.TabFindUser.Text = "Find";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.txtSearchUserName);
            this.groupBox4.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(2, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(307, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ادخل رقم الحساب ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(6, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.Location = new System.Drawing.Point(62, 42);
            this.txtSearchUserName.Multiline = true;
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(235, 28);
            this.txtSearchUserName.TabIndex = 2;
            this.txtSearchUserName.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDesOrder);
            this.groupBox3.Controls.Add(this.rdbtnAscOrder);
            this.groupBox3.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(394, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(275, 100);
            this.groupBox3.TabIndex = 5;
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
            // dgvUserList
            // 
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.ContextMenuStrip = this.contextMenuStripUser;
            this.dgvUserList.Location = new System.Drawing.Point(3, 186);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.Size = new System.Drawing.Size(787, 264);
            this.dgvUserList.TabIndex = 0;
            // 
            // contextMenuStripUser
            // 
            this.contextMenuStripUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStripUser.Name = "contextMenuStrip1";
            this.contextMenuStripUser.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // TabUpdateUser
            // 
            this.TabUpdateUser.Controls.Add(this.btnUpdateUser);
            this.TabUpdateUser.Controls.Add(this.combUserNameList);
            this.TabUpdateUser.Controls.Add(this.label14);
            this.TabUpdateUser.Controls.Add(this.panel3);
            this.TabUpdateUser.Location = new System.Drawing.Point(4, 28);
            this.TabUpdateUser.Name = "TabUpdateUser";
            this.TabUpdateUser.Padding = new System.Windows.Forms.Padding(3);
            this.TabUpdateUser.Size = new System.Drawing.Size(859, 453);
            this.TabUpdateUser.TabIndex = 1;
            this.TabUpdateUser.Text = "Update";
            this.TabUpdateUser.UseVisualStyleBackColor = true;
            this.TabUpdateUser.Click += new System.EventHandler(this.TabUpdateUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateUser.Depth = 0;
            this.btnUpdateUser.DrawShadows = true;
            this.btnUpdateUser.HighEmphasis = true;
            this.btnUpdateUser.Icon = null;
            this.btnUpdateUser.Location = new System.Drawing.Point(358, 396);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(117, 36);
            this.btnUpdateUser.TabIndex = 32;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateUser.UseAccentColor = false;
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // combUserNameList
            // 
            this.combUserNameList.FormattingEnabled = true;
            this.combUserNameList.Location = new System.Drawing.Point(178, 12);
            this.combUserNameList.Name = "combUserNameList";
            this.combUserNameList.Size = new System.Drawing.Size(173, 27);
            this.combUserNameList.TabIndex = 31;
            this.combUserNameList.SelectedIndexChanged += new System.EventHandler(this.combUserNameList_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(22, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 22);
            this.label14.TabIndex = 30;
            this.label14.Text = "Select UserName:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.rdbUpdateSomePermission);
            this.panel3.Controls.Add(this.rdbUpdateFullPermission);
            this.panel3.Controls.Add(this.grbUpdateChkPermission);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtUpdateUserPassword);
            this.panel3.Controls.Add(this.txtUpdateUserPhone);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtUpdateUserLastName);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtUpdateUserUserName);
            this.panel3.Controls.Add(this.txtUpdateUserEmail);
            this.panel3.Controls.Add(this.txtUpdateUserFirtsName);
            this.panel3.Location = new System.Drawing.Point(68, 45);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(735, 342);
            this.panel3.TabIndex = 19;
            // 
            // rdbUpdateSomePermission
            // 
            this.rdbUpdateSomePermission.AutoSize = true;
            this.rdbUpdateSomePermission.Location = new System.Drawing.Point(17, 233);
            this.rdbUpdateSomePermission.Name = "rdbUpdateSomePermission";
            this.rdbUpdateSomePermission.Size = new System.Drawing.Size(158, 23);
            this.rdbUpdateSomePermission.TabIndex = 29;
            this.rdbUpdateSomePermission.TabStop = true;
            this.rdbUpdateSomePermission.Text = "Set Permission For:";
            this.rdbUpdateSomePermission.UseVisualStyleBackColor = true;
            this.rdbUpdateSomePermission.CheckedChanged += new System.EventHandler(this.rdbUpdateSomePermission_CheckedChanged);
            // 
            // rdbUpdateFullPermission
            // 
            this.rdbUpdateFullPermission.AutoSize = true;
            this.rdbUpdateFullPermission.Location = new System.Drawing.Point(17, 204);
            this.rdbUpdateFullPermission.Name = "rdbUpdateFullPermission";
            this.rdbUpdateFullPermission.Size = new System.Drawing.Size(129, 23);
            this.rdbUpdateFullPermission.TabIndex = 28;
            this.rdbUpdateFullPermission.TabStop = true;
            this.rdbUpdateFullPermission.Tag = "-1";
            this.rdbUpdateFullPermission.Text = "Full Permission";
            this.rdbUpdateFullPermission.UseVisualStyleBackColor = true;
            this.rdbUpdateFullPermission.CheckedChanged += new System.EventHandler(this.rdbUpdateFullPermission_CheckedChanged);
            // 
            // grbUpdateChkPermission
            // 
            this.grbUpdateChkPermission.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbUpdateChkPermission.Controls.Add(this.chkUpdateClinetTransactionPermission);
            this.grbUpdateChkPermission.Controls.Add(this.checkBox2chkUpdateUserManagmentPermission);
            this.grbUpdateChkPermission.Controls.Add(this.chkUpdateClinetManagmentPermission);
            this.grbUpdateChkPermission.Location = new System.Drawing.Point(175, 204);
            this.grbUpdateChkPermission.Name = "grbUpdateChkPermission";
            this.grbUpdateChkPermission.Size = new System.Drawing.Size(394, 132);
            this.grbUpdateChkPermission.TabIndex = 27;
            this.grbUpdateChkPermission.TabStop = false;
            this.grbUpdateChkPermission.Text = "Check Permission ";
            // 
            // chkUpdateClinetTransactionPermission
            // 
            this.chkUpdateClinetTransactionPermission.AutoSize = true;
            this.chkUpdateClinetTransactionPermission.Location = new System.Drawing.Point(40, 89);
            this.chkUpdateClinetTransactionPermission.Name = "chkUpdateClinetTransactionPermission";
            this.chkUpdateClinetTransactionPermission.Size = new System.Drawing.Size(106, 23);
            this.chkUpdateClinetTransactionPermission.TabIndex = 2;
            this.chkUpdateClinetTransactionPermission.Tag = "8";
            this.chkUpdateClinetTransactionPermission.Text = "Transaction";
            this.chkUpdateClinetTransactionPermission.UseVisualStyleBackColor = true;
            this.chkUpdateClinetTransactionPermission.CheckedChanged += new System.EventHandler(this.chkUpdateClinetTransactionPermission_CheckedChanged);
            // 
            // checkBox2chkUpdateUserManagmentPermission
            // 
            this.checkBox2chkUpdateUserManagmentPermission.AutoSize = true;
            this.checkBox2chkUpdateUserManagmentPermission.Location = new System.Drawing.Point(221, 43);
            this.checkBox2chkUpdateUserManagmentPermission.Name = "checkBox2chkUpdateUserManagmentPermission";
            this.checkBox2chkUpdateUserManagmentPermission.Size = new System.Drawing.Size(145, 23);
            this.checkBox2chkUpdateUserManagmentPermission.TabIndex = 1;
            this.checkBox2chkUpdateUserManagmentPermission.Tag = "4";
            this.checkBox2chkUpdateUserManagmentPermission.Text = "User Managment";
            this.checkBox2chkUpdateUserManagmentPermission.UseVisualStyleBackColor = true;
            this.checkBox2chkUpdateUserManagmentPermission.CheckedChanged += new System.EventHandler(this.checkBox2chkUpdateUserManagmentPermission_CheckedChanged);
            // 
            // chkUpdateClinetManagmentPermission
            // 
            this.chkUpdateClinetManagmentPermission.AutoSize = true;
            this.chkUpdateClinetManagmentPermission.Location = new System.Drawing.Point(39, 43);
            this.chkUpdateClinetManagmentPermission.Name = "chkUpdateClinetManagmentPermission";
            this.chkUpdateClinetManagmentPermission.Size = new System.Drawing.Size(153, 23);
            this.chkUpdateClinetManagmentPermission.TabIndex = 0;
            this.chkUpdateClinetManagmentPermission.Tag = "2";
            this.chkUpdateClinetManagmentPermission.Text = "Client Managment";
            this.chkUpdateClinetManagmentPermission.UseVisualStyleBackColor = true;
            this.chkUpdateClinetManagmentPermission.CheckedChanged += new System.EventHandler(this.chkUpdateClinetManagmentPermission_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(378, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Password:";
            // 
            // txtUpdateUserPassword
            // 
            this.txtUpdateUserPassword.Location = new System.Drawing.Point(485, 147);
            this.txtUpdateUserPassword.Multiline = true;
            this.txtUpdateUserPassword.Name = "txtUpdateUserPassword";
            this.txtUpdateUserPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUpdateUserPassword.Size = new System.Drawing.Size(214, 36);
            this.txtUpdateUserPassword.TabIndex = 15;
            this.txtUpdateUserPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtUpdateUserPhone
            // 
            this.txtUpdateUserPhone.Location = new System.Drawing.Point(485, 81);
            this.txtUpdateUserPhone.Multiline = true;
            this.txtUpdateUserPhone.Name = "txtUpdateUserPhone";
            this.txtUpdateUserPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUpdateUserPhone.Size = new System.Drawing.Size(214, 36);
            this.txtUpdateUserPhone.TabIndex = 14;
            this.txtUpdateUserPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(368, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "LastName:";
            // 
            // txtUpdateUserLastName
            // 
            this.txtUpdateUserLastName.Location = new System.Drawing.Point(485, 17);
            this.txtUpdateUserLastName.Multiline = true;
            this.txtUpdateUserLastName.Name = "txtUpdateUserLastName";
            this.txtUpdateUserLastName.Size = new System.Drawing.Size(214, 36);
            this.txtUpdateUserLastName.TabIndex = 13;
            this.txtUpdateUserLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(382, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Phone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "UserName:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 22);
            this.label13.TabIndex = 19;
            this.label13.Text = "FirstName:";
            // 
            // txtUpdateUserUserName
            // 
            this.txtUpdateUserUserName.Location = new System.Drawing.Point(134, 147);
            this.txtUpdateUserUserName.Multiline = true;
            this.txtUpdateUserUserName.Name = "txtUpdateUserUserName";
            this.txtUpdateUserUserName.ReadOnly = true;
            this.txtUpdateUserUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUpdateUserUserName.Size = new System.Drawing.Size(214, 36);
            this.txtUpdateUserUserName.TabIndex = 18;
            this.txtUpdateUserUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtUpdateUserEmail
            // 
            this.txtUpdateUserEmail.Location = new System.Drawing.Point(134, 81);
            this.txtUpdateUserEmail.Multiline = true;
            this.txtUpdateUserEmail.Name = "txtUpdateUserEmail";
            this.txtUpdateUserEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUpdateUserEmail.Size = new System.Drawing.Size(214, 36);
            this.txtUpdateUserEmail.TabIndex = 17;
            this.txtUpdateUserEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtUpdateUserFirtsName
            // 
            this.txtUpdateUserFirtsName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUpdateUserFirtsName.Location = new System.Drawing.Point(134, 17);
            this.txtUpdateUserFirtsName.Multiline = true;
            this.txtUpdateUserFirtsName.Name = "txtUpdateUserFirtsName";
            this.txtUpdateUserFirtsName.Size = new System.Drawing.Size(214, 36);
            this.txtUpdateUserFirtsName.TabIndex = 16;
            this.txtUpdateUserFirtsName.VisibleChanged += new System.EventHandler(this.FrmUserManagment_Load);
            // 
            // TabAddUser
            // 
            this.TabAddUser.Controls.Add(this.btnAddNewUser);
            this.TabAddUser.Controls.Add(this.panel2);
            this.TabAddUser.Location = new System.Drawing.Point(4, 28);
            this.TabAddUser.Name = "TabAddUser";
            this.TabAddUser.Size = new System.Drawing.Size(859, 453);
            this.TabAddUser.TabIndex = 2;
            this.TabAddUser.Text = "Add";
            this.TabAddUser.UseVisualStyleBackColor = true;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.AutoSize = false;
            this.btnAddNewUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewUser.Depth = 0;
            this.btnAddNewUser.DrawShadows = true;
            this.btnAddNewUser.HighEmphasis = true;
            this.btnAddNewUser.Icon = null;
            this.btnAddNewUser.Location = new System.Drawing.Point(311, 400);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNewUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(201, 47);
            this.btnAddNewUser.TabIndex = 19;
            this.btnAddNewUser.Text = "Add User";
            this.btnAddNewUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddNewUser.UseAccentColor = false;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.rdbSomePermission);
            this.panel2.Controls.Add(this.rdbFullPerimission);
            this.panel2.Controls.Add(this.grbAddChkPermission);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtAddUserPassword);
            this.panel2.Controls.Add(this.txtAddUserPhone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAddUserLastName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAddUserUserName);
            this.panel2.Controls.Add(this.txtAddUserEmail);
            this.panel2.Controls.Add(this.txtAddUserFirstName);
            this.panel2.Location = new System.Drawing.Point(47, 17);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(735, 374);
            this.panel2.TabIndex = 18;
            // 
            // rdbSomePermission
            // 
            this.rdbSomePermission.AutoSize = true;
            this.rdbSomePermission.Location = new System.Drawing.Point(8, 280);
            this.rdbSomePermission.Name = "rdbSomePermission";
            this.rdbSomePermission.Size = new System.Drawing.Size(158, 23);
            this.rdbSomePermission.TabIndex = 29;
            this.rdbSomePermission.TabStop = true;
            this.rdbSomePermission.Text = "Set Permission For:";
            this.rdbSomePermission.UseVisualStyleBackColor = true;
            this.rdbSomePermission.CheckedChanged += new System.EventHandler(this.rdbSomePermission_CheckedChanged);
            // 
            // rdbFullPerimission
            // 
            this.rdbFullPerimission.AutoSize = true;
            this.rdbFullPerimission.Location = new System.Drawing.Point(8, 232);
            this.rdbFullPerimission.Name = "rdbFullPerimission";
            this.rdbFullPerimission.Size = new System.Drawing.Size(129, 23);
            this.rdbFullPerimission.TabIndex = 28;
            this.rdbFullPerimission.TabStop = true;
            this.rdbFullPerimission.Tag = "-1";
            this.rdbFullPerimission.Text = "Full Permission";
            this.rdbFullPerimission.UseVisualStyleBackColor = true;
            this.rdbFullPerimission.CheckedChanged += new System.EventHandler(this.rdbFullPerimission_CheckedChanged);
            // 
            // grbAddChkPermission
            // 
            this.grbAddChkPermission.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbAddChkPermission.Controls.Add(this.chkTransaction);
            this.grbAddChkPermission.Controls.Add(this.chkUserManagment);
            this.grbAddChkPermission.Controls.Add(this.chkClientManagment);
            this.grbAddChkPermission.Location = new System.Drawing.Point(172, 220);
            this.grbAddChkPermission.Name = "grbAddChkPermission";
            this.grbAddChkPermission.Size = new System.Drawing.Size(394, 132);
            this.grbAddChkPermission.TabIndex = 27;
            this.grbAddChkPermission.TabStop = false;
            this.grbAddChkPermission.Text = "Check Permission ";
            this.grbAddChkPermission.Enter += new System.EventHandler(this.grbPermission_Enter);
            // 
            // chkTransaction
            // 
            this.chkTransaction.AutoSize = true;
            this.chkTransaction.Location = new System.Drawing.Point(40, 89);
            this.chkTransaction.Name = "chkTransaction";
            this.chkTransaction.Size = new System.Drawing.Size(106, 23);
            this.chkTransaction.TabIndex = 2;
            this.chkTransaction.Tag = "8";
            this.chkTransaction.Text = "Transaction";
            this.chkTransaction.UseVisualStyleBackColor = true;
            this.chkTransaction.CheckedChanged += new System.EventHandler(this.chkTransaction_CheckedChanged);
            // 
            // chkUserManagment
            // 
            this.chkUserManagment.AutoSize = true;
            this.chkUserManagment.Location = new System.Drawing.Point(221, 43);
            this.chkUserManagment.Name = "chkUserManagment";
            this.chkUserManagment.Size = new System.Drawing.Size(145, 23);
            this.chkUserManagment.TabIndex = 1;
            this.chkUserManagment.Tag = "4";
            this.chkUserManagment.Text = "User Managment";
            this.chkUserManagment.UseVisualStyleBackColor = true;
            this.chkUserManagment.CheckedChanged += new System.EventHandler(this.chkUserManagment_CheckedChanged);
            // 
            // chkClientManagment
            // 
            this.chkClientManagment.AutoSize = true;
            this.chkClientManagment.Location = new System.Drawing.Point(40, 43);
            this.chkClientManagment.Name = "chkClientManagment";
            this.chkClientManagment.Size = new System.Drawing.Size(153, 23);
            this.chkClientManagment.TabIndex = 0;
            this.chkClientManagment.Tag = "2";
            this.chkClientManagment.Text = "Client Managment";
            this.chkClientManagment.UseVisualStyleBackColor = true;
            this.chkClientManagment.CheckedChanged += new System.EventHandler(this.chkClientManagment_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(378, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Password:";
            // 
            // txtAddUserPassword
            // 
            this.txtAddUserPassword.Location = new System.Drawing.Point(485, 147);
            this.txtAddUserPassword.Multiline = true;
            this.txtAddUserPassword.Name = "txtAddUserPassword";
            this.txtAddUserPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddUserPassword.Size = new System.Drawing.Size(214, 36);
            this.txtAddUserPassword.TabIndex = 15;
            this.txtAddUserPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtAddUserPhone
            // 
            this.txtAddUserPhone.Location = new System.Drawing.Point(485, 81);
            this.txtAddUserPhone.Multiline = true;
            this.txtAddUserPhone.Name = "txtAddUserPhone";
            this.txtAddUserPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddUserPhone.Size = new System.Drawing.Size(214, 36);
            this.txtAddUserPhone.TabIndex = 14;
            this.txtAddUserPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
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
            // txtAddUserLastName
            // 
            this.txtAddUserLastName.Location = new System.Drawing.Point(485, 17);
            this.txtAddUserLastName.Multiline = true;
            this.txtAddUserLastName.Name = "txtAddUserLastName";
            this.txtAddUserLastName.Size = new System.Drawing.Size(214, 36);
            this.txtAddUserLastName.TabIndex = 13;
            this.txtAddUserLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
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
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "UserName:";
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
            // txtAddUserUserName
            // 
            this.txtAddUserUserName.Location = new System.Drawing.Point(134, 147);
            this.txtAddUserUserName.Multiline = true;
            this.txtAddUserUserName.Name = "txtAddUserUserName";
            this.txtAddUserUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddUserUserName.Size = new System.Drawing.Size(214, 36);
            this.txtAddUserUserName.TabIndex = 18;
            this.txtAddUserUserName.TextChanged += new System.EventHandler(this.txtAddUserUserName_TextChanged);
            this.txtAddUserUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtAddUserEmail
            // 
            this.txtAddUserEmail.Location = new System.Drawing.Point(134, 81);
            this.txtAddUserEmail.Multiline = true;
            this.txtAddUserEmail.Name = "txtAddUserEmail";
            this.txtAddUserEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddUserEmail.Size = new System.Drawing.Size(214, 36);
            this.txtAddUserEmail.TabIndex = 17;
            this.txtAddUserEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // txtAddUserFirstName
            // 
            this.txtAddUserFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddUserFirstName.Location = new System.Drawing.Point(134, 17);
            this.txtAddUserFirstName.Multiline = true;
            this.txtAddUserFirstName.Name = "txtAddUserFirstName";
            this.txtAddUserFirstName.Size = new System.Drawing.Size(214, 36);
            this.txtAddUserFirstName.TabIndex = 16;
            this.txtAddUserFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredFeild);
            // 
            // UserAdderrorProvider
            // 
            this.UserAdderrorProvider.ContainerControl = this;
            // 
            // FrmUserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1076, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmUserManagment";
            this.Load += new System.EventHandler(this.FrmUserManagment_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.TabFindUser.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.contextMenuStripUser.ResumeLayout(false);
            this.TabUpdateUser.ResumeLayout(false);
            this.TabUpdateUser.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grbUpdateChkPermission.ResumeLayout(false);
            this.grbUpdateChkPermission.PerformLayout();
            this.TabAddUser.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbAddChkPermission.ResumeLayout(false);
            this.grbAddChkPermission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserAdderrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabFindUser;
        private System.Windows.Forms.TabPage TabUpdateUser;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.TabPage TabAddUser;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbDesOrder;
        private System.Windows.Forms.RadioButton rdbtnAscOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUser;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbSomePermission;
        private System.Windows.Forms.RadioButton rdbFullPerimission;
        private System.Windows.Forms.GroupBox grbAddChkPermission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddUserPassword;
        private System.Windows.Forms.TextBox txtAddUserPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddUserLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddUserUserName;
        private System.Windows.Forms.TextBox txtAddUserEmail;
        private System.Windows.Forms.TextBox txtAddUserFirstName;
        private System.Windows.Forms.CheckBox chkTransaction;
        private System.Windows.Forms.CheckBox chkUserManagment;
        private System.Windows.Forms.CheckBox chkClientManagment;
        private MaterialSkin.Controls.MaterialButton btnAddNewUser;
        private System.Windows.Forms.ErrorProvider UserAdderrorProvider;
        private System.Windows.Forms.ComboBox combUserNameList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbUpdateSomePermission;
        private System.Windows.Forms.RadioButton rdbUpdateFullPermission;
        private System.Windows.Forms.GroupBox grbUpdateChkPermission;
        private System.Windows.Forms.CheckBox chkUpdateClinetTransactionPermission;
        private System.Windows.Forms.CheckBox checkBox2chkUpdateUserManagmentPermission;
        private System.Windows.Forms.CheckBox chkUpdateClinetManagmentPermission;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateUserPassword;
        private System.Windows.Forms.TextBox txtUpdateUserPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateUserLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdateUserUserName;
        private System.Windows.Forms.TextBox txtUpdateUserEmail;
        private System.Windows.Forms.TextBox txtUpdateUserFirtsName;
        private MaterialSkin.Controls.MaterialButton btnUpdateUser;
    }
}
