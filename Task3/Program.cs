/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс Dictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен System.Collections.Generic. Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества пар элементов.  
*/
using System;

namespace Task3
{
    class Program
    {
        static string twoWordsWithASpacebar, theRequestWord;
        static string[] arrayOfWordsWithoutSpacebar;
        static Dictionary<string, string> dictionary;

        static void Main()
        {
            Console.WriteLine("Пример новых комбинаций для словаря:\napple яблоко orange апельсин\n\nЗапись новых слов: ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            twoWordsWithASpacebar = Console.ReadLine();
            Console.ResetColor();

            //Имеется ли в строке спецсимвол пробел? Если да, то разбиваем строку на подстроки и передаём в метод AddPairsOfElements английское и русское слово
            if (twoWordsWithASpacebar.Contains(' ') && (twoWordsWithASpacebar[twoWordsWithASpacebar.Length - 1] != ' '))
            {
                arrayOfWordsWithoutSpacebar = twoWordsWithASpacebar.Split(' ');
                dictionary = new Dictionary<string, string>(arrayOfWordsWithoutSpacebar.Length / 2);

                for (int i = 0; i < arrayOfWordsWithoutSpacebar.Length; i++)
                {
                    dictionary.AddPairsOfElements(arrayOfWordsWithoutSpacebar[i], arrayOfWordsWithoutSpacebar[i + 1]);
                    i++;
                }

                Console.WriteLine("\nПеревод какого слова вывести на экран?");
                Console.ForegroundColor = ConsoleColor.Cyan;
                theRequestWord = Console.ReadLine();
                Console.ResetColor();

                Console.WriteLine($"\n{dictionary[theRequestWord]}");
            }

            else
                Console.WriteLine("\nСтрока либо не имеет пробела между словами, либо заканчивается пробелом!");

            Console.ReadKey();
        }
    }
}
