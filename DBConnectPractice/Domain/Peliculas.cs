using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectPractice.Domain
{
    public class Peliculas
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public int AñoEstreno { get; set;}
        public string Clasificacion { get; set; }
        public int IdProductora { get; set; }
        public int IdDirector { get;set; }
        public int Recaudacion { get; set; }

    }
}
