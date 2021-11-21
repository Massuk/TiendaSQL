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

using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Funcionalidad : Form
    {
        private CNElemento elementos = new CNElemento();
        public Funcionalidad()
        {
            InitializeComponent();
        }

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

        private void Funcionalidad_Load(object sender, EventArgs e)
        {
            subMenusOcultosAlIniciar();
            mostrarDataGrid();
        }

        public void mostrarDataGrid()
        {
            dgvDatos.DataSource = elementos.mostrarTabla();
        }

        // Agregar Datos al DGV

        private void subMenusOcultosAlIniciar()
        {
            submAgregar.Visible = false;
            submModificar.Visible = false;
        }

        private void ocultarSubMenus()
        {
            if (submAgregar.Visible == true)
                submAgregar.Visible = false;
            if (submModificar.Visible == true)
                submModificar.Visible = false;
        }

        private void mostrarSubMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnFuncionAgregar_Click(object sender, EventArgs e)
        {
            mostrarSubMenus(submAgregar);
        }

        private void btnFuncionModificar_Click(object sender, EventArgs e)
        {
            mostrarSubMenus(submModificar);
        }

        private void btnHabilitarCamposAgregar_Click(object sender, EventArgs e)
        {
            habilitarTB();
            limpiarTB();
            btnGuardarCambiosAgregar.Enabled = true;
        }

        private void limpiarTB()
        {
            tbCodigoAlumno.Text = "";
            tbCodigoUniversidad.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbCarrera.Text = "";
            tbNumero.Text = "";
        }

        private void deshabilitarTB()
        {
            tbCodigoAlumno.Enabled = false;
            tbCodigoUniversidad.Enabled = false;
            tbNombre.Enabled = false;
            tbApellido.Enabled = false;
            tbCarrera.Enabled = false;
            tbNumero.Enabled = false;
        }

        private void btnGuardarCambiosAgregar_Click(object sender, EventArgs e)
        {
            if (tbCodigoAlumno.TextLength > 0 &&
                tbCodigoUniversidad.TextLength > 0 &&
                tbNombre.TextLength > 0 &&
                tbApellido.TextLength > 0 &&
                tbCarrera.TextLength > 0 &&
                tbNumero.TextLength > 0)
            {
                CNElemento agregar = new CNElemento();
                CEElemento elm = new CEElemento();

                elm.CodigoAlumno = tbCodigoAlumno.Text;
                elm.CodigoUniversidad = Convert.ToInt32(tbCodigoUniversidad.Text);
                elm.Nombre = tbNombre.Text;
                elm.Apellido = tbApellido.Text;
                elm.Carrera = tbCarrera.Text;
                elm.Numero = Convert.ToInt32(tbNumero.Text);

                agregar.agregarDato(elm);
                MessageBox.Show("Dato agregado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar el nuevo dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mostrarDataGrid();
            deshabilitarTB();
            ocultarSubMenus();
            btnGuardarCambiosAgregar.Enabled = false;
        }

        private void habilitarTB()
        {
            tbCodigoAlumno.Enabled = true;
            tbCodigoUniversidad.Enabled = true;
            tbNombre.Enabled = true;
            tbApellido.Enabled = true;
            tbCarrera.Enabled = true;
            tbNumero.Enabled = true;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnFuncionEliminar.Enabled = true;

            string codigoalumno = dgvDatos.CurrentRow.Cells[0].Value.ToString();
            int codigouniversidad = Convert.ToInt32(dgvDatos.CurrentRow.Cells[1].Value.ToString());
            string nombre = dgvDatos.CurrentRow.Cells[2].Value.ToString();
            string apellido = dgvDatos.CurrentRow.Cells[3].Value.ToString();
            string carrera = dgvDatos.CurrentRow.Cells[4].Value.ToString();
            int numero = Convert.ToInt32(dgvDatos.CurrentRow.Cells[5].Value.ToString());

            CNElemento objeto = new CNElemento();
            CEElemento element = new CEElemento();
            element = objeto.leerDato(codigoalumno);

            tbCodigoAlumno.Text = codigoalumno.ToString();
            tbCodigoUniversidad.Text = codigouniversidad.ToString();
            tbNombre.Text = nombre.ToString();
            tbApellido.Text = apellido.ToString();
            tbCarrera.Text = carrera.ToString();
            tbNumero.Text = numero.ToString();
        }

        private void btnHabilitarCamposModificar_Click(object sender, EventArgs e)
        {
            habilitarTB();
            tbCodigoAlumno.Enabled = false;
            btnGuardarCambiosModificar.Enabled = true;
        }

        private void btnGuardarCambiosModificar_Click(object sender, EventArgs e)
        {
            if (tbCodigoAlumno.TextLength > 0 &&
                tbCodigoUniversidad.TextLength > 0 &&
                tbNombre.TextLength > 0 &&
                tbApellido.TextLength > 0 &&
                tbCarrera.TextLength > 0 &&
                tbNumero.TextLength > 0)
            {
                CNElemento modificar = new CNElemento();
                CEElemento elm = new CEElemento();

                elm.CodigoAlumno = tbCodigoAlumno.Text;
                elm.CodigoUniversidad = Convert.ToInt32(tbCodigoUniversidad.Text);
                elm.Nombre = tbNombre.Text;
                elm.Apellido = tbApellido.Text;
                elm.Carrera = tbCarrera.Text;
                elm.Numero = Convert.ToInt32(tbNumero.Text);

                modificar.modificarDato(elm);
                MessageBox.Show("Dato modificado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo modificar el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mostrarDataGrid();
            deshabilitarTB();
            ocultarSubMenus();
            btnGuardarCambiosModificar.Enabled = false;
        }

        private void btnFuncionEliminar_Click(object sender, EventArgs e)
        {
            ocultarSubMenus();
            CEElemento elm = new CEElemento();
            elm.CodigoAlumno = dgvDatos.CurrentRow.Cells[0].Value.ToString();
            if (elementos.eliminarDato(elm))
            {
                MessageBox.Show("Se eliminó la información correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se eliminó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mostrarDataGrid();
        }
    }
}
