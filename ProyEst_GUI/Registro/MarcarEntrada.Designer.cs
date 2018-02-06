namespace ProyEst_GUI.Registro
{
    partial class MarcarEntrada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPuestos = new System.Windows.Forms.ComboBox();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.cbxModelos = new System.Windows.Forms.ComboBox();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cbxMarcas = new System.Windows.Forms.ComboBox();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mtxtPlaca);
            this.groupBox1.Controls.Add(this.lblHoraActual);
            this.groupBox1.Controls.Add(this.pbxLogo);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxPuestos);
            this.groupBox1.Controls.Add(this.cbxClientes);
            this.groupBox1.Controls.Add(this.cbxModelos);
            this.groupBox1.Controls.Add(this.cbxTipoVehiculo);
            this.groupBox1.Controls.Add(this.cbxMarcas);
            this.groupBox1.Controls.Add(this.rtxtDescripcion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1085, 861);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculo";
            // 
            // mtxtPlaca
            // 
            this.mtxtPlaca.Location = new System.Drawing.Point(108, 145);
            this.mtxtPlaca.Mask = "AAA-AAA";
            this.mtxtPlaca.Name = "mtxtPlaca";
            this.mtxtPlaca.Size = new System.Drawing.Size(297, 29);
            this.mtxtPlaca.TabIndex = 0;
            this.mtxtPlaca.TextChanged += new System.EventHandler(this.mtxtPlaca_TextChanged);
            this.mtxtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPlaca_KeyPress);
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.Location = new System.Drawing.Point(809, 26);
            this.lblHoraActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(255, 34);
            this.lblHoraActual.TabIndex = 12;
            this.lblHoraActual.Text = "HORA ACTUAL";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pbxLogo.ErrorImage = null;
            this.pbxLogo.Location = new System.Drawing.Point(494, 216);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(337, 233);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 11;
            this.pbxLogo.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Location = new System.Drawing.Point(917, 797);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 52);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(765, 796);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 52);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Finalizar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 563);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripcion Entrada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 466);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Puesto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de Vehiculo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(616, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha/Hora Entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Placa:";
            // 
            // cbxPuestos
            // 
            this.cbxPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPuestos.FormattingEnabled = true;
            this.cbxPuestos.Location = new System.Drawing.Point(108, 502);
            this.cbxPuestos.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPuestos.Name = "cbxPuestos";
            this.cbxPuestos.Size = new System.Drawing.Size(203, 32);
            this.cbxPuestos.TabIndex = 4;
            // 
            // cbxClientes
            // 
            this.cbxClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(476, 502);
            this.cbxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(353, 32);
            this.cbxClientes.TabIndex = 5;
            // 
            // cbxModelos
            // 
            this.cbxModelos.Enabled = false;
            this.cbxModelos.FormattingEnabled = true;
            this.cbxModelos.Location = new System.Drawing.Point(108, 361);
            this.cbxModelos.Margin = new System.Windows.Forms.Padding(4);
            this.cbxModelos.Name = "cbxModelos";
            this.cbxModelos.Size = new System.Drawing.Size(319, 32);
            this.cbxModelos.TabIndex = 3;
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Items.AddRange(new object[] {
            "AUTO",
            "MOTO"});
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(494, 142);
            this.cbxTipoVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(320, 32);
            this.cbxTipoVehiculo.TabIndex = 1;
            // 
            // cbxMarcas
            // 
            this.cbxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarcas.FormattingEnabled = true;
            this.cbxMarcas.Location = new System.Drawing.Point(108, 266);
            this.cbxMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMarcas.Name = "cbxMarcas";
            this.cbxMarcas.Size = new System.Drawing.Size(319, 32);
            this.cbxMarcas.TabIndex = 2;
            this.cbxMarcas.SelectionChangeCommitted += new System.EventHandler(this.cbxMarcas_SelectionChangeCommitted);
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(108, 613);
            this.rtxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(621, 200);
            this.rtxtDescripcion.TabIndex = 6;
            this.rtxtDescripcion.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MarcarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 896);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarcarEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcar Entrada";
            this.Load += new System.EventHandler(this.MarcarEntrada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.ComboBox cbxModelos;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.ComboBox cbxMarcas;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxPuestos;
        private System.Windows.Forms.MaskedTextBox mtxtPlaca;
    }
}