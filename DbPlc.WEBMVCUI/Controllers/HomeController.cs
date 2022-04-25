using DbPlc.WEBMVCUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbPlc.EntityFramework;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Web.Script.Serialization;
using System.Web.Security;
using System.Web.Services.Protocols;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using DbPlc.EntityFramework.Entity;
using DbPlc.EntityFramework.Entity.Dto;
using DbPlc.EntityFramework.Repository;
using DbPlc.WEBMVCUI.DbReference;
using Newtonsoft.Json.Linq;
using Login = DbPlc.EntityFramework.Entity.Login;

namespace DbPlc.WEBMVCUI.Controllers
{

    public class HomeController : Controller
    {
        readonly DbPlcWebClient _dbPlcWeb = new DbPlcWebClient();
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            try
            {
                //var dbPlcWeb = new DbPlcWebClient();
                var responseLogin = _dbPlcWeb.Login(login);
                if (responseLogin != true)
                    return Json(new { success = false, message = "Password or lock password is wrong" },
                        JsonRequestBehavior.AllowGet);
                FormsAuthentication.SetAuthCookie(login.Name, false);
                //Session["UserName"] = loginModel.Name;
                Session.Add("UserName", login.Name);
                return Json(new { success = true, message = "Login is succesfully." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            return Json(new { success = true, message = "SingOut Succesfully." }, JsonRequestBehavior.AllowGet);
        }


        [Authorize]
        public ActionResult Area()
        {
            try
            {
                var jsonArea = _dbPlcWeb.GetAllArea();
                var ser = new JavaScriptSerializer();
                var jsonList = ser.Deserialize<List<Area>>(jsonArea);
                return View(jsonList);
            }
            catch (FaultException<ResponseError> fex)
            {
                return HttpNotFound(fex.Message);
                // return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                // return Json(new { success = false, message = e.Message }, JsonRequestBehavior.AllowGet);
                return HttpNotFound(e.Message);
            }
        }
        [HttpPost]
        public ActionResult AddArea(Area area)
        {
            try
            {
                var responseSaveArea = _dbPlcWeb.AddArea(area);
                return Json(responseSaveArea == false ? new { success = false, message = "Enter a different Value" } : new { success = true, message = "Your request has been successfully added." }, JsonRequestBehavior.AllowGet);
            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult DeleteArea(Area area)
        {
            try
            {
                var responseDeleteArea = _dbPlcWeb.DeleteArea(area);
                return Json(responseDeleteArea == false ? new { success = false, message = "Error" } : new { success = true, message = "Your request has been successfully deleted." }, JsonRequestBehavior.AllowGet);
            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult UpdateArea(Area area)
        {
            try
            {
                var responseUpdateArea = _dbPlcWeb.UpdateArea(area);
                return Json(responseUpdateArea == false ? new { success = false, message = "Enter a different Value" } : new { success = true, message = "Your request has been successfully deleted." }, JsonRequestBehavior.AllowGet);
            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }


        [Authorize]
        public ActionResult WorkCenter(ListViewModel listViewModel)
        {
            try
            {
                var jsonArea = _dbPlcWeb.GetAllArea();
                var serArea = new JavaScriptSerializer();
                var jsonListArea = serArea.Deserialize<List<Area>>(jsonArea);
                listViewModel.ListArea = jsonListArea;

                var jsonWorkCenterDto = _dbPlcWeb.GetAllWorkCenterDto();
                var serWorkCenterDto = new JavaScriptSerializer();
                var jsonListWorkCenterDto = serWorkCenterDto.Deserialize<List<WorkCenterDto>>(jsonWorkCenterDto);
                listViewModel.LIstWorkCenterDto = jsonListWorkCenterDto;

                return View(listViewModel);
            }
            catch (FaultException<ResponseError> fex)
            {
                return HttpNotFound(fex.Message);
                // return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                // return Json(new { success = false, message = e.Message }, JsonRequestBehavior.AllowGet);
                return HttpNotFound(e.Message);
            }
        }
        [HttpPost]
        public ActionResult AddWorkCenter(WorkCenter workCenter)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                //    return View("WorkCenter");
                //}
                var responseSaveWorkCenter = _dbPlcWeb.AddWorkCenter(workCenter);
                return Json(responseSaveWorkCenter == false ? new { success = false, message = "Enter a different Value" } : new { success = true, message = "Your request has been successfully added." }, JsonRequestBehavior.AllowGet);
            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult DeleteWorkCenter(WorkCenter workCenter)
        {
            try
            {
                var responseDeleteWorkCenter = _dbPlcWeb.DeleteWorkCenter(workCenter);
                return Json(responseDeleteWorkCenter == false ? new { success = false, message = "Error" } : new { success = true, message = "Your request has been successfully deleted." }, JsonRequestBehavior.AllowGet);

            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult UpdateWorkCenter(WorkCenter workCenter)
        {
            try
            {
                var responseUpdateWorkCenter = _dbPlcWeb.UpdateWorkCenter(workCenter);
                return Json(responseUpdateWorkCenter == false ? new { success = false, message = "Enter a different Value" } : new { success = true, message = "Your request has been successfully deleted." }, JsonRequestBehavior.AllowGet);
            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }


        [Authorize]
        public ActionResult Plc(ListWorkModel listWorkModel)
        {
            try
            {
                var jsonWorkCenter = _dbPlcWeb.GetAllWorkCenter();
                var serWorkCenter = new JavaScriptSerializer();
                var jsonListWork = serWorkCenter.Deserialize<List<WorkCenter>>(jsonWorkCenter);
                listWorkModel.ListWorkCenter = jsonListWork;

                var jsonPlcDto = _dbPlcWeb.GetAllPlcDto();
                var serPlcDto = new JavaScriptSerializer();
                var jsonListPlcDto = serPlcDto.Deserialize<List<PlcDto>>(jsonPlcDto);
                listWorkModel.ListPlcDto = jsonListPlcDto;

                return View(listWorkModel);
            }
            catch (FaultException<ResponseError> fex)
            {
                return HttpNotFound(fex.Message);
                // return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                // return Json(new { success = false, message = e.Message }, JsonRequestBehavior.AllowGet);
                return HttpNotFound(e.Message);
            }
        }
        [HttpPost]
        public ActionResult AddPlc(Plc plc)
        {
            try
            {
                var responseSavePlc = _dbPlcWeb.AddPlc(plc);
                return Json(responseSavePlc == false ? new { success = false, message = "Enter a different Value" } : new { success = true, message = "Your request has been successfully added." }, JsonRequestBehavior.AllowGet);

            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult DeletePlc(Plc plc)
        {
            try
            {
                var responseDeletePlc = _dbPlcWeb.DeletePlc(plc);
                return Json(responseDeletePlc == false ? new { success = false, message = "Error" } : new { success = true, message = "Your request has been successfully deleted." }, JsonRequestBehavior.AllowGet);
            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult UpdatePlc(Plc plc)
        {
            try
            {
                var responseUpdatePlc = _dbPlcWeb.UpdatePlc(plc);
                return Json(responseUpdatePlc == false ? new { success = false, message = "Enter a different Value" } : new { success = true, message = "Your request has been successfully deleted." }, JsonRequestBehavior.AllowGet);

            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }


        [Authorize]
        public ActionResult PlcTag(ListPlcModel listPlcModel)
        {
            try
            {
                var jsonPlc = _dbPlcWeb.GetAllPlc();
                var serPlc = new JavaScriptSerializer();
                var jsonListPlc = serPlc.Deserialize<List<Plc>>(jsonPlc);
                listPlcModel.ListPlc = jsonListPlc;

                var jsonPlcTagDto = _dbPlcWeb.GetAllPlcTagDto();
                var serPlcTagDto = new JavaScriptSerializer();
                var jsonListPlcTagDto = serPlcTagDto.Deserialize<List<PlcTagDto>>(jsonPlcTagDto);
                listPlcModel.ListPlcTagDto = jsonListPlcTagDto;

                return View(listPlcModel);
            }
            catch (FaultException<ResponseError> fex)
            {
                return HttpNotFound(fex.Message);
            }
            catch (Exception e)
            {
                return HttpNotFound(e.Message);
            }
        }
        [HttpPost]
        public ActionResult AddPlcTag(PlcTag plcTag)
        {
            try
            {
                var responseUpdatePlcTag = _dbPlcWeb.AddPlcTag(plcTag);
                return Json(responseUpdatePlcTag == false ? new { success = false, message = "Enter a different Value" } : new { success = true, message = "Your request has been successfully deleted." }, JsonRequestBehavior.AllowGet);
            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult DeletePlcTag(PlcTag plcTag)
        {
            try
            {
                var responseDeletePlcTag = _dbPlcWeb.DeletePlcTag(plcTag);
                return Json(responseDeletePlcTag == false ? new { success = false, message = "Error" } : new { success = true, message = "Your request has been successfully deleted." }, JsonRequestBehavior.AllowGet);
            }
            catch (FaultException<ResponseError> fex)
            {
                return Json(new { success = false, message = fex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult UpdatePlcTag(PlcTag plcTag)
        {
            try
            {
                var responseUpdatePlcTag = _dbPlcWeb.UpdatePlcTag(plcTag);
                return Json(responseUpdatePlcTag == false ? new { success = false, message = "Enter a different Value" } : new { success = true, message = "Your request has been successfully deleted." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        
    }
}