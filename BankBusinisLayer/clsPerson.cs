using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccess;

namespace BankBusinisLayer
{
  public   class clsPerson
    {




    public   enum enMode { Update = 0, AddNew = 1 };

      public enMode Mode = enMode.Update;
      public int PersonID { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Email { get; set; }
      public string Phone { get; set; }
       


   
      public clsPerson ()
      {
          this.PersonID = -1;
          this.FirstName = string.Empty;
          this.LastName = string.Empty;
          this.Email = string.Empty;
          this.Phone = string.Empty;



          Mode = enMode.AddNew;

      }
      public  clsPerson(int PersonID,string FirtsName,string LastName,string Email,string Phone)
      {
          this.PersonID = PersonID;
          this.FirstName = FirtsName;
          this.LastName = LastName;
          this.Email = Email;
          this.Phone = Phone;



          Mode = enMode.Update;

      }



      public static clsPerson Find(int PersonID,  ref string FirstName, ref string LastName, ref string Email, ref string Phone)
      {
          if (clsPersonDataAccess.Find(PersonID, ref FirstName, ref LastName, ref Email, ref Phone))
              return new clsPerson(PersonID, FirstName, LastName, Email, Phone);
          else
              return null;
      }



      public string FullName()
      {
          return (this.FirstName + " " + this.LastName);
      }


       private bool _UpdatePerson()
      {
          return clsPersonDataAccess.UpdatePerson(this.PersonID, this. FirstName, this. LastName, this. Email, this. Phone);
      }


      private bool _AddNewPerson()
       {
           this.PersonID = clsPersonDataAccess.AddNewPerson(this.FirstName, this.LastName, this.Email, this.Phone);
           return (this.PersonID != -1);
       }




   

      public virtual bool Save()
      {
          switch (Mode)
          {
              case enMode.Update:
                  return _UpdatePerson();
          
              case enMode.AddNew:
                  if(_AddNewPerson ())
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
