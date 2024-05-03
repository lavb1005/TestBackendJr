using Aplicacion.Datos;
using Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepoUsuario : IRepositorio<usuarios>
    {
        //Se obtienen los usuarios
        public List<usuarios> Read
        {
            get
            {
                using(TESTDEVBACKJREntities db = new TESTDEVBACKJREntities())
                {
                    IQueryable<usuarios> lista = db.usuarios.Include(x => x.empleados);
                    return lista.ToList();
                }
            }
        }

        //Se crea un usuario
        public bool Create(usuarios entity)
        {
            try
            {
                using(TESTDEVBACKJREntities db = new TESTDEVBACKJREntities())
                {
                    db.usuarios.Add(entity);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error al agrear el registro: {ex.Message}");
                return false;
            }
        }

        //Se elimina un usuario
        public bool Delete(int id)
        {
            try
            {
                using(TESTDEVBACKJREntities db =new TESTDEVBACKJREntities())
                {
                    var entidad = db.usuarios.FirstOrDefault(x=>x.userId == id);
                    db.usuarios.Remove(entidad);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error al eliminar el usuario: {ex.Message}");
                return false;
            }
        }

        //Se actualiza un registro
        public bool Update(usuarios Modifyentity)
        {
            try
            {
                using(TESTDEVBACKJREntities db = new TESTDEVBACKJREntities())
                {
                    var entidad = db.usuarios.FirstOrDefault(x=>x.userId==Modifyentity.userId);
                    entidad.Login = Modifyentity.Login;
                    entidad.Nombre = Modifyentity.Nombre;
                    entidad.Paterno = Modifyentity.Paterno;
                    entidad.Materno = Modifyentity.Materno;
                    entidad.empleados = Modifyentity.empleados;

                    db.SaveChanges(); 
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocurrio un error al ACTUALIZAR el registro: {ex.Message}");
                return false;
            }
        }
    }
}
