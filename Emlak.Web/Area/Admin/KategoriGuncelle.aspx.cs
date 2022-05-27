using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak.Web.Area.Admin
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Emlak.Business.Kategori Kategori = new Emlak.Business.Kategori();
                var kategori = Kategori.Getir(Convert.ToInt32(Request.QueryString["Id"]));
                KategoriAdi.Text = kategori.KategoriAdi;
                Aciklama.Text = kategori.Aciklama;
            }
        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            Emlak.Business.Kategori Kategori = new Emlak.Business.Kategori();
            Kategori.KategoriAdi = KategoriAdi.Text;
            Kategori.Aciklama = Aciklama.Text;
            var Sonuc = Kategori.Guncelle(Convert.ToInt32(Request.QueryString["Id"]));
            if (Sonuc == 1)
            {
                Response.Redirect("~/Area/Admin/KategoriListele.aspx");
            }
        }

    }
}