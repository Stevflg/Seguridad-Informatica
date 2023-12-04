using Datos.Context;
using Datos.Proc;
using Dominio.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Procedimientos
{
    public static class NInicioSesion
    {
        public static async Task<bool> Login(Usuario user)
        {
           return await DInicioSesion.Login(user);
        }

        public static async Task<Usuario> GetUsuario(Usuario user)
        {
           return await DInicioSesion.GetUsuario(user);
        }

    }
}
