void FillArray2(int[] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Console.WriteLine("Введите числo:");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Следующее:");
    }
}

void PrintArray2(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Числа, которые вы ввели: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +"\t");
    }
    Console.WriteLine();
}

void Task41()
{
    /*Задача 41: Пользователь вводит с клавиатуры M чисел. 
    Посчитайте, сколько чисел больше 0 ввёл пользователь.
        0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3  */

    Console.WriteLine();
    Console.WriteLine("Сколько чисел Вы хотите ввести?");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [size];
    FillArray2(array);
    PrintArray2(array);
    CountPositiveNumbers(array);
}    

void CountPositiveNumbers(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Из чисел, которые вы ввели {count} больше 0.");
    Console.WriteLine();
}

void Task42()
{
    /*
    Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    */

    Console.Write("Введите значение b1 =  ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k1 =  ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение b2 =  ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k2 =  ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    PointAdress(b1, k1, b2, k2); 
}

void PointAdress(double b1, double k1,  double b2, double k2 )
{
    double x = (b2 -b1)/(k1-k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых: [{x}, {y}]");
}

//Task41();
Task42();