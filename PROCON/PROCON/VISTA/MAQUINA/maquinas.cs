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
using PROCON.CONTROLADOR.MAQUINAS;
using PROCON.CONTROLADOR.EMPRESA;
using PROCON.CONTROLADOR.TIPO_DESPERDICIO;

namespace PROCON.VISTA.MAQUINAS
{
    public partial class maquinas : Form
    {
        
        private static maquinas m_FormDefInstance;
        /// Crea una instancia unica del Formulario
        public static maquinas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new maquinas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public maquinas ()//constructor
        {
            try
            {
                InitializeComponent();
                navegacionDeRegistros(); //datos de navegacion del formulario
                llenaCombos();
                cargarDataGrid();
                actividadCampos(0, 1); // inabilito los campos
                this.bindingNavigator1.MoveLastItem.PerformClick();//ir al ultimo registro
                this.Text = " MAQUINAS " + sesion.NOMBREUSUARIOSESION;
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

                //lleno el combo fkempresa
                cmbFkempresa.DataSource = controladorEmpresa.listar();
                cmbFkempresa.DisplayMember = "sede";
                cmbFkempresa.ValueMember = "id";
                cmbFkempresa.DropDownStyle = ComboBoxStyle.DropDown;
                cmbFkempresa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbFkempresa.AutoCompleteCustomSource = controladorEmpresa.autocompletar();
                cmbFkempresa.AutoCompleteSource = AutoCompleteSource.CustomSource;

                //lleno el combo Fktipo_maquina
                cmbFktipo_maquina.DataSource = controladorTipo_desperdicio.listar();
                cmbFktipo_maquina.DisplayMember = "descripcion";
                cmbFktipo_maquina.ValueMember = "id";
                cmbFktipo_maquina.DropDownStyle = ComboBoxStyle.DropDown;
                cmbFktipo_maquina.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbFktipo_maquina.AutoCompleteCustomSource = controladorTipo_desperdicio.autocompletar();
                cmbFktipo_maquina.AutoCompleteSource = AutoCompleteSource.CustomSource;
              

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
                bindingSource1.DataSource = controladorMaquinas.examinarPorIdDataset().Tables[0];
                bindingNavigator1.BindingSource = this.bindingSource1;

                txtId.DataBindings.Add(new Binding("Text", bindingSource1, "id", true));
                txtNumero.DataBindings.Add(new Binding("Text", bindingSource1, "numero", true));
                txtDescripcion.DataBindings.Add(new Binding("Text", bindingSource1, "descripcion", true));
                cmbFkempresa.DataBindings.Add(new Binding("SelectedValue", bindingSource1, "fkempresa", true));
                cmbFktipo_maquina.DataBindings.Add(new Binding("SelectedValue", bindingSource1, "fktipo_maquina", true));


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
                txtNumero.Focus();
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
                txtNumero.Focus(); //pongo el foco en el campo nombre
                llenaCombos();

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
                dgListado.DataSource = controladorMaquinas.ListarDataGridDataset().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL NAVEGAR POR LOS REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            
                try
                {
                    actividadCampos(0, 0); //desactivo los campos
                    NUEVOREGISTRO.Enabled = true; //activo el boton anexar
                    txtNuevo.Text = "0"; //cambio la bandera nuevo a no nuevo
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
                txtNuevo.Text = "0";
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
                source1.DataSource = controladorMaquinas.ListarDataGridDataset().Tables[0];
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
                    this.txtNumero.Focus();

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
                if (validaciones.IsValidoEntero(this.txtNumero.Text) == false)
                {
                    MessageBox.Show("DEBE INGRESAR SOLO NUMEROS", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNumero.Focus();
                    Res = false;
                }

                else
                {

                    if (this.txtDescripcion.Text == "")
                    {
                        MessageBox.Show("DEBE INGRESAR DESCRIPCION", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtDescripcion.Focus();
                        Res = false;
                    }

                    else
                    {
                        if (this.cmbFkempresa.Text == "")
                        {
                            MessageBox.Show("DEBE ELEGIR UNA OPCION DEL COMBO EMPRESA", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.cmbFkempresa.Focus();
                            Res = false;
                        }
                        else
                        {
                            if (this.cmbFktipo_maquina.Text == "")
                            {
                                MessageBox.Show("DEBE ELEGIR UNA OPCION DEL COMBO TIPO MAQUINA", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.cmbFktipo_maquina.Focus();
                                Res = false;

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
                controladorMaquinas controlador = new controladorMaquinas();
                //instancio el contenedor
                entidadMaquinas entMaq = new entidadMaquinas();


                if (validarCampos() == true) //se ejecuta si se validan los campos
                {
                    //lleno la clase con los datos del formulario
                    entMaq.Numero = Convert.ToInt16(txtNumero.Text);
                    entMaq.Descripcion = txtDescripcion.Text;
                    entMaq.Fkempresa = Convert.ToInt16( cmbFkempresa.SelectedValue);
                    entMaq.Fktipo_maquina = Convert.ToInt16(cmbFktipo_maquina.SelectedValue);


                    int Resultado;

                    if (txtNuevo.Text == "0")
                    {
                        entMaq.Id = Convert.ToInt16(this.txtId.Text.ToString());
                        //llamo al metodo modificar
                        Resultado = controlador.modificar(entMaq);
                    }
                    else
                    {
                        entMaq.Id = 0;
                        //llamo al metodo modificar
                        Resultado = controlador.nuevo(entMaq);
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



       
    }
}
