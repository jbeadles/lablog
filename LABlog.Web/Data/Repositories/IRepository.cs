using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABlog.Data.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T Find(int id);
        T Create(T t);
        T Update(T t);
        void Delete(int id);
    }
}
