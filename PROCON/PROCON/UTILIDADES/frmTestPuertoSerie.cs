using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROCON.UTILIDADES
{
    public partial class frmTestPuertoSerie : Form
    {
        public frmTestPuertoSerie() { InitializeComponent(); }

        #region Funciones

        public void fn_ConfiguraPuertos(String nPuerto, int bAudios, Parity oParidad, int nBits, StopBits nBits_Parada)
        {
            oPuertoSerial = new SerialPort(nPuerto, bAudios, oParidad, nBits, nBits_Parada);
        }
        public void fn_BuscaPuertos()
        {
            string[] oPuertos = SerialPort.GetPortNames();
            cboPuerto.Items.Clear();
            foreach (string oPuerto in oPuertos)
            {
                cboPuerto.Items.Add(oPuerto);
            }
            cboPuerto.Text = "Seleccione Puerto";
        }
        #endregion

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if ((oPuertoSerial != null) && (oPuertoSerial.IsOpen == true))
                oPuertoSerial.Write(txtCadenaEnviar.Text.ToString());
        }

        private void frmTestPuertoSerie_Load(object sender, EventArgs e)
        {
            fn_BuscaPuertos();
            fn_ConfiguraPuertos("COM1", 9600, Parity.None, 8, StopBits.One);
            cboBAudios.Items.Add("1200");
            cboBAudios.Items.Add("2400");
            cboBAudios.Items.Add("4800");
            cboBAudios.Items.Add("9600");
            cboBAudios.Text = "9600";

            cboParidad.Items.Add(Parity.Even.ToString());
            cboParidad.Items.Add(Parity.Mark.ToString());
            cboParidad.Items.Add(Parity.None.ToString());
            cboParidad.Items.Add(Parity.Odd.ToString());
            cboParidad.Items.Add(Parity.Space.ToString());
            cboParidad.Text = "None";
            CheckForIllegalCrossThreadCalls = false;
        }

        private void oPuertoSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            txtCadenaRecibida.Text = oPuertoSerial.ReadExisting();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            Parity oParidad = Parity.None;
            StopBits oBitsParada = StopBits.None;
            int numBits = 8;

            if (cboParidad.Text == "Even")
                oParidad = Parity.Even;
            else if (cboParidad.Text == "Mark")
                oParidad = Parity.Mark;
            else if (cboParidad.Text == "Odd")
                oParidad = Parity.Odd;
            else if (cboParidad.Text == "Space")
                oParidad = Parity.Space;
            else
                oParidad = Parity.None;

            if (rbnParada1.Checked)
                oBitsParada = StopBits.One;
            else
                oBitsParada = StopBits.Two;

            if (rbnBits1.Checked)
                numBits = 7;
            else
                numBits = 8;

            fn_ConfiguraPuertos(cboPuerto.Text, Convert.ToInt32(cboBAudios.Text), oParidad, numBits, oBitsParada);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (oPuertoSerial != null)
            {
                oPuertoSerial.Open();
                //MessageBox.Show("Puerto abierto");
                btnAbrir.Enabled = false;
                btnCerrar.Enabled = true; 
                oPuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(oPuertoSerial_DataReceived);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (oPuertoSerial != null)
            {
                if (oPuertoSerial.IsOpen == true)
                {
                    oPuertoSerial.Close();
                    //MessageBox.Show("Puerto cerrado");
                    btnCerrar.Enabled = false;
                    btnAbrir.Enabled = true;
                }
            }
        }
    }
}
