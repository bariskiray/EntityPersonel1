using Entities_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_.DA_Abstract
{
    public interface IPersoneller
    {
        int Insert(Personeller p);
        int Update(Personeller p);
        int Delete(Personeller p);
        List<Personeller> List();
        Personeller GetByID(int id);
        List<Personeller> List(Expression<Func<Personeller, bool>> filter);
        Personeller Find(Expression<Func<Personeller, bool>> where);
    }
}
