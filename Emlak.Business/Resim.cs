using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Business
{
    public class Resim
    {
        Emlak.DataAccess.EmlakEntities ent = new DataAccess.EmlakEntities();
        public string IlanId { get; set; }
        public string ResimAdi { get; set; }
        public string ResimYol { get; set; }

        public List<Emlak.DataAccess.Resim> Listele()
        {
            var sonuc = ent.Resim.ToList();
            return sonuc;
        }

        public Emlak.DataAccess.Resim Getir(int id)
        {
            var sonuc = ent.Resim.Where(p => p.Id == id).FirstOrDefault();
            return sonuc;
        }

        public int Ekle()
        {
            Emlak.DataAccess.Resim ekle = new DataAccess.Resim();
            ekle.IlanId =Convert.ToInt32(IlanId);
            ekle.ResimAdi = ResimAdi;
            ekle.ResimYol = ResimYol;
            ent.Resim.Add(ekle);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Sil(int id)
        {
            var silinecek = Getir(id);
            ent.Resim.Remove(silinecek);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Guncelle(int id)
        {
            var guncellenecek = Getir(id);
            guncellenecek.IlanId = Convert.ToInt32(IlanId);
            guncellenecek.ResimAdi = ResimAdi;
            guncellenecek.ResimYol = ResimYol;
            var sonuc = ent.SaveChanges();
            return sonuc;
        }
    }
}

