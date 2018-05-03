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
    public partial class verpod : Form
    {
        public verpod()
        {
            InitializeComponent();
        }

        private void verpod_Load(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
           dataGridView1.DataSource = oper.cosnsultaconresultado("select * from producto");
        }
    }
}
