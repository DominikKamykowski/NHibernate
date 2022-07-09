using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kolokwium_.Api;

namespace kolokwium_
{
    public partial class postList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                KolokwiumApi api = new KolokwiumApi();
                var posts = api.GetPosts();
                gvPosts.DataSource = posts;
                gvPosts.DataBind();
            }

        }
    }
}