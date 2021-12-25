//Коробчук А.
// 1.
// а) Дописать структуру Complex,
//  добавив метод вычитания комплексных чисел.
//   Продемонстрировать работу структуры.
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
    }
}