using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recapitulando_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de 1 dimensão
            int[] meuArray = new int[3];
            meuArray[0] = 1;
            meuArray[1] = 10;
            meuArray[2] = 100;
            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine("----------------------");

            //Outras maneiras de criar um array
            int[] meuArray1 = {2, 20, 200};
            Console.WriteLine(meuArray1[0]);
            Console.WriteLine(meuArray1[1]);
            Console.WriteLine(meuArray1[2]);

            int[] meuArray2 = new int[] {3, 30, 300, 3000};
            Console.WriteLine(meuArray2[0]);
            Console.WriteLine(meuArray2[1]);
            Console.WriteLine(meuArray2[2]);
            Console.WriteLine(meuArray2[3]);
            Console.WriteLine("----------------------");

            //Array de 2 dimensões 
            string[,] meuArray3 = new string[2, 3];
            meuArray3[0, 0] = "1";
            meuArray3[0, 1] = "2";
            meuArray3[0, 2] = "3";
            meuArray3[1, 0] = "11";
            meuArray3[1, 1] = "12";
            meuArray3[1, 2] = "13";
            Console.WriteLine(meuArray3[0,0]);
            Console.WriteLine(meuArray3[0,1]);
            Console.WriteLine(meuArray3[0,2]);
            Console.WriteLine(meuArray3[1,0]);
            Console.WriteLine(meuArray3[1,1]);
            Console.WriteLine(meuArray3[1,2]);
            Console.WriteLine("----------------------");

            //Outras maneiras de inicializar um array de 2 dimensões
            string[,] meuArray4 = { {"10", "20", "30" }, {"100", "200", "300" } };
            Console.WriteLine(meuArray4[0, 0]);
            Console.WriteLine(meuArray4[0, 1]);
            Console.WriteLine(meuArray4[0, 2]);
            Console.WriteLine(meuArray4[1, 0]);
            Console.WriteLine(meuArray4[1, 1]);
            Console.WriteLine(meuArray4[1, 2]);

            string[,] meuArray5 = new string [ , ] { { "100", "200", "300" }, { "1000", "2000", "3000" } };
            Console.WriteLine(meuArray5[0, 0]);
            Console.WriteLine(meuArray5[0, 1]);
            Console.WriteLine(meuArray5[0, 2]);
            Console.WriteLine(meuArray5[1, 0]);
            Console.WriteLine(meuArray5[1, 1]);
            Console.WriteLine(meuArray5[1, 2]);
            Console.WriteLine("----------------------");

            //Pegando o número de elementos de um Array
            int tamanho1 = meuArray5.GetLength(0);
            int tamanho2 = meuArray5.GetLength(1);
            Console.WriteLine("A primeira dimensão do meu Array5 possui: " + tamanho1 + " elementos");
            Console.WriteLine("A segunda dimensão do meu Array5 possui: " + tamanho2 + " elementos");
            Console.WriteLine("----------------------");

            //Array de 3 Dimensões
            int[,,] array3D = new int[2, 2, 2];
            array3D[0, 0, 0] = 10;

            Console.ReadKey();
        }
    }
}
