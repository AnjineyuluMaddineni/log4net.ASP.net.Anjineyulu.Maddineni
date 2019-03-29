using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace log4net.ASP.net.Anjineyulu.Maddineni
{
    public partial class Log4net : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ILog log = log4net.LogManager.GetLogger(typeof(Log4net));
            log.Info("Button1_Click fired");
            try
            {
                object o2 = null;
                int i2 = (int)o2;   // Error
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            log.Info("Button1_Click completed");
            Label1.Text = "logs generated at C:\\Logs\\log4net.ASP.net.Anjineyulu.Maddineni";
        }
    }
}