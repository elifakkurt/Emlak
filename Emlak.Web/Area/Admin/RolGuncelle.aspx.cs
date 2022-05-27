using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak.Web.Area.Admin
{
    public partial class RolGuncelle : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                Emlak.Business.Rol Rol = new Emlak.Business.Rol();
                var roll = Rol.Getir(Convert.ToInt32(Request.QueryString["Id"]));
                RolAdi.Text = roll.RolAdi;
                Aciklama.Text = roll.Aciklama;
            }
        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            Emlak.Business.Rol Rol = new Emlak.Business.Rol();
            Rol.RolAdi = RolAdi.Text;
            Rol.Aciklama = Aciklama.Text;
            var Sonuc = Rol.Guncelle(Convert.ToInt32(Request.QueryString["Id"]));
            if (Sonuc == 1)
            {
                Response.Redirect("~/Area/Admin/RolListele.aspx");
            }
        }

    }
}