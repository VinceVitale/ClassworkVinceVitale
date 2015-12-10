using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ch7Lab : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack){ddlState.Items.Add(new ListItem("Select State", "0"));}
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            txtUserInfo.Visible = true;

            txtUserInfo.Text = string.Format("Name: {0} {1}\nEmail: {2}\nZip Code: {3}\nDOB: {4}\nState: {5}\nPassword: {6}\nQuantity: {7}\nAge: {8}", txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtZipCode.Text, txtBirthday.Text, ddlState.SelectedValue, txtPassword.Text, txtQuantity.Text, txtAge.Text);
            lblUserInfo.Text = txtUserInfo.Text;
            btnSubmit.Enabled = false;
        }
    }
}
