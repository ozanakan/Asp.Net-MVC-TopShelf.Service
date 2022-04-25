using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DbPlc.EntityFramework.Entity;
using DbPlc.EntityFramework.Repository.Abstract;

namespace DbPlc.EntityFramework.Repository
{
    public class AreaRepository:IAreaDal
    {
        private readonly Connection _con = new Connection();
   
        public List<Area> GetAll()
        {
            var arealist = new List<Area>();
            try
            {
                var queryString = String.Format("select * from Areas");

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                var command = new SqlCommand(queryString, _con.connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    arealist.Add(new Area
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString()
                    });
                }
                return arealist;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (_con.connection.State == ConnectionState.Open)
                    _con.connection.Close();
            }
        }
        public bool Add(Area area)
        {
            try
            {
                var queryString = string.Format("INSERT INTO Areas(Name) VALUES('{0}')", area.Name);

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                var command = new SqlCommand(queryString, _con.connection);
                var queryResult = command.ExecuteNonQuery();
                return queryResult != -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (_con.connection.State == ConnectionState.Open)
                    _con.connection.Close();
            }
        }
        public bool Delete(Area area)
        {
            try
            {
                string queryString = String.Format("Delete from Areas where Id = '{0}'", area.Id);

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                var command = new SqlCommand(queryString, _con.connection);
                var queryResult = command.ExecuteNonQuery();
                if (queryResult == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (_con.connection.State == ConnectionState.Open)
                    _con.connection.Close();
            }
        }
        public bool Update(Area area)
        {
            try
            {
                var queryString = string.Format("Update Areas set Name= '{0}' where Id= '{1}'", area.Name, area.Id);

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                var command = new SqlCommand(queryString, _con.connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (_con.connection.State == ConnectionState.Open)
                    _con.connection.Close();
            }
        }


    }
}


