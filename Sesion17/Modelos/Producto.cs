using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion17.Modelos
{
    public struct Producto
    {

        //campos
        public int ID {  get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }

        public double Precio { get; set; }
    }
}
