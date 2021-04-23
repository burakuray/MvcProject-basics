using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T p);
        void Remove(T p);
        void Update(T p);

        //filter seklindeki list metodu (Sadece X gelsin)
        List<T> List(Expression<Func<T,bool>> filter);
    }
}
