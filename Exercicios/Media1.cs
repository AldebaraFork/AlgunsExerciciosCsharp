using System;

public class Class1
{
	public Class1()
	{
		using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a nota da primeira avaliação (A):");
        double notaA = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o peso da nota da primeira avaliação (A):");
        double pesoA = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota da segunda avaliação (B):");
        double notaB = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o peso da nota da segunda avaliação (B):");
        double pesoB = double.Parse(Console.ReadLine());

        // Calcula a média ponderada
        double mediaPonderada = (notaA * pesoA + notaB * pesoB) / (pesoA + pesoB);

        Console.WriteLine($"A média ponderada do aluno é: {mediaPonderada:F1}");

        // Verifica se o aluno foi aprovado, em recuperação ou reprovado
        if (mediaPonderada >= 6.0)
        {
            Console.WriteLine("Parabéns, você foi aprovado!");
        }
        else if (mediaPonderada >= 2.0)
        {
            Console.WriteLine("Infelizmente você está em recuperação.");
        }
        else
        {
            Console.WriteLine("Infelizmente você foi reprovado.");
        }
    }
}

	}
}
