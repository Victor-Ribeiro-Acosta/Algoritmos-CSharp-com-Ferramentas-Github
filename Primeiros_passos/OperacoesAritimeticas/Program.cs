

using System;

class OperacoesAritmeticas
{
    static void Main()
    {
        double num1 = 10;
        double num2 = 5;

        // Adição
        double adicao = num1 + num2;
        Console.WriteLine($"Adição: {num1} + {num2} = {adicao}");

        // Subtração
        double subtracao = num1 - num2;
        Console.WriteLine($"Subtração: {num1} - {num2} = {subtracao}");

        // Multiplicação
        double multiplicacao = num1 * num2;
        Console.WriteLine($"Multiplicação: {num1} * {num2} = {multiplicacao}");

        // Divisão
        double divisao = num1 / num2;
        Console.WriteLine($"Divisão: {num1} / {num2} = {divisao}");

        // Potenciação
        double potencia = Math.Pow(num1, num2);
        Console.WriteLine($"Potenciação: {num1} ^ {num2} = {potencia}");
    }
}
