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
    public partial class tipoUsuario : Form
    {
        private static tipoUsuario m_FormDefInstance;
        /// Crea una instancia unica del Formulario
        public static tipoUsuario DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new tipoUsuario();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public tipoUsuario()
        {
            try
            {
                InitializeComponent();
                navegacionDeRegistros(); //datos de navegacion del formulario
                cargarDataGrid();
                actividadCampos(0, 1); // inabilito los campos
                this.bindingNavigator1.MoveLastItem.PerformClick();//ir al ultimo registro

                this.Text = " PERFILES " + sesion.NOMBREUSUARIOSESION;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL INICIAR COMPONENTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void navegacionDeRegistros()
        {
            try
            {
                bindingSource1.DataSource = controladorTipoUsuario.examinarPorIdDataset().Tables[0];
                bindingNavigator1.BindingSource = this.bindingSource1;

                txtId.DataBindings.Add(new Binding("Text", bindingSource1, "id", true));
                txtDescripcion.DataBindings.Add(new Binding("Text", bindingSource1, "descripcion", true));
                
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
                dgListado.DataSource = controladorTipoUsuario.ListarDataGridDataset().Tables[0];
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
                txtDescripcion.Focus();
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
                    this.txtDescripcion.Focus();

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
                source1.DataSource = controladorTipoUsuario.ListarDataGridDataset().Tables[0];
                dgListado.DataSource = source1;
                source1.Filter = "descripcion like '%" + this.txtFiltro.Text + "%'"; 

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
                    limpiarTreeView();
                    CrearNodosDelPadre(0, null, Convert.ToInt16(txtId.Text));
                    treeView1.ExpandAll();

                    CrearNodosDelPadreDisponibles(0, null, Convert.ToInt16(txtId.Text));
                    treeView2.ExpandAll();
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
                txtDescripcion.Focus(); //pongo el foco en el campo nombre
                limpiarTreeView();
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private Boolean validarCampos()
        {
            Boolean Res = true;
            try
            {
                if (this.txtDescripcion.Text == "")
                {
                    MessageBox.Show("DEBE INGRESAR DESCRIPCION", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtDescripcion.Focus();
                    Res = false;
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
                controladorTipoUsuario controlador = new controladorTipoUsuario();
                //instancio el contenedor
                entidadTipoUsuario usuario = new entidadTipoUsuario();


                if (validarCampos() == true) //se ejecuta si se validan los campos
                {
                    //lleno la clase con los datos del formulario
                    usuario.Descripcion = txtDescripcion.Text;

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
                        MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        actividadCampos(0, 0); //desactivo los campos puesto que guardo la informacion 
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

        private void llenarModulosUsuario(int idTUsuario)
        {
            try
            {
                //limpiar los nodos antes de cargar de nuevo
                limpiarTreeView();
                // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.

                DataTable dt = controladorTipoUsuario.listarModulosdeUnTipoUsuario(idTUsuario).Tables[0];
                DataView dataViewHijos = dt.DefaultView;

                // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
                foreach (DataRowView dataRowCurrent in dataViewHijos)
                {
                    TreeNode nuevoNodo = new TreeNode();
                    nuevoNodo.Text = dataRowCurrent["descripcion"].ToString().Trim();
                    nuevoNodo.Tag = dataRowCurrent["id"].ToString().Trim();
                    nuevoNodo.ImageIndex = Convert.ToInt16( dataRowCurrent["imagen"].ToString().Trim());
                    
                    treeView1.Nodes.Add(nuevoNodo);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CrearNodosDelPadre(int indicePadre, TreeNode nodePadre, int idTUsuario)
        {
            // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
            DataTable dt = controladorTipoUsuario.listarModulosdeUnTipoUsuario(idTUsuario).Tables[0];

            DataView dataViewHijos = dt.DefaultView;


            dataViewHijos.RowFilter = dt.Columns["superior"].ColumnName + " = " + indicePadre;

            // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["descripcion"].ToString().Trim();
                nuevoNodo.Tag = dataRowCurrent["id"].ToString().Trim();
                

                if (dataRowCurrent["imagen"].ToString().Trim() == null || dataRowCurrent["imagen"].ToString().Trim() == "") nuevoNodo.ImageIndex = 0;
                else nuevoNodo.ImageIndex = Convert.ToInt16(dataRowCurrent["imagen"].ToString().Trim());
                // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                // del primer nivel que no dependen de otro nodo.
                if (nodePadre == null)
                {
                    treeView1.Nodes.Add(nuevoNodo);
                }
                // se añade el nuevo nodo al nodo padre.
                else
                {
                    nodePadre.Nodes.Add(nuevoNodo);
                }

                // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.

                CrearNodosDelPadre(Int32.Parse(dataRowCurrent["id"].ToString()), nuevoNodo, idTUsuario);


            }

        }
        private void CrearNodosDelPadreDisponibles(int indicePadre, TreeNode nodePadre, int idTUsuario)
        {
            // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
            DataTable dt = controladorTipoUsuario.listarModulosdeUnTipoUsuarioDisponibles().Tables[0];

            DataView dataViewHijos = dt.DefaultView;


            dataViewHijos.RowFilter = dt.Columns["superior"].ColumnName + " = " + indicePadre;

            // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();

                int total = controladorTipoUsuario.consultarSiElPerfilTieneElModuloAsignado(Convert.ToInt16(txtId.Text), Convert.ToInt16(dataRowCurrent["id"].ToString().Trim()));

                if (total == 0)
                {
                    nuevoNodo.Text = dataRowCurrent["descripcion"].ToString().Trim();
                    if (dataRowCurrent["imagen"].ToString().Trim() == null || dataRowCurrent["imagen"].ToString().Trim() == "") nuevoNodo.ImageIndex = 0;
                    else nuevoNodo.ImageIndex = Convert.ToInt16(dataRowCurrent["imagen"].ToString().Trim());
                    nuevoNodo.Tag = dataRowCurrent["id"].ToString().Trim();
                }
                else
                {
                    nuevoNodo.Text = "YA " + dataRowCurrent["descripcion"].ToString().Trim();
                    nuevoNodo.ImageIndex = 6;
                    nuevoNodo.Tag = "0";
                    
                }
                    

             

                if (nodePadre == null)
                    {
                        treeView2.Nodes.Add(nuevoNodo);
                    }
                    // se añade el nuevo nodo al nodo padre.
                    else
                    {
                        nodePadre.Nodes.Add(nuevoNodo);
                    }
                // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.

 CrearNodosDelPadreDisponibles(Int32.Parse(dataRowCurrent["id"].ToString()), nuevoNodo, idTUsuario);


            }

        }
        private void tipoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    CrearNodosDelPadre(0, null, Convert.ToInt16(txtId.Text));
                    CrearNodosDelPadreDisponibles(0, null, Convert.ToInt16(txtId.Text));
                    treeView1.ExpandAll();
                    treeView2.ExpandAll();
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                TreeNode node = treeView1.SelectedNode;
                string nodoSeleccionado = node.Tag.ToString();

                controladorTipoUsuario conutu = new controladorTipoUsuario();

                int res = conutu.eliminarUnModulo(Convert.ToInt32(txtId.Text),Convert.ToInt32(nodoSeleccionado) );

                if (res > 0)
                {
                    if (txtId.Text != "")
                    {
                        limpiarTreeView();
                        CrearNodosDelPadre(0, null, Convert.ToInt16(txtId.Text));
                        CrearNodosDelPadreDisponibles(0, null, Convert.ToInt16(txtId.Text));
                        treeView1.ExpandAll();
                        treeView2.ExpandAll();
                    }
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

                controladorTipoUsuario conutu = new controladorTipoUsuario();

                int res = conutu.AnexarUnModulo(Convert.ToInt32(txtId.Text), Convert.ToInt32(nodoSeleccionado));

                if (res > 0)
                {
                    if (txtId.Text != "")
                    {
                        limpiarTreeView();
                        CrearNodosDelPadre(0, null, Convert.ToInt16(txtId.Text));
                        CrearNodosDelPadreDisponibles(0, null, Convert.ToInt16(txtId.Text));
                        treeView1.ExpandAll();
                        treeView2.ExpandAll();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
