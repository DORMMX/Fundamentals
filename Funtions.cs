using System.Drawing;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fundamentals
{
    internal class Funtions
    {
        /*
        Inicialización: La variable debe estar inicializada en el código que llama al método antes de pasarla como argumento ref.

        Propósito: Se usa cuando el método podría leer y/o modificar el valor de la variable. El método no está obligado a modificar el valor, pero tiene la capacidad de hacerlo.

        Bidireccional: Los datos pueden fluir en ambas direcciones (entrada y salida).
         */

        public static void RefParameter(ref int numero)
        {
            Console.WriteLine($"Dentro del método (antes): {numero}");
            numero += 10; // Modificamos el valor de la variable original
            Console.WriteLine($"Dentro del método (después): {numero}");
        }

        /*
        
         */
        /// <summary>
        /// Inicialización: La variable no necesita estar inicializada en el código que llama al método.
        /// Propósito: Se usa cuando el método está obligado a asignar un valor al parámetro antes de que el método regrese.Se utiliza comúnmente para devolver múltiples valores de un método.
        /// Unidireccional(principalmente): La intención principal es que los datos fluyan hacia afuera del método.El método es responsable de "producir" un valor para esa variable.
        /// </summary>
        /// <param name="lado"></param>
        /// <param name="area"></param>
        /// <param name="perimetro"></param>
        public static void OutParameter(int lado, out int area, out int perimetro)
        {
            // El método es responsable de asignar valores a 'area' y 'perimetro'
            area = lado * lado;
            perimetro = 4 * lado;
            Console.WriteLine($"Dentro del método - Área: {area}, Perímetro: {perimetro}");
        }

        /// <summary>
        /// Cuando defines un parámetro con la palabra clave params en la declaración de un método, C# permite que la llamada a ese método se haga de dos maneras:
        /// 
        /// Pasando argumentos individuales separados por comas: El compilador de C# automáticamente los agrupa en un array del tipo especificado y los pasa al método.
        /// Pasando directamente un array: Si ya tienes tus valores en un array, puedes pasarlo directamente al método.
        /// Reglas importantes para usar params:
        /// 
        /// Solo puede haber un parámetro params en la lista de parámetros de un método.
        /// 
        /// El parámetro params debe ser el último en la lista de parámetros del método.
        /// 
        /// El tipo del parámetro params debe ser un array unidimensional.
        /// </summary>
        /// <param name="numeros"></param>
        /// <returns></returns>        
        public static int ParamsFunction(params int[] numeros)
        {
            int suma = 0;
            foreach (int num in numeros)
            {
                suma += num;
            }
            return suma;
        }
    }
}
