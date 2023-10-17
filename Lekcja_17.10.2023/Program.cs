namespace Lekcja_17._10._2023;

class Program
{
    static bool CzyTrojkat(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    static void Main(string[] args)
    {
        // Obliczenie pola trójkąta ze wzoru herona

        // double a;
        // if(double.TryParse(Console.ReadLine(), out a))
        // {
        //     System.Console.WriteLine(a);
        // }
        // else
        // {
        //     System.Console.WriteLine("Błędne dane!");
        // }

        System.Console.Write("Podaj a: ");
        double a;
        while(!double.TryParse(Console.ReadLine(), out a) || a <= 0)
        {
            System.Console.Write("Wpisz prawidłowe dane: ");
        }

        System.Console.Write("Podaj b: ");
        double b;
        while(!double.TryParse(Console.ReadLine(), out b) || b <= 0)
        {
            System.Console.Write("Wpisz prawidłowe dane: ");
        }

        System.Console.Write("Podaj c: ");
        double c;
        while(!double.TryParse(Console.ReadLine(), out c) || c <= 0)
        {
            System.Console.Write("Wpisz prawidłowe dane: ");
        }

        if(CzyTrojkat(a,b,c))
        {
            System.Console.WriteLine("Pole trojkata o bokach {0}, {1}, {2} wynosi: ", a, b, c);
        }
        else
        {
            System.Console.WriteLine("Podane dlugosci bokow nie tworza trojkata");
        }
    }
}
