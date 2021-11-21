using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Presentacion : Form
    {
        private CNElemento elemento = new CNElemento();
        public Presentacion()
        {
            InitializeComponent();
        }

        // Permitir arrastre de formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Quitar el parpadeo en controles de WForms
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
        }

        private Form formularioActivo = null;
        private void abrirFormularioFuncionalidad(Form funcionalidad)
        {
            if(formularioActivo!= null)
            formularioActivo.Close();

            formularioActivo = funcionalidad;
            funcionalidad.TopLevel = false;
            funcionalidad.FormBorderStyle = FormBorderStyle.None;
            funcionalidad.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(funcionalidad);
            panelContenedor.Tag = funcionalidad;
            funcionalidad.BringToFront(); //funcion por si tenemos un logo en panel contenedor
            funcionalidad.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioFuncionalidad(new Funcionalidad());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
        }
    }
}
