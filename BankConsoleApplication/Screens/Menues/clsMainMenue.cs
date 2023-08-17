using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;
namespace BankConsoleApplication
{
  public   class clsMainMenue:clsScreen 
    {

     private enum _enChooseWhatYouWan{ Show = 1, Add = 2, Delete = 3, Update = 4, Find = 5, Transaction = 6, ManageUser = 7, LoginRegister = 8,CurrencyExchange=9,Logout=10 };



     private static  void _BacktoMainMenue()
     {
         Console.WriteLine(String.Format("{0,37:D}", "") + "press any key to  go back to  Main Menue...");
         Console.ReadKey();
         clsMainMenue.ShowMainMenuScreen();
     }
    

     private  static short _ReadMainMenueOption()
      {
          short Num;
          Console.Write(String.Format("{0,37:D}", "") + "Choose what do you want to do ?[1 to 10]?");
          Num = clsInputValidate.ReadshortNumberBetween(1, 10, "Enter number between 1 and 10 \n");
          return Num;

      }

      private  static void _PerforimMainMenueOption(_enChooseWhatYouWan Option)
     {
          switch (Option)
          { 
              case _enChooseWhatYouWan.Show:
                  Console.Clear();
                  clsShowClientListScreen.ShowClientList();
                  _BacktoMainMenue();
                  break;

              case _enChooseWhatYouWan.Add :
                  Console.Clear();
                  clsAddNewClinet.ShowAddNewClientScreen();
                  _BacktoMainMenue();
                  break;
              case _enChooseWhatYouWan.Delete :
                  Console.Clear();
                  clsDeleteClientScreen.ShowDeleteScreen();
                  _BacktoMainMenue();
                  break;
              case _enChooseWhatYouWan.Update :
                  Console.Clear();
                  clsUpdateClientScreen.ShowUpdateClientScreen();
                  _BacktoMainMenue();
                  break;
              case _enChooseWhatYouWan.Find :
                  Console.Clear();
                  clsFindClientScreen.FindClientScreen();
                  _BacktoMainMenue();
                  break;
              case _enChooseWhatYouWan.ManageUser:
                  Console.Clear();
                  clsMangeUserMenue.ShowMangeUserScreen();
                  _BacktoMainMenue();
                  break;



              case _enChooseWhatYouWan.Transaction :
                  Console.Clear();
                  clsTransactionMenueScreen.ShowTransactionScreen();
                  _BacktoMainMenue();
                  break;



              case _enChooseWhatYouWan.LoginRegister :
                  Console.Clear();
                  clsLoginRegisterListScreen.ShowLoginRegisterListScreen();
                  _BacktoMainMenue();
                  break;
          }
     }


     public  static void ShowMainMenuScreen()
      {
          Console.Clear();
         
          _DrawHeaderScreen("Main Menue Screen", "");
         Console.Write ( "\n\n");
          
          Console.WriteLine(String.Format("{0,37:D}", "") + "=====================================================");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t\tMain Munue Screen");
          Console.WriteLine(String.Format("{0,37:D}", "") + "=====================================================");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[1] Show Client List.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[2] Add New Client.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[3] Delete Client.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[4] Update Client Info.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[5] Find Client.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[6] Transactions.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[7] Manage Users.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[8] Login Register.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[9] Currency Exchange.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[10] Exit.");

          Console.WriteLine(String.Format("{0,37:D}", "") + "=====================================================");
        
        
     
    
        
         _PerforimMainMenueOption((_enChooseWhatYouWan)_ReadMainMenueOption());

      }
    }
}
