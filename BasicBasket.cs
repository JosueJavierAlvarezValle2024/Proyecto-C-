using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_C_
{
    internal class BasicBasket : ICalculable  // IMPLEMENTACION DE INTERFAZ
    {
        private List<Product> products; // Buscar, ordenar y manipular listas.
        private string owner;


        public BasicBasket()
        {
            products = new List<Product>();  // PRODUCTS LIST
        }

        public static void WelcomeMessage()
        {
            MessageBox.Show("¡Welcome to the product basket!"); // METODO ESTATICO
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(int indice)
        {
            if (indice >= 0 && indice < products.Count)
            {
                products.RemoveAt(indice);
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        
        public int Count // PROPIEDAD DE SOLO LECTURA
        {
            get { return products.Count; }
        } 

    }
}
