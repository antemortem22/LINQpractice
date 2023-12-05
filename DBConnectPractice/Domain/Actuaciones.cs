using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectPractice.Domain
{
    public class Actuaciones 
    {
        public int IdActuacion { get; set; }
        public int IdPelicula { get; set; }
        public int IdActor { get; set; }
        public string Papel {  get; set; }

    }
}
