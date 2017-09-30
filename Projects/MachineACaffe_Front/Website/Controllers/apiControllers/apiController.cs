using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WCFClient;

namespace Website.Controllers.apiControllers
{
    [RoutePrefix("api")]
    public class apiController : ApiController
    {

        [HttpGet]
        [Route("GetLatestBadgeOrder")]
        public string GetLatestBadgeOrder(string badge)
        {
            return ServiceManager.GetInstance().getBadgeLastSelection(badge);
        }


    }
}
