using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIÁVEIS

            int lado;
            int altura;
            int areaQuadrado;

            //INÍCIO

            Console.Write("Digite o valor da lado do quadrado: ");      /*entradas*/
            lado = Convert.ToInt32(Console.ReadLine());                 /*entradas*/
            Console.Write("Digite o valor da altura do quadrado: ");      /*entradas*/
            altura = Convert.ToInt32(Console.ReadLine());               /*entradas*/
                        
            areaQuadrado = lado * altura;                               /*processamento*/
            
            Console.WriteLine("Valor da área é: {0}", areaQuadrado);    /*saída*/

            //FIM
            Console.ReadKey();
        }
    }
}
