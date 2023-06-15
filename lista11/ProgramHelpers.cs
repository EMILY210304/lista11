using System;

namespace lista11
{
    internal static class ProgramHelpers
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
            int[] numeros = new int[20000];

            // Preenche o vetor com números inteiros
            PreencherVetor(numeros);

            Console.WriteLine("Digite um número para verificar quantas vezes ele aparece no vetor:");
            int numeroEscolhido;

            // Lê o número escolhido pelo usuário
            if (!int.TryParse(Console.ReadLine(), out numeroEscolhido))
            {
                Console.WriteLine("Digite um número válido!");
            }
            else
            {
                int contagem = ContarNumero(numeros, numeroEscolhido);

                Console.WriteLine($"O número {numeroEscolhido} aparece {contagem} vezes no vetor.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}