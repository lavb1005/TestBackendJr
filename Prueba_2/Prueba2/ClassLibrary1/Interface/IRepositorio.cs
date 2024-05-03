using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interface
{
    public interface IRepositorio<T> where T : class
    {
        Boolean Create (T entity);
        List<T> Read {  get; }
        Boolean Update (T Modifyentity);
        Boolean Delete (int id);
    }
}
