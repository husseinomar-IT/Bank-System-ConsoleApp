using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;

namespace BankConsoleApplication
{
  public   class clsAddNewUserScreeen:clsScreen
    {


      private static void _ReadPersonInfo(ref clsPerson Person)
      {
          Console.WriteLine("\n\nUser Card\n");
          Console.WriteLine("__________________________________\n");
          Console.Write("\nFirstName:");
          Person.FirstName = Console.ReadLine();
          Console.Write("\nLastName:");
          Person.LastName = Console.ReadLine();
          Console.Write("\nEmail:");
          Person.Email = Console.ReadLine();
          Console.Write("\nPhone:");
          Person.Phone = Console.ReadLine();



      }

      private static int _ReadPerimission()
      {

          int perimission = 0;
          char Answer = 'n';
          Console.WriteLine("Do you want to give full access? y/n? ");
          Answer = Convert.ToChar(Console.ReadLine());
          if (Answer == 'Y' || Answer == 'y')
          {
              return -1;
          }

          Console.WriteLine("\n Do you want to give access to : \n");

          Console.WriteLine("\n show Client List? y/n:? ");
          Answer = Convert.ToChar(Console.ReadLine());

          if (Answer == 'Y' || Answer == 'y')
          {
              perimission += (int)clsUser.enUserPerimission.eShoeListClient;
          }


          Console.WriteLine("\n Add new Client? y/n:? ");
          Answer = Convert.ToChar(Console.ReadLine());

          if (Answer == 'Y' || Answer == 'y')
          {
              perimission += (int)clsUser.enUserPerimission.eAddNewClient;
          }


          Console.WriteLine("\n Delete Client? y/n:? ");
          Answer = Convert.ToChar(Console.ReadLine());

          if (Answer == 'Y' || Answer == 'y')
          {
              perimission += (int)clsUser.enUserPerimission.eDeleteClient;
          }




          Console.WriteLine("\n Update Client? y/n:? ");
          Answer = Convert.ToChar(Console.ReadLine());

          if (Answer == 'Y' || Answer == 'y')
          {
              perimission += (int)clsUser.enUserPerimission.eUpdateClient;
          }




          Console.WriteLine("\n Find Client? y/n:? ");
          Answer = Convert.ToChar(Console.ReadLine());

          if (Answer == 'Y' || Answer == 'y')
          {
              perimission += (int)clsUser.enUserPerimission.eFindClient;
          }



          Console.WriteLine("\nTransactions? y/n:? ");
          Answer = Convert.ToChar(Console.ReadLine());

          if (Answer == 'Y' || Answer == 'y')
          {
              perimission += (int)clsUser.enUserPerimission.eTransaction;
          }

          Console.WriteLine("\n Manage Users? y/n:? ");
          Answer = Convert.ToChar(Console.ReadLine());

          if (Answer == 'Y' || Answer == 'y')
          {
              perimission += (int)clsUser.enUserPerimission.eManageUser;
          }



          Console.WriteLine("\nLoginRegister Screen? y/n:? ");
          Answer = Convert.ToChar(Console.ReadLine());

          if (Answer == 'Y' || Answer == 'y')
          {
              perimission += (int)clsUser.enUserPerimission.eShowLoginRegister;
          }



          Console.WriteLine("\n Currency Exchange Screen? y/n:? ");
          Answer = Convert.ToChar(Console.ReadLine());

          if (Answer == 'Y' || Answer == 'y')
          {
              perimission += (int)clsUser.enUserPerimission.eCurrencyEXchang;
          }



          return perimission;






      }
      private static void _ReadUserInfo(ref clsUser  User)
      {


          Console.Write("\nPassword:");
          User.Password  = Console.ReadLine();
          Console.Write("\nPermission:");
          User.Permission = _ReadPerimission();

          Console.WriteLine("__________________________________\n");

      }



      public static void ShowAddNewUserScreen()
      {
          //if (!CheckAccessRight(clsUser::enUserPerimission::eAddNewClient))
          //{
          //    return;
          //}

    
          _DrawHeaderScreen("Add New User Screen");
          string Username = "";
          Console.Write("\nPlease Enter Username: ");
          Username = Console.ReadLine();

          while (clsUser.IsUserExsist(Username))
          {
              Console.Write("Username  is Exsit ,choose another one:\n");
              Username = Console.ReadLine();
          }

          clsPerson Person = new clsPerson();
          _ReadPersonInfo(ref Person);
          if (Person.Save())
          {
              clsUser User = new clsUser(Username,Person.PersonID);

              _ReadUserInfo(ref User);
              if (User.Save())
              {
                  Console.WriteLine("User Inserted Succssufuly:-)");
              }
              else
              {
                  Console.WriteLine("User is not  Inserted :-(");
              }
          }




      }
    }
}
