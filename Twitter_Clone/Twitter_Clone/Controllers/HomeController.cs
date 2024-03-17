using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Twitter_Clone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public ActionResult Index()
        {
            _logger.LogInformation("Index loaded");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            _logger.LogDebug("loading contact page");
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public HomeController()
        {
            this._logger = MvcApplication.ServiceProvider.GetService<ILogger<HomeController>>();
            _logger.LogInformation("Creating home controller");
        }
    }
}