using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;

namespace BankConsoleApplication
{
  public   class clsFindClientScreen:clsScreen
    {
    private    static void _PrintClient(clsClient Client)
      {
         Console .WriteLine ( "client Card\n");
      Console .WriteLine("__________________________________\n");
      Console.WriteLine("\nFiratName      : " + Client.FirstName );
      Console.WriteLine ("\nLastName       : "+  Client.LastName );
      Console.WriteLine ("\nFullName       : " +Client.FullName());
      Console.WriteLine ( "\nEmail          : " + Client.Email );
      Console.WriteLine ( "\nPhone          : "+Client.Phone );
      Console.WriteLine("\nAccountNumber  : " + Client.AccountNumber);
      Console.WriteLine("\nPinCode        : " + Client.PINCode);
      Console.WriteLine("\nAccountBalance : " + Client.Balance);
      Console.WriteLine("__________________________________\n");
      }

    
     public  static void FindClientScreen()


	{


        if (!CheckAccessRight(clsUser.enUserPerimission.eFindClient))
        {
            return;
        }
        
		_DrawHeaderScreen("Find Client Screen");
		string AccountNumber = "";
	Console .WriteLine ( "\nPlease Enter Client Account Number: ");
		AccountNumber =Console.ReadLine();
		while ( !clsClient.IsClientExsist(AccountNumber))
		{
				Console .WriteLine (  "Account number is not found,choose another one:\n");
			AccountNumber = Console.ReadLine();
		}
		clsClient Client1 = clsClient.Find(AccountNumber);
		if (Client1!=null )
		{
		Console .WriteLine ("\nFound Client :-)\n\n");
		}
		else
		{
		Console .WriteLine ( "\nClient Was not Found :-(\n\n");
		}
	
		_PrintClient(Client1);
	}



    }
}
