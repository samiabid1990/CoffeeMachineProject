using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFClient;

namespace Website.Controllers.SaveController
{
    public class SaveController : Controller
    {
        [HttpPost]
        public string SaveOrder(string coffeOrder)
        {
            return ServiceManager.GetInstance().PersistOrder(coffeOrder);
        }
    }
}