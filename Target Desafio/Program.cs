using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 13;
            int Soma = 0;
            int K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                Soma = Soma + K;


                     
            }
            Console.WriteLine(Soma);
            Console.ReadLine();
        }
        
    }
}
