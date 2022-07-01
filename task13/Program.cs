int n;
n = Convert.ToInt32(Console.ReadLine());
if (n % 100 == n)
Console.WriteLine("no third digit");
else
Console.WriteLine("third digit");
Console.WriteLine(Convert.ToString(n)[2]);
