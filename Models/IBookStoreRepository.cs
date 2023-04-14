using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_Lektion_CustomGenericsInterface.Models
{
    internal interface IBookStoreRepository<TEntity>
    {
       IList<TEntity> GetAll();

       TEntity Find(int id);

        void Add(TEntity entity);

        void Delete(int id);
        void Update(int id, TEntity entity);
    }
}
