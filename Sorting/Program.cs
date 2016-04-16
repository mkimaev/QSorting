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
        static void quickSort(int[] a, int l, int r)
        {
            int temp; //переменная для хранения временных значений
            int x = a[l + (r - l) / 2]; //переменная для опорного индекса
            int i = l; //переменная для начального индекса
            int j = r; //переменная для последнего индекса
            
            while (i <= j) //пробегаемся по массиву
            {
                while (a[i] < x) i++; //пропускаем если левые меньше опорного
                while (a[j] > x) j--; //пропускаем если правые больше опорного
                if (i <= j) //если есть нераскиданные значения - переставляем их местами
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r) //вызываем сортировку рекурсивно для левого подмассива
                quickSort(a, i, r);

            if (l < j) //вызываем сортировку рекурсивно для правого подмассива
                quickSort(a, l, j);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, Бро!\nВведи размер массива[]");
            int size;
            size = Convert.ToInt32(Console.ReadLine()); // ввод
            Console.WriteLine("Введите " + size + " чисел через ЗАПЯТУЮ и нажми Enter "); 
            Console.WriteLine();
            string str = Console.ReadLine();
            string[] mas = str.Split(','); //применяем класс который делит строчку на части между символами. у нас через запятую
            Console.WriteLine("Бро, ты ввел\t" + str + "\tполучай результат сортировки \n");

            int[] a = new int[size]; // создаём массив
            for (int i = 0; i < size; i++) // запускаем цикл для конверта все строк в цифру
            {
                a[i] = int.Parse(mas[i]); // парсим строчные в int
            }
            quickSort(a, 0, size - 1); //вызываем метод быстрой сортировки массива "а" с нулевого по последний елемент массива
            for (int i = 0; i < size; i++) //запускаем цикл для отображения сортировки методом быстрой сортировки
            {
                Console.WriteLine(a[i]);
                Console.WriteLine(' ');

            } //признаю, что задание помог сделать Google. Самому, зная алгоритм решения, получилось реализовать половину:)
            
        }
    }
}
