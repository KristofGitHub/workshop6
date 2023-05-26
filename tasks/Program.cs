// Напишите программу, которая принимает на вход три числа и проверяет, возможен ли треугольник со сторонами такой длины.
// Главное правило: каждая сторона должна быть строго меньше суммы длин двух других сторон.
// int a = GetUserInput("a");
// int b = GetUserInput("b");
// int c = GetUserInput("c");
// if (CheckTriangleExist(a, b, c)) Console.WriteLine("Треугольник существует.");
// else Console.WriteLine("Треугольник не существует");

// bool CheckTriangleExist(int a, int b, int c)
// {
//     if ((a < b + c) && (b < a + c) && (c < a + b)) return true;
//     else return false;
// }

// int GetUserInput(string name)
// {
//     Console.Write($"Введите длину стороны {name} = ");
//     int userInput = Convert.ToInt32(Console.ReadLine());
//     return userInput;
// }

// Ввывести числа Фибоначчи без использования рекурсии.
// int f_prefinal = 0;
// int f_final = 1;
// Console.Write($"{f_prefinal}, ");
// Console.Write($"{f_final}, ");

// for(int i = 0; i < 40; i++) 
// {
//     int f_next = GetFibonachiNextTerm(f_prefinal, f_final);
//     Console.Write($"{f_next}, ");
//     f_prefinal = f_final;
//     f_final = f_next;
// }

// int GetFibonachiNextTerm(int f_prefinal, int f_final)
// {
//     int f_next;
//     return f_next = f_prefinal + f_final;
// }

// Развернуть массив.
int[] array = CreateRandomArray(9, -9, 9);
PrintArray(array);
int[] reverseArray = ArrayReverse(array);
PrintArray(reverseArray);

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int index = 0; index < size; index++){newArray[index] = new Random().Next(minValue, maxValue + 1);}
    return newArray;
}

void PrintArray(int[] arrayExample)
{
    int size = arrayExample.Length;
    for(int index = 0; index < size; index++){Console.Write(arrayExample[index] + " ");}
    Console.WriteLine();
}

int[] ArrayReverse(int[] array)
{
    for(int i = 0; i < array.Length/2; i++) (array[i], array[(array.Length - 1) - i]) = (array[(array.Length - 1) - i], array[i]);
    return array;
}