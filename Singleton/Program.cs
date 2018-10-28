using Singleton.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion c = Conexion.getInstancia();
            c.conectar();
            c.desconectar();

            

            Console.ReadKey();            
        }
    }
}
