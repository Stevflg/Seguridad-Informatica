using Datos.Context;
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
            var context = new SeguridadInformaticaContext();
            context.Database.EnsureCreated();
            if(context.Usuarios.FirstOrDefault() == null) { Registrar fr = new Registrar(); fr.ShowDialog(); }
            Application.Run(new Inicio_Sesion());
        }
    }
}