using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    [ServiceContract]
    public interface IPersitanceService
    {
        [OperationContract]
        string PersistOrder(string coffeOrder);


        [OperationContract]
        string getBadgeLastSelection(string badge);

    }
}
