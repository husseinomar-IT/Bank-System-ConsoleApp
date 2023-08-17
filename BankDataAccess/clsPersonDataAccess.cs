using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankDataAccess
{
  public  class clsPersonDataAccess
    {
        public static bool Find(int PersonID,ref string FirstName,ref string LastName,ref string Email,ref string Phone)
        {
            bool IsFound = false;
            SqlConnection Conncetion = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
            string Query = "Select * from Persons where PersonID=@PersonID";
            SqlCommand Command = new SqlCommand(Query, Conncetion);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Conncetion.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if(Reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (string)Reader["Phone"];

                }
                Reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Conncetion.Close();
            }
            return IsFound;

        }

        public static bool UpdatePerson(int PersonID,string FirstName,string LastName,string Email,string Phone)

        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);
            string Query = @"Update [Persons] set 
                         [FirstName]=@FirstName,
                         [LastName]=@LastName,
                         [Email]=@Email,
                        [Phone]=@Phone
                      where PersonID=@PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName );
            Command.Parameters.AddWithValue("@Email", Email );
            Command.Parameters.AddWithValue("@Phone", Phone );
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();


            }
            catch (Exception  ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return (RowsAffected > 0);
        }



      public static int AddNewPerson(string FirstName,string LastName,string Email,string Phone)
        {
            int PersonID = -1;
          int IndexID=-1;
            SqlConnection Connection = new SqlConnection(clsBankDataAccsessSettings.ConnectionString);

            string Query = @"Insert INTO Persons(FirstName,LastName,Email,Phone)
                         Values(@FirstName,@LastName,@Email,@Phone);
                            Select SCOPE_Identity(); ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName );
            Command.Parameters.AddWithValue("@Email", Email );
            Command.Parameters.AddWithValue("@Phone", Phone );
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if(Result !=null &&int.TryParse(Result.ToString(),out IndexID ))
                {
                    PersonID = IndexID;
                }
            }
          catch (Exception ex)
            {

            }
          finally
            {
                Connection.Close();
            }
            return PersonID;


        }


    }





}
