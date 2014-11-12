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

namespace PROCON.VISTA.SESION
{
    public partial class modulos : Form
    {
        private static modulos m_FormDefInstance;
        /// Crea una instancia unica del Formulario
        public static modulos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new modulos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public modulos()
        {
            try
            {
                InitializeComponent();
                navegacionDeRegistros(); //datos de navegacion del formulario
                llenaCombos();
                //cargarDataGrid();
                //actividadCampos(0, 1); // inabilito los campos
                this.bindingNavigator1.MoveLastItem.PerformClick();//ir al ultimo registro

                this.Text = " MODULOS " + sesion.NOMBREUSUARIOSESION;



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
                for (int i = 0; i <= 3; i++)
                {
                    cmbInterfaz.Items.Add(i);
                }
                cmbInterfaz.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbInterfaz.SelectedItem = 0;

                //lleno el combo medicos
                cmbSuperior.DataSource = controladorModulos.listar();
                cmbSuperior.DisplayMember = "descripcion";
                cmbSuperior.ValueMember = "id";
                cmbSuperior.DropDownStyle = ComboBoxStyle.DropDown;
                cmbSuperior.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbSuperior.AutoCompleteCustomSource = controladorModulos.autocompletar();
                cmbSuperior.AutoCompleteSource = AutoCompleteSource.CustomSource;

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
                bindingSource1.DataSource = controladorModulos.examinarPorIdDataset().Tables[0];
                bindingNavigator1.BindingSource = this.bindingSource1;

                txtId.DataBindings.Add(new Binding("Text", bindingSource1, "id", true));
                txtDescripcion.DataBindings.Add(new Binding("Text", bindingSource1, "descripcion", true));
                txtDireccion.DataBindings.Add(new Binding("Text", bindingSource1, "direccion", true));
                cmbInterfaz.DataBindings.Add(new Binding("SelectedItem", bindingSource1, "interfaz", true));
                txtImagen.DataBindings.Add(new Binding("Text", bindingSource1, "imagen", true));
                txtOrden.DataBindings.Add(new Binding("Text", bindingSource1, "orden", true));
                cmbSuperior.DataBindings.Add(new Binding("SelectedValue", bindingSource1, "superior", true));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                btnGuardar.Enabled = Convert.ToBoolean(estatu);
                txtDescripcion.Focus();
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
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarDataGrid()
        {

            try
            {
                //lleno el datagrid
                dgListado.DataSource = controladorModulos.ListarDataGridDataset().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL NAVEGAR POR LOS REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtImagen_TextChanged(object sender, EventArgs e)
        {

        }
        private void cargarImagen()
        {
            try
            {
                int valorImagen = 0;
                if (imageList1.Images.Count > 0)
                {
                if (txtImagen.Text == "" || txtImagen.Text == null)
                {
                    valorImagen = 0;
                }
                else
                {
                    try
                    {
                        valorImagen = Convert.ToInt16(txtImagen.Text);
                        int totalCargadas = imageList1.Images.Count;
                        if (valorImagen >= totalCargadas)
                        {
   
                            MessageBox.Show("NO EXISTE UNA IMAGEN PARA ESE NUMERO: " + valorImagen, sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtImagen.Text = "0";
                            valorImagen = 0;
                        }
                    }
               
                    catch
                    {
                        valorImagen = 0;
                    }
                }
                pictureBox1.Image = imageList1.Images[valorImagen];
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            try
            {
            cargarImagen();
            actividadCampos(0, 0); //desactivo los campos
            NUEVOREGISTRO.Enabled = true; //activo el boton anexar
            txtNuevo.Text = "0"; //cambio la bandera nuevo a no nuevo

            if (txtId.Text != "")
            {
                // llenarPerfilesUsuario(Convert.ToInt16(txtId.Text));
                // llenarPerfiles(Convert.ToInt16(txtId.Text));
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtImagen_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
            cargarImagen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource source1 = new BindingSource();
                source1.DataSource = controladorModulos.ListarDataGridDataset().Tables[0];
                dgListado.DataSource = source1;
                source1.Filter = "descripcion like '%" + this.txtFiltro.Text + "%'";

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
                controladorModulos controlador = new controladorModulos();
                //instancio el contenedor
                entidadModulos entMod = new entidadModulos();


                if (validarCampos() == true) //se ejecuta si se validan los campos
                {
                    //lleno la clase con los datos del formulario
                    entMod.Descripcion = txtDescripcion.Text;
                    entMod.Direccion = txtDireccion.Text;
                    entMod.Imagen = txtImagen.Text;
                    entMod.Interfaz = Convert.ToInt16( cmbInterfaz.SelectedItem);
                    entMod.Orden = Convert.ToInt16( txtOrden.Text);
                    entMod.Superior = Convert.ToInt16(cmbSuperior.SelectedValue);


                    int Resultado;

                    if (txtNuevo.Text == "0")
                    {
                        entMod.Id = Convert.ToInt16(this.txtId.Text.ToString());
                        //llamo al metodo modificar
                        Resultado = controlador.modificar(entMod);
                    }
                    else
                    {
                        entMod.Id = 0;
                        //llamo al metodo modificar
                        Resultado = controlador.nuevo(entMod);
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

    }
}
