using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightGaming_V1._0
{
    public partial class FormFinalizarCompra : Form
    {
        //Variables para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormFinalizarCompra()
        {
            InitializeComponent();

        }
        //Error
        private void dgwListaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Error
        private void tbDireccionComprador_TextChanged(object sender, EventArgs e)
        {

        }
        //Metodo load que carga los datos del usuario
        private void FormFinalizarCompra_Load(object sender, EventArgs e)
        {
            var bindingList = new BindingList<Videojuego>(Carrito.juegos);
            var source = new BindingSource(bindingList, null);
            dgwListaCompra.DataSource = source;
            string sqlorder = "SELECT * FROM usuario WHERE Id=@codigo";
            OleDbCommand comando = new OleDbCommand(sqlorder, MainForm.conexion);
            comando.Parameters.AddWithValue("@codigo", LoginInfo.UserCode);
            OleDbDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //MessageBox.Show(Convert.ToString(LoginInfo.UserCode));
                tbNombreComprador.Text = reader.GetString(5);
                tbDireccionComprador.Text = reader.GetString(7);
            }

        }
        //Metodo onclick que finaliza la compra y vacia el carrito
        private void btFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNumeroTarjeta.Text) && !String.IsNullOrEmpty(tbCVC.Text))
            {
                string compra = "";
                Videojuego[] juegos = Carrito.juegos.ToArray();
                int precio = 0;
                for (int i = 0; i < juegos.Length; i++)
                {
                    compra += juegos[i].nombre + '|';
                    precio += juegos[i].precio;
                }
                DateTime today = DateTime.Today;
                string comprafinal = compra.Remove(compra.Length - 1, 1);
                string sql = "INSERT INTO tickets(fecha_compra,precio,usuario_compra,detalles_compra) VALUES(@param1,@param2,@param3,@param4)";
                OleDbCommand comandoinsercion = new OleDbCommand(sql, MainForm.conexion);
                comandoinsercion.Parameters.AddWithValue("@param1", today);
                comandoinsercion.Parameters.AddWithValue("@param2", precio);
                comandoinsercion.Parameters.AddWithValue("@param3", LoginInfo.UserCode);
                comandoinsercion.Parameters.AddWithValue("@param4", comprafinal);
                comandoinsercion.ExecuteNonQuery();
                MessageBox.Show("Compra finalizada");
                Carrito.importe = 0;
                Carrito.juegos.Clear();
                Carrito.productos = String.Empty;
                this.Close();
                
            }
        }

        private void btCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
