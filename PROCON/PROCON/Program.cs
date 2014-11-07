using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PROCON.CONEXION;
using PROCON.VISTA.SESION;
using System.Configuration;

namespace laboratorius
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Conexion conexion = new Conexion();
            conexion.getConexion();

            if (conexion.estatusConexion == false)
            {

                string RES = MessageBox.Show("ERROR CONECTANDO AL SERVIDOR DE DATOS \n Si = Reconectar \n No = Configurar Conexión \n Cancelar = Cerrar el Sistema", "Fallo la Conexión", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).ToString();
                if (RES == "Yes")
                {
                    conexion.getConexion();
                }
                else
                {
                    if (RES == "No") Application.Run(new configurarConexion());
                    else Application.Exit();
                }


            }
            else Application.Run(new acceso());



            //encripto la conexion
            try
            {
                //EncryptConnectionStrings();
            }
            catch { }
        }

        /*static void EncryptConnectionStrings()
                {
                    Configuration config = ConfigurationManager.
                          OpenExeConfiguration
                          (ConfigurationUserLevel.None);
                    ConfigurationSection section =
                        config.GetSection("connectionStrings");
                    if (section != null)
                    {
                        if (!section.IsReadOnly())
                        {
                            if (!section.SectionInformation.IsProtected)
                            {
                                section.SectionInformation.ProtectSection
                               ("DataProtectionConfigurationProvider");
                                section.SectionInformation.
                                      ForceSave = true;
                                config.Save(ConfigurationSaveMode.Full);
                            }
                        }
                    }
        
                }*/
    }
}
