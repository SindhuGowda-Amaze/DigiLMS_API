using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Http;
using System.Net.Mail;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using System.Web;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Web.Http;
using ExcelDataReader;
using FastMember;
using System.Data.SqlClient;
using FreshersApp.Business.Interface;
using FreshersApp.Business.Entities;


namespace FreshersApp.API.Controllers
{
    public class MasterController : ApiController
    {
        private IMasterManager IMasterManager;
        public MasterController(IMasterManager IMasterManager)
        {
            this.IMasterManager = IMasterManager;
        }

        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpGet]
        [Route("Master/GetDepartment")]
        public HttpResponseMessage GetDepartment()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetDepartment();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetDepartment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertDepartment")]
        public HttpResponseMessage InsertDepartment(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertDepartment(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertDepartment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/UpdateDepartment")]
        public HttpResponseMessage UpdateDepartment(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateDepartment(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateDepartment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteDepartment")]
        public HttpResponseMessage DeleteDepartment(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteDepartment(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteDepartment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetOTRates")]
        public HttpResponseMessage GetOTRates()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetOTRates();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetOTRates + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertOTRates")]
        public HttpResponseMessage InsertOTRates(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertOTRates(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertOTRates + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/UpdateOTRates")]
        public HttpResponseMessage UpdateOTRates(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateOTRates(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateOTRates + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteOTRates")]
        public HttpResponseMessage DeleteOTRates(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteOTRates(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteOTRates + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
















        [HttpGet]
        [Route("Master/GetCostcenter")]
        public HttpResponseMessage GetCostcenter()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetCostcenter();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetCostcenter + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/InsertCostcenter")]
        public HttpResponseMessage InsertCostcenter(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertCostcenter(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertCostcenter + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/UpdateCostcenter")]
        public HttpResponseMessage UpdateCostcenter(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateCostcenter(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateCostcenter + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteCostcenter")]
        public HttpResponseMessage DeleteCostcenter(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteCostcenter(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteCostcenter + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }













        [HttpGet]
        [Route("Master/GetFoodSenseProjects")]
        public HttpResponseMessage GetFoodSenseProjects()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetFoodSenseProjects();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetFoodSenseProjects + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

       


        [HttpGet]
        [Route("Master/DeleteFoodSenseProject")]
        public HttpResponseMessage DeleteFoodSenseProject(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteFoodSenseProject(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetFoodSenseProjects + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertFoodSenseProjects")]
        public HttpResponseMessage InsertFoodSenseProjects(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertFoodSenseProjects(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertFoodSenseProjects + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

      
        [HttpGet]
        [Route("Master/GetCompanyProfile")]
        public HttpResponseMessage GetCompanyProfile()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetCompanyProfile();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetCompanyProfile + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertCompany_Profile")]
        public HttpResponseMessage InsertCompany_Profile(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertCompany_Profile(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertCompany_Profile + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteCompanyProfile")]
        public HttpResponseMessage DeleteCompanyProfile(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteCompanyProfile(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteCompanyProfile + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
























        //Important!!!
        [HttpPost]
        [Route("Master/UploadImages/")]
        public HttpResponseMessage UploadImages()
        {
            HttpResponseMessage response;
            try
            {
                string result = string.Empty;
                var httpRequest = HttpContext.Current.Request;
                if (httpRequest.Files.Count > 0)
                {
                    foreach (string file in httpRequest.Files)
                    {
                        var postedFile = httpRequest.Files[file];
                        var Name = postedFile.FileName.Split('\\').LastOrDefault().Split('/').LastOrDefault().Replace(" ", null);
                        var fn = Name.Split('.').FirstOrDefault();
                        var ext = Name.Split('.').LastOrDefault();
                        var time = DateTime.Now.ToString("yyyyMMddHHmmss");
                        //var fileName = time + Name;
                        var fileName = fn + '-' + time + '.' + ext;
                        Directory.CreateDirectory(HostingEnvironment.MapPath("~/Images/"));
                        string filePath = HostingEnvironment.MapPath("~/Images/" + fileName);
                        postedFile.SaveAs(filePath);
                        result = filePath;
                    }
                }
               response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Master/UploadTestimonialImages/Error:" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Uploadimage Error " + ex.Message);
            }
            return response;
        }
    }
}