using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Business
{
    public class Detay
    {
        Emlak.DataAccess.EmlakEntities ent = new DataAccess.EmlakEntities();
        public string OdaSayisi { get; set; }
        public string BinaYasi { get; set; }
        public string BinaKati { get; set; }
        public string Kat { get; set; }
        public string Isitma { get; set; }
        public string Esyalimi { get; set; }

        public List<Emlak.DataAccess.Detay> Listele()
        {
            var sonuc = ent.Detay.ToList();
            return sonuc;
        }

        public Emlak.DataAccess.Detay Getir(int id)
        {
            var sonuc = ent.Detay.Where(p => p.Id == id).FirstOrDefault();
            return sonuc;
        }

        public int Ekle()
        {
            Emlak.DataAccess.Detay ekle = new DataAccess.Detay();
            ekle.OdaSayisi = OdaSayisi;
            ekle.BinaYasi = BinaYasi;
            ekle.BinaKati = BinaKati;
            ekle.Kat = Kat;
            ekle.Isitma = Isitma;
            ekle.Esyalimi = Esyalimi;
            ent.Detay.Add(ekle);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Sil(int id)
        {
            var silinecek = Getir(id);
            ent.Detay.Remove(silinecek);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Guncelle(int id)
        {
            var guncellenecek = Getir(id);
            guncellenecek.OdaSayisi = OdaSayisi;
            guncellenecek.BinaYasi = BinaYasi;
            guncellenecek.BinaKati = BinaKati;
            guncellenecek.Kat = Kat;
            guncellenecek.Isitma = Isitma;
            guncellenecek.Esyalimi = Esyalimi;
            var sonuc = ent.SaveChanges();
            return sonuc;
        }
    }
}

