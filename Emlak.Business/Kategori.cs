using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Business
{
    public class Kategori
    {
        Emlak.DataAccess.EmlakEntities ent = new DataAccess.EmlakEntities();
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }

        public List<Emlak.DataAccess.Kategori> Listele()
        {
            var sonuc = ent.Kategori.ToList();
            return sonuc;
        }

        public Emlak.DataAccess.Kategori Getir(int id)
        {
            var sonuc = ent.Kategori.Where(p => p.Id == id).FirstOrDefault();
            return sonuc;
        }

        public int Ekle()
        {
            Emlak.DataAccess.Kategori ekle = new DataAccess.Kategori();
            ekle.KategoriAdi = KategoriAdi;
            ekle.Aciklama = Aciklama;
            ent.Kategori.Add(ekle);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Sil(int id)
        {
            var silinecek = Getir(id);
            ent.Kategori.Remove(silinecek);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Guncelle(int id)
        {
            var guncellenecek = Getir(id);
            guncellenecek.KategoriAdi = KategoriAdi;
            guncellenecek.Aciklama = Aciklama;
            var sonuc = ent.SaveChanges();
            return sonuc;
        }
    }
}
