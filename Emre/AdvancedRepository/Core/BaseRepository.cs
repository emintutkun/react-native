using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Core
{
    public class BaseRepository<T>:IBaseRepository<T> where T: class
    {
        SirketContext _db;
        public BaseRepository(SirketContext db)
        {
            _db = db;
        }

        public bool Create(T ent)
        {
            try
            {
                Set().Add(ent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T ent)
        {
            try
            {
                Set().Remove(ent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Find(int id)
        {
            return Set().Find(id);

        }

        public List<T> List()
        {
            return Set().ToList();
        }

        //public void Save()
        //{
        //    _db.SaveChanges();
        //}

        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }

        public bool Update(T ent)
        {
            try
            {
                Set().Update(ent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
