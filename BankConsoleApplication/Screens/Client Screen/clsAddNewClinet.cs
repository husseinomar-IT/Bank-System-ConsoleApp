using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;

namespace BankConsoleApplication
{
   public  class clsAddNewClinet:clsScreen
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


       private static void _ReadCleintInfo(ref clsClient Client)
       {
         
       
           Console.Write("\nPINCode:");
           Client.PINCode = Console.ReadLine();
           Console.Write("\nBalance:");
           Client.Balance = Convert.ToDouble(Console.ReadLine());


       }

       private static void _ReadPersonInfo(ref clsPerson Person)
       {
           Console.WriteLine("client Card\n");
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

     public   	static void   ShowAddNewClientScreen()
	{
        if (!CheckAccessRight(clsUser.enUserPerimission.eAddNewClient))
        {
            return;
        }

		_DrawHeaderScreen("Add Client Screen");
		string AccountNumber = "";
		Console .Write ( "\nPlease Enter Client Account Number: ");
		AccountNumber =Console.ReadLine ();

		while (clsClient.IsClientExsist(AccountNumber ))
		{
			Console .Write (  "Account number is Exsit ,choose another one:\n");
				AccountNumber =Console.ReadLine ();
		}

            clsPerson  Person=new clsPerson ();
             _ReadPersonInfo(ref Person);
            if(Person.Save() )
            {
                clsClient Client=new clsClient (AccountNumber ,Person.PersonID);
                _ReadCleintInfo(ref Client );
                if(Client.Save())
                {
                    Console.WriteLine("Client Inserted Succssufuly:-)");
                }
                else
                {
                     Console.WriteLine("Client is not  Inserted :-(");
                }
            }
         
    
		

	}
    }
}
