using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankBusinisLayer;


namespace BankWindowsFormsApplication
{
    public partial class FrmUserManagment : BankWindowsFormsApplication.FromScreen
    {
        public FrmUserManagment()
        {
            InitializeComponent();
            FullListBox();
        }

        public DataTable datatableUser = new DataTable();
        public DataView dataviewUser = new DataView();

        public static  int UserPermission;

        private void _RefreishUserList()
        {
            datatableUser = clsUser.GetAllUsers();
            dataviewUser = datatableUser.DefaultView;
            dgvUserList.DataSource = dataviewUser;
         

        }


        private void FullListBox()
        {

            datatableUser = clsUser.GetAllUsers();


            foreach (DataRow Row in datatableUser.Rows)
            {
                combUserNameList.Items.Add(Row["UserName"]);
            }
         
            //for (int i = 0; i < dgvUserList.RowCount - 1; i++)
            //{
            //    combUserNameList.Items.Add(dgvUserList.Rows[i].Cells[4].Value);

            //}
        }

        private void FrmUserManagment_Load(object sender, EventArgs e)
        {

            _RefreishUserList();
           
        }

        private void rdbtnAscOrder_CheckedChanged(object sender, EventArgs e)
        {
            dgvUserList.Sort(dgvUserList.Columns[0], ListSortDirection.Ascending);
        }

