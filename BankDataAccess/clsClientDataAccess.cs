using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BankDataAccess
{
    public class clsClientDataAccess
    {
       public static bool  Find(string AccountNumber,ref int ClientID, ref string PINCode,ref double   Balance ,ref int PersonID )
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
//          
            string Query = @"Select * from  Clients where AccountNumber=@AccountNumber";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("AccountNumber", AccountNumber);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if(Reader.Read())
                {
                    IsFound = true;
                    ClientID = (int)Reader["ClientID"];
                    PINCode = (string)Reader["PINCode"];
                    Balance = Convert.ToDouble(Reader["Balance"]);
                    PersonID = (int)Reader["PersonID"];
                  //  ID = (int)Reader["ClientID"];
                    //FirstName = (string)Reader["FirstName"];
                    //LastName = (string)Reader["LastName"];
                    //Email = (string)Reader["Email"];
                    //Phone = (string)Reader["Phone"];
              
                }

                Reader.Close();

            }

           catch (Exception  ex)
            {

            }


           finally
            {
                Connection.Close();
            }
            return IsFound;
        }



       public static bool IsCLientExist(string  AccountNumber)
       {
           bool IsFound = false;
           SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
           string Query = @"select Found=1 from Clients  where AccountNumber=@AccountNumber";
           SqlCommand Command = new SqlCommand(Query, Connection);
           Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
           try
           {
               Connection.Open();
               SqlDataReader Reader = Command.ExecuteReader();
               IsFound = Reader.HasRows;
               Reader.Close();
           }


           catch (Exception ex)
           {

           }


           finally
           {

               Connection.Close();
           }
           return IsFound;
       }




        public static bool UpdateClientInfo(int ClientID,string AccountNumber,string PINCOde,double Balance)
       {
           int RowAffected = 0;
           SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
        

           string Query = @"Update [Clients] set 
                       [PINCode]=@PINCode,
                      [Balance]=@Balance
                      

                       where AccountNumber=@AccountNumber ";

           SqlCommand Command = new SqlCommand(Query, Connection);
           Command.Parameters.AddWithValue("@PINCode", PINCOde);
           Command.Parameters.AddWithValue("@Balance", Balance);
           Command.Parameters.AddWithValue("@AccountNumber", AccountNumber );
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();

            }
            catch (Exception  ex)
            {

            }

            finally
            {
                Connection.Close();
            }
            return (RowAffected > 0);



       }



        public static int AddnewClient(string AccountNumber,string PINCode,double Balance,int FKPersonID)
        {
            int ClientID = -1;
            int IndexID = -1;
            SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
            string Query = @"Insert Into Clients(AccountNumber,PINCode,Balance,PersonID)
                         Values   (@AccountNumber,@PINCode,@Balance,@FKPersonID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            Command.Parameters.AddWithValue("@PINCode", PINCode );
            Command.Parameters.AddWithValue("@Balance", Balance );
            Command.Parameters.AddWithValue("@FKPersonID", FKPersonID );
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if(Result !=null && int.TryParse(Result.ToString (),out IndexID ))
                {
                    ClientID = IndexID;
                }
            }
            catch (Exception  ex)
            {

            }

            finally
            {
                Connection.Close();
            }
            return ClientID;
        }




        public static  DataTable GetAllClientList()
        {
            DataTable Dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
            string Query = @"Select ClientID,FullName=FirstName+' '+LastName,Email,Phone,AccountNumber,PINCode,Balance
                           from Clients inner join Persons on 
                                Clients.PersonID=Persons.PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if(Reader.HasRows)
                {
                    Dt.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception  ex)
            {

            }

            finally
            {
                Connection.Close();
            }
            return Dt;
        }




        public static bool DeleteClient(int ClientID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
            string Query = @"Delete from Clients where ClientID=@ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);
        
            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
             
            }
            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }



        public static bool DeleteClient(string AccountNumber)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
            string Query = @"Delete from Clients where AccountNumber=@AccountNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }




        public static bool RegisterTransferlog(double amount,int SouClientID,int DesClientID,DateTime dt,int UserID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
            string Query = @"Insert into TransferLog(Aomunt,TransferDateTime,SourceClient,DestinationClient,UserID)
                                   Values(@Aomunt,@TransferDateTime,@SourceClient,@DestinationClient,@UserID)";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Aomunt", amount );
            Command.Parameters.AddWithValue("@TransferDateTime", dt);
            Command.Parameters.AddWithValue("@SourceClient", SouClientID );
            Command.Parameters.AddWithValue("@DestinationClient", DesClientID );
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);
        }



        public static DataTable GetAllTransferLog()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
            string Query = @"select SourceAcc=AccountNumber,
                            DesAcc=(select AccountNumber from Clients where Clients.ClientID=TransferLog.DestinationClient),
                            Aomunt ,SourceBalance=Clients.Balance,
                            DesBalance=(Select Balance from Clients where Clients.ClientID=TransferLog.DestinationClient),
                           UserName
                           from TransferLog  inner join Clients on TransferLog.SourceClient=Clients.ClientID
                           inner join Users on
                           TransferLog.UserID=Users.UserID";


                       

                     

       


            SqlCommand Command = new SqlCommand(Query, Connection);
    


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
               
                if(Reader.HasRows )
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }
            return dt;



        }

    }
}
