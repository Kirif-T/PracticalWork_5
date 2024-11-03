using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inputPhrase = Console.ReadLine();
            string result = ReverseWords(inputPhrase);
            Console.WriteLine("Результат: " + result);
        }

        static string ReverseWords(string inputPhrase)
        {
            string[] words = SplitText(inputPhrase);
            Array.Reverse(words);

            // Преобразуем первую букву первого слова и последнего слова
            if (words.Length > 0)
            {
                words[0] = char.ToUpper(words[0][0]) + words[0].Substring(1).ToLower(); // Первое слово
            }
            if (words.Length > 1)
            {
                words[words.Length - 1] = char.ToLower(words[words.Length - 1][0]) + words[words.Length - 1].Substring(1); // Последнее слово
            }

            string resultString = string.Empty;

            // Собираем обратно в строку
            foreach (string word in words)
            {
                resultString += word + " ";
            }

            return resultString.Trim(); // Удаляем последний пробел
        }

        static string[] SplitText(string text)
        {
            return text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
