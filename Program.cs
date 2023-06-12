using System;

namespace _Teste05

{
    class Program
    {
        static void Main(string[] args)
        {
            Futuro r = new Futuro();
            Console.WriteLine("\nQual o período de investimento?");
            r.periodo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a taxa de juros aplicada?");
            r.taxa = Convert.ToDouble(Console.ReadLine());
            r.tabela();
        }

    }

}