namespace ApCuentasClaras
{
    partial class PantallaDePresentacion
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
            this.lb_Cargando = new System.Windows.Forms.Label();
            this.pb_Cargando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cargando)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Cargando
            // 
            this.lb_Cargando.AutoSize = true;
            this.lb_Cargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cargando.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_Cargando.Location = new System.Drawing.Point(53, 77);
            this.lb_Cargando.Name = "lb_Cargando";
            this.lb_Cargando.Size = new System.Drawing.Size(340, 29);
            this.lb_Cargando.TabIndex = 0;
            this.lb_Cargando.Text = "La aplicación se esta iniciando";
            // 
            // pb_Cargando
            // 
            this.pb_Cargando.Image = global::ApCuentasClaras.Properties.Resources.esperar;
            this.pb_Cargando.Location = new System.Drawing.Point(430, 77);
            this.pb_Cargando.Name = "pb_Cargando";
            this.pb_Cargando.Size = new System.Drawing.Size(43, 34);
            this.pb_Cargando.TabIndex = 1;
            this.pb_Cargando.TabStop = false;
            // 
            // PantallaDePresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 196);
            this.Controls.Add(this.pb_Cargando);
            this.Controls.Add(this.lb_Cargando);
            this.Name = "PantallaDePresentacion";
            this.Text = "PantallaDePresentacion";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Cargando;
        private System.Windows.Forms.PictureBox pb_Cargando;
    }
}