using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Business
{
    public class Ilan
    {
        Emlak.DataAccess.EmlakEntities ent = new DataAccess.EmlakEntities();
        public int KategoriId { get; set; }
        public int KullaniciId { get; set; }
        public int DetayId { get; set; }
        public int OzellikId { get; set; }
        public string Baslik { get; set; }
        public string Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        public string Vitrin { get; set; }
        public string VitrinResim { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }

        public List<Emlak.DataAccess.Ilan> Listele()
        {
            var sonuc = ent.Ilan.ToList();
            return sonuc;
        }

        public Emlak.DataAccess.Ilan Getir(int id)
        {
            var sonuc = ent.Ilan.Where(p => p.Id == id).FirstOrDefault();
            return sonuc;
        }

        public int Ekle()
        {
            Emlak.DataAccess.Ilan ekle = new DataAccess.Ilan();
            ekle.KategoriId = KategoriId;
            ekle.KullaniciId =KullaniciId;
            ekle.DetayId = DetayId;
            ekle.OzellikId =OzellikId;
            ekle.Baslik = Baslik;
            ekle.Fiyat = Fiyat;
            ekle.Tarih = Tarih;
            ekle.Vitrin = Vitrin;
            ekle.VitrinResim = VitrinResim;
            ekle.Adres = Adres;
            ekle.Aciklama = Aciklama;
            ent.Ilan.Add(ekle);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Sil(int id)
        {
            var silinecek = Getir(id);
            ent.Ilan.Remove(silinecek);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Guncelle(int id)
        {
            var guncellenecek = Getir(id);
            guncellenecek.KategoriId = KategoriId;
            guncellenecek.KullaniciId = KullaniciId;
            guncellenecek.DetayId = DetayId;
            guncellenecek.OzellikId = OzellikId;
            guncellenecek.Baslik = Baslik;
            guncellenecek.Fiyat = Fiyat;
            guncellenecek.Tarih = Tarih;
            guncellenecek.Vitrin = Vitrin;
            guncellenecek.VitrinResim = VitrinResim;
            guncellenecek.Adres = Adres;
            guncellenecek.Aciklama = Aciklama;
            var sonuc = ent.SaveChanges();
            return sonuc;
        }
    }
}
