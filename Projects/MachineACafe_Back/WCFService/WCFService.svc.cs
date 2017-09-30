using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WCFService : IPersitanceService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        public string getBadgeLastSelection(string badge)
        {
            ICoffeOrderService orderService = new CoffeOrderService();
            return orderService.GetByBadge(badge);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="coffeOrder"></param>
        /// <returns></returns>
        public string PersistOrder(string coffeOrder)
        {
            ICoffeOrderService orderService = new CoffeOrderService();
            return orderService.addCoffeOrder(coffeOrder);
        }
    }
}
