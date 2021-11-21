
namespace CapaPresentacion
{
    partial class Funcionalidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionalidad));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panelFunciones = new System.Windows.Forms.Panel();
            this.btnFuncionEliminar = new System.Windows.Forms.Button();
            this.submModificar = new System.Windows.Forms.Panel();
            this.btnGuardarCambiosModificar = new System.Windows.Forms.Button();
            this.btnHabilitarCamposModificar = new System.Windows.Forms.Button();
            this.btnFuncionModificar = new System.Windows.Forms.Button();
            this.submAgregar = new System.Windows.Forms.Panel();
            this.btnGuardarCambiosAgregar = new System.Windows.Forms.Button();
            this.btnHabilitarCamposAgregar = new System.Windows.Forms.Button();
            this.btnFuncionAgregar = new System.Windows.Forms.Button();
            this.panelTituloAcciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigoUniversidad = new System.Windows.Forms.TextBox();
            this.tbCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoUniversidad = new System.Windows.Forms.Label();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panelFunciones.SuspendLayout();
            this.submModificar.SuspendLayout();
            this.submAgregar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(13, 38);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(651, 345);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // panelFunciones
            // 
            this.panelFunciones.AutoScroll = true;
            this.panelFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelFunciones.Controls.Add(this.btnFuncionEliminar);
            this.panelFunciones.Controls.Add(this.submModificar);
            this.panelFunciones.Controls.Add(this.btnFuncionModificar);
            this.panelFunciones.Controls.Add(this.submAgregar);
            this.panelFunciones.Controls.Add(this.btnFuncionAgregar);
            this.panelFunciones.Controls.Add(this.panelTituloAcciones);
            this.panelFunciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFunciones.Location = new System.Drawing.Point(679, 0);
            this.panelFunciones.Name = "panelFunciones";
            this.panelFunciones.Size = new System.Drawing.Size(161, 494);
            this.panelFunciones.TabIndex = 2;
            // 
            // btnFuncionEliminar
            // 
            this.btnFuncionEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionEliminar.FlatAppearance.BorderSize = 0;
            this.btnFuncionEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnFuncionEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnFuncionEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionEliminar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFuncionEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionEliminar.Image")));
            this.btnFuncionEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionEliminar.Location = new System.Drawing.Point(0, 314);
            this.btnFuncionEliminar.Name = "btnFuncionEliminar";
            this.btnFuncionEliminar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFuncionEliminar.Size = new System.Drawing.Size(161, 46);
            this.btnFuncionEliminar.TabIndex = 6;
            this.btnFuncionEliminar.Text = "  Eliminar";
            this.btnFuncionEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionEliminar.UseVisualStyleBackColor = true;
            this.btnFuncionEliminar.Click += new System.EventHandler(this.btnFuncionEliminar_Click);
            // 
            // submModificar
            // 
            this.submModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.submModificar.Controls.Add(this.btnGuardarCambiosModificar);
            this.submModificar.Controls.Add(this.btnHabilitarCamposModificar);
            this.submModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.submModificar.Location = new System.Drawing.Point(0, 234);
            this.submModificar.Name = "submModificar";
            this.submModificar.Size = new System.Drawing.Size(161, 80);
            this.submModificar.TabIndex = 5;
            // 
            // btnGuardarCambiosModificar
            // 
            this.btnGuardarCambiosModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardarCambiosModificar.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambiosModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosModificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGuardarCambiosModificar.Location = new System.Drawing.Point(0, 40);
            this.btnGuardarCambiosModificar.Name = "btnGuardarCambiosModificar";
            this.btnGuardarCambiosModificar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGuardarCambiosModificar.Size = new System.Drawing.Size(161, 40);
            this.btnGuardarCambiosModificar.TabIndex = 1;
            this.btnGuardarCambiosModificar.Text = "Guardar cambios";
            this.btnGuardarCambiosModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambiosModificar.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosModificar.Click += new System.EventHandler(this.btnGuardarCambiosModificar_Click);
            // 
            // btnHabilitarCamposModificar
            // 
            this.btnHabilitarCamposModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHabilitarCamposModificar.FlatAppearance.BorderSize = 0;
            this.btnHabilitarCamposModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitarCamposModificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHabilitarCamposModificar.Location = new System.Drawing.Point(0, 0);
            this.btnHabilitarCamposModificar.Name = "btnHabilitarCamposModificar";
            this.btnHabilitarCamposModificar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHabilitarCamposModificar.Size = new System.Drawing.Size(161, 40);
            this.btnHabilitarCamposModificar.TabIndex = 0;
            this.btnHabilitarCamposModificar.Text = "Habilitar campos";
            this.btnHabilitarCamposModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabilitarCamposModificar.UseVisualStyleBackColor = true;
            this.btnHabilitarCamposModificar.Click += new System.EventHandler(this.btnHabilitarCamposModificar_Click);
            // 
            // btnFuncionModificar
            // 
            this.btnFuncionModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionModificar.FlatAppearance.BorderSize = 0;
            this.btnFuncionModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnFuncionModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnFuncionModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionModificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFuncionModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionModificar.Image")));
            this.btnFuncionModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionModificar.Location = new System.Drawing.Point(0, 188);
            this.btnFuncionModificar.Name = "btnFuncionModificar";
            this.btnFuncionModificar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFuncionModificar.Size = new System.Drawing.Size(161, 46);
            this.btnFuncionModificar.TabIndex = 4;
            this.btnFuncionModificar.Text = "  Modificar";
            this.btnFuncionModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionModificar.UseVisualStyleBackColor = true;
            this.btnFuncionModificar.Click += new System.EventHandler(this.btnFuncionModificar_Click);
            // 
            // submAgregar
            // 
            this.submAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.submAgregar.Controls.Add(this.btnGuardarCambiosAgregar);
            this.submAgregar.Controls.Add(this.btnHabilitarCamposAgregar);
            this.submAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.submAgregar.Location = new System.Drawing.Point(0, 108);
            this.submAgregar.Name = "submAgregar";
            this.submAgregar.Size = new System.Drawing.Size(161, 80);
            this.submAgregar.TabIndex = 3;
            // 
            // btnGuardarCambiosAgregar
            // 
            this.btnGuardarCambiosAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardarCambiosAgregar.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambiosAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGuardarCambiosAgregar.Location = new System.Drawing.Point(0, 40);
            this.btnGuardarCambiosAgregar.Name = "btnGuardarCambiosAgregar";
            this.btnGuardarCambiosAgregar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGuardarCambiosAgregar.Size = new System.Drawing.Size(161, 40);
            this.btnGuardarCambiosAgregar.TabIndex = 1;
            this.btnGuardarCambiosAgregar.Text = "Guardar cambios";
            this.btnGuardarCambiosAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambiosAgregar.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosAgregar.Click += new System.EventHandler(this.btnGuardarCambiosAgregar_Click);
            // 
            // btnHabilitarCamposAgregar
            // 
            this.btnHabilitarCamposAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHabilitarCamposAgregar.FlatAppearance.BorderSize = 0;
            this.btnHabilitarCamposAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitarCamposAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHabilitarCamposAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnHabilitarCamposAgregar.Name = "btnHabilitarCamposAgregar";
            this.btnHabilitarCamposAgregar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHabilitarCamposAgregar.Size = new System.Drawing.Size(161, 40);
            this.btnHabilitarCamposAgregar.TabIndex = 0;
            this.btnHabilitarCamposAgregar.Text = "Habilitar campos";
            this.btnHabilitarCamposAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabilitarCamposAgregar.UseVisualStyleBackColor = true;
            this.btnHabilitarCamposAgregar.Click += new System.EventHandler(this.btnHabilitarCamposAgregar_Click);
            // 
            // btnFuncionAgregar
            // 
            this.btnFuncionAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionAgregar.FlatAppearance.BorderSize = 0;
            this.btnFuncionAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnFuncionAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnFuncionAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFuncionAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionAgregar.Image")));
            this.btnFuncionAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionAgregar.Location = new System.Drawing.Point(0, 62);
            this.btnFuncionAgregar.Name = "btnFuncionAgregar";
            this.btnFuncionAgregar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFuncionAgregar.Size = new System.Drawing.Size(161, 46);
            this.btnFuncionAgregar.TabIndex = 2;
            this.btnFuncionAgregar.Text = "  Agregar";
            this.btnFuncionAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionAgregar.UseVisualStyleBackColor = true;
            this.btnFuncionAgregar.Click += new System.EventHandler(this.btnFuncionAgregar_Click);
            // 
            // panelTituloAcciones
            // 
            this.panelTituloAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAcciones.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAcciones.Name = "panelTituloAcciones";
            this.panelTituloAcciones.Size = new System.Drawing.Size(161, 62);
            this.panelTituloAcciones.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.tbNumero);
            this.panel1.Controls.Add(this.tbCarrera);
            this.panel1.Controls.Add(this.tbApellido);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.tbCodigoUniversidad);
            this.panel1.Controls.Add(this.tbCodigoAlumno);
            this.panel1.Controls.Add(this.lblNumero);
            this.panel1.Controls.Add(this.lblCarrera);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblCodigoUniversidad);
            this.panel1.Controls.Add(this.lblCodigoAlumno);
            this.panel1.Controls.Add(this.dgvDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 494);
            this.panel1.TabIndex = 4;
            // 
            // tbNumero
            // 
            this.tbNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumero.Enabled = false;
            this.tbNumero.Location = new System.Drawing.Point(548, 446);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 16);
            this.tbNumero.TabIndex = 12;
            // 
            // tbCarrera
            // 
            this.tbCarrera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCarrera.Enabled = false;
            this.tbCarrera.Location = new System.Drawing.Point(548, 417);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(100, 16);
            this.tbCarrera.TabIndex = 11;
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbApellido.Enabled = false;
            this.tbApellido.Location = new System.Drawing.Point(347, 446);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 16);
            this.tbApellido.TabIndex = 10;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(347, 417);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 16);
            this.tbNombre.TabIndex = 9;
            // 
            // tbCodigoUniversidad
            // 
            this.tbCodigoUniversidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCodigoUniversidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodigoUniversidad.Enabled = false;
            this.tbCodigoUniversidad.Location = new System.Drawing.Point(151, 446);
            this.tbCodigoUniversidad.Name = "tbCodigoUniversidad";
            this.tbCodigoUniversidad.Size = new System.Drawing.Size(100, 16);
            this.tbCodigoUniversidad.TabIndex = 8;
            // 
            // tbCodigoAlumno
            // 
            this.tbCodigoAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCodigoAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodigoAlumno.Enabled = false;
            this.tbCodigoAlumno.Location = new System.Drawing.Point(151, 417);
            this.tbCodigoAlumno.Name = "tbCodigoAlumno";
            this.tbCodigoAlumno.Size = new System.Drawing.Size(100, 16);
            this.tbCodigoAlumno.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumero.Location = new System.Drawing.Point(481, 449);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero";
            // 
            // lblCarrera
            // 
            this.lblCarrera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarrera.Location = new System.Drawing.Point(481, 420);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(45, 15);
            this.lblCarrera.TabIndex = 5;
            this.lblCarrera.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(279, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(279, 420);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigoUniversidad
            // 
            this.lblCodigoUniversidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigoUniversidad.AutoSize = true;
            this.lblCodigoUniversidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCodigoUniversidad.Location = new System.Drawing.Point(27, 449);
            this.lblCodigoUniversidad.Name = "lblCodigoUniversidad";
            this.lblCodigoUniversidad.Size = new System.Drawing.Size(111, 15);
            this.lblCodigoUniversidad.TabIndex = 2;
            this.lblCodigoUniversidad.Text = "Codigo Universidad";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(27, 420);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(92, 15);
            this.lblCodigoAlumno.TabIndex = 1;
            this.lblCodigoAlumno.Text = "Codigo Alumno";
            // 
            // Funcionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 494);
            this.Controls.Add(this.panelFunciones);
            this.Controls.Add(this.panel1);
            this.Name = "Funcionalidad";
            this.Text = "Programa";
            this.Load += new System.EventHandler(this.Funcionalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panelFunciones.ResumeLayout(false);
            this.submModificar.ResumeLayout(false);
            this.submAgregar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel panelFunciones;
        private System.Windows.Forms.Button btnFuncionAgregar;
        private System.Windows.Forms.Panel panelTituloAcciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel submAgregar;
        private System.Windows.Forms.Panel submModificar;
        private System.Windows.Forms.Button btnGuardarCambiosModificar;
        private System.Windows.Forms.Button btnHabilitarCamposModificar;
        private System.Windows.Forms.Button btnFuncionModificar;
        private System.Windows.Forms.Button btnGuardarCambiosAgregar;
        private System.Windows.Forms.Button btnHabilitarCamposAgregar;
        private System.Windows.Forms.Button btnFuncionEliminar;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoUniversidad;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigoUniversidad;
        private System.Windows.Forms.TextBox tbCodigoAlumno;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCarrera;
    }
}