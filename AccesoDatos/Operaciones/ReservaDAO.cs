using AccesoDatos.Context;
using AccesoDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Operaciones
{
    public class ReservaDAO
    {
        private RecursosContext context = new RecursosContext();

        public List<IndexReservas> index(int id)
        {
            var query = from r in context.Reservas
                        join u in context.Usuarios on r.IdUsuario equals u.IdUsuario
                        join re in context.Recursos on r.IdRecurso equals re.IdRecurso
                        where u.IdUsuario == id && re.Estado == 1
                        select new IndexReservas
                        {
                            Id = u.IdUsuario,
                            NombreUsuario = u.Nombre,
                            NombreEvento = re.Nombre,
                            Descripcion = re.Descripcion,
                            Fecha = r.Fecha,
                            Precio = re.Precio
                        };

            return query.ToList();
        }
        public bool selectRecursoExistente(int id_recurso)
        {
            var existente = context.Reservas.Where(a => a.IdRecurso == id_recurso).FirstOrDefault();

            if (existente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool insertarReserva(int id_recurso, int id_usuario, int estado, string fecha)
        {

            try
            {

                if (selectRecursoExistente(id_recurso) == true)
                {
                    var reserva = new Reserva
                    {
                        IdRecurso = id_recurso,
                        IdUsuario = id_usuario,
                        Estado = estado,
                        Fecha = fecha
                    };
                    context.Reservas.Add(reserva);
                    context.SaveChanges();
                    RecursoDAO recurso = new RecursoDAO();
                    


                    return recurso.inhabilitarRecurso(id_recurso, 2);
                }
                 else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                return false;
            }

        }

        public List<ReservaOne> showReserva(int id)
        {
            var query = from r in context.Reservas
                        join u in context.Usuarios on r.IdUsuario equals u.IdUsuario
                        join re in context.Recursos on r.IdRecurso equals re.IdRecurso
                        where r.IdReserva == id && r.Estado == 1
                        select new ReservaOne
                        {
                            IdReserva = r.IdReserva,
                            NombreUsuario = u.Nombre,
                            NombreEvento = re.Nombre,
                            Descripcion = re.Descripcion,
                            Fecha = r.Fecha,
                            Precio = re.Precio
                        };

            return query.ToList();


        }

        public Reserva selectReserva(int id)
        {
            var reserva = context.Reservas.Where(a => a.IdReserva == id).FirstOrDefault();

            if (reserva != null)
            {
                return reserva;
            }
            else
            {
                return null;
            }
        }


        public bool editReserva(int id_reserva, int id_recurso, int id_usuario, int estado, string fecha)
        {
            try
            {
                var reserva = selectReserva(id_reserva);

                if (reserva != null)
                {
                    reserva.IdRecurso = id_recurso;
                    reserva.IdUsuario = id_usuario;
                    reserva.Estado = estado;
                    reserva.Fecha = fecha;

                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }


            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteReserva(int id)
        {
            try
            {
                var reserva = selectReserva(id);
                if (reserva != null)
                {
                    RecursoDAO recurso = new RecursoDAO();
                    recurso.inhabilitarRecurso(reserva.IdRecurso, 1);
                    context.Remove(reserva);
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


