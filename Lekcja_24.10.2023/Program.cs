namespace Lekcja_24._10._2023;

class Program
{
    static void Main(string[] args)
    {
        bool flaga = false;
        
        do
        {
            try
            {
                Console.WriteLine("Podaj dwie liczby\n");
                System.Console.Write("Podaj x: ");
                int x = int.Parse(Console.ReadLine());
                System.Console.Write("Podaj y: ");
                int y = int.Parse(Console.ReadLine());
                if (y == 0)
                {
                    throw new Exception("You cant divide by 0");
                }
                double result = x / y;
                System.Console.Write($"Wynik dzielenia {x} / {y} = ");
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{result:F3}");
                Console.ResetColor();
                flaga = true;
            }
            catch (DivideByZeroException)
            {
            ErrorColorChange("You cant divide by 0");
            }
            catch (FormatException)
            {
                ErrorColorChange("\nBłędny format danych, podaj liczbe ziennoprzecinkową lub całkowitą");
            }
            catch (OverflowException)
            {
                ErrorColorChange($"Podana liczba jest błędna, podaj liczbe z zakresu <{int.MinValue} ; {int.MaxValue}>");
            }
            catch (Exception ex)
            {
                ErrorColorChange(ex.Message);
            }
        } while (!flaga);
    }

    static void ErrorColorChange(string comment)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine($"\nBłąd: {comment}");
        Console.ResetColor();
    }
}
