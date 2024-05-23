using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //List<string> listTwo = new List<string> { "Maria", "João" };

            //Add adiciona item ao final da lista
            list.Add("Maria");
            list.Add("Antônio");
            list.Add("Bob");
            list.Add("Anna");

            //Insert especifica a posição que você quer inserir
            list.Insert(1, "Mario");


            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Count mostra o tamanho da lista

            Console.WriteLine($"A lista tem {list.Count} itens.");
            Console.WriteLine();

            //Find encontra o primeiro elemento com a condição correspondente ao predicado (a função)
            //Ela recebe como argumento uma função que faz a verificação, como por exemplo a função Test ou
            //Uma função lambda que lembra a arrow function em Javascript.
            //string s1 = list.Find(Test);
            string name1 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"First name with 'A' char is: {name1}");

            //FindLast encontra o último elemento com a condição correspondente ao predicado (a função)
            //Ela recebe como argumento uma função que faz a verificação, como por exemplo a função Test ou
            //Uma função lambda que lembra a arrow function em Javascript.
            //string s1 = list.Find(Test);
            string name2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last name with 'A' char is: {name2}");
            Console.WriteLine();

            //FindIndex encontra a posição do primeiro elemento com a condição correspondente ao predicado (a função)
            //Ela recebe como argumento uma função que faz a verificação, como por exemplo a função Test ou
            //Uma função lambda que lembra a arrow function em Javascript. 
            int namePosition1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First position with 'A' char is: {namePosition1}");

            //FindLastIndex encontra a posição do último elemento com a condição correspondente ao predicado (a função)
            //Ela recebe como argumento uma função que faz a verificação, como por exemplo a função Test ou
            //Uma função lambda que lembra a arrow function em Javascript. 
            int namePosition2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"First position with 'A' char is: {namePosition2}");
            Console.WriteLine();


            //FindAll filtra a lista com base no predicado (a função)
            List<string> list2 = list.FindAll(x => x.Length >= 5);
            Console.WriteLine("Names with 5 or more characters:");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            //Remover elemento da lista:
            //Remove vai remover o elemento da lista com base no predicado (a função)

            Console.WriteLine("Removing Antônio from the list...");
            list.Remove("Antônio");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            Console.WriteLine("Removing names with 'M' character from the list...");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            Console.WriteLine("Removing the element at position two (index 1) from the list...");
            list.RemoveAt(1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            List<string> list3 = new List<string>();

            //List<string> listTwo = new List<string> { "Maria", "João" };

            //Add adiciona item ao final da lista
            list3.Add("Maria");
            list3.Add("Antônio");
            list3.Add("Bob");
            list3.Add("Anna");

            Console.WriteLine("Creating a new list...");
            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            Console.WriteLine("Removing all the elements betwen two (index 1) and three (index 2) from the list...");
            list3.RemoveRange(1, 2);
            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }

        }

        //static bool Test(string s)
        //{
        //    return s[0] == 'A';
        //}
    }
}