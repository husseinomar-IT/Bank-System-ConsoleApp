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
    public partial class FrmClientsManagment : BankWindowsFormsApplication.FromScreen
    {
        public FrmClientsManagment()
        {
            InitializeComponent();

            FullListBox();
            
        }


        public DataTable datatable = new DataTable();
        public DataView Dataview1 = new DataView();

        private void dgvClientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabShowClients_Click(object sender, EventArgs e)
        {

        }
        private void _ReferishClientsList()
        {
            datatable  = clsClient.GetAllClients();
            DataView Dataview1 = datatable.DefaultView;
            dgvClientList.DataSource = Dataview1;
            


           
         
        }


        private void FullListBox()
        {
            DataView Dataview2 = new DataView();

          
          for(int i=0;i<dgvClientList.RowCount ;i++)
          {
              combAccountNumber.Items.Add(dgvClientList.Rows[i].Cells[4].Value);
                
          }
        }

        private void FrmClientsManagment_Load(object sender, EventArgs e)
        {
         
            _ReferishClientsList();
          
        }

        private void rdbtnAscOrder_CheckedChanged(object sender, EventArgs e)
        {
            dgvClientList.Sort(dgvClientList.Columns[0],ListSortDirection.Ascending);
        }

        private void rdbDesOrder_CheckedChanged(object sender, EventArgs e)
        {
            dgvClientList.Sort(dgvClientList.Columns[0], ListSortDirection.Descending );
        }

      
        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            //clsClient Client = clsClient.Find(txtAccountNumber.Text);
         
        
        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            Dataview1 = datatable.DefaultView;
            Dataview1.RowFilter = "AccountNumber like '%"+txtAccountNumber.Text+"%'";
           dgvClientList.DataSource = Dataview1;
                 
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        private void _ReadPersonInfo(ref clsPerson Person)
        {
            Person.FirstName = txtClientAddFirstname.Text;
            Person.LastName = txtClientAddLastname.Text;
            Person.Email = txtClientAddEmail.Text;
            Person.Phone = txtClientAddPhone.Text;
 
        }

        private void _ReadClientInfo(ref clsClient  Client)
        {
            Client.PINCode = txtClientAddPINCode.Text;
            Client.Balance = (double)numClientAUpDownAddBalance.Value;
        }
        private bool _AddNewClient()
        {
            clsPerson Person = new clsPerson();
            _ReadPersonInfo(ref Person);
            if (Person.Save())
            {
                clsClient Client = new clsClient(txtClientAddAccountNumber.Text, Person.PersonID);
                _ReadClientInfo(ref Client);
                if (Client.Save())
                {
                    return true;
                }
                else
                {
                    return false;
                }
             

            }
            else
            {
                return false;
            }
          


        }

        private void btnAddnewClient_Click(object sender, EventArgs e)
        {
            if(clsClient.IsClientExsist(txtClientAddAccountNumber.Text))
            {
                if(MessageBox.Show("this Account Number Already Exsists Enter Enother Acc","Error", MessageBoxButtons.OK,MessageBoxIcon.Error)==DialogResult .OK )
                {
                    txtClientAddAccountNumber.Clear();
                    txtClientAddAccountNumber.Focus();
                }
            }
            else
            {
               if(_AddNewClient ())
               {
                  if( MessageBox.Show("Client Added Successfuly","Add Client", MessageBoxButtons.OK,MessageBoxIcon.Asterisk)==DialogResult .OK )
                  {
                      _ReferishClientsList();
                      txtClientAddFirstname.Clear();
                      txtClientAddLastname.Clear();
                      txtClientAddEmail.Clear();
                      txtClientAddPhone.Clear();
                      txtClientAddPINCode.Clear();
                      txtClientAddAccountNumber.Clear();
                      numClientAUpDownAddBalance.Value = 0;
                  }

               }
               else
               {
                   MessageBox.Show("Client  is not Added ", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }

            }
        }

      
        private void numClientAUpDownAddBalance_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDouble(numClientAUpDownAddBalance.Value)<1000)
            {
                e.Cancel = true;
                numClientAUpDownAddBalance.Focus();
                errorProvider1.SetError(numClientAUpDownAddBalance, "Balance Must be greater than 1000");

            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numClientAUpDownAddBalance, "");
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Do you sure you want to Delete this Client with ID[" + dgvClientList.CurrentRow.Cells[0].Value + "]","Confirmation message",MessageBoxButtons.OK,MessageBoxIcon.Question)==DialogResult .OK )
           {
               if(clsClient.Delete ((int)dgvClientList.CurrentRow.Cells[0].Value))
               {
                   if(MessageBox .Show ("Client Deleted Successfuly","Message",MessageBoxButtons.OK)==DialogResult .OK )
                   {
                       _ReferishClientsList();
                   }

               }
               else
               {
                   MessageBox.Show("Client is not  Deleted ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
               }
               
           }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsClient Client = clsClient.Find(combAccountNumber.SelectedItem.ToString());
            if(Client !=null)
            {
                txtClientUpdateFirstname.Text = Client.FirstName;
                txtClientUpdateLastname.Text = Client.LastName;
                txtClientUpdateEmail.Text = Client.Email;
                txtClientUpdatePhone.Text = Client.Phone;
                txtClientUpdatePINCode.Text = Client.PINCode;
                txtClientUpdateAccountnumber.Text = Client.AccountNumber;
             nudUpdateClientBalnce.Value  = Convert.ToDecimal(Client.Balance);

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void _UpdateClientInfo(ref clsClient Client )
        {
            Client.FirstName = txtClientUpdateFirstname.Text;
            Client.LastName = txtClientUpdateLastname.Text;
            Client.Email = txtClientUpdateEmail.Text;
            Client.Phone = txtClientUpdatePhone.Text;
            Client.PINCode = txtClientUpdatePINCode.Text;
            Client.Balance = (double)nudUpdateClientBalnce.Value;
        }


        private bool _UpdateClinetRecord()
        {
            clsClient client = clsClient.Find(txtClientUpdateAccountnumber.Text);
            _UpdateClientInfo(ref client);
            clsPerson Person = new clsPerson(client.FKPersonID, client.FirstName, client.LastName, client.Email, client.Phone);
            if(Person .Save())
            {
              if(client .Save ())
              {
                  return true;
              }
              else
              {
                  return false;
              }
            }
            else
            {
                return false;
            }

        }
        private void _ClearTabUpdateTextboxs()
        {
            txtClientUpdateAccountnumber.Clear();
            txtClientUpdateEmail.Clear();
            txtClientUpdateFirstname.Clear();
            txtClientUpdateLastname.Clear();
            txtClientUpdatePhone.Clear();
            txtClientUpdatePINCode.Clear();
            nudUpdateClientBalnce.Value = 0;
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
          if(MessageBox .Show ("Are you sure you Want to Update this Client ?","Confirm Message",MessageBoxButtons.OKCancel ,MessageBoxIcon.Question )==DialogResult .OK )
          {
             if(_UpdateClinetRecord())
             {
                 MessageBox.Show("Client Updated Succssefuly", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 _ReferishClientsList();
                 _ClearTabUpdateTextboxs();

             }
             else
             {
                 MessageBox.Show("Client is not Updated ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
             }
          }

        }


        private void _Requiredtxt(TextBox txtbox, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox.Text))
            {
                e.Cancel = true;
                txtbox.Focus();
                errorProvider1.SetError(txtbox, "Field is required");
            }


            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtbox, "");
            }
        }

        private void txtRequiredFeild(object sender, CancelEventArgs e)
        {
            _Requiredtxt((TextBox)sender, e);
        }


     

     
    

  

      

  

        private void nudUpdateClientBalnce_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDouble(nudUpdateClientBalnce .Value ) < 1000)
            {
                e.Cancel = true;
                nudUpdateClientBalnce.Focus();
                errorProvider1.SetError(nudUpdateClientBalnce, "Balance Must be greater than 1000");

            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nudUpdateClientBalnce, "");
            }
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransaction Frm = new FrmTransaction(dgvClientList.CurrentRow.Cells [4].Value.ToString() ,"Deposit");
            Frm.ShowDialog();
           
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransaction Frm = new FrmTransaction(dgvClientList.CurrentRow.Cells[4].Value.ToString(), "Withdraw");
            Frm.ShowDialog();
        }

     

      
    }
}
