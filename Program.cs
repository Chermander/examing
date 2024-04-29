
string[] CreateArr(int elementCount) {

    string[] myArray = new string[elementCount];
    

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива пол индексом {i}:\t ");
        myArray[i] = Console.ReadLine();
        
    }
    
    return myArray;
   
}

 string[] ArrSelection (string[] myArray) {
        string[] SelectArray = new string[myArray.Length];
        int k =0;
     for (int i = 0; i < myArray.Length; i++)
     {
        if (myArray[i].Length<= 3)
        {
            SelectArray[k] = myArray[i];
            k++;
        }
     }
     return SelectArray;
}

    Console.Write("Введите количество элементов массива:\t");
    int elementCount = int.Parse(Console.ReadLine());
    //CreateArr(elementCount);
    //ArrSelection(CreateArr(elementCount));

void Conclusion
     Console.WriteLine("Вывод массива");
     string[] cop = ArrSelection(CreateArr(elementCount));

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(cop[i]);
    }


