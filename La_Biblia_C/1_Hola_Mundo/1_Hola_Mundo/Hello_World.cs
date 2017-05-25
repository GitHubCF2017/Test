using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Hola_Mundo
{
    /// <summary>
    /// La clase Hello_World es la unica clase de la clase "Hello_World".
    /// La clase implementa la funcion Main() de la aplicacion.
    /// La clase no contiene otras funciones.
    /// </summary>
    class Hello_World
    {
        /// <summary>
        /// Esta es la funcion <c>Main()</c> para la clase.
        /// No devuelve un valor y no toma ninguno argumento.
        /// Escribe el texto "Hola Mundo" en la consola y luego sale.
        /// </summary>

        /*Declaracion de Variables
              * Antes de poder usar una varible es necesario declararla.
              * Al declararla se informa al compilador de C# del tipo y nombre de la variable.
              * Una variable se declara excribiendo su tipo seguido de un espacio en blanco y acontinuacion el nombre de la variable
              * Termina la declaracion con ;*/
        
        /*Agregar "static" a una variable permite que automaticamente C# asigne un valor a la variable para
         * poder trabajar con ella; De lo contrario causa un error y se necesita declar el valor de la misma.*/
        
        static byte MyIntegerVariable;
        //int MyIntegerVariable_2;
        static byte MyIntegerVariable_3 = 2;
        static int a;
        static bool boleano;

        public static void Main(string[] args)
        {
            /*********************Imprime en consola un mensaje*********************/
            System.Console.WriteLine("Hola Mundo");

            /*********************Declaracion de Variables*********************/
            //Mostar el valor de la variable que le asigno C# al declararla como static
            System.Console.WriteLine("El valor de la variable MyIntegerVariable es " + MyIntegerVariable);

            byte MyIntegerVariable_2 = 1;
            System.Console.WriteLine("El valor de la variable MyIntegerVariable_2 es : " + MyIntegerVariable_2);
            System.Console.WriteLine("El valor de la variable MyIntegerVariable_3 es : " + MyIntegerVariable_3);

            a = 32768;
            System.Console.WriteLine("El valor de la variable a es : " + a);

            //Si no se le asigna un valor al tipo de dato bool por defecto es False
            boleano = true;
            System.Console.WriteLine("El valor de la variable boleano es : " + boleano);
            //Sirve para que el programa espere una tecla para salir
            System.Console.Read();

            /*********************Declaracion de Matrices Unidimensionales*********************/



        }
    }
}
