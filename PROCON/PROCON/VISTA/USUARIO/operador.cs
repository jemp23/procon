using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROCON.CONTROLADOR.EMPRESA;
using PROCON.CONTROLADOR.SESION;
using PROCON.CONTROLADOR.USUARIO;
using PROCON.MODELO;
using PROCON.UTILIDADES;

namespace PROCON.VISTA.USUARIO
{
    public partial class operador : Form
    {
        private static operador m_FormDefInstance;
        /// Crea una instancia unica del Formulario
        public static operador DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new operador();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }


        public operador()
        {
            try
            {
                InitializeComponent();
                llenaCombos(); //LLENO LOS COMBOS
                navegacionDeRegistros(); //datos de navegacion del formulario
                cargarDataGrid();
                actividadCampos(0, 1); // inabilito los campos
                this.bindingNavigator1.MoveLastItem.PerformClick();//ir al ultimo registro

                this.Text = " OPERADORES " + sesion.NOMBREUSUARIOSESION;



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
                //lleno un arreglo con las respuestas si / no
                List<siNo> arreglo = new List<siNo>();
                arreglo.Add(new siNo { id = 0, des = "INACTIVO" });
                arreglo.Add(new siNo { id = 1, des = "ACTINO" });
                var ab = from a in arreglo
                         orderby a.id
                         select a;

                //lleno el combo eliminar con el arreglo si / no
                cmbEstatus.DataSource = ab.ToList();
                cmbEstatus.DisplayMember = "des";
                cmbEstatus.ValueMember = "id";
                cmbEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbEstatus.SelectedItem = "";

                //lleno el combo fkempresa
                cmbFkSede.DataSource = controladorEmpresa.listar();
                cmbFkSede.DisplayMember = "sede";
                cmbFkSede.ValueMember = "id";
                cmbFkSede.DropDownStyle = ComboBoxStyle.DropDownList;
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
                bindingSource1.DataSource = controladorOperador.examinarPorIdDataset().Tables[0];
                bindingNavigator1.BindingSource = this.bindingSource1;

                txtIdOperador.DataBindings.Add(new Binding("Text", bindingSource1, "idOperador", true));
                txtNombreOperador.DataBindings.Add(new Binding("Text", bindingSource1, "nombreOperador", true));
                txtTelefonoOperador.DataBindings.Add(new Binding("Text", bindingSource1, "telefonoOperador", true));
                cmbEstatus.DataBindings.Add(new Binding("SelectedValue", bindingSource1, "estatus", true));
                cmbFkSede.DataBindings.Add(new Binding("SelectedValue", bindingSource1, "fkSede", true));

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
                dgListado.DataSource = controladorOperador.ListarDataGridDataset().Tables[0];
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
                txtNombreOperador.Focus();
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
                    int m_Pos = bindingSource1.Find("idOperador", s);
                    bindingSource1.Position = m_Pos;
                    tabDatos.Select();
                    this.tabFormulario.SelectedIndex = 0;
                    this.txtNombreOperador.Focus();

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
                source1.DataSource = controladorOperador.ListarDataGridDataset().Tables[0];
                dgListado.DataSource = source1;

                source1.Filter = "nombreOperador like '%" + this.txtFiltro.Text + "%'";

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

                if (txtIdOperador.Text != "")
                {
                    //llenarPerfilesUsuario(Convert.ToInt16(txtIdOperador.Text));
                    //llenarPerfiles(Convert.ToInt16(txtIdOperador.Text));
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
                txtNombreOperador.Focus(); //pongo el foco en el campo nombre
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
                if (this.txtNombreOperador.Text == "")
                {
                    MessageBox.Show("DEBE INGRESAR  EL NOMBRE DEL OPERADOR", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNombreOperador.Focus();
                    Res = false;
                }

                else
                {
                    if (txtTelefonoOperador.Text!="" && (validaciones.IsValidoCelular(txtTelefonoOperador.Text) == false))
                    {
                        MessageBox.Show("DEBE INGRESAR  EL NUMERO DE CELULAR SIN PUNTO NI GUION. SOLO NUMEROS. EJEMPLO: 04264284471", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtTelefonoOperador.Focus();
                        Res = false;
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
                controladorOperador controlador = new controladorOperador();
                //instancio el contenedor
                entidadOperador op = new entidadOperador();


                if (validarCampos() == true) //se ejecuta si se validan los campos
                {
                    //lleno la clase con los datos del formulario
                    op.NombreOperador = txtNombreOperador.Text;
                    op.TelefonoOperador = txtTelefonoOperador.Text;
                    op.FkSede = Convert.ToInt16(cmbFkSede.SelectedValue.ToString());
                    op.Estatus = Convert.ToInt16(cmbEstatus.SelectedValue.ToString());


                    int Resultado;

                    if (txtNuevo.Text == "0")
                    {
                        op.IdOperador = Convert.ToInt16(this.txtIdOperador.Text.ToString());
                        //llamo al metodo modificar
                        Resultado = controlador.modificar(op);
                    }
                    else
                    {
                        op.IdOperador = 0;
                        //llamo al metodo modificar
                        Resultado = controlador.nuevo(op);
                        //cargo el numero del ultimo registro en el text 
                        if (Resultado != 0) txtIdOperador.Text = controlador.idUltimoRegistrado().ToString();
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

                    if (total == 0) treeView2.Nodes.Add(nuevoNodo);
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
                if (txtIdOperador.Text != "")
                {
                    llenarPerfilesUsuario(Convert.ToInt16(txtIdOperador.Text));
                    llenarPerfiles(Convert.ToInt16(txtIdOperador.Text));
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
                entUtu.Fkusuario = Convert.ToInt32(txtIdOperador.Text);

                int res = conutu.nuevo(entUtu);

                if (res > 0)
                {
                    llenarPerfilesUsuario(Convert.ToInt16(txtIdOperador.Text));
                    llenarPerfiles(Convert.ToInt16(txtIdOperador.Text));
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
                entUtu.Fkusuario = Convert.ToInt32(txtIdOperador.Text);

                int res = conutu.eliminar(entUtu);

                if (res > 0)
                {
                    llenarPerfilesUsuario(Convert.ToInt16(txtIdOperador.Text));
                    llenarPerfiles(Convert.ToInt16(txtIdOperador.Text));
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
                entUtu.Fkusuario = Convert.ToInt32(txtIdOperador.Text);

                int res = conutu.eliminar(entUtu);

                if (res > 0)
                {
                    llenarPerfilesUsuario(Convert.ToInt16(txtIdOperador.Text));
                    llenarPerfiles(Convert.ToInt16(txtIdOperador.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}