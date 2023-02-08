// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]


//static void Main(int[] args)
        {
            int [] arr = new int[8] {1};
           Console.ReadLine();
            
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write($"Введите элементы массива:  \t ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();
        }
