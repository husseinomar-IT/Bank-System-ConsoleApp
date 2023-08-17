using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;

namespace BankConsoleApplication
{
  public   class clsDeleteClientScreen:clsScreen
    {


      private static void _PrintClient(clsClient Client)
      {
          Console.WriteLine("\n\nclient Card\n");
          Console.WriteLine("__________________________________\n");
          Console.Write("\nFiratName      : " + Client.FirstName);
          Console.Write("\nLastName       : " + Client.LastName);
          Console.Write("\nFullName       : " + Client.FullName());
          Console.Write("\nEmail          : " + Client.Email);
          Console.Write("\nPhone          : " + Client.Phone);
          Console.Write("\nAccountNumber  : " + Client.AccountNumber);
          Console.Write("\nPinCode        : " + Client.PINCode);
          Console.Write("\nAccountBalance : " + Client.Balance);
          Console.WriteLine("\n__________________________________");
      }
      
      public  static void ShowDeleteScreen()

      {


          if (!CheckAccessRight(clsUser.enUserPerimission.eDeleteClient ))
          {
              return;
          }
          _DrawHeaderScreen("Delete Client Screen");
          string AccountNumber = "";
          char answer = 'n';
          Console.WriteLine("\nPlease Enter Client Account Number: ");
          AccountNumber = Console.ReadLine();
          while (!clsClient.IsClientExsist(AccountNumber))
          {
              Console.WriteLine("Account number is not found,choose another one:\n");
              AccountNumber = Console.ReadLine();
          }
          clsClient Client1 = clsClient.Find(AccountNumber);
          if (Client1 != null)
              _PrintClient(Client1);
          Console.WriteLine("Are you Sure you Want To Delete This  Client with AcccountNumber:[" + Client1.AccountNumber + "] Y/N");
          answer = Convert.ToChar(Console.ReadLine());
          if(answer =='Y' || answer =='y')
          {
             if(Client1.Delete ())
             
                 Console.WriteLine("Client Deleted Successfuly :-)");
             else

                 Console.WriteLine("Client is not Deleted  :-(");
          }
      }
    }
}
