using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak.Web.Area.Admin
{
    public partial class Anasayfa : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["kullanici"]);
            Emlak.DataAccess.EmlakEntities ent = new Emlak.DataAccess.EmlakEntities();
            var kullanıcı = ent.Kullanici.Where(x => x.Id == id).SingleOrDefault();
            if (Session["kullanici"] != null)
            {
                NavBarKullanici.Text = kullanıcı.Ad + " " + kullanıcı.Soyad;
            }
            else
            {
                Response.Redirect("/Area/Admin/Giris.aspx");
            }
        }
    }
}