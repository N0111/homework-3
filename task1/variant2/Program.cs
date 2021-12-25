// Коробчук А.
//1
// б) Дописать класс Complex, добавив методы вычитания
//  и произведения чисел. Проверить работу класса.
class Program
{
    static void Main()
    {
        Complex z1 = new Complex(1, -2);
        Console.WriteLine(z1);

        Complex z2 = new(3, -4);
        Console.WriteLine(z2);

        Complex z3;
        z3 = Complex.Sum(z1, z2);
        Console.WriteLine(z3);

        Complex z4;
        z4 = Complex.Sub(z1, z2);
        Console.WriteLine(z4);

        Complex z5;
        z5 = Complex.Mul(z1, z2);
        Console.WriteLine(z5);

    }

}