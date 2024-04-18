using Hospitals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;


namespace Hospitals.Controllers
{
    public class AdminLoginController : Controller
    {
        HospitalsEntities db = new HospitalsEntities(); 
        // GET: AdminLogin
        public ActionResult Index(AdminLogin log)
        {
            var Admin = db.AdminLogins.Where(x => x.AdminName == log.AdminName && x.APassword == log.APassword).Count();
            if (Admin > 0)
            {
                return Redirect("/AdminLogin/Dashboard");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Dashboard()
        {
            return View();
        }
    }
    
}