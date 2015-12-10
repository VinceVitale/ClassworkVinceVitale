using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cookie2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["userInfo"] != null)
        {
            //(cookie)
            string cookieName = Request.Cookies["userInfo"]["userName"];
            string cookieAddress = Request.Cookies["userInfo"]["userAddress"];
            string cookiePhoneNumber = Request.Cookies["userInfo"]["userPhoneNumber"];
            string cookieLastVisit = Request.Cookies["userInfo"]["userLastVisit"];
            lblUserNameC.Text = "User Name: " + cookieName;
            lblAddressC.Text = "Address: " + cookieAddress;
            lblPhoneNumberC.Text = "Phone Number: " + cookiePhoneNumber;
            lblLastVisitC.Text = "(Cookie)Last Visit: " + cookieLastVisit;
        }

        //(Session)
        string sessionName = (string)Session["sessionName"];
        string sessionAddress = (string)Session["sessionAddress"];
        string sessionPhoneNumber = (string)Session["sessionPhoneNumber"];
        lblUserNameC.Text = "User Name: " + sessionName;
        lblAddressC.Text = "Address: " + sessionAddress;
        lblPhoneNumberC.Text = "Phone Number: " + sessionPhoneNumber;
        lblLastVisitC.Text = "Session";

        //(Cached)
        string cacheName = (string)Cache["cacheName"];
        string cacheAddress = (string)Cache["cacheAddress"];
        string cachePhoneNumber = (string)Cache["cachePhoneNumber"];
        lblUserNameC.Text = "User Name: " + cacheName;
        lblAddressC.Text = "Address: " + cacheAddress;
        lblPhoneNumberC.Text = "Phone Number: " + cachePhoneNumber;
        lblLastVisitC.Text = "Cached";

        //(Query)
        string queryName = Request.QueryString["queryName"];
        string queryAddress = Request.QueryString["queryAddress"];
        string queryPhoneNumber = Request.QueryString["queryPhoneNumber"];
        lblUserNameC.Text = "User Name: " + queryName;
        lblAddressC.Text = "Address: " + queryAddress;
        lblPhoneNumberC.Text = "Phone Number: " + queryPhoneNumber;
        lblLastVisitC.Text = "Query";
    }
}
