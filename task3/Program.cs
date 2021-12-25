//Коробчук А.
// 3. *Описать класс дробей — рациональных чисел,
//  являющихся отношением двух целых чисел.
//  Предусмотреть методы сложения, вычитания,
//   умножения и деления дробей. Написать программу,
//  демонстрирующую все разработанные элементы класса.

// Добавить свойства типа int для доступа к числителю и знаменателю;
// Добавить свойство типа double только на чтение,
//  чтобы получить десятичную дробь числа;
//  ** Добавить проверку, чтобы знаменатель не равнялся 0.
//   Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");

class Program
{

    public static double NumberA()
    {
        Console.Write("Введите числитель: ");
        double a = Convert.ToDouble(Console.ReadLine());
        return a;
    }
    public static double NumberB()
    {
        Console.Write("Введите знаменатель: ");
        double b = Convert.ToDouble(Console.ReadLine());
        while (b == 0)
        {
            Console.Write("Знаменатель не может равняться 0. Введите другой: ");
            b = Convert.ToDouble(Console.ReadLine());
        }
        return b;
    }

    static void Main()
    {

        double a1 = NumberA();
        double b1 = NumberB();
        double c1 = a1 / b1;
        Console.WriteLine(c1);

        double a2 = NumberA();
        double b2 = NumberB();
        double c2 = a2 / b2;
        Console.WriteLine(c2);

        Fraction fraction = new Fraction(c1, c2);
        Console.WriteLine(c1 + "+" + c2 + "=" + fraction.Sum());
        Console.WriteLine(c1 + "-" + c2 + "=" + fraction.Sub());
        Console.WriteLine(c1 + "*" + c2 + "=" + fraction.Mul());
        Console.WriteLine(c1 + "/" + c2 + "=" + fraction.Sha());
    }

}