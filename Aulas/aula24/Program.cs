using System;
using System.Collections.Generic;


namespace aula24 {
    class Program {
        static void Main(string [] args) {
            List<string> list = new List<string>();

            list.Add("Alexandre"); // Adiciona na última posição
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco"); // Adiciona na posição 2

            foreach (string name in list) { // Percorre a lista
                Console.WriteLine(name);
            }
            System.Console.WriteLine("List count: " + list.Count); // Mostra a quantidade de elementos na lista
            
            string s1 = list.Find(x => x[0] == 'A'); // Encontra o primeiro elemento que começa com A
            Console.WriteLine("First 'A': " + s1); // Mostra o elemento encontrado
        
            string s2 = list.FindLast(x => x[0] == 'A'); // Encontra o último elemento que começa com A
            Console.WriteLine("Last 'A': " + s2); // Mostra o elemento encontrado
        
            int pos1 = list.FindIndex(x => x[0] == 'A'); // Encontra a posição do primeiro elemento que começa com A
            Console.WriteLine("First 'A' position: " + pos1); // Mostra a posição do elemento encontrado
        
            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // Encontra a posição do último elemento que começa com A
            Console.WriteLine("Last 'A' position: " + pos2); // Mostra a posição do elemento encontrado
        
            List<string> list2 = list.FindAll(x => x.Length == 5); // Encontra todos os elementos que tem 5 letras
            System.Console.WriteLine("------------------");
            foreach (string name in list2) { 
                Console.WriteLine(name); 
            }

            System.Console.WriteLine("------------------");
            list.Remove("Marco"); // Remove o elemento Marco
            foreach (string name in list) { 
                Console.WriteLine(name);
            }

            list.RemoveAll(x => x[0] == 'M');
            foreach (string name in list) { 
                Console.WriteLine(name); 
            }

            System.Console.WriteLine("------------------");
            list.RemoveAt(2); 
            foreach (string name in list) { 
                Console.WriteLine(name);
            }

            list.RemoveRange(2, 2); // Remove os dois elementos a partir da posição 2
            System.Console.WriteLine("------------------");
            foreach (string name in list) { 
                Console.WriteLine(name); 
            }
        }
    }
}