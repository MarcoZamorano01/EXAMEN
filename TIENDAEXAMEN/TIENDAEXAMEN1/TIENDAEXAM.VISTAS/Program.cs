namespace TIENDAEXAM.VISTAS
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
            //Application.Run(new Form1());
            //listar
            //Application.Run(new PersonaVistas.PersonaListarVisa());
            //Application.Run(new EmpleadoVistas.EmpleadoListarVista());
            //insertar
            Application.Run(new EmpleadoVistas.EmpleadoInsertarVista());
        }
    }
}