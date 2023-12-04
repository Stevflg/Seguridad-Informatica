using Datos.Context;
using Datos.Proc;
using Dominio.DTO;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Procedimientos
{
    public static class NUsuarios 
    {
        public static async Task<string> Create(Usuario user)
        {
           return await DUsuarios.Create(user);
        }

        public static async Task<string> Update(Usuario user)
        {
           return await DUsuarios.Update(user);
        }

        public static async Task<string> Delete(Usuario user)
        {
           return await DUsuarios.Delete(user);
        }

        public static async Task<List<UsuarioDTO>> GetListUsuarios()
        {
            return await DUsuarios.GetListUsuarios();
        }

        public static async Task<List<UsuarioDTO>> SearchUsuarios(Usuario user)
        {
            return await DUsuarios.SearchUsuarios(user);
        }

        public static async Task<Usuario> GetUsarioId(Usuario user)
        {
           return await DUsuarios.GetUsarioId(user);
        }
    }
}