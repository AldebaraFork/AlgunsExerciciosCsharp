using System;


namespace CalculoDiferenca
{
    public class Diferenca
    {
        public static void CalculandoDiferenca()
        {
            Console.WriteLine("Digite 4 valores inteiros");


            Console.WriteLine("Digite o valor de A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D");
            int D = int.Parse(Console.ReadLine());
            int DIFERENCA = (A * B - C * D);
            Console.WriteLine("DIFERENÇA = " + DIFERENCA);
        }
    }
}