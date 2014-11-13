namespace PROCON.VISTA.EMPRESA
{
    partial class empresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empresas));
            this.txtFiltro = new System.Windows.Forms.TextBox();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRif = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRif = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtModificando = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.lblsede = new System.Windows.Forms.Label();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.dgListado = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabFormulario.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
            this.SuspendLayout();
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
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
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
            this.bindingNavigator1.Size = new System.Drawing.Size(603, 37);
            this.bindingNavigator1.TabIndex = 47;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.ico");
            this.imageList1.Images.SetKeyName(1, "1.ico");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.ico");
            this.imageList1.Images.SetKeyName(4, "4.ico");
            this.imageList1.Images.SetKeyName(5, "5.ico");
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
            // tabFormulario
            // 
            this.tabFormulario.Controls.Add(this.tabDatos);
            this.tabFormulario.Controls.Add(this.tabListado);
            this.tabFormulario.Location = new System.Drawing.Point(5, 87);
            this.tabFormulario.Name = "tabFormulario";
            this.tabFormulario.SelectedIndex = 0;
            this.tabFormulario.Size = new System.Drawing.Size(575, 361);
            this.tabFormulario.TabIndex = 48;
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
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtRif);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblRif);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtModificando);
            this.groupBox1.Controls.Add(this.txtNuevo);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSede);
            this.groupBox1.Controls.Add(this.lblsede);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 319);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LA EMPRESA";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AcceptsReturn = true;
            this.txtCorreo.AcceptsTab = true;
            this.txtCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(108, 228);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(369, 27);
            this.txtCorreo.TabIndex = 64;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AcceptsReturn = true;
            this.txtTelefono.AcceptsTab = true;
            this.txtTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(108, 194);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(110, 27);
            this.txtTelefono.TabIndex = 63;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // txtDireccion
            // 
            this.txtDireccion.AcceptsReturn = true;
            this.txtDireccion.AcceptsTab = true;
            this.txtDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(108, 158);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(369, 27);
            this.txtDireccion.TabIndex = 62;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // txtRif
            // 
            this.txtRif.AcceptsReturn = true;
            this.txtRif.AcceptsTab = true;
            this.txtRif.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRif.Location = new System.Drawing.Point(108, 122);
            this.txtRif.MaxLength = 30;
            this.txtRif.Name = "txtRif";
            this.txtRif.Size = new System.Drawing.Size(110, 27);
            this.txtRif.TabIndex = 61;
            this.txtRif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Navy;
            this.lblCorreo.Location = new System.Drawing.Point(27, 231);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 19);
            this.lblCorreo.TabIndex = 57;
            this.lblCorreo.Text = "CORREO";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Navy;
            this.lblTelefono.Location = new System.Drawing.Point(20, 198);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 19);
            this.lblTelefono.TabIndex = 56;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Navy;
            this.lblDireccion.Location = new System.Drawing.Point(19, 165);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 19);
            this.lblDireccion.TabIndex = 53;
            this.lblDireccion.Text = "DIRECCION";
            // 
            // lblRif
            // 
            this.lblRif.AutoSize = true;
            this.lblRif.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRif.ForeColor = System.Drawing.Color.Navy;
            this.lblRif.Location = new System.Drawing.Point(56, 130);
            this.lblRif.Name = "lblRif";
            this.lblRif.Size = new System.Drawing.Size(37, 19);
            this.lblRif.TabIndex = 51;
            this.lblRif.Text = "R.I.F";
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsReturn = true;
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(108, 89);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(369, 27);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(31, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 49;
            this.lblNombre.Text = "NOMBRE";
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
            this.txtId.Location = new System.Drawing.Point(108, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(110, 27);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "CODIGO";
            // 
            // txtSede
            // 
            this.txtSede.AcceptsReturn = true;
            this.txtSede.AcceptsTab = true;
            this.txtSede.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSede.Location = new System.Drawing.Point(108, 59);
            this.txtSede.MaxLength = 100;
            this.txtSede.Name = "txtSede";
            this.txtSede.Size = new System.Drawing.Size(258, 27);
            this.txtSede.TabIndex = 1;
            this.txtSede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // lblsede
            // 
            this.lblsede.AutoSize = true;
            this.lblsede.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsede.ForeColor = System.Drawing.Color.Navy;
            this.lblsede.Location = new System.Drawing.Point(51, 67);
            this.lblsede.Name = "lblsede";
            this.lblsede.Size = new System.Drawing.Size(42, 19);
            this.lblsede.TabIndex = 39;
            this.lblsede.Text = "SEDE";
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
            // dgListado
            // 
            this.dgListado.AllowUserToDeleteRows = false;
            this.dgListado.AllowUserToOrderColumns = true;
            this.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.sede,
            this.nombre});
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
            // sede
            // 
            this.sede.DataPropertyName = "sede";
            this.sede.HeaderText = "SEDE";
            this.sede.Name = "sede";
            this.sede.Width = 200;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.Width = 250;
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
            this.label18.Size = new System.Drawing.Size(603, 39);
            this.label18.TabIndex = 46;
            this.label18.Text = "Control de Empresa";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 456);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabFormulario);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "empresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "empresas";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabFormulario.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabControl tabFormulario;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRif;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtModificando;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.Label lblsede;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.DataGridView dgListado;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRif;
        private System.Windows.Forms.DataGridViewLinkColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}