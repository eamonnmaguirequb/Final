using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CharityApplication
{
    public partial class charityStoreOverview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlImage.SelectParameters["charityStore"].DefaultValue = Context.User.Identity.Name;
        }
    }
}