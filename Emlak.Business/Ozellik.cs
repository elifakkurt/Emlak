using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Business
{
    public class Ozellik
    {
        Emlak.DataAccess.EmlakEntities ent = new DataAccess.EmlakEntities();
        public string OzellikTipi { get; set; }
        public string Asansor { get; set; }
        public string Somine { get; set; }
        public string Kapici { get; set; }
        public string Alarm { get; set; }
        public string Park { get; set; }
        public string Yuruyus { get; set; }

        public List<Emlak.DataAccess.Ozellik> Listele()
        {
            var sonuc = ent.Ozellik.ToList();
            return sonuc;
        }

        public Emlak.DataAccess.Ozellik Getir(int id)
        {
            var sonuc = ent.Ozellik.Where(p => p.Id == id).FirstOrDefault();
            return sonuc;
        }

        public int Ekle()
        {
            Emlak.DataAccess.Ozellik ekle = new DataAccess.Ozellik();
            ekle.OzellikTipi = OzellikTipi;
            ekle.Asansor = Asansor;
            ekle.Somine = Somine;
            ekle.Kapici = Kapici;
            ekle.Alarm = Alarm;
            ekle.Park = Park;
            ekle.Yuruyus = Yuruyus;
            ent.Ozellik.Add(ekle);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Sil(int id)
        {
            var silinecek = Getir(id);
            ent.Ozellik.Remove(silinecek);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Guncelle(int id)
        {
            var guncellenecek = Getir(id);
            guncellenecek.OzellikTipi = OzellikTipi;
            guncellenecek.Asansor = Asansor;
            guncellenecek.Somine = Somine;
            guncellenecek.Kapici = Kapici;
            guncellenecek.Alarm = Alarm;
            guncellenecek.Park = Park;
            guncellenecek.Yuruyus = Yuruyus;
            var sonuc = ent.SaveChanges();
            return sonuc;
        }
    }
}
