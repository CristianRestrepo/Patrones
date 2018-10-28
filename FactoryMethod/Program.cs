using FactoryMethod.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IConexion conexion = ConexionFabrica.getFabrica().getConexion("SQL");

            conexion.conectar();
            conexion.desconectar();

            conexion = ConexionFabrica.getFabrica().getConexion("MySQL");

            conexion.conectar();
            conexion.desconectar();

            conexion = ConexionFabrica.getFabrica().getConexion("Oracle");

            conexion.conectar();
            conexion.desconectar();

            Console.ReadKey();
        }
    }
}
