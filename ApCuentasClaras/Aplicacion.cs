using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ApCuentasClaras
{
    class Aplicacion : WindowsFormsApplicationBase
    {
        public Aplicacion()
        {
            // Asegurar que solo habrá una instancia de la aplicación. 
            // Se lanza la excepción OnStartupNextInstance.
            this.IsSingleInstance = true;
        }

        protected override void OnCreateSplashScreen()
        {
            base.OnCreateSplashScreen();
            // Pantalla de presentación
            this.SplashScreen = new PantallaDePresentacion();
            this.MinimumSplashScreenDisplayTime = 2000;
        }

        protected override void OnCreateMainForm()
        {
            base.OnCreateMainForm();
            this.MainForm = new Menus();
            // Argumentos en la línea de órdenes
            if (this.CommandLineArgs.Count > 0)
            {
                if (this.CommandLineArgs[0] == "/max" || this.CommandLineArgs[0] == "-max")
                    this.MainForm.WindowState = FormWindowState.Maximized;
            }
        }
    }
}