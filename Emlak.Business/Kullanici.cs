using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Business
{
    public class Kullanici
    {

        Emlak.DataAccess.EmlakEntities ent = new DataAccess.EmlakEntities();
        public int RolId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Eposta { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public List<Emlak.DataAccess.Kullanici> Listele()
        {
            var sonuc = ent.Kullanici.ToList();
            return sonuc;
        }

        public Emlak.DataAccess.Kullanici Getir(int id)
        {
            var sonuc = ent.Kullanici.Where(p => p.Id == id).FirstOrDefault();
            return sonuc;
        }

        public int Ekle()
        {
            Emlak.DataAccess.Kullanici ekle = new DataAccess.Kullanici();
            ekle.RolId = RolId;
            ekle.Ad = Ad;
            ekle.Soyad = Soyad;
            ekle.Telefon = Telefon;
            ekle.Adres = Adres;
            ekle.Eposta = Eposta;
            ekle.KullaniciAdi = KullaniciAdi;
            ekle.Sifre = Sifre;
            ent.Kullanici.Add(ekle);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Sil(int id)
        {
            var silinecek = Getir(id);
            ent.Kullanici.Remove(silinecek);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Guncelle(int id)
        {
            var guncellenecek = Getir(id);
            guncellenecek.Ad = Ad;
            guncellenecek.RolId =RolId;
            guncellenecek.Soyad = Soyad;
            guncellenecek.Telefon = Telefon;
            guncellenecek.Adres = Adres;
            guncellenecek.Eposta = Eposta;
            guncellenecek.KullaniciAdi = KullaniciAdi;
            guncellenecek.Sifre = Sifre;
            var sonuc = ent.SaveChanges();
            return sonuc;
        }
        
    }
}
