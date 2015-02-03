namespace PROCON.UTILIDADES
{
    partial class frmTestPuertoSerie
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
            this.oPuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.cboPuerto = new System.Windows.Forms.ComboBox();
            this.txtCadenaEnviar = new System.Windows.Forms.TextBox();
            this.cboBAudios = new System.Windows.Forms.ComboBox();
            this.cboParidad = new System.Windows.Forms.ComboBox();
            this.txtCadenaRecibida = new System.Windows.Forms.TextBox();
            this.rbnParada1 = new System.Windows.Forms.RadioButton();
            this.rbnBits1 = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oPuertoSerial
            // 
            this.oPuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.oPuertoSerial_DataReceived);
            // 
            // cboPuerto
            // 
            this.cboPuerto.FormattingEnabled = true;
            this.cboPuerto.Location = new System.Drawing.Point(305, 108);
            this.cboPuerto.Name = "cboPuerto";
            this.cboPuerto.Size = new System.Drawing.Size(121, 21);
            this.cboPuerto.TabIndex = 0;
            // 
            // txtCadenaEnviar
            // 
            this.txtCadenaEnviar.Location = new System.Drawing.Point(305, 135);
            this.txtCadenaEnviar.Name = "txtCadenaEnviar";
            this.txtCadenaEnviar.Size = new System.Drawing.Size(121, 20);
            this.txtCadenaEnviar.TabIndex = 1;
            // 
            // cboBAudios
            // 
            this.cboBAudios.FormattingEnabled = true;
            this.cboBAudios.Location = new System.Drawing.Point(305, 162);
            this.cboBAudios.Name = "cboBAudios";
            this.cboBAudios.Size = new System.Drawing.Size(121, 21);
            this.cboBAudios.TabIndex = 2;
            // 
            // cboParidad
            // 
            this.cboParidad.FormattingEnabled = true;
            this.cboParidad.Location = new System.Drawing.Point(305, 190);
            this.cboParidad.Name = "cboParidad";
            this.cboParidad.Size = new System.Drawing.Size(121, 21);
            this.cboParidad.TabIndex = 3;
            // 
            // txtCadenaRecibida
            // 
            this.txtCadenaRecibida.Location = new System.Drawing.Point(305, 217);
            this.txtCadenaRecibida.Name = "txtCadenaRecibida";
            this.txtCadenaRecibida.Size = new System.Drawing.Size(100, 20);
            this.txtCadenaRecibida.TabIndex = 4;
            // 
            // rbnParada1
            // 
            this.rbnParada1.AutoSize = true;
            this.rbnParada1.Location = new System.Drawing.Point(305, 258);
            this.rbnParada1.Name = "rbnParada1";
            this.rbnParada1.Size = new System.Drawing.Size(85, 17);
            this.rbnParada1.TabIndex = 5;
            this.rbnParada1.TabStop = true;
            this.rbnParada1.Text = "radioButton1";
            this.rbnParada1.UseVisualStyleBackColor = true;
            // 
            // rbnBits1
            // 
            this.rbnBits1.AutoSize = true;
            this.rbnBits1.Location = new System.Drawing.Point(305, 294);
            this.rbnBits1.Name = "rbnBits1";
            this.rbnBits1.Size = new System.Drawing.Size(85, 17);
            this.rbnBits1.TabIndex = 6;
            this.rbnBits1.TabStop = true;
            this.rbnBits1.Text = "radioButton1";
            this.rbnBits1.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(572, 190);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(572, 219);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 8;
            this.btnConfigurar.Text = "configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(572, 248);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.Text = "btnAbrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Enabled = false;
            this.btnCerrar.Location = new System.Drawing.Point(572, 277);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmTestPuertoSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 507);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.rbnBits1);
            this.Controls.Add(this.rbnParada1);
            this.Controls.Add(this.txtCadenaRecibida);
            this.Controls.Add(this.cboParidad);
            this.Controls.Add(this.cboBAudios);
            this.Controls.Add(this.txtCadenaEnviar);
            this.Controls.Add(this.cboPuerto);
            this.Name = "frmTestPuertoSerie";
            this.Text = "frmTestPuertoSerie";
            this.Load += new System.EventHandler(this.frmTestPuertoSerie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort oPuertoSerial;
        private System.Windows.Forms.ComboBox cboPuerto;
        private System.Windows.Forms.TextBox txtCadenaEnviar;
        private System.Windows.Forms.ComboBox cboBAudios;
        private System.Windows.Forms.ComboBox cboParidad;
        private System.Windows.Forms.TextBox txtCadenaRecibida;
        private System.Windows.Forms.RadioButton rbnParada1;
        private System.Windows.Forms.RadioButton rbnBits1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCerrar;
    }
}