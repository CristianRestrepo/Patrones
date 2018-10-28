using FactoryMethod.implementacion;
using FactoryMethod.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ConexionFabrica
    {
        //implemento singleton de la fabrica
        private static ConexionFabrica fabrica;
                    
        private ConexionFabrica(){}

        public static ConexionFabrica getFabrica() {
            if (fabrica == null) {
                fabrica = new ConexionFabrica();
            }
            return fabrica;
        }

        //implemento la factoria
        public IConexion getConexion(String motor) {
            if (motor == null) {
                return new ConexionVacia();
            }
            if (motor.Equals("MySQL"))
            {
                return new ConexionMySQL();
            }
            else if (motor.Equals("Oracle"))
            {
                return new ConexionOracle();
            }
            else if (motor.Equals("SQL"))
            {
                return new ConexionSQL();
            }
            return new ConexionVacia();
        }
    }
}
