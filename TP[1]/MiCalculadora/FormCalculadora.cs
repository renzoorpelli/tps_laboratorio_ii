using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Se encarga de cargar los operadores y setear como index el primer elemento 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add(" ");
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");
            cmbOperador.SelectedIndex = 0;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;


        }
        /// <summary>
        /// se encarga de cerrar la aplicación a traves del boton asignado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///     se encarga de preguntarle al usurio si esta seguro de salir 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de querer salir??", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// se encarga de borrar todos los elementos de la pantalla 
        /// </summary>
        public void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = 0;
            //lstOperaciones.Items.Clear();
            lblResultado.Text = "0";
        }
        /// <summary>
        /// se encarga de preguntarle al usurio si desea borrar todo y si apreta "si" llama a la función borrar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        ///  esta función crea dos operando y se la pasa a la función Operar de Calculadora encargada de hacer la operación matemática
        /// </summary>
        /// <param name="numero1">primer numero</param>
        /// <param name="numero2">segundo numero</param>
        /// <param name="operador">el operador</param>
        /// <returns>retorna el resultado de la operación</returns>
        public static double Operar(string numero1, string numero2, string operador)
        {
            Operando numeroUno = new Operando(numero1);
            Operando numeroDos = new Operando(numero2);
            double resultado = Calculadora.Operar(numeroUno, numeroDos, Convert.ToChar(operador));
            return resultado;
        }
        /// <summary>
        /// esta función se encarga de informar al usurio si le faltó ingresar alguno de los dos numeros y de ser correcto mostrar el resultado y agregara la operación realizada en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero1.Text) || string.IsNullOrEmpty(txtNumero2.Text))
            {
                MessageBox.Show("Por favor ingrese un numero", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
                if (cmbOperador.SelectedIndex == 0)
                {
                    cmbOperador.SelectedIndex = 1;
                }
                lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
                
            }
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;//false
        }
        /// <summary>
        /// esta función se encarga de convertir a binario el numero decimal del resultado de la operación realizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            lblResultado.Text = resultado.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        /// <summary>
        /// esta función se encarga de convertir a decimal el numero binario de la operacion realizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }
    }
}
