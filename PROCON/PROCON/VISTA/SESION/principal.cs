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

namespace PROCON.VISTA.SESION
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
            CrearNodosDelPadre(0, null);
        }

        private void principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void CrearNodosDelPadre(int indicePadre, TreeNode nodePadre)
        {
            // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.

            DataTable dt = sesion.listarMenu().Tables[0];

            DataView dataViewHijos =  dt.DefaultView;


            dataViewHijos.RowFilter = dt.Columns["superior"].ColumnName + " = " + indicePadre;

            // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["descripcion"].ToString().Trim();
                nuevoNodo.Tag = dataRowCurrent["direccion"].ToString().Trim();

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

                CrearNodosDelPadre(Int32.Parse(dataRowCurrent["id"].ToString()), nuevoNodo);
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {

            try
            {

                TreeNode node = treeView1.SelectedNode;
                string nodoSeleccionado = node.Tag.ToString();


                switch (nodoSeleccionado)
                { 
                    case "USUARIO":

                        USUARIO.usuario.DefInstance.MdiParent = this;
                        USUARIO.usuario.DefInstance.Show();
                        break;

                    default:
                        MessageBox.Show("ESTE MENU NO TIENE FORMULARIO ASIGNADO", sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void treeView1_MouseEnter(object sender, EventArgs e)
        {
            try
            {

                treeView1.Width = 350;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void treeView1_MouseLeave(object sender, EventArgs e)
        {
            try
            {

                treeView1.Visible = false;
                splitter1.Width = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void splitter1_MouseEnter(object sender, EventArgs e)
        {
            try
            {

                treeView1.Visible = true;
                splitter1.Width = 226;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void splitter1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
