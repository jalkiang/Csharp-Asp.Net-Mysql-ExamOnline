using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EOWeb.htmls
{
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            label_QyeryString.Text = Request.QueryString["num"];
            label_params.Text = Request.Params["num"];
            label_url.Text = Convert.ToString(Request.Url);
            label_islocal.Text = Request.IsLocal ? "本地" : "非本地";
            label_userHostAddress.Text = Request.UserHostAddress;
            label_browser.Text = Request.Browser.Browser;
        }
    }
}