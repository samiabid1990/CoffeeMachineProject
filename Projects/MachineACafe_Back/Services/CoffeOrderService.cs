using Data.Infrastructure;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Service
{
    public class CoffeOrderService : ICoffeOrderService
    {
        DatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;

        public CoffeOrderService()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        public string GetByBadge(string badge)
        {
            return JsonConvert.SerializeObject(utOfWork.CoffeOrderRepositroy.GetById(badge));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="coffeOrder"></param>
        public string addCoffeOrder(string coffeOrderJson)
        {
            CoffeOrder coffeOrder = JsonConvert.DeserializeObject<CoffeOrder>(coffeOrderJson);
            if (coffeOrder.badge != null)
            {
                utOfWork.CoffeOrderRepositroy.Update(coffeOrder);
                utOfWork.Commit();
                return "update";
            }
            else
            {
                coffeOrder.badge = Guid.NewGuid().ToString();
                utOfWork.CoffeOrderRepositroy.Add(coffeOrder);
                utOfWork.Commit();
                return coffeOrder.badge;
            }
        }

    }

    public interface ICoffeOrderService
    {
        string GetByBadge(string badge);
        string addCoffeOrder(string coffeOrderJson);
    }
}
