using BusinessLayer_.BL_Abstract;
using DataAccessLayer_;
using DataAccessLayer_.DA_Abstract;
using Entities_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_
{
   public class ViewPersonelBirim_Manager: IViewPersonelBirimService_
    {
        public readonly IViewPersonelBirim _viewPersonelBirim;
        public ViewPersonelBirim_Manager(IViewPersonelBirim viewPersonelBirim)
        {
            _viewPersonelBirim = viewPersonelBirim;
        }
        public int BLAdd(viewPersonelBirim p)
        {
            return _viewPersonelBirim.Insert(p);

        }

        public int BLDelete(viewPersonelBirim p)
        {
            return _viewPersonelBirim.Delete(p);

        }

        public int BLUpdate(viewPersonelBirim p)
        {
            return (_viewPersonelBirim.Update(p));
        }


        public List<viewPersonelBirim> GetAll()
        {
           return _viewPersonelBirim.List();
        }
    }
}
