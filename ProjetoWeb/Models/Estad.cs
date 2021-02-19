using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb.Models
{
    public class Estad
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Populacao { get; set; }

        List<City> Cidades {get; set; }
    }
}