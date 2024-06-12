using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Demostración de operaciones con Stack<int>
        Console.WriteLine("Operaciones con Stack<int>:");
        DemonstrateStackOperations();

        // Separador entre demostraciones
        Console.WriteLine(new string('-', 50));

        // Demostración de operaciones con Queue<int>
        Console.WriteLine("Operaciones con Queue<int>:");
        DemonstrateQueueOperations();
    }

    static void DemonstrateStackOperations()
    {
        Stack<int> stack = new Stack<int>();

        // Operación Push
        Console.WriteLine("Push(10)");
        stack.Push(10);
        Console.WriteLine("Push(20)");
        stack.Push(20);
        Console.WriteLine("Push(30)");
        stack.Push(30);

        // Mostrar contenido de la pila
        Console.WriteLine("Contenido de la pila: " + string.Join(", ", stack));

        // Operación Peek
        Console.WriteLine("Peek() devuelve: " + stack.Peek());

        // Operación Pop
        Console.WriteLine("Pop() devuelve: " + stack.Pop());

        // Mostrar contenido de la pila después de Pop
        Console.WriteLine("Contenido de la pila después de Pop: " + string.Join(", ", stack));

        // Operación Count
        Console.WriteLine("Número de elementos en la pila: " + stack.Count);
    }

    static void DemonstrateQueueOperations()
    {
        Queue<int> queue = new Queue<int>();

        // Operación Enqueue
        Console.WriteLine("Enqueue(10)");
        queue.Enqueue(10);
        Console.WriteLine("Enqueue(20)");
        queue.Enqueue(20);
        Console.WriteLine("Enqueue(30)");
        queue.Enqueue(30);

        // Mostrar contenido de la cola
        Console.WriteLine("Contenido de la cola: " + string.Join(", ", queue));

        // Operación Peek
        Console.WriteLine("Peek() devuelve: " + queue.Peek());

        // Operación Dequeue
        Console.WriteLine("Dequeue() devuelve: " + queue.Dequeue());

        // Mostrar contenido de la cola después de Dequeue
        Console.WriteLine("Contenido de la cola después de Dequeue: " + string.Join(", ", queue));

        // Operación Count
        Console.WriteLine("Número de elementos en la cola: " + queue.Count);
    }
}
