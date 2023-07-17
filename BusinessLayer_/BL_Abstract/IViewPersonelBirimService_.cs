using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities_;

namespace BusinessLayer_.BL_Abstract
{
    public interface IViewPersonelBirimService_
    {
        List<viewPersonelBirim> GetAll();
        int BLAdd(viewPersonelBirim p);

        int BLDelete(viewPersonelBirim p);

        int BLUpdate(viewPersonelBirim p);
    }
}
