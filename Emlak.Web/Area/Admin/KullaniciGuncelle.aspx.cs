using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emlak.Web.Area.Admin
{
    public partial class KullaniciGuncelle : System.Web.UI.Page
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
                Emlak.Business.Kullanici Kullanici = new Emlak.Business.Kullanici();
                var kullanici = Kullanici.Getir(Convert.ToInt32(Request.QueryString["Id"]));
                Adi.Text = kullanici.Ad;
                Soyadi.Text = kullanici.Soyad;
                Telefon.Text = kullanici.Telefon;
                Adres.Text = kullanici.Adres;
                Eposta.Text = kullanici.Eposta;
                KullaniciAdi.Text = kullanici.KullaniciAdi;
                Sifre.Text = kullanici.Sifre;                
            }
        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            Emlak.Business.Kullanici Kullanici = new Emlak.Business.Kullanici();
            Kullanici.Ad = Adi.Text;
            Kullanici.Soyad = Soyadi.Text;
            Kullanici.Telefon = Telefon.Text;
            Kullanici.Adres = Adres.Text;
            Kullanici.Eposta = Eposta.Text;
            Kullanici.KullaniciAdi = KullaniciAdi.Text;
            Kullanici.Sifre = Sifre.Text;
            Kullanici.RolId = Convert.ToInt32(RolAdi.SelectedItem.Value);
            var Sonuc = Kullanici.Guncelle(Convert.ToInt32(Request.QueryString["Id"]));
            if (Sonuc == 1)
            {
                Response.Redirect("~/Area/Admin/KullaniciListele.aspx");
            }
        }

    }
}