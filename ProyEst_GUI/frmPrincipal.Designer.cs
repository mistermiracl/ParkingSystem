namespace ProyEst_GUI
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosIngresadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalIngresosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasfechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.panelVehiculos = new System.Windows.Forms.Panel();
            this.btnSalirVehiculo = new System.Windows.Forms.Button();
            this.btnActualizarVehiculo = new System.Windows.Forms.Button();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.dtgVehiculos = new System.Windows.Forms.DataGridView();
            this.panelEmpleados = new System.Windows.Forms.Panel();
            this.btnSalirEmpleado = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnInactivarEmpleado = new System.Windows.Forms.Button();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTiempoSesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.panelVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).BeginInit();
            this.panelEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 41);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.AutoSize = false;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(97, 38);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.AutoSize = false;
            this.salirToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.AutoSize = false;
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehículosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(143, 38);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // vehículosToolStripMenuItem
            // 
            this.vehículosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.vehículosToolStripMenuItem.Name = "vehículosToolStripMenuItem";
            this.vehículosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.vehículosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.vehículosToolStripMenuItem.Text = "Vehículos";
            this.vehículosToolStripMenuItem.Click += new System.EventHandler(this.vehículosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.AutoSize = false;
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.empleadosToolStripMenuItem1});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(117, 38);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosIngresadosToolStripMenuItem,
            this.totalIngresosToolStripMenuItem1});
            this.vehiculosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.vehiculosToolStripMenuItem.Text = "Consultas Vehiculos";
            // 
            // vehiculosIngresadosToolStripMenuItem
            // 
            this.vehiculosIngresadosToolStripMenuItem.Name = "vehiculosIngresadosToolStripMenuItem";
            this.vehiculosIngresadosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.vehiculosIngresadosToolStripMenuItem.Text = "Vehiculos Ingresados";
            this.vehiculosIngresadosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosIngresadosToolStripMenuItem_Click);
            // 
            // totalIngresosToolStripMenuItem1
            // 
            this.totalIngresosToolStripMenuItem1.Name = "totalIngresosToolStripMenuItem1";
            this.totalIngresosToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.totalIngresosToolStripMenuItem1.Text = "Total Ingresos";
            this.totalIngresosToolStripMenuItem1.Click += new System.EventHandler(this.totalIngresosToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasfechaToolStripMenuItem});
            this.clientesToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.clientesToolStripMenuItem1.Text = "Consultas Clientes";
            // 
            // entradasfechaToolStripMenuItem
            // 
            this.entradasfechaToolStripMenuItem.Name = "entradasfechaToolStripMenuItem";
            this.entradasfechaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.entradasfechaToolStripMenuItem.Text = "Entradas por Fecha";
            this.entradasfechaToolStripMenuItem.Click += new System.EventHandler(this.entradasfechaToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem});
            this.empleadosToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.empleadosToolStripMenuItem1.Text = "Consultas Empleados";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.AutoSize = false;
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem});
            this.configuracionToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(131, 38);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.AutoSize = false;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(76, 38);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // panelCliente
            // 
            this.panelCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCliente.Controls.Add(this.btnSalir);
            this.panelCliente.Controls.Add(this.btnModificar);
            this.panelCliente.Controls.Add(this.btnAgregar);
            this.panelCliente.Controls.Add(this.btnEliminar);
            this.panelCliente.Controls.Add(this.dtgClientes);
            this.panelCliente.Location = new System.Drawing.Point(62, 52);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(1154, 554);
            this.panelCliente.TabIndex = 6;
            this.panelCliente.Visible = false;
            this.panelCliente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panelCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panelCliente.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(986, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 38);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(986, 113);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 38);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Actualizar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(986, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 38);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(986, 159);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            this.dtgClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgClientes.Location = new System.Drawing.Point(10, 12);
            this.dtgClientes.MultiSelect = false;
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(938, 526);
            this.dtgClientes.TabIndex = 1;
            // 
            // panelVehiculos
            // 
            this.panelVehiculos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVehiculos.Controls.Add(this.btnSalirVehiculo);
            this.panelVehiculos.Controls.Add(this.btnActualizarVehiculo);
            this.panelVehiculos.Controls.Add(this.btnAgregarVehiculo);
            this.panelVehiculos.Controls.Add(this.dtgVehiculos);
            this.panelVehiculos.Location = new System.Drawing.Point(45, 52);
            this.panelVehiculos.Name = "panelVehiculos";
            this.panelVehiculos.Size = new System.Drawing.Size(1277, 554);
            this.panelVehiculos.TabIndex = 0;
            this.panelVehiculos.Visible = false;
            this.panelVehiculos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panelVehiculos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panelVehiculos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // btnSalirVehiculo
            // 
            this.btnSalirVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirVehiculo.Location = new System.Drawing.Point(830, 475);
            this.btnSalirVehiculo.Name = "btnSalirVehiculo";
            this.btnSalirVehiculo.Size = new System.Drawing.Size(144, 38);
            this.btnSalirVehiculo.TabIndex = 3;
            this.btnSalirVehiculo.Text = "Salir";
            this.btnSalirVehiculo.UseVisualStyleBackColor = true;
            this.btnSalirVehiculo.Click += new System.EventHandler(this.btnSalirVehiculo_Click);
            // 
            // btnActualizarVehiculo
            // 
            this.btnActualizarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVehiculo.Location = new System.Drawing.Point(260, 475);
            this.btnActualizarVehiculo.Name = "btnActualizarVehiculo";
            this.btnActualizarVehiculo.Size = new System.Drawing.Size(144, 38);
            this.btnActualizarVehiculo.TabIndex = 4;
            this.btnActualizarVehiculo.Text = "Marcar Salida";
            this.btnActualizarVehiculo.UseVisualStyleBackColor = true;
            this.btnActualizarVehiculo.Click += new System.EventHandler(this.btnActualizarVehiculo_Click);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(110, 475);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(144, 38);
            this.btnAgregarVehiculo.TabIndex = 5;
            this.btnAgregarVehiculo.Text = "Marcar Entrada";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // dtgVehiculos
            // 
            this.dtgVehiculos.AllowUserToAddRows = false;
            this.dtgVehiculos.AllowUserToDeleteRows = false;
            this.dtgVehiculos.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray;
            this.dtgVehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgVehiculos.Location = new System.Drawing.Point(9, 11);
            this.dtgVehiculos.MultiSelect = false;
            this.dtgVehiculos.Name = "dtgVehiculos";
            this.dtgVehiculos.RowHeadersVisible = false;
            this.dtgVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVehiculos.Size = new System.Drawing.Size(1243, 414);
            this.dtgVehiculos.TabIndex = 2;
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEmpleados.Controls.Add(this.btnSalirEmpleado);
            this.panelEmpleados.Controls.Add(this.btnActualizarEmpleado);
            this.panelEmpleados.Controls.Add(this.btnAgregarEmpleado);
            this.panelEmpleados.Controls.Add(this.btnInactivarEmpleado);
            this.panelEmpleados.Controls.Add(this.dtgEmpleados);
            this.panelEmpleados.Location = new System.Drawing.Point(62, 52);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Size = new System.Drawing.Size(1154, 554);
            this.panelEmpleados.TabIndex = 8;
            this.panelEmpleados.Visible = false;
            this.panelEmpleados.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panelEmpleados.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panelEmpleados.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // btnSalirEmpleado
            // 
            this.btnSalirEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirEmpleado.Location = new System.Drawing.Point(16, 466);
            this.btnSalirEmpleado.Name = "btnSalirEmpleado";
            this.btnSalirEmpleado.Size = new System.Drawing.Size(144, 38);
            this.btnSalirEmpleado.TabIndex = 3;
            this.btnSalirEmpleado.Text = "Salir";
            this.btnSalirEmpleado.UseVisualStyleBackColor = true;
            this.btnSalirEmpleado.Click += new System.EventHandler(this.btnSalirEmpleado_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(16, 103);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(144, 50);
            this.btnActualizarEmpleado.TabIndex = 4;
            this.btnActualizarEmpleado.Text = "Actualizar Empleado";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = true;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(16, 50);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(144, 38);
            this.btnAgregarEmpleado.TabIndex = 5;
            this.btnAgregarEmpleado.Text = "Nuevo Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnInactivarEmpleado
            // 
            this.btnInactivarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivarEmpleado.Location = new System.Drawing.Point(16, 170);
            this.btnInactivarEmpleado.Name = "btnInactivarEmpleado";
            this.btnInactivarEmpleado.Size = new System.Drawing.Size(144, 38);
            this.btnInactivarEmpleado.TabIndex = 6;
            this.btnInactivarEmpleado.Text = "Eliminar";
            this.btnInactivarEmpleado.UseVisualStyleBackColor = true;
            this.btnInactivarEmpleado.Click += new System.EventHandler(this.btnInactivarEmpleado_Click);
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.AllowUserToAddRows = false;
            this.dtgEmpleados.AllowUserToDeleteRows = false;
            this.dtgEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            this.dtgEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgEmpleados.Location = new System.Drawing.Point(175, 11);
            this.dtgEmpleados.MultiSelect = false;
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.RowHeadersVisible = false;
            this.dtgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpleados.Size = new System.Drawing.Size(954, 526);
            this.dtgEmpleados.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPC,
            this.lblTiempoSesion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1022, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "s";
            // 
            // lblPC
            // 
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(503, 20);
            this.lblPC.Spring = true;
            this.lblPC.Text = "...";
            this.lblPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTiempoSesion
            // 
            this.lblTiempoSesion.BackColor = System.Drawing.Color.Black;
            this.lblTiempoSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTiempoSesion.Name = "lblTiempoSesion";
            this.lblTiempoSesion.Size = new System.Drawing.Size(503, 20);
            this.lblTiempoSesion.Spring = true;
            this.lblTiempoSesion.Text = "...";
            this.lblTiempoSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::ProyEst_GUI.Properties.Resources.fondoparking;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.panelVehiculos);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panelEmpleados);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(830, 604);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto U";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.panelVehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).EndInit();
            this.panelEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Panel panelVehiculos;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgVehiculos;
        private System.Windows.Forms.Button btnSalirVehiculo;
        private System.Windows.Forms.Button btnActualizarVehiculo;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Panel panelEmpleados;
        private System.Windows.Forms.Button btnSalirEmpleado;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnInactivarEmpleado;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTiempoSesion;
        private System.Windows.Forms.ToolStripStatusLabel lblPC;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vehiculosIngresadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalIngresosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradasfechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
    }
}