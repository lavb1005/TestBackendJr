using Aplicacion.Datos;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ManUsuario : IManUsuario
    {
        readonly IRepositorio<usuarios> _repositorio;

        //************************************************************
        //              Constructor de la Clase
        public ManUsuario(IRepositorio<usuarios> repositorio)
        {
            this._repositorio = repositorio;
        }
        //************************************************************


        public List<usuarios> Listar => _repositorio.Read;

        public bool Agregar(usuarios entidad) => _repositorio.Create(entidad);

        public bool Eliminar(int id) => _repositorio.Delete(id);

        public bool Modificar(usuarios entidad) => _repositorio.Update(entidad);
    }
}
