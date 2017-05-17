using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace homework.Controllers
{
    public class OvertodayController : Controller
    {
        // GET: overtoday
        public ActionResult Index(DateTime? Dateee)
        {
            var isValidate = true;
            if (Dateee.HasValue)
            {
                isValidate = DateTime.Now.Date > Dateee;
            }
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}