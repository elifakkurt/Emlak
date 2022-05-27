using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Business
{
    public class Rol
    {
        Emlak.DataAccess.EmlakEntities ent = new DataAccess.EmlakEntities();
        public string RolAdi { get; set; }
        public string Aciklama { get; set; }

        public List<Emlak.DataAccess.Rol> Listele()
        {
            var sonuc = ent.Rol.ToList();
            return sonuc;
        }

        public Emlak.DataAccess.Rol Getir(int id)
        {
            var sonuc = ent.Rol.Where(p => p.Id == id).FirstOrDefault();
            return sonuc;
        }

        public int Ekle()
        {
            Emlak.DataAccess.Rol ekle = new DataAccess.Rol();
            ekle.RolAdi = RolAdi;
            ekle.Aciklama = Aciklama;
            ent.Rol.Add(ekle);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Sil(int id)
        {
            var silinecek = Getir(id);
            ent.Rol.Remove(silinecek);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        public int Guncelle(int id)
        {
            var guncellenecek = Getir(id);
            guncellenecek.RolAdi = RolAdi;
            guncellenecek.Aciklama = Aciklama;
            var sonuc = ent.SaveChanges();
            return sonuc;
        }
    }
}

