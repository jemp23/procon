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
using System.Runtime.InteropServices;
using System.Drawing.Text;
using PROCON.DATASET;

namespace PROCON.VISTA.DESPERDICIO
{
    public partial class desperdicio : Form
    {
        #region Variables
        dsImpresionRotuloDesperdicio impresionRotuloDesperdicio;

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;
        #endregion Variables
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
                actualizaCombos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL INTENTAR LLENAR LOS COMBOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void actualizaCombos()
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
                    entidad.Fkoperador = Convert.ToInt16(cmbFkoperador.SelectedValue);
                    entidad.Observacion = txtObservacion.Text;
                    entidad.Cantidad = Convert.ToDouble(txtCantidad.Text);
                    entidad.Fkempresa = sesion.CODIGODEEMPRESAACTIVA;
                    entidad.Fkusuario = sesion.CODUSUARIOSESION;


                    int Resultado;


                    if (txtId.Text == "...")
                    {

                        Resultado = controlador.nuevo(entidad);
                    }
                    else
                    {
                        string r = MessageBox.Show("¿DESEA MODIFICAR EL REGISTRO ACTURAL?", sesion.NOMBREAPLICACION, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

                        if (r == "Yes")
                        {
                            entidad.Id = Convert.ToInt32(txtId.Text);
                            Resultado = controlador.modificar(entidad);
                        }
                        else Resultado = 0;

                    }




                    if (Resultado == 0)
                    {
                        MessageBox.Show("NO SE PUDO ACTUALIZAR LA INFORMACION", "FALLO EL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        controladorDesperdicio conDes = new controladorDesperdicio();
                        Int32 ultimo = conDes.idUltimoRegistrado();
                        cargarDataGrid();
                        desactivarCampos();
                        imprimirRotulo(ultimo);
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

                    else
                    {
                        if (this.cmbFkmaquina.SelectedValue == "" || this.cmbFkmaquina.SelectedValue == null)
                        {
                            MessageBox.Show("DEBE SELECCIONAR UNA MAQUINA", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.cmbFkmaquina.Focus();
                            Res = false;
                        }
                        else
                        {
                            if (this.cmbFkoperador.SelectedValue == "" || this.cmbFkoperador.SelectedValue == null)
                            {
                                MessageBox.Show("DEBE SELECCIONAR UN OPERADOR", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.cmbFkoperador.Focus();
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
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            txtCantidad.Text = serialPort1.ReadExisting();
        }
        private void leerPeso()
        {
            try
            {
            serialPort1.Open();
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler( serialPort1_DataReceived);
            serialPort1.Close();
           
            }
            catch (Exception eX)
            {
                MessageBox.Show("NO SE PUDO LEER EL PESO", "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardar2_Click(object sender, EventArgs e)
        {

            try
            {

//



                leerPeso();
               // btnGuardar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FALLO DE SISTEMA AL NAVEGAR POR LOS REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    //selecciono la fila donde se realizo el clic
                    string id = dgListado[e.ColumnIndex, e.RowIndex].Value.ToString();

                    txtId.Text = id;

                    //busco los datos del registro
                    entidadDesperdicio esteDesperdicio = controladorDesperdicio.examinarPorId(Convert.ToInt32( id));

                    cmbfktipo_desperdicio.SelectedValue = esteDesperdicio.Fktipo_desperdicio;

                    actualizaCombos();

                    fecha.Text = esteDesperdicio.Fecha.ToString();
                    txtFkorden_produccion.Text = esteDesperdicio.Fkorden_produccion.ToString();
                    cmbFkmaquina.SelectedValue = esteDesperdicio.Fkmaquina;
                    cmbFkoperador.SelectedValue = esteDesperdicio.Fkoperador;
                    txtObservacion.Text = esteDesperdicio.Observacion;
                    txtCantidad.Text = esteDesperdicio.Cantidad.ToString();




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
                llenaCombos();
                desactivarCampos(); 
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void desactivarCampos()
        {
            try
            {
                cmbFkmaquina.Enabled = false;
                cmbFkoperador.Enabled = false;
                txtObservacion.Enabled = false;
                txtCantidad.Enabled = false;
                txtId.Text = "...";
                txtCantidad.Text = "";
                txtObservacion.Text = "";
                cmbfktipo_desperdicio.Focus();
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString(), "FALLO LA APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void imprimirRotulo(Int32 id)
        {
            try
            {
                    //cargo los valores del dataset 
                    impresionRotuloDesperdicio = controladorDsImpresionRotuloDesperdicio.examinarPorId(id);
                    
                    printRotulo.PrinterSettings.PrinterName = sesion.IMPRESORADEROTULOS;
                    printRotulo.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printRotulo_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                CargarFuente();
                e.Graphics.DrawString("CODIGO: "+ impresionRotuloDesperdicio.Id.ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 45, 4);
                e.Graphics.DrawString("ORDEN : "+impresionRotuloDesperdicio.Fkorden_produccion.ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 45, 18);
                e.Graphics.DrawString(impresionRotuloDesperdicio.Maquina+ " "+impresionRotuloDesperdicio.NombreOperador, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, 45, 40);
                e.Graphics.DrawString("PESO  : "+impresionRotuloDesperdicio.Cantidad.ToString()+" Kgs", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 45, 50);
                
               e.Graphics.DrawString(FormatBarCode(impresionRotuloDesperdicio.Id.ToString()), font, Brushes.Black, 45, 65);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printRotulo_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarFuente()
        {
             try
            {
            // CREO EL BYTE[] Y TOMO SU LONGITUD
            byte[] fontArray = PROCON.Properties.Resources.fre3of9x;
            int dataLength = PROCON.Properties.Resources.fre3of9x.Length;


            // ASIGNO MEMORIA Y COPIO BYTE[] EN LA DIRECCION
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);


            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            //PASO LA FUENTE A LA PRIVATEFONTCOLLECTION
            pfc.AddMemoryFont(ptrData, dataLength);

            //LIBERO LA MEMORIA "UNSAFE"
            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 25);
            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
        private string FormatBarCode(string code)
        {
            try
            {
                string barcode = string.Empty;
                barcode = string.Format("*{0}*", code);
                return barcode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


             
    }
}
