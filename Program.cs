using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o salário bruto: ");
        double salarioBruto = double.Parse(Console.ReadLine());

        FolhaPagamento folha = new FolhaPagamento(salarioBruto);

        double inss = folha.CalcularINSS();
        double irrf = folha.CalcularIRRF();

        Console.WriteLine($"
Desconto INSS: {inss:F2}");
        Console.WriteLine($"Desconto IRRF: {irrf:F2}");
    }
}
