using DbPlc.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbPlc.EntityFramework.Entity.Dto;

namespace DbPlc.EntityFramework.Repository
{
    public class PlcTagRepository
    {
        private readonly Connection _con = new Connection();
        private static PlcTagRepository _plcTagRepository;
        private static readonly object LockObject = new object();

        public PlcTagRepository()
        {
        }
        public static PlcTagRepository CreateAsSingletonPlcTag()
        {
            lock (LockObject)
            {
                if (_plcTagRepository==null)
                {
                    _plcTagRepository = new PlcTagRepository();
                }
            }
            return _plcTagRepository;
        }



        public List<PlcTag> GetAll()
        {
            var tmprlist = new List<PlcTag>();

            try
            {
                var queryString = String.Format("select * from PlcTags");

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();
                var command = new SqlCommand(queryString, _con.connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var plcTag = new PlcTag
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        PlcId = Convert.ToInt32(reader["PlcId"]),
                        Name = reader["Name"].ToString(),
                        Description = reader["Description"].ToString(),
                        DbNumber = Convert.ToInt32(reader["DbNumber"]),
                        Address = Convert.ToInt32(reader["Address"]),
                        DataType = Convert.ToInt32(reader["DataType"])
                    };
                    tmprlist.Add(plcTag);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _con.connection.Close();
                throw;
            }
            finally
            {
                if (_con.connection.State == ConnectionState.Open)
                    _con.connection.Close();
            }
            return tmprlist;
        }
        public bool Add(PlcTag plcTag)
        {
            try
            {
                string queryString =
                    String.Format("INSERT INTO PlcTags(PlcId,Name,Description,DbNumber,Address,DataType)  values ('{0}','{1}','{2}','{3}','{4}','{5}')", plcTag.PlcId, plcTag.Name, plcTag.Description, plcTag.DbNumber, plcTag.Address, plcTag.DataType);

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();


                var command = new SqlCommand(queryString, _con.connection);
                var queryResult = command.ExecuteNonQuery();

                if (queryResult == -1)
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
        public bool Delete(PlcTag plcTag)
        {
            try
            {
                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                var queryString = string.Format("Delete from PlcTags where Id = '{0}'", plcTag.Id);
                var command = new SqlCommand(queryString, _con.connection);
                var queryResult = command.ExecuteNonQuery();
                return queryResult != 0;
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
        public bool Update(PlcTag plcTag)
        {
            try
            {
                var queryString = string.Format("Update PlcTags set  PlcId={0}, Name='{1}',Description='{2}',DbNumber={3},Address={4},DataType={5}  where Id= '{6}'",plcTag.PlcId,plcTag.Name,plcTag.Description,plcTag.DbNumber,plcTag.Address,plcTag.DataType,plcTag.Id);

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
        public List<PlcTagDto> GetPlcTagDto()
        {
            var plcTagDtoList = new List<PlcTagDto>();
            try
            {
                string queryString = "SELECT T.Id as PlcTagId,P.Name as PlcName,p.Id as PlcId,T.Name as Name,T.Description as Description,T.DbNumber as DbNumber,t.Address as Address,t.DataType as DataType FROM Plcs P INNER JOIN PlcTags T ON P.Id = T.PlcId";

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                var command = new SqlCommand(queryString, _con.connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var plcTagDto = new PlcTagDto
                    {
                        Id = Convert.ToInt32(reader["PlcTagId"]),
                        PlcId = Convert.ToInt32(reader["PlcId"]),
                        PlcName = reader["PlcName"].ToString(),
                        Name = reader["Name"].ToString(),
                        Description = reader["Description"].ToString(),
                        DbNumber = Convert.ToInt32(reader["DbNumber"]),
                        Address = Convert.ToInt32(reader["Address"]),
                        DataType = Convert.ToInt32(reader["DataType"])
                    };
                    plcTagDtoList.Add(plcTagDto);
                }
                return plcTagDtoList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
