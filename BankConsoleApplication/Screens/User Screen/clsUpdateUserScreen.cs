using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;

namespace BankConsoleApplication
{
   public class clsUpdateUserScreen:clsScreen
    {



    private   static int _ReadPerimission()
	{

		int perimission = 0;
		char Answer = 'n';
		Console.WriteLine( "Do you want to give full access? y/n? ");
	  Answer=Convert.ToChar (Console .ReadLine ());
		if (Answer == 'Y' || Answer == 'y')
		{
			return -1;
		}

		Console.WriteLine("\n Do you want to give access to : \n");

			Console.WriteLine( "\n show Client List? y/n:? ");
		  Answer=Convert.ToChar (Console .ReadLine ());

		if (Answer == 'Y' || Answer == 'y')
		{
			perimission += (int)clsUser.enUserPerimission.eShoeListClient;
		}


		Console.WriteLine( "\n Add new Client? y/n:? ");
	  Answer=Convert.ToChar (Console .ReadLine ());

		if (Answer == 'Y' || Answer == 'y')
		{
			perimission +=(int)clsUser.enUserPerimission.eAddNewClient ;
		}


		Console.WriteLine( "\n Delete Client? y/n:? ");
	  Answer=Convert.ToChar (Console .ReadLine ());

		if (Answer == 'Y' || Answer == 'y')
		{
			perimission += (int)clsUser.enUserPerimission.eDeleteClient;
		}




	Console.WriteLine("\n Update Client? y/n:? ");
	  Answer=Convert.ToChar (Console .ReadLine ());

		if (Answer == 'Y' || Answer == 'y')
		{
			perimission += (int)clsUser.enUserPerimission.eUpdateClient;
		}




		Console.WriteLine("\n Find Client? y/n:? ");
		Answer=Convert.ToChar (Console .ReadLine ());

		if (Answer == 'Y' || Answer == 'y')
		{
			perimission += (int)clsUser.enUserPerimission.eFindClient;
		}



			Console.WriteLine("\nTransactions? y/n:? ");
		Answer=Convert.ToChar (Console .ReadLine ());

		if (Answer == 'Y' || Answer == 'y')
		{
			perimission +=(int)clsUser.enUserPerimission.eTransaction;
		}

			Console.WriteLine("\n Manage Users? y/n:? ");
		Answer=Convert.ToChar (Console .ReadLine ());

		if (Answer == 'Y' || Answer == 'y')
		{
			perimission += (int)clsUser.enUserPerimission.eManageUser ;
		}



		Console.WriteLine("\nLoginRegister Screen? y/n:? ");
		Answer=Convert.ToChar (Console .ReadLine ());

		if (Answer == 'Y' || Answer == 'y')
		{
			perimission += (int)clsUser.enUserPerimission.eShowLoginRegister ;
		}



	Console.WriteLine("\n Currency Exchange Screen? y/n:? ");
		Answer=Convert.ToChar (Console .ReadLine ());

		if (Answer == 'Y' || Answer == 'y')
		{
			perimission += (int)clsUser.enUserPerimission.eCurrencyEXchang ;
		}



		return perimission;






	}



       private static void _ReadUserInfo( ref clsUser User)
       {
         Console.Write ( "\n_________________________________\n");
	 Console.Write("\nFirstname      : ");
		User.FirstName = Console .ReadLine();
	 Console.Write( "\nLastname      : ");
		User.LastName=Console.ReadLine ();
	 Console.Write("\nEmail          : ");
		User.Email = Console.ReadLine ();
     Console.Write("\nPhone          : ");
		User.Phone  =  Console.ReadLine ();
	  Console.Write("\nPassword      : ");
      User.Password = Console.ReadLine();
      Console.Write("\nPermission    : ");
      User.Permission = _ReadPerimission();
      Console.Write("\n_________________________________\n");

       }

       private static void _PrintUser(clsUser User)
       {
           Console.WriteLine("User Card\n");
           Console.WriteLine("__________________________________\n");
           Console.WriteLine("\nFiratName      : " + User.FirstName);
           Console.WriteLine("\nLastName       : " + User.LastName);
           Console.WriteLine("\nFullName       : " + User.FullName());
           Console.WriteLine("\nEmail          : " + User.Email);
           Console.WriteLine("\nPhone          : " + User.Phone);
           Console.WriteLine("\nUsername       : " + User.UserName);
           Console.WriteLine("\nPassword       : " + User.Password);
           Console.WriteLine("\nPinCode        : " + User.Permission);
           Console.WriteLine("__________________________________\n");
       }
     public  static void ShowUpdateUserScreen()
	{
		_DrawHeaderScreen("Update User Screen");
		string username = "";
		char answer = 'n';
		Console.WriteLine( "\nPlease Enter Username: ");
		username =Console .ReadLine();
		while (!clsUser.IsUserExsist(username))
		{
				Console.WriteLine( "Username is not found,choose another one: ");
		username =Console .ReadLine();
		}
		clsUser User1=clsUser.Find(username);
		_PrintUser(User1);
	Console.WriteLine( "\n Do you Want to Update this User?? y/n ");
	answer=Convert.ToChar(Console .ReadLine());	
		if (answer == 'Y' || answer == 'y')
		{
		Console.WriteLine( "\n\nUpdate User Info:\n");
		Console.WriteLine( "_________________________________\n");


			_ReadUserInfo(ref User1);


            clsPerson Person = new clsPerson(User1.PersonID, User1.FirstName, User1.LastName, User1.Email, User1.Phone);


            if (User1.Save())
            {
                Person.Save();

                Console.WriteLine("Usert Updated successfuly:-)");
            }
            else
            {
                Console.WriteLine("User is not Updated :-(");
            }
		
		}

	}
    }
}
