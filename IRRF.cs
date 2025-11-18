public class IRRF
{
    public double Calcular(double salarioBase)
    {
        double aliquota = 0, deducao = 0;

        if (salarioBase <= 2259.20)
        {
            aliquota = 0;
            deducao = 0;
        }
        else if (salarioBase <= 2826.65)
        {
            aliquota = 0.075;
            deducao = 169.44;
        }
        else if (salarioBase <= 3751.05)
        {
            aliquota = 0.15;
            deducao = 381.44;
        }
        else if (salarioBase <= 4664.68)
        {
            aliquota = 0.225;
            deducao = 662.77;
        }
        else:
            aliquota = 0.275;
            deducao = 896.00;

        return salarioBase * aliquota - deducao;
    }
}
