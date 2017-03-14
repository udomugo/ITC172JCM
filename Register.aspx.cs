using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAServiceReference;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RegisterButton_Click(object sender, EventArgs e)
    {
        CAServiceClient cas = new CAServiceClient();
        PersonLite pl = new PersonLite();
        pl.LastName = LastNameTextBox.Text;
        pl.FirstName = FirstNameTextBox.Text;
        pl.Email = EmailTextBox.Text;
        pl.Apartment = AptTextBox.Text;
        pl.Street = StreetTextBox.Text;
        pl.City = CityTextBox.Text;
        pl.State = StateTextBox.Text;
        pl.HomePhone = HomePhoneTextBox.Text;
        pl.WorkPhone = WorkPhoneTextBox.Text;
        pl.Password = NewPassTextBox.Text;
        bool result = cas.RegisterPerson(pl);
        if (result)
        {
            ResultLabel.Text = "Registration Successful";
        }
        else
        {
            ResultLabel.Text = "Registration Failed";
        }
    }
}