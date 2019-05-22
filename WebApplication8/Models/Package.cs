using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Package
    {
        public PackageState State { get; set; }

        public Package(PackageState state)
        {
            State = state;
        }
    }
}