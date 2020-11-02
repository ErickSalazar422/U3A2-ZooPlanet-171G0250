using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooPlanet.Models.ViewModels
{
    public class EspeciesIndexViewModel
    {
        public IEnumerable<Especies> Especies { get; set; }
        public IEnumerable<Clase> Clases { get; set; }
        public string idClase { get; set; }
    }
}
