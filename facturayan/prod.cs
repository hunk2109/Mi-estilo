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
    public partial class prod : Form
    {
        public prod()
        {
            InitializeComponent();
        }

        private void btnagre_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("insert into producto(descripcion,precio)values('"+txtdecrip.Text+"','"+txtprecio.Text+"')");
            MessageBox.Show("Datos Guardados");
            txtprecio.Text = "";
            txtdecrip.Text = "";
        }
    }
}
