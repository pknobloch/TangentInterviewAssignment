using EmployeeBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EmployeeWeb2.Controllers
{
    public class BaseController : Controller
    {
        protected TangentEmployeeService GetTangentEmployeeService()
        {
            return (TangentEmployeeService)Session[Constants.Session.TangentEmployeeService];
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (GetTangentEmployeeService() == null)
            {
                FormsAuthentication.SignOut();
                filterContext.Result = RedirectToAction("Login", "Account");
            }
            else
                base.OnActionExecuting(filterContext);
        }
    }
}