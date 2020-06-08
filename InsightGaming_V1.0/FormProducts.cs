using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InsightGaming_V1._0
{
    public partial class FormProducts : Form
    {
    
        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            /*AutoScrollMinSize = new Size(panel2.Width + 4000, panel2.Height + 4000);
            Size size = new Size(200, 200);
            int rows = 70;
            int columns = 4;
            int x =47;
            int y =49;
            int totalBoxes = rows * columns;
            List<PictureBox> pictureBoxList = new List<PictureBox>();
            for (int i = 0; i < totalBoxes; i++)
            {
                int curentColumn = i % columns;
                int currentRow = i / columns;
                int curentX = x + curentColumn * size.Width;
                int curentY = y + currentRow * size.Height;
                PictureBox picture = new PictureBox
                {
                    Name = "pictureBox" + i,
                    Size = size,
                    Location = new Point(curentX, curentY),
                    BorderStyle = BorderStyle.Fixed3D,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Visible = true
                };
                
                panel2.Controls.Add(picture);
                pictureBoxList.Add(picture);
            }*/
        }

        private void btRecargarStock_Click(object sender, EventArgs e)
        {
            System.Net.WebRequest request=null;
    
            string[] generos = { "accion", "rpg", "shooter", "sports", "aventura", "simulacion", "estrategia", "indie" };
            for (int j = 0; j <8; j++)
            {
                switch (generos[j]){
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
                int[] precios=new int[resultado.Results.Length];
                for (int i = 0; i < resultado.Results.Length; i++)
                {
                    Random rnd = new Random();
                    precios[i]= rnd.Next(5, 60); ;
                }
                for (int i = 0; i <resultado.Results.Length; i++)
                {
                    
                    long metacritic;
                    
                    string query = @"INSERT INTO productos(nombre,genero,copias,precio,imagen,rating,metacritic,clip) VALUES(?,?,?,?,?,?,?,?)";
                    OleDbCommand comandoinsertar = new OleDbCommand(query, MainForm.conexion);
                    comandoinsertar.Parameters.AddWithValue("@nombre", resultado.Results[i].Name);
                    comandoinsertar.Parameters.AddWithValue("@genero", generos[j]);
                    comandoinsertar.Parameters.AddWithValue("@copias", 15);
                    comandoinsertar.Parameters.AddWithValue("@precio",precios[i]);
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btGaleriaProductos_Click(object sender, EventArgs e)
        {
            ProductGalleryForm formGaleria = new ProductGalleryForm();
            formGaleria.ShowDialog();
        }
    }
}
