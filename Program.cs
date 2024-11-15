using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. В одномерном массиве из 8 целых чисел с явной инициализацией обнулить значения трех элементов, начиная с индекса, равного 1.
            /*
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 1; i <= 3; i++) 
            {
                number[i] = 0;
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.ReadLine();
            */

            //Задача 2. Изменить размер одномерного массива.

            /*
            int[] array = new int [9];
            for (int i = 0; i < array.Length; i++)
            {
                array [i] = i + 1;  
                Console.WriteLine(array[i]); //Размер масва равен 9
            }   
            */

            //Задача 3. Найти индекс первого отрицательного элемента одномерного массива, заполненного случайным образом в диапазоне от -5 до 5.

            Random rand = new Random();
            

            int[] number = new int[10];

            for (int i = 0; i < number.Length; i++) 
            {
                number[i] = rand.Next(-5,6);
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}
