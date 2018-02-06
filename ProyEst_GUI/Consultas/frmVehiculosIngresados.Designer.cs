namespace ProyEst_GUI.Consultas
{
    partial class frmVehiculosIngresados
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxMarcas = new System.Windows.Forms.ComboBox();
            this.btnConsultarPorMarca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.rbtnMarca = new System.Windows.Forms.RadioButton();
            this.rbtnPlaca = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dtgVehiculosIngresados = new System.Windows.Forms.DataGridView();
            this.btnImprimirReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculosIngresados)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(894, 602);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(876, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxMarcas);
            this.groupBox3.Controls.Add(this.btnConsultarPorMarca);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(414, 50);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(405, 137);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Marca:";
            // 
            // cbxMarcas
            // 
            this.cbxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarcas.FormattingEnabled = true;
            this.cbxMarcas.Location = new System.Drawing.Point(37, 58);
            this.cbxMarcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMarcas.Name = "cbxMarcas";
            this.cbxMarcas.Size = new System.Drawing.Size(193, 26);
            this.cbxMarcas.TabIndex = 4;
            // 
            // btnConsultarPorMarca
            // 
            this.btnConsultarPorMarca.Location = new System.Drawing.Point(272, 48);
            this.btnConsultarPorMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultarPorMarca.Name = "btnConsultarPorMarca";
            this.btnConsultarPorMarca.Size = new System.Drawing.Size(105, 46);
            this.btnConsultarPorMarca.TabIndex = 3;
            this.btnConsultarPorMarca.Text = "Consultar";
            this.btnConsultarPorMarca.UseVisualStyleBackColor = true;
            this.btnConsultarPorMarca.Click += new System.EventHandler(this.btnConsultarPorMarca_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOrdenar);
            this.groupBox2.Controls.Add(this.rbtnMarca);
            this.groupBox2.Controls.Add(this.rbtnPlaca);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(52, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(291, 137);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar Por:";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(162, 48);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(105, 46);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Consultar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.Location = new System.Drawing.Point(29, 80);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(68, 22);
            this.rbtnMarca.TabIndex = 2;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = true;
            // 
            // rbtnPlaca
            // 
            this.rbtnPlaca.AutoSize = true;
            this.rbtnPlaca.Checked = true;
            this.rbtnPlaca.Location = new System.Drawing.Point(29, 41);
            this.rbtnPlaca.Name = "rbtnPlaca";
            this.rbtnPlaca.Size = new System.Drawing.Size(63, 22);
            this.rbtnPlaca.TabIndex = 0;
            this.rbtnPlaca.TabStop = true;
            this.rbtnPlaca.Text = "Placa";
            this.rbtnPlaca.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dtgVehiculosIngresados);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnImprimirReporte);
            this.splitContainer2.Size = new System.Drawing.Size(894, 363);
            this.splitContainer2.SplitterDistance = 258;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // dtgVehiculosIngresados
            // 
            this.dtgVehiculosIngresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVehiculosIngresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculosIngresados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVehiculosIngresados.Location = new System.Drawing.Point(0, 0);
            this.dtgVehiculosIngresados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgVehiculosIngresados.Name = "dtgVehiculosIngresados";
            this.dtgVehiculosIngresados.ReadOnly = true;
            this.dtgVehiculosIngresados.RowTemplate.Height = 24;
            this.dtgVehiculosIngresados.Size = new System.Drawing.Size(894, 258);
            this.dtgVehiculosIngresados.TabIndex = 0;
            // 
            // btnImprimirReporte
            // 
            this.btnImprimirReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirReporte.Image = global::ProyEst_GUI.Properties.Resources.printer_64;
            this.btnImprimirReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirReporte.Location = new System.Drawing.Point(629, 17);
            this.btnImprimirReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimirReporte.Name = "btnImprimirReporte";
            this.btnImprimirReporte.Size = new System.Drawing.Size(171, 67);
            this.btnImprimirReporte.TabIndex = 1;
            this.btnImprimirReporte.Text = "Imprimir Reporte";
            this.btnImprimirReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirReporte.UseVisualStyleBackColor = true;
            this.btnImprimirReporte.Click += new System.EventHandler(this.btnImprimirReporte_Click);
            // 
            // frmVehiculosIngresados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 602);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVehiculosIngresados";
            this.Text = "Vehiculos Ingresados";
            this.Load += new System.EventHandler(this.frmVehiculosIngresados_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculosIngresados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnMarca;
        private System.Windows.Forms.RadioButton rbtnPlaca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxMarcas;
        private System.Windows.Forms.Button btnConsultarPorMarca;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dtgVehiculosIngresados;
        private System.Windows.Forms.Button btnImprimirReporte;
    }
}