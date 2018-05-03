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
    public partial class agrclien : Form
    {
        public agrclien()
        {
            InitializeComponent();
        }

        private void btnagre_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("insert into cliente(nombre,telefono,direccion)values('" + txtnomb.Text + "','"+txttel.Text+"','"+txtdirec.Text+"')");
            MessageBox.Show("Cliente Guardado");
        }
    }
}
