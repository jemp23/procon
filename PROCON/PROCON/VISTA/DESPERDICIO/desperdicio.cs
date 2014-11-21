using PROCON.CONTROLADOR.MAQUINAS;
using PROCON.CONTROLADOR.SESION;
using PROCON.CONTROLADOR.TIPO_DESPERDICIO;
using PROCON.CONTROLADOR.USUARIO;
using PROCON.MODELO;
using PROCON.UTILIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROCON.VISTA.DESPERDICIO
{
    public partial class desperdicio : Form
    {
        private static desperdicio m_FormDefInstance;
        /// Crea una instancia unica del Formulario
        public static desperdicio DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new desperdicio();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public desperdicio()
        {
            try
            {
                InitializeComponent();
                llenaCombos();
                cargarDataGrid();
                this.Text = " CARGAR DESPERDICIO " + sesion.NOMBREUSUARIOSESION;
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
                cmbfktipo_desperdicio.DataSource = controladorTipo_desperdicio.listar();
                cmbfktipo_desperdicio.DisplayMember = "descripcion";
                cmbfktipo_desperdicio.ValueMember = "id";
                cmbfktipo_desperdicio.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL INTENTAR LLENAR LOS COMBOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void llenaCombosMaquinaOperador(int tipoDesperdicio)
        {
            try
            {

                //lleno el combo 
                cmbFkmaquina.DataSource = controladorMaquinas.listarPorTipo(tipoDesperdicio);
                cmbFkmaquina.DisplayMember = "descripcion";
                cmbFkmaquina.ValueMember = "id";
                cmbFkmaquina.DropDownStyle = ComboBoxStyle.DropDownList;

                //lleno el combo 
                cmbFkoperador.DataSource = controladorOperador.listarPorTipo(tipoDesperdicio, sesion.CODIGODEEMPRESAACTIVA);
                cmbFkoperador.DisplayMember = "nombreOperador";
                cmbFkoperador.ValueMember = "idOperador";
                cmbFkoperador.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL INTENTAR LLENAR LOS COMBOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cmbfktipo_desperdicio_Leave(object sender, EventArgs e)
        {
            try
            {
                llenaCombosMaquinaOperador(Convert.ToInt16(cmbfktipo_desperdicio.SelectedValue));
                cmbFkmaquina.Enabled = true;
                cmbFkoperador.Enabled = true;
                txtObservacion.Enabled = true;
                txtCantidad.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL INTENTAR LLENAR LOS COMBOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //instancio el controlador de la clase
                controladorDesperdicio controlador = new controladorDesperdicio();
                //instancio el contenedor
                entidadDesperdicio entidad = new entidadDesperdicio();


                if (validarCampos() == true) //se ejecuta si se validan los campos
                {
                    //lleno la clase con los datos del formulario
                    entidad.Fktipo_desperdicio = Convert.ToInt16( cmbfktipo_desperdicio.SelectedValue);
                    entidad.Fecha = Convert.ToDateTime(fecha.Text);
                    entidad.Fkorden_produccion = Convert.ToInt32( txtFkorden_produccion.Text);
                    entidad.Fkmaquina = Convert.ToInt16(cmbFkmaquina.SelectedValue);
                    entidad.Fkoperador = Convert.ToInt16(cmbFkmaquina.SelectedValue);
                    entidad.Observacion = txtObservacion.Text;
                    entidad.Cantidad = Convert.ToDouble(txtCantidad.Text);
                    entidad.Fkempresa = sesion.CODIGODEEMPRESAACTIVA;
                    entidad.Fkusuario = sesion.CODUSUARIOSESION;


                    int Resultado;

                        Resultado = controlador.nuevo(entidad);




                    if (Resultado == 0)
                    {
                        MessageBox.Show("NO SE PUDO ACTUALIZAR LA INFORMACION", "FALLO EL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cargarDataGrid();
                        cmbFkmaquina.Enabled = false;
                        cmbFkoperador.Enabled = false;
                        txtObservacion.Enabled = false;
                        txtCantidad.Enabled = false;
                        txtCantidad.Text = "";
                        txtObservacion.Text = "";
                        cmbfktipo_desperdicio.Focus();

                        //MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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
                if (this.txtFkorden_produccion.Text == "" || this.txtFkorden_produccion.Text == "0" || (validaciones.IsValidoEntero(this.txtFkorden_produccion.Text) == false))
                {
                    MessageBox.Show("DEBE INGRESAR  UN NUMERO ORDEN DE PRODUCCION VALIDO", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtFkorden_produccion.Focus();
                    Res = false;
                }

                else
                {
                    if (this.txtCantidad.Text == "" || this.txtCantidad.Text == "0" || (validaciones.IsValidoMoneda(this.txtCantidad.Text) == false))
                    {
                        MessageBox.Show("DEBE INGRESAR  UNA CANTIDAD VALIDA", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtCantidad.Focus();
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
        private void cargarDataGrid()
        {

            try
            {
                //lleno el datagrid
                dgListado.DataSource = controladorDesperdicio.ListarDataGridDataset().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL NAVEGAR POR LOS REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {

            try
            {
                btnGuardar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL NAVEGAR POR LOS REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
