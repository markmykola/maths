using System;

// Абстрактний клас для геометричних тіл
abstract class Solid
{
    public abstract double GetVolume();
}

// Клас для куба
class Cube : Solid
{
    private double A; // Довжина ребра куба

    public Cube(double a)
    {
        A = a;
    }

    public override double GetVolume()
    {
        return Math.Pow(A, 3);
    }
}

// Клас для прямокутного паралелепіпеда
class RectSolid : Solid
{
    private double C; // Довжина основи
    private double D; // Ширина основи
    private double H; // Висота

    public RectSolid(double c, double d, double h)
    {
        C = c;
        D = d;
        H = h;
    }

    public override double GetVolume()
    {
        return C * D * H;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double a, c, d, h;

        do
        {
            // Введення даних для куба
            Console.Write("Введіть довжину ребра куба: ");
            if (double.TryParse(Console.ReadLine(), out a))
            {
                if (a >= 0)
                {
                    Cube cube = new Cube(a);
                    double cubeVolume = cube.GetVolume();
                    Console.WriteLine($"Об'єм куба: {cubeVolume}");
                    break;
                }
                else
                {
                    Console.WriteLine("Довжина ребра куба не може бути від'ємною.");
                }
            }
            else
            {
                Console.WriteLine("Некоректний ввід для куба.");
            }
        } while (true);

        do
        {
            // Введення даних для прямокутного паралелепіпеда
            Console.Write("Введіть довжину основи прямокутного паралелепіпеда: ");
            if (double.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Введіть ширину основи прямокутного паралелепіпеда: ");
                if (double.TryParse(Console.ReadLine(), out d))
                {
                    Console.Write("Введіть висоту прямокутного паралелепіпеда: ");
                    if (double.TryParse(Console.ReadLine(), out h))
                    {
                        if (c >= 0 && d >= 0 && h >= 0)
                        {
                            RectSolid rectSolid = new RectSolid(c, d, h);
                            double rectSolidVolume = rectSolid.GetVolume();
                            Console.WriteLine($"Об'єм прямокутного паралелепіпеда: {rectSolidVolume}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Всі величини повинні бути невід'ємними.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некоректний ввід для висоти прямокутного паралелепіпеда.");
                    }
                }
                else
                {
                    Console.WriteLine("Некоректний ввід для ширини основи прямокутного паралелепіпеда.");
                }
            }
            else
            {
                Console.WriteLine("Некоректний ввід для довжини основи прямокутного паралелепіпеда.");
            }
        } while (true);
    }
}