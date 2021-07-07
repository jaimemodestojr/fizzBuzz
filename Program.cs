/* Escrever um algoritmo que liste números de 1 até 100, de maneira ordenada e um abaixo do outro e aplicar certas regras a eles, sendo elas:
   - Quando o número for múltiplo de 3: escrever Buzz no lugar do número;
   - Quando o número for múltiplo de 5: escrever Fizz no lugar do número;
   - Quando o número for múltiplo de 3 e 5 ao mesmo tempo: escrever FizzBuzz no lugar do número. */

using System;
using System.Collections.Generic;

namespace fizzBuzz
{
    class Program
    {
        static void Main(String[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                string solucao = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" : (i % 3 == 0) ? "Fizz" : i.ToString();

                Console.WriteLine(solucao);
            }

        }
    }
}