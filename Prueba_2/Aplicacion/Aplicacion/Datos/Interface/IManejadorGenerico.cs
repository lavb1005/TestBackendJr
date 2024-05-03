using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IManejadorGenerico<T> where T : class
    {
        Boolean Agregar(T entidad);
        List<T> Listar { get; }
        Boolean Eliminar(int id);
        Boolean Modificar(T entidad);
    }
}
