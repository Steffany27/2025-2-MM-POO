public class INSS
{
    public double Calcular(double salario)
    {
        if (salario <= 1412.00)
            return salario * 0.075;
        else if (salario <= 2666.68)
            return salario * 0.09;
        else if (salario <= 4000.03)
            return salario * 0.12;
        else if (salario <= 7786.02)
            return salario * 0.14;

        return 7786.02 * 0.14;
    }
}
