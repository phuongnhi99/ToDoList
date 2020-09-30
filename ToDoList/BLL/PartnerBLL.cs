using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.DAL;
using ToDoList.Entity;

namespace ToDoList.BLL
{
    public class PartnerBLL
    {
        private static PartnerDAL obj = new PartnerDAL();
        public static void AddPartner(Partner partner)
        {
            obj.AddPartner(partner);
        }

        public static void delete(Partner partner)
        {
            obj.Delete(partner);
        }
    }
}