using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorBootstrap;
using CityGuard.Web.Model;

namespace CityGuard.Web.Components
{
    public class GReportMarker : GoogleMapMarker
    {
        public DangerReport Report { get; set; }
        

    }
}