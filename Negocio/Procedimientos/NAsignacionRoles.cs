using Datos.Proc;
using Dominio.DTO;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Procedimientos
{
    public static class NAsignacionRoles
    {
        public static async Task<List<RolDTO>> UserRolList(Usuario user)
        {
            return await DAsignacionRoles.UserRolList(user);
        }

        public static async Task<string> AgregarRolUsuario(RolUsuario userRol)
        {
            return await DAsignacionRoles.AgregarRolUsuario(userRol);
        }

        public static async Task<string> RevocarPermiso(RolUsuario userRol)
        {
            return await DAsignacionRoles.RevocarPermiso(userRol);
        }

        public static async Task<string> HabilitarPermiso(RolUsuario userRol)
        {
            return await DAsignacionRoles.HabilitarPermiso(userRol);
        }

        public static async Task<List<Role>> ListRole()
        {
            return await DAsignacionRoles.ListRole();
        }

    }
}
