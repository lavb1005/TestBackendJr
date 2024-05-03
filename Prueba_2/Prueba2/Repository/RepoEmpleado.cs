using ClassLibrary1;
using ClassLibrary1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepoEmpleado : IRepositorio<empleados>
    {
        //Se obtienen los empleados
        public List<empleados> Read
        {
            get
            {
                using (TESTDEVBACKJREntities1 db = new TESTDEVBACKJREntities1())
                {
                    IQueryable<empleados> lista = db.empleados;
                    return lista.ToList();
                }
            }
        }

        //Se crea un usuario
        public bool Create(empleados entity)
        {
            try
            {
                using (TESTDEVBACKJREntities1 db = new TESTDEVBACKJREntities1())
                {
                    db.empleados.Add(entity);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error al agregar el registro: {ex.Message}");
                return false;
            }
        }

        //Se elimina un registro
        public bool Delete(int id)
        {
            try
            {
                using (TESTDEVBACKJREntities1 db = new TESTDEVBACKJREntities1())
                {
                    var entidad = db.usuarios.FirstOrDefault(x => x.userId == id);
                    db.usuarios.Remove(entidad);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error al ELIMINAR el registro: {ex.Message}");
                return false;
            }
        }

        //Se actualiza un registro
        public bool Update(empleados Modifyentity)
        {
            try
            {
                using (TESTDEVBACKJREntities1 db = new TESTDEVBACKJREntities1())
                {
                    var entidad = db.empleados.FirstOrDefault(x => x.userId == Modifyentity.userId);
                    entidad.Sueldo = Modifyentity.Sueldo;
                    entidad.FechaIngreso = Modifyentity.FechaIngreso;

                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error al ACTUALIZAR el registro: {ex.Message}");
                return false;
            }
        }
    }
}
