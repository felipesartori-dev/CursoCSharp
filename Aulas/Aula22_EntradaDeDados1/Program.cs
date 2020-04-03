using System;

namespace Aula22_EntradaDeDados1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando o SPLIT - serve para quebrar uma string em vários conteudos e armazenar em um vetor.

            String recebePalavras = Console.ReadLine();

            Console.WriteLine(recebePalavras);

            /* Agora vamos utilizar o split pra armazenar cada palavra em uma posição do vetor e depois armazena-las
            em uma variável */
            // Primeiro é necessária a criação de um vetor

            string[] vetorPalavras = recebePalavras.Split(' '); // O espaço em branco entre aspas simples indica que sempre que o programa encontrar um espaço em branco irá dividir as palavras
            
            string p0 = vetorPalavras[0];
            string p1 = vetorPalavras[1];
            string p2 = vetorPalavras[2];

            Console.WriteLine($"{p0} \n{p1} \n{p2}");
        }
    }
}
