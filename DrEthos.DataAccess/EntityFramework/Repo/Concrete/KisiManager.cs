using DrEthos.Entities.Kisiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrEthos.DataAccess.EntityFramework.Repo.Concrete
{
    public class KisiManager : IDataRepository<Kisi>
    {
        readonly EFDatabaseContext _kisiContext;
        public KisiManager(EFDatabaseContext context)
        {
            _kisiContext = context;
        }
        public IEnumerable<Kisi> GetAll()
        {
            return _kisiContext.Kisi.ToList();
        }
        public Kisi Get(Guid id)
        {
            return _kisiContext.Kisi
                  .FirstOrDefault(e => e.Id == id);
        }
        public void Add(Kisi entity)
        {
            _kisiContext.Kisi.Add(entity);
            _kisiContext.SaveChanges();
        }
        public void Update(Guid id, Kisi entity)
        {
            var kisi = _kisiContext.Kisi.Find(id);

            kisi.Adi = entity.Adi;
            kisi.Soyadi = entity.Soyadi;
            kisi.Telefon = entity.Telefon;
            kisi.DogumTarihi = entity.DogumTarihi;

            _kisiContext.SaveChanges();
        }
        public void Delete(Guid id)
        {
            var kisi=_kisiContext.Kisi.Find(id);
            _kisiContext.Kisi.Remove(kisi);

            _kisiContext.SaveChanges();
        }
    }
}
