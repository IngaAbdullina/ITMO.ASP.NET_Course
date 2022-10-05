using System;

namespace ITMO_ASP_FirstApp
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (IsPostBack)
                {
                    GuestResponse rsvp = new GuestResponse(name.Text, email.Text, phone.Text, CheckBoxYN.Checked);
                    ResponseRepository.GetRepository().AddResponse(rsvp);
                    if (rsvp.WillAttend.HasValue && rsvp.WillAttend.Value)
                    {
                        Response.Redirect("seeyouthere.html");
                    }
                    else
                    {
                        Response.Redirect("sorryyoucantcome.html");
                    }
                }
            }

        }
    }
}