namespace Tools;

public static class Int32Extensions
{
    public static bool IsPrime(this int number)
    {
        if (number < 2) throw new ArgumentException($"La valeur {number} ne peut pas être inférieure à 2.");
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i < boundary; i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
