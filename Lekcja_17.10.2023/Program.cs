namespace Lekcja_17._10._2023;

class Program
{
    static bool CzyTrojkat(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static double PoleHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
        return s;
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

        bool CzyPoprawna = false;
        do
        {
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
                CzyPoprawna = true;
                double area = PoleHeron(a,b,c);
                // Console.OutputEncoding = System.Text.Encoding.unicode;
                System.Console.WriteLine("Pole trojkata o bokach {0}, {1}, {2} wynosi: {3:F4}cm\u00b2", a, b, c, area); // F4 - dostajemy liczbe z 4 cyframi po przecinku
                // Console.OutputEncoding = System.Text.Encoding.default;
            }
            else
            {
                System.Console.WriteLine("Podane dlugosci bokow nie tworza trojkata");
                Thread.Sleep(2000);
                Console.Clear();
            }   
        }while (!CzyPoprawna);
    }
}
