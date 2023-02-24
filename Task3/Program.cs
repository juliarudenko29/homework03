Console.Write("Введите число N: ");
    var n = Convert.ToInt32(Console.ReadLine());

    var numberList = new int[n + 1];

    int counter = 0;
    int length = numberList.Length;
    while (counter < length)
    {
        numberList[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }

    int count = numberList.Length;
    int index = 1;
    while (index < count)
    {
        Console.Write(numberList[index] + " ");
        index++;
    }
    Console.ReadKey();