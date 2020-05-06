using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> List { get;}
        T FindById(int Id);
    }
}
