using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.modelos
{
    class Conexion
    {
        private static Conexion instancia;

        // Se define un constructor privado 
        // impidiento la instanciacion de nuevos objetos
        private Conexion(){}

        // Se hace uso del modificador de acceso static
        // para acceder a el desde cualquier parte del
        // código fuente
        public static Conexion getInstancia() {
            if (instancia == null) {
                instancia = new Conexion();
            }
            return instancia;
        }

        //Métodos
        public void conectar() {
            Console.WriteLine("Me conecte a la BD");
        }

        public void desconectar() {
            Console.WriteLine("Me desconecte de la BD");
        }    
    }
}
