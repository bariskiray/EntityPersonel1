using EntityPersonel1.DataAccessLayer.Abstract;
using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonel1.DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Model1 m = new Model1();
        DbSet<T> _object;
        public Repository ()
        {
            _object = m.Set<T>();
        }
        public int Delete(T p)
        {
            _object.Remove(p);
            return m.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }
        public List<T> List()
        {
            return _object.ToList();
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return m.SaveChanges();
        }

        public int Update(T p)
        {
            return m.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }
    }
}
