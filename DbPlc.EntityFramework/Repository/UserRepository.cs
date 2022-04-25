using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbPlc.EntityFramework.Entity;

namespace DbPlc.EntityFramework.Repository
{
    public class UserRepository
    {
        private readonly Connection con = new Connection();
        public bool Login(Login login) 
        {
            try
            {
                var queryString = string.Format("SELECT Id FROM [User] WHERE Name ='{0}' AND Password='{1}' ",login.Name,login.Password);
                if (con.connection.State == ConnectionState.Closed)
                    con.connection.Open();

                var command = new SqlCommand(queryString, con.connection);
                var reader = command.ExecuteReader();
                return reader.Read();

                //var queryString = String.Format("SELECT Id FROM [User] WHERE Name =@name AND Password=@pass ");
                //if (con.connection.State == ConnectionState.Closed)
                //    con.connection.Open();

                //var command = new SqlCommand(queryString, con.connection);
                //command.Parameters.AddWithValue("@name", name);
                //command.Parameters.AddWithValue("@pass", pass);
                //var reader = command.ExecuteReader();
                //return reader.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (con.connection.State == ConnectionState.Open)
                    con.connection.Close();
            }
        }
    }
}
