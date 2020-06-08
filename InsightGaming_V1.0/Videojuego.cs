using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InsightGaming_V1._0
{
    class Videojuego
    {
        public string nombre { get; set; }
        public string direccionImagen; /*{ get; set; }*/
        public int rating;/* { get; set; }*/
        public int metacritic; /*{ get; set; }*/
        public string clip; /*{ get; set; }*/
        public int precio { get; set; }
    }
}
