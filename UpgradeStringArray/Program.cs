const int maxLength = 3; // максимальная длина слова, удовлетворяющая условию

// Медод, принимает на вход массив строк words и 
// возвращает количество слов длиной меньше либо равно length 
int CountWordsLessLength(string[] words, int length)
{
    int count = 0;
    foreach (string word in words)
    {
        if (word.Length <= length) count++;
    }
    return count;
}
// Медод, принимает на вход массив строк words и 
// возвращает массив слов длиной меньше либо равно length 
string[] WordsLessLength(string[] words, int length)
{
    string[] newWords = new string[CountWordsLessLength(words, length)];
    int index = 0;
    foreach (string word in words)
    {
        if (word.Length <= length)
        {
            newWords[index] = word;
            index++;
        } 
    }
    return newWords;
}
// Метод, осуществляющий вывод массива string на консоль
void PrintArray(string[] array)
{
    foreach (string element in array)
    {
        Console.Write($"[{element}] ");
    }
    Console.WriteLine();
}
Console.Write("Введите строку:");
string str = Console.ReadLine();
string[] words = str.Split(' ',StringSplitOptions.RemoveEmptyEntries);
PrintArray(WordsLessLength(words, maxLength));