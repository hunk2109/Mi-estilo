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
    public partial class actcli : Form
    {
        public actcli()
        {
            InitializeComponent();
        }

        private void actcli_Load(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            dgvclie.DataSource = oper.cosnsultaconresultado("select * from cliente");
        }

        private void txtbusc_TextChanged(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            dgvclie.DataSource = oper.cosnsultaconresultado("select * from cliente where descripcion like'%" + txtbusc.Text + "%'");
        }

        private void dgvclie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dgvclie.Rows[e.RowIndex];
            txtid.Text = act.Cells["id_clie"].Value.ToString();
            txtnnom.Text = act.Cells["nombre"].Value.ToString();
            txttel.Text = act.Cells["telefono"].Value.ToString();
            txtdirec.Text = act.Cells["direccion"].Value.ToString();

        }

        private void btnborr_Click(object sender, EventArgs e)
        {
            DialogResult result
                = MessageBox.Show("Seguro que desea borrar?", "Borrar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                operaciones oper = new operaciones();
                oper.consultasinreaultado("delete from cliente where id_clie = '" + txtid.Text + "'");
                dgvclie.DataSource = oper.cosnsultaconresultado("select * from cliente");
                MessageBox.Show("Datos borrados");
                txtid.Text = "";
                txtnnom.Text = "";
                txttel.Text = "";
                txtdirec.Text = "";

            }
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("update  producto set nombre = '" + txtnnom.Text + "', telefono = '" + txttel.Text + "', direccion = '"+txtdirec.Text+"' where id_pr = '" + txtid.Text + "'");
            MessageBox.Show("Datos Actualisados");
            dgvclie.DataSource = oper.cosnsultaconresultado("select * from producto");
        }
    }
}
