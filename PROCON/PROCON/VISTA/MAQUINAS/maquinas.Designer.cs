namespace PROCON.VISTA.MAQUINAS
{
    partial class maquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maquinas));
            this.lblfkempresa = new System.Windows.Forms.Label();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgListado = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciondesperdicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblfktipo_maquina = new System.Windows.Forms.Label();
            this.NUEVOREGISTRO = new System.Windows.Forms.ToolStripButton();
            this.PRIMERO = new System.Windows.Forms.ToolStripButton();
            this.ANTERIOR = new System.Windows.Forms.ToolStripButton();
            this.SIGUIENTE = new System.Windows.Forms.ToolStripButton();
            this.ULTIMO = new System.Windows.Forms.ToolStripButton();
            this.ELIMINARREFISTRO = new System.Windows.Forms.ToolStripButton();
            this.MODIFICAR = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.BUSCAR = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.totalR = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFktipo_maquina = new System.Windows.Forms.ComboBox();
            this.cmbFkempresa = new System.Windows.Forms.ComboBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtModificando = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabFormulario.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfkempresa
            // 
            this.lblfkempresa.AutoSize = true;
            this.lblfkempresa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfkempresa.ForeColor = System.Drawing.Color.Navy;
            this.lblfkempresa.Location = new System.Drawing.Point(67, 130);
            this.lblfkempresa.Name = "lblfkempresa";
            this.lblfkempresa.Size = new System.Drawing.Size(71, 19);
            this.lblfkempresa.TabIndex = 51;
            this.lblfkempresa.Text = "EMPRESA";
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.txtFiltro);
            this.tabListado.Controls.Add(this.label19);
            this.tabListado.Controls.Add(this.dgListado);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(567, 335);
            this.tabListado.TabIndex = 1;
            this.tabListado.Text = "LISTADO";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.AcceptsReturn = true;
            this.txtFiltro.AcceptsTab = true;
            this.txtFiltro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(106, 6);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(491, 27);
            this.txtFiltro.TabIndex = 41;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Navy;
            this.label19.Location = new System.Drawing.Point(7, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 19);
            this.label19.TabIndex = 42;
            this.label19.Text = "FILTRAR POR";
            // 
            // dgListado
            // 
            this.dgListado.AllowUserToDeleteRows = false;
            this.dgListado.AllowUserToOrderColumns = true;
            this.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.sede,
            this.descripciondesperdicio});
            this.dgListado.Location = new System.Drawing.Point(3, 36);
            this.dgListado.Name = "dgListado";
            this.dgListado.Size = new System.Drawing.Size(564, 296);
            this.dgListado.TabIndex = 0;
            this.dgListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListado_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "CODIGO";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            // 
            // sede
            // 
            this.sede.DataPropertyName = "sede";
            this.sede.HeaderText = "SEDE";
            this.sede.Name = "sede";
            this.sede.Width = 250;
            // 
            // descripciondesperdicio
            // 
            this.descripciondesperdicio.DataPropertyName = "descripciondesperdicio";
            this.descripciondesperdicio.HeaderText = "TIPO MAQUINA";
            this.descripciondesperdicio.Name = "descripciondesperdicio";
            // 
            // lblfktipo_maquina
            // 
            this.lblfktipo_maquina.AutoSize = true;
            this.lblfktipo_maquina.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfktipo_maquina.ForeColor = System.Drawing.Color.Navy;
            this.lblfktipo_maquina.Location = new System.Drawing.Point(6, 163);
            this.lblfktipo_maquina.Name = "lblfktipo_maquina";
            this.lblfktipo_maquina.Size = new System.Drawing.Size(132, 19);
            this.lblfktipo_maquina.TabIndex = 53;
            this.lblfktipo_maquina.Text = "TIPO DE MAQUINA";
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
            // PRIMERO
            // 
            this.PRIMERO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PRIMERO.Image = ((System.Drawing.Image)(resources.GetObject("PRIMERO.Image")));
            this.PRIMERO.Name = "PRIMERO";
            this.PRIMERO.RightToLeftAutoMirrorImage = true;
            this.PRIMERO.Size = new System.Drawing.Size(34, 34);
            this.PRIMERO.Text = "Mover primero";
            // 
            // ANTERIOR
            // 
            this.ANTERIOR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ANTERIOR.Image = ((System.Drawing.Image)(resources.GetObject("ANTERIOR.Image")));
            this.ANTERIOR.Name = "ANTERIOR";
            this.ANTERIOR.RightToLeftAutoMirrorImage = true;
            this.ANTERIOR.Size = new System.Drawing.Size(34, 34);
            this.ANTERIOR.Text = "Mover anterior";
            // 
            // SIGUIENTE
            // 
            this.SIGUIENTE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SIGUIENTE.Image = ((System.Drawing.Image)(resources.GetObject("SIGUIENTE.Image")));
            this.SIGUIENTE.Name = "SIGUIENTE";
            this.SIGUIENTE.RightToLeftAutoMirrorImage = true;
            this.SIGUIENTE.Size = new System.Drawing.Size(34, 34);
            this.SIGUIENTE.Text = "Mover siguiente";
            // 
            // ULTIMO
            // 
            this.ULTIMO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ULTIMO.Image = ((System.Drawing.Image)(resources.GetObject("ULTIMO.Image")));
            this.ULTIMO.Name = "ULTIMO";
            this.ULTIMO.RightToLeftAutoMirrorImage = true;
            this.ULTIMO.Size = new System.Drawing.Size(34, 34);
            this.ULTIMO.Text = "Mover último";
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
            // MODIFICAR
            // 
            this.MODIFICAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MODIFICAR.Image = ((System.Drawing.Image)(resources.GetObject("MODIFICAR.Image")));
            this.MODIFICAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MODIFICAR.Name = "MODIFICAR";
            this.MODIFICAR.Size = new System.Drawing.Size(34, 34);
            this.MODIFICAR.Text = "toolStripButton1";
            this.MODIFICAR.ToolTipText = "MODIFICAR ESTE REGISTRO";
            this.MODIFICAR.Click += new System.EventHandler(this.MODIFICAR_Click);
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
            // BUSCAR
            // 
            this.BUSCAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("BUSCAR.Image")));
            this.BUSCAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(34, 34);
            this.BUSCAR.Text = "toolStripSplitButton1";
            this.BUSCAR.ToolTipText = "BUSCAR UN REGISTRO";
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsReturn = true;
            this.txtDescripcion.AcceptsTab = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(144, 89);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(340, 27);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(0, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(607, 39);
            this.label18.TabIndex = 49;
            this.label18.Text = "Control de Maquinas";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.NUEVOREGISTRO;
            this.bindingNavigator1.CountItem = this.totalR;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PRIMERO,
            this.ANTERIOR,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.totalR,
            this.bindingNavigatorSeparator1,
            this.SIGUIENTE,
            this.ULTIMO,
            this.bindingNavigatorSeparator2,
            this.NUEVOREGISTRO,
            this.ELIMINARREFISTRO,
            this.MODIFICAR,
            this.btnGuardar,
            this.toolStripSeparator1,
            this.BUSCAR,
            this.toolStripSeparator2,
            this.salir});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.PRIMERO;
            this.bindingNavigator1.MoveLastItem = this.ULTIMO;
            this.bindingNavigator1.MoveNextItem = this.SIGUIENTE;
            this.bindingNavigator1.MovePreviousItem = this.ANTERIOR;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(607, 37);
            this.bindingNavigator1.TabIndex = 50;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.TextChanged += new System.EventHandler(this.bindingNavigatorPositionItem_TextChanged);
            // 
            // totalR
            // 
            this.totalR.Name = "totalR";
            this.totalR.Size = new System.Drawing.Size(37, 34);
            this.totalR.Text = "de {0}";
            this.totalR.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.bindingNavigatorPositionItem_TextChanged);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
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
            // tabFormulario
            // 
            this.tabFormulario.Controls.Add(this.tabDatos);
            this.tabFormulario.Controls.Add(this.tabListado);
            this.tabFormulario.Location = new System.Drawing.Point(5, 93);
            this.tabFormulario.Name = "tabFormulario";
            this.tabFormulario.SelectedIndex = 0;
            this.tabFormulario.Size = new System.Drawing.Size(575, 361);
            this.tabFormulario.TabIndex = 51;
            // 
            // tabDatos
            // 
            this.tabDatos.BackColor = System.Drawing.SystemColors.Control;
            this.tabDatos.Controls.Add(this.groupBox1);
            this.tabDatos.Location = new System.Drawing.Point(4, 22);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatos.Size = new System.Drawing.Size(567, 335);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.Text = "DATOS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cmbFktipo_maquina);
            this.groupBox1.Controls.Add(this.cmbFkempresa);
            this.groupBox1.Controls.Add(this.lblfktipo_maquina);
            this.groupBox1.Controls.Add(this.lblfkempresa);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lbldescripcion);
            this.groupBox1.Controls.Add(this.txtModificando);
            this.groupBox1.Controls.Add(this.txtNuevo);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lblnumero);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 319);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LA MAQUINA";
            // 
            // cmbFktipo_maquina
            // 
            this.cmbFktipo_maquina.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFktipo_maquina.FormattingEnabled = true;
            this.cmbFktipo_maquina.Location = new System.Drawing.Point(144, 155);
            this.cmbFktipo_maquina.Name = "cmbFktipo_maquina";
            this.cmbFktipo_maquina.Size = new System.Drawing.Size(110, 26);
            this.cmbFktipo_maquina.TabIndex = 64;
            // 
            // cmbFkempresa
            // 
            this.cmbFkempresa.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFkempresa.FormattingEnabled = true;
            this.cmbFkempresa.Location = new System.Drawing.Point(144, 123);
            this.cmbFkempresa.Name = "cmbFkempresa";
            this.cmbFkempresa.Size = new System.Drawing.Size(110, 26);
            this.cmbFkempresa.TabIndex = 63;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.ForeColor = System.Drawing.Color.Navy;
            this.lbldescripcion.Location = new System.Drawing.Point(40, 97);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(98, 19);
            this.lbldescripcion.TabIndex = 49;
            this.lbldescripcion.Text = "DESCRIPCION";
            // 
            // txtModificando
            // 
            this.txtModificando.Location = new System.Drawing.Point(37, 30);
            this.txtModificando.Name = "txtModificando";
            this.txtModificando.Size = new System.Drawing.Size(19, 27);
            this.txtModificando.TabIndex = 47;
            this.txtModificando.Text = "0";
            this.txtModificando.Visible = false;
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(12, 30);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(19, 27);
            this.txtNuevo.TabIndex = 46;
            this.txtNuevo.Text = "0";
            this.txtNuevo.Visible = false;
            // 
            // txtId
            // 
            this.txtId.AcceptsReturn = true;
            this.txtId.AcceptsTab = true;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(144, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(110, 27);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "CODIGO";
            // 
            // txtNumero
            // 
            this.txtNumero.AcceptsReturn = true;
            this.txtNumero.AcceptsTab = true;
            this.txtNumero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(144, 59);
            this.txtNumero.MaxLength = 100;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(110, 27);
            this.txtNumero.TabIndex = 1;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.Color.Navy;
            this.lblnumero.Location = new System.Drawing.Point(68, 67);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(70, 19);
            this.lblnumero.TabIndex = 39;
            this.lblnumero.Text = "NUMERO";
            // 
            // maquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 460);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabFormulario);
            this.Name = "maquinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "maquinas";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabFormulario.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfkempresa;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgListado;
        private System.Windows.Forms.Label lblfktipo_maquina;
        private System.Windows.Forms.ToolStripButton NUEVOREGISTRO;
        private System.Windows.Forms.ToolStripButton PRIMERO;
        private System.Windows.Forms.ToolStripButton ANTERIOR;
        private System.Windows.Forms.ToolStripButton SIGUIENTE;
        private System.Windows.Forms.ToolStripButton ULTIMO;
        private System.Windows.Forms.ToolStripButton ELIMINARREFISTRO;
        private System.Windows.Forms.ToolStripButton MODIFICAR;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton BUSCAR;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel totalR;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.TabControl tabFormulario;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtModificando;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.ComboBox cmbFktipo_maquina;
        private System.Windows.Forms.ComboBox cmbFkempresa;
        private System.Windows.Forms.DataGridViewLinkColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciondesperdicio;
    }
}