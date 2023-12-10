using Datos.Context;
using Negocio.Inicial;
using Negocio.Procedimientos;
using Seguridad_Informatica.Forms;

namespace Seguridad_Informatica
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            NDatabase.CreateDatabase();
            var ld = new LoadData();
            ld.InsertData();
            if(!NDatabase.UsersAny()) { Registrar fr = new Registrar(); fr.ShowDialog(); }
            Application.Run(new Inicio_Sesion());
        }
    }
}