﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectPractice.Domain
{
    public class Rankings
    {
        public int IdRanking {  get; set; } 
        public int IdPelicula { get; set; }
        public int Ranking { get; set; }    
        public DateTime Fecha {  get; set; }

    }
}
