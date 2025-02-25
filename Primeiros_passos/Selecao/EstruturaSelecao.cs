using System;

class EstruturaSelecao
{
    static void Main()
    {
        // Declaração de uma variável inteira chamada 'numero'
        int numero = 10;

        // Estrutura de seleção 'if'
        // Verifica se o valor da variável 'numero' é maior que 5
        if (numero > 5)
        {
            // Se a condição for verdadeira, este bloco de código será executado
            Console.WriteLine("O número é maior que 5.");
        }
        else
        {
            // Se a condição for falsa, este bloco de código será executado
            Console.WriteLine("O número não é maior que 5.");
        }

        // Estrutura de seleção 'if-else if-else'
        // Verifica se o valor da variável 'numero' é igual a 10
        if (numero == 10)
        {
            // Se a condição for verdadeira, este bloco de código será executado
            Console.WriteLine("O número é igual a 10.");
        }
        // Verifica se o valor da variável 'numero' é maior que 10
        else if (numero > 10)
        {
            // Se a condição for verdadeira, este bloco de código será executado
            Console.WriteLine("O número é maior que 10.");
        }
        else
        {
            // Se nenhuma das condições anteriores for verdadeira, este bloco de código será executado
            Console.WriteLine("O número é menor que 10.");
        }

        // Estrutura de seleção 'switch'
        // Avalia o valor da variável 'numero'
        switch (numero)
        {
            // Caso o valor seja 5
            case 5:
                Console.WriteLine("O número é 5.");
                break; // Interrompe a execução do 'switch'

            // Caso o valor seja 10
            case 10:
                Console.WriteLine("O número é 10.");
                break; // Interrompe a execução do 'switch'

            // Caso o valor seja 15
            case 15:
                Console.WriteLine("O número é 15.");
                break; // Interrompe a execução do 'switch'

            // Caso o valor não corresponda a nenhum dos casos anteriores
            default:
                Console.WriteLine("O número não é 5, 10 ou 15.");
                break; // Interrompe a execução do 'switch'
        }
    }
}
