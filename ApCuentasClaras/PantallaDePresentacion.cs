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
    public partial class PantallaDePresentacion : Form
    {
        public PantallaDePresentacion()
        {
            InitializeComponent();
            ConfigurarSplash();
        }

        private void ConfigurarSplash()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
