using System;
using System.Globalization;
using System.Runtime.Remoting.Messaging;

//uma dica para quem for usuario de C# principalmente no visual studio: o console.WriteLine voce pode usar cw tab tab que completa para você
//e o console.ReadLine voce pode usar cr tab tab que completa para você 
public class Program
{
    public static void main()
    {
        int idade = int.Parse(Console.ReadLine());
        if (idade <= 18)
        {
            Console.WriteLine("Peça autorização de um Adulto");
        }
        else
        {
            Console.WriteLine("Bem vindo!");
        }

        Console.WriteLine("Por favor, informe o seu salario atual!");
        double salario = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
        Console.WriteLine("O valor inserido é de R$: " + salario);

        Console.WriteLine("Insira sua altura ");
        double altura = double.Parse(Console.ReadLine());
        if (altura < 1.70)
        {
            Console.Write("Uau voce é uma pessoa classificada baixa");
        }
        else
        {
            Console.Write("Voce é uma pessoa classificada alta!");
        }

        Console.WriteLine("Porfavor informe a primeira letra do seu genero M ou F");
        char genero = char.Parse(Console.ReadLine());
        Console.WriteLine("Seu genero é: " + genero);

        Console.WriteLine("Por favor, insira seu nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Olá," + nome + " Seja bem vindo!");




    }
}