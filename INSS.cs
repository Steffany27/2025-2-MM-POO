public class INSS
{
    public double Calcular(double salario)
    {
        double inss = 0.0;

        // Faixas do INSS
        double[] limites = { 1412.00, 2666.68, 4000.03, 7786.02 };
        double[] aliquotas = { 0.075, 0.09, 0.12, 0.14 };

        double restante = salario;

        for (int i = 0; i < limites.Length; i++)
        {
            double faixa = 0;

            if (i == 0)
                faixa = Math.Min(restante, limites[i]);
            else
                faixa = Math.Min(restante, limites[i] - limites[i - 1]);

            inss += faixa * aliquotas[i];
            restante -= faixa;

            if (restante <= 0)
                break;
        }

       
        if (salario > limites[limites.Length - 1])
        {
            inss = 0;
            double[] teto = { 1412.00, 1254.68, 1333.35, 3786.00 }; // valores aproximados por faixa
            double[] aliquotasTeto = { 0.075, 0.09, 0.12, 0.14 };
            for (int i = 0; i < teto.Length; i++)
                inss += teto[i] * aliquotasTeto[i];
        }

        return Math.Round(inss, 2); // arredonda para 2 casas decimais
    }
}
