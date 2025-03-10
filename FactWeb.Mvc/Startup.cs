﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FactWeb.Mvc.Startup))]
namespace FactWeb.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
