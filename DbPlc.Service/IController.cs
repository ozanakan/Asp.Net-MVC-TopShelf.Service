using DbPlc.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using DbPlc.EntityFramework.Entity.Dto;

namespace DbPlc.Service
{
    [ServiceContract(Name = "DbPlcWeb")]
    public interface IController
    {

        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        string GetAllArea();
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        string GetAllWorkCenter();
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        string GetAllPlc();
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        string GelAllPlcTag();
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        string GetAllWorkCenterDto();
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        string GetAllPlcDto();
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        string GetAllPlcTagDto();

        

        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool AddArea(Area area);
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool AddWorkCenter(WorkCenter workCenter);
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool AddPlc(Plc plc);
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool AddPlcTag(PlcTag plcTag);
        
    

        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool DeleteArea(Area area);
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool DeleteWorkCenter(WorkCenter workCenter);
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool DeletePlc(Plc plc);
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool DeletePlcTag(PlcTag plcTag);



        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool UpdateArea(Area area);
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool UpdateWorkCenter(WorkCenter workCenter);
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool UpdatePlc(Plc plc);
        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool UpdatePlcTag(PlcTag plcTag);



        [OperationContract]
        [FaultContract(typeof(ResponseError))]
        bool Login(Login login);

    }
}

