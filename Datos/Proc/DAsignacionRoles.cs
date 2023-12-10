using Datos.Context;
using Dominio.DTO;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Datos.Proc
{
    public static class DAsignacionRoles
    {
        public static async Task<List<RolDTO>> UserRolList(Usuario user) { 
            
            using(var context = new SeguridadInformaticaContext())
            {
                List<RolDTO> ListRoles = await (from u in context.Usuarios
                                                join ur in context.RolUsuarios on u.Id equals ur.IdUsuario
                                                join r in context.Roles on ur.IdRol equals r.Id
                                                where u.Id.Equals(user.Id)
                                                orderby ur.Id
                                                orderby ur.Activo descending
                                                select new RolDTO {
                                                    Id = r.Id,
                                                    Rol = r.Rol,
                                                    Estado = (ur.Activo) ? "Activo" : "Inactivo"
                                                }
                                               ).ToListAsync();
                return ListRoles;
            }        
        }
        public static async Task<List<Role>> ListRole()
        {
            using (var context = new SeguridadInformaticaContext())
            {
                var roles = await (from r in context.Roles
                                   where r.Activo.Equals(true)
                                   select r).ToListAsync();
                return roles;
            }
        }
        public static async Task<string> AgregarRolUsuario(RolUsuario userRol)
        {
            try
            {
                using (var context = new SeguridadInformaticaContext())
                {
                    var userValidation = await context.RolUsuarios.Where(
                        a => a.IdUsuario.Equals(userRol.IdUsuario) && a.IdRol.Equals(userRol.IdRol)
                        ).FirstOrDefaultAsync();

                    if(userValidation == null) {
                        context.Add(userRol);
                        var query = await context.SaveChangesAsync();
                        var result = (query > 0) ? "Agregado Correctamente": "No se pudo agregar Registro";
                        return result;

                    }
                    return "No se pudo Insertar Registro \nEste permiso ya existe";
                }
            }
            catch(Exception ex)
            {
                return ex.InnerException.Message;
            }
        }
        public static async Task<string> RevocarPermiso(RolUsuario userRol)
        {
            try
            {
                using (var context = new SeguridadInformaticaContext())
                {
                    var userRolPermiso = await (from ur in context.RolUsuarios
                                                where ur.IdUsuario.Equals(userRol.IdUsuario)
                                                && ur.IdRol.Equals(userRol.IdRol)
                                                select ur).FirstAsync();

                    if (userRolPermiso != null && userRolPermiso.Activo.Equals(true))
                    {
                        userRolPermiso.Activo = false;
                        userRolPermiso.UsuarioActualiza = userRol.UsuarioActualiza;
                        userRolPermiso.FechaActualizacion = userRol.FechaActualizacion;
                        var query = await context.SaveChangesAsync();
                        var result = (query > 0) ? "Revocado Correctamente" : "No se pudo Revocar Permiso";
                        return result;
                    }
                    return "Este permiso ya esta revocado";
                }
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }
        public static async Task<string> HabilitarPermiso(RolUsuario userRol)
        {
            try
            {
                using (var context = new SeguridadInformaticaContext())
                {
                    var userRolPermiso = await (from ur in context.RolUsuarios
                                                where ur.IdUsuario.Equals(userRol.IdUsuario)
                                                && ur.IdRol.Equals(userRol.IdRol)
                                                select ur).FirstAsync();

                    if (userRolPermiso != null && userRolPermiso.Activo.Equals(false))
                    {
                        userRolPermiso.Activo = true;
                        userRolPermiso.UsuarioActualiza = userRol.UsuarioActualiza;
                        userRolPermiso.FechaActualizacion = userRol.FechaActualizacion;
                        var query = await context.SaveChangesAsync();
                        var result = (query > 0) ? "Habilitado Correctamente" : "No se pudo Habilitar Permiso";
                        return result;

                    }
                    return "Este permiso ya esta Habilitado";
                }
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }
    }
}
