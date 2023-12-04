using Datos.Context;
using Dominio.DTO;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Proc
{
    public static class DPermisos
    {
        public static async Task<List<PermisosDTO>> GetPermisos(Usuario user)
        {
            try
            {
                using(var context = new SeguridadInformaticaContext())
                {
                    var list = await (from ur in context.RolUsuarios
                                      join r in context.Roles on ur.IdRol equals r.Id
                                      join u in context.Usuarios on ur.IdUsuario equals u.Id
                                      join pr in context.RolPermisos on r.Id equals pr.IdRol
                                      join p in context.Permisos on pr.IdPermiso equals p.Id
                                      where ur.Activo.Equals(true)
                                      select new PermisosDTO
                                      {
                                          Id = ur.Id,
                                          Nombre = u.Nombre,
                                          Rol = r.Rol,
                                          Permisos = p.Permiso1
                                      }
                                 ).ToListAsync();
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }

        public static async Task<List<Usuario>> UsuariosList()
        {
            try
            {
                using(var context = new SeguridadInformaticaContext())
                {

                    var list = await (from u in context.Usuarios
                                      where u.Activo.Equals(true)
                                      select new Usuario
                                      {
                                          Id = u.Id,
                                          Nombre = u.Nombre
                                      }).ToListAsync();
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }
        public static async Task<List<Role>> RolesList()
        {
            try
            {
                using(var context = new SeguridadInformaticaContext())
                {
                    var list = await (from r in context.Roles
                                      where r.Activo.Equals(true)
                                      select new Role
                                      {
                                          Id = r.Id,
                                          Rol = r.Rol
                                      }).ToListAsync();
                    return list;
                }
            }
            catch { return null; }
        }
        public static async Task<string> AgregarPermiso(RolUsuario permiso)
        {
            try
            {
               using(var context = new SeguridadInformaticaContext())
                {
                    var p = await context.RolUsuarios.Where(pr => pr.IdUsuario.Equals(permiso.IdUsuario)
               && pr.IdRol.Equals(permiso.IdRol)).FirstOrDefaultAsync();
                    if (p == null)
                    {
                        context.Add(permiso);
                        var query = await context.SaveChangesAsync();
                        var result = (query > 0) ? "Guardado Correctamente" : "No se pudo Guardar";
                        return result;
                    }
                    return $"Permiso ya existe con id = {p.Id}";
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public static async Task<string> Eliminar(PermisosDTO obj,Usuario user)
        {
            try
            {
               using(var context = new SeguridadInformaticaContext())
                {
                    var permiso = await context.RolUsuarios.FindAsync(obj.Id);
                    if (permiso != null)
                    {
                        permiso.Activo = false;
                        permiso.UsuarioActualiza = user.Id;
                        permiso.FechaActualizacion = user.FechaActualizacion;
                        context.Entry(permiso).State = EntityState.Modified;
                        var query = await context.SaveChangesAsync();
                        var result = (query > 0) ? "Revocado Correctamente" : "No se pudo Revocar Permiso";
                        return result;
                    }
                    return "No se pudo Revocar Permiso";
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}