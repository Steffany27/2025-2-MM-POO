using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o salário bruto: ");
        double salarioBruto = double.Parse(Console.ReadLine());

        FolhaPagamento folha = new FolhaPagamento(salarioBruto);

        double inss = folha.CalcularINSS();
        double salarioBase = salarioBruto - inss;
        double irrf = folha.CalcularIRRF();

        Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
        Console.WriteLine($"Desconto INSS: R$ {inss:F2}");
        Console.WriteLine($"Salário base: R$ {salarioBase:F2}");
        Console.WriteLine($"Desconto IRRF: R$ {irrf:F2}");
    }
}
