using FactoryMethod.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.implementacion
{
    public class ConexionVacia : IConexion
    {
        public void conectar()
        {
            Console.WriteLine("Conectado a una instancia vacia");
        }

        public void desconectar()
        {
            Console.WriteLine("Deconectado a una instancia vacia");
        }
    }
}
