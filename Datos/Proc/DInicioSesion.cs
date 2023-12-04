using Datos.Context;
using Dominio.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Proc
{
    public static class DInicioSesion
    {
        public static async Task<bool> Login(Usuario user)
        {
            try
            {
                using (var context = new SeguridadInformaticaContext())
                {
                    var usuario = await (from u in context.Usuarios
                                         where u.Correo.Equals(user.Correo)
                                         && u.Activo.Equals(true) && u.Bloqueado.Equals(false)
                                         select u).FirstAsync();
                    if (usuario != null)
                    {
                        if (DEncrypt.EncryptUser(user.Correo).SequenceEqual(DEncrypt.EncryptUser(user.Correo)))
                        {
                            var result = (usuario.Password.SequenceEqual(user.Password)) ? true : false;
                            if (!result)
                            {
                                usuario.Contador += 1;
                                usuario.Bloqueado = (usuario.Contador > 2) ? true : false;
                                context.Entry(usuario).State = EntityState.Modified;
                                await context.SaveChangesAsync();
                                return result;
                            }
                            return result;
                        }
                        else
                        {
                            usuario.Contador += 1;
                            usuario.Bloqueado = (usuario.Contador > 2) ? true : false;
                            context.Entry(usuario).State = EntityState.Modified;
                            await context.SaveChangesAsync();
                            return false;
                        }
                    }
                    return false;
                }
            }catch (Exception ex)
            {
                return false;
            }
        }
        public static async Task<Usuario> GetUsuario(Usuario user)
        {
            try
            {
               using(var context = new SeguridadInformaticaContext())
                {
                    var usuario = await (from u in context.Usuarios
                                         where u.Correo.Equals(user.Correo) && u.Activo.Equals(true)
                                         select u).FirstOrDefaultAsync();
                    var result = (usuario != null) ? usuario : null;
                    return result;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

    }
}
