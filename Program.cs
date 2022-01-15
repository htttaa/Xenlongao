using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            int quantidadeTestes; //C
            int quantidadeEsferas; //N
            int divisores;
            int divisoresImpares = 0;
            int quantidadeMinimaEsferas;

            quantidadeTestes = int.Parse(Console.ReadLine());
            for (int casos = 0; casos < quantidadeTestes; casos++)
            {
                quantidadeEsferas = int.Parse(Console.ReadLine());
                if (quantidadeEsferas >= 2 && quantidadeEsferas <= 109)
                {
                    for (int esfera = 0; esfera <= quantidadeEsferas; esfera++)
                    {
                        divisores = 0;
                        for (int aux = 1; aux <= esfera; aux++)
                        {
                            int resultado = esfera % aux;
                            if (resultado == 0)
                            {
                                divisores++;
                            }
                        }
                        if ((divisores % 3) == 0)
                        {
                            divisoresImpares++;
                        }
                    }
                }
                quantidadeMinimaEsferas = quantidadeEsferas - divisoresImpares;
                Console.WriteLine(quantidadeMinimaEsferas);
                divisoresImpares = 0;
            }
        }
    }
}