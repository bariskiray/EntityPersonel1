using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonel1.BusinessLayer.BL_Abstract
{
    public interface IPersonellerService
    {
        List<Personeller> GetAll();
        int BLAdd(Personeller p);

        int BLDelete(Personeller p);

        int BLUpdate(Personeller p);

        List<Personeller> GetByName(string name);
    }
}
