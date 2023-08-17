using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           //clsFindClientScreen.FindClientScreen();
          // double a = Convert.ToDouble(Console.ReadLine());
           //clsUpdateClientScreen.ShowUpdateClientScreen();
           // clsAddNewClinet.ShowAddNewClientScreen();
           // Console.WriteLine(String.Format("{0,-50:D}", 2));
           // clsShowClientListScreen.ShowClientList();
          //  clsDeleteClientScreen.ShowDeleteScreen();
          // clsFindUserScreen.FindUserScreen();
         // clsUpdateUserScreen.ShowUpdateUserScreen();
           // clsDeleteUserScreen.ShowDeleteScreen();
           // clsAddNewUserScreeen.ShowAddNewUserScreen();
          //  clsShowUserListScreen.ShowUsersListScreen();
          //  clsMainMenue.ShowMainMenuScreen();

            while (true)
            {
                if (!clsLoginScreen.ShowLoginScreen())
                {
                    return;
                }
            }
        
          
        }
    }
}
