using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Security.Cryptography;

namespace InsightGaming_V1._0
{

    public partial class MainForm : Form
    {
        //Variables para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static OleDbConnection conexion;
        public MainForm()
        {

            InitializeComponent();







            /*System.Net.WebRequest request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_size=50");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            String jsonstring = reader.ReadToEnd();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            //var records =  ser.Deserialize<List<Videojuego>>(jsonstring);
            var resultado = JsonConvert.DeserializeObject<VideoJuegos>(jsonstring);
           

            //List<Videojuego> lista = new List<Videojuego>();
            //lista.Add(resultado);
            dgwProductosDestacados.DataSource = resultado.Results;
            //MessageBox.Show(juego);
            pbLetrero.ImageLocation = ".\\basedatos\\gif_principal.gif";
            timer1.Start();*/

        }
        //Metodo de llamada a la api y carga del formulario principal
        public void load()
        {
            //Operaciones de llamada a la api
            System.Net.WebRequest request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_size=50");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            String jsonstring = reader.ReadToEnd();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            //var records =  ser.Deserialize<List<Videojuego>>(jsonstring);
            var resultado = JsonConvert.DeserializeObject<VideoJuegos>(jsonstring);


            //List<Videojuego> lista = new List<Videojuego>();
            //lista.Add(resultado);
            dgwProductosDestacados.DataSource = resultado.Results;
            //Carga de la imagen principal
            pbLetrero.ImageLocation = ".\\basedatos\\gif_principal.gif";
            timer1.Start();

            //String de conexion a la base de datos
            string connection_string = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\basedatos\bd_gaminginsight.mdb");
            conexion = new OleDbConnection(connection_string);
            //Comprobaciones en la carga para loguear con tu cuenta.
            try
            {
                conexion.Open();
            }
            catch (Exception)
            {

            }
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            recogida_datos();
            if (!String.IsNullOrEmpty(LoginInfo.UserName))
            {
                laNombreUsuario.Text = LoginInfo.UserName;
            }
            if (LoginInfo.imagen != "!")
            {
                pbImagenUsuario.ImageLocation = LoginInfo.imagen;
            }
            else
            {
                pbImagenUsuario.ImageLocation = "C:/Users/Zer0/source/repos/InsightGaming_V1.0/InsightGaming_V1.0/bin/Debug/basedatos/defaultavatar.png";
            }
            laPuntos.Text = "¡Tienes " + LoginInfo.Puntos.ToString() + " puntos!";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            /*string connection_string = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\basedatos\bd_gaminginsight.mdb");
            conexion = new OleDbConnection(connection_string);
            try
            {
                conexion.Open();
            }
            catch (Exception)
            {

            }
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            recogida_datos();
            if (!String.IsNullOrEmpty(LoginInfo.UserName))
            {
                laNombreUsuario.Text = LoginInfo.UserName;
            }
            if (LoginInfo.imagen!="!")
            {
                pbImagenUsuario.ImageLocation = LoginInfo.imagen;
            }
            else
            {
                pbImagenUsuario.ImageLocation = "C:/Users/Zer0/source/repos/InsightGaming_V1.0/InsightGaming_V1.0/bin/Debug/basedatos/defaultavatar.png";
            }
            laPuntos.Text = "¡Actualmente tienes " + LoginInfo.Puntos.ToString() + " puntos!";*/
            load();
            //Aqui solo se carga este metodo
        }
        //Metodo que recoge los datos para ver si alguien se ha logueado y pone los distintos mensajes segun la respuesta
        public void recogida_datos()
        {
            if (LoginInfo.UserName != null)
            {
                laBienvenida.Text = "¡Bienvenido de vuelta " + LoginInfo.UserName + " !";
                btLogOut.Visible = true;
                btIniciarSesion.Visible = false;
            }
            else
            {
                laBienvenida.Text = "¡Hola bienvenido a Insight Gaming, pulsa en iniciar sesion para acceder a todo el contenido del que disponemos !";
                btLogOut.Visible = false;
                btIniciarSesion.Visible = true;
            }
        }
        //Boton de Login
        private void btLogin_Click(object sender, EventArgs e)
        {
            FormLogin fmLogin = new FormLogin();
            fmLogin.ShowDialog();
        }
        //Metodos para controlar los botones de cierre minimizar y maximizar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbRestaurar.Visible = true;
            pbMaximizar.Visible = false;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }
        //Metodo de animacion del letrero
        private void timer1_Tick(object sender, EventArgs e)
        {
            laBienvenida.Location = new Point(laBienvenida.Location.X + 5, laBienvenida.Location.Y);

            if (laBienvenida.Location.X > this.Width)
            {
                laBienvenida.Location = new Point(0 - laBienvenida.Width, laBienvenida.Location.Y);
            }
        }
        //Metodo para mover la ventana
        private void pnlButtons_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        //Metodo para llamar al formulario de login para iniciar sesion
        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            if (LoginInfo.UserName != null)
            {
                recogida_datos();
            }

        }
        //Metodo para acceder a las opciones de usuario
        private void btOpcionesUsuario_Click(object sender, EventArgs e)
        {
            if (LoginInfo.UserName == null)
            {

            }
            else
            {
                formOpciones formOpciones = new formOpciones();
                formOpciones.ShowDialog();
            }
        }
        //Metodo para hacer logout de la aplicacion
        private void btLogOut_Click(object sender, EventArgs e)
        {
            LoginInfo.Email = "";
            LoginInfo.imagen = "";
            LoginInfo.Puntos = 0;
            LoginInfo.UserCode = 0;
            LoginInfo.UserName = "";
            LoginInfo.Usertype = 0;
            Carrito.juegos = null;
            Carrito.importe = 0;
            Carrito.productos = "";
            this.Controls.Clear();
            this.InitializeComponent();
            this.load();

        }
        //Metodo para mostrar la galeria de productos
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(LoginInfo.Email)) { 
            ProductGalleryForm formProductos = new ProductGalleryForm();
            formProductos.ShowDialog();
            }
            else
            {
                btProductos.ForeColor = Color.DimGray;
                
            }
        }
        //Metodo para ordenar el datagrid que recoge los datos de la api
        private void RbtAccion_CheckedChanged(object sender, EventArgs e)
        {
           RadioButton btn= sender as RadioButton;
    
            
            System.Net.WebRequest request = HttpWebRequest.Create("https://api.rawg.io/api/games?genre=action&page_Size=20");
            if (btn != null && btn.Checked)
            {
                switch (btn.Name)
                {
                    case "RbtAccion":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_Size=20");
                        break;
                    case "RbtRpg":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=role-playing-games-rpg&page_Size=20");
                        break;
                    case "RbtShooter":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=shooter&page_Size=20");
                        break;
                    case "RbtDeportes":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=sports&page_Size=20");
                        break;
                    case "RbtAventura":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=adventure&page_Size=20");
                        break;
                    case "RbtSimulador":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=simulation&page_Size=20");
                        break;
                    case "RbtEstrategia":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=strategy&page_Size=20");
                        break;
                    case "RbtIndie":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=indie&page_Size=20");
                        break;

                }
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                String jsonstring = reader.ReadToEnd();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                //var records =  ser.Deserialize<List<Videojuego>>(jsonstring);
                var resultado = JsonConvert.DeserializeObject<VideoJuegos>(jsonstring);
                //List<Videojuego> lista = new List<Videojuego>();
                //lista.Add(resultado);
                dgwProductosDestacados.DataSource = resultado.Results;
            }
        }

        private void dgwProductosDestacados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        //Metodo para ordenar el datagridview
        private void rbtRating_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton btn = sender as RadioButton;
            System.Net.WebRequest request = HttpWebRequest.Create("https://api.rawg.io/api/games?genre=action&page_Size=20");
            if (btn != null && btn.Checked)
            {
                switch (btn.Name)
                {
                    case "rbtRating":
                        if (RbtAccion.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_Size=20&ordering=rating");

                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_Size=20&ordering=-rating");
                            }
                        }
                        if (RbtRpg.Checked)
                        {
                          
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=role-playing-games-rpg&page_Size=20&ordering=rating");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=role-playing-games-rpg&page_Size=20&ordering=-rating");
                            }
                           
                        }
                        if (RbtShooter.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=shooter&page_Size=20&ordering=rating");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=shooter&page_Size=20&ordering=-rating");
                            }
                        }
                        if (RbtDeportes.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=sports&page_Size=20&ordering=rating");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=sports&page_Size=20&ordering=-rating");
                            }
                           
                        }
                        if (RbtAventura.Checked)
                        {
                          
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=adventure&page_Size=20&ordering=rating");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=adventure&page_Size=20&ordering=-rating");
                            }
                            
                        }
                        if (RbtSimulador.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=simulation&page_Size=20&ordering=rating");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=simulation&page_Size=20&ordering=-rating");
                            }
                            
                        }
                        if (RbtEstrategia.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=strategy&page_Size=20&ordering=rating");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=strategy&page_Size=20&ordering=-rating");
                            }
                            
                        }

                        if (RbtIndie.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=indie&page_Size=20&ordering=rating");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=indie&page_Size=20&ordering=-rating");
                            }
                            
                        }
                        break;
                    case "rbtAñadido":
                        if (RbtAccion.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_Size=20&ordering=added");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_Size=20&ordering=-added");
                            }
                        }
                        if (RbtRpg.Checked)
                        {
                            
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=role-playing-games-rpg&page_Size=20&ordering=added");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=role-playing-games-rpg&page_Size=20&ordering=-added");
                            }

                        }
                        if (RbtShooter.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=shooter&page_Size=20&ordering=added");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=shooter&page_Size=20&ordering=-added");
                            }
                        }
                        if (RbtDeportes.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=sports&page_Size=20&ordering=added");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=sports&page_Size=20&ordering=-added");
                            }

                        }
                        if (RbtAventura.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=adventure&page_Size=20&ordering=added");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=adventure&page_Size=20&ordering=-added");
                            }

                        }
                        if (RbtSimulador.Checked)
                        {
                            
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=simulation&page_Size=20&ordering=added");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=simulation&page_Size=20&ordering=-added");
                            }

                        }
                        if (RbtEstrategia.Checked)
                        {
                            
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=strategy&page_Size=20&ordering=added");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=strategy&page_Size=20&ordering=-added");
                            }

                        }

                        if (RbtIndie.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=indie&page_Size=20&ordering=added");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=indie&page_Size=20&ordering=-added");
                            }

                        }

                        break;
                    case "rbtNombre":
                        if (RbtAccion.Checked)
                        {
                            
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_Size=20&ordering=name");

                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_Size=20&ordering=-name");
                            }
                        }
                        if (RbtRpg.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=role-playing-games-rpg&page_Size=20&ordering=name");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=role-playing-games-rpg&page_Size=20&ordering=-name");
                            }

                        }
                        if (RbtShooter.Checked)
                        {
                           
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=shooter&page_Size=20&ordering=name");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=shooter&page_Size=20&ordering=-name");
                            }
                        }
                        if (RbtDeportes.Checked)
                        {
                         
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=sports&page_Size=20&ordering=name");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=sports&page_Size=20&ordering=-name");
                            }

                        }
                        if (RbtAventura.Checked)
                        {
                          
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=adventure&page_Size=20&ordering=name");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=adventure&page_Size=20&ordering=-name");
                            }

                        }
                        if (RbtSimulador.Checked)
                        {
                          
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=simulation&page_Size=20&ordering=name");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=simulation&page_Size=20&ordering=-name");
                            }

                        }
                        if (RbtEstrategia.Checked)
                        {
                            
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=strategy&page_Size=20&ordering=name");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=strategy&page_Size=20&ordering=-name");
                            }

                        }

                        if (RbtIndie.Checked)
                        {
                          
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=indie&page_Size=20&ordering=name");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=indie&page_Size=20&ordering=-name");
                            }

                        }
                        break;
                    case "rbtLanzamiento":
                        if (RbtAccion.Checked)
                        {
                        
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_Size=20&ordering=released");

                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_Size=20&ordering=-released");
                            }
                        }
                        if (RbtRpg.Checked)
                        {
                       
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=role-playing-games-rpg&page_Size=20&ordering=released");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=role-playing-games-rpg&page_Size=20&ordering=-released");
                            }

                        }
                        if (RbtShooter.Checked)
                        {
                         
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=shooter&page_Size=20&ordering=released");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=shooter&page_Size=20&ordering=-released");
                            }
                        }
                        if (RbtDeportes.Checked)
                        {
                       
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=sports&page_Size=20&ordering=released");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=sports&page_Size=20&ordering=-released");
                            }

                        }
                        if (RbtAventura.Checked)
                        {

                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=adventure&page_Size=20&ordering=released");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=adventure&page_Size=20&ordering=-released");
                            }

                        }
                        if (RbtSimulador.Checked)
                        {
                      
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=simulation&page_Size=20&ordering=released");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=simulation&page_Size=20&ordering=-released");
                            }

                        }
                        if (RbtEstrategia.Checked)
                        {
                      
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=strategy&page_Size=20&ordering=released");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=strategy&page_Size=20&ordering=-released");
                            }

                        }

                        if (RbtIndie.Checked)
                        {

                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=indie&page_Size=20&ordering=released");
                            
                            if (rbtDescendente.Checked)
                            {
                                request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=indie&page_Size=20&ordering=-released");
                            }

                        }
                        break;
                }
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                String jsonstring = reader.ReadToEnd(); 
                var resultado = JsonConvert.DeserializeObject<VideoJuegos>(jsonstring);
                dgwProductosDestacados.DataSource = resultado.Results;
            }
        }

        private void pbLetrero_Click(object sender, EventArgs e)
        {

        }
        //Metodo para reactivar el formulario principal cuando se realiza una compra
        private void MainForm_Activated(object sender, EventArgs e)
        {
            recogida_datos();
           
            if (Carrito.juegos.Count>0)
            {
                laCantidadCarrito.Text = Convert.ToString(Carrito.juegos.Count);
                laCantidadCarrito.BackColor = Color.GreenYellow;
                ProductDetailForm.confirmacion_compra = false;
            }
        }
        //Metodo para abrir el dialogo donde se realiza el pago del carrito
        private void btCarritoFinalizarCompra_Click(object sender, EventArgs e)
        {
            FormFinalizarCompra finalizarCompra = new FormFinalizarCompra();
            finalizarCompra.ShowDialog();
        }
    }
}

