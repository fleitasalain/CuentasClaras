using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApCuentasClaras
{
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void menuArchivoSalir_Click(object sender, EventArgs e)
        {
            Close();    //Cerrara el Formulario
        }

        private void menuArchivoAbrir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Archivo > Abrir");
        }

        private void menuArchivoGuardarMismoNombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Archivo > Guardar Mismo Nombre");
        }

        private void menuArchivoGuardarOtroNombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Archivo > Guardar Otro Nombre");
        }

        private void ArchivoSalir_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Cierrala la aplicacion";
        }

        private void OrdenMenu_MouseLeave(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Listo";
        }

        private void ArchivoAbrir_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Abre un fichero";
        }
        private void ArchivoGuardar_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Guarda un fichero";
        }

        private void ArchivoGuardarMismoNombre_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Guarda un fichero con el mismo nombre";
        }

        private void ArchivoGuardarOtroNombre_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Guarda un fichero con otro nombre";
        }

        private void HerrCalculadora_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Calculadora";
        }
        private void HerrConver_MouseEnter(object sender, EventArgs e)
        {
            etbarestPpal.Text = "Convertidor";
        }
    }
}
