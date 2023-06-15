using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO1
            //            int[] numeros = new int[1000];

            //            // Preenche o vetor com números inteiros
            //            PreencherVetor(numeros);

            //            Console.WriteLine("Adivinhe um número entre 1 e 1000:");

            //            int numeroAdivinhado;
            //            bool acertou = false;

            //            do
            //            {
            //                // Lê o número adivinhado pelo usuário
            //                if (!int.TryParse(Console.ReadLine(), out numeroAdivinhado))
            //                {
            //                    Console.WriteLine("Digite um número válido!");
            //                    continue;
            //                }

            //                // Verifica se o número está no vetor
            //                if (Array.Exists(numeros, n => n == numeroAdivinhado))
            //                {
            //                    acertou = true;
            //                    Console.WriteLine("Parabéns, você acertou!");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Tente novamente!");
            //                }
            //            } while (!acertou);

            //            Console.WriteLine("Pressione qualquer tecla para sair...");
            //            Console.ReadKey();
            //        }

            //        static void PreencherVetor(int[] vetor)
            //        {
            //            Random random = new Random();

            //            for (int i = 0; i < vetor.Length; i++)
            //            {
            //                vetor[i] = random.Next(1, 1001);
            //                Console.ReadKey();
            //            }
            //        }
            //    }
            //}

            //EXERCICIO2

            //         int[] numeros = new int[20000];

            //         // Preenche o vetor com números inteiros
            //         PreencherVetor(numeros);

            //         Console.WriteLine("Digite um número para verificar quantas vezes ele aparece no vetor:");
            //         int numeroEscolhido;

            //         // Lê o número escolhido pelo usuário
            //         if (!int.TryParse(Console.ReadLine(), out numeroEscolhido))
            //         {
            //             Console.WriteLine("Digite um número válido!");
            //         }
            //         else
            //         {
            //             int contagem = ContarNumero(numeros, numeroEscolhido);

            //             Console.WriteLine($"O número {numeroEscolhido} aparece {contagem} vezes no vetor.");
            //         }

            //         Console.WriteLine("Pressione qualquer tecla para sair...");
            //         Console.ReadKey();
            //     }

            //     static void PreencherVetor(int[] vetor)
            //     {
            //         Random random = new Random();

            //         for (int i = 0; i < vetor.Length; i++)
            //         {
            //             vetor[i] = random.Next(1, 1001);
            //         }
            //     }

            //     static int ContarNumero(int[] vetor, int numero)
            //     {
            //         int contagem = 0;

            //         for (int i = 0; i < vetor.Length; i++)
            //         {
            //             if (vetor[i] == numero)
            //             {
            //                 contagem++;
            //             }
            //         }

            //         return contagem;
            //         Console.ReadKey();
            //     }
            // }
            //}

            //EXERCICIO3
            //            int[] vetorOriginal = new int[10];
            //            int[] vetorModificado = new int[10];

            //            // Lê os elementos do vetor original
            //            for (int i = 0; i < vetorOriginal.Length; i++)
            //            {
            //                Console.Write($"Digite o elemento {i + 1}: ");
            //                if (!int.TryParse(Console.ReadLine(), out vetorOriginal[i]) || vetorOriginal[i] <= 0)
            //                {
            //                    Console.WriteLine("Digite um número inteiro positivo!");
            //                    i--;
            //                }
            //            }

            //            // Modifica o vetor e preenche o vetor modificado
            //            for (int i = 0; i < vetorOriginal.Length; i++)
            //            {
            //                if (i % 2 == 0)
            //                {
            //                    vetorModificado[i] = vetorOriginal[i] / 2;
            //                }
            //                else
            //                {
            //                    vetorModificado[i] = vetorOriginal[i] * 3;
            //                }
            //            }

            //            Console.WriteLine("\nVetor Original:");
            //            ImprimirVetor(vetorOriginal);

            //            Console.WriteLine("\nVetor Modificado:");
            //            ImprimirVetor(vetorModificado);

            //            Console.WriteLine("Pressione qualquer tecla para sair...");
            //            Console.ReadKey();
            //        }

            //        static void ImprimirVetor(int[] vetor)
            //        {
            //            for (int i = 0; i < vetor.Length; i++)
            //            {
            //                Console.Write($"{vetor[i]} ");
            //            }
            //            Console.WriteLine();
            //        }
            //    }
            //}

            //EXERCICIO4

 //           int[] numeros = new int[5000];

 //           // Lê os números digitados pelo usuário
 //           for (int i = 0; i < numeros.Length; i++)
 //           {
 //               Console.Write($"Digite o número {i + 1}: ");
 //               if (!int.TryParse(Console.ReadLine(), out numeros[i]))
 //               {
 //                   Console.WriteLine("Digite um número válido!");
 //                   i--;
 //               }
 //           }

 //           Console.WriteLine("\nNúmeros primos:");

 //           // Verifica quais números são primos e os imprime
 //           for (int i = 0; i < numeros.Length; i++)
 //           {
 //               if (EhPrimo(numeros[i]))
 //               {
 //                   Console.Write($"{numeros[i]} ");
 //               }
 //           }

 //           Console.WriteLine("\nPressione qualquer tecla para sair...");
 //           Console.ReadKey();
 //       }

 //       static bool EhPrimo(int numero)
 //       {
 //           if (numero < 2)
 //           {
 //               return false;
 //           }

 //           for (int i = 2; i <= Math.Sqrt(numero); i++)
 //           {
 //               if (numero % i == 0)
 //               {
 //                   return false;
 //               }
 //           }

 //           return true;
 //       }
 //   }
 //}