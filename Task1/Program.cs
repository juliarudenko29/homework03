Console.Write("введи пятизначное число: ");
    int value = Int32.Parse(Console.ReadLine());

    var countSymbols = Math.Floor(Math.Log10(value) + 1);

    if (countSymbols != 5)
    {
        Console.WriteLine("Аааа жесть! Введите пятизначное число!1!!!11!");
        return;
    }
    int result;
    var temp = value;
    var divider = 10000;
    var reversValue = 0;

    for (int i = 0; i < 5; i++)
    {
        reversValue += temp % 10 * divider;
        temp = temp / 10;
        divider = divider / 10;

        // на случай если в конце числа будет 0
        if (i == 0 && reversValue == 0)
            break;
    }

    var resultStr = reversValue == value ? "палиндром" : "не палиндром"; 
    Console.WriteLine($"Число: {value} {resultStr}");