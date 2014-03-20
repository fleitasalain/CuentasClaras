namespace ApCuentasClaras
{
    partial class Menus
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
            this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoGuardarMismoNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoGuardarOtroNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.menuArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHerr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHerrCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHerrConver = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraDeHerramientas = new System.Windows.Forms.ToolStrip();
            this.btAbrir = new System.Windows.Forms.ToolStripButton();
            this.btBarGuardarMismoNombre = new System.Windows.Forms.ToolStripButton();
            this.BarraDeEstado = new System.Windows.Forms.StatusStrip();
            this.etbarestPpal = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraDeMenus.SuspendLayout();
            this.BarraDeHerramientas.SuspendLayout();
            this.BarraDeEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraDeMenus
            // 
            this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuHerr});
            this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
            this.BarraDeMenus.Name = "BarraDeMenus";
            this.BarraDeMenus.Size = new System.Drawing.Size(284, 24);
            this.BarraDeMenus.TabIndex = 1;
            this.BarraDeMenus.Text = "Barra de Menus";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivoAbrir,
            this.menuArchivoGuardar,
            this.menuArchivoSeparador,
            this.menuArchivoSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "&Archivo";
            // 
            // menuArchivoAbrir
            // 
            this.menuArchivoAbrir.Image = global::ApCuentasClaras.Properties.Resources.imagenArchivoAbrir;
            this.menuArchivoAbrir.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuArchivoAbrir.Name = "menuArchivoAbrir";
            this.menuArchivoAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuArchivoAbrir.Size = new System.Drawing.Size(152, 22);
            this.menuArchivoAbrir.Text = "&Abrir";
            this.menuArchivoAbrir.Click += new System.EventHandler(this.menuArchivoAbrir_Click);
            this.menuArchivoAbrir.MouseEnter += new System.EventHandler(this.ArchivoAbrir_MouseEnter);
            this.menuArchivoAbrir.MouseLeave += new System.EventHandler(this.OrdenMenu_MouseLeave);
            // 
            // menuArchivoGuardar
            // 
            this.menuArchivoGuardar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivoGuardarMismoNombre,
            this.menuArchivoGuardarOtroNombre});
            this.menuArchivoGuardar.Image = global::ApCuentasClaras.Properties.Resources.imagenArchivoGuardar;
            this.menuArchivoGuardar.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuArchivoGuardar.Name = "menuArchivoGuardar";
            this.menuArchivoGuardar.Size = new System.Drawing.Size(152, 22);
            this.menuArchivoGuardar.Text = "&Guardar";
            this.menuArchivoGuardar.MouseEnter += new System.EventHandler(this.ArchivoGuardar_MouseEnter);
            // 
            // menuArchivoGuardarMismoNombre
            // 
            this.menuArchivoGuardarMismoNombre.Name = "menuArchivoGuardarMismoNombre";
            this.menuArchivoGuardarMismoNombre.Size = new System.Drawing.Size(158, 22);
            this.menuArchivoGuardarMismoNombre.Text = "Mismo Nombre";
            this.menuArchivoGuardarMismoNombre.Click += new System.EventHandler(this.menuArchivoGuardarMismoNombre_Click);
            this.menuArchivoGuardarMismoNombre.MouseEnter += new System.EventHandler(this.ArchivoGuardarMismoNombre_MouseEnter);
            // 
            // menuArchivoGuardarOtroNombre
            // 
            this.menuArchivoGuardarOtroNombre.Name = "menuArchivoGuardarOtroNombre";
            this.menuArchivoGuardarOtroNombre.Size = new System.Drawing.Size(158, 22);
            this.menuArchivoGuardarOtroNombre.Text = "Otro Nombre";
            this.menuArchivoGuardarOtroNombre.Click += new System.EventHandler(this.menuArchivoGuardarOtroNombre_Click);
            this.menuArchivoGuardarOtroNombre.MouseEnter += new System.EventHandler(this.ArchivoGuardarOtroNombre_MouseEnter);
            // 
            // menuArchivoSeparador
            // 
            this.menuArchivoSeparador.Name = "menuArchivoSeparador";
            this.menuArchivoSeparador.Size = new System.Drawing.Size(149, 6);
            // 
            // menuArchivoSalir
            // 
            this.menuArchivoSalir.Name = "menuArchivoSalir";
            this.menuArchivoSalir.Size = new System.Drawing.Size(152, 22);
            this.menuArchivoSalir.Text = "Salir";
            this.menuArchivoSalir.Click += new System.EventHandler(this.menuArchivoSalir_Click);
            this.menuArchivoSalir.MouseEnter += new System.EventHandler(this.ArchivoSalir_MouseEnter);
            // 
            // menuHerr
            // 
            this.menuHerr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHerrCalculadora,
            this.menuHerrConver});
            this.menuHerr.Name = "menuHerr";
            this.menuHerr.Size = new System.Drawing.Size(90, 20);
            this.menuHerr.Text = "&Herramientas";
            // 
            // menuHerrCalculadora
            // 
            this.menuHerrCalculadora.Name = "menuHerrCalculadora";
            this.menuHerrCalculadora.Size = new System.Drawing.Size(152, 22);
            this.menuHerrCalculadora.Text = "Calculadora";
            this.menuHerrCalculadora.MouseEnter += new System.EventHandler(this.HerrCalculadora_MouseEnter);
            // 
            // menuHerrConver
            // 
            this.menuHerrConver.Name = "menuHerrConver";
            this.menuHerrConver.Size = new System.Drawing.Size(152, 22);
            this.menuHerrConver.Text = "Conver";
            this.menuHerrConver.MouseEnter += new System.EventHandler(this.HerrConver_MouseEnter);
            // 
            // BarraDeHerramientas
            // 
            this.BarraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAbrir,
            this.btBarGuardarMismoNombre});
            this.BarraDeHerramientas.Location = new System.Drawing.Point(0, 24);
            this.BarraDeHerramientas.Name = "BarraDeHerramientas";
            this.BarraDeHerramientas.Size = new System.Drawing.Size(284, 25);
            this.BarraDeHerramientas.TabIndex = 2;
            this.BarraDeHerramientas.Text = "Barra de Herramientas";
            // 
            // btAbrir
            // 
            this.btAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAbrir.Image = global::ApCuentasClaras.Properties.Resources.imagenArchivoAbrir;
            this.btAbrir.ImageTransparentColor = System.Drawing.Color.Black;
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(23, 22);
            this.btAbrir.Text = "btBarAbrir";
            // 
            // btBarGuardarMismoNombre
            // 
            this.btBarGuardarMismoNombre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btBarGuardarMismoNombre.Image = global::ApCuentasClaras.Properties.Resources.imagenArchivoGuardar;
            this.btBarGuardarMismoNombre.ImageTransparentColor = System.Drawing.Color.Black;
            this.btBarGuardarMismoNombre.Name = "btBarGuardarMismoNombre";
            this.btBarGuardarMismoNombre.Size = new System.Drawing.Size(23, 22);
            // 
            // BarraDeEstado
            // 
            this.BarraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etbarestPpal});
            this.BarraDeEstado.Location = new System.Drawing.Point(0, 240);
            this.BarraDeEstado.Name = "BarraDeEstado";
            this.BarraDeEstado.Size = new System.Drawing.Size(284, 22);
            this.BarraDeEstado.TabIndex = 3;
            this.BarraDeEstado.Text = "Barra de Estado";
            // 
            // etbarestPpal
            // 
            this.etbarestPpal.Name = "etbarestPpal";
            this.etbarestPpal.Size = new System.Drawing.Size(32, 17);
            this.etbarestPpal.Text = "Listo";
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BarraDeEstado);
            this.Controls.Add(this.BarraDeHerramientas);
            this.Controls.Add(this.BarraDeMenus);
            this.Name = "Menus";
            this.Text = "Menus";
            this.BarraDeMenus.ResumeLayout(false);
            this.BarraDeMenus.PerformLayout();
            this.BarraDeHerramientas.ResumeLayout(false);
            this.BarraDeHerramientas.PerformLayout();
            this.BarraDeEstado.ResumeLayout(false);
            this.BarraDeEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraDeMenus;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoGuardar;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoGuardarMismoNombre;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoGuardarOtroNombre;
        private System.Windows.Forms.ToolStripSeparator menuArchivoSeparador;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem menuHerr;
        private System.Windows.Forms.ToolStripMenuItem menuHerrCalculadora;
        private System.Windows.Forms.ToolStripMenuItem menuHerrConver;
        private System.Windows.Forms.ToolStrip BarraDeHerramientas;
        private System.Windows.Forms.ToolStripButton btAbrir;
        private System.Windows.Forms.ToolStripButton btBarGuardarMismoNombre;
        private System.Windows.Forms.StatusStrip BarraDeEstado;
        private System.Windows.Forms.ToolStripStatusLabel etbarestPpal;
    }
}