using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(Twitter_Clone.Startup))]

namespace Twitter_Clone
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            //TODO: what is this path based on?
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });

            app.CreatePerOwinContext(() => new ApplicationUserManager(new UserStore<ApplicationUser>(new ApplicationDbContext())));
        }
    }
}
