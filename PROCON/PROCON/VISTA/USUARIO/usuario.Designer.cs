namespace PROCON.VISTA.USUARIO
{
    partial class usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuario));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.totalR = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label18 = new System.Windows.Forms.Label();
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModificando = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClave2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgListado = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUEVOREGISTRO = new System.Windows.Forms.ToolStripButton();
            this.PRIMERO = new System.Windows.Forms.ToolStripButton();
            this.ANTERIOR = new System.Windows.Forms.ToolStripButton();
            this.SIGUIENTE = new System.Windows.Forms.ToolStripButton();
            this.ULTIMO = new System.Windows.Forms.ToolStripButton();
            this.ELIMINARREFISTRO = new System.Windows.Forms.ToolStripButton();
            this.MODIFICAR = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.BUSCAR = new System.Windows.Forms.ToolStripButton();
            this.salir = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabFormulario.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1014, 37);
            this.bindingNavigator1.TabIndex = 39;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1014, 39);
            this.label18.TabIndex = 38;
            this.label18.Text = "Control de Usuarios";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabFormulario
            // 
            this.tabFormulario.Controls.Add(this.tabDatos);
            this.tabFormulario.Controls.Add(this.tabListado);
            this.tabFormulario.Location = new System.Drawing.Point(1, 79);
            this.tabFormulario.Name = "tabFormulario";
            this.tabFormulario.SelectedIndex = 0;
            this.tabFormulario.Size = new System.Drawing.Size(1001, 381);
            this.tabFormulario.TabIndex = 40;
            // 
            // tabDatos
            // 
            this.tabDatos.BackColor = System.Drawing.SystemColors.Control;
            this.tabDatos.Controls.Add(this.groupBox2);
            this.tabDatos.Controls.Add(this.groupBox1);
            this.tabDatos.Location = new System.Drawing.Point(4, 22);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatos.Size = new System.Drawing.Size(993, 355);
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
            this.groupBox2.Size = new System.Drawing.Size(540, 319);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERFIL DE ACCESO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(293, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "PERFILES DISPONIBLES";
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView2.ForeColor = System.Drawing.Color.Gray;
            this.treeView2.HotTracking = true;
            this.treeView2.Location = new System.Drawing.Point(288, 59);
            this.treeView2.Name = "treeView2";
            this.treeView2.Scrollable = false;
            this.treeView2.Size = new System.Drawing.Size(170, 244);
            this.treeView2.TabIndex = 42;
            this.treeView2.DoubleClick += new System.EventHandler(this.treeView2_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(35, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 19);
            this.label9.TabIndex = 41;
            this.label9.Text = "PERFILES DEL USUARIO";
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
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cmbNivel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtModificando);
            this.groupBox1.Controls.Add(this.txtNuevo);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtClave2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.lbldireccion);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 319);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL USUARIO";
            // 
            // cmbNivel
            // 
            this.cmbNivel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(146, 277);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(191, 26);
            this.cmbNivel.TabIndex = 10;
            this.cmbNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            this.cmbNivel.Leave += new System.EventHandler(this.cmbNivel_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(96, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "NIVEL";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsReturn = true;
            this.txtUsuario.AcceptsTab = true;
            this.txtUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(146, 183);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(191, 27);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(89, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "LOGIN";
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
            // txtCelular
            // 
            this.txtCelular.AcceptsReturn = true;
            this.txtCelular.AcceptsTab = true;
            this.txtCelular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(146, 152);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(191, 27);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(58, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "N CELULAR";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AcceptsReturn = true;
            this.txtCorreo.AcceptsTab = true;
            this.txtCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(146, 121);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(284, 27);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(90, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "EMAIL";
            // 
            // txtClave2
            // 
            this.txtClave2.AcceptsReturn = true;
            this.txtClave2.AcceptsTab = true;
            this.txtClave2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave2.Location = new System.Drawing.Point(146, 245);
            this.txtClave2.Name = "txtClave2";
            this.txtClave2.PasswordChar = '*';
            this.txtClave2.Size = new System.Drawing.Size(191, 27);
            this.txtClave2.TabIndex = 9;
            this.txtClave2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(41, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "REPITE CLAVE";
            // 
            // txtClave
            // 
            this.txtClave.AcceptsReturn = true;
            this.txtClave.AcceptsTab = true;
            this.txtClave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(146, 214);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(191, 27);
            this.txtClave.TabIndex = 8;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(90, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "CLAVE";
            // 
            // txtApellidos
            // 
            this.txtApellidos.AcceptsReturn = true;
            this.txtApellidos.AcceptsTab = true;
            this.txtApellidos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(146, 90);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(284, 27);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(-4, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "APELLIDOS USUARIO";
            // 
            // txtId
            // 
            this.txtId.AcceptsReturn = true;
            this.txtId.AcceptsTab = true;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(146, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(191, 27);
            this.txtId.TabIndex = 0;
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
            // txtNombres
            // 
            this.txtNombres.AcceptsReturn = true;
            this.txtNombres.AcceptsTab = true;
            this.txtNombres.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(146, 59);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(284, 27);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabularEnter);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.ForeColor = System.Drawing.Color.Navy;
            this.lbldireccion.Location = new System.Drawing.Point(7, 67);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(133, 19);
            this.lbldireccion.TabIndex = 39;
            this.lbldireccion.Text = "NOMBRE USUARIO";
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.cmbFiltro);
            this.tabListado.Controls.Add(this.txtFiltro);
            this.tabListado.Controls.Add(this.label19);
            this.tabListado.Controls.Add(this.dgListado);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(993, 355);
            this.tabListado.TabIndex = 1;
            this.tabListado.Text = "LISTADO";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "NOMBRES",
            "APELLIDOS",
            "LOGIN"});
            this.cmbFiltro.Location = new System.Drawing.Point(603, 6);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(186, 26);
            this.cmbFiltro.TabIndex = 43;
            this.cmbFiltro.Text = "NOMBRES";
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
            this.nombres,
            this.apellidos,
            this.Uusuario,
            this.celular,
            this.correo});
            this.dgListado.Location = new System.Drawing.Point(6, 40);
            this.dgListado.Name = "dgListado";
            this.dgListado.Size = new System.Drawing.Size(979, 380);
            this.dgListado.TabIndex = 0;
            this.dgListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListado_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "CODIGO";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "NOMBRES";
            this.nombres.Name = "nombres";
            this.nombres.Width = 200;
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "apellidos";
            this.apellidos.HeaderText = "APELLIDOS";
            this.apellidos.Name = "apellidos";
            this.apellidos.Width = 200;
            // 
            // Uusuario
            // 
            this.Uusuario.DataPropertyName = "usuario";
            this.Uusuario.HeaderText = "LOGIN";
            this.Uusuario.Name = "Uusuario";
            this.Uusuario.Width = 80;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "CELULAR";
            this.celular.Name = "celular";
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "CORREO";
            this.correo.Name = "correo";
            this.correo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.correo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.correo.Width = 250;
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
            // usuario
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 514);
            this.Controls.Add(this.tabFormulario);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabFormulario.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TabControl tabFormulario;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModificando;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClave2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgListado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewLinkColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label9;
    }
}