using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuard.Web.Model
{
    public class DangerReport
    {
        public Guid Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DangerType DangerType { get; set; }
        public string DangerDescription { get; set; }
        public int LikeCount { get; set; }
        public IList<ReportComment> Comments {get; set;}
        
        //TODO: Add more filed regarding to the  a Danger point like photos or videos too



    }

    public enum DangerType
    {
        Robbery,
        OrganizedCrime,
        Assault,
        ViolentKill,
        DrugSelling,
        Kidnapping,
        OrganTrafficking,
        Gangs

    }
}