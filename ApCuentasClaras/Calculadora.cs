using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Calculadora : Form
    {
        private enum Entrada
        {
            NINGUNA,
            DIGITO,
            OPERADOR,
            CE
        }
        private Entrada ultimaEntrada;
        private bool comaDecimal;
        private char operador;
        private byte numOperandos;
        private double operando1;
        private double operando2;

        public Calculadora()
        {
            InitializeComponent();
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0';
            numOperandos = 0;
            operando1 = 0;
            operando2 = 0;
        }

        private void bt_Digito_click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;

            if (ultimaEntrada != Entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaEntrada = Entrada.DIGITO;
            }
            etPantalla.Text += objButton.Text;
        }

        private void btComaDec_Click(object sender, System.EventArgs e)
        {
            if (ultimaEntrada != Entrada.DIGITO)
            {
                etPantalla.Text = "0,";
                ultimaEntrada = Entrada.DIGITO;
            }
            else if (comaDecimal == false)
                etPantalla.Text = etPantalla.Text + ",";
            comaDecimal = true;
        }

        private void btOperacion_Click(object sender, System.EventArgs e)
        {
            //Obtener el id del boton que genero el evento
            Button objButton = (Button)sender;
            //Obtener el texto del boton puslado
            string textoBoton = objButton.Text;

            if ((numOperandos == 0) && (textoBoton[0] == '-'))
                ultimaEntrada = Entrada.DIGITO;
            if (ultimaEntrada == Entrada.DIGITO)
                numOperandos += 1;
            if (numOperandos == 1)
                operando1 = double.Parse(etPantalla.Text);
            else if (numOperandos == 2)
            {
                operando2 = double.Parse(etPantalla.Text);
                switch (operador)
                {
                    case '+':
                        operando1 += operando2;
                        break;
                    case '-':
                        operando1 -= operando2;
                        break;
                    case 'X':
                        operando1 *= operando2;
                        break;
                    case'/':
                        operando1 /= operando2;
                        break;
                    case '=':
                        operando1 = operando2;
                        break;
                }
                //Visualizar el resultado
                etPantalla.Text = operando1.ToString();
                numOperandos = 1;
            }
            operador = textoBoton[0]; //caracter de la posicion 0
            ultimaEntrada = Entrada.OPERADOR;
        }

        private void btTantoPorCiento_Click(object sender, System.EventArgs e)
        {
            double resultado;
            if (ultimaEntrada == Entrada.DIGITO)
            {
                resultado = operando1 * double.Parse(etPantalla.Text) / 100;
                //visualiar el resultado
                etPantalla.Text = resultado.ToString();
                //simular que se ha hecho clic en "="
                btIgual.PerformClick();
                //enfocar la tecla %
                btTantoPorCiento.Focus();
            }
        }

        private void btIniciar_Click(object sender, System.EventArgs e)
        {
            etPantalla.Text = "0,";
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0';
            numOperandos = 0;
            operando1 = 0;
            operando2 = 0;
        }

        private void btBorrarEntrada_Click(object sender, System.EventArgs e)
        {
            etPantalla.Text = "0";
            ultimaEntrada = Entrada.CE;
            comaDecimal = false;
        }


    }
}
