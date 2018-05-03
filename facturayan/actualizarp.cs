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
    public partial class actualizarp : Form
    {
        public actualizarp()
        {
            InitializeComponent();
        }

        private void actualizarp_Load(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            dgvactu.DataSource = oper.cosnsultaconresultado("select * from producto");
        }

        private void dgvactu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            operaciones oper = new operaciones();
            dgvactu.DataSource = oper.cosnsultaconresultado("select * from producto where descripcion like'%"+txtbucar.Text+"%'");

        }

        private void btnact_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("update  producto set descripcion = '"+txtprod.Text+"', precio = '"+txtpreci.Text+"' where id_pr = '"+txtid.Text+"'");
            MessageBox.Show("Datos Actualisados");
            dgvactu.DataSource = oper.cosnsultaconresultado("select * from producto");

        }

        private void dgvactu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dgvactu.Rows[e.RowIndex];
            txtid.Text = act.Cells["id_pr"].Value.ToString();
            txtprod.Text = act.Cells["descripcion"].Value.ToString();
            txtpreci.Text = act.Cells["precio"].Value.ToString();
           
        }

        private void btnborr_Click(object sender, EventArgs e)
        {
           DialogResult result
                = MessageBox.Show("Seguro que desea borrar?", "Borrar", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                operaciones oper = new operaciones();
                oper.consultasinreaultado("delete from producto where id_pr = '"+txtid.Text+"'");
                dgvactu.DataSource = oper.cosnsultaconresultado("select * from producto");
                MessageBox.Show("Datos borrados");
                txtid.Text = "";
                txtpreci.Text = "";
                txtprod.Text = "";

            }


            

            
                

               
        }
    }
}
