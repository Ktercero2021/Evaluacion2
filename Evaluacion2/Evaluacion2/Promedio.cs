using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2
{
    public class Promedio
    {
        public string nombre { get; set;}
        public string numeroCuenta { get; set; }
        public int nota1 { get; set; }
        public int nota2 { get; set; }
        public int nota3 { get; set; }
        public int nota4 { get; set; }


        public Promedio() {}



        public Promedio( string _nombre, string _numeroCuenta){
            nombre = _nombre;
            numeroCuenta = _numeroCuenta;

        }

        public Promedio(int n1, int n2, int n3, int n4 ){

            nota1 = n1;
            nota2 = n2;
            nota3 = n3;
            nota4 = n4;
        }

        public string nombrecuenta(){

            return "Estudiante:" + nombre + "Numero de Cuenta:" + Convert.ToString(numeroCuenta);

        }

        public string nota()
        {
            int promedio = 0;
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if(promedio >= 70)
            {
                return "Tiene un promedio de:" +promedio+ "APROBADO";
            }else
            {
                return "Tiene un promedio de:" +promedio+ "REPROBADO";
            }


        }

    }
}
