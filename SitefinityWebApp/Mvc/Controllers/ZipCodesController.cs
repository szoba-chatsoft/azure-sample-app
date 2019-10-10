using SitefinityWebApp.Mvc.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers
{
     
    // The ControllerToolboxItem attribute registers the widget in Sitefinity backend
    [ControllerToolboxItem(Name = "ZipCodeWidget", Title = "ZipCode Widget", SectionName = "Classifications")]

    public class ZipCodesController : Controller
    {
        public ActionResult Index()
        {
            var zipcodes = new List<ZipCodesModel>();

            zipcodes.Add(new ZipCodesModel() { Zipcode = "06824"});
            zipcodes.Add(new ZipCodesModel() { Zipcode = "02101" });
            zipcodes.Add(new ZipCodesModel() { Zipcode = "03101" });

            return View("Index", model:zipcodes);
        }
    }
}