namespace CustomPower;
public class Class1
{
    public double MyPow(double x, int n)
    {
        double constant = x;
        if (n == Int32.MaxValue)
        {
            return (x == 1) ? 1 : (x == -1) ? -1 : 0;
        }
        if (n == Int32.MinValue)
        {
            return (x == 1 || x == -1) ? 1 : 0;
        }
        if (n > 0)
        {
            while (n > 1)
            {
                x *= constant;
                n--;
            }
            return x;
        }
        else
        {
            while (n < 1)
            {
                x /= constant;
                n++;
            }
            return x;
        }
    }
}
