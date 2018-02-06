namespace ProyEst_GUI.Consultas
{
    partial class TotalIngresos
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
            this.dtgRegistros = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRegistros
            // 
            this.dtgRegistros.AlternatingBackColor = System.Drawing.Color.Gainsboro;
            this.dtgRegistros.BackColor = System.Drawing.Color.Silver;
            this.dtgRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtgRegistros.CaptionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dtgRegistros.CaptionFont = new System.Drawing.Font("Tahoma", 8F);
            this.dtgRegistros.CaptionForeColor = System.Drawing.Color.White;
            this.dtgRegistros.DataMember = "";
            this.dtgRegistros.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgRegistros.FlatMode = true;
            this.dtgRegistros.ForeColor = System.Drawing.Color.Black;
            this.dtgRegistros.GridLineColor = System.Drawing.Color.White;
            this.dtgRegistros.HeaderBackColor = System.Drawing.Color.DarkGray;
            this.dtgRegistros.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgRegistros.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.dtgRegistros.Location = new System.Drawing.Point(0, 0);
            this.dtgRegistros.Name = "dtgRegistros";
            this.dtgRegistros.ParentRowsBackColor = System.Drawing.Color.Black;
            this.dtgRegistros.ParentRowsForeColor = System.Drawing.Color.White;
            this.dtgRegistros.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dtgRegistros.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRegistros.Size = new System.Drawing.Size(1239, 515);
            this.dtgRegistros.TabIndex = 0;
            // 
            // TotalIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 674);
            this.Controls.Add(this.dtgRegistros);
            this.Name = "TotalIngresos";
            this.Text = "TotalIngresos";
            this.Load += new System.EventHandler(this.TotalIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dtgRegistros;
    }
}