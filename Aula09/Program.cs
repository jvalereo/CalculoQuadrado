using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula09, Calcule a area do quadrado, tipo double
            //Jonas valereo - Técnico em Informática 

            //Declarando as variaveis, tipo double

            double l, area;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o lado do quadrado: ");
            l = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            Console.WriteLine();
            


            //Declarando a variavel area do quadrado

            area = Math.Pow(l, 2.0);


            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("Area do quadrado: " + area.ToString("F2", CultureInfo.InstalledUICulture));
            Console.WriteLine();
            Console.WriteLine("Teste de Novo!!!");


            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa 


 
        }
    }
}
