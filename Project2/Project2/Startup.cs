﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project2.Startup))]
namespace Project2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
