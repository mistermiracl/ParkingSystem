namespace ProyEst_GUI.Estacionamiento
{
    partial class frmEstacionamientoConf
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
            this.mtxtTarifa = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgPuestos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevaMarca = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_DISPONIBILIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtTarifa
            // 
            this.mtxtTarifa.Location = new System.Drawing.Point(757, 59);
            this.mtxtTarifa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtTarifa.Mask = "s/99.99";
            this.mtxtTarifa.Name = "mtxtTarifa";
            this.mtxtTarifa.Size = new System.Drawing.Size(164, 29);
            this.mtxtTarifa.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgPuestos);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnNuevaMarca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.lblUsuarioActivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxtTarifa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1004, 580);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion";
            // 
            // dtgPuestos
            // 
            this.dtgPuestos.AllowUserToAddRows = false;
            this.dtgPuestos.AllowUserToDeleteRows = false;
            this.dtgPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PUESTO,
            this.NIVEL,
            this.BLOQUE,
            this.ESTADO_DISPONIBILIDAD});
            this.dtgPuestos.Location = new System.Drawing.Point(29, 229);
            this.dtgPuestos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgPuestos.MultiSelect = false;
            this.dtgPuestos.Name = "dtgPuestos";
            this.dtgPuestos.ReadOnly = true;
            this.dtgPuestos.RowHeadersVisible = false;
            this.dtgPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPuestos.Size = new System.Drawing.Size(480, 250);
            this.dtgPuestos.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(252, 149);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(165, 46);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(657, 527);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 46);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(831, 527);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 46);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevaMarca.Location = new System.Drawing.Point(757, 288);
            this.btnNuevaMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.Size = new System.Drawing.Size(123, 78);
            this.btnNuevaMarca.TabIndex = 6;
            this.btnNuevaMarca.Text = "+";
            this.btnNuevaMarca.UseVisualStyleBackColor = true;
            this.btnNuevaMarca.Click += new System.EventHandler(this.btnNuevaMarca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nueva Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puestos Disponibles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarifa Diaria (Hora):";
            // 
            // lblCantidad
            // 
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad.Location = new System.Drawing.Point(121, 495);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(155, 32);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "cuenta";
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuarioActivo.Location = new System.Drawing.Point(209, 58);
            this.lblUsuarioActivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(292, 34);
            this.lblUsuarioActivo.TabIndex = 4;
            this.lblUsuarioActivo.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 496);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario Activo:";
            // 
            // ID_PUESTO
            // 
            this.ID_PUESTO.DataPropertyName = "ID_PUESTO";
            this.ID_PUESTO.HeaderText = "CODIGO";
            this.ID_PUESTO.Name = "ID_PUESTO";
            this.ID_PUESTO.ReadOnly = true;
            // 
            // NIVEL
            // 
            this.NIVEL.DataPropertyName = "NIVEL";
            this.NIVEL.FillWeight = 70F;
            this.NIVEL.HeaderText = "NIVEL";
            this.NIVEL.Name = "NIVEL";
            this.NIVEL.ReadOnly = true;
            this.NIVEL.Width = 85;
            // 
            // BLOQUE
            // 
            this.BLOQUE.DataPropertyName = "BLOQUE";
            this.BLOQUE.HeaderText = "BLOQUE";
            this.BLOQUE.Name = "BLOQUE";
            this.BLOQUE.ReadOnly = true;
            // 
            // ESTADO_DISPONIBILIDAD
            // 
            this.ESTADO_DISPONIBILIDAD.DataPropertyName = "DISPONIBILIDAD";
            this.ESTADO_DISPONIBILIDAD.HeaderText = "DISPONIBILIDAD";
            this.ESTADO_DISPONIBILIDAD.Name = "ESTADO_DISPONIBILIDAD";
            this.ESTADO_DISPONIBILIDAD.ReadOnly = true;
            this.ESTADO_DISPONIBILIDAD.Width = 190;
            // 
            // frmEstacionamientoConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 609);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstacionamientoConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion Estacionamiento";
            this.Load += new System.EventHandler(this.frmEstacionamientoConf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtTarifa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgPuestos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_DISPONIBILIDAD;
    }
}