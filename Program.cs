
string[] CreateArr(int elementCount) {          //Создаём массив и заносим туда значения

    string[] myArray = new string[elementCount];
    

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
        myArray[i] = Console.ReadLine();
        
    }
    
    return myArray;
   
}

 string[] ArrSelection (string[] myArray) {         //создаём второй массив и сразу сортируем в него значения первого
        string[] SelectArray = new string[myArray.Length];
        int SecondArrayCount =0;
     for (int i = 0; i < myArray.Length; i++)
     {
        if (myArray[i].Length<= 3)
        {
            SelectArray[SecondArrayCount] = myArray[i];
            SecondArrayCount++;
        }
     }
     return SelectArray;
}

void Conclusion()                                     //Выводим всё вышенаписанное
{
    Console.Write("Введите количество элементов массива:\t");
    int elementCount = int.Parse(Console.ReadLine());
    
    string[] cop = ArrSelection(CreateArr(elementCount));
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < cop.Length; i++)
    {
        Console.Write($" {cop[i]}");
    }
}

Conclusion();


