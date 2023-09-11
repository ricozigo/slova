

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в игру в слова!");
        Console.WriteLine("Правила: Называйте слова, начиная с последней буквы предыдущего слова, либо 'к' для завершения игры.");

        string lastWord = string.Empty;
        bool gameOver = false;

        while (!gameOver)
        {
            Console.Write("Введите слово (или 'к' для завершения игры): ");
            string input = Console.ReadLine().ToLower();

            if (input == "к")
            {
                Console.WriteLine("Игра завершена. Спасибо за игру!");
                gameOver = true;
            }
            else if (IsValidWord(input, lastWord))
            {
                lastWord = input;
                Console.WriteLine($"Следующее слово должно начинаться с буквы '{lastWord[lastWord.Length - 1]}'");
            }
            else
            {
                Console.WriteLine("Это слово недопустимо. Попробуйте снова.");
            }
        }
    }

    static bool IsValidWord(string word, string lastWord)
    {
        return !string.IsNullOrEmpty(word) &&
               (lastWord == string.Empty || word[0] == lastWord[lastWord.Length - 1]);
    }
}