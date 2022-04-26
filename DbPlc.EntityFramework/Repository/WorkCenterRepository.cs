using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DbPlc.EntityFramework.Entity;
using DbPlc.EntityFramework.Entity.Dto;

namespace DbPlc.EntityFramework.Repository
{
    public class WorkCenterRepository
    {
        private readonly Connection _con = new Connection();
        private static WorkCenterRepository _workCenterRepository;
        private static readonly object LockObject = new object();

        private WorkCenterRepository()
        {
        }
        public static WorkCenterRepository CreateAsSingletonWorkCenter()
        {
            lock (LockObject)
            {
                if (_workCenterRepository == null)
                {
                    _workCenterRepository = new WorkCenterRepository();
                }
            }
            return _workCenterRepository;
        }



        public List<WorkCenter> GetAll()
        {
            var workCenterlist = new List<WorkCenter>();
            try
            {
                var queryString = string.Format("select * from WorkCenters");

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                SqlCommand command = new SqlCommand(queryString, _con.connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var workCenter = new WorkCenter
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        AreaId = Convert.ToInt32(reader["AreaId"]),
                        Name = reader["Name"].ToString(),
                        Description = reader["Description"].ToString()
                    };
                    workCenterlist.Add(workCenter);
                }
                return workCenterlist;
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
        public bool Delete(WorkCenter workCenter)
        {
            try
            {
                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();


                string queryString = string.Format("Delete from WorkCenters where Id = '{0}'", workCenter.Id);
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
        public bool Update(WorkCenter workCenter)
        {
            try
            {
                var queryString = string.Format("Update WorkCenters set AreaId={0},Name='{1}',Description='{2}'  where Id= '{3}'", workCenter.AreaId, workCenter.Name, workCenter.Description, workCenter.Id);

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
        public List<WorkCenterDto> GetAllWorkCenterDto()
        {
            var workCenterDtoList = new List<WorkCenterDto>();
            try
            {
                var queryString = string.Format("Select C.Id as WorkCenterId,E.Id as AreaId,E.Name as AreaName,C.Name as WorkCenterName,C.Description as Description FROM Areas E INNER JOIN WorkCenters C ON E.Id = C.AreaId");

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                var command = new SqlCommand(queryString, _con.connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var workCenterDto = new WorkCenterDto
                    {
                        Id = Convert.ToInt32(reader["WorkCenterId"]),
                        AreaId = Convert.ToInt32(reader["AreaId"]),
                        AreaName = reader["AreaName"].ToString(),
                        Name = reader["WorkCenterName"].ToString(),
                        Description = reader["Description"].ToString()
                    };
                    workCenterDtoList.Add(workCenterDto);
                }
                return workCenterDtoList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public bool Add(WorkCenter workCenter)
        {
            try
            {
                string queryString =
                    string.Format("INSERT INTO WorkCenters(AreaId,Name,Description)  values ('{0}','{1}','{2}')", workCenter.AreaId, workCenter.Name, workCenter.Description);

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                var command = new SqlCommand(queryString, _con.connection);
                var queryResult = command.ExecuteNonQuery();
                return queryResult != -1;
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
        }
    }
}
