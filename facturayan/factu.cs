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
    public partial class factu : Form
    {
        public factu()
        {
            InitializeComponent();
        }

        private void factu_Load(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
           dataGridView1.DataSource = oper.cosnsultaconresultado("select * from factura");
        }
    }
}
