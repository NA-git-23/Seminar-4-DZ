// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16


Console.WriteLine("Введите первое число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число B:");
int b = Convert.ToInt32(Console.ReadLine());


   if (a > 0)
    {
        double result = Math.Pow(a, b);
        Console.WriteLine($"Число{a} ^ {b} степени = {result}");
    }
    
    else if (a < 0 || (b % 2)==0)
   
        {
            double result = Math.Pow(a, b);
            Console.WriteLine($"Число{a} ^ {b} степени = {result}");
        }
            else
            {
                double result = Math.Pow(a, b);
                Console.WriteLine($"Число -{a} ^ {b} степени = -{result}");
            }
    
Console.WriteLine();
