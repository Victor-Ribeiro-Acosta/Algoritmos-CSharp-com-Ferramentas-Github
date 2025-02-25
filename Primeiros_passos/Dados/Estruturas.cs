using System;
using System.Collections.Generic;

namespace Dados
{
    class Estruturas
    {
        static void Main(string[] args)
        {
            // Array: Estrutura de dados que armazena uma coleção de elementos do mesmo tipo.
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            // List: Lista genérica que pode crescer dinamicamente.
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Dictionary: Estrutura de dados que armazena pares chave-valor.
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary["um"] = 1;
            dictionary["dois"] = 2;
            dictionary["tres"] = 3;

            // Queue: Fila que segue o princípio FIFO (First In, First Out).
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("primeiro");
            queue.Enqueue("segundo");
            queue.Enqueue("terceiro");

            // Stack: Pilha que segue o princípio LIFO (Last In, First Out).
            Stack<string> stack = new Stack<string>();
            stack.Push("primeiro");
            stack.Push("segundo");
            stack.Push("terceiro");

            // Exibindo os elementos das estruturas de dados
            Console.WriteLine("Array:");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nList:");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDictionary:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine("\nQueue:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine("\nStack:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}