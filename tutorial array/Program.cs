using System;
using System.Collections.Generic; //grupos de funcionalidades importados que permitem o uso de list

namespace tutorial_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Caso saiba quais serão os inputs
            string[] filmes = {"Procurando Nemo","Toy Story 1","Minha mãe é uma peça","Faroeste Caboclo"};
                Console.WriteLine("A lista de filmes: "); 
                for(int i = 0; i < filmes.Length; i++){
                int rank = i + 1;
                Console.WriteLine(rank + " - " + filmes[i]);  
                } 
            // não conhece os inputs - array vazio
            string[] movies = new string[4];
                Console.WriteLine("Informe o nome dos filmes: ");
                for(int i = 0; i < movies.Length; i++){
                   Console.Write("Informe: ");
                   movies[i] = Console.ReadLine(); 
                }
                Console.WriteLine("Colocamos os filmes em ordem alfabética: ");
                Array.Sort(movies);

                for(int i = 0; i < movies.Length; i++){
                    Console.WriteLine(movies[i]);
                } 
            List<string> shoppingList = new List<string>();

                shoppingList.Add("Dreams"); //add: adicione um "item" a lista
                shoppingList.Add("Miracle");
                shoppingList.Add("Rainbows");
                shoppingList.Add("Pony");

                for(int i = 0; i < shoppingList.Count; i++){ //não permite o uso de lenght
                    Console.WriteLine(shoppingList[i]);
                }
                
                    shoppingList.Remove("Dreams");
                    shoppingList.RemoveAt(1);
                    
                    Console.WriteLine("===================");
                
                for(int i = 0; i < shoppingList.Count; i++){ 
                    Console.WriteLine(shoppingList[i]);
                }
        }
    }
}
