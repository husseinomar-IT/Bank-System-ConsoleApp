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
    public partial class FrmTransaction : BankWindowsFormsApplication.FromScreen
    {
        public FrmTransaction(string AccountNumber, string FormTab)
        {
           
            InitializeComponent();
            _FillCombbox(comboboxDepositAccountNumber);
            _FillCombbox(comboboxwithdraw);
            _FillCombbox(comboboxFromAcc);
            _FillCombbox(comboBoxToAcc);
            CheckTap(AccountNumber, FormTab);

         
        }



        
        private void CheckTap(string Accountnumber,string formtab)
        {
            switch (formtab)
            {
                case "Deposit":
                    tabControl1.SelectedIndex = 0;
                    //TabDeposite.Show();
                    comboboxDepositAccountNumber.SelectedItem = Accountnumber;
                    break;



                case "Withdraw":
                 //   tabWithdraw.Show();
                    tabControl1.SelectedIndex = 1;
                    comboboxwithdraw.SelectedItem = Accountnumber;
                    break;
            }
        }
          

        public  DataTable datatable = new DataTable();
     


        public clsClient Client;
        public clsClient DesClient;
        private void _FillCombbox(ComboBox combobox)
        {
            datatable = clsClient.GetAllClients();
         foreach (DataRow Row in datatable.Rows )
         {
             combobox.Items.Add(Row["AccountNumber"]);
         }
        }




 
        private void FrmTransaction_Load(object sender, EventArgs e)
        {
            lblResult.Visible  = false;
            _RefreshTransferList();
        }


        private void _RefreshTransferList()
        {
            DataTable TransferdataTable = new DataTable();
            TransferdataTable = clsClient.GetAllTransferLog();
            dgvTransferLog.DataSource = TransferdataTable;
        }

        private void comboboxDepositAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
             Client = clsClient.Find(comboboxDepositAccountNumber.SelectedItem.ToString());
        }


        private void _RereshDepositScreen()
        {
            comboboxDepositAccountNumber.Text = "";
            comboboxDepositAccountNumber.Enabled = false;
            nudDepositAmount.Value = 50;
            btnDeposit.Enabled = false;
        }


        private void _RereshWithDrawScreen()
        {
            comboboxwithdraw.Text = "";
            comboboxwithdraw.Enabled = false;
            nudWithdrawAmount.Value = 50;
            btnWithdraw.Enabled = false;
        }




        private void _RereshTransferScreen()
        {
            comboboxFromAcc.Text = "";
            comboboxFromAcc.Enabled = false;
            comboBoxToAcc.Text = "";
            comboBoxToAcc.Enabled = false;

            nudTransaction.Value = 50;
            nudTransaction.Enabled = false;
            btnTransfer.Enabled = false;
        
           
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(MessageBox .Show ("Are you sure you want to Deposit Amout ["+nudDepositAmount.Value+"] For Account ["+Client.AccountNumber+"]","Confirm Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Question  )==DialogResult .OK )
            {
                Client.Deposit(Convert.ToDouble(nudDepositAmount.Value));
                lblResult.Visible = true;
                lblNewBalance.Text = Client.Balance.ToString();
                _RereshDepositScreen();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboboxwithdraw_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(!clsClient .CheckBalane(comboboxwithdraw .SelectedItem .ToString ()))
            {
               if( MessageBox.Show(" You not can do  Withdraw Abount Because Balane =0", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning)==DialogResult.OK )
                {
                    _RereshWithDrawScreen();
                    return;
                }
             
            }
            Client = clsClient.Find(comboboxwithdraw.SelectedItem.ToString());
            lblCurrentBalance.Text = Client.Balance + "$";
        }


        private void _AutokNumricUpDownWithdraw(NumericUpDown NumUpDown)
        {
            if (NumUpDown.Value > Convert.ToDecimal(Client.Balance))
            {
                NumUpDown.Value = Convert.ToDecimal(Client.Balance);
            }
        }
        private void nudWithdrawAmount_ValueChanged(object sender, EventArgs e)
        {
            _AutokNumricUpDownWithdraw((NumericUpDown)sender);
        }

        private void nudWithdrawAmount_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Withdraw Amout [" + nudDepositAmount.Value + "] For Account [" + Client.AccountNumber + "]", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Client.WithDraw(Convert.ToDouble(nudWithdrawAmount.Value ));

                lblCurrentBalance.Text = Client.Balance + "$";
                _RereshWithDrawScreen();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboboxFromAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (!clsClient.CheckBalane(comboboxFromAcc.SelectedItem .ToString ()))
            {
                MessageBox.Show(" You can  not  do  Withdraw Abount Because Balane =0", "Warnning");
               
                    _RereshTransferScreen();
                
               

            }
            else
            {
                Client = clsClient.Find(comboboxFromAcc.SelectedItem.ToString());
                comboBoxToAcc.Items.Remove(comboboxFromAcc.SelectedItem);
            }

         
        }

        private void comboBoxToAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesClient = clsClient.Find(comboBoxToAcc.SelectedItem.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _AutokNumricUpDownWithdraw((NumericUpDown)sender);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Trasfer Amout [" + nudTransaction.Value  + "] Form Acc [" + Client.AccountNumber + "] To Acc ["+DesClient .AccountNumber +"]", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
               if( Client.Transfer (Convert .ToDouble(nudTransaction .Value ),DesClient ,CurrentUser .UserID))
               {
                   MessageBox.Show("Transfer done Successfuly");
                   _RefreshTransferList();
                   _RereshTransferScreen();
               }
             
              
            }
        }
    }
}
