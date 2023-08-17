using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;

namespace BankConsoleApplication
{
  public   class clsTransactionMenueScreen:clsScreen 
    {
      enum enTransactionMenueOption { Deposit = 1, Withdraw = 2, TotalBlances = 3, Transfer = 4, TransferLog = 5, MainMenue = 6 }
        private static void _BacktoTransactionMenue()
        {
            Console.WriteLine(String.Format("{0,37:D}", "") + "press any key to  go back to  Main Menue...");
            Console.ReadKey();
            clsTransactionMenueScreen.ShowTransactionScreen();
        }



        private static short _ReadTransactionMenueOption()
        {
            short Num;
            Console.Write(String.Format("{0,37:D}", "") + "Choose what do you want to do ?[1 to 6]?");
            Num = clsInputValidate.ReadshortNumberBetween(1, 6, "Enter number between 1 and 10 \n");
            return Num;

        }

        private static void _PerforimTransactionOption(enTransactionMenueOption Option)
        {
            switch (Option)
            {
                case enTransactionMenueOption.Deposit:
                    Console.Clear();
                    clsDepositeScreen.ShowDepositScreen();
                    _BacktoTransactionMenue();
                    break;




                case enTransactionMenueOption.Withdraw :
                    Console.Clear();
                    clsWithdrawScreen.Show_WithdrawScreen();
                    _BacktoTransactionMenue();
                    break;







                case enTransactionMenueOption.TotalBlances:
                    Console.Clear();
                    clsTotalBalanceScreen.ShowTotalBalnceScreen();
                    _BacktoTransactionMenue();
                    break;




                case enTransactionMenueOption.Transfer:
                    Console.Clear();
                    clsTransferScreen.ShowTransferScreen();
                    _BacktoTransactionMenue();
                    break;



                case enTransactionMenueOption.TransferLog:
                    Console.Clear();
                    clsTransferLogScreencs.ShowTransferLogList();
                    _BacktoTransactionMenue();
                    break;



                case enTransactionMenueOption.MainMenue :

                    break;







            }
        }

      public static void ShowTransactionScreen()
      {
          Console.Clear();
          if (!CheckAccessRight(clsUser.enUserPerimission.eTransaction))
          {
              return;
          }
          Console.Clear();
          _DrawHeaderScreen("Transaction  Menue Screen");
          Console.WriteLine(String.Format("{0,37:D}", "") + "=====================================================");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\tTransaction  Munue Screen           ");
          Console.WriteLine(String.Format("{0,37:D}", "") + "=====================================================");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[1] Deposit.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[2] Withdrae.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[3] Total Balance.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[4] Transfer.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[5] Transfer Log.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[6] Main Menue.");
          Console.WriteLine(String.Format("{0,37:D}", "") + "=====================================================");
          _PerforimTransactionOption ((enTransactionMenueOption )_ReadTransactionMenueOption());

      }
    }
}
