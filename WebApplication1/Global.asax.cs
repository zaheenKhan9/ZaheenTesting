using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : HttpApplication
    {
        public static int count_loggedInUser;

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void UpdateCount(Dictionary<DateTime,Int32> dt, DateTime key, int value)
        {
            if(dt.TryGetValue(key, out value))
            {
                dt[key] = ++value;
            }
            else
            {
                dt.Add(key, value);
            }

        }
        void Session_Start()
        {
            CommonCode.test();

            UpdateCount(CommonCode.dict, System.DateTime.Today,1);

            Console.WriteLine("process completed" + CommonCode.dict.Values.Last());
        }
    }
}