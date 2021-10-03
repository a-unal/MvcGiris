using dataacceslayer.concrete.Repositories;
using entitylayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.Concrete
{
 public class CategoryManager
    {
        GenericRepository<category> repo = new GenericRepository<category>();

        public List<category> GetAllBL()
        {
            return repo.List();
        }
        public void CategoryAddBL(category p)
        {
            if(p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {
                // Hata Mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
