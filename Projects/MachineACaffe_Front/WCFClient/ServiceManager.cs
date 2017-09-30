using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    public class ServiceManager
    {
        static readonly object instanceLock = new object();
        private static ServiceManager _instance;

        public ServiceManager() { }

        public static ServiceManager GetInstance()
        {
            lock (instanceLock)
            {
                if (_instance == null)
                    _instance = new ServiceManager();
                return _instance;
            }
        }

        public string PersistOrder(string value)
        {
            PersitanceService.PersitanceServiceClient ps = new PersitanceService.PersitanceServiceClient();
            ps.Open();
            var result = ps.PersistOrder(value);
            ps.Close();
            return result;
        }

        public string getBadgeLastSelection(string badge)
        {
            PersitanceService.PersitanceServiceClient ps = new PersitanceService.PersitanceServiceClient();
            ps.Open();
            var result = ps.getBadgeLastSelection(badge);
            ps.Close();
            return result;
        }
    }
}
