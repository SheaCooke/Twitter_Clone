using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Twitter_Clone.App_Start
{
    public static class DependencyInjectionConfig
    {
        public static ServiceProvider serviceProvider { get; private set; }
    }
}