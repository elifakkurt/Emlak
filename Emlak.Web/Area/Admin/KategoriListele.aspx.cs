using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak.Web.Area.Admin
{
    public partial class KategoriListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Emlak.Business.Kategori kategori = new Emlak.Business.Kategori();
            var kategoriler = kategori.Listele();
            KategoriTablo.DataSource = kategoriler;
            KategoriTablo.DataBind();
        }
        protected void KategoriTabloCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "kategoriSil")
            {
                Emlak.Business.Kategori kategori = new Emlak.Business.Kategori();
                var Sonuc = kategori.Sil(Convert.ToInt32(e.CommandArgument));
                if (Sonuc == 1)
                {
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    //Hata Mesaj
                }
            }
            if (e.CommandName == "kategoriGuncelle")
            {
                Response.Redirect("~/Area/Admin/KategoriGuncelle.aspx?Id=" + e.CommandArgument.ToString() + "");
            }
        }
    }
}