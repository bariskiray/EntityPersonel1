using EntityPersonel1.DataAccessLayer;
using EntityPersonel1.DataAccessLayer.Abstract;
using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonel1.BusinessLayer
{
    public class ViewPersonelBirimManager
    {
        Repository<viewPersonelBirim> personelbirimrepo = new Repository<viewPersonelBirim>();
        public List<viewPersonelBirim> GetAll()
        {
            return personelbirimrepo.List();
        }
            
    }
}
