using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak.Web
{
    public enum Yetki
    {
        Admin=1,
        Kullanici=2
    }
    public partial class YetkiKontrol : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            var yetki = (Emlak.Business.Kullanici)System.Web.HttpContext.Current.Session["Kullanici"];
            if (yetki.KullaniciAdi != "Admin")
            {
                Response.Redirect("/Default.aspx");
                base.OnLoad(e);
            }
            if (yetki.KullaniciAdi != "Kullanici")
            {
                Response.Redirect("/Default.aspx");
                base.OnLoad(e);
            }
        }
    }
}