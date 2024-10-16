using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityGuard.Web.Model;

namespace CityGuard.Web.Service
{
    public class MockDataService : IDataService
    {
        List<DangerReport> _dangerReports;

        public MockDataService()
        {
            _dangerReports = loadFakeReports();
        }

        private List<DangerReport>? loadFakeReports()
        {
            return new List<DangerReport>()
            {
                    new DangerReport
                    {
                        Id = Guid.NewGuid(),
                        Latitude = -17.423316m, // Example latitude (Bolivia)
                        Longitude =  -66.134594m, // Example longitude (Bolivia)
                        DangerType = DangerType.Robbery,
                        DangerDescription = "A robbery was reported at this location.",
                        LikeCount = 5,
                        Comments = new List<ReportComment>
                        {
                            new ReportComment { DangerEvaluation = 3, TextComment = "This place is getting more dangerous." },
                            new ReportComment { DangerEvaluation = 5, TextComment = "Stay safe everyone!" }
                        }
                    },
                    new DangerReport
                    {
                        Id = Guid.NewGuid(),
                        Latitude = -17.424611m, // Example latitude
                        Longitude = -66.134080m, // Example longitude
                        DangerType = DangerType.Kidnapping,
                        DangerDescription = "An attempted kidnapping was reported in this area.",
                        LikeCount = 10,
                        Comments = new List<ReportComment>
                        {
                            new ReportComment { DangerEvaluation = 4, TextComment = "This is terrifying, avoid this area!" },
                            new ReportComment { DangerEvaluation = 2, TextComment = "Hope the police takes action soon." }
                        }
                    },
                    new DangerReport
                    {
                        Id = Guid.NewGuid(),
                        Latitude = -17.424458m, // Example latitude
                        Longitude = -66.134475m, // Example longitude
                        DangerType = DangerType.DrugSelling,
                        DangerDescription = "A drug selling activity was noticed nearby.",
                        LikeCount = 8,
                        Comments = new List<ReportComment>
                        {
                            new ReportComment { DangerEvaluation = 3, TextComment = "Reported this to the local authorities." },
                            new ReportComment { DangerEvaluation = 4, TextComment = "Be cautious in this area." }
                        }
                    }
             };


        }

        public IList<DangerReport> GetDangerReports()
        {
           return _dangerReports;
        }
    }
}