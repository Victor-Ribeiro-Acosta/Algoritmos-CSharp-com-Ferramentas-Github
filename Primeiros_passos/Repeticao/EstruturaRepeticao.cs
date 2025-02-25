using System;

class EstruturaRepeticao
{
    static void Main()
    {
        // Estrutura de repetição "for"
        // Utilizada quando sabemos de antemão quantas vezes o loop deve ser executado.
        // Sintaxe: for (inicialização; condição; incremento/decremento)
        Console.WriteLine("Estrutura de repetição 'for':");
        for (int i = 0; i < 5; i++)
        {
            // Este bloco de código será executado enquanto a condição (i < 5) for verdadeira.
            Console.WriteLine("Valor de i: " + i);
        }

        // Estrutura de repetição "while"
        // Utilizada quando não sabemos quantas vezes o loop deve ser executado, mas sabemos a condição de parada.
        // Sintaxe: while (condição)
        Console.WriteLine("\nEstrutura de repetição 'while':");
        int j = 0;
        while (j < 5)
        {
            // Este bloco de código será executado enquanto a condição (j < 5) for verdadeira.
            Console.WriteLine("Valor de j: " + j);
            j++; // Incremento da variável para evitar loop infinito.
        }

        // Estrutura de repetição "do-while"
        // Semelhante ao "while", mas garante que o bloco de código seja executado pelo menos uma vez.
        // Sintaxe: do { ... } while (condição);
        Console.WriteLine("\nEstrutura de repetição 'do-while':");
        int k = 0;
        do
        {
            // Este bloco de código será executado pelo menos uma vez, independentemente da condição.
            Console.WriteLine("Valor de k: " + k);
            k++; // Incremento da variável para evitar loop infinito.
        } while (k < 5);

        // Estrutura de repetição "foreach"
        // Utilizada para iterar sobre coleções (arrays, listas, etc.).
        // Sintaxe: foreach (tipo item in coleção)
        Console.WriteLine("\nEstrutura de repetição 'foreach':");
        int[] numeros = { 1, 2, 3, 4, 5 };
        foreach (int numero in numeros)
        {
            // Este bloco de código será executado para cada elemento na coleção.
            Console.WriteLine("Número: " + numero);
        }
    }
}
