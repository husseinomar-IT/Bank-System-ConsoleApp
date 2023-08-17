using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;
namespace BankConsoleApplication
{
  public   class clsDeleteUserScreen: clsScreen 
    {

      private static void _PrintUser(clsUser User)
      {
          Console.WriteLine("User Card\n");
          Console.WriteLine("__________________________________\n");
          Console.WriteLine("\nFiratName      : " + User.FirstName);
          Console.WriteLine("\nLastName       : " + User.LastName);
          Console.WriteLine("\nFullName       : " + User.FullName());
          Console.WriteLine("\nEmail          : " + User.Email);
          Console.WriteLine("\nPhone          : " + User.Phone);
          Console.WriteLine("\nUsername       : " + User.UserName);
          Console.WriteLine("\nPassword       : " + User.Password);
          Console.WriteLine("\nPinCode        : " + User.Permission);
          Console.WriteLine("__________________________________\n");
      }
      public static void ShowDeleteScreen()
      {
          _DrawHeaderScreen("Delete User Screen");
          string UserName = "";
          char answer = 'n';
          Console.WriteLine("\nPlease Enter Username: ");
          UserName  = Console.ReadLine();
          while (!clsUser.IsUserExsist(UserName))
          {
              Console.WriteLine("Username  is not found,choose another one:\n");
              UserName = Console.ReadLine();
          }

          clsUser User1 = clsUser.Find(UserName);
          if (User1 != null)
              _PrintUser(User1);
          Console.WriteLine("Are you Sure you Want To Delete This  User with Username:[" + User1.UserName  + "] Y/N ?");
          answer = Convert.ToChar(Console.ReadLine());
          if (answer == 'Y' || answer == 'y')
          {
              if (User1.Delete())

                  Console.WriteLine("User Deleted Successfuly :-)");
              else

                  Console.WriteLine("User is not Deleted  :-(");
          }
      }
    }
}
