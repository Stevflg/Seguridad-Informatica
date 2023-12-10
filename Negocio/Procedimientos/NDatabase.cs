using Datos.Proc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Procedimientos
{
    public static class NDatabase
    {
        public static void CreateDatabase()
        {
            DDatabase.CreateDatabase();
        }
        public static bool UsersAny()
        {
           return DDatabase.UsersAny();
        }
    }
}
