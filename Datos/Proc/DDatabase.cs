using Datos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Proc
{
    public static class DDatabase
    {
        public static void CreateDatabase()
        {
            using (var context  = new SeguridadInformaticaContext())
            {
                context.Database.EnsureCreated();
            }
        }
        public static bool UsersAny()
        {
            using (var context = new SeguridadInformaticaContext())
            {
                return context.Usuarios.Any();
            }
        }
    }
}
