namespace Fundamentals
{

    internal class Stack_Heap
    {
        public class Persona
        {
            public string? Nombre { get; set; }
            public int Edad { get; set; }
        }
        
        internal Stack_Heap() { }
        public static void Stack() 
        {
            /* 
              
             El Stack es una región de memoria que funciona como una "pila" de platos: el último elemento que se añade es el primero en quitarse (LIFO - Last In, First Out). Es una memoria muy rápida y eficiente.

             - ¿Qué almacena? Principalmente almacena tipos de valor (value types) y punteros (referencias) a objetos que están en el Heap.
             - Tipos de valor: int, double, float, bool, char, structs personalizados, enums. Cuando declaras una variable de un tipo de valor, su contenido real se almacena directamente en el Stack.
             - Punteros/Referencias: Para los tipos de referencia (objetos), el Stack almacena la dirección de memoria donde se encuentra el objeto real en el Heap.
             - Gestión de memoria: La asignación y desasignación de memoria en el Stack es automática y muy rápida. Cuando un método se llama, sus variables locales y parámetros se asignan en el Stack. Cuando el método termina, esas variables se "desapilan" (se eliminan automáticamente).
             - Tamaño: Generalmente más pequeño y con un tamaño fijo.
             - Errores comunes: StackOverflowException si se excede el tamaño máximo del Stack (por ejemplo, con recursión infinita).
            
             */
            // 'a' es un tipo de valor (int), su valor 10 se almacena directamente en el Stack.
            int a = 10;

            // 'b' es otro tipo de valor (double), su valor 20.5 se almacena directamente en el Stack.
            double b = 20.5;

            Console.WriteLine($"Valor de 'a' (Stack): {a}");
            Console.WriteLine($"Valor de 'b' (Stack): {b}");

            // Cuando la función Main termina, 'a' y 'b' se desapilan automáticamente.
        }

        public static void Heap() 
        {
            /*
              
             El Heap es una región de memoria más grande y flexible. A diferencia del Stack, no sigue un orden estricto LIFO. Es donde se almacenan dinámicamente los objetos (instancias de clases) y otros tipos de referencia.

             - ¿Qué almacena? Principalmente almacena tipos de referencia (reference types).
             - Tipos de referencia: class (clases), string, object, arrays (arreglos), delegates, interfaces. Cuando creas una instancia de una clase (un objeto) usando new, este objeto se crea en el Heap.
             - Gestión de memoria: La asignación de memoria en el Heap es más lenta que en el Stack porque el sistema necesita encontrar un espacio disponible. La desasignación de memoria no es automática de inmediato; en C# (y .NET), el Garbage Collector (GC) se encarga de liberar la memoria de los objetos que ya no están siendo referenciados por ninguna parte del programa. Esto evita fugas de memoria, pero el GC tiene un costo de rendimiento.
             - Tamaño: Mucho más grande y dinámico.
             - Errores comunes: OutOfMemoryException si se agota la memoria disponible en el Heap.
             
             */

            // 'p1' es una variable de referencia (tipo Persona), 
            // pero el objeto 'new Persona()' se crea en el Heap.
            // La variable 'p1' en el Stack solo almacena la dirección de memoria donde reside el objeto en el Heap.
            Persona p1 = new() { Nombre = "Ana", Edad = 30 };

            // 'p2' también es una variable de referencia. Apunta al mismo objeto en el Heap que p1.
            Persona p2 = p1;

            Console.WriteLine($"Nombre de p1 (Heap): {p1.Nombre}");
            Console.WriteLine($"Edad de p2 (Heap): {p2.Edad}");

            // Si modificamos p2, también se modifica p1 porque ambos apuntan al mismo objeto en el Heap.
            p2.Edad = 31;
            Console.WriteLine($"Nueva edad de p1 (Heap, después de modificar p2): {p1.Edad}");

            // Cuando 'p1' y 'p2' dejan de ser referenciados, el Garbage Collector eventualmente
            // liberará la memoria del objeto 'Persona' en el Heap.
        }
    }
}