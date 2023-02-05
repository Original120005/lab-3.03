using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
                int[][,] myMixedArray = new int[4][,];
                Random r = new Random();
                for (int i = 0; i < myMixedArray.Length; i++) {
                    myMixedArray[i] = new int[1, r.Next(2, 6)];
                }
                int min = myMixedArray[0].Length, max = 0, min_index = 0, max_index = 0;
                for (int i = 0; i < myMixedArray.Length; i++) {
                    for (int j = 0; j < myMixedArray[i].GetLength(0); j++) {
                        for (int t = 0; t < myMixedArray[i].GetLength(1); t++) {
                            myMixedArray[i][j, t] = r.Next(1, 20);
                            Console.Write(myMixedArray[i][j, t] + "\t");
                        }
                        Console.WriteLine();
                    }
                    if(min > myMixedArray[i].Length) { min = myMixedArray[i].Length; min_index = i; }
                    if (max < myMixedArray[i].Length) { max = myMixedArray[i].Length; max_index = i; }
                }
                Console.WriteLine($"\nmax = {max} \tindex = {max_index}");
                Console.WriteLine($"min = {min} \tindex = {min_index}");
                int[][,] arr = new int[1][,];
                arr[0] = myMixedArray[min_index];
                myMixedArray[min_index] = myMixedArray[max_index];
                myMixedArray[max_index] = arr[0];

                Console.WriteLine("\n");
                 for (int i = 0; i < myMixedArray.Length; i++) {
                    for (int j = 0; j < myMixedArray[i].GetLength(0); j++) {
                        for (int t = 0; t < myMixedArray[i].GetLength(1); t++) {
                            Console.Write(myMixedArray[i][j, t] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                

                
                /*int[][] mas = new int[8][];
                for(int i = mas.Length; i > 0; i--) {
                    mas[i - 1] = new int[i - 1];
                    for(int j = mas[i-1].Length; j > 0; j--) {
                        Console.Write(mas[i - 1][j - 1] + "\t");
                    }
                    Console.WriteLine();
                }*/
                
            }
        }
    }
}
    
