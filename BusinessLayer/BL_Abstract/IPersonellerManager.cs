using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonel1.BusinessLayer.BL_Abstract
{
    public interface IPersonellerManager<T>
    {
        List<T> GetAll();
        int BLAdd(T p);

        int BLDelete(T p);

        int BLUpdate(T p);
    }
}
