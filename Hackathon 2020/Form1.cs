using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_2020
{
    public partial class Farmacia : Form
    {
        private int n = 0;

        public Farmacia()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Adiciamos nuevo renglon

            int n = dtg.Rows.Add();

            //Colocamos la informacion 

            dtg.Rows[n].Cells[0].Value = txtProducto.Text;
            dtg.Rows[n].Cells[1].Value = dtpFechadeIngreso.Value;
            dtg.Rows[n].Cells[2].Value = nudCantidad.Value;
            dtg.Rows[n].Cells[3].Value = dtpFechadeElaboracion.Value;
            dtg.Rows[n].Cells[4].Value = dtpFechadeVencimiento.Value;

            //Limpiamos los campos

            txtProducto.Text = "";
        
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            n = e.RowIndex;

            if(n!=-1)
            {
                lblCantidad.Text = (string)dtg.Rows[n].Cells[1].Value;

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n!=-1)
            {
                dtg.Rows.RemoveAt(n);

            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
