namespace ProyEst_GUI
{
    partial class frmNuevoCliente
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxPuesto = new System.Windows.Forms.ComboBox();
            this.cbxDir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkAbonado = new System.Windows.Forms.CheckBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtApellidoMaterno);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.cbxPuesto);
            this.grpDatos.Controls.Add(this.cbxDir);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.txtDir);
            this.grpDatos.Controls.Add(this.txtDni);
            this.grpDatos.Controls.Add(this.txtTel);
            this.grpDatos.Controls.Add(this.txtEmail);
            this.grpDatos.Controls.Add(this.chkAbonado);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.txtApellidoPaterno);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(16, 15);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDatos.Size = new System.Drawing.Size(903, 662);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(611, 106);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(279, 27);
            this.txtApellidoMaterno.TabIndex = 2;
            this.txtApellidoMaterno.Validating += new System.ComponentModel.CancelEventHandler(this.control_Validating);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(446, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Apellido Materno:";
            // 
            // cbxPuesto
            // 
            this.cbxPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPuesto.Enabled = false;
            this.cbxPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPuesto.Items.AddRange(new object[] {
            "Av.",
            "Jr.",
            "Psj.",
            "Calle"});
            this.cbxPuesto.Location = new System.Drawing.Point(133, 488);
            this.cbxPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPuesto.Name = "cbxPuesto";
            this.cbxPuesto.Size = new System.Drawing.Size(165, 28);
            this.cbxPuesto.TabIndex = 9;
            this.cbxPuesto.Validating += new System.ComponentModel.CancelEventHandler(this.cbx_Validating);
            // 
            // cbxDir
            // 
            this.cbxDir.Enabled = false;
            this.cbxDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDir.Items.AddRange(new object[] {
            "Av.",
            "Jr.",
            "Psj.",
            "Calle"});
            this.cbxDir.Location = new System.Drawing.Point(133, 292);
            this.cbxDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDir.Name = "cbxDir";
            this.cbxDir.Size = new System.Drawing.Size(99, 28);
            this.cbxDir.TabIndex = 5;
            this.cbxDir.Validating += new System.ComponentModel.CancelEventHandler(this.cbx_Validating);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 492);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Puesto:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "E-Mail:";
            // 
            // txtDir
            // 
            this.txtDir.Enabled = false;
            this.txtDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.Location = new System.Drawing.Point(240, 292);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(261, 27);
            this.txtDir.TabIndex = 6;
            this.txtDir.Validating += new System.ComponentModel.CancelEventHandler(this.control_Validating);
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(133, 418);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.ShortcutsEnabled = false;
            this.txtDni.Size = new System.Drawing.Size(280, 27);
            this.txtDni.TabIndex = 8;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtDni.Validating += new System.ComponentModel.CancelEventHandler(this.control_Validating);
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(133, 354);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.MaxLength = 9;
            this.txtTel.Name = "txtTel";
            this.txtTel.ShortcutsEnabled = false;
            this.txtTel.Size = new System.Drawing.Size(280, 27);
            this.txtTel.TabIndex = 7;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtTel.Validating += new System.ComponentModel.CancelEventHandler(this.control_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(133, 231);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 27);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.control_Validating);
            // 
            // chkAbonado
            // 
            this.chkAbonado.AutoSize = true;
            this.chkAbonado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAbonado.Location = new System.Drawing.Point(23, 169);
            this.chkAbonado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAbonado.Name = "chkAbonado";
            this.chkAbonado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAbonado.Size = new System.Drawing.Size(110, 28);
            this.chkAbonado.TabIndex = 3;
            this.chkAbonado.Text = "Abonado";
            this.chkAbonado.UseVisualStyleBackColor = true;
            this.chkAbonado.CheckedChanged += new System.EventHandler(this.chkAbonado_CheckedChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(602, 604);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(138, 50);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(183, 109);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(255, 27);
            this.txtApellidoPaterno.TabIndex = 1;
            this.txtApellidoPaterno.Validating += new System.ComponentModel.CancelEventHandler(this.control_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(133, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.control_Validating);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Apellido Paterno:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(757, 604);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 50);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 690);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Cliente";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.CheckBox chkAbonado;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtApellidoPaterno;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxDir;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtDir;
        internal System.Windows.Forms.TextBox txtDni;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbxPuesto;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtApellidoMaterno;
        internal System.Windows.Forms.Label label8;
    }
}