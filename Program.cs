//@niallivmi
using System;

namespace Pgc1Aula02Ex04
{
    public class Program
    {
        static void Main(string[] args)
        {
            float va, vr;

            Console.Write("Digite o valor aplicado: ");
            va = float.Parse(Console.ReadLine());   

            Console.Write("Digite o valor resgatado: ");
            vr = float.Parse(Console.ReadLine());

            Console.WriteLine("O valor percentual da aplicação financeira é de: "+((vr-va)/va)*100);
        }
    }
}