using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankBusinisLayer;

namespace BankConsoleApplication
{
   public  class clsShowUserListScreen:clsScreen 
    {

        public static void _PrintUser(DataRow Row)
        {
           
            Console.Write(String.Format("{0,8:D}", "") + "| " + String.Format("{0,-15:D}", Row["UserName"]));
            Console.Write("| " + String.Format("{0,-20:D}", Row["FullName"]));
            Console.Write("| " + String.Format("{0,-15:D}", Row["Phone"]));
            Console.Write("| " + String.Format("{0,-20:D}", Row["Email"]));
            Console.Write("| " + String.Format("{0,-10:D}", Row["Password"]));
            Console.Write("| " + String.Format("{0,-12:D}", Row["Permission"].ToString()));
            Console.WriteLine();

        }





        public static void ShowUsersListScreen()
        {

            DataTable Dt = clsUser.GetAllUsers();
            string title = "Users List Screen";

            string Subtile = "(" + Convert.ToString(Dt.Rows.Count) + ") User(s) ";
            _DrawHeaderScreen(title, Subtile);

            Console.Write(String.Format("{0,8:D}", "") + "\n\t_______________________________________________________");
            Console.Write("_________________________________________\n");
            Console.WriteLine();
            Console.Write(String.Format("{0,8:D}", "") + "| " + (String.Format("{0,-15:D}", "User Name")));
            Console.Write("| " + String.Format("{0,-20:D}", "Full Name"));
            Console.Write("| " + String.Format("{0,-15:D}", "Phone"));
            Console.Write("| " + String.Format("{0,-20:D}", "Email"));
            Console.Write("| " + String.Format("{0,-10:D}", "Password"));
            Console.Write("| " + String.Format("{0,-12:D}", "Perimission "));
            Console.Write(String.Format("{0,8:D}", "") + "\n\t_______________________________________________________");
            Console.Write("_________________________________________\n");
            if (Dt.Rows.Count == 0)
                Console.WriteLine("\t\t No Uesr(s) Available in the System\n");
            else


                foreach (DataRow Row in Dt.Rows)
                {

                    
                    _PrintUser(Row);
                }

        }
    }
}
