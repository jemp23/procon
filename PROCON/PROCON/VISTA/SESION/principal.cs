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
            try
            {
                InitializeComponent();

                //crea los nodos segun los permisos del usuario
                CrearNodosDelPadre(0, null);

                //nodo para salir del sistema
                TreeNode nuevoNodo2 = new TreeNode();
                nuevoNodo2.Text = "SALIR DEL SISTEMA";
                nuevoNodo2.Tag = "salir";
                nuevoNodo2.ImageIndex = 2;
                treeView1.Nodes.Add(nuevoNodo2);


                this.Text = "BIENVENIDOS A " + sesion.NOMBREAPLICACION + " FORMULARIO PRINCIPAL" ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
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
                    case "MODULOS":
                        SESION.modulos.DefInstance.MdiParent = this;
                        SESION.modulos.DefInstance.Show();
                        break;

                    case "USUARIO":

                        USUARIO.usuario.DefInstance.MdiParent = this;
                        USUARIO.usuario.DefInstance.Show();
                        break;

                    case "TIPOUSUARIO":
                        USUARIO.tipoUsuario.DefInstance.MdiParent = this;
                        USUARIO.tipoUsuario.DefInstance.Show();
                        break;

                    case "salir":
                        Application.Exit();
                        break;

                    default:
                        //MessageBox.Show("ESTE MENU NO TIENE FORMULARIO ASIGNADO", sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            try
            {

                treeView1.Visible = false;
                splitter1.Width = 50;
                BtnMinimizar.Visible = false;
                btnMaximizar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            try
            {

                treeView1.Visible = true;
                splitter1.Width = 245;
                btnMaximizar.Visible = false;
                BtnMinimizar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
