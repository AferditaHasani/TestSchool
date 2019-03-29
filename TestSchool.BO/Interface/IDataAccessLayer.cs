using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSchool.BO.Interface
{
    public interface IDataAccessLayer<T> where T:class
    {
        //void Add(T model);
        bool Add(T model);
        bool Modify(T model);
        bool Remove(int id);
        bool Remove(T model);

        T Get(int id);
        T Get(T model);
        IEnumerable<T> GetAll();

        //int Add(T model);

    }
}
