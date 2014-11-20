namespace PROCON.VISTA.USUARIO
{
    partial class operador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(operador));
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFkSede = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModificando = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.txtTelefonoOperador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdOperador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreOperador = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgListado = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.NUEVOREGISTRO = new System.Windows.Forms.ToolStripButton();
            this.totalR = new System.Windows.Forms.ToolStripLabel();
            this.PRIMERO = new System.Windows.Forms.ToolStripButton();
            this.ANTERIOR = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SIGUIENTE = new System.Windows.Forms.ToolStripButton();
            this.ULTIMO = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ELIMINARREFISTRO = new System.Windows.Forms.ToolStripButton();
            this.MODIFICAR = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BUSCAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.label18 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idOperador = new System.Windows.Forms.DataGridViewLinkColumn();
            this.nombreOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFormulario.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormulario
            // 
            this.tabFormulario.Controls.Add(this.tabDatos);
            this.tabFormulario.Controls.Add(this.tabListado);
            this.tabFormulario.Location = new System.Drawing.Point(2, 80);
            this.tabFormulario.Name = "tabFormulario";
            this.tabFormulario.SelectedIndex = 0;
            this.tabFormulario.Size = new System.Drawing.Size(878, 381);
            this.tabFormulario.TabIndex = 43;
            // 
            // tabDatos
            // 
            this.tabDatos.BackColor = System.Drawing.SystemColors.Control;
            this.tabDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabDatos.Controls.Add(this.groupBox2);
            this.tabDatos.Controls.Add(this.groupBox1);
            this.tabDatos.Location = new System.Drawing.Point(4, 22);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatos.Size = new System.Drawing.Size(870, 355);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.Text = "DATOS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.treeView2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(453, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 319);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TIPO DE OPERADOR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(257, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "DISPONIBLES";
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView2.ForeColor = System.Drawing.Color.Gray;
            this.treeView2.HotTracking = true;
            this.treeView2.Location = new System.Drawing.Point(223, 59);
            this.treeView2.Name = "treeView2";
            this.treeView2.Scrollable = false;
            this.treeView2.Size = new System.Drawing.Size(170, 244);
            this.treeView2.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(35, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 19);
            this.label9.TabIndex = 41;
            this.label9.Text = "TIPOS SELECCIONADOS";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.Gray;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(30, 59);
            this.treeView1.Name = "treeView1";
            this.treeView1.Scrollable = false;
            this.treeView1.Size = new System.Drawing.Size(170, 244);
            this.treeView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cmbEstatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbFkSede);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtModificando);
            this.groupBox1.Controls.Add(this.txtNuevo);
            this.groupBox1.Controls.Add(this.txtTelefonoOperador);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdOperador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreOperador);
            this.groupBox1.Controls.Add(this.lbldireccion);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 319);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL OPERADOR";
            // 
            // cmbFkSede
            // 
            this.cmbFkSede.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFkSede.FormattingEnabled = true;
            this.cmbFkSede.Location = new System.Drawing.Point(146, 123);
            this.cmbFkSede.Name = "cmbFkSede";
            this.cmbFkSede.Size = new System.Drawing.Size(284, 26);
            this.cmbFkSede.TabIndex = 10;
            this.cmbFkSede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(102, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "SEDE";
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
            // txtTelefonoOperador
            // 
            this.txtTelefonoOperador.AcceptsReturn = true;
            this.txtTelefonoOperador.AcceptsTab = true;
            this.txtTelefonoOperador.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoOperador.Location = new System.Drawing.Point(146, 90);
            this.txtTelefonoOperador.MaxLength = 11;
            this.txtTelefonoOperador.Name = "txtTelefonoOperador";
            this.txtTelefonoOperador.Size = new System.Drawing.Size(284, 27);
            this.txtTelefonoOperador.TabIndex = 2;
            this.txtTelefonoOperador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(72, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "CELULAR";
            // 
            // txtIdOperador
            // 
            this.txtIdOperador.AcceptsReturn = true;
            this.txtIdOperador.AcceptsTab = true;
            this.txtIdOperador.Enabled = false;
            this.txtIdOperador.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdOperador.Location = new System.Drawing.Point(146, 28);
            this.txtIdOperador.Name = "txtIdOperador";
            this.txtIdOperador.Size = new System.Drawing.Size(191, 27);
            this.txtIdOperador.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "CODIGO";
            // 
            // txtNombreOperador
            // 
            this.txtNombreOperador.AcceptsReturn = true;
            this.txtNombreOperador.AcceptsTab = true;
            this.txtNombreOperador.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreOperador.Location = new System.Drawing.Point(146, 59);
            this.txtNombreOperador.MaxLength = 50;
            this.txtNombreOperador.Name = "txtNombreOperador";
            this.txtNombreOperador.Size = new System.Drawing.Size(284, 27);
            this.txtNombreOperador.TabIndex = 1;
            this.txtNombreOperador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.ForeColor = System.Drawing.Color.Navy;
            this.lbldireccion.Location = new System.Drawing.Point(67, 67);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(73, 19);
            this.lbldireccion.TabIndex = 39;
            this.lbldireccion.Text = "NOMBRE ";
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.txtFiltro);
            this.tabListado.Controls.Add(this.label19);
            this.tabListado.Controls.Add(this.dgListado);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(870, 355);
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
            this.idOperador,
            this.nombreOperador,
            this.telefonoOperador});
            this.dgListado.Location = new System.Drawing.Point(6, 40);
            this.dgListado.Name = "dgListado";
            this.dgListado.Size = new System.Drawing.Size(858, 312);
            this.dgListado.TabIndex = 0;
            this.dgListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListado_CellContentClick);
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 39);
            this.bindingNavigator1.MoveFirstItem = this.PRIMERO;
            this.bindingNavigator1.MoveLastItem = this.ULTIMO;
            this.bindingNavigator1.MoveNextItem = this.SIGUIENTE;
            this.bindingNavigator1.MovePreviousItem = this.ANTERIOR;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(892, 37);
            this.bindingNavigator1.TabIndex = 42;
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
            // totalR
            // 
            this.totalR.Name = "totalR";
            this.totalR.Size = new System.Drawing.Size(37, 34);
            this.totalR.Text = "de {0}";
            this.totalR.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 37);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
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
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(892, 39);
            this.label18.TabIndex = 41;
            this.label18.Text = "Control de Operadores";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Location = new System.Drawing.Point(146, 155);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(191, 26);
            this.cmbEstatus.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(81, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "ESTATUS";
            // 
            // idOperador
            // 
            this.idOperador.DataPropertyName = "idOperador";
            this.idOperador.HeaderText = "CODIGO";
            this.idOperador.Name = "idOperador";
            this.idOperador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombreOperador
            // 
            this.nombreOperador.DataPropertyName = "nombreOperador";
            this.nombreOperador.HeaderText = "NOMBRES";
            this.nombreOperador.Name = "nombreOperador";
            this.nombreOperador.Width = 300;
            // 
            // telefonoOperador
            // 
            this.telefonoOperador.DataPropertyName = "telefonoOperador";
            this.telefonoOperador.HeaderText = "TELEFONO";
            this.telefonoOperador.Name = "telefonoOperador";
            this.telefonoOperador.Width = 200;
            // 
            // operador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 478);
            this.Controls.Add(this.tabFormulario);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label18);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "operador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "operador";
            this.tabFormulario.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabFormulario;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFkSede;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModificando;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.TextBox txtTelefonoOperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdOperador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreOperador;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgListado;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton NUEVOREGISTRO;
        private System.Windows.Forms.ToolStripLabel totalR;
        private System.Windows.Forms.ToolStripButton PRIMERO;
        private System.Windows.Forms.ToolStripButton ANTERIOR;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton SIGUIENTE;
        private System.Windows.Forms.ToolStripButton ULTIMO;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ELIMINARREFISTRO;
        private System.Windows.Forms.ToolStripButton MODIFICAR;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BUSCAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton salir;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewLinkColumn idOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoOperador;
    }
}