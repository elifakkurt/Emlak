using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak.Web.Area.Admin
{
    public partial class RolListele : System.Web.UI.Page
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
            Emlak.Business.Rol Rol = new Emlak.Business.Rol();
            var Roller = Rol.Listele();
            RolTablo.DataSource = Roller;
            RolTablo.DataBind();
        }
        protected void RolTabloCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "rolSil")
            {
                Emlak.Business.Rol Rol = new Emlak.Business.Rol();
                var Sonuc = Rol.Sil(Convert.ToInt32(e.CommandArgument));
                if (Sonuc == 1)
                {
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    //Hata Mesaj
                }
            }
            if (e.CommandName == "rolGuncelle")
            {
                Response.Redirect("~/Area/Admin/RolGuncelle.aspx?Id=" + e.CommandArgument.ToString() + "");
            }
        }
    }
}