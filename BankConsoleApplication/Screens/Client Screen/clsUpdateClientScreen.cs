using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;
namespace BankConsoleApplication
{
    public class clsUpdateClientScreen : clsScreen
    {
        private static void _PrintClient(clsClient Client)
        {
            Console.WriteLine("client Card\n");
            Console.WriteLine("__________________________________\n");
            Console.WriteLine("\nFiratName      : " + Client.FirstName);
            Console.WriteLine("\nLastName       : " + Client.LastName);
            Console.WriteLine("\nFullName       : " + Client.FullName());
            Console.WriteLine("\nEmail          : " + Client.Email);
            Console.WriteLine("\nPhone          : " + Client.Phone);
            Console.WriteLine("\nAccountNumber  : " + Client.AccountNumber);
            Console.WriteLine("\nPinCode        : " + Client.PINCode);
            Console.WriteLine("\nAccountBalance : " + Client.Balance);
            Console.WriteLine("__________________________________\n");
        }



        private static void _ReadCleintInfo( ref clsClient Client)
        {
            Console.Write("FirstName:");
            Client.FirstName = Console.ReadLine();
            Console.Write("LastName:");
            Client.LastName = Console.ReadLine();
            Console.Write("Email:");
            Client.Email = Console.ReadLine();
            Console.Write("Phone:");
            Client.Phone = Console.ReadLine();
            Console.Write("PINCode:");
            Client.PINCode = Console.ReadLine();
            Console.Write("Balance:");
            Client.Balance = Convert.ToDouble(Console.ReadLine());
       

        }



        public static void ShowUpdateClientScreen()
        {
            if (!CheckAccessRight(clsUser.enUserPerimission.eUpdateClient))
            {
                return;
            }
            _DrawHeaderScreen("Update Client Screen");
            string AccountNumber = "";
            char answer = 'n';
            Console.WriteLine("\nPlease Enter Client Account Number: ");
            AccountNumber = Console.ReadLine();
            while (!clsClient.IsClientExsist(AccountNumber))
            {
                Console.WriteLine("Account number is not found,choose another one:\n");
                AccountNumber = Console.ReadLine();
            }
            clsClient Client = clsClient.Find(AccountNumber);
            _PrintClient(Client);
            Console.WriteLine("\n Do you Want to Update this Client?? y/n ");
            answer = Convert.ToChar(Console.ReadLine());
            if (answer == 'Y' || answer == 'y')
            {
                Console.WriteLine("\n\nUpdate Client Info:\n");
                Console.WriteLine("_________________________________\n");


                _ReadCleintInfo(ref Client);

                clsPerson Person = new clsPerson(Client.FKPersonID, Client.FirstName, Client.LastName, Client.Email, Client.Phone);

              
                if (Client.Save())
                {
                    Person.Save();
                 
                    Console.WriteLine("Client Updated successfuly:-)");
                }
                else
                {
                    Console.WriteLine("Client is not Updated :-(");
                }


            }
        }

    }
}