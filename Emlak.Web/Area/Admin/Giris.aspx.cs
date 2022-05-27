using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak.Web.Area.Admin
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GirisBtn_Click(object sender, EventArgs e)
        {
            Emlak.DataAccess.EmlakEntities ent = new Emlak.DataAccess.EmlakEntities();
            var kullanıcı = ent.Kullanici.Where(x => x.KullaniciAdi == KullaniciAdi.Text && x.Sifre == Sifre.Text).SingleOrDefault();
            Session.Add("kullanici", kullanıcı.Id);
            Response.Redirect("default.aspx");
        }
    }
}