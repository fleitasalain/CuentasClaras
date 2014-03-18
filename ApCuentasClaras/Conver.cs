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
   public partial class Conver : Form
    {
        private TextBox objTextBox = null;

        public Conver()
        {
            InitializeComponent();
        }
        private void tbGradosC_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
        }

        private void tbGradosF_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                //Si se escribio en la caja de texto grados Centigrados...
                if (objTextBox == tbGradosC)
                {
                    grados = Convert.ToDouble(tbGradosC.Text) * 9.0 / 5.0 + 32.0;
                    //Mostrar el resultado redondeado a dos decimales
                    tbGradosF.Text = string.Format("{0:F2}", grados);
                }
                //Si se escribio en la caja de texto grados Fahrenheit...
                if (objTextBox == tbGradosF)
                {
                    grados = (Convert.ToDouble(tbGradosF.Text) - 32.0) * 5.0 / 9.0;
                    //Mostrar el resultado redondeado a dos decimales
                    tbGradosC.Text = string.Format("{0:F2}", grados);
                }
            }
            catch (FormatException)
            {
                tbGradosC.Text = "0.00";
                tbGradosF.Text = "32.00";
            }
        }

       /* private void Form1_Load(object sender, EventArgs e)
        {
            //this.Visible = true;
            //tbGradosC.Focus();
            //tbGradosF.Focus();
        }*/

        private void Form1_Show(object sender, EventArgs e)
        {
            tbGradosC.Focus();
        }
        private void CajaTexto_Enter(object sender, EventArgs e)
        {
            TextBox ObjTextBox = (TextBox)sender;
            ObjTextBox.SelectAll();
        }
        private void CajaTexto_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox ObjTextBox = (TextBox)sender;
            ObjTextBox.SelectAll();
        }
    }
}