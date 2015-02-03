namespace PROCON.VISTA.DESPERDICIO
{
    partial class desperdicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(desperdicio));
            this.label18 = new System.Windows.Forms.Label();
            this.dgListado = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkorden_produccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFkoperador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFkmaquina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFkorden_produccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.cmbfktipo_desperdicio = new System.Windows.Forms.ComboBox();
            this.lblfkempresa = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.NUEVOREGISTRO = new System.Windows.Forms.ToolStripButton();
            this.ELIMINARREFISTRO = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BUSCAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar2 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.printRotulo = new System.Drawing.Printing.PrintDocument();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1132, 39);
            this.label18.TabIndex = 42;
            this.label18.Text = "REGISTRO DE DESPERDICIO";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgListado
            // 
            this.dgListado.AllowUserToDeleteRows = false;
            this.dgListado.AllowUserToOrderColumns = true;
            this.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.fecha2,
            this.fkorden_produccion,
            this.maquina,
            this.nombreOperador,
            this.cantidad});
            this.dgListado.Location = new System.Drawing.Point(12, 332);
            this.dgListado.Name = "dgListado";
            this.dgListado.Size = new System.Drawing.Size(1108, 362);
            this.dgListado.TabIndex = 83;
            this.dgListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListado_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "CODIGO";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "TIPO";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 150;
            // 
            // fecha2
            // 
            this.fecha2.DataPropertyName = "fecha";
            this.fecha2.HeaderText = "FECHA";
            this.fecha2.Name = "fecha2";
            this.fecha2.Width = 150;
            // 
            // fkorden_produccion
            // 
            this.fkorden_produccion.DataPropertyName = "fkorden_produccion";
            this.fkorden_produccion.HeaderText = "ORDEN";
            this.fkorden_produccion.Name = "fkorden_produccion";
            // 
            // maquina
            // 
            this.maquina.DataPropertyName = "maquina";
            this.maquina.HeaderText = "MAQUINA";
            this.maquina.Name = "maquina";
            // 
            // nombreOperador
            // 
            this.nombreOperador.DataPropertyName = "nombreOperador";
            this.nombreOperador.HeaderText = "OPERADOR";
            this.nombreOperador.Name = "nombreOperador";
            this.nombreOperador.Width = 300;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 150;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AcceptsReturn = true;
            this.txtCantidad.AcceptsTab = true;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(191, 292);
            this.txtCantidad.MaxLength = 100;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 27);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(107, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 97;
            this.label5.Text = "CANTIDAD";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Enabled = false;
            this.txtObservacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(191, 247);
            this.txtObservacion.MaxLength = 100;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(349, 42);
            this.txtObservacion.TabIndex = 5;
            this.txtObservacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(81, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 95;
            this.label4.Text = "OBSERVACION";
            // 
            // cmbFkoperador
            // 
            this.cmbFkoperador.Enabled = false;
            this.cmbFkoperador.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFkoperador.FormattingEnabled = true;
            this.cmbFkoperador.Location = new System.Drawing.Point(191, 218);
            this.cmbFkoperador.Name = "cmbFkoperador";
            this.cmbFkoperador.Size = new System.Drawing.Size(349, 26);
            this.cmbFkoperador.TabIndex = 4;
            this.cmbFkoperador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(101, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 92;
            this.label3.Text = "OPERADOR";
            // 
            // cmbFkmaquina
            // 
            this.cmbFkmaquina.Enabled = false;
            this.cmbFkmaquina.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFkmaquina.FormattingEnabled = true;
            this.cmbFkmaquina.Location = new System.Drawing.Point(191, 190);
            this.cmbFkmaquina.Name = "cmbFkmaquina";
            this.cmbFkmaquina.Size = new System.Drawing.Size(349, 26);
            this.cmbFkmaquina.TabIndex = 3;
            this.cmbFkmaquina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(110, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 90;
            this.label2.Text = "MAQUINA";
            // 
            // txtFkorden_produccion
            // 
            this.txtFkorden_produccion.AcceptsReturn = true;
            this.txtFkorden_produccion.AcceptsTab = true;
            this.txtFkorden_produccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFkorden_produccion.Location = new System.Drawing.Point(191, 160);
            this.txtFkorden_produccion.MaxLength = 100;
            this.txtFkorden_produccion.Name = "txtFkorden_produccion";
            this.txtFkorden_produccion.Size = new System.Drawing.Size(132, 27);
            this.txtFkorden_produccion.TabIndex = 2;
            this.txtFkorden_produccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(11, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 89;
            this.label1.Text = "ORDEN DE PRODUCCION";
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(191, 138);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(132, 20);
            this.fecha.TabIndex = 1;
            this.fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // cmbfktipo_desperdicio
            // 
            this.cmbfktipo_desperdicio.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfktipo_desperdicio.FormattingEnabled = true;
            this.cmbfktipo_desperdicio.Location = new System.Drawing.Point(191, 110);
            this.cmbfktipo_desperdicio.Name = "cmbfktipo_desperdicio";
            this.cmbfktipo_desperdicio.Size = new System.Drawing.Size(239, 26);
            this.cmbfktipo_desperdicio.TabIndex = 0;
            this.cmbfktipo_desperdicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            this.cmbfktipo_desperdicio.Leave += new System.EventHandler(this.cmbfktipo_desperdicio_Leave);
            // 
            // lblfkempresa
            // 
            this.lblfkempresa.AutoSize = true;
            this.lblfkempresa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfkempresa.ForeColor = System.Drawing.Color.Navy;
            this.lblfkempresa.Location = new System.Drawing.Point(31, 114);
            this.lblfkempresa.Name = "lblfkempresa";
            this.lblfkempresa.Size = new System.Drawing.Size(154, 19);
            this.lblfkempresa.TabIndex = 85;
            this.lblfkempresa.Text = "TIPO DE DESPERDICIO";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.Color.Navy;
            this.lblnumero.Location = new System.Drawing.Point(44, 138);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(141, 19);
            this.lblnumero.TabIndex = 84;
            this.lblnumero.Text = "FECHA DE PROCESO";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NUEVOREGISTRO,
            this.ELIMINARREFISTRO,
            this.btnGuardar,
            this.toolStripSeparator1,
            this.BUSCAR,
            this.toolStripSeparator2,
            this.salir});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 39);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(1132, 37);
            this.bindingNavigator1.TabIndex = 98;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // NUEVOREGISTRO
            // 
            this.NUEVOREGISTRO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NUEVOREGISTRO.Image = ((System.Drawing.Image)(resources.GetObject("NUEVOREGISTRO.Image")));
            this.NUEVOREGISTRO.Name = "NUEVOREGISTRO";
            this.NUEVOREGISTRO.RightToLeftAutoMirrorImage = true;
            this.NUEVOREGISTRO.Size = new System.Drawing.Size(34, 34);
            this.NUEVOREGISTRO.Text = "Agregar nuevo";
            this.NUEVOREGISTRO.Click += new System.EventHandler(this.NUEVOREGISTRO_Click);
            // 
            // ELIMINARREFISTRO
            // 
            this.ELIMINARREFISTRO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ELIMINARREFISTRO.Enabled = false;
            this.ELIMINARREFISTRO.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINARREFISTRO.Image")));
            this.ELIMINARREFISTRO.Name = "ELIMINARREFISTRO";
            this.ELIMINARREFISTRO.RightToLeftAutoMirrorImage = true;
            this.ELIMINARREFISTRO.Size = new System.Drawing.Size(34, 34);
            this.ELIMINARREFISTRO.Text = "Eliminar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(34, 34);
            this.btnGuardar.Text = "GUARDAR DATOS";
            this.btnGuardar.ToolTipText = "GUARDAR CAMBIOS EN REGISTRO";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // BUSCAR
            // 
            this.BUSCAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BUSCAR.Enabled = false;
            this.BUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("BUSCAR.Image")));
            this.BUSCAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(34, 34);
            this.BUSCAR.Text = "toolStripSplitButton1";
            this.BUSCAR.ToolTipText = "BUSCAR UN REGISTRO";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // salir
            // 
            this.salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salir.Image = global::PROCON.Properties.Resources.salir;
            this.salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(34, 34);
            this.salir.Text = "toolStripButton1";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Location = new System.Drawing.Point(329, 292);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar2.TabIndex = 7;
            this.btnGuardar2.Text = "...";
            this.btnGuardar2.UseVisualStyleBackColor = true;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // txtId
            // 
            this.txtId.AcceptsReturn = true;
            this.txtId.AcceptsTab = true;
            this.txtId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(191, 81);
            this.txtId.MaxLength = 100;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(132, 27);
            this.txtId.TabIndex = 99;
            this.txtId.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(162, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 19);
            this.label6.TabIndex = 100;
            this.label6.Text = "ID";
            // 
            // printRotulo
            // 
            this.printRotulo.DocumentName = "";
            this.printRotulo.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printRotulo_EndPrint);
            this.printRotulo.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printRotulo_EndPrint);
            this.printRotulo.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printRotulo_PrintPage);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // desperdicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 700);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardar2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFkoperador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFkmaquina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFkorden_produccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.cmbfktipo_desperdicio);
            this.Controls.Add(this.lblfkempresa);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.dgListado);
            this.Controls.Add(this.label18);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "desperdicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "desperdicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgListado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFkoperador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFkmaquina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFkorden_produccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox cmbfktipo_desperdicio;
        private System.Windows.Forms.Label lblfkempresa;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton NUEVOREGISTRO;
        private System.Windows.Forms.ToolStripButton ELIMINARREFISTRO;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BUSCAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.Button btnGuardar2;
        private System.Windows.Forms.DataGridViewLinkColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkorden_produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Drawing.Printing.PrintDocument printRotulo;
        private System.IO.Ports.SerialPort serialPort1;
    }
}