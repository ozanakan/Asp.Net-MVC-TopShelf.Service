using DbPlc.EntityFramework.Entity;
using DbPlc.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Script.Serialization;
using System.Web.Services.Protocols;
using DbPlc.EntityFramework.Entity.Dto;
using Exception = System.Exception;

namespace DbPlc.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                         ConcurrencyMode = ConcurrencyMode.Multiple)]
    class PlcService : IController
    {

        private readonly AreaRepository _areaRepository = new AreaRepository();
        private readonly WorkCenterRepository _workCenterRepository = new WorkCenterRepository();
        private readonly PlcRepository _plcRepository = new PlcRepository();
        private readonly PlcTagRepository _plcTagRepository = new PlcTagRepository();
        private readonly LogEvent _logger = new LogEvent();
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly InputControl _inputControl = new InputControl();



        public string GetAllArea()
        {
            try
            {
                var listArea = _areaRepository.GetAll();
                var jsonArea = new JavaScriptSerializer().Serialize(listArea);
                return jsonArea;
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public string GetAllWorkCenter()
        {
            try
            {
                var listWorkCenter = _workCenterRepository.GetAll();
                var jsonWorkCenter = new JavaScriptSerializer().Serialize(listWorkCenter);
                return jsonWorkCenter;
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public string GetAllPlc()
        {
            try
            {
                var listPlc = _plcRepository.GetAll();
                var jsonPlc = new JavaScriptSerializer().Serialize(listPlc);
                return jsonPlc;
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public string GelAllPlcTag()
        {
            try
            {
                var listPlcTag = _plcTagRepository.GetAll();
                var jsonPlcTag = new JavaScriptSerializer().Serialize(listPlcTag);
                return jsonPlcTag;
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }

        
        public string GetAllWorkCenterDto()
        {
            try
            {
                var listWorkCenterDto = _workCenterRepository.GetAllWorkCenterDto();
                var jsonWorkCenterDto = new JavaScriptSerializer().Serialize(listWorkCenterDto);
                return jsonWorkCenterDto;
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public string GetAllPlcDto()
        {
            try
            {
                var listPlcDto = _plcRepository.GetAllPlcDto();
                var jsonPlcDto = new JavaScriptSerializer().Serialize(listPlcDto);
                return jsonPlcDto;
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public string GetAllPlcTagDto()
        {
            try
            {
                var listPlcTagDto = _plcTagRepository.GetPlcTagDto();
                var jsonPlcTagDto = new JavaScriptSerializer().Serialize(listPlcTagDto);
                return jsonPlcTagDto;
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }

        
        public bool AddArea(Area area)
        {
            try
            {
                var result = _inputControl.ControlLogin(area.Name);
                return result != false && _areaRepository.Add(area);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public bool AddWorkCenter(WorkCenter workCenter)
        {
            try
            {
                var result = _inputControl.ControlLogin(workCenter.Name + workCenter.Description+workCenter.AreaId);
                return result != false && _workCenterRepository.Add(workCenter);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public bool AddPlc(Plc plc)
        {
            try
            {
                var result = _inputControl.ControlLogin(plc.Name + plc.ConnType + plc.Ip + plc.Slot+plc.WorkCenterId);
                return result != false && _plcRepository.Add(plc);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public bool AddPlcTag(PlcTag plcTag)
        {
            try
            {
                var result = _inputControl.ControlLogin(plcTag.Description+plcTag.Name+plcTag.Address+plcTag.DataType+plcTag.DbNumber+plcTag.PlcId);
                return result != false && _plcTagRepository.Add(plcTag);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }

        }
        

        public bool DeleteArea(Area area)
        {
            try
            {
                return _areaRepository.Delete(area);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public bool DeleteWorkCenter(WorkCenter workCenter)
        {
            try
            {
                return _workCenterRepository.Delete(workCenter);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public bool DeletePlc(Plc plc)
        {
            try
            {
                return _plcRepository.Delete(plc);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public bool DeletePlcTag(PlcTag plcTag)
        {
            try
            {
                return _plcTagRepository.Delete(plcTag);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }


        public bool UpdateArea(Area area)
        {
            try
            {
                var result = _inputControl.ControlLogin(area.Name);
                return result != false && _areaRepository.Update(area);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public bool UpdateWorkCenter(WorkCenter workCenter)
        {
            try
            {
                var result = _inputControl.ControlLogin(workCenter.Name + workCenter.Description+workCenter.AreaId);
                return result != false && _workCenterRepository.Update(workCenter);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public bool UpdatePlc(Plc plc)
        {
            try
            {
                var result = _inputControl.ControlLogin(plc.Name + plc.ConnType + plc.Ip + plc.Slot+plc.WorkCenterId);
                return result != false && _plcRepository.Update(plc);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }
        public bool UpdatePlcTag(PlcTag plcTag)
        {
            try
            {
                var result = _inputControl.ControlLogin(plcTag.Description + plcTag.Name + plcTag.Address + plcTag.DataType + plcTag.DbNumber + plcTag.PlcId);
                return result != false && _plcTagRepository.Update(plcTag);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }


        public bool Login(Login login)
        {
            try
            {
                var result = _inputControl.ControlLogin(login.Name + login.Password);
                return result != false && _userRepository.Login(login);
            }
            catch (Exception e)
            {
                _logger.Log(e);
                var fault = new ResponseError("Exception");
                throw new FaultException<ResponseError>(fault, new FaultReason(e.Message));
            }
        }


    }
}
