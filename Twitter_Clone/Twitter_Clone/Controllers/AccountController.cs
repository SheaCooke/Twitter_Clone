using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Twitter_Clone.Models.User;
using Microsoft.Owin;


namespace Twitter_Clone.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger _logger;
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ActionResult Index()
        {
            _logger.LogInformation("Account creation page");
            return View();
        }

        public AccountController()
        {
            this._logger = MvcApplication.ServiceProvider.GetService<ILogger<AccountController>>();
        }

        public AccountController(ApplicationUserManager userManager) : this()
        {
            _userManager = userManager;
        }
    }
}