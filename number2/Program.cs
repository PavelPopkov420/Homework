int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
    Console.WriteLine("Максимальное число: " + Convert.ToString(a));

if (b > a && b > c)
   Console.WriteLine("Максимальное число: " + Convert.ToString(b));

if (c > b && c > a)
    Console.WriteLine("Максимальное число: " + Convert.ToString(c));

