using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                int numeroDeAtletas = 0;
                string[] nomeAtleta;
                string nomeAtletaMaiorAltura = "";
                char[] sexoAtleta;
                double[] pesoAtleta;
                double pesoMedioAtletas;
                double[] alturaAtleta;
                double alturaMaiorAtletas;
                double soma, alturaMediaMulheres, porcentagemHomens;
                int numeroDeMulheres, numeroDeHomens;

                Console.WriteLine("Qual a quantidade de Atletas? ");
                numeroDeAtletas = int.Parse(Console.ReadLine());

                nomeAtleta = new string[numeroDeAtletas];
                alturaAtleta = new double[numeroDeAtletas];
                pesoAtleta = new double[numeroDeAtletas];
                sexoAtleta = new Char[numeroDeAtletas];

                for (int i = 0; i < numeroDeAtletas; i++)
                {
                    Console.WriteLine($"Digite os dados do atleta numero {i + 1}:");
                    Console.Write("Nome: ");
                    nomeAtleta[i] = Console.ReadLine();

                    Console.Write("Sexo (M/F): ");
                    sexoAtleta[i] = char.Parse(Console.ReadLine());
                    while (sexoAtleta[i] != 'M' && sexoAtleta[i] != 'F')
                    {
                        Console.WriteLine("Valor inválido! Favor digitar F ou M.");
                        sexoAtleta[i] = char.Parse(Console.ReadLine());
                    }
                    Console.Write("Altura: ");
                    alturaAtleta[i] = double.Parse(Console.ReadLine(), CI);
                    while (alturaAtleta[i] <= 0)
                    {
                        Console.WriteLine("Valor invalido! Favor digitar um valor positvo");
                        alturaAtleta[i] = double.Parse(Console.ReadLine(), CI);
                    }
                    Console.Write("Peso: ");
                    pesoAtleta[i] = double.Parse(Console.ReadLine(), CI);
                    while (pesoAtleta[i] <= 0)
                    {
                        Console.WriteLine("Valor invalido! Favor digitar um valor positvo");
                        pesoAtleta[i] = double.Parse(Console.ReadLine(), CI);
                    }
                }
              
                Console.WriteLine();

                // ******************************** Peso medio dos atletas

                soma = 0;
                pesoMedioAtletas = 0.0;

                for (int i = 0; i < numeroDeAtletas; i++)
                {
                    if (pesoAtleta[i] > pesoMedioAtletas)
                    {
                        soma += pesoAtleta[i];
                    }
                }
                pesoMedioAtletas = soma / numeroDeAtletas;


                // ******************************** Nome do Atleta Maior!

                alturaMaiorAtletas = 0.0;

                for (int i = 0; i < numeroDeAtletas; i++)
                {
                    if (alturaAtleta[i] > alturaMaiorAtletas)
                    {
                        alturaMaiorAtletas = alturaAtleta[i];
                        nomeAtletaMaiorAltura = nomeAtleta[i];
                    }
                }

                // ******************************** Altura media das mulheres

                numeroDeMulheres = 0;
           
                for (int i = 0; i < numeroDeAtletas; i++)
                {
                    if (sexoAtleta[i] == 'F')
                    {
                        soma += alturaAtleta[i];
                        numeroDeMulheres++;
                    }
                    else
                    {
                        Console.WriteLine("Não ha mulhereres cadastrada");
                    }
                }
               
                alturaMediaMulheres = soma / numeroDeMulheres;

               
                // ******************************** porcentagem dos homens

                numeroDeHomens = 0;
                
                for (int i = 0; i < numeroDeAtletas; i++)
                {
                    if (sexoAtleta[i] == 'M')
                    {
                        numeroDeHomens++;
                    }
                }

                porcentagemHomens = (numeroDeHomens * 100.0) / numeroDeAtletas;
                
                Console.WriteLine();
                Console.WriteLine("RELATORIO: ");
                Console.WriteLine("Peso médio dos atletas: " + pesoMedioAtletas.ToString("F2", CI));
                Console.WriteLine("Atleta mais alto: " + nomeAtletaMaiorAltura);
                Console.WriteLine("Porcentagem de homens: " + porcentagemHomens.ToString("F2" ,CI));
                Console.WriteLine("Altura média das mulheres:" + alturaMediaMulheres.ToString("F2", CI));
            }
         }
     }
}

