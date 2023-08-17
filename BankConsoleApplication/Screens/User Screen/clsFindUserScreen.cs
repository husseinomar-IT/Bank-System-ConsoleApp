using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;

namespace BankConsoleApplication
{
  public   class clsFindUserScreen:clsScreen 
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
            Console.WriteLine("\nPassword       : " + User.Password );
            Console.WriteLine("\nPinCode        : " + User.Permission);
            Console.WriteLine("__________________________________\n");
        }



        public static void FindUserScreen()
        {


            //if (!CheckAccessRight(clsUser::enUserPerimission::eFindClient))
            //{
            //    return;
            //}

            _DrawHeaderScreen("Find User Screen");
            string Username = "";
            Console.WriteLine("\nPlease Enter UserName: ");
            Username = Console.ReadLine();
            while (!clsUser.IsUserExsist(Username))
            {
                Console.WriteLine("UserName is not found,choose another one:\n");
                Username = Console.ReadLine();
            }
            clsUser User1 = clsUser.Find(Username);
            if (User1 != null)
            {
                Console.WriteLine("\nFound User :-)\n\n");
            }
            else
            {
                Console.WriteLine("\nUser Was not Found :-(\n\n");
            }

            _PrintUser(User1);
        }
    }
}
