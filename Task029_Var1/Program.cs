// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// // (вводим массив с клавиатуры (т. е. через консоль)

Console.Write ("Введите число A: ");
int A = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число B: ");
int B =Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число C: ");
int C =Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число D: ");
int D =Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число E: ");
int E =Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число F: ");
int F =Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число G: ");
int G =Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число H: ");
int H =Convert.ToInt32 (Console.ReadLine());

int [] array = new int[8];
array [0] = A;
array [1] = B;
array [2] = C;
array [3] = D;
array [4] = E;
array [5] = F;
array [6] = G;
array [7] = H;

Console.WriteLine($"Массив из 8 элементов: {'['+string.Join(", ", array)+']'}");

// Второй вариант выведения массива на экран:
// Console.WriteLine($"Массив из 8 элементов = [ {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]} ]");
