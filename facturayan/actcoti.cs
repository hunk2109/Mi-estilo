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
    public partial class actcoti : Form
    {
        public actcoti()
        {
            InitializeComponent();
        }

        private void actcoti_Load(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            dgvcot.DataSource = oper.cosnsultaconresultado("select * from cotizacion");
        }

        private void dgvcot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dgvcot.Rows[e.RowIndex];
            txtid.Text = act.Cells["id_cot"].Value.ToString();
            txtprod.Text = act.Cells["descrip"].Value.ToString();
            txtcan.Text = act.Cells["cantidad"].Value.ToString();
            txtprec.Text = act.Cells["precio"].Value.ToString();
           
            txtidfac.Text = act.Cells["factura_id_fac"].Value.ToString();
            
        }

        private void txtbusc_TextChanged(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            dgvcot.DataSource = oper.cosnsultaconresultado("select * from cotizacion where factura_id_fac like '%"+txtbusc.Text+"%' ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("update  cotizacion set cantidad = '" + txtcan.Text + "', cliente_id_clie = '" + txtidclien.Text + "' where id_pr = '" + txtid.Text + "'");
            MessageBox.Show("Datos Actualisados");
            dgvcot.DataSource = oper.cosnsultaconresultado("select * from cotizacion");
        }

        private void btnborr_Click(object sender, EventArgs e)
        {
            DialogResult result
               = MessageBox.Show("Seguro que desea borrar?", "Borrar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                operaciones oper = new operaciones();
                oper.consultasinreaultado("delete from cotizacion where id_cot = '" + txtid.Text + "'");
                dgvcot.DataSource = oper.cosnsultaconresultado("select * from cotizacion");
                MessageBox.Show("Datos borrados");
                txtid.Text = "";
                txtprec.Text = "";
                txtprod.Text = "";
                txtidfac.Text = "";
                txtidclien.Text = "";
                txtcan.Text = "";

            }
        }
    }
}
