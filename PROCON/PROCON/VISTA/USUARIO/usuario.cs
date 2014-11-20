using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROCON.CONTROLADOR.SESION;
using PROCON.CONTROLADOR.USUARIO;
using PROCON.MODELO;
using PROCON.UTILIDADES;

namespace PROCON.VISTA.USUARIO
{
    public partial class usuario : Form 
    {
        private static usuario m_FormDefInstance;
        /// Crea una instancia unica del Formulario
        public static usuario DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new usuario();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }


        public usuario()
        {
            try
            {
                InitializeComponent();
                llenaCombos(); //LLENO LOS COMBOS
                navegacionDeRegistros(); //datos de navegacion del formulario
                cargarDataGrid();
                actividadCampos(0, 1); // inabilito los campos
                this.bindingNavigator1.MoveLastItem.PerformClick();//ir al ultimo registro

                this.Text = " USUARIOS " + sesion.NOMBREUSUARIOSESION;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL INICIAR COMPONENTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void llenaCombos()
        {
            try
            {
                //lleno el combo nivel con los numeros
                for (int i = 0; i <= 100; i++)
                {
                    cmbNivel.Items.Add(i);
                }
                cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbNivel.SelectedItem = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL INTENTAR LLENAR LOS COMBOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void navegacionDeRegistros()
        {
            try
            {
                bindingSource1.DataSource = controladorUsuario.examinarPorIdDataset().Tables[0];
                bindingNavigator1.BindingSource = this.bindingSource1;

                txtId.DataBindings.Add(new Binding("Text", bindingSource1, "id", true));
                txtNombres.DataBindings.Add(new Binding("Text", bindingSource1, "nombres", true));
                txtApellidos.DataBindings.Add(new Binding("Text", bindingSource1, "apellidos", true));
                txtCorreo.DataBindings.Add(new Binding("Text", bindingSource1, "correo", true));
                txtCelular.DataBindings.Add(new Binding("Text", bindingSource1, "celular", true));
                txtClave.DataBindings.Add(new Binding("Text", bindingSource1, "clave", true));
                txtClave2.DataBindings.Add(new Binding("Text", bindingSource1, "clave", true));
                cmbNivel.DataBindings.Add(new Binding("SelectedItem", bindingSource1, "nivel", true));
                txtUsuario.DataBindings.Add(new Binding("Text", bindingSource1, "usuario", true));

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cargarDataGrid()
        {

            try
            {
                //lleno el datagrid
                dgListado.DataSource = controladorUsuario.ListarDataGridDataset().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL NAVEGAR POR LOS REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void actividadCampos(int estado, int nuevo)
        {
            try
            {
                string estatu;

                // el estado me indica si se quiere habilitar o inabilitar
                if (estado == 0)
                {
                    estatu = "false";
                    txtModificando.Text = "0";
                }

                else
                {
                    estatu = "true";
                    txtModificando.Text = "1";
                }

                groupBox1.Enabled = Convert.ToBoolean(estatu);
                groupBox2.Enabled = Convert.ToBoolean(estatu);
                treeView1.Enabled = Convert.ToBoolean(estatu);
                btnGuardar.Enabled = Convert.ToBoolean(estatu);
                txtNombres.Focus();
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    //selecciono la fila donde se realizo el clic
                    string s = dgListado[e.ColumnIndex, e.RowIndex].Value.ToString();

                    //busco el registro seleccionado
                    int m_Pos = bindingSource1.Find("id", s);
                    bindingSource1.Position = m_Pos;
                    tabDatos.Select();
                    this.tabFormulario.SelectedIndex = 0;
                    this.txtNombres.Focus();

                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource source1 = new BindingSource();
                source1.DataSource = controladorUsuario.ListarDataGridDataset().Tables[0];
                dgListado.DataSource = source1;

                switch (cmbFiltro.Text)
                {
                    case "NOMBRES": source1.Filter = "nombres like '%" + this.txtFiltro.Text + "%'"; break;
                    case "APELLIDOS": source1.Filter = "apellidos like '%" + this.txtFiltro.Text + "%'"; break;
                    case "LOGIN": source1.Filter = "usuario like '%" + this.txtFiltro.Text + "%'"; break;
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                tabListado.Select();
                this.tabFormulario.SelectedIndex = 1;
                this.txtFiltro.Focus();
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MODIFICAR_Click(object sender, EventArgs e)
        {
            try
            {
                txtNuevo.Text = "0";
                actividadCampos(1, 0); //activo los campos y le indico al metodo que es modificar
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                actividadCampos(0, 0); //desactivo los campos
                NUEVOREGISTRO.Enabled = true; //activo el boton anexar
                txtNuevo.Text = "0"; //cambio la bandera nuevo a no nuevo

                if (txtId.Text != "")
                {
                    llenarPerfilesUsuario(Convert.ToInt16(txtId.Text));
                    llenarPerfiles(Convert.ToInt16(txtId.Text));
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NUEVOREGISTRO_Click(object sender, EventArgs e)
        {
            try
            {
                actividadCampos(1, 1);  //activo los campos y le indico al metodo que es nuevo
                NUEVOREGISTRO.Enabled = false; //desactivo el boton anexar
                txtNuevo.Text = "1"; //cambio labandera a 1 para indicar que es nuevo registro
                tabListado.Select(); this.tabFormulario.SelectedIndex = 0; //activo la ficha datos
                txtNombres.Focus(); //pongo el foco en el campo nombre
                llenaCombos();
                limpiarTreeView();
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Boolean validarCampos()
        {
            Boolean Res = true;
            try
            {
                if (this.txtNombres.Text == "")
                {
                    MessageBox.Show("DEBE INGRESAR  EL NOMBRE DEL USUARIO", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNombres.Focus();
                    Res = false;
                }

                else
                {
                    if (this.txtApellidos.Text == "")
                    {
                        MessageBox.Show("DEBE INGRESAR  EL APELLIDO DEL USUARIO", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtApellidos.Focus();
                        Res = false;
                    }
                    else
                    {
                        if (this.txtUsuario.Text == "")
                        {
                            MessageBox.Show("DEBE INGRESAR  EL LOGIN DEL USUARIO", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtUsuario.Focus();
                            Res = false;
                        }

                        else
                        {
                            if (this.txtClave.Text == "")
                            {
                                MessageBox.Show("DEBE INGRESAR  UNA CLAVE PARA DEL USUARIO", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.txtUsuario.Focus();
                                Res = false;
                            }
                            else
                            {
                                if (this.txtClave.ToString().CompareTo(this.txtClave2.ToString()) != 0)
                                {
                                    MessageBox.Show("LA CLAVE NO COINCIDE", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.txtClave.Focus();
                                    Res = false;
                                }

                                else
                                {
                                    if (this.txtCelular.Text == "" || (validaciones.IsValidoCelular(this.txtCelular.Text) == false))
                                    {
                                        MessageBox.Show("DEBE INGRESAR  EL NUMERO DE CELULAR SIN PUNTO NI GUION. SOLO NUMEROS. EJEMPLO: 04264284471", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.txtCelular.Focus();
                                        Res = false;
                                    }
                                    else
                                    {
                                        if (this.txtCorreo.Text != "" && (validaciones.IsValidoEmail(this.txtCorreo.Text) == false))
                                        {
                                            MessageBox.Show("EL CORREO INGRESADO NO ES CORRECTO.", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            this.txtCorreo.Focus();
                                            Res = false;
                                        }
                                    }

                                }
                            }



                        }
                    }
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Res = false;
            }

            return Res;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //instancio el controlador de la clase
                controladorUsuario controlador = new controladorUsuario();
                //instancio el contenedor
                entidadUsuario usuario = new entidadUsuario();


                if (validarCampos() == true) //se ejecuta si se validan los campos
                {
                    //lleno la clase con los datos del formulario
                    usuario.Nombres = txtNombres.Text;
                    usuario.Apellidos = txtApellidos.Text;
                    usuario.Usuario = txtUsuario.Text;
                    usuario.Celular = txtCelular.Text;
                    usuario.Correo = txtCorreo.Text;
                    usuario.Clave = txtClave.Text;
                    usuario.Nivel = Convert.ToInt32(cmbNivel.SelectedItem.ToString());


                    int Resultado;

                    if (txtNuevo.Text == "0")
                    {
                        usuario.Id = Convert.ToInt16(this.txtId.Text.ToString());
                        //llamo al metodo modificar
                        Resultado = controlador.modificar(usuario);
                    }
                    else
                    {
                        usuario.Id = 0;
                        //llamo al metodo modificar
                        Resultado = controlador.nuevo(usuario);
                        //cargo el numero del ultimo registro en el text 
                        if (Resultado != 0) txtId.Text = controlador.idUltimoRegistrado().ToString();
                    }



                    if (Resultado == 0)
                    {
                        MessageBox.Show("NO SE PUDO ACTUALIZAR LA INFORMACION", "FALLO EL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        actividadCampos(1, 0);//dejo los campos activos puesto que no se pudo guardar
                    }
                    else
                    {
                        //MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actividadCampos(0, 0); //desactivo los campos puesto que guardo la informacion 
                        NUEVOREGISTRO.Enabled = true;
                    }
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabularEnter(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbNivel_Leave(object sender, EventArgs e)
        {
            try
            {
                bindingNavigator1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void llenarPerfilesUsuario(int idUsuario)
        {
            try
            {
                //limpiar los nodos antes de cargar de nuevo
                limpiarTreeView();
                // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.

            DataTable dt = controladorTipoUsuario.listarPerfilesdeUnUsuario(idUsuario).Tables[0];  
            DataView dataViewHijos = dt.DefaultView;

            // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["descripcion"].ToString().Trim();
                nuevoNodo.Tag = dataRowCurrent["id"].ToString().Trim();
                treeView1.Nodes.Add(nuevoNodo);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void llenarPerfiles(int idUsuario)
        {
            try
            {
                // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.

                DataTable dt = controladorTipoUsuario.listarPerfilesDisponibles().Tables[0];
                DataView dataViewHijos = dt.DefaultView;


                // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
                foreach (DataRowView dataRowCurrent in dataViewHijos)
                {
                    TreeNode nuevoNodo = new TreeNode();
                    nuevoNodo.Text = dataRowCurrent["descripcion"].ToString().Trim();
                    nuevoNodo.Tag = dataRowCurrent["id"].ToString().Trim();
                    //
                   
                    int total = controladorTipoUsuario.consultarSiElUsuarioTieneElModuloAsignado(idUsuario, Convert.ToInt16(dataRowCurrent["id"].ToString().Trim()));

                    if ( total==0) treeView2.Nodes.Add(nuevoNodo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void limpiarTreeView()
        {
            try
            {
                //limpiar los nodos antes de cargar de nuevo
                treeView1.Nodes.Clear();
                treeView2.Nodes.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void usuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    llenarPerfilesUsuario(Convert.ToInt16(txtId.Text));
                    llenarPerfiles(Convert.ToInt16(txtId.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                TreeNode node = treeView2.SelectedNode;
                string nodoSeleccionado = node.Tag.ToString();

                controladorUsuarioTipoUsuario conutu = new controladorUsuarioTipoUsuario();
                entidadUsuarioTipoUsuario entUtu = new entidadUsuarioTipoUsuario();

                entUtu.Fktipo_usuario = Convert.ToInt32(nodoSeleccionado);
                entUtu.Fkusuario = Convert.ToInt32(txtId.Text);

                int res = conutu.nuevo(entUtu);

                if (res > 0)
                {
                    llenarPerfilesUsuario(Convert.ToInt16(txtId.Text));
                    llenarPerfiles(Convert.ToInt16(txtId.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                TreeNode node = treeView1.SelectedNode;
                string nodoSeleccionado = node.Tag.ToString();

                controladorUsuarioTipoUsuario conutu = new controladorUsuarioTipoUsuario();
                entidadUsuarioTipoUsuario entUtu = new entidadUsuarioTipoUsuario();

                entUtu.Fktipo_usuario = Convert.ToInt32(nodoSeleccionado);
                entUtu.Fkusuario = Convert.ToInt32(txtId.Text);

                int res = conutu.eliminar(entUtu);

                if (res > 0)
                {
                    llenarPerfilesUsuario(Convert.ToInt16(txtId.Text));
                    llenarPerfiles(Convert.ToInt16(txtId.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {

                TreeNode node = treeView1.SelectedNode;
                string nodoSeleccionado = node.Tag.ToString();

                controladorUsuarioTipoUsuario conutu = new controladorUsuarioTipoUsuario();
                entidadUsuarioTipoUsuario entUtu = new entidadUsuarioTipoUsuario();

                entUtu.Fktipo_usuario = Convert.ToInt32(nodoSeleccionado);
                entUtu.Fkusuario = Convert.ToInt32(txtId.Text);

                int res = conutu.eliminar(entUtu);

                if (res > 0)
                {
                    llenarPerfilesUsuario(Convert.ToInt16(txtId.Text));
                    llenarPerfiles(Convert.ToInt16(txtId.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
