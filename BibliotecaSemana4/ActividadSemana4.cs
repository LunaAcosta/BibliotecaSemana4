using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSemana4
{
    public class ActividadSemana4
    {
        public static void SortedListCollection()
        {
            int c1, c2, result;
            string numbers, ope;

            Console.Write("INGRESE LA PRIMERA CANTIDAD: ");
            numbers = Console.ReadLine();
            c1 = int.Parse(numbers);

            Console.Write("INGRESE LA SEGUNDA CANTIDAD: ");
            numbers = Console.ReadLine();
            c2 = int.Parse(numbers);

            Console.Write("ELIJA LA OPERACION QUE DESEA REALIZAR : s (SUMA) / r(RESTA) / m(MULTIPLICACION) / d(DIVICION): ");
            ope = Console.ReadLine();
            Console.ReadLine();

            if (ope == "s") 
            {
                result = c1 + c2;

                Console.WriteLine("EL RESULTADO DE LA SUMA ES :" + result);
            }

            if (ope == "r")
            {
                result = c1 - c2;
                Console.WriteLine("EL RESULTADO DE LA RESTA ES: " + result);
            }

            if (ope == "m")
            {
                result = c1 * c2;
                Console.WriteLine("EL RESULTADO DE LA MULTIPLICACION ES: " + result);
            }

            if (ope == "d")
            {
                result = c1 / c2;
                Console.WriteLine("EL RESULTADO DE LA DIVISION ES: " +  result);

            }

            Console.ReadKey();



        }

    }
}
