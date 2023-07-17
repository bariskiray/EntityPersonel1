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
    public class ViewPersonelBirimRepo
    {
        Model1 m = new Model1();
        DbSet<viewPersonelBirim> _object;
        public int Delete(viewPersonelBirim p)
        {
            _object.Remove(p);
            return m.SaveChanges();
        }

        public viewPersonelBirim GetByID(int id)
        {
            return _object.Find(id);
        }
        public List<viewPersonelBirim> List()
        {
            return _object.ToList();
        }

        public int Insert(viewPersonelBirim p)
        {
            _object.Add(p);
            return m.SaveChanges();
        }

        public int Update(viewPersonelBirim p)
        {
            return m.SaveChanges();
        }

        public viewPersonelBirim Find(Expression<Func<viewPersonelBirim, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }

        public List<viewPersonelBirim> List(Expression<Func<viewPersonelBirim, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }
    }
}
