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
    public partial class FrmLogin : BankWindowsFormsApplication.FromScreen
    {



        public string Username = "";
        public string Password = "";
        public short LoginCounter = 0;


        
        public FrmLogin()
        {
            InitializeComponent();
            _RefreshFromLogin();
          
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }




    



        private void _RefreshFromLogin()
        {
            txtUsername.Text = "Enter Your Name:";
            txtUsername.ForeColor = Color.Red;
            txtPassword.Text = "Enter Password:";
            txtPassword.ForeColor = Color.Red;


        }

        private void CheckLogin()
        {

          


            if (CurrentUser == null)
            {


                if (LoginCounter == 3)
                {
                    btnLogin.Enabled = false;
                    lblWarning.Text = "Your are Loked after 3 falid trails";

                }
                else
                {
                    lblWarning.Text = @"Invlaid Username/Password!
You have" + (3 - LoginCounter) + " Trial(s) to login";

                }
 

            

               

            }
            else
            {
                CurrentUser.RegisterLogin();
                lblUserName.Text = CurrentUser.UserName;
                _RefreshFromLogin();
                FrmMainMenue MainMenue = new FrmMainMenue();
              
                MainMenue.ShowDialog();
               this.Close();
            }




        }

             
            
              
           
        


   
        private void LoginButton1_Click(object sender, EventArgs e)
        {
          if(LoginCounter <3)
          {
              CurrentUser = clsUser.Find(txtUsername.Text, txtPassword.Text);
              LoginCounter++;
              CheckLogin();
          }
       


    
             
                
           



      

            

          
           
           

        }

        

     

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void _PasswordMode(PictureBox picbox)
        {
           
           switch (picbox .Tag.ToString())
            {
               case "Hiden":

                    picHidePassword.Image = Properties.Resources.hide_password1;
                    txtPassword.PasswordChar = '•';
                txtPassword.UseSystemPasswordChar = true;
               
                picbox.Tag = "Show";
             
                break;

               case "Show":
                picHidePassword.Image = Properties.Resources.show_password1 ;
                txtPassword.UseSystemPasswordChar = false ;
                picbox.Tag = "Hiden";
             
                break;
            }
        }

        private void picHidePassword_Click(object sender, EventArgs e)
        {
           
           
            _PasswordMode((PictureBox)sender);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if(txtUsername .Text ==txtUsername .Tag.ToString ())
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_MouseLeave(object sender, EventArgs e)
        {
            if(txtUsername.Text ==string.Empty )
            {
                txtUsername.Text = "Enter Your Name:";
                txtUsername.ForeColor = Color.Red;
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text ==txtPassword.Tag.ToString ())
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if(txtPassword.Text ==string .Empty )
            {
                txtPassword.Text = "Enter Password:";
                txtPassword.ForeColor = Color.Red;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
         
        }
    }
}
