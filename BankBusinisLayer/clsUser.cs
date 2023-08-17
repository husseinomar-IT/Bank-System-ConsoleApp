using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankDataAccess;

namespace BankBusinisLayer
{
   public  class clsUser:clsPerson 
    {



     public   enum enUserPerimission
       {
           eAll = -1, eShoeListClient = 1, eAddNewClient = 2,
           eDeleteClient = 4, eUpdateClient = 8, eFindClient = 16, eTransaction = 32, eManageUser = 64, eShowLoginRegister = 128, eCurrencyEXchang = 256
       };


 // public     enUserPerimission PermissionUser = enUserPerimission.eAll;
      public enum enMode { Update = 0, AddNew = 1};
       public enMode Mode = enMode.Update;
       public int UserID { get; set; }
       public string UserName { get; set; }
       public string Password { get; set; }
       public int Permission { get; set; }
       public int PersonID { get; set; }
       private DateTime _dt = DateTime.Now;





     public clsUser ()
       {

       }


       public clsUser(string Username,int FKPersonID)
       {
           this.UserID = -1;
           this.UserName = Username;
           this.Password = String.Empty;
           this.Permission = -1;
           this.PersonID = FKPersonID;

           Mode = enMode.AddNew;
       }



       public clsUser (int UserID,string FirstName,string LastName,string Email,string Phone,string Username,string Password,int Permission,int FKPersonID)
       {
           this.UserID = UserID;
           this.FirstName = FirstName;
           this.LastName = LastName;
           this.Email = Email;
           this.Phone = Phone;
           this.UserName = Username;
           this.Password = Password;
           this.Permission = Permission;
           this.PersonID = FKPersonID;
           Mode = enMode.Update;
       }



   


       public static clsUser Find(string Username)
       {
           int UserID = -1;
           int PersonID = -1;
           string FirstName = "", LastName = "", Email = "", Phone = "", Password = "";
           int Permission=-1;
           double Balance = 0;

           if (clsUserDataAccess.FindByUsername(Username, ref UserID, ref Password, ref Permission, ref  PersonID))                
           {


               clsPerson Person = clsPerson.Find(PersonID, ref FirstName, ref LastName, ref Email, ref Phone);
               if (Person != null)
               {
                   return new clsUser(UserID, FirstName, LastName, Email, Phone, Username, Password, Permission, PersonID);
               }

               else
               {
                   return null;
               }
           }

           else
               return null;
       }

       public static clsUser Find(string Username,string Password)
       {
           int UserID = -1;
           int PersonID = -1;
           string FirstName = "", LastName = "", Email = "", Phone = "";
           int Permission = -1;
           double Balance = 0;

           if (clsUserDataAccess.FindByUsernameAndPassword(Username, ref UserID, Password, ref Permission, ref  PersonID))
           {


               clsPerson Person = clsPerson.Find(PersonID, ref FirstName, ref LastName, ref Email, ref Phone);
               if (Person != null)
               {
                   return new clsUser(UserID, FirstName, LastName, Email, Phone, Username, Password, Permission, PersonID);
               }

               else
               {
                   return null;
               }
           }

           else
               return null;
       }


       public static bool IsUserExsist(string Username)
       {
          return clsUserDataAccess.IsUserExsist(Username);

       }

       private bool _UpdateUser()
       {
           return clsUserDataAccess.UpdateUser(this.UserName, this.Password, this.Permission);
       }

          public bool RegisterLogin()
      {
          return clsUserDataAccess.RegisterLogin(UserID,_dt);
      }




       public bool Delete()
       {
           return clsUserDataAccess.DeleteUser(this.UserName);
       }

       public static bool Delete(int userid)
       {
           return clsUserDataAccess.DeleteUser(userid);
       }


       private bool _AddNewUser()
       {
           this.UserID = clsUserDataAccess.AddNewUser(this.UserName, this.Password, this.Permission, this.PersonID);
           return (this.UserID != -1);
           
       }






       public static DataTable GetAllUsers()
       {
           return clsUserDataAccess.GetAllUsers();
       }



   



      public  	 bool CheckAccessPerimission(enUserPerimission Perimission)
	{
        if (this.Permission == (int)enUserPerimission.eAll)
		{
			return true;
		}

		if (((int)Perimission &this.Permission )== (int)Perimission)


			return true;
		else

			return false;

	}
      public bool CheckAccessPerimission(int btnPermission)
      {
          if (this.Permission == -1)
          {
              return true;
          }

          if ((btnPermission & this.Permission) == btnPermission)


              return true;
          else

              return false;

      }







       public static DataTable GetAllLoginRegister()
      {
          return clsUserDataAccess.GetAllLoginRegister();
      }

       public override bool Save()
       {
           switch (Mode)
           {
               case enMode.Update:

                   return _UpdateUser();
               case enMode.AddNew:
                   if (_AddNewUser())
                   {
                       Mode = enMode.Update;
                       return true;
                   }
                   else
                   {
                       return false;
                   }


           }
           return false;

       }
    }
}
