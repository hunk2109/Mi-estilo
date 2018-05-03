using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturayan
{
    public partial class vercliente : Form
    {
        public vercliente()
        {
            InitializeComponent();
        }

        private void vercliente_Load(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
           dgvclien.DataSource = oper.cosnsultaconresultado("select id_clie as ID,nombre as Nombre,telefono as Telefono,direccion as Direccion from cliente");
        }
    }
}
