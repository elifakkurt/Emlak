using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak.Web.Area.Admin
{
    public partial class KullaniciListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Emlak.DataAccess.EmlakEntities ent = new Emlak.DataAccess.EmlakEntities();
            int id = Convert.ToInt32(Session["kullanici"]);
            var kullanıcı = ent.Kullanici.Where(x => x.Id == id).SingleOrDefault();
            var rol = ent.Rol.Where(y => y.Id == kullanıcı.RolId).SingleOrDefault();
            if (rol.RolAdi != "Admin")
            {
                Response.Redirect("/Area/Admin/ErisimEngellendi.aspx");
            }
            Emlak.Business.Kullanici Kullanici = new Emlak.Business.Kullanici();
            var Kullanicilar = Kullanici.Listele();
            KullaniciTablo.DataSource = Kullanicilar;
            KullaniciTablo.DataBind();
        }
        protected void KullaniciTabloCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "kullaniciSil")
            {
                Emlak.Business.Kullanici Kullanici = new Emlak.Business.Kullanici();
                var Sonuc = Kullanici.Sil(Convert.ToInt32(e.CommandArgument));
                if (Sonuc == 1)
                {
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    //Hata Mesaj
                }
            }
            if (e.CommandName == "kullaniciGuncelle")
            {
                Response.Redirect("~/Area/Admin/KullaniciGuncelle.aspx?Id=" + e.CommandArgument.ToString() + "");
            }
        }
    }
}