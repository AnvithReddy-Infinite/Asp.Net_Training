using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetValidationAssignment
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheckDetails_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string familyName = txtFamilyName.Text.Trim();
            string userAddress = txtAddress.Text.Trim();
            string userCity = txtCity.Text.Trim();
            string zipCode = txtZipCode.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string emailAddress = txtEmailAddress.Text.Trim();



            if (userName.Equals(familyName, StringComparison.OrdinalIgnoreCase))
            {
                lblResultMessage.Text = "Name and Family Name should not be the same.";
                lblResultMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (userAddress.Length < 2)
            {
                lblResultMessage.Text = "Address must contain at least 2 characters.";
                lblResultMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (userCity.Length < 2)
            {
                lblResultMessage.Text = "City must contain at least 2 characters.";
                lblResultMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (zipCode.Length != 5 || !zipCode.All(char.IsDigit))
            {
                lblResultMessage.Text = "Zip Code must contain exactly 5 digits.";
                lblResultMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string[] phoneParts = phoneNumber.Split('-');

            if (phoneParts.Length != 2)
            {
                lblResultMessage.Text = "Phone number must contain a single '-' symbol.";
                lblResultMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string firstPart = phoneParts[0];
            string secondPart = phoneParts[1];

            bool firstPartValid = (firstPart.Length == 2 || firstPart.Length == 3 || firstPart.Length == 0) && firstPart.All(char.IsDigit);
            bool secondPartValid = (secondPart.Length == 10) && secondPart.All(char.IsDigit);

            if (!firstPartValid || !secondPartValid)
            {
                lblResultMessage.Text = "Phone number format should be XX-XXXXXXXXXX or XXX-XXXXXXX or XXXXXXXXXX.";
                lblResultMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(emailAddress) ||
               !emailAddress.Contains("@") ||
               !emailAddress.Contains(".") ||
               emailAddress.IndexOf("@") > emailAddress.LastIndexOf("."))
            {
                lblResultMessage.Text = "Please enter a valid email address.";
                lblResultMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }



            lblResultMessage.Text = "All Validations passed successfully ";
            lblResultMessage.ForeColor = System.Drawing.Color.Green;
        }


    }
}