using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form2 : Form
    {
        manttoPuesto objPuesto = new manttoPuesto();

        public Form2()
        {
            InitializeComponent();
        }

        private void cbbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPuesto.dt.Clear();
            cbbArea.Refresh();
            cbbArea.DataSource = null;
            objPuesto.mostrarPuesto();
            cbbArea.DataSource = objPuesto.dt;
            cbbArea.ValueMember = "AREA";
            cbbArea.DisplayMember = "DESCRIPCION";
        }
    }
}
