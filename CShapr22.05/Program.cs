using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapr22._05
{
    internal class Program
    {
        static void Print(int[] arr)
        {         
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Randomize(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(10);
            }
        }
        static void Main(string[] args)
        {
            /*
            Пользователь вводит с клавиатуры два числа. Нужно
            показать все четные числа в указанном диапазоне. Если
            границы диапазона указаны неправильно требуется произвести нормализацию границ.
            Например, пользователь ввел 20 и 11, требуется нормализация, после которой
            начало диапазона станет равно 11, а конец 20
            
            int a = int.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                int temp = a;
                a = b; 
                b = temp;
            }
            Console.WriteLine();
            for(int i = a; i <= b; i++)
            {
                if (i%2 == 0) { Console.WriteLine(i); }
            }

            //тип_элементов[] имя_массива;
            int[] intArr;
            intArr = new int[2];
            string[] strArr = new string[10];

            int[] intArr1 = new int[10] { 7, 8, 9, 1, 3, 8, 6, 7, 0, 1 };
            int[] intArr2 = new int[] { 7, 9, 5, 4, 5, 4, 2, 1, 3, 7 };
            int[] intArr3 = { 7, 98, 9, 5, 42, 6 };
            for (int i = 0;i < intArr1.Length; i++)
            {
                Console.Write(intArr1[i] + " ");
            }
            Console.WriteLine();
            foreach(int i in intArr2)
            {
                Console.Write(i + " ");
            }*/

            /*
            GetLength()
            CopyTo()
            Clone() { return Object[]}
            Array.BinarySearch()
            Array.Clear()
            Array.IndexOf() LastIndexOf()
            Array.Resize() Reverse() Sort()
             
            Contains()

            Length
            Rank
             

            int[] intArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Print("Массив intArray 1: ", intArr1);
            int[] tempArr = (int[])intArr1.Clone();
            Array.Reverse(intArr1, 3, 4);
            Print("Массив intArray 1 после переворота: ", intArr1);
            intArr1 = tempArr;

            int[] intArr2 = new int[20];
            Print("Массив intArray 2: ", intArr2);
            intArr1.CopyTo(intArr2, 5);
            Print("Массив intArray 2 после копирования: ", intArr2);

            Array.Clear(intArr2, 0, intArr2.GetLength(0));
            Print("Массив intArray 2 после очистки: ", intArr2);
            Array.Resize(ref intArr2, 10);
            Print("Массив intArray 2 после изменения размера: ", intArr2);
            intArr2 = new int[] { 7, 8, 9, 6, 4, 2, 2, 3, 4 };
            Print("Массив intArray 2: ", intArr2);
            Array.Sort(intArr2);
            Print("Массив intArray 2 после сортировки: ", intArr2);

            Console.WriteLine("Минимум - " + intArr2.Min());
            Console.WriteLine("Максимум - " + intArr2.Max());
            Console.WriteLine("Среднее - " + intArr2.Average());

            int[,,,,,,,,,,] mnogoArr = new int[2, 7, 7, 6, 4, 6, 4, 3, 1, 3, 7];
            Console.WriteLine(mnogoArr.Rank);*/

            /*int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[,] arr2 = new int[,] { {1, 2, 3 }, {4, 5, 6 }, {7, 8, 9} };
            int[][] arr3 = new int[3][]
            {
                new int[3]{1,2,3},
                new int[]{4, 5},
                new int[]{6, 7, 8,9, 10}
            };

            foreach(int i in arr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            foreach(int i in arr2)
            { 
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < arr3.Length; i++)
            {
                foreach (int j in arr3[i])
                {
                    Console.Write(j + " ");
                }
            }*/

            /*
             * Создайте приложение, которое отображает количество
             * чётных, нечётных, уникальных элементов массива.
             */

            int[] arr = new int[20];
            Randomize(arr);
            Print(arr);
            int even = 0, odd = 0, unique = 0;
            foreach (int i in arr)
            {
                /*if (i % 2 == 0) even++;
                else odd++;*/
                _ = (i % 2 == 0) ? even++ : odd++;
            }
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i] && i != j) {
                        flag = true;
                        break; 
                    }
                }
                if (!flag)unique++;
                flag= false;
            }
            foreach(int i in arr.Distinct())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(even + "\n" + odd + "\n" + unique);

            /*Создайте приложение, отображающее количество
            значений в массиве меньше заданного параметра пользователем. 
            Например, количество значений меньших, чем 7
            (7 введено пользователем с клавиатуры).
            */
            int n = int.Parse(Console.ReadLine());
            foreach(int i in arr)
            {
                if (i < n) Console.WriteLine(i + " ");
            }
            /*
            Пользователь вводит с клавиатуры три числа. 
            Необходимо подсчитать сколько раз последовательность из этих
            трёх чисел встречается в массиве.
            Например:
            пользователь ввёл: 7 6 5;
            массив: 7 6 5 3 4 7 6 5 8 7 6 5;
            количество повторений последовательности: 3.
             */
            string intArray = Console.ReadLine();
            string intArray2 = Console.ReadLine();
            intArray2.Contains(intArray);


            
            Console.ReadKey();
        }
    }
}
