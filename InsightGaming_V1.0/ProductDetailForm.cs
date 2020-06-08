using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightGaming_V1._0
{

    public partial class ProductDetailForm : Form
    {
        //Variables para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Variables de datos temporales de producto
        public string[] datos;
        public string titulo;
        public string imagen;
        public int rating;
        public int metacritic;
        public string raw;
        public string video;
        public string datosstring;
        public static bool confirmacion_compra = false;
        public ProductDetailForm()
        {
            InitializeComponent();
        }
        //Metodo load() donde se cargan todos los datos
        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            confirmacion_compra = false;
            datos = datosstring.Split('|');
            raw = datos[3];
            rating = Convert.ToInt32(raw[0]);
            metacritic = Convert.ToInt32(raw[1] + raw[2]);
            laMetacritic.Text = "Metacritic: "+raw[1]+raw[2];
            laRating.Text = "Rating: " + raw[0];
            laTitulo.Text = datos[0] ;
            pbFondo.ImageLocation = datos[1];
            laTitulo.Text = laTitulo.Text.ToUpper();
            
            laTitulo.Parent = pbFondo;
            laTitulo.BackColor = Color.Transparent;
            laRating.Parent = pbFondo;
            laRating.BackColor = Color.Transparent;
            laMetacritic.Parent = pbFondo;
            laMetacritic.BackColor = Color.Transparent;
            btComprar.Text="AGREGAR A CARRITO - "+datos[4]+"€";
            btComprar.Parent = pbFondo;
            btComprar.BackColor = Color.Transparent;
        }

        private void wbVideo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        //Metodo click del boton de comprar
        private void btComprar_Click(object sender, EventArgs e)
        {
            Carrito.productos += this.titulo+"|";
            Carrito.importe += Convert.ToInt32(this.datos[4]);
            confirmacion_compra = true;
            Videojuego juego = new Videojuego();
            juego.nombre = datos[0];
            juego.precio = Convert.ToInt32(datos[4].Trim());
            Carrito.juegos.Add(juego);
            MessageBox.Show("Agregado Correctamente al carrito");
            this.Close();
        }

        private void pbFondo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Errores
        private void laMetacritic_Click(object sender, EventArgs e)
        {

        }

        private void laRating_Click(object sender, EventArgs e)
        {

        }

        private void pbFondo_Click(object sender, EventArgs e)
        {

        }

        private void laPrecio_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //
    }
}
