#include <stdio.h>
#include "inss.h"
#include "irrf.h"

int main() {

    double salarioBruto = 3000.00;

    double inss = calcularInss(salarioBruto);
    double salarioBase = salarioBruto - inss;
    double irrf = calcularIrrf(salarioBase);

    printf("Salário Bruto: %.2f\n", salarioBruto);
    printf("Desconto INSS: %.2f\n", inss);
    printf("Salário Base: %.2f\n", salarioBase);
    printf("IRRF: %.2f\n", irrf);

    return 0;
}