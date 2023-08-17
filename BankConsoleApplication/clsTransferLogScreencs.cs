using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;
using System.Data;

namespace BankConsoleApplication
{
   public  class clsTransferLogScreencs:clsScreen

    {

        public static void _PrintTransgerLog(DataRow Row)
        {

            Console.Write(String.Format("{0,8:D}", "") + "| " + String.Format("{0,-30:D}", Row["TransferDateTime"]));
            Console.Write("| " + String.Format("{0,-25:D}", Row["SourceAcc"]));
            Console.Write("| " + String.Format("{0,-18:D}", Row["Username"]));
            Console.Write("| " + String.Format("{0,-16:D}", Row["DesAccount"]));
            Console.WriteLine();

        }
        public static void ShowTransferLogList()
        {




            DataTable Dt = clsClient.GetAllTransferLog();
            string title = "TransferLog  List Screen";

            string Subtile = "(" + Convert.ToString(Dt.Rows.Count) + ") Transfer(s) ";
            _DrawHeaderScreen(title, Subtile);

            Console.Write(String.Format("{0,8:D}", "") + "\n\t_______________________________________________________");
            Console.Write("_________________________________________\n");
            Console.WriteLine();
            Console.Write(String.Format("{0,8:D}", "") + "| " + (String.Format("{0,-30:D}", "DateTime")));
            Console.Write("| " + String.Format("{0,-25:D}", " Source Acc"));
            Console.Write("| " + String.Format("{0,-18:D}", "Destination Acc"));
            Console.Write("| " + String.Format("{0,-16:D}", "Username "));
            Console.Write(String.Format("{0,8:D}", "") + "\n\t_______________________________________________________");
            Console.Write("_________________________________________\n");
            if (Dt.Rows.Count == 0)
                Console.WriteLine("\t\t No Transfer(s) Available in the Log File\n");
            else


                foreach (DataRow Row in Dt.Rows)
                {


                    _PrintTransgerLog(Row);
                }
        }
    }
}
