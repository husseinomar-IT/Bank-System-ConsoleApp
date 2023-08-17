using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;
namespace BankConsoleApplication
{



    public class clsTransferScreen:clsScreen 
    {

        private static string _ReadAccountNumber()
        {
            string AccountNumber = "";
            AccountNumber=Console .ReadLine();
            while (!clsClient .IsClientExsist (AccountNumber))
            {
                Console.Write("\n\nAccount number is not found,choose another one: ");
                AccountNumber = Console.ReadLine();
            }
            return AccountNumber;
        }



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





       private static  double _ReadAmount(clsClient  Clinet)
        {
            double amount;
            Console.Write("Please Enter a Amount:");
            amount = clsInputValidate.ReaddblNumber();
           while(amount>Clinet .Balance)
           {
               Console.Write("\nAmount Exceeds available,Enter another Amount ? ");
               amount = clsInputValidate.ReaddblNumber();
           }
           return amount;
        }
      public   static void ShowTransferScreen()
	{


		_DrawHeaderScreen("Transfer Screen");
	Console .Write ("\nPlease Enter Account Number to Transfer from : ");

		clsClient  SourceClient =clsClient .Find(_ReadAccountNumber());

			_PrintClient(SourceClient);
		
	Console.Write ( "\nPlease Enter Account Number to Transfer to : ");
		clsClient  DestinationClient = clsClient.Find(_ReadAccountNumber());
		
		
		_PrintClient(DestinationClient);
		

		double amount = _ReadAmount(SourceClient);

		

		char answer = 'n';
		Console .Write ( "\nAre you sure you want to perform this transaction? ");
        answer = Convert.ToChar(Console.ReadLine());
		
		if (answer == 'Y' || answer == 'y')
		{ 
			if (SourceClient.Transfer(amount, DestinationClient,CurrentUser.UserID ))
			{
				Console.Write ("\nTransfer done successfully\n");
				
			}

			else
			{
				Console.Write ("\n Falid Transfer \n");

			}
			_PrintClient(SourceClient);
			_PrintClient(DestinationClient);
			
		

			
		}

	}
    }
}
