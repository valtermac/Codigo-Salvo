using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // VARIÁVEIS
            /*TIPOS DE DADOS NUMÉRICOS */

            int numerointeiro;
            double numeroFracionado1;
            float numeroFracionado2;

            char umCaracter;
            string variosCaracteres;

            bool verdadeiro;;
            bool falso;

            //INÍCIO
            numerointeiro = 3;
            numeroFracionado1 = 3.14;
            numeroFracionado2 = 0.4f;

            umCaracter = 'a';
            variosCaracteres = "Código Salvo";

            verdadeiro = true;
            falso = false;

            //operadores

            numerointeiro = 3 + 10;
            numeroFracionado1 = 5 - numeroFracionado1;
            numeroFracionado2 = 7 * 5.5f;
            numeroFracionado1 = 20 / 2;


            //FIM

            Console.ReadKey();
        }
    }
}
