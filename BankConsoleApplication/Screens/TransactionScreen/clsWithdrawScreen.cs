using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;

namespace BankConsoleApplication
{
   public  class clsWithdrawScreen:clsScreen 
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

        public static void Show_WithdrawScreen()
        {
            _DrawHeaderScreen("withdraw Screen");
            string AccountNumber = "";
            Console.Write("\nPlease Enter Client Account Number:");
            AccountNumber = Console.ReadLine();
            while (!clsClient.IsClientExsist(AccountNumber))
            {
                Console.Write("Client with [" + AccountNumber + "] does not exist.\n");
                AccountNumber = Console.ReadLine();
            }
            clsClient Client = clsClient.Find(AccountNumber);

            _PrintClient(Client);
            double amount = 0;
            Console.Write("\nPlease enter withdraw amount? ");
            amount = clsInputValidate.ReaddblNumber();


            char answer = 'n';
            Console.Write("\nAre you sure you want to perform this transaction Y/N ? ");
            answer = Convert.ToChar(Console.ReadLine());
            if (answer == 'Y' || answer == 'y')
            {
                while(!Client.CheckAmount(amount) )
                {
                    Console.Write ("\nYou Can not WithDraw this Amount={0} your Balnce={1}, try to enter amount:" , amount, Client.Balance);
                    amount = clsInputValidate.ReaddblNumber();

                }
                Client.WithDraw (amount);
                Console.Write("\nAmount WithDraw Successfuly");
                Console.WriteLine("\nNew Balance is: " + Client.Balance);
                _PrintClient(Client);
            }


        }
    }
}
