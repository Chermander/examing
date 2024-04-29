
    Console.Write("Введите количество элементов массива:\t");

    int elementCount = int.Parse(Console.ReadLine());


    string[] myArray = new string[elementCount];

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива пол индексом {i}:\t ");
        myArray[i] = Console.ReadLine();
        
    }
    Console.WriteLine("Вывод массива");

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine(myArray[i]);
    }

    Console. Write(myArray[1].Length);
