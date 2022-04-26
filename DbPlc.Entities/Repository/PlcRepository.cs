using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbPlc.EntityFramework.Entity;
using DbPlc.EntityFramework.Entity.Dto;
using DbPlc.EntityFramework.Repository.Abstract;

namespace DbPlc.EntityFramework.Repository
{

    public class PlcRepository:IPlcDal
    {
        private readonly Connection _con = new Connection();
        
        
        public List<Plc> GetAll()
        {
            var plclist = new List<Plc>();

            try
            {
                var queryString = String.Format("select * from Plcs");
                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                var command = new SqlCommand(queryString, _con.connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Plc plc = new Plc
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        WorkCenterId = Convert.ToInt32(reader["WorkCenterId"]),
                        Name = reader["Name"].ToString(),
                        Ip = Convert.ToInt32(reader["Ip"]),
                        Slot = Convert.ToInt32(reader["Slot"]),
                        ConnType = Convert.ToInt32(reader["ConnType"])
                    };
                    plclist.Add(plc);
                }
                return plclist;
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
        public bool Add(Plc plc)
        {
            try
            {
                var queryString = String.Format("INSERT INTO Plcs(WorkCenterId,Name,Ip,Slot,ConnType) values ('{0}','{1}','{2}','{3}','{4}')",plc.WorkCenterId,plc.Name,plc.Ip,plc.Slot,plc.ConnType );

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
        public bool Delete(Plc plc)
        {
            try
            {
                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();


                var queryString = String.Format("Delete from Plcs where Id = '{0}'", plc.Id);
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
        public bool Update(Plc plc)
        {
            try
            {
                var queryString = string.Format("Update Plcs set  WorkCenterId={0}, Name='{1}',Ip={2},Slot={3},ConnType={4}  where Id= '{5}'", plc.WorkCenterId,plc.Name,plc.Ip,plc.Slot,plc.ConnType,plc.Id);

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
        public List<PlcDto> GetAllPlcDto()
        {
            var plcDtoList = new List<PlcDto>();
            try
            {
                string queryString = "SELECT P.Id as PlcId,W.Id as WorkCenterId,W.Name as WorkCenterName,P.Name as PlcName,P.Ip as IpNumber,P.Slot as SlotNumber,P.ConnType as ConnectionType FROM WorkCenters W INNER JOIN Plcs P ON w.Id = p.WorkCenterId ";

                if (_con.connection.State == ConnectionState.Closed)
                    _con.connection.Open();

                var command = new SqlCommand(queryString, _con.connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var plcDto = new PlcDto
                    {
                        Id = Convert.ToInt32(reader["PlcId"]),
                        WorkCenterId = Convert.ToInt32(reader["WorkCenterId"]),
                        WorkCenterName = reader["WorkCenterName"].ToString(),
                        Name = reader["PlcName"].ToString(),
                        Ip = Convert.ToInt32(reader["IpNumber"]),
                        Slot = Convert.ToInt32(reader["SlotNumber"]),
                        ConnType = Convert.ToInt32(reader["ConnectionType"]),
                    };
                    plcDtoList.Add(plcDto);
                }
                return plcDtoList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        

    }
}
