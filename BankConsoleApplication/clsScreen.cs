using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;

namespace BankConsoleApplication
{
  public    class clsScreen
    {
      protected   static   string _Username { set; get; }



      public static clsUser CurrentUser = new clsUser();




      public static DateTime dt1 = new DateTime();

  




     
      protected  static void _DrawHeaderScreen(string Title, string SubTitle = "")
	{
             //DateTime dt1 = new DateTime();
          
          dt1=DateTime .Now ;
          
		Console .WriteLine ( "\t\t\t\t------------------------------------------------------------");
	Console .WriteLine ( "\n\n\t\t\t\t\t\t\t "+Title );
		if (SubTitle != "")
		{
			Console .WriteLine( "\n\t\t\t\t\t\t\t "+SubTitle ) ;
		}
	Console.WriteLine( "\n\n\t\t\t\t------------------------------------------------------------\n\n");
			Console.Write( "\t\t\t\tUser:"+CurrentUser .UserName );
    Console.WriteLine("\n\t\t\t\tDate:" + dt1);
   
		
	}



      public static bool CheckAccessRight(clsUser.enUserPerimission Permission)
      {
          if (!CurrentUser.CheckAccessPerimission(Permission))
          {
             Console.Write ( "\t\t\t\t------------------------------------------------------------");
             Console.Write ( "\n\n\t\t\t\t\t\t" + "Access Denied Contact your Admin ");
             Console.Write ("\n\n\t\t\t\t------------------------------------------------------------\n\n");
              return false;
          }
          else
          {


              return true;
          }
      }

      
    }
}
