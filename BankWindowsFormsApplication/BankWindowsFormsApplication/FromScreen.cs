using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinisLayer;
namespace BankWindowsFormsApplication
{
    public partial class FromScreen : Form
    {
        public DateTime dt = DateTime.Now;


        public static clsUser CurrentUser = new clsUser();



     
        public FromScreen()
        {
            InitializeComponent();
          
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frm2 = new FrmLogin();
            frm2.ShowDialog();
        }






        public static bool CheckAccessRight(Button btn)
        {
            if (!CurrentUser.CheckAccessPerimission(Convert.ToInt16(btn.Tag)))
            {
               
                MessageBox.Show("Access Denied Contact your Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {


                return true;
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        protected void _Refresh( )
        {
            if(CurrentUser!=null)
            {
                lblUserName.Text = CurrentUser.UserName;
            }
            else
            {
                lblUserName.Text = "";
            }
         

        }

        private void FromScreen_Load(object sender, EventArgs e)
        {


            lblDateTime.Text = dt.ToString();

            if (CurrentUser != null)
            {
                lblUserName.Text = CurrentUser.UserName;


            }
           
       
        }
    }
}
