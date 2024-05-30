using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_C_
{
    internal class Product
    {
        public string Name { get; set; } // PROPIEDAD DE LECTURA Y ESCRITURA
        public decimal Price { get; set; } // PROPIEDAD DE LECTURA Y ESCRITURA

        private DateTime addedDate; // PROPIEDAD SOLO ESCIRTURA
        public DateTime AddedDate
        {
            get { return addedDate; }
        }

        public Product() { } // COSNTRUCTOR SIN PARAMETROS

        public Product(string name, decimal price) // CONSTRUCTOR CON PARAMETROS
        {
            Name = name;
            Price = price;
            addedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Name}: ${Price}"; // METODO QUE RECIBE ALGO Y REGRESA PARAMETROS (SOBREESCRITO, POLIMORFISMO)
        }
    }
}
