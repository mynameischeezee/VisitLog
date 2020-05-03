using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitLog.BussinesLogicLayer
{
    public class Visit
    {
        public string PIB;
        public string ID;
        public string RoomNumber;
        public DateTime Date;
        public float Duration;

        public Visit(string pib, string id, string room, DateTime date, float duration)
        {
            this.PIB = pib;
            this.ID = id;
            this.RoomNumber = room;
            this.Date = date;
            this.Duration = duration;
        }
    }
}
