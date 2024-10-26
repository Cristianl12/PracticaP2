using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosApp.Persistances.Models
{
    public class AsientoBusModel
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public bool Disponible { get; set; }
    }

}
