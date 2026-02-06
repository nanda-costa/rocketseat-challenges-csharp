namespace Project_01;

public class Valores
{
    public double Soma(double n1 = 10.5, double n2 = 5.2)
    {
        return n1 + n2;
    }
    public double Subtracao(double n1 = 10.5, double n2 = 5.2)
    {
        return n1 - n2;
    }
    
    public double Multiplicacao(double n1 = 10.5, double n2 = 5.2)
    {
        return n1 * n2;
    }
    
    public double Divisao(double n1 = 10.5, double n2 = 5.2)
    {
        if (n2 == 0)
        {
            throw new DivideByZeroException();
        }
        return n1 / n2;
    }
    
    public double Media(double n1 = 10.5, double n2 = 5.2)
    {
        return (n1 + n2)/2;
    }
}