using System;

namespace lab4ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. 
             Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul
             */

            int n = int.Parse(Console.ReadLine());
            int[] vectorIntregi = new int[n];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine($"Introduceti numarul de pe pozitia {i}:");
                vectorIntregi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vectorIntregi.Length; i++)
            {
                Console.WriteLine(" "+ $"[{i}] =" + ReverseArray(vectorIntregi)[i]);
            }
                       
            static int[] ReverseArray(int[] arr)
            {
                int[] newArr= new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[arr.Length - 1 - i] = arr[i]; 
                }
                return newArr;
            }
        }
    }
}
