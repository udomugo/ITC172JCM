using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class userWelcome : System.Web.UI.Page
{
    UserWelcome uw = new UserWelcome();
    protected void Page_Load(object sender, EventArgs e)
    {
        if("useKey" != null)
        {
            if (!IsPostBack)
            {
                DataTable table = uw.GetPeople();
                PersonDropDownList.DataSource = table;
                PersonDropDownList.DataTextField = "PersonName";
                PersonDropDownList.DataValueField = "PersonKey";
                PersonDropDownList.DataBind();
                ListItem item = new ListItem("Select a Person");
                PersonDropDownList.Items.Insert(0, item);
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void FillGridView()
    {
        if(!PersonDropDownList.SelectedItem.Text.Equals("Select a Person"))
        {
            int key = int.Parse(PersonDropDownList.SelectedValue.ToString());
            DataTable tbl = uw.GetGrantReviews(key);
            GrantExplainGridView.DataSource = tbl;
            GrantExplainGridView.DataBind();
        }
    }

    protected void PersonDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGridView();
    }
}