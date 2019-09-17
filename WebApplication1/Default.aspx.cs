using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        private static int loginUserCount;
        int tst = Global.count_loggedInUser;

        public static int LoginUserCount { get => loginUserCount; set => loginUserCount = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["test"] = CommonCode.dict.Values.Last().ToString();
            lblCount.Text = CommonCode.dict.Values.Last().ToString(); 
        }
    }
}