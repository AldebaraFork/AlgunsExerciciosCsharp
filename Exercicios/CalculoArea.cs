using System;


    public class Area
    {
        public static void CalculandoArea()
        {
            //tipando as variaveis
            double b, be, h, area;

            //atribuição dos valores
            b = 6.0;
            be = 8.0;
            h = 5.0;

            //expressão
            area = (b + be) / 2.0 * h;
            Console.WriteLine(area);

            //para um codigo mais complexo atribuir as variaves com double.parse(Console.Readline());
            //voce tambem pode usar a mesma formula para varias formas geometricas diferentes
        }
    }
