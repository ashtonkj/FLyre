using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;

namespace FLyre.WebHost
{
    /// <summary>
    /// Class Startup.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configures the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}