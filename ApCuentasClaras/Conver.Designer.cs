namespace ApCuentasClaras
{
    partial class Conver
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
            this.etGradosC = new System.Windows.Forms.Label();
            this.etGradosF = new System.Windows.Forms.Label();
            this.tbGradosC = new System.Windows.Forms.TextBox();
            this.tbGradosF = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etGradosC
            // 
            this.etGradosC.AutoSize = true;
            this.etGradosC.Location = new System.Drawing.Point(85, 61);
            this.etGradosC.Name = "etGradosC";
            this.etGradosC.Size = new System.Drawing.Size(103, 13);
            this.etGradosC.TabIndex = 0;
            this.etGradosC.Text = "Grados Centigrados:";
            // 
            // etGradosF
            // 
            this.etGradosF.AutoSize = true;
            this.etGradosF.Location = new System.Drawing.Point(85, 106);
            this.etGradosF.Name = "etGradosF";
            this.etGradosF.Size = new System.Drawing.Size(97, 13);
            this.etGradosF.TabIndex = 1;
            this.etGradosF.Text = "Grados Fahrenheit:";
            // 
            // tbGradosC
            // 
            this.tbGradosC.Location = new System.Drawing.Point(262, 53);
            this.tbGradosC.Name = "tbGradosC";
            this.tbGradosC.Size = new System.Drawing.Size(100, 20);
            this.tbGradosC.TabIndex = 2;
            this.tbGradosC.Text = "0.00";
            this.tbGradosC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGradosC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
            this.tbGradosC.Enter += new System.EventHandler(this.CajaTexto_Enter);
            this.tbGradosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGradosC_KeyPress);
            // 
            // tbGradosF
            // 
            this.tbGradosF.Location = new System.Drawing.Point(262, 98);
            this.tbGradosF.Name = "tbGradosF";
            this.tbGradosF.Size = new System.Drawing.Size(100, 20);
            this.tbGradosF.TabIndex = 3;
            this.tbGradosF.Text = "32.00";
            this.tbGradosF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGradosF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CajaTexto_MouseClick);
            this.tbGradosF.Enter += new System.EventHandler(this.CajaTexto_Enter);
            this.tbGradosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGradosF_KeyPress);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(262, 157);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 212);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbGradosF);
            this.Controls.Add(this.tbGradosC);
            this.Controls.Add(this.etGradosF);
            this.Controls.Add(this.etGradosC);
            this.Name = "Form1";
            this.Text = "Conversion de Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etGradosC;
        private System.Windows.Forms.Label etGradosF;
        private System.Windows.Forms.TextBox tbGradosC;
        private System.Windows.Forms.TextBox tbGradosF;
        private System.Windows.Forms.Button btAceptar;
    }
}

