namespace Biblioteca_UPN
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.picLogoUPN = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.tabContenido = new System.Windows.Forms.TabControl();
            this.tabEstudiantes = new System.Windows.Forms.TabPage();
            this.cboEstadoMatricula = new System.Windows.Forms.ComboBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.btnMostrarEstudiantes = new System.Windows.Forms.Button();
            this.btnRegistrarEstudiante = new System.Windows.Forms.Button();
            this.txtApellidosEstudiante = new System.Windows.Forms.TextBox();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtCodigoEstudiante = new System.Windows.Forms.TextBox();
            this.lblEstadoMatricula = new System.Windows.Forms.Label();
            this.lblApellidosEstudiante = new System.Windows.Forms.Label();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.lblCodigoEstudiante = new System.Windows.Forms.Label();
            this.lblTituloEstudiantes = new System.Windows.Forms.Label();
            this.tabLibros = new System.Windows.Forms.TabPage();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.colCodigoLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAreaLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoULLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnMostrarLibros = new System.Windows.Forms.Button();
            this.btnRegistrarLibro = new System.Windows.Forms.Button();
            this.txtCodigoUL = new System.Windows.Forms.TextBox();
            this.txtAreaLibro = new System.Windows.Forms.TextBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtCodigoLibro = new System.Windows.Forms.TextBox();
            this.lblCodigoUL = new System.Windows.Forms.Label();
            this.lblAreaLibro = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblCodigoLibro = new System.Windows.Forms.Label();
            this.lblTituloLibros = new System.Windows.Forms.Label();
            this.tabPrestamos = new System.Windows.Forms.TabPage();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.colCodigoEstudiante_Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoUL_Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado_Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloPrestamos = new System.Windows.Forms.Label();
            this.btnMostrarPrestamos = new System.Windows.Forms.Button();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.txtCodigoULPrestamo = new System.Windows.Forms.TextBox();
            this.txtCodigoEstudiantePrestamo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConsultas = new System.Windows.Forms.TabPage();
            this.lblResultadoConsulta = new System.Windows.Forms.Label();
            this.txtResultadoConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultarLibro = new System.Windows.Forms.Button();
            this.btnConsultarEstudiante = new System.Windows.Forms.Button();
            this.txtConsultaUL = new System.Windows.Forms.TextBox();
            this.lblCodigoULConsulta = new System.Windows.Forms.Label();
            this.txtConsultaEstudiante = new System.Windows.Forms.TextBox();
            this.lblCodigoEstudianteConsulta = new System.Windows.Forms.Label();
            this.lblTituloConsultas = new System.Windows.Forms.Label();
            this.tabDevoluciones = new System.Windows.Forms.TabPage();
            this.txtResultadoDevolucion = new System.Windows.Forms.TextBox();
            this.lblResultadoDevolucion = new System.Windows.Forms.Label();
            this.btnRegistrarDevolucion = new System.Windows.Forms.Button();
            this.txtCodigoULDevolucion = new System.Windows.Forms.TextBox();
            this.lblCodigoULDevolucion = new System.Windows.Forms.Label();
            this.lblTituloDevoluciones = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colCodigoEstudiantePrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoULPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnOrdenarBurbuja = new System.Windows.Forms.Button();
            this.btnOrdenarSeleccion = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoUPN)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.tabContenido.SuspendLayout();
            this.tabEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.tabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tabPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.tabConsultas.SuspendLayout();
            this.tabDevoluciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(25)))));
            this.pnlEncabezado.Controls.Add(this.picLogoUPN);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(25)))));
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(784, 75);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // picLogoUPN
            // 
            this.picLogoUPN.Image = ((System.Drawing.Image)(resources.GetObject("picLogoUPN.Image")));
            this.picLogoUPN.Location = new System.Drawing.Point(0, -12);
            this.picLogoUPN.Name = "picLogoUPN";
            this.picLogoUPN.Size = new System.Drawing.Size(123, 102);
            this.picLogoUPN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoUPN.TabIndex = 1;
            this.picLogoUPN.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(145, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(457, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SISTEMA DE PRÉSTAMOS DE LA BIBLIOTECA ";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.btnDevoluciones);
            this.pnlMenu.Controls.Add(this.btnConsultas);
            this.pnlMenu.Controls.Add(this.btnPrestamos);
            this.pnlMenu.Controls.Add(this.btnLibros);
            this.pnlMenu.Controls.Add(this.btnEstudiantes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 75);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(123, 486);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.BackColor = System.Drawing.Color.Transparent;
            this.btnDevoluciones.FlatAppearance.BorderSize = 0;
            this.btnDevoluciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(25)))));
            this.btnDevoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluciones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnDevoluciones.Location = new System.Drawing.Point(0, 196);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(123, 50);
            this.btnDevoluciones.TabIndex = 4;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.UseVisualStyleBackColor = false;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(25)))));
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(0, 147);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(123, 50);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(25)))));
            this.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnPrestamos.Location = new System.Drawing.Point(0, 98);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(123, 50);
            this.btnPrestamos.TabIndex = 2;
            this.btnPrestamos.Text = "Préstamos";
            this.btnPrestamos.UseVisualStyleBackColor = false;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.Color.Transparent;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(25)))));
            this.btnLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.Color.White;
            this.btnLibros.Location = new System.Drawing.Point(0, 49);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(123, 50);
            this.btnLibros.TabIndex = 1;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = false;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnEstudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(25)))));
            this.btnEstudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(123, 50);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // tabContenido
            // 
            this.tabContenido.Controls.Add(this.tabEstudiantes);
            this.tabContenido.Controls.Add(this.tabLibros);
            this.tabContenido.Controls.Add(this.tabPrestamos);
            this.tabContenido.Controls.Add(this.tabConsultas);
            this.tabContenido.Controls.Add(this.tabDevoluciones);
            this.tabContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContenido.Location = new System.Drawing.Point(123, 75);
            this.tabContenido.Name = "tabContenido";
            this.tabContenido.SelectedIndex = 0;
            this.tabContenido.Size = new System.Drawing.Size(661, 486);
            this.tabContenido.TabIndex = 2;
            // 
            // tabEstudiantes
            // 
            this.tabEstudiantes.Controls.Add(this.btnOrdenarSeleccion);
            this.tabEstudiantes.Controls.Add(this.btnOrdenarBurbuja);
            this.tabEstudiantes.Controls.Add(this.btnEliminarEstudiante);
            this.tabEstudiantes.Controls.Add(this.cboEstadoMatricula);
            this.tabEstudiantes.Controls.Add(this.dgvEstudiantes);
            this.tabEstudiantes.Controls.Add(this.btnBuscarEstudiante);
            this.tabEstudiantes.Controls.Add(this.btnMostrarEstudiantes);
            this.tabEstudiantes.Controls.Add(this.btnRegistrarEstudiante);
            this.tabEstudiantes.Controls.Add(this.txtApellidosEstudiante);
            this.tabEstudiantes.Controls.Add(this.txtNombreEstudiante);
            this.tabEstudiantes.Controls.Add(this.txtCodigoEstudiante);
            this.tabEstudiantes.Controls.Add(this.lblEstadoMatricula);
            this.tabEstudiantes.Controls.Add(this.lblApellidosEstudiante);
            this.tabEstudiantes.Controls.Add(this.lblNombreEstudiante);
            this.tabEstudiantes.Controls.Add(this.lblCodigoEstudiante);
            this.tabEstudiantes.Controls.Add(this.lblTituloEstudiantes);
            this.tabEstudiantes.Location = new System.Drawing.Point(4, 22);
            this.tabEstudiantes.Name = "tabEstudiantes";
            this.tabEstudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstudiantes.Size = new System.Drawing.Size(653, 460);
            this.tabEstudiantes.TabIndex = 0;
            this.tabEstudiantes.Text = "Estudiantes";
            this.tabEstudiantes.UseVisualStyleBackColor = true;
            // 
            // cboEstadoMatricula
            // 
            this.cboEstadoMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoMatricula.FormattingEnabled = true;
            this.cboEstadoMatricula.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cboEstadoMatricula.Location = new System.Drawing.Point(148, 163);
            this.cboEstadoMatricula.Name = "cboEstadoMatricula";
            this.cboEstadoMatricula.Size = new System.Drawing.Size(471, 21);
            this.cboEstadoMatricula.TabIndex = 13;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colApellidos,
            this.colEstadoMatricula});
            this.dgvEstudiantes.Location = new System.Drawing.Point(20, 292);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(599, 150);
            this.dgvEstudiantes.TabIndex = 12;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombres";
            this.colNombre.Name = "colNombre";
            // 
            // colApellidos
            // 
            this.colApellidos.HeaderText = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            // 
            // colEstadoMatricula
            // 
            this.colEstadoMatricula.HeaderText = "Estado de matrícula";
            this.colEstadoMatricula.Name = "colEstadoMatricula";
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.BackColor = System.Drawing.Color.OliveDrab;
            this.btnBuscarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(338, 205);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(124, 33);
            this.btnBuscarEstudiante.TabIndex = 11;
            this.btnBuscarEstudiante.Text = "Buscar";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = false;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // btnMostrarEstudiantes
            // 
            this.btnMostrarEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMostrarEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnMostrarEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarEstudiantes.Location = new System.Drawing.Point(178, 205);
            this.btnMostrarEstudiantes.Name = "btnMostrarEstudiantes";
            this.btnMostrarEstudiantes.Size = new System.Drawing.Size(124, 33);
            this.btnMostrarEstudiantes.TabIndex = 10;
            this.btnMostrarEstudiantes.Text = "Mostrar estudiantes";
            this.btnMostrarEstudiantes.UseVisualStyleBackColor = false;
            this.btnMostrarEstudiantes.Click += new System.EventHandler(this.btnMostrarEstudiantes_Click);
            // 
            // btnRegistrarEstudiante
            // 
            this.btnRegistrarEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btnRegistrarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEstudiante.Location = new System.Drawing.Point(23, 205);
            this.btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            this.btnRegistrarEstudiante.Size = new System.Drawing.Size(124, 33);
            this.btnRegistrarEstudiante.TabIndex = 9;
            this.btnRegistrarEstudiante.Text = "Registrar";
            this.btnRegistrarEstudiante.UseVisualStyleBackColor = false;
            this.btnRegistrarEstudiante.Click += new System.EventHandler(this.btnRegistrarEstudiante_Click);
            // 
            // txtApellidosEstudiante
            // 
            this.txtApellidosEstudiante.Location = new System.Drawing.Point(148, 126);
            this.txtApellidosEstudiante.Name = "txtApellidosEstudiante";
            this.txtApellidosEstudiante.Size = new System.Drawing.Size(471, 20);
            this.txtApellidosEstudiante.TabIndex = 7;
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(148, 88);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(471, 20);
            this.txtNombreEstudiante.TabIndex = 6;
            // 
            // txtCodigoEstudiante
            // 
            this.txtCodigoEstudiante.Location = new System.Drawing.Point(148, 54);
            this.txtCodigoEstudiante.Name = "txtCodigoEstudiante";
            this.txtCodigoEstudiante.Size = new System.Drawing.Size(471, 20);
            this.txtCodigoEstudiante.TabIndex = 5;
            // 
            // lblEstadoMatricula
            // 
            this.lblEstadoMatricula.AutoSize = true;
            this.lblEstadoMatricula.Location = new System.Drawing.Point(20, 166);
            this.lblEstadoMatricula.Name = "lblEstadoMatricula";
            this.lblEstadoMatricula.Size = new System.Drawing.Size(105, 13);
            this.lblEstadoMatricula.TabIndex = 4;
            this.lblEstadoMatricula.Text = "Estado de matrícula:";
            // 
            // lblApellidosEstudiante
            // 
            this.lblApellidosEstudiante.AutoSize = true;
            this.lblApellidosEstudiante.Location = new System.Drawing.Point(20, 129);
            this.lblApellidosEstudiante.Name = "lblApellidosEstudiante";
            this.lblApellidosEstudiante.Size = new System.Drawing.Size(52, 13);
            this.lblApellidosEstudiante.TabIndex = 3;
            this.lblApellidosEstudiante.Text = "Apellidos:";
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.Location = new System.Drawing.Point(20, 91);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(52, 13);
            this.lblNombreEstudiante.TabIndex = 2;
            this.lblNombreEstudiante.Text = "Nombres:";
            // 
            // lblCodigoEstudiante
            // 
            this.lblCodigoEstudiante.AutoSize = true;
            this.lblCodigoEstudiante.Location = new System.Drawing.Point(20, 57);
            this.lblCodigoEstudiante.Name = "lblCodigoEstudiante";
            this.lblCodigoEstudiante.Size = new System.Drawing.Size(112, 13);
            this.lblCodigoEstudiante.TabIndex = 1;
            this.lblCodigoEstudiante.Text = "Código del estudiante:";
            // 
            // lblTituloEstudiantes
            // 
            this.lblTituloEstudiantes.AutoSize = true;
            this.lblTituloEstudiantes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEstudiantes.Location = new System.Drawing.Point(15, 9);
            this.lblTituloEstudiantes.Name = "lblTituloEstudiantes";
            this.lblTituloEstudiantes.Size = new System.Drawing.Size(262, 25);
            this.lblTituloEstudiantes.TabIndex = 0;
            this.lblTituloEstudiantes.Text = "REGISTRO DE ESTUDIANTES";
            // 
            // tabLibros
            // 
            this.tabLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLibros.Controls.Add(this.btnEliminarLibro);
            this.tabLibros.Controls.Add(this.dgvLibros);
            this.tabLibros.Controls.Add(this.btnBuscarLibro);
            this.tabLibros.Controls.Add(this.btnMostrarLibros);
            this.tabLibros.Controls.Add(this.btnRegistrarLibro);
            this.tabLibros.Controls.Add(this.txtCodigoUL);
            this.tabLibros.Controls.Add(this.txtAreaLibro);
            this.tabLibros.Controls.Add(this.txtTituloLibro);
            this.tabLibros.Controls.Add(this.txtCodigoLibro);
            this.tabLibros.Controls.Add(this.lblCodigoUL);
            this.tabLibros.Controls.Add(this.lblAreaLibro);
            this.tabLibros.Controls.Add(this.lblNombreLibro);
            this.tabLibros.Controls.Add(this.lblCodigoLibro);
            this.tabLibros.Controls.Add(this.lblTituloLibros);
            this.tabLibros.Location = new System.Drawing.Point(4, 22);
            this.tabLibros.Name = "tabLibros";
            this.tabLibros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibros.Size = new System.Drawing.Size(653, 460);
            this.tabLibros.TabIndex = 1;
            this.tabLibros.Text = "Libros";
            this.tabLibros.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoLibro,
            this.colTituloLibro,
            this.colAreaLibro,
            this.colCodigoULLibro});
            this.dgvLibros.Location = new System.Drawing.Point(25, 261);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.Size = new System.Drawing.Size(586, 150);
            this.dgvLibros.TabIndex = 12;
            // 
            // colCodigoLibro
            // 
            this.colCodigoLibro.HeaderText = "Código";
            this.colCodigoLibro.Name = "colCodigoLibro";
            this.colCodigoLibro.ReadOnly = true;
            // 
            // colTituloLibro
            // 
            this.colTituloLibro.HeaderText = "Título";
            this.colTituloLibro.Name = "colTituloLibro";
            this.colTituloLibro.ReadOnly = true;
            // 
            // colAreaLibro
            // 
            this.colAreaLibro.HeaderText = "Área";
            this.colAreaLibro.Name = "colAreaLibro";
            this.colAreaLibro.ReadOnly = true;
            // 
            // colCodigoULLibro
            // 
            this.colCodigoULLibro.HeaderText = "Código UL";
            this.colCodigoULLibro.Name = "colCodigoULLibro";
            this.colCodigoULLibro.ReadOnly = true;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(265, 207);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(102, 38);
            this.btnBuscarLibro.TabIndex = 11;
            this.btnBuscarLibro.Text = "Buscar por UL";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnMostrarLibros
            // 
            this.btnMostrarLibros.Location = new System.Drawing.Point(144, 207);
            this.btnMostrarLibros.Name = "btnMostrarLibros";
            this.btnMostrarLibros.Size = new System.Drawing.Size(102, 38);
            this.btnMostrarLibros.TabIndex = 10;
            this.btnMostrarLibros.Text = "Mostrar libros";
            this.btnMostrarLibros.UseVisualStyleBackColor = true;
            this.btnMostrarLibros.Click += new System.EventHandler(this.btnMostrarLibros_Click);
            // 
            // btnRegistrarLibro
            // 
            this.btnRegistrarLibro.Location = new System.Drawing.Point(23, 207);
            this.btnRegistrarLibro.Name = "btnRegistrarLibro";
            this.btnRegistrarLibro.Size = new System.Drawing.Size(102, 38);
            this.btnRegistrarLibro.TabIndex = 9;
            this.btnRegistrarLibro.Text = "Registrar libro";
            this.btnRegistrarLibro.UseVisualStyleBackColor = true;
            this.btnRegistrarLibro.Click += new System.EventHandler(this.btnRegistrarLibro_Click);
            // 
            // txtCodigoUL
            // 
            this.txtCodigoUL.Location = new System.Drawing.Point(157, 163);
            this.txtCodigoUL.Name = "txtCodigoUL";
            this.txtCodigoUL.Size = new System.Drawing.Size(454, 20);
            this.txtCodigoUL.TabIndex = 8;
            // 
            // txtAreaLibro
            // 
            this.txtAreaLibro.Location = new System.Drawing.Point(157, 129);
            this.txtAreaLibro.Name = "txtAreaLibro";
            this.txtAreaLibro.Size = new System.Drawing.Size(454, 20);
            this.txtAreaLibro.TabIndex = 7;
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(157, 96);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(454, 20);
            this.txtTituloLibro.TabIndex = 6;
            // 
            // txtCodigoLibro
            // 
            this.txtCodigoLibro.Location = new System.Drawing.Point(157, 60);
            this.txtCodigoLibro.Name = "txtCodigoLibro";
            this.txtCodigoLibro.Size = new System.Drawing.Size(454, 20);
            this.txtCodigoLibro.TabIndex = 5;
            // 
            // lblCodigoUL
            // 
            this.lblCodigoUL.AutoSize = true;
            this.lblCodigoUL.Location = new System.Drawing.Point(20, 166);
            this.lblCodigoUL.Name = "lblCodigoUL";
            this.lblCodigoUL.Size = new System.Drawing.Size(119, 13);
            this.lblCodigoUL.TabIndex = 4;
            this.lblCodigoUL.Text = "Código UL del ejemplar:";
            // 
            // lblAreaLibro
            // 
            this.lblAreaLibro.AutoSize = true;
            this.lblAreaLibro.Location = new System.Drawing.Point(20, 132);
            this.lblAreaLibro.Name = "lblAreaLibro";
            this.lblAreaLibro.Size = new System.Drawing.Size(32, 13);
            this.lblAreaLibro.TabIndex = 3;
            this.lblAreaLibro.Text = "Área:";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Location = new System.Drawing.Point(20, 99);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(77, 13);
            this.lblNombreLibro.TabIndex = 2;
            this.lblNombreLibro.Text = "Título del libro:";
            // 
            // lblCodigoLibro
            // 
            this.lblCodigoLibro.AutoSize = true;
            this.lblCodigoLibro.Location = new System.Drawing.Point(20, 63);
            this.lblCodigoLibro.Name = "lblCodigoLibro";
            this.lblCodigoLibro.Size = new System.Drawing.Size(82, 13);
            this.lblCodigoLibro.TabIndex = 1;
            this.lblCodigoLibro.Text = "Código del libro:";
            // 
            // lblTituloLibros
            // 
            this.lblTituloLibros.AutoSize = true;
            this.lblTituloLibros.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibros.Location = new System.Drawing.Point(18, 9);
            this.lblTituloLibros.Name = "lblTituloLibros";
            this.lblTituloLibros.Size = new System.Drawing.Size(212, 25);
            this.lblTituloLibros.TabIndex = 0;
            this.lblTituloLibros.Text = "REGISTROS DE LIBROS";
            // 
            // tabPrestamos
            // 
            this.tabPrestamos.Controls.Add(this.btnVerHistorial);
            this.tabPrestamos.Controls.Add(this.dgvPrestamos);
            this.tabPrestamos.Controls.Add(this.lblTituloPrestamos);
            this.tabPrestamos.Controls.Add(this.btnMostrarPrestamos);
            this.tabPrestamos.Controls.Add(this.btnRegistrarPrestamo);
            this.tabPrestamos.Controls.Add(this.txtCodigoULPrestamo);
            this.tabPrestamos.Controls.Add(this.txtCodigoEstudiantePrestamo);
            this.tabPrestamos.Controls.Add(this.label2);
            this.tabPrestamos.Controls.Add(this.label1);
            this.tabPrestamos.Location = new System.Drawing.Point(4, 22);
            this.tabPrestamos.Name = "tabPrestamos";
            this.tabPrestamos.Size = new System.Drawing.Size(653, 460);
            this.tabPrestamos.TabIndex = 2;
            this.tabPrestamos.Text = "Préstamos";
            this.tabPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Location = new System.Drawing.Point(362, 139);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(157, 46);
            this.btnVerHistorial.TabIndex = 8;
            this.btnVerHistorial.Text = "Historial de Devoluciones";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoEstudiante_Prestamo,
            this.colCodigoUL_Prestamo,
            this.colFechaPrestamo,
            this.colFechaDevolucion,
            this.colEstado_Prestamo});
            this.dgvPrestamos.Location = new System.Drawing.Point(26, 200);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(493, 150);
            this.dgvPrestamos.TabIndex = 7;
            // 
            // colCodigoEstudiante_Prestamo
            // 
            this.colCodigoEstudiante_Prestamo.HeaderText = "Código estudiante";
            this.colCodigoEstudiante_Prestamo.Name = "colCodigoEstudiante_Prestamo";
            this.colCodigoEstudiante_Prestamo.ReadOnly = true;
            // 
            // colCodigoUL_Prestamo
            // 
            this.colCodigoUL_Prestamo.HeaderText = "Código UL";
            this.colCodigoUL_Prestamo.Name = "colCodigoUL_Prestamo";
            this.colCodigoUL_Prestamo.ReadOnly = true;
            // 
            // colFechaPrestamo
            // 
            this.colFechaPrestamo.HeaderText = "Fecha de préstamo";
            this.colFechaPrestamo.Name = "colFechaPrestamo";
            this.colFechaPrestamo.ReadOnly = true;
            // 
            // colFechaDevolucion
            // 
            this.colFechaDevolucion.HeaderText = "Fecha de devolución";
            this.colFechaDevolucion.Name = "colFechaDevolucion";
            this.colFechaDevolucion.ReadOnly = true;
            // 
            // colEstado_Prestamo
            // 
            this.colEstado_Prestamo.HeaderText = "Estado";
            this.colEstado_Prestamo.Name = "colEstado_Prestamo";
            this.colEstado_Prestamo.ReadOnly = true;
            // 
            // lblTituloPrestamos
            // 
            this.lblTituloPrestamos.AutoSize = true;
            this.lblTituloPrestamos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrestamos.Location = new System.Drawing.Point(18, 8);
            this.lblTituloPrestamos.Name = "lblTituloPrestamos";
            this.lblTituloPrestamos.Size = new System.Drawing.Size(238, 25);
            this.lblTituloPrestamos.TabIndex = 6;
            this.lblTituloPrestamos.Text = "GESTIÓN DE PRÉSTAMOS";
            // 
            // btnMostrarPrestamos
            // 
            this.btnMostrarPrestamos.Location = new System.Drawing.Point(196, 139);
            this.btnMostrarPrestamos.Name = "btnMostrarPrestamos";
            this.btnMostrarPrestamos.Size = new System.Drawing.Size(157, 46);
            this.btnMostrarPrestamos.TabIndex = 5;
            this.btnMostrarPrestamos.Text = "Mostrar préstamos";
            this.btnMostrarPrestamos.UseVisualStyleBackColor = true;
            this.btnMostrarPrestamos.Click += new System.EventHandler(this.btnMostrarPrestamos_Click);
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(26, 139);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(157, 46);
            this.btnRegistrarPrestamo.TabIndex = 4;
            this.btnRegistrarPrestamo.Text = "Registrar préstamo";
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = true;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // txtCodigoULPrestamo
            // 
            this.txtCodigoULPrestamo.Location = new System.Drawing.Point(157, 93);
            this.txtCodigoULPrestamo.Name = "txtCodigoULPrestamo";
            this.txtCodigoULPrestamo.Size = new System.Drawing.Size(359, 20);
            this.txtCodigoULPrestamo.TabIndex = 3;
            // 
            // txtCodigoEstudiantePrestamo
            // 
            this.txtCodigoEstudiantePrestamo.Location = new System.Drawing.Point(157, 57);
            this.txtCodigoEstudiantePrestamo.Name = "txtCodigoEstudiantePrestamo";
            this.txtCodigoEstudiantePrestamo.Size = new System.Drawing.Size(359, 20);
            this.txtCodigoEstudiantePrestamo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código UL del ejemplar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del estudiante";
            // 
            // tabConsultas
            // 
            this.tabConsultas.Controls.Add(this.lblResultadoConsulta);
            this.tabConsultas.Controls.Add(this.txtResultadoConsulta);
            this.tabConsultas.Controls.Add(this.btnConsultarLibro);
            this.tabConsultas.Controls.Add(this.btnConsultarEstudiante);
            this.tabConsultas.Controls.Add(this.txtConsultaUL);
            this.tabConsultas.Controls.Add(this.lblCodigoULConsulta);
            this.tabConsultas.Controls.Add(this.txtConsultaEstudiante);
            this.tabConsultas.Controls.Add(this.lblCodigoEstudianteConsulta);
            this.tabConsultas.Controls.Add(this.lblTituloConsultas);
            this.tabConsultas.Location = new System.Drawing.Point(4, 22);
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.Size = new System.Drawing.Size(653, 460);
            this.tabConsultas.TabIndex = 3;
            this.tabConsultas.Text = "Consultas";
            this.tabConsultas.UseVisualStyleBackColor = true;
            // 
            // lblResultadoConsulta
            // 
            this.lblResultadoConsulta.AutoSize = true;
            this.lblResultadoConsulta.Location = new System.Drawing.Point(20, 164);
            this.lblResultadoConsulta.Name = "lblResultadoConsulta";
            this.lblResultadoConsulta.Size = new System.Drawing.Size(122, 13);
            this.lblResultadoConsulta.TabIndex = 8;
            this.lblResultadoConsulta.Text = "Resultados de Consulta:";
            // 
            // txtResultadoConsulta
            // 
            this.txtResultadoConsulta.Location = new System.Drawing.Point(23, 191);
            this.txtResultadoConsulta.Multiline = true;
            this.txtResultadoConsulta.Name = "txtResultadoConsulta";
            this.txtResultadoConsulta.ReadOnly = true;
            this.txtResultadoConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultadoConsulta.Size = new System.Drawing.Size(486, 109);
            this.txtResultadoConsulta.TabIndex = 7;
            // 
            // btnConsultarLibro
            // 
            this.btnConsultarLibro.Location = new System.Drawing.Point(383, 88);
            this.btnConsultarLibro.Name = "btnConsultarLibro";
            this.btnConsultarLibro.Size = new System.Drawing.Size(127, 34);
            this.btnConsultarLibro.TabIndex = 6;
            this.btnConsultarLibro.Text = "Consultar libro";
            this.btnConsultarLibro.UseVisualStyleBackColor = true;
            this.btnConsultarLibro.Click += new System.EventHandler(this.btnConsultarLibro_Click);
            // 
            // btnConsultarEstudiante
            // 
            this.btnConsultarEstudiante.Location = new System.Drawing.Point(383, 40);
            this.btnConsultarEstudiante.Name = "btnConsultarEstudiante";
            this.btnConsultarEstudiante.Size = new System.Drawing.Size(127, 34);
            this.btnConsultarEstudiante.TabIndex = 5;
            this.btnConsultarEstudiante.Text = "Consultar estudiante";
            this.btnConsultarEstudiante.UseVisualStyleBackColor = true;
            this.btnConsultarEstudiante.Click += new System.EventHandler(this.btnConsultarEstudiante_Click);
            // 
            // txtConsultaUL
            // 
            this.txtConsultaUL.Location = new System.Drawing.Point(145, 96);
            this.txtConsultaUL.Name = "txtConsultaUL";
            this.txtConsultaUL.Size = new System.Drawing.Size(208, 20);
            this.txtConsultaUL.TabIndex = 4;
            // 
            // lblCodigoULConsulta
            // 
            this.lblCodigoULConsulta.AutoSize = true;
            this.lblCodigoULConsulta.Location = new System.Drawing.Point(21, 99);
            this.lblCodigoULConsulta.Name = "lblCodigoULConsulta";
            this.lblCodigoULConsulta.Size = new System.Drawing.Size(99, 13);
            this.lblCodigoULConsulta.TabIndex = 3;
            this.lblCodigoULConsulta.Text = "Código UL del libro:";
            // 
            // txtConsultaEstudiante
            // 
            this.txtConsultaEstudiante.Location = new System.Drawing.Point(145, 48);
            this.txtConsultaEstudiante.Name = "txtConsultaEstudiante";
            this.txtConsultaEstudiante.Size = new System.Drawing.Size(208, 20);
            this.txtConsultaEstudiante.TabIndex = 2;
            // 
            // lblCodigoEstudianteConsulta
            // 
            this.lblCodigoEstudianteConsulta.AutoSize = true;
            this.lblCodigoEstudianteConsulta.Location = new System.Drawing.Point(21, 51);
            this.lblCodigoEstudianteConsulta.Name = "lblCodigoEstudianteConsulta";
            this.lblCodigoEstudianteConsulta.Size = new System.Drawing.Size(112, 13);
            this.lblCodigoEstudianteConsulta.TabIndex = 1;
            this.lblCodigoEstudianteConsulta.Text = "Código del estudiante:";
            // 
            // lblTituloConsultas
            // 
            this.lblTituloConsultas.AutoSize = true;
            this.lblTituloConsultas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultas.Location = new System.Drawing.Point(19, 11);
            this.lblTituloConsultas.Name = "lblTituloConsultas";
            this.lblTituloConsultas.Size = new System.Drawing.Size(121, 25);
            this.lblTituloConsultas.TabIndex = 0;
            this.lblTituloConsultas.Text = "CONSULTAS";
            // 
            // tabDevoluciones
            // 
            this.tabDevoluciones.Controls.Add(this.txtResultadoDevolucion);
            this.tabDevoluciones.Controls.Add(this.lblResultadoDevolucion);
            this.tabDevoluciones.Controls.Add(this.btnRegistrarDevolucion);
            this.tabDevoluciones.Controls.Add(this.txtCodigoULDevolucion);
            this.tabDevoluciones.Controls.Add(this.lblCodigoULDevolucion);
            this.tabDevoluciones.Controls.Add(this.lblTituloDevoluciones);
            this.tabDevoluciones.Location = new System.Drawing.Point(4, 22);
            this.tabDevoluciones.Name = "tabDevoluciones";
            this.tabDevoluciones.Size = new System.Drawing.Size(653, 460);
            this.tabDevoluciones.TabIndex = 4;
            this.tabDevoluciones.Text = "Devoluciones";
            this.tabDevoluciones.UseVisualStyleBackColor = true;
            // 
            // txtResultadoDevolucion
            // 
            this.txtResultadoDevolucion.Location = new System.Drawing.Point(18, 134);
            this.txtResultadoDevolucion.Multiline = true;
            this.txtResultadoDevolucion.Name = "txtResultadoDevolucion";
            this.txtResultadoDevolucion.ReadOnly = true;
            this.txtResultadoDevolucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultadoDevolucion.Size = new System.Drawing.Size(503, 226);
            this.txtResultadoDevolucion.TabIndex = 5;
            // 
            // lblResultadoDevolucion
            // 
            this.lblResultadoDevolucion.AutoSize = true;
            this.lblResultadoDevolucion.Location = new System.Drawing.Point(15, 106);
            this.lblResultadoDevolucion.Name = "lblResultadoDevolucion";
            this.lblResultadoDevolucion.Size = new System.Drawing.Size(136, 13);
            this.lblResultadoDevolucion.TabIndex = 4;
            this.lblResultadoDevolucion.Text = "Resultado de la devolución";
            // 
            // btnRegistrarDevolucion
            // 
            this.btnRegistrarDevolucion.Location = new System.Drawing.Point(384, 41);
            this.btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            this.btnRegistrarDevolucion.Size = new System.Drawing.Size(137, 37);
            this.btnRegistrarDevolucion.TabIndex = 3;
            this.btnRegistrarDevolucion.Text = "Registrar devolución";
            this.btnRegistrarDevolucion.UseVisualStyleBackColor = true;
            this.btnRegistrarDevolucion.Click += new System.EventHandler(this.btnRegistrarDevolucion_Click);
            // 
            // txtCodigoULDevolucion
            // 
            this.txtCodigoULDevolucion.Location = new System.Drawing.Point(150, 50);
            this.txtCodigoULDevolucion.Name = "txtCodigoULDevolucion";
            this.txtCodigoULDevolucion.Size = new System.Drawing.Size(206, 20);
            this.txtCodigoULDevolucion.TabIndex = 2;
            // 
            // lblCodigoULDevolucion
            // 
            this.lblCodigoULDevolucion.AutoSize = true;
            this.lblCodigoULDevolucion.Location = new System.Drawing.Point(15, 53);
            this.lblCodigoULDevolucion.Name = "lblCodigoULDevolucion";
            this.lblCodigoULDevolucion.Size = new System.Drawing.Size(116, 13);
            this.lblCodigoULDevolucion.TabIndex = 1;
            this.lblCodigoULDevolucion.Text = "Código UL del ejemplar";
            // 
            // lblTituloDevoluciones
            // 
            this.lblTituloDevoluciones.AutoSize = true;
            this.lblTituloDevoluciones.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDevoluciones.Location = new System.Drawing.Point(13, 11);
            this.lblTituloDevoluciones.Name = "lblTituloDevoluciones";
            this.lblTituloDevoluciones.Size = new System.Drawing.Size(270, 25);
            this.lblTituloDevoluciones.TabIndex = 0;
            this.lblTituloDevoluciones.Text = "GESTIÓN DE DEVOLUCIONES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // colCodigoEstudiantePrestamo
            // 
            this.colCodigoEstudiantePrestamo.HeaderText = "Código estudiante";
            this.colCodigoEstudiantePrestamo.Name = "colCodigoEstudiantePrestamo";
            this.colCodigoEstudiantePrestamo.Width = 66;
            // 
            // colCodigoULPrestamo
            // 
            this.colCodigoULPrestamo.HeaderText = "Código UL";
            this.colCodigoULPrestamo.Name = "colCodigoULPrestamo";
            this.colCodigoULPrestamo.ReadOnly = true;
            // 
            // colEstadoPrestamo
            // 
            this.colEstadoPrestamo.HeaderText = "Estado";
            this.colEstadoPrestamo.Name = "colEstadoPrestamo";
            this.colEstadoPrestamo.ReadOnly = true;
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(389, 207);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(102, 38);
            this.btnEliminarLibro.TabIndex = 13;
            this.btnEliminarLibro.Text = "Eliminar libro";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnEliminarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(495, 205);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(124, 33);
            this.btnEliminarEstudiante.TabIndex = 14;
            this.btnEliminarEstudiante.Text = "Eliminar Estudiante";
            this.btnEliminarEstudiante.UseVisualStyleBackColor = false;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // btnOrdenarBurbuja
            // 
            this.btnOrdenarBurbuja.Location = new System.Drawing.Point(104, 250);
            this.btnOrdenarBurbuja.Name = "btnOrdenarBurbuja";
            this.btnOrdenarBurbuja.Size = new System.Drawing.Size(173, 33);
            this.btnOrdenarBurbuja.TabIndex = 15;
            this.btnOrdenarBurbuja.Text = "Ordenar A-Z (Burbuja)";
            this.btnOrdenarBurbuja.UseVisualStyleBackColor = true;
            this.btnOrdenarBurbuja.Click += new System.EventHandler(this.btnOrdenarBurbuja_Click);
            // 
            // btnOrdenarSeleccion
            // 
            this.btnOrdenarSeleccion.Location = new System.Drawing.Point(360, 250);
            this.btnOrdenarSeleccion.Name = "btnOrdenarSeleccion";
            this.btnOrdenarSeleccion.Size = new System.Drawing.Size(172, 33);
            this.btnOrdenarSeleccion.TabIndex = 16;
            this.btnOrdenarSeleccion.Text = "Ordenar A-Z (Selección)";
            this.btnOrdenarSeleccion.UseVisualStyleBackColor = true;
            this.btnOrdenarSeleccion.Click += new System.EventHandler(this.btnOrdenarSeleccion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabContenido);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "BIBLIOTECA DE LA UPN";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoUPN)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.tabContenido.ResumeLayout(false);
            this.tabEstudiantes.ResumeLayout(false);
            this.tabEstudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.tabLibros.ResumeLayout(false);
            this.tabLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.tabPrestamos.ResumeLayout(false);
            this.tabPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.tabConsultas.ResumeLayout(false);
            this.tabConsultas.PerformLayout();
            this.tabDevoluciones.ResumeLayout(false);
            this.tabDevoluciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.TabControl tabContenido;
        private System.Windows.Forms.TabPage tabEstudiantes;
        private System.Windows.Forms.TabPage tabLibros;
        private System.Windows.Forms.TabPage tabPrestamos;
        private System.Windows.Forms.TabPage tabConsultas;
        private System.Windows.Forms.Label lblTituloEstudiantes;
        private System.Windows.Forms.Label lblEstadoMatricula;
        private System.Windows.Forms.Label lblApellidosEstudiante;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.Label lblCodigoEstudiante;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.Button btnMostrarEstudiantes;
        private System.Windows.Forms.Button btnRegistrarEstudiante;
        private System.Windows.Forms.TextBox txtApellidosEstudiante;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtCodigoEstudiante;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.ComboBox cboEstadoMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoMatricula;
        private System.Windows.Forms.TabPage tabDevoluciones;
        private System.Windows.Forms.Label lblTituloLibros;
        private System.Windows.Forms.Label lblCodigoUL;
        private System.Windows.Forms.Label lblAreaLibro;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblCodigoLibro;
        private System.Windows.Forms.TextBox txtCodigoUL;
        private System.Windows.Forms.TextBox txtAreaLibro;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtCodigoLibro;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.Button btnMostrarLibros;
        private System.Windows.Forms.Button btnRegistrarLibro;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAreaLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoULLibro;
        private System.Windows.Forms.Button btnMostrarPrestamos;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
        private System.Windows.Forms.TextBox txtCodigoULPrestamo;
        private System.Windows.Forms.TextBox txtCodigoEstudiantePrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloPrestamos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoEstudiantePrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoULPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoPrestamo;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoEstudiante_Prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoUL_Prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado_Prestamo;
        private System.Windows.Forms.Label lblTituloConsultas;
        private System.Windows.Forms.Button btnConsultarLibro;
        private System.Windows.Forms.Button btnConsultarEstudiante;
        private System.Windows.Forms.TextBox txtConsultaUL;
        private System.Windows.Forms.Label lblCodigoULConsulta;
        private System.Windows.Forms.TextBox txtConsultaEstudiante;
        private System.Windows.Forms.Label lblCodigoEstudianteConsulta;
        private System.Windows.Forms.TextBox txtResultadoConsulta;
        private System.Windows.Forms.Label lblCodigoULDevolucion;
        private System.Windows.Forms.Label lblTituloDevoluciones;
        private System.Windows.Forms.Button btnRegistrarDevolucion;
        private System.Windows.Forms.TextBox txtCodigoULDevolucion;
        private System.Windows.Forms.Label lblResultadoConsulta;
        private System.Windows.Forms.TextBox txtResultadoDevolucion;
        private System.Windows.Forms.Label lblResultadoDevolucion;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.PictureBox picLogoUPN;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnOrdenarSeleccion;
        private System.Windows.Forms.Button btnOrdenarBurbuja;
    }
}

