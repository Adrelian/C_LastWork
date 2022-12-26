void userArray ()
{
    // Пользовательский ввод размера массива
    
    Console.Write("Введите размер массива данных ");
    int size = Convert.ToInt32(Console.ReadLine());

    string [] UserFirstArray = new string [size]; // Массив пользовательских строк
    string [] UserSecondArray = new string [size]; // Массив строк, где длина символом меньше 3

    // Вводим каждый новый элемент массива построчно

    for (int i = 0; i < size; i++)
    {
        string element = string.Empty;
        Console.Write($"Введите {i+1} элемент массива ");
        element = Console.ReadLine();
        if (element.Length < 3)
        {
            UserSecondArray[i] = element;
        }
        UserFirstArray[i] = element;
    }
    // Вывод массива пользователя
    Console.Write("Массив пользователя -> ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(UserFirstArray[i] + ", ");
    }

    Console.WriteLine(); // отступ

    // Вывод массива пользователя  с элементами длиной меньше 3
    Console.Write("Массив элементов длинной меньше 3 символов -> ");
    for (int i = 0; i < size; i++)
    {
        if (UserSecondArray[i] != null)
        {
            Console.Write(UserSecondArray[i] + ", ");  
        }
    } 
}

userArray();