using System;

Console.Write("Digite o valor de A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Digite o valor de B: ");
double B = double.Parse(Console.ReadLine());
double C = (A * B) / 2;

Console.WriteLine("O do resultado da multiplicação de A por B dividido por 2 é: " + C);