using PI_zadaca_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_zadaca_3
{
  public class Zahtjev
    {
        public int Id_Zahtjev { get; set; }
        public string NazivPonude { get; set; }
        public DateTime DatumPodnosenja { get; set; }
        public string Narucitelj { get; set; }


    }
}
