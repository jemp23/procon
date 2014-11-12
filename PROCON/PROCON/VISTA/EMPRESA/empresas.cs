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
using PROCON.CONTROLADOR.EMPRESA;
using PROCON.MODELO;
using PROCON.UTILIDADES;

namespace PROCON.VISTA.EMPRESA
{
    public partial class empresas : Form
    {
        private static empresas m_FormDefInstance;
        /// Crea una instancia unica del Formulario
        public static empresas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new empresas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }



        public empresas()
        {
            try
            {
                InitializeComponent();
               navegacionDeRegistros(); //datos de navegacion del formulario

               cargarDataGrid();
               actividadCampos(0, 1); // inabilito los campos
                this.bindingNavigator1.MoveLastItem.PerformClick();//ir al ultimo registro

                this.Text = " EMPRESAS " + sesion.NOMBREUSUARIOSESION;



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
                bindingSource1.DataSource = controladorEmpresa.examinarPorIdDataset().Tables[0];
                bindingNavigator1.BindingSource = this.bindingSource1;

                txtId.DataBindings.Add(new Binding("Text", bindingSource1, "id", true));
                txtSede.DataBindings.Add(new Binding("Text", bindingSource1, "sede", true));
                txtNombre.DataBindings.Add(new Binding("Text", bindingSource1, "nombre", true));
                txtRif.DataBindings.Add(new Binding("Text", bindingSource1, "rif", true));
                txtDireccion.DataBindings.Add(new Binding("Text", bindingSource1, "direccion", true));
                txtTelefono.DataBindings.Add(new Binding("Text", bindingSource1, "telefono", true));
                txtCorreo.DataBindings.Add(new Binding("Text", bindingSource1, "correo", true));
               

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
                txtSede.Focus();
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
                txtSede.Focus(); //pongo el foco en el campo nombre
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
                dgListado.DataSource = controladorEmpresa.ListarDataGridDataset().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL NAVEGAR POR LOS REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e) //se ejecute la barra de navegacion me muestre la cantidad de registros
        {

            try
            {
               
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
                source1.DataSource = controladorEmpresa.ListarDataGridDataset().Tables[0];
                dgListado.DataSource = source1;
                source1.Filter = "sede like '%" + this.txtFiltro.Text + "%'";

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

        private void dgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)//me muestre con el click la informacion del registro que seleccione
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
                    this.txtSede.Focus();

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
                if (this.txtSede.Text == "")
                {
                    MessageBox.Show("DEBE INGRESAR LA SEDE ", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtSede.Focus();
                    Res = false;
                }

                else
                {
                    if (this.txtNombre.Text == "")
                    {
                        MessageBox.Show("DEBE INGRESAR EL NOMBRE", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtNombre.Focus();
                        Res = false;
                    }

                    else
                    {
                        if (this.txtRif.Text == "" || (validaciones.IsValidoRif(this.txtRif.Text) == false))
                        {
                            MessageBox.Show("DEBE INGRESAR UN NUMERO DE RIF VALIDO.  EJEMPLO: J-00000000-0", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtRif.Focus();
                            Res = false;
                        }
                        else
                        {
                            if (this.txtDireccion.Text == "")
                            {
                                MessageBox.Show("DEBE INGRESAR LA DIRECCION", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.txtDireccion.Focus();
                                Res = false;
                            }
                            else{
                                 if(validaciones.IsValidoEmail(this.txtCorreo.Text)==false)
                                 {
                                     MessageBox.Show("DEBE INGRESAR UN CORREO VALIDO", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                     this.txtCorreo.Focus();
                                    Res = false;
                                 }
                                 else{
                                     if (validaciones.IsValidoEntero(this.txtTelefono.Text) == false)
                                     {
                                         MessageBox.Show("DEBE INGRESAR SOLO NUMEROS", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                         this.txtTelefono.Focus();
                                         Res = false;
                                     }
                                 }
                            }

                        }

                    }

                }
                return Res;
            }
           
            catch (Exception eX)
            {
               
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
            try
            {
                //instancio el controlador de la clase
                controladorEmpresa controlador = new controladorEmpresa();
                //instancio el contenedor
                entidadEmpresa empresa = new entidadEmpresa();


                if (validarCampos() == true) //se ejecuta si se validan los campos
                {
                    //lleno la clase con los datos del formulario
                  empresa.Sede = txtSede.Text;
                  empresa.Nombre = txtNombre.Text;
                  empresa.Rif = txtRif.Text;
                  empresa.Direccion = txtDireccion.Text;
                  empresa.Telefono = txtTelefono.Text;
                  empresa.Correo = txtCorreo.Text;
             


                    int Resultado;

                    if (txtNuevo.Text == "0")
                    {
                        empresa.Id = Convert.ToInt16(this.txtId.Text.ToString());
                        //llamo al metodo modificar
                        Resultado = controlador.modificar(empresa);
                    }
                    else
                    {
                        empresa.Id = 0;
                        //llamo al metodo modificar
                        Resultado = controlador.nuevo(empresa);
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
