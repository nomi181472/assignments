using k173652_Q4.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace k173652_Q4.Controllers
{
    public class ScriptsController : Controller
    {
       
        // GET: Scripts

        public ActionResult Index(string data )
        {

            CommonService cs = new CommonService();
            
             var   script = ConfigurationManager.AppSettings["directorypath"]; // new Scripts() { price=23.2,script="script"};
            
            ViewBag.day =cs.GetDropDownDay(script);
       
            return View();


        }
        
    }
}