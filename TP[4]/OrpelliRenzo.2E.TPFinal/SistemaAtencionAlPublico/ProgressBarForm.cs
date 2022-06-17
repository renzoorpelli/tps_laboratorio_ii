using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SistemaAtencionAlPublico
{
    
    public delegate void CargarBarraEventHandler(int porcentaje);
    public delegate void BarraCargada();
    public partial class ProgressBarForm : Form
    {
        public event CargarBarraEventHandler cargarBarra;
        public event BarraCargada barraCargada;
       
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        public ProgressBarForm()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
        }

        /// <summary>
        /// en el evento load del form se asociaran los eventos cargarBarra y Barra cargada a los metodos  CargandoBarra y FinCargaBarra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            cargarBarra += CargandoBarra;
            barraCargada += FinCargaBarra;
            Task hilo = new Task(IniciarCargaBarra, cancellationToken);
            hilo.Start();

        }

        /// <summary>
        /// metodo encargado de asignar un porcentaje a la propiedad value de la progressbar, al ser una tarea ejecutada en un hilo secundario
        /// se llamara a la priopiedad invokeRequired para poder ejercer cambios a un control del form desde un hilo secundario
        /// </summary>
        /// <param name="porcentajeCarga"></param>
        private void CargandoBarra(int porcentajeCarga)
        {
            if (this.InvokeRequired)
            {
                object[] args = { porcentajeCarga };
                this.BeginInvoke(cargarBarra, args);
            }
            else
            {
                this.progressBar1.Value = porcentajeCarga;
            }
        }

        /// <summary>
        /// metodo encargado de simular el estado de porcentaje completado de la progressbar
        /// sera el encargado de llaamar a los eventos cargarBarra y barra cargada
        /// </summary>
        private void IniciarCargaBarra()
        {
            int barraCompleta = 0;
            while(barraCompleta < 100)
            {
                barraCompleta += 10;
                if(this.cargarBarra is not null)
                {
                    this.cargarBarra.Invoke(barraCompleta);
                    Thread.Sleep(200);
                }
            }
            if(barraCargada is not null)
            {
                barraCargada.Invoke();
            }
            
        }
        /// <summary>
        /// metodo encargado de controlar el estado de la barra, esta tarea al estar siendo ejecutada en un hilo secundario
        /// se llamara a la propiedad InvokeRequired par que pueda ser ejecutada desde otro hilo y despues si la barra se 
        /// cargo correctamente llamara al metodo close que cancelara el hilo
        /// </summary>
        private void FinCargaBarra()
        {
            if(this.InvokeRequired)
            {
                this.BeginInvoke(barraCargada);
            }
            else
            {
                if (progressBar1.Value == 100)
                {
                    this.Close();
                }
            }
            
        }

        //metodo encargado de cancelar el hilo
        private void ProgressBarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }


    }
}
