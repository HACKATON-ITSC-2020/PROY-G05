using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StockTrail
{
    public partial class FrmModificar : Form
    {
        static string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=farmacia;";
        public FrmModificar()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {

        }
        private void Actualizar()
        {
            string sql = "UPDATE prodfar SET Nombre ='" + txtNombre.Text + "', Cantidad='" + txtCantidad.Text + "',Importe='" + txtPrecioUnitario.Text + "',Proveedor='" + txtProveedor.Text + "'WHERE Producto =" + txtIdProd.Text+"";
            MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                commandDatabase.CommandText = sql;
                commandDatabase.Connection = databaseConnection;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("DATO ACTUALIZADO CORRECTAMENTE");
                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtIdProd.Text = "";
                txtPrecioUnitario.Text = "";
                txtProveedor.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        
    }
}
