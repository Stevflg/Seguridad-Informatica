using Datos.Context;
using Datos.Proc;
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

namespace Negocio.Procedimientos
{
    public static class NPermisos
    {
        public static async Task<List<PermisosDTO>> GetPermisos(Usuario user)
        {
           return await DPermisos.GetPermisos(user);
        }

        public static async Task<List<Usuario>> UsuariosList()
        {
            return await DPermisos.UsuariosList();
        }

        public static async Task<List<Role>> RolesList()
        {
            return await DPermisos.RolesList();
        }

        public static async Task<string> AgregarPermiso(RolUsuario permiso)
        {
            return await DPermisos.AgregarPermiso(permiso);
        }

        public static async Task<string> Eliminar(PermisosDTO obj,Usuario user)
        {
            return await DPermisos.Eliminar(obj,user);
        }

    }
}
