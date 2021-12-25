struct Complex
{
    public int a, b;

    public Complex(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public static Complex Sum(Complex z1, Complex z2)
    {
        Complex result;
        result = new(z1.a + z2.a, z1.b + z2.b);
        return result;
    }

    public static Complex Sub(Complex z1, Complex z2)
    {
        Complex result;
        result = new(z1.a - z2.a, z1.b - z2.b);
        return result;
    }


    public override string ToString()
    {
        string s;
        if (b < 0)
        {
            s = $"{a} - {-b}i";
        }
        else s = $"{a} + {b}i";
        return s;
    }


}