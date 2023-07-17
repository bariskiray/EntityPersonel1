using Entities_;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_
{
    public class PersonellerrRepo
    {
        Model1 m = new Model1();
        DbSet<Personeller> _object;
        public int Delete(Personeller p)
        {
            _object.Remove(p);
            return m.SaveChanges();
        }

        public Personeller GetByID(int id)
        {
            return _object.Find(id);
        }
        public List<Personeller> List()
        {
            return _object.ToList();
        }

        public int Insert(Personeller p)
        {
            _object.Add(p);
            return m.SaveChanges();
        }

        public int Update(Personeller p)
        {
            return m.SaveChanges();
        }

        public Personeller Find(Expression<Func<Personeller, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }

        public List<Personeller> List(Expression<Func<Personeller, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }
    }
}
