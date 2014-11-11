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

                for (int i = 0; i <= 30; i++)
                {
                    cmbSuperior.Items.Add(i);
                }
                cmbSuperior.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbSuperior.SelectedItem = 0;


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
                cmbSuperior.DataBindings.Add(new Binding("SelectedItem", bindingSource1, "superior", true));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
