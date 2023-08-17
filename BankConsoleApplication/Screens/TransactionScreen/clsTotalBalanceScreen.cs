using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;
using System.Data;

namespace BankConsoleApplication
{
   public  class clsTotalBalanceScreen:clsScreen
    {
        public static void _PrintClient(DataRow Row)
        {
            // cout << setw(8) << left << "" << "| " << setw(15) << left << Client.GetAccountNumber();
            Console.Write(String.Format("{0,8:D}", "") + "| " + String.Format("{0,-15:D}", Row["AccountNumber"]));
            Console.Write("| " + String.Format("{0,-20:D}", Row["FullName"]));

            Console.Write("| " + String.Format("{0,-15:D}", Row["Phone"]));
            Console.Write("| " + String.Format("{0,-20:D}", Row["Email"]));
            //   Console.Write("| " + String.Format("{0,20:D}", Row["AccountNumber"]));
            Console.Write("| " + String.Format("{0,-10:D}", Row["PINCode"]));
            Console.Write("| " + String.Format("{0,-12:D}", Row["Balance"].ToString()));
            Console.WriteLine();

        }





        public static void ShowTotalBalnceScreen()
        {

            
            DataTable Dt = clsClient.GetAllClients();
            double TotalBalane =Convert.ToDouble ( Dt.Compute("SUM(Balance)", string.Empty));
         
           
            string title = "Client List Screen";

            string Subtile = "(" + Convert.ToString(Dt.Rows.Count) + ") Client(s) ";
            _DrawHeaderScreen(title, Subtile);

            Console.Write(String.Format("{0,8:D}", "") + "\n\t_______________________________________________________");
            Console.Write("_________________________________________\n");
            Console.WriteLine();
            Console.Write(String.Format("{0,8:D}", "") + "| " + (String.Format("{0,15:D}", "AccoutNumber")));
            Console.Write("| " + String.Format("{0,-20:D}", "Client Name"));
            Console.Write("| " + String.Format("{0,-15:D}", "Phone"));
            Console.Write("| " + String.Format("{0,-20:D}", "Email"));
            Console.Write("| " + String.Format("{0,-10:D}", "PinCode"));
            Console.Write("| " + String.Format("{0,-12:D}", "Balance "));
            Console.Write(String.Format("{0,8:D}", "") + "\t_______________________________________________________");
            Console.Write("_________________________________________\n");
            if (Dt.Rows.Count == 0)
                Console.WriteLine("\t\t No Clients Available in the System\n");
            else


                foreach (DataRow Row in Dt.Rows)
                {

                    //  Console.WriteLine("{0},{1},{2},{3},{4}", Row["FullName"], Row["Email"], Row["Phone"], Row["AccountNumber"], Row["PINCode"]);
                    _PrintClient(Row);
                }
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,37:D}","")+"TotalBalnce="+TotalBalane);


        }
    }
}
