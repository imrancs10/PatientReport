﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientReport.Global;
using PatientReport.BAL.Masters;
using PatientReport.Infrastructure.Authentication;

namespace PatientReport.Controllers
{
    public class CommonController : Controller
    {

        protected virtual new CustomPrincipal User
        {
            get { return HttpContext.User as CustomPrincipal; }
        }

        public string LoginResponse(Enums.LoginMessage inputMessage)
        {
            if (inputMessage == Enums.LoginMessage.InvalidCreadential)
                return Resource.Login_InvalidCredential;
            else
                return Global.Resource.Common_NoResponseFromServer;
        }

        public string CrudResponse(Enums.CrudStatus inputMessage)
        {
            if (inputMessage == Enums.CrudStatus.DataAlreadyExist)
                return Resource.Crud_DataAlreadyExist;
            else if (inputMessage == Enums.CrudStatus.Saved)
                return Global.Resource.Crud_DataSaved;
            else if (inputMessage == Enums.CrudStatus.NotSaved)
                return Global.Resource.Crud_DataNotSaved;
            else if (inputMessage == Enums.CrudStatus.Deleted)
                return Global.Resource.Crud_DataDelete;
            else if (inputMessage == Enums.CrudStatus.NotDeleted)
                return Global.Resource.Crud_NotDelete;
            else if (inputMessage == Enums.CrudStatus.Updated)
                return Global.Resource.Crud_DataUpdated;
            else if (inputMessage == Enums.CrudStatus.NotUpdated)
                return Global.Resource.Crud_DataNotUpdated;
            else if (inputMessage == Enums.CrudStatus.NotSaved)
                return Global.Resource.Crud_DataNotSaved;
            else if (inputMessage == Enums.CrudStatus.SessionExpired)
                return Global.Resource.Session_Expired;
            else if (inputMessage == Enums.CrudStatus.InvalidPostedData)
                return Global.Resource.Invalid_Posted_Data;
            else if (inputMessage == Enums.CrudStatus.InvalidPastDate)
                return Global.Resource.Invalid_Past_Date;
            else
                return Resource.Common_NoResponseFromServer;
        }

        public void SetAlertMessage(string message,string title="Alert")
        {
            TempData["Alert_Message"] = message;
            TempData["Alert_Title"] = title;
        }
    }
}