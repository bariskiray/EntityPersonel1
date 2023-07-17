using Entities_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_.DA_Abstract
{
    public interface IBirimler
    {
        int Insert(Birimler p);
        int Update(Birimler p);
        int Delete(Birimler p);
        List<Birimler> List();
        Birimler GetByID(int id);
        List<Birimler> List(Expression<Func<Birimler, bool>> filter);
        Birimler Find(Expression<Func<Birimler, bool>> where);
    }
}
