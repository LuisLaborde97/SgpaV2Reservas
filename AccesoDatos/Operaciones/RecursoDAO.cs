using AccesoDatos.Context;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Operaciones
{
    public class RecursoDAO
    {
        public RecursosContext context = new RecursosContext();

        public List<Recurso> indexRecursos()
        {
            var recursos = context.Recursos.ToList();

            return recursos;
        }

        public Recurso selectRecurso(int id)
        {
            var recurso = context.Recursos.Where(a => a.IdRecurso == id).FirstOrDefault();

            if (recurso != null)
            {
                return recurso;
            }
            else
            {
                return null;
            }


        }

        public bool insertRecurso(string nombre, string descripcion, int precio, int estado)
        {
            try
            {
                var recurso = new Recurso
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Precio = precio,
                    Estado = estado
                };

                context.Recursos.Add(recurso);
                context.SaveChanges();

                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool updateRecurso(int id_recurso, string nombre, string descripcion, int precio, int estado)
        {
            try
            {
                var recurso = selectRecurso(id_recurso);
                if (recurso != null)
                {
                    recurso.Nombre = nombre;
                    recurso.Descripcion = descripcion;
                    recurso.Precio = precio;
                    recurso.Estado = estado;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteRecurso(int id)
        {
            var recurso = selectRecurso(id); 
            if (recurso != null)
            {
                context.Recursos.Remove(recurso);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool inhabilitarRecurso(int id, int estado)
        {
           
                
            try
            {
                var recurso = selectRecurso(id);
                if (recurso != null)
                {
                    recurso.Estado = estado;

                    context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }


        }
        
    }
}
