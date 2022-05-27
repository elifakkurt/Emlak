using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak.Web.Area.Admin
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            Emlak.Business.Kategori kategori = new Emlak.Business.Kategori();
            kategori.KategoriAdi = KategoriAdi.Text;
            kategori.Aciklama = Aciklama.Text;
            kategori.Ekle();
            Response.Redirect("~/Area/Admin/KategoriListele.aspx");
        }
    }
}