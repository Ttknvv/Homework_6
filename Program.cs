void FillArrayKey(int[] array, int start, int end)
{
    int size = array.Length;
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-е число - ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountPosNum(int[] array)
{
    int size = array.Length;
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Zadacha_41()
{
    Console.Write("Введите размер массива - ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];
    FillArrayKey(array, -999, 1000);

    int count = CountPosNum(array);
    Console.Write($"Количество положительных чисел - {count}");
}
//Zadacha_41();


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Zadacha_43()
{
    Console.Write("Введите B1 - ");
    double bOne = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите K1 - ");
    double kOne = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите B2 - ");
    double bTwo = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите K2 - ");
    double kTwo = Convert.ToDouble(Console.ReadLine());
    
    if(kOne != kTwo)
    {
        double x = (bTwo - bOne)/(kOne - kTwo);
        double y = kOne * x + bOne;
        Console.WriteLine($"Координаты точки пересечения - ({Math.Round(x, 2)};{Math.Round(y, 2)})");
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
    }
}
//Zadacha_43();