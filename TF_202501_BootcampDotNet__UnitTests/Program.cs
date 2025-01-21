//using TF_202501_BootcampDotNet__UnitTests.Models;


//Console.WriteLine(Int32Extensions.IsPrime(3)); // true
//Console.WriteLine(Int32Extensions.IsPrime(4)); // false
//Console.WriteLine(Int32Extensions.IsPrime(5)); // true
//Console.WriteLine(Int32Extensions.IsPrime(0)); // ArgumentException()...

using Tools;

int compteur = 0;

while (compteur < 100)
{
    if (compteur.IsPrime())
    {
        Console.WriteLine();
    }
}