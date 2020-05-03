using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VisitLog.BussinesLogicLayer
{
   public static class VisitLogMain
    {

        public static VisiterID ID;

        public static List<Visit> Visits =  new List<Visit>();

        public static void AddVisit(Visit visit)
        {
            Visits.Add(visit);
        }
        public static void RemoveVisit(Visit visit)
        {
            Visits.Remove(visit);
        }
    }
}
