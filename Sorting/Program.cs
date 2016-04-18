using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        //метод с тремя вводными параметрами (название массива, первый индекс, последний индекс)
        static void QuickSort(int[] array, int first, int last)
        {
            int temp; //переменная для хранения временных значений
            int x = array[first + (last - first) / 2]; //переменная для опорного индекса
            int i = first; //переменная для начального индекса
            int j = last; //переменная для последнего индекса
            
            while (i <= j) //пробегаемся по массиву
            {
                while (array[i] < x) i++; //пропускаем если левые меньше опорного
                while (array[j] > x) j--; //пропускаем если правые больше опорного
                if (i <= j) //если есть нераскиданные значения - переставляем их местами
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < last) //вызываем сортировку рекурсивно для левого подмассива
            {
                QuickSort(array, i, last);
            }
            if (first < j) //вызываем сортировку рекурсивно для правого подмассива
            {
                QuickSort(array, first, j);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, Бро!\nВведи размер массива[]");
            int size;
            size = Convert.ToInt32(Console.ReadLine()); // ввод
            Console.WriteLine("Введите " + size + " чисел через ЗАПЯТУЮ и нажмите Enter "); 
            Console.WriteLine();
            string str = Console.ReadLine();
            string[] mas = str.Split(','); //применяем класс который делит строчку на части между символами. у нас через запятую
            Console.WriteLine("Бро, ты ввел\t" + str + "\tполучай результат сортировки \n");

            int[] nums = new int[size]; // создаём массив
            for (int i = 0; i < size; i++) // запускаем цикл для конверта все строк в цифру
            {
                nums[i] = int.Parse(mas[i]); // парсим строчные в int
            }
            QuickSort(nums, 0, size - 1); //вызываем метод быстрой сортировки массива "nums" с нулевого по последний елемент массива
            for (int i = 0; i < size; i++) //запускаем цикл для отображения сортировки методом быстрой сортировки
            {
                Console.WriteLine(mas[i]); 
                Console.WriteLine(' ');

            } //признаю, что задание помог сделать Google. Самому, зная алгоритм решения, получилось реализовать половину:)
            
        }
    }
}
