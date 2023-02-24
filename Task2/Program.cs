Console.WriteLine("Введите через пробел координаты первой точки A: ");
    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if (arr.Length != 3)
    {
        Console.WriteLine("Неверно ввели");
        return;
    }

    var pointA = new Point() {
        x = arr[0],
        y = arr[1],
        z = arr[2]
    };

    Console.WriteLine("Введите через пробел координаты второй точки B: ");
    arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if (arr.Length != 3)
    {
        Console.WriteLine("Неверно ввели");
        return;
    }

    var pointB = new Point()
    {
        x = arr[0],
        y = arr[1],
        z = arr[2]
    };

    var result = Math.Round(Math.Sqrt(Math.Pow((pointB.x - pointA.x), 2) +
                     Math.Pow((pointB.y - pointA.y), 2) +
                     Math.Pow((pointB.z - pointA.z), 2)), 2);

    Console.WriteLine(result);


struct Point
{
    public int x, y, z;
}