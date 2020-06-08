using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace InsightGaming_V1._0
{
    public partial class ProductGalleryForm : Form
    {
        //variables para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //
        //Array de datos para taspasar
        public static string[] traspaso_datos;
        public ProductGalleryForm()
        {
            InitializeComponent();
        }
        //Metodo load () que hace que aparezca el formulario
        private void ProductGalleryForm_Load(object sender, EventArgs e)
        {
            if (LoginInfo.Usertype == 0)
            {
                btRecargarStock.Visible = false;
            }
            else
            {
                btRecargarStock.Visible = true;
            }
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = false;
            panel1.VerticalScroll.Visible = false;
            panel1.AutoScroll = true;
            AutoScrollMinSize = new Size(panel2.Width + 200, panel2.Height + 1600);
            /*      string sqlorder = "SELECT * FROM productos ";
                  sqlorder = sqlorder + "WHERE genero=@genero";
                  OleDbCommand command = new OleDbCommand(sqlorder, MainForm.conexion);
                  command.Parameters.AddWithValue("@genero","accion");
                  OleDbDataReader reader = command.ExecuteReader();
                  List<Videojuego> direcciones_1=new List<Videojuego>();
                  Videojuego[] direcciones;
                  while (reader.Read())
                  {
                      Videojuego tmpObjetoVideojuego = new Videojuego(); 
                      tmpObjetoVideojuego.direccionImagen=(reader.GetString(5));
                      tmpObjetoVideojuego.nombre = (reader.GetString(1));
                      tmpObjetoVideojuego.rating = (reader.GetInt32(6));
                      tmpObjetoVideojuego.metacritic = (reader.GetInt32(7));
                      tmpObjetoVideojuego.clip = (reader.GetString(8));
                      tmpObjetoVideojuego.precio = (reader.GetInt32(4));
                      direcciones_1.Add(tmpObjetoVideojuego);
                  }
                  direcciones = direcciones_1.ToArray();
                  //MessageBox.Show(direcciones.Length.ToString());
                  AutoScrollMinSize = new Size(panel2.Width + 1000, panel2.Height +1000);
                  Size size = new Size(200, 200);
                  int rows = 10;
                  int columns = 4;
                  int x = 47;
                  int y = 49;
                  int totalBoxes = rows * columns;
                  List<PictureBox> pictureBoxList = new List<PictureBox>();
                  for (int i = 0; i <totalBoxes; i++)
                  {
                      int curentColumn = i % columns;
                      int currentRow  = i / columns;
                      int curentX = x + curentColumn * size.Width;
                      int curentY = y + currentRow * size.Height;
                      string tag= direcciones[i].rating.ToString() + direcciones[i].metacritic.ToString();
                      string nombre = direcciones[i].nombre;
                      string imagen = direcciones[i].direccionImagen;
                      string video = direcciones[i].clip;
                      string precio = direcciones[i].precio.ToString();
                      traspaso_datos = new string[5];
                      traspaso_datos[0] = nombre;
                      traspaso_datos[1] = imagen;
                      traspaso_datos[2] = video;
                      traspaso_datos[3] = tag;
                      traspaso_datos[4] = precio;
                      PictureBox picture = new PictureBox
                      {
                          Name = direcciones[i].nombre,
                          Size = size,
                          Tag = tag ,
                          AccessibleName=direcciones[i].clip,
                          Location = new Point(curentX, curentY),
                          BorderStyle = BorderStyle.Fixed3D,
                          SizeMode = PictureBoxSizeMode.Zoom,
                          Visible = true

                      };
                      picture.ImageLocation = direcciones[i].direccionImagen;
                      picture.SizeMode = PictureBoxSizeMode.StretchImage;
                      picture.Click += new EventHandler(evento);


                      panel2.Controls.Add(picture);
                      pictureBoxList.Add(picture);
                  }*/

        }
        //Error
        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }
        //Evento que crea el evento on click en cada articulo
        protected void evento(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            ProductDetailForm formDetalle = new ProductDetailForm();
            formDetalle.datosstring = pb.AccessibleDescription;
            formDetalle.ShowDialog();

            // identify which button was clicked and perform necessary actions
        }
        //Error
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //Metodo que checkea si un radiobutton cambia y reasigna los pictureboxes
        private void rbListaAccion_CheckedChanged(object sender, EventArgs e)
        {
            string sqlorder = "";
            RadioButton btn = sender as RadioButton;
            panel2.Controls.Clear();
            switch (btn.Name)
            {
                case "rbListaAccion":
                    if (rbListaPrecio4060.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='accion' AND precio BETWEEN 40 AND 60";
                    }
                    if (rbListaPrecio2040.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='accion' AND precio BETWEEN 20 AND 40";
                    }
                    if (rbListaPreciomenos20.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='accion' AND precio <20";
                    }
                    if (rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='accion' AND precio <20";
                    }
                    if (!rbListaPrecio4060.Checked && !rbListaPrecio2040.Checked && !rbListaPreciomenos20.Checked && !rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='accion'";
                    }
                    break;
                case "rbListaRPG":
                    if (rbListaPrecio4060.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='rpg' AND precio BETWEEN 40 AND 60";
                    }
                    if (rbListaPrecio2040.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='rpg' AND precio BETWEEN 20 AND 40";
                    }
                    if (rbListaPreciomenos20.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='rpg' AND precio <20";
                    }
                    if (rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='rpg' AND precio <20";
                    }
                    if (!rbListaPrecio4060.Checked && !rbListaPrecio2040.Checked && !rbListaPreciomenos20.Checked && !rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='rpg'";
                    }
                    break;
                case "rbListaShooter":
                    if (rbListaPrecio4060.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='shooter' AND precio BETWEEN 40 AND 60";
                    }
                    if (rbListaPrecio2040.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='shooter' AND precio BETWEEN 20 AND 40";
                    }
                    if (rbListaPreciomenos20.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='shooter' AND precio <20";
                    }
                    if (rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='shooter' AND precio <20";
                    }
                    if (!rbListaPrecio4060.Checked && !rbListaPrecio2040.Checked && !rbListaPreciomenos20.Checked && !rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='shooter'";
                    }
                    break;
                case "rbListaDeportes":
                    if (rbListaPrecio4060.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='sports' AND precio BETWEEN 40 AND 60";
                    }
                    if (rbListaPrecio2040.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='sports' AND precio BETWEEN 20 AND 40";
                    }
                    if (rbListaPreciomenos20.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='sports' AND precio <20";
                    }
                    if (rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='sports' AND precio <20";
                    }
                    if (!rbListaPrecio4060.Checked && !rbListaPrecio2040.Checked && !rbListaPreciomenos20.Checked && !rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='sports'";
                    }
                    break;
                case "rbListaAventuras":
                    if (rbListaPrecio4060.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='aventura' AND precio BETWEEN 40 AND 60";
                    }
                    if (rbListaPrecio2040.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='aventura' AND precio BETWEEN 20 AND 40";
                    }
                    if (rbListaPreciomenos20.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='aventura' AND precio <20";
                    }
                    if (rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='aventura' AND precio <20";
                    }
                    if (!rbListaPrecio4060.Checked && !rbListaPrecio2040.Checked && !rbListaPreciomenos20.Checked && !rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='aventura'";
                    }
                    break;
                case "rbListaSimulacion":
                    if (rbListaPrecio4060.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='simulacion' AND precio BETWEEN 40 AND 60";
                    }
                    if (rbListaPrecio2040.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='simulacion' AND precio BETWEEN 20 AND 40";
                    }
                    if (rbListaPreciomenos20.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='simulacion' AND precio <20";
                    }
                    if (rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='simulacion' AND precio <20";
                    }
                    if (!rbListaPrecio4060.Checked && !rbListaPrecio2040.Checked && !rbListaPreciomenos20.Checked && !rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='simulacion'";
                    }
                    break;
                case "rbListaEstrategia":
                    if (rbListaPrecio4060.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='estrategia' AND precio BETWEEN 40 AND 60";
                    }
                    if (rbListaPrecio2040.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='estrategia' AND precio BETWEEN 20 AND 40";
                    }
                    if (rbListaPreciomenos20.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='estrategia' AND precio <20";
                    }
                    if (rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='estrategia' AND precio <20";
                    }
                    if (!rbListaPrecio4060.Checked && !rbListaPrecio2040.Checked && !rbListaPreciomenos20.Checked && !rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='estrategia'";
                    }
                    break;
                case "rbListaIndie":
                    if (rbListaPrecio4060.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='indie' AND precio BETWEEN 40 AND 60";
                    }
                    if (rbListaPrecio2040.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='indie' AND precio BETWEEN 20 AND 40";
                    }
                    if (rbListaPreciomenos20.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='indie' AND precio <20";
                    }
                    if (rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='indie' AND precio <20";
                    }
                    if (!rbListaPrecio4060.Checked && !rbListaPrecio2040.Checked && !rbListaPreciomenos20.Checked && !rbListaPreciomenos10.Checked)
                    {
                        sqlorder = "SELECT * FROM productos WHERE genero='indie'";
                    }
                    break;
                default:
                    if (rbListaAccion.Checked)
                    {
                        goto case "rbListaAccion";
                    }
                    if (rbListaRPG.Checked)
                    {
                        goto case "rbListaRPG";
                    }
                    if (rbListaShooter.Checked)
                    {
                        goto case "rbListaShooter";
                    }
                    if (rbListaDeportes.Checked)
                    {
                        goto case "rbListaDeportes";
                    }
                    if (rbListaAventuras.Checked)
                    {
                        goto case "rbListaAventuras";
                    }
                    if (rbListaSimulacion.Checked)
                    {
                        goto case "rbListaSimulacion";
                    }
                    if (rbListaEstrategia.Checked)
                    {
                        goto case "rbListaEstrategia";
                    }
                    if (rbListaIndie.Checked)
                    {
                        goto case "rbListaIndie";
                    }
                    break;
                    /* case "rbListaPrecio2040":
                         if (rbListaAccion.Checked)
                         {
                             goto case "rbListaAccion";
                         }
                         if (rbListaRPG.Checked)
                         {
                             goto case "rbListaRPG";
                         }
                         if (rbListaShooter.Checked)
                         {
                             goto case "rbListaShooter";
                         }
                         if (rbListaDeportes.Checked)
                         {
                             goto case "rbListaDeportes";
                         }
                         if (rbListaAventuras.Checked)
                         {
                             goto case "rbListaAventuras";
                         }
                         if (rbListaSimulacion.Checked)
                         {
                             goto case "rbListaSimulacion";
                         }
                         if (rbListaEstrategia.Checked)
                         {
                             goto case "rbListaEstrategia";
                         }
                         if (rbListaIndie.Checked)
                         {
                             goto case "rbListaIndie";
                         }
                         break;
                     case "rbListaPreciomenos20":
                         if (rbListaAccion.Checked)
                         {
                             goto case "rbListaAccion";
                         }
                         if (rbListaRPG.Checked)
                         {
                             goto case "rbListaRPG";
                         }
                         if (rbListaShooter.Checked)
                         {
                             goto case "rbListaShooter";
                         }
                         if (rbListaDeportes.Checked)
                         {
                             goto case "rbListaDeportes";
                         }
                         if (rbListaAventuras.Checked)
                         {
                             goto case "rbListaAventuras";
                         }
                         if (rbListaSimulacion.Checked)
                         {
                             goto case "rbListaSimulacion";
                         }
                         if (rbListaEstrategia.Checked)
                         {
                             goto case "rbListaEstrategia";
                         }
                         if (rbListaIndie.Checked)
                         {
                             goto case "rbListaIndie";
                         }
                         break;
                     case "rbListaPreciomenos10":
                         if (rbListaAccion.Checked)
                         {
                             goto case "rbListaAccion";
                         }
                         if (rbListaRPG.Checked)
                         {
                             goto case "rbListaRPG";
                         }
                         if (rbListaShooter.Checked)
                         {
                             goto case "rbListaShooter";
                         }
                         if (rbListaDeportes.Checked)
                         {
                             goto case "rbListaDeportes";
                         }
                         if (rbListaAventuras.Checked)
                         {
                             goto case "rbListaAventuras";
                         }
                         if (rbListaSimulacion.Checked)
                         {
                             goto case "rbListaSimulacion";
                         }
                         if (rbListaEstrategia.Checked)
                         {
                             goto case "rbListaEstrategia";
                         }
                         if (rbListaIndie.Checked)
                         {
                             goto case "rbListaIndie";
                         }
                         break;*/
            }
            OleDbCommand command = new OleDbCommand(sqlorder, MainForm.conexion);
            OleDbDataReader reader = command.ExecuteReader();
            List<Videojuego> direcciones_1 = new List<Videojuego>();
            Videojuego[] direcciones;
            while (reader.Read())
            {
                Videojuego tmpObjetoVideojuego = new Videojuego();
                tmpObjetoVideojuego.direccionImagen = (reader.GetString(5));
                tmpObjetoVideojuego.nombre = (reader.GetString(1));
                tmpObjetoVideojuego.rating = (reader.GetInt32(6));
                tmpObjetoVideojuego.metacritic = (reader.GetInt32(7));
                tmpObjetoVideojuego.clip = (reader.GetString(8));
                tmpObjetoVideojuego.precio = (reader.GetInt32(4));
                direcciones_1.Add(tmpObjetoVideojuego);
            }
            direcciones = direcciones_1.ToArray();
            //MessageBox.Show(direcciones.Length.ToString());
            // AutoScrollMinSize = new Size(panel2.Width + 1000, panel2.Height + 1000);
            Size size = new Size(200, 200);
            int rows = 10;
            int columns = 4;
            int x = 47;
            int y = 49;
            int totalBoxes = direcciones.Length;
            List<PictureBox> pictureBoxList = new List<PictureBox>();
            for (int i = 0; i < totalBoxes; i++)
            {
                int curentColumn = i % columns;
                int currentRow = i / columns;
                int curentX = x + curentColumn * size.Width;
                int curentY = y + currentRow * size.Height;
                string tag = direcciones[i].rating.ToString() + direcciones[i].metacritic.ToString();
                string nombre = direcciones[i].nombre;
                string imagen = direcciones[i].direccionImagen;
                string video = direcciones[i].clip;
                string precio = direcciones[i].precio.ToString();
                string datos = nombre + "|" + imagen + "|" + video + "|" + tag + "|" + precio;

                PictureBox picture = new PictureBox
                {
                    Name = direcciones[i].nombre,
                    Size = size,
                    Tag = tag,
                    AccessibleName = direcciones[i].clip,
                    AccessibleDescription = datos,
                    Location = new Point(curentX, curentY),
                    BorderStyle = BorderStyle.Fixed3D,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Visible = true

                };
                picture.ImageLocation = direcciones[i].direccionImagen;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Click += new EventHandler(evento);
                picture.MouseEnter += new EventHandler(animacion);
                picture.MouseLeave += new EventHandler(animacion2);
                picture.Paint += new PaintEventHandler(metodo_dibujo);
                panel2.Controls.Add(picture);
                pictureBoxList.Add(picture);
            }
        }
        //Metodo que genera la animacion de las cajas
        private void metodo_dibujo(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            string[] datos = pb.AccessibleDescription.Split('|');
            using (Font myFont = new Font("Arial", 10))
            {
                e.Graphics.DrawString(pb.Name+"-"+datos[4]+ " €", myFont, Brushes.White, new Point(2, 2));
            }
        }
        //Metodo de animacion
        private void animacion2(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Size = new Size(200, 200);
        }
        //Metodo para buscar por nombre
        private void btBuscarPorNombre_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbBusqueda.Text))
            {

                panel2.Controls.Clear();
                string sqlorder = "SELECT * FROM productos WHERE  (nombre LIKE '%% '+@nombre+' %%')or(nombre LIKE '%% ' + @nombre + '')or(nombre LIKE '' + @nombre + ' %%')or(nombre LIKE '' + @nombre + '')";
                OleDbCommand command = new OleDbCommand(sqlorder, MainForm.conexion);
                command.Parameters.AddWithValue("@nombre", tbBusqueda.Text);
                OleDbDataReader reader = command.ExecuteReader();
                List<Videojuego> direcciones_1 = new List<Videojuego>();
                Videojuego[] direcciones;
                while (reader.Read())
                {
                    Videojuego tmpObjetoVideojuego = new Videojuego();
                    tmpObjetoVideojuego.direccionImagen = (reader.GetString(5));
                    tmpObjetoVideojuego.nombre = (reader.GetString(1));
                    tmpObjetoVideojuego.rating = (reader.GetInt32(6));
                    tmpObjetoVideojuego.metacritic = (reader.GetInt32(7));
                    tmpObjetoVideojuego.clip = (reader.GetString(8));
                    tmpObjetoVideojuego.precio = (reader.GetInt32(4));
                    direcciones_1.Add(tmpObjetoVideojuego);
                }
                direcciones = direcciones_1.ToArray();
                //MessageBox.Show(direcciones.Length.ToString());

                Size size = new Size(200, 200);
                int rows = 10;
                int columns = 4;
                int x = 47;
                int y = 49;
                int totalBoxes = direcciones.Length;
                List<PictureBox> pictureBoxList = new List<PictureBox>();
                for (int i = 0; i < totalBoxes; i++)
                {
                    int curentColumn = i % columns;
                    int currentRow = i / columns;
                    int curentX = x + curentColumn * size.Width;
                    int curentY = y + currentRow * size.Height;
                    string tag = direcciones[i].rating.ToString() + direcciones[i].metacritic.ToString();
                    string nombre = direcciones[i].nombre;
                    string imagen = direcciones[i].direccionImagen;
                    string video = direcciones[i].clip;
                    string precio = direcciones[i].precio.ToString();
                    traspaso_datos = new string[5];
                    traspaso_datos[0] = nombre;
                    traspaso_datos[1] = imagen;
                    traspaso_datos[2] = video;
                    traspaso_datos[3] = tag;
                    traspaso_datos[4] = precio;
                    string datos = nombre + "|" + imagen + "|" + video + "|" + tag + "|" + precio;

                    PictureBox picture = new PictureBox
                    {
                        Name = direcciones[i].nombre,
                        Size = size,
                        Tag = tag,
                        AccessibleName = direcciones[i].clip,
                        AccessibleDescription = datos,
                        Location = new Point(curentX, curentY),
                        BorderStyle = BorderStyle.Fixed3D,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Visible = true

                    };
                    picture.ImageLocation = direcciones[i].direccionImagen;
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Click += new EventHandler(evento);


                    panel2.Controls.Add(picture);
                    pictureBoxList.Add(picture);
                }
            }
        }
        //Metodo para la recarga de stock
        private void btRecargarStock_Click(object sender, EventArgs e)
        {
            System.Net.WebRequest request = null;

            string[] generos = { "accion", "rpg", "shooter", "sports", "aventura", "simulacion", "estrategia", "indie" };
            for (int j = 0; j < 8; j++)
            {
                switch (generos[j])
                {
                    case "accion":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=action&page_size=50");
                        break;
                    case "rpg":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=role-playing-games-rpg&page_size=50");
                        break;
                    case "shooter":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=shooter&page_size=50");
                        break;
                    case "sports":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=sports&page_size=50");
                        break;
                    case "aventura":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=adventure&page_size=50");
                        break;
                    case "simulacion":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=simulation&page_size=50");
                        break;
                    case "estrategia":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=strategy&page_size=50");
                        break;
                    case "indie":
                        request = HttpWebRequest.Create("https://api.rawg.io/api/games?genres=indie&page_size=50");
                        break;
                }
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                String jsonstring = reader.ReadToEnd();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                //var records =  ser.Deserialize<List<Videojuego>>(jsonstring);
                var resultado = JsonConvert.DeserializeObject<VideoJuegos>(jsonstring);
                int[] precios = new int[resultado.Results.Length];
                for (int i = 0; i < resultado.Results.Length; i++)
                {
                    Random rnd = new Random();
                    precios[i] = rnd.Next(5, 60); ;
                }
                for (int i = 0; i < resultado.Results.Length; i++)
                {

                    long metacritic;

                    string query = @"INSERT INTO productos(nombre,genero,copias,precio,imagen,rating,metacritic,clip) VALUES(?,?,?,?,?,?,?,?)";
                    OleDbCommand comandoinsertar = new OleDbCommand(query, MainForm.conexion);
                    comandoinsertar.Parameters.AddWithValue("@nombre", resultado.Results[i].Name);
                    comandoinsertar.Parameters.AddWithValue("@genero", generos[j]);
                    comandoinsertar.Parameters.AddWithValue("@copias", 15);
                    comandoinsertar.Parameters.AddWithValue("@precio", precios[i]);
                    comandoinsertar.Parameters.AddWithValue("@imagen", resultado.Results[i].BackgroundImage.AbsoluteUri);
                    comandoinsertar.Parameters.AddWithValue("@rating", resultado.Results[i].Rating);
                    if (resultado.Results[i].Metacritic == null)
                    {
                        metacritic = 20;
                    }
                    else
                    {
                        metacritic = (long)resultado.Results[i].Metacritic;
                    }
                    comandoinsertar.Parameters.AddWithValue("@metacritic", metacritic);

                    Clip clip = resultado.Results[i].Clip;
                    if (clip == null)
                    {
                        comandoinsertar.Parameters.AddWithValue("@clip", "https://www.instant-gaming.com/en/");
                    }
                    else
                    {
                        comandoinsertar.Parameters.AddWithValue("@clip", clip.ClipClip.AbsoluteUri);
                    }

                    //MessageBox.Show(resultado.Results[i].Clip.ClipClip.ToString());
                    // MessageBox.Show(query);
                    comandoinsertar.ExecuteNonQuery();

                }
            }
        }
        //Metodo de animacion
        public void animacion(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Size = new Size(250, 200);
        }
        //Metodo de cierre
        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductGalleryForm_Activated(object sender, EventArgs e)
        {
            if (ProductDetailForm.confirmacion_compra)
            {
                
                this.Close();
            }
        }
    }
}

