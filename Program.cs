// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

    string[] FilterStringArray(string[] inputArray)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                filteredArray[index++] = inputArray[i];
            }
        }

        return filteredArray;
    }	

    Console.WriteLine("Введите элементы массива, разделяя их запятой:");
    string? input = Console.ReadLine();

    string[] stringArray = input!.Split(',');

    string[] filteredArray = FilterStringArray(stringArray);

    Console.WriteLine("Отфильтрованный массив:");
    Console.WriteLine(string.Join(", ", filteredArray));
    

    