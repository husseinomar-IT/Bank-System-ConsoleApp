using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankBusinisLayer;

namespace BankConsoleApplication
{
   public class clsMangeUserMenue:clsScreen
    {

       enum enMangeUserOption{ListUser=1,AddNewUser=2,DeletUser=3,UpdateUser=4,FindUser=5,MainMenue};

       private static void _BacktoMAngeUserMenue()
       {
           Console.WriteLine(String.Format("{0,37:D}", "") + "press any key to  go back to  Main Menue...");
           Console.ReadKey();
           clsMangeUserMenue.ShowMangeUserScreen();
       }



       private static short _ReadMangeMenueOption()
       {
           short Num;
           Console.Write(String.Format("{0,37:D}", "") + "Choose what do you want to do ?[1 to 6]?");
           Num = clsInputValidate.ReadshortNumberBetween(1, 6, "Enter number between 1 and 10 \n");
           return Num;

       }

       private  static void _PerforimManageUserOption(enMangeUserOption Option)
       {
           switch (Option )
           {
               case enMangeUserOption.ListUser :
                   Console.Clear();
                   clsShowUserListScreen.ShowUsersListScreen();
                   _BacktoMAngeUserMenue();
                   break;




               case enMangeUserOption.AddNewUser :
                   Console.Clear();
                   clsAddNewUserScreeen.ShowAddNewUserScreen();
                   _BacktoMAngeUserMenue();
                   break;







               case enMangeUserOption.DeletUser:
                   Console.Clear();
                   clsDeleteUserScreen.ShowDeleteScreen();
                   _BacktoMAngeUserMenue();
                   break;




               case enMangeUserOption.UpdateUser:
                   Console.Clear();
                   clsUpdateUserScreen.ShowUpdateUserScreen();
                   _BacktoMAngeUserMenue();
                   break;



               case enMangeUserOption.MainMenue :
                  
                   break;





             

           }
       }
     public  static void ShowMangeUserScreen()
	{
		Console .Clear ();
		if (!CheckAccessRight(clsUser.enUserPerimission.eManageUser))
		{
			return;
		}
		_DrawHeaderScreen("Manage User Menue Screen");

	  Console.WriteLine(String.Format("{0,37:D}", "") + "=====================================================");
	  Console.WriteLine(String.Format("{0,37:D}", "") +  "\t\tManage Users Munue Screen           ");
	  Console.WriteLine(String.Format("{0,37:D}", "") + "=====================================================");
	  Console.WriteLine(String.Format("{0,37:D}", "") + "\t\t[1] List Users.");
	  Console.WriteLine(String.Format("{0,37:D}", "") +  "\t\t[2] Add New User.");
	  Console.WriteLine(String.Format("{0,37:D}", "") +  "\t\t[3] Delete User.");
	  Console.WriteLine(String.Format("{0,37:D}", "") +  "\t\t[4] Update User.");
	  Console.WriteLine(String.Format("{0,37:D}", "") +  "\t\t[5] Find User.");
	  Console.WriteLine(String.Format("{0,37:D}", "") +  "\t\t[6] Main Menue.");

	  Console.WriteLine(String.Format("{0,37:D}", "") + "=====================================================");
        _PerforimManageUserOption((enMangeUserOption)_ReadMangeMenueOption());

	}
    }
}
