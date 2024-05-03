using ClassLibrary1;
using ClassLibrary1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ManEmpleado : IManEmpleados
    {
        readonly IRepositorio<empleados> _repositorio;

        //************************************************************
        //              Constructor de la Clase
        public ManEmpleado(IRepositorio<empleados> repositorio)
        {
            _repositorio = repositorio;
        }
        //************************************************************

        public List<empleados> Listar => _repositorio.Read;

        public bool Agregar(empleados entidad) => _repositorio.Create(entidad);

        public bool Eliminar(int id) => _repositorio.Delete(id);

        public bool Modificar(empleados entidad) => _repositorio.Update(entidad);
    }
}
