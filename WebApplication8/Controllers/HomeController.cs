using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/

        public ActionResult Index()
        {
            PackageRepository.Package = new Package(PackageState.Complete);
            IList<PackageState> states = new List<PackageState>
                                             {PackageState.Received, PackageState.Processing, PackageState.Complete};

            int selectedStateId = 2; // hard code for demo

            IEnumerable<SelectListItem> selectList =
                from s in states
                select new SelectListItem
                {
                    Selected = (s.Id == selectedStateId),
                    Text = s.Name,
                    Value = s.Id.ToString()
                };

            // Do this if you don't care about selection
            //            List<SelectListItem> selectList = states.Select(state => new SelectListItem {Value = state.Id.ToString(), Text = state.Name}).ToList();

            var model = new DashboardIndexModel { Package = PackageRepository.Package, PackageStates = selectList };
            return View(model);
        }
    }
}