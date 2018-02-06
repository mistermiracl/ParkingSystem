namespace ProyEst_GUI.Estacionamiento
{
    partial class frmNuevoPuesto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxBloque = new System.Windows.Forms.ComboBox();
            this.nudNivel = new System.Windows.Forms.NumericUpDown();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bloque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel";
            // 
            // cbxBloque
            // 
            this.cbxBloque.FormattingEnabled = true;
            this.cbxBloque.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbxBloque.Location = new System.Drawing.Point(116, 101);
            this.cbxBloque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxBloque.Name = "cbxBloque";
            this.cbxBloque.Size = new System.Drawing.Size(159, 24);
            this.cbxBloque.TabIndex = 3;
            // 
            // nudNivel
            // 
            this.nudNivel.Location = new System.Drawing.Point(405, 102);
            this.nudNivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudNivel.Name = "nudNivel";
            this.nudNivel.Size = new System.Drawing.Size(160, 22);
            this.nudNivel.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Location = new System.Drawing.Point(116, 36);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(160, 32);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "lblCodigo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(465, 172);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmNuevoPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 215);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.nudNivel);
            this.Controls.Add(this.cbxBloque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNuevoPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Puesto";
            this.Load += new System.EventHandler(this.frmNuevoPuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxBloque;
        private System.Windows.Forms.NumericUpDown nudNivel;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAceptar;
    }
}