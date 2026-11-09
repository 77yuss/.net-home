//  task 1
// void PrintFromNumberToOne(int number)
// {
//     for (int i = number; i >= 1; i--)
//     {
//         Console.Write(i + " ");
//     }
// }

// int n = Convert.ToInt32(Console.ReadLine());

// PrintFromNumberToOne(n);

//  task2
// int Sum(int a, int b, int c, int d)
// {
//     return a + b + c + d;
// }

// string[] input = Console.ReadLine()!.Split();

// int a = int.Parse(input[0]);
// int b = int.Parse(input[1]);
// int c = int.Parse(input[2]);
// int d = int.Parse(input[3]);

// Console.WriteLine(Sum(a, b, c, d));

//   task3
// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }

// int n = int.Parse(Console.ReadLine()!);
// PrintStars(n);

//  task 4
// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }

// void PrintSquare(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         PrintStars(size);
//     }
// }

// int n = int.Parse(Console.ReadLine()!);
// PrintSquare(n);

//  task 6
// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }

// void PrintRectangle(int width, int height)
// {
//     for (int i = 0; i < height; i++)
//     {
//         PrintStars(width);
//     }
// }
// string[] numbers = Console.ReadLine()!.Split();

// int width = int.Parse(numbers[0]);
// int height = int.Parse(numbers[1]);

// PrintRectangle(width, height);

//  task 7
// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }

// void PrintTriangle(int size)
// {
//     for (int i = 1; i <= size; i++)
//     {
//         PrintStars(i);
//     }
// }

// int n = int.Parse(Console.ReadLine()!);
// PrintTriangle(n);


// Home 2
// int Add(int a, int b)
// {
//     return a + b;
// }

// int Subtract(int a, int b)
// {
//     return a - b;
// }

// int Multiply(int a, int b)
// {
//     return a * b;
// }

// int Division(int a, int b)
// {
//     return a / b;
// }

// string[] input = Console.ReadLine()!.Split();

// int a = int.Parse(input[0]);
// int b = int.Parse(input[1]);

// Console.WriteLine($"Add:{Add(a, b)} Subtract:{Subtract(a, b)} Multiply:{Multiply(a, b)} Division:{Division(a, b)}");



// hometask 3
// int MinDigit(int n)
// {
//     int min = 9;

//     for (; n > 0; n /= 10)
//     {
//         int digit = n % 10;

//         if (digit < min)
//         {
//             min = digit;
//         }
//     }

//     return min;
// }

// int MaxDigit(int n)
// {
//     int max = 0;

//     for (; n > 0; n /= 10)
//     {
//         int digit = n % 10;

//         if (digit > max)
//         {
//             max = digit;
//         }
//     }

//     return max;
// }

// int n = int.Parse(Console.ReadLine()!);

// int min = MinDigit(n);
// int max = MaxDigit(n);

// Console.WriteLine($"{min} + {max} = {min + max}");


// home 4
// int Pow(int x, int y)
// {
//     int result = 1;
//     for (int i = 0; i < y; i++)
//     {
//         result *= x;
//     }

//     return result;
// }

// string[] input = Console.ReadLine()!.Split();

// int x = int.Parse(input[0]);
// int y = int.Parse(input[1]);

// Console.WriteLine(Pow(x, y));



// home 8
// int MinNumber(int a, int b, int c, int d)
// {
//     int min = a;

//     if (b < min)
//         min = b;

//     if (c < min)
//         min = c;

//     if (d < min)
//         min = d;

//     return min;
// }

// string[] input = Console.ReadLine()!.Split();

// int a = int.Parse(input[0]);
// int b = int.Parse(input[1]);
// int c = int.Parse(input[2]);
// int d = int.Parse(input[3]);

// Console.WriteLine(MinNumber(a, b, c, d));


// Home 9
// int Min(int v1, int v2)
// {
//     if (val1 < v2)
//         return v1;
//     else
//         return v2;
// }

// string[] input = Console.ReadLine()!.Split();

// int a = int.Parse(input[0]);
// int b = int.Parse(input[1]);

// Console.WriteLine(Min(a, b));

