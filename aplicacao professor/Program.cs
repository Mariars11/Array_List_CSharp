using System;

namespace aplicacao_professor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAlunos;
            Console.Write("Informe o número de Alunos: ");
            numAlunos = Convert.ToInt32(Console.ReadLine());

            string[] nomeAlunos = new string[numAlunos];
            Console.WriteLine();
            for(int i = 0; i < nomeAlunos.Length; i++){
                Console.Write("Informe o nome do aluno(a): ");
                nomeAlunos[i] = Console.ReadLine();
            }  

            Array.Sort(nomeAlunos); //coloca os nomes em ordem alfabetica
            Console.WriteLine("\nOs nomes dos alunos em ordem alfabética: ");
            Console.WriteLine("==== Pressione qualquer tecla para que os nomes apareçam! ==== ");
            for(int i = 0; i < nomeAlunos.Length; i++){
                int rank = i + 1;
                Console.Write(rank + (" - ") + nomeAlunos[i]);
            } 
        }
    }
}
