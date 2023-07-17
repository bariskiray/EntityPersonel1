using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities_;

namespace BusinessLayer_.BL_Abstract
{
    public interface IPersonellerService_
    {
        List<Personeller> GetAll();
        int BLAdd(Personeller p);

        int BLDelete(Personeller p);

        int BLUpdate(Personeller p);

        List<Personeller> GetByName(string name);
    }
}
