
//Напишите программу, в которой пользователь
// задает длину массива, элементы которого 
//задаются в диапазоне [1,99] и выводит на экран .
//5 -> [1, 2, 5, 7, 19]
//3 -> [6, 1, 33]

int getNumberFromUser(string UserInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(UserInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result <= 0)
        {
            Console.WriteLine($"Введите целое число > 0, вы ввели некорректное значение: {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}

int number = getNumberFromUser("Задайте длинну массива: ");

int[] array = new int[number + 1];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 99);
}

PrintArray(array);

void PrintArray(int[] array)
{
    Console.Write($"Эллементы массива длинной {number} -> [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}