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
            InitializeComponent();
        }
    }
}
