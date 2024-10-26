using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosApp.Persistances.Exceptions
{
    public class AsientoDataException : Exception
    {
        public AsientoDataException(string message) : base(message) { }
    }

}
