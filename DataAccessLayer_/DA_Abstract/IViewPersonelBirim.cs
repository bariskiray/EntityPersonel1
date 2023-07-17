using Entities_;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_.DA_Abstract
{
    public interface IViewPersonelBirim
    {
        int Insert(viewPersonelBirim p);
        int Update(viewPersonelBirim p);
        int Delete(viewPersonelBirim p);
        List<viewPersonelBirim> List();
        viewPersonelBirim GetByID(int id);
        List<viewPersonelBirim> List(Expression<Func<viewPersonelBirim, bool>> filter);
        viewPersonelBirim Find(Expression<Func<viewPersonelBirim, bool>> where);
    }
}
