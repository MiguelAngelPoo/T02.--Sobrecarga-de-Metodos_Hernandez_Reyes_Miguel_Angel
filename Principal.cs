using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga
{
    class Principal
    {
        //clase donde se realiza toda la operacion 
        //metodo sobre que es el que imprime y realiza el proceso
        public void sobre()
        {
            //creacion y utilizacion de la variable x
            int x = Suma(4, 5, 3);
            Console.WriteLine("respuesta sobre carga 1: " + x);
            Console.ReadKey();

            int x1 = Suma(4, 3);
            Console.WriteLine("respuesta sobre carga 2: " + x1);
            Console.ReadKey();

            int x2 = Suma(4);
            Console.WriteLine("respuesta sobre carga 3: " + x2);
            Console.ReadKey();

            int x3 = Suma();
            Console.WriteLine("respuesta sobre carga 4: " + x3);
            Console.ReadKey();
        }

        //creando metodo para sobrecarga
        public static int Suma(int a, int b, int c)
        {   //operaciones de suma y retorno de valor
            return a + b + c;
        }

        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static int Suma(int a)
        {
            return a + 5;
        }


        public static int Suma()
        {
            return 1 + 3;
        }
        
    }
}
