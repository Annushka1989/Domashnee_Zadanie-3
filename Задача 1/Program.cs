//Напишите программу, которая 
//принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

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
            Console.WriteLine($"Введите целое число от 1 до N, вы ввели некорректное значение: {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}
int number = getNumberFromUser("Введите целое число от 1 до N: ");

for (int i = 1; i <= number; i++)
{
   Console.WriteLine ($"Для числа {i} куб равен {Math.Pow(i, 3)}"); 
}