        private void rdbDesOrder_CheckedChanged(object sender, EventArgs e)
        {
            dgvUserList.Sort(dgvUserList.Columns[0], ListSortDirection.Descending);
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            dataviewUser = datatableUser.DefaultView;
            dataviewUser.RowFilter = "UserName like'%" + txtSearchUserName.Text + "%'";
            dgvUserList.DataSource = dataviewUser;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure you want to Delete this User with ID[" + dgvUserList.CurrentRow.Cells[0].Value + "]", "Confirmation message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.Delete((int)dgvUserList.CurrentRow.Cells[0].Value))
                {
                    if (MessageBox.Show("User Deleted Successfuly", "Message", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        _RefreishUserList();
                    }

                }
                else
                {
                    MessageBox.Show("User is not  Deleted ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        //private int _ReadUserPermission()
        //{
        //    int UserPermission = 0;
        //    if (rdbFullPerimission.Checked)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        if (chkClientManagment.Checked)
        //        {
        //            UserPermission += Convert.ToInt16(chkClientManagment.Tag);
        //        }

        //        if (chkUserManagment.Checked)
        //        {
        //            UserPermission += Convert.ToInt16(chkUserManagment.Tag);
        //        }



        //        if (chkTransaction.Checked)
        //        {
        //            UserPermission += Convert.ToInt16(chkTransaction.Tag);
        //        }
        //    }
        //    return UserPermission;
        //}



        private void _ReadPersonInfo(ref clsPerson Person)
        {
            Person.FirstName = txtAddUserFirstName.Text;
            Person.LastName = txtAddUserLastName.Text;
            Person.Email = txtAddUserEmail.Text;
            Person.Phone = txtAddUserPhone.Text;
        }


        private void _ReadUserInfo(ref clsUser User)
        {
            User.UserName = txtAddUserUserName.Text;
            User.Password = txtAddUserPassword.Text;
            User.Permission = UserPermission;
        }


        private bool _AddNewUser()
        {
            clsPerson Person = new clsPerson();
            _ReadPersonInfo(ref Person);
            if (Person.Save())
            {
                clsUser User = new clsUser(txtAddUserUserName.Text, Person.PersonID);

                _ReadUserInfo(ref User);
                return (User.Save());

            }
            else
                return false;

        }
        private void _RefrishAddUserTextBox()
        {
            txtAddUserFirstName.Clear();
            txtAddUserLastName.Clear();
            txtAddUserEmail.Clear();
            txtAddUserPhone.Clear();
            txtAddUserUserName.Clear();
            txtAddUserPassword.Clear();
            chkClientManagment.Checked = false;
            chkUserManagment.Checked = false;
            chkTransaction.Checked = false;
            rdbFullPerimission.Checked = true;
        }

        private void materialCheckbox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbFullPerimission_CheckedChanged(object sender, EventArgs e)
        {
            grbAddChkPermission.Enabled = false;
            setFullPermission((RadioButton)sender);
          
        }

        private void rdbSomePermission_CheckedChanged(object sender, EventArgs e)
        {
            EnableGrbCheckPermission((RadioButton)sender, grbAddChkPermission);
        }

        private void txtAddUserUserName_TextChanged(object sender, EventArgs e)
        {
            if (clsUser.IsUserExsist(txtAddUserUserName.Text))
            {
                if (MessageBox.Show("Username is Already Exsits Enter another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtAddUserUserName.Clear();
                    txtAddUserUserName.Focus();
                }

            }
        }





        private void _Requiredtxt(TextBox txtbox, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox.Text))
            {
                e.Cancel = true;
                txtbox.Focus();
                UserAdderrorProvider.SetError(txtbox, "Field is required");
            }


            else
            {
                e.Cancel = false;
                UserAdderrorProvider.SetError(txtbox, "");
            }
        }

        private void txtRequiredFeild(object sender, CancelEventArgs e)
        {
            _Requiredtxt((TextBox)sender, e);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you Want to Add this User?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (_AddNewUser())
                {
                    MessageBox.Show("User Added Successfuly", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    _RefrishAddUserTextBox();
                    _RefreishUserList();

                  

                }
                else
                {
                    MessageBox.Show("User is not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



     

        private void combUserNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(combUserNameList.SelectedItem.ToString());
            if (User != null)
            {
                txtUpdateUserFirtsName.Text = User.FirstName;
                txtUpdateUserLastName.Text = User.LastName;
                txtUpdateUserEmail.Text = User.Email;
                txtUpdateUserPhone.Text = User.Phone;
                txtUpdateUserUserName.Text = User.UserName;
                txtUpdateUserPassword.Text = User.Password;
                if (User.Permission == -1)
                {
                    rdbUpdateFullPermission.Checked = true;

                    grbUpdateChkPermission.Enabled = false;

                }
                else

                {

                    rdbUpdateSomePermission.Checked = true;
                    grbUpdateChkPermission.Enabled = true;
                    
                }
                   
            }
        }



        private  void setFullPermission(RadioButton rdp)
        {
            if(rdp.Checked ==true )
            {
                UserPermission = -1;
            }
        }
        private void rdbUpdateFullPermission_CheckedChanged(object sender, EventArgs e)
        {
            setFullPermission((RadioButton)sender);
        }



        private void _SetPermission(CheckBox chk)
        {
            if(chk.Checked)
            {
                UserPermission += Convert.ToInt16(chk.Tag);
            }
        }

        private void _UpdateUserInfo(ref clsUser User)
        {
            User.FirstName = txtUpdateUserFirtsName.Text;
            User.LastName = txtUpdateUserLastName.Text;
            User.Email = txtUpdateUserEmail.Text;
            User.Phone = txtUpdateUserPhone.Text;
            User.Password = txtUpdateUserPassword.Text;
            User.Permission = UserPermission;
        }
        private bool _UpdateUserRecord()
        {
            clsUser User = clsUser.Find(txtUpdateUserUserName.Text);
            _UpdateUserInfo(ref User);
            clsPerson Person = new clsPerson(User.PersonID, User.FirstName, User.LastName, User.Email, User.Phone);
            if (Person.Save())
            {
                return (User.Save());
            }
            else
            {
                return false;
            }

        } 


        private void _RefreshUpdateUserScreen()
        {
            txtUpdateUserFirtsName.Clear();
            txtUpdateUserLastName.Clear();
            txtUpdateUserEmail.Clear();
            txtUpdateUserPhone.Clear();
            txtUpdateUserUserName.Clear();
            txtUpdateUserPassword.Clear();
            rdbFullPerimission.Checked = true;
        }
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you Want to Update this User ?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (_UpdateUserRecord())
                {
                    MessageBox.Show("User Updated Succssefuly", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreishUserList();
                    _RefreshUpdateUserScreen();


                }
                else
                {
                    MessageBox.Show("User is not Updated ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void chkUpdateClinetManagmentPermission_CheckedChanged(object sender, EventArgs e)
        {
            _SetPermission((CheckBox)sender);
        }

        private void checkBox2chkUpdateUserManagmentPermission_CheckedChanged(object sender, EventArgs e)
        {
            _SetPermission((CheckBox)sender);
        }

        private void chkUpdateClinetTransactionPermission_CheckedChanged(object sender, EventArgs e)
        {
            _SetPermission((CheckBox)sender);
        }

        private void chkClientManagment_CheckedChanged(object sender, EventArgs e)
        {
            _SetPermission((CheckBox)sender);
        }

        private void chkUserManagment_CheckedChanged(object sender, EventArgs e)
        {
            _SetPermission((CheckBox)sender);
        }

        private void chkTransaction_CheckedChanged(object sender, EventArgs e)
        {
            _SetPermission((CheckBox)sender);
        }

        private void EnableGrbCheckPermission(RadioButton btn,GroupBox  Grp)
        {
            if(btn.Checked )
            {
                UserPermission = 0;
                Grp.Enabled = true;
            }
        }
        private void rdbUpdateSomePermission_CheckedChanged(object sender, EventArgs e)
        {
            EnableGrbCheckPermission((RadioButton)sender, grbUpdateChkPermission);
        }

        private void grbPermission_Enter(object sender, EventArgs e)
        {

        }

        private void TabUpdateUser_Click(object sender, EventArgs e)
        {

        }
    }
}
