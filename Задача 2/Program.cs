int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result ==0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число, вы ввели некорректное значение: {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}

int x1 = getCoordinateFromUser ("Введите координату X точки 1: ");
int y1 = getCoordinateFromUser ("Введите координату Y точки 1: ");
int z1 = getCoordinateFromUser ("Введите координату Z точки 1: ");

int x2 = getCoordinateFromUser ("Введите координату X точки 2: ");
int y2 = getCoordinateFromUser ("Введите координату Y точки 2: ");
int z2 = getCoordinateFromUser ("Введите координату Z точки 2: ");

double length = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
Console.WriteLine($"Расстояние между точкой 1 с координатами х:{x1}, у:{y1}, z:{z1} и точкой 2 с координатами х:{x2}, у:{y2}, z:{z2} в 3D пространстве составляет: {length}");
