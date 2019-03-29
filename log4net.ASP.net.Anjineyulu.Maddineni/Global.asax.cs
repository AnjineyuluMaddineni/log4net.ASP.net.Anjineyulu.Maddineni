using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace log4net.ASP.net.Anjineyulu.Maddineni
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //Step 2 : log4net.Config.XmlConfigurator.Configure(); in Global.asax
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}