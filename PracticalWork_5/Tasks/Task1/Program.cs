using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();

            // Разделяем предложение на слова
            string[] words = SplitText(input);

            // Вывод каждого слова на отдельную строку
            PrintWords(words);
        }

        // Метод разделения текста на слова
        static string[] SplitText(string text)
        {
            return text.Split(' '); // Разделение строки по пробелам
        }

        // Метод вывода каждого слова на отдельной строке
        static void PrintWords(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
