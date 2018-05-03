using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace facturayan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrclien f = new agrclien();
            f.Show();
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vercliente f = new vercliente();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            DataTable dgvdatos = oper.cosnsultaconresultado("select * from producto");
            DataTable dc = oper.cosnsultaconresultado("select * from cliente");
            foreach (DataRow dr in dgvdatos.Rows)
            {
                string prod;
                prod = dr["descripcion"].ToString();
                cmbproducto.Items.Add(prod);

            }

            foreach (DataRow dr in dc.Rows)
            {
                string cliet;
                cliet = dr["nombre"].ToString();
                cmbcliente.Items.Add(cliet);
            }


            

        }

        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            DataTable dt = oper.cosnsultaconresultado("select * from producto where descripcion ='" + cmbproducto.Text + "'");
            foreach (DataRow dr in dt.Rows)
            {
                string prec;
                prec = dr["precio"].ToString();
                txtprecio.Text = prec;

            }
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            DataTable dt = oper.cosnsultaconresultado("select * from cliente where nombre ='" + cmbcliente.Text + "'");
            foreach (DataRow dr in dt.Rows)
            {
                string tel, direc,id;
                tel = dr["telefono"].ToString();
                direc = dr["direccion"].ToString();
                txttel.Text = tel;
                txtdirecc.Text = direc;
                id = dr["id_clie"].ToString();
                txtid.Text = id;
            }

        }

        private void btnimpri_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            DataSet ds= new DataSet();
            DataSet ds2 = new DataSet();
            DataTable dt = oper.cosnsultaconresultado("select descrip as Descripcion,cantidad as Cantidad,precio as Precio,(cantidad*precio) as Importe,factura_id_fac as Factura, nombre as Nombre,tel as Telefono,direccion as Direccion  from cotizacion   where factura_id_fac = '" + txtfactn.Text+"' ");
            DataTable dt2 = oper.cosnsultaconresultado("select sum(cantidad*precio) as Total from cotizacion where factura_id_fac = '" + txtfactn.Text + "' ");
            ds.Tables.Add(dt);
            ds2.Tables.Add(dt2);
            ds.WriteXml(@"C:\factura\Factura.xml");
            ds2.WriteXml(@"C:\factura\suma.xml");
            oper.consultasinreaultado("insert into factura(id_fac,fecha)values('" + txtfactn.Text + "','" + dtpfac.Text + "')");
            vso f = new vso();
            f.Show();
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagre_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("insert into cotizacion(descrip,cantidad,precio,nombre,tel,direccion,factura_id_fac)values('" + cmbproducto.Text + "','" + txtcantidad.Text + "','" + txtprecio.Text + "','"+cmbcliente.Text+"','"+txttel.Text+"','"+txtdirecc.Text+"','"+ txtfactn.Text+"')");
            
            dgvcoti.DataSource = oper.cosnsultaconresultado("select descrip as Descripcion,cantidad as Cantidad,precio as Precio,(cantidad*precio) as Importe,factura_id_fac as Factura  from cotizacion where factura_id_fac = '"+txtfactn.Text+"' ");

        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prod f = new prod();
            f.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verpod f = new verpod();
            f.Show();
        }

        private void dgvcoti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcoti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dgvcoti.Rows[e.RowIndex];
            txtfactn.Text = act.Cells["Factura"].Value.ToString();
           

        }
            private void verFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            factu f = new factu();
            f.Show();
        }

        private void txtfactn_TextChanged(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
           dgvcoti.DataSource = oper.cosnsultaconresultado("select descrip as Descripcion,cantidad as Cantidad,precio as Precio,(cantidad*precio) as Importe,factura_id_fac as Factura, nombre as Nombre,tel as Telefono  from cotizacion   where factura_id_fac like '%" + txtfactn.Text + "%' ");

        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarp f = new actualizarp();
            f.Show();
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actcli f = new actcli();
            f.Show();
        }

        private void actualizarCotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actcoti f = new actcoti();
            f.Show();
        }

        private void btnagre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operaciones oper = new operaciones();
                oper.consultasinreaultado("insert into cotizacion(descrip,cantidad,precio,cliente_id_clie,factura_id_fac)values('" + cmbproducto.Text + "','" + txtcantidad.Text + "','" + txtprecio.Text + "','" + txtid.Text + "','" + txtfactn.Text + "')");

                dgvcoti.DataSource = oper.cosnsultaconresultado("select descrip as Descripcion,cantidad as Cantidad,precio as Precio,(cantidad*precio) as Importe,cliente_id_clie as Cliente,factura_id_fac as Factura  from cotizacion where factura_id_fac = '" + txtfactn.Text + "' ");

            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void txtfactn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operaciones oper = new operaciones();
                oper.consultasinreaultado("insert into cotizacion(descrip,cantidad,precio,cliente_id_clie,factura_id_fac)values('" + cmbproducto.Text + "','" + txtcantidad.Text + "','" + txtprecio.Text + "','" + txtid.Text + "','" + txtfactn.Text + "')");

                dgvcoti.DataSource = oper.cosnsultaconresultado("select descrip as Descripcion,cantidad as Cantidad,precio as Precio,(cantidad*precio) as Importe,cliente_id_clie as Cliente,factura_id_fac as Factura  from cotizacion where factura_id_fac = '" + txtfactn.Text + "' ");

            }


        }
    }
}
