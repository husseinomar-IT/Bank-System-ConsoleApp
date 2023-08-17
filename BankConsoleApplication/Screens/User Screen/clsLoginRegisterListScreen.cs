using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;
using System.Data;

namespace BankConsoleApplication
{
   public  class clsLoginRegisterListScreen:clsScreen 
    {


         public static void _PrintUser(DataRow Row)
        {
           
            Console.Write(String.Format("{0,8:D}", "") + "| " + String.Format("{0,-30:D}", Row["RegisterDateTime"]));
            Console.Write("| " + String.Format("{0,-25:D}", Row["UserName"]));
            Console.Write("| " + String.Format("{0,-18:D}", Row["Password"]));
            Console.Write("| " + String.Format("{0,-16:D}", Row["Permission"].ToString()));
            Console.WriteLine();

        }
       public  static void  ShowLoginRegisterListScreen()
       {


           if(!CheckAccessRight (clsUser.enUserPerimission .eShowLoginRegister ))
           {
               return;
           }
           DataTable Dt=clsUser.GetAllLoginRegister();
            string title = "Register  List Screen";

            string Subtile = "(" + Convert.ToString(Dt.Rows.Count) + ") User(s) ";
            _DrawHeaderScreen(title, Subtile);

            Console.Write(String.Format("{0,8:D}", "") + "\n\t_______________________________________________________");
            Console.Write("_________________________________________\n");
            Console.WriteLine();
            Console.Write(String.Format("{0,8:D}", "") + "| " + (String.Format("{0,-30:D}", "DateTime")));
            Console.Write("| " + String.Format("{0,-25:D}", " User Name"));
            Console.Write("| " + String.Format("{0,-18:D}", "Password"));
            Console.Write("| " + String.Format("{0,-16:D}", "Perimission "));
            Console.Write(String.Format("{0,8:D}", "") + "\n\t_______________________________________________________");
            Console.Write("_________________________________________\n");
            if (Dt.Rows.Count == 0)
                Console.WriteLine("\t\t No Uesr(s) Available in the Log File\n");
            else


                foreach (DataRow Row in Dt.Rows)
                {

                    
                    _PrintUser(Row);
                }
       }
    }
}
