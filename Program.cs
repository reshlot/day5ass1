using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5JArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] studentScores = new int[3][]
            {
                new int[] { 85, 92, 78 },
                new int[] { 90, 87, 93, 89 },
                new int[] { 76, 88 }
            };

            Console.WriteLine("Student Scores:");
            Console.WriteLine("----------------");

            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write("Student {0}: ", (i + 1));
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write("{0} ", studentScores[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nAverage Scores:");
            Console.WriteLine("----------------");

            for (int i = 0; i < studentScores.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                double average = sum / studentScores[i].Length;
                Console.WriteLine("Student {0}: {1}", (i + 1), average);
            }

            double totalSum = 0;
            int totalLength = 0;
            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalLength++;
                }
            }
            double totalAverage = totalSum / totalLength;

            Console.WriteLine("\nAverage Score for all Students Combined: {0}", totalAverage);

            Console.ReadLine();
        }
    }
    }

