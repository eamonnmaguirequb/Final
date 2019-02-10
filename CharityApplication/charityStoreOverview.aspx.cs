using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization;
using System.Data.SqlClient;

namespace CharityApplication
{
    public partial class charityStoreOverview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection usercheckcon = new SqlConnection();
            usercheckcon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\charitySQL.mdf;Integrated Security=True";
            SqlCommand cmd = usercheckcon.CreateCommand();

            string username = string.Empty;
            string location = string.Empty;
            string signIn = Context.User.Identity.Name;

            usercheckcon.Open();
            cmd.CommandText = ("SELECT [charityName],[charityLocation] FROM [Charity] where charityOrganiser='" + signIn + "'");
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    username = reader.GetString(0);
                    location = reader.GetString(1);
                }
                usercheckcon.Close();
            }

            //string userName = Context.User.Identity.Name;



            userLoggedIn.Text = username;
            userLocation.Text = location;







            sqlImage.SelectParameters["charityStore"].DefaultValue = Context.User.Identity.Name;
        }
    }
}