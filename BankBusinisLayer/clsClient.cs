using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankDataAccess;

namespace BankBusinisLayer
{
    public class clsClient:clsPerson

    {

        public enum enMode { Update = 0, Addnew = 2, };
        public enMode Mode = enMode.Update;







        public int ClientID { get; set; }

        public String AccountNumber { get; set; }



        public string PINCode { get; set; }
        public double   Balance { get; set; }


        public int FKPersonID { get; set; }


     


     



    

      public static bool IsClientExsist(string AccountNumber)
        {
            return clsClientDataAccess.IsCLientExist(AccountNumber);

        }


      

        public clsClient(string AccountNumber,int FkPerson)
      {
          this.ClientID = -1;
          this.AccountNumber = AccountNumber;
          this.PINCode = "";
          this.Balance = 0;
          this.FKPersonID = FkPerson;
          Mode = enMode.Addnew;

      }



        private clsClient(int ClientID, string FirtsName,string LastName,string Email,string Phone,string AccountNumber,double  Balance,string PINCode,int FKPersonID):
          base(FKPersonID, FirtsName, LastName, Email, Phone)
        {

            this.ClientID = ClientID;
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            this.PINCode = PINCode;
            this.FKPersonID = FKPersonID;



            Mode = enMode.Update;
        }


        



        public static clsClient Find(string AccountNumber)
        {
            int ClinetID = -1;
            int PersonID = -1;
            string FirstName = "", LastName = "", Email = "", Phone = "", PINCode = "";
            double Balance=0;

            if (clsClientDataAccess.Find(AccountNumber, ref ClinetID, ref PINCode, ref Balance, ref PersonID))
            {


                clsPerson Person = clsPerson.Find(PersonID, ref FirstName, ref LastName, ref Email, ref Phone);
                if(Person  != null )
                {
                    return new clsClient(ClinetID, FirstName, LastName, Email, Phone, AccountNumber, Balance, PINCode, PersonID);
                }
            
                else
                {
                    return null;
                }
            }
               
            else
                return null;
        }




        private  bool _UpdateClient()
        {


            return clsClientDataAccess.UpdateClientInfo(this.ClientID,this.AccountNumber, this.PINCode, this.Balance);
           
              
              

        }


        private bool _AddNewClient()
        {
            this.ClientID = clsClientDataAccess.AddnewClient(this.AccountNumber, this.PINCode, this.Balance, this.FKPersonID);
            return (this.ClientID != -1);
        }


        public override  bool Save()
        {
            switch (Mode)
            {
                case enMode.Update:
                   
                    return _UpdateClient();
                case enMode.Addnew:
                    if (_AddNewClient())
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




        public static  DataTable GetAllClients()
        {
            return clsClientDataAccess.GetAllClientList();
        }




        public  bool Delete()
        {
            return clsClientDataAccess.DeleteClient(this.AccountNumber);
        }



        public static bool Delete(int ClientID)
        {
            return clsClientDataAccess.DeleteClient(ClientID);
        }



      



        public void Deposit(double amout)
        {
            Balance += amout;
            Save();
        }



      public  bool  CheckAmount(double amount)
      {
          return (amount <=this.Balance);
      }



        public static bool CheckBalane(string AccountNumber)
      {
          clsClient Client = clsClient.Find(AccountNumber);
          return (Client.Balance  > 0);
      }

        public  void WithDraw(double amount)
        {
          
            
                this.Balance -=amount ;
                Save();
             
          
        
                
        }






        private bool _RegisterTransferLog(double amount,clsClient DestinationClient,int UserID )
        {
            DateTime dt = DateTime.Now;

            return clsClientDataAccess.RegisterTransferlog(amount, ClientID, DestinationClient.ClientID, dt, UserID);
            
        }

       public bool  Transfer(double amount,clsClient DestinationClient,int UserID)
        {
           if(amount >Balance )
           {
               return false;
           }

           WithDraw(amount);
           DestinationClient.Deposit(amount);
           _RegisterTransferLog(amount, DestinationClient, UserID);

           return true;



        }



        public static DataTable GetAllTransferLog()
       {
           return clsClientDataAccess.GetAllTransferLog();
       }

    }
}
