using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAtencionAlPublico
{
    public partial class FormWhiteHatCS : Form
    {
        public FormWhiteHatCS()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormWhiteHatCS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }


        private void btnAdministracionClientes_Click(object sender, EventArgs e)
        {
            FrmAdministracionClientes frmAdministracion = new FrmAdministracionClientes();
            frmAdministracion.ShowDialog();
        }

        private void btnListadoClientes_Click(object sender, EventArgs e)
        {
            FrmAdministracionClientes frmAdministracion = new FrmAdministracionClientes();
            frmAdministracion.ShowDialog();
        }
    }
}
