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
    public partial class FrmMainMenue : BankWindowsFormsApplication.FromScreen
    {
        public FrmMainMenue()
        {
            InitializeComponent();
            
        }
        public FrmLogin frmLogin = new FrmLogin();
        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(!CheckAccessRight((Button )sender ))
            {
                return;
            }
            FrmClientsManagment FrmClients = new FrmClientsManagment();
            FrmClients.ShowDialog();
        }

        private void btnUsersMangment_Click(object sender, EventArgs e)
        {
            if (!CheckAccessRight((Button)sender))
            {
                return;
            }
            FrmUserManagment FrmUser = new FrmUserManagment();
            FrmUser.ShowDialog();
        }

        private void btnTransactionManagment_Click(object sender, EventArgs e)
        {
            if (!CheckAccessRight((Button)sender))
            {
                return;
            }
            FrmTransaction FrmTransaction = new FrmTransaction("","");
            FrmTransaction.ShowDialog();
        }

   
        private void btnLogOut_Click(object sender, EventArgs e)
        {
          //  this.Close();
            this.Visible = false;
            CurrentUser = clsUser.Find("", "");
         
            frmLogin.ShowDialog();
          
        }
    }
}
