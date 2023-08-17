using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;
namespace BankConsoleApplication
{
   public class clsLoginScreen:clsScreen 
    {

 



	private static bool _Login()
	{
		string username = "", Password = ""; 
		bool Falidlogin = false; 
		short FalidLogincounter = 0;
    
		
		do{
			
			
			if (Falidlogin)
			{
				FalidLogincounter++;
				Console.WriteLine( "\nInvlaid Username/Password!");
			Console.Write("You have " + (3 - FalidLogincounter)+" Trial(s) to login\n\n");
            Console.Write("\n Your are Loked after 3 falid trails\n\n");
				
			}
			if (FalidLogincounter == 3)
			{
				Console.Write ("\n Your are Loked after 3 falid trails\n\n");
				return false;
			}
			Console.Write( "\nEnter Username? ");
            username =Console.ReadLine();
		

		Console.Write( "\nEnter Password? ");
            Password  =Console.ReadLine();
			
            
				 
            CurrentUser = clsUser.Find(username,Password );
                Falidlogin = (CurrentUser == null);
			
			
		} while (Falidlogin);

        CurrentUser.RegisterLogin();
     
        clsMainMenue.ShowMainMenuScreen();
  
        return true;
    
   

	}


	public static bool ShowLoginScreen()
	{
		_DrawHeaderScreen("Login Screen");
	
			return _Login();
		
	

	}
	
    }
}
