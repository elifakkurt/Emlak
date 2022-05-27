using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Emlak.Web
{
    public class Global : System.Web.HttpApplication
    {
        void Yonlendir(RouteCollection route)
        {
            route.MapPageRoute("KategoriAdi","Kategori", "~/Area/Admin/KategoriEkle.aspx");
            route.MapPageRoute("Aciklama", "Kategori", "~/Area/Admin/KategoriEkle.aspx");

            route.MapPageRoute("OdaSayisi", "OdaSayisi", "~/Detay.aspx");
            route.MapPageRoute("BinaYasi", "BinaYasi", "~/Detay.aspx");
            route.MapPageRoute("BinaKati", "BinaKati", "~/Detay.aspx");
            route.MapPageRoute("Kat", "Kat", "~/Detay.aspx");
            route.MapPageRoute("Isitma", "Isitma", "~/Detay.aspx");
            route.MapPageRoute("Esyalimi", "Esyalimi", "~/Detay.aspx");

            route.MapPageRoute("OzellikTipi", "OzellikTipi", "~/Ozellik.aspx");
            route.MapPageRoute("Asansor", "Asansor", "~/Ozellik.aspx");
            route.MapPageRoute("Somine", "Somine", "~/Ozellik.aspx");
            route.MapPageRoute("Kapici", "Kapici", "~/Ozellik.aspx");
            route.MapPageRoute("Alarm", "Alarm", "~/Ozellik.aspx");
            route.MapPageRoute("Park", "Park", "~/Ozellik.aspx");
            route.MapPageRoute("Yuruyus", "Yuruyus", "~/Ozellik.aspx");

            route.MapPageRoute("Ad", "Ad", "~/Kullanici.aspx");
            route.MapPageRoute("Soyad", "Soyad", "~/Kullanici.aspx");
            route.MapPageRoute("Adres", "Adres", "~/Kullanici.aspx");
            route.MapPageRoute("Park", "Park", "~/Ozellik.aspx");
            route.MapPageRoute("Yuruyus", "Yuruyus", "~/Ozellik.aspx");






        }
    }
}