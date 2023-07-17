using DataAccessLayer_.DA_Abstract;
using Entities_;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer_
{
    public class BirimlerRepo : IBirimler
    {
        Model1 m = new Model1();
        DbSet<Birimler> _object;
        public int Delete(Birimler p)
        {
            _object.Remove(p);
            return m.SaveChanges();
        }

        public Birimler GetByID(int id)
        {
            return _object.Find(id);
        }
        public List<Birimler> List()
        {
            return _object.ToList();
        }

        public int Insert(Birimler p)
        {
            _object.Add(p);
            return m.SaveChanges();
        }

        public int Update(Birimler p)
        {
            return m.SaveChanges();
        }

        public Birimler Find(Expression<Func<Birimler, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }

        public List<Birimler> List(Expression<Func<Birimler, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

    }
}
