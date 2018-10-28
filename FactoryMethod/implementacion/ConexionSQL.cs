using FactoryMethod.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.implementacion
{
    public class ConexionSQL : IConexion
    {
        public void conectar()
        {
            Console.WriteLine("Conectado a una base SQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Desconectado a una base MySQL");
        }
    }
}
