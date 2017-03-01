using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Donate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //make sure they are logged in to see this page.
        if (Session["userKey"] == null)
            Response.Redirect("Default.aspx");
    }

    protected void DonateButton_Click(object sender, EventArgs e)
    {
        Community_AssistEntities cae = new Community_AssistEntities();
        //get the key from the session
        int key = (int)Session["userKey"];

        decimal evalDonation;
        if (decimal.TryParse(DonationTextBox.Text, out evalDonation))
        {
            if (evalDonation > 0)
            {
                //Make a new Donation object
                Donation d = new Donation();
                //assign the values
                d.DonationAmount = decimal.Parse(DonationTextBox.Text);
                d.DonationDate = DateTime.Now;
                d.PersonKey = key;

                //add the donatin to the collected Donations
                cae.Donations.Add(d);
                //save the changes to the database
                cae.SaveChanges();

                Response.Redirect("Donations.aspx");
            }
            else
            {
                ErrorLabel.Text = "Donations must be a positive amount greater than $0.00.";
            }
        }
        else
        {
            ErrorLabel.Text = "Please enter a donation amount.";
        }
    }
}