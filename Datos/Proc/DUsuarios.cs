using Datos.Context;
using Dominio.DTO;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Proc
{
    public static class DUsuarios 
    {
        public static async Task<string> Create(Usuario user)
        {
            try
            {
               using(var context =new SeguridadInformaticaContext())
                {
                        context.Add(user);
                        var query = await context.SaveChangesAsync();
                        var result = (query > 0) ? "Guardado Correctamente" : "No se pudo Guardar";
                        return result;
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public static async Task<string> UnlockUser(Usuario user)
        {
            try
            {
                using(var context =  new SeguridadInformaticaContext())
                {
                    var getrol = await (from u in context.Usuarios
                                        join ur in context.RolUsuarios on u.Id equals ur.IdUsuario
                                      where u.Id.Equals(user.Id) && ur.IdRol.Equals(1)
                                      select ur).FirstOrDefaultAsync();   
                    if(getrol != null)
                    {
                        var usuario = await context.Usuarios.FindAsync(user.Correo);
                        if(usuario != null)
                        {
                            usuario.Password = user.Password;
                            usuario.Bloqueado = false;
                            usuario.Contador = 0;
                            usuario.UsuarioActualiza = user.UsuarioActualiza;
                            usuario.FechaActualizacion = user.FechaActualizacion;
                            context.Entry(usuario).State= EntityState.Modified;
                            var query = await context.SaveChangesAsync();
                            var result = (query > 0) ? "Contraseña reestablecida correctamente" : "No se pudo reestablecer contraseña";
                            return result;
                        }
                    }
                    return "Usuario no posee los permisos suficientes \nPara realizar esta accion";
                }

            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public static async Task<string> Update(Usuario user)
        {
            try
            {
               using(var context = new SeguridadInformaticaContext())
                {
                    var usuario = await context.Usuarios.FindAsync(user.Id);
                    if (usuario != null)
                    {
                        usuario.Nombre = user.Nombre;
                        usuario.Correo = user.Correo;
                        usuario.Login = user.Login;
                        usuario.Password = user.Password;
                        usuario.UsuarioActualiza = user.UsuarioActualiza;
                        usuario.FechaActualizacion = DateTime.Now;
                        context.Entry(usuario).State = EntityState.Modified;
                        var query = await context.SaveChangesAsync();
                        var result = (query > 0) ? "Guardado Correctamente" : "No se pudo Guardar";
                        return result;
                    }
                    return "No se pudo Guardar";
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public static async Task<string> Delete(Usuario user)
        {
            try
            {
                using (var context = new SeguridadInformaticaContext())
                {
                    var usuario = await context.Usuarios.FindAsync(user.Id);
                    if (usuario != null)
                    {
                        usuario.Activo = false;
                        usuario.UsuarioActualiza = user.UsuarioActualiza;
                        usuario.FechaActualizacion = user.FechaActualizacion;
                        context.Entry(usuario).State = EntityState.Modified;
                        var query = await context.SaveChangesAsync();
                        var result = (query > 0) ? "Eliminado Correctamente" : "No se pudo Eliminar";
                        return result;
                    }
                    return "No se pudo Eliminar";
                }
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public static async Task<List<UsuarioDTO>> GetListUsuarios()
        {
            try
            {
               using(var context = new SeguridadInformaticaContext())
                {
                    var list = await (from u in context.Usuarios
                                      where u.Activo.Equals(true)
                                      select new UsuarioDTO
                                      {
                                          Id = u.Id,
                                          Nombre = u.Nombre,
                                          Correo = u.Correo,
                                          Usuario = u.Login,
                                          FechaRegistro = u.FechaRegistro,
                                      }).ToListAsync();
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }
        public static async Task<List<UsuarioDTO>> SearchUsuarios(Usuario user)
        {
            try
            {
                using (var context = new SeguridadInformaticaContext())
                {
                     var list = await (from u in context.Usuarios
                                  where (
                                        u.Id.ToString().Contains(user.Id.ToString())||
                                        u.Nombre.Contains(user.Nombre)||
                                        u.Correo.Contains(user.Correo)||
                                        u.Login.Contains(user.Login)
                                  )&& u.Activo.Equals(true)
                                  select new UsuarioDTO
                                  {
                                      Id = u.Id,
                                      Nombre = u.Nombre,
                                      Correo = u.Correo,
                                      Usuario = u.Login,
                                      FechaRegistro = u.FechaRegistro,
                                  }).ToListAsync();
                return list;
                }
            }
            catch
            {
                return null;
            }
        }

        public static async Task<Usuario> GetUsarioId(Usuario user)
        {
            try
            {
                using (var context = new SeguridadInformaticaContext())
                {
                    var usuario = await context.Usuarios.FindAsync(user.Id);
                    return usuario;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}