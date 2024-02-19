using System;
using System.globalization;
public class Class1
{
	public Class1()
	{
		Console.WriteLine("Digite o número de funcionários: ");
		int Funcionarios = int.parse.Console.ReadLine();
		Console.WriteLine("Digite o número de horas trabalhadas: ");
		int HorasTrabalhadas = int.parse.Console.ReadLine();
	    Console.writeLine("Digite o valor da hora trabalhada: ");
		double ValorHora = double.parse.toString(Console.ReadLine());
        
		double Salario = HorasTrabalhadas * ValorHora;

		Console.WriteLine("Número de funcionários: " + Funcionarios);
		Console.WriteLine("Salário: " + Salario.ToString("F2", CultureInfo.CurrentCulture));
	}
}
