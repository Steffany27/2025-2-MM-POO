public class FolhaPagamento
{
    private INSS inss = new INSS();
    private IRRF irrf = new IRRF();

    public double SalarioBruto { get; set; }

    public FolhaPagamento(double salarioBruto)
    {
        SalarioBruto = salarioBruto;
    }

    public double CalcularINSS()
    {
        return inss.Calcular(SalarioBruto);
    }

    public double CalcularIRRF()
    {
        double descontoINSS = CalcularINSS();
        double salarioBase = SalarioBruto - descontoINSS;
        return irrf.Calcular(salarioBase);
    }
}
