using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Models
{
    public class DashboardIndexModel
    {
        public Package Package { get; set; }
        public IEnumerable<SelectListItem> PackageStates { get; set; } // dropdown
    }
}