using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityGuard.Web.Model;

namespace CityGuard.Web.Service
{
    public interface IDataService
    {
        IList<DangerReport> GetDangerReports();

    }
}