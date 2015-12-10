using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //(Cookie)
        HttpCookie userInfoCookie = new HttpCookie("userInfo");
        userInfoCookie.Values.Add("userName", txtUserName.Text);
        userInfoCookie.Values.Add("userAddress", txtAddress.Text);
        userInfoCookie.Values.Add("userPhoneNumber", txtPhoneNumber.Text);
        userInfoCookie.Values.Add("userLastVisit", DateTime.Now.ToString());
        userInfoCookie.Expires = DateTime.Now.AddDays(1);
        Response.Cookies.Add(userInfoCookie);
        //(Session)
        Session["sessionName"] = txtUserName.Text;
        Session["sessionAddress"] = txtAddress.Text;
        Session["sessionPhoneNumber"] = txtPhoneNumber.Text;
        //(Cache)
        Cache.Insert("cacheName", txtUserName.Text, null, DateTime.Now.AddMinutes(10), System.Web.Caching.Cache.NoSlidingExpiration);
        Cache.Insert("cacheAddress", txtAddress.Text, null, DateTime.Now.AddMinutes(10), System.Web.Caching.Cache.NoSlidingExpiration);
        Cache.Insert("cachePhoneNumber", txtPhoneNumber.Text, null, DateTime.Now.AddMinutes(10), System.Web.Caching.Cache.NoSlidingExpiration);
        //(Query)
        Response.Redirect("Cookie2.aspx?queryName=" + txtUserName.Text + "&queryAddress=" + txtAddress.Text + "&queryPhoneNumber=" + txtPhoneNumber.Text);
    }

    protected void btnCookie_Click(object sender, EventArgs e)
    {
        //(Cookie)
        HttpCookie userInfoCookie = new HttpCookie("userInfo");
        userInfoCookie.Values.Add("userName", txtUserName.Text);
        userInfoCookie.Values.Add("userAddress", txtAddress.Text);
        userInfoCookie.Values.Add("userPhoneNumber", txtPhoneNumber.Text);
        userInfoCookie.Values.Add("userLastVisit", DateTime.Now.ToString());
        userInfoCookie.Expires = DateTime.Now.AddDays(1);
        Response.Cookies.Add(userInfoCookie);
        Response.Redirect("Cookie2.aspx");
    }

    protected void btnSession_Click(object sender, EventArgs e)
    {
        //(Session)
        Session["sessionName"] = txtUserName.Text;
        Session["sessionAddress"] = txtAddress.Text;
        Session["sessionPhoneNumber"] = txtPhoneNumber.Text;
        Response.Redirect("Cookie2.aspx");
    }

    protected void btnCache_Click(object sender, EventArgs e)
    {
        //(Cache)
        Cache.Insert("cacheName", txtUserName.Text, null, DateTime.Now.AddMinutes(10), System.Web.Caching.Cache.NoSlidingExpiration);
        Cache.Insert("cacheAddress", txtAddress.Text, null, DateTime.Now.AddMinutes(10), System.Web.Caching.Cache.NoSlidingExpiration);
        Cache.Insert("cachePhoneNumber", txtPhoneNumber.Text, null, DateTime.Now.AddMinutes(10), System.Web.Caching.Cache.NoSlidingExpiration);
        Response.Redirect("Cookie2.aspx");
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        //(Query)
        Response.Redirect("Cookie2.aspx?queryName=" + txtUserName.Text + "&queryAddress=" + txtAddress.Text + "&queryPhoneNumber=" + txtPhoneNumber.Text);
    }
}
