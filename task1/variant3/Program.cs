// Коробчук А.
//1
// в) Добавить диалог с использованием switch демонстрирующий работу класса.
class Program
{
    static void Main()
    {
        //Console.Write("Введите число 1, если хотите отнять числа; Число 2 - прибавить; Число 3 - умножить ");
        //int s = Convert.ToInt32(Console.ReadLine());
        int s;
        do 
        {
            Console.Write("Введите число 1, если хотите отнять числа; Число 2 - прибавить; Число 3 - умножить ");
            s = Convert.ToInt32(Console.ReadLine());
        }while (s > 3 | s < 1); 

        Complex z1 = new Complex(1, -2);
        Console.WriteLine(z1);

        Complex z2 = new(3, -4);
        Console.WriteLine(z2);
        Complex z3 = z2;

        switch (s)
        {
            case 1:
                z3 = Complex.Sub(z1, z2);
break;
            case 2:
                z3 = Complex.Sum(z1, z2);
break;
            case 3:
                z3 = Complex.Mul(z1, z2);
break;

        }
        Console.WriteLine(z3);


    }


}

