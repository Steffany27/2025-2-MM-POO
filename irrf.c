#include "irrf.h"

double calcularIrrf(double salarioBase) {

    double aliquota;
    double deducao;

    if (salarioBase <= 2259.20) {
        return 0.0;
    } else if (salarioBase <= 2826.65) {
        aliquota = 0.075;
        deducao = 169.44;
    } else if (salarioBase <= 3751.05) {
        aliquota = 0.15;
        deducao = 381.44;
    } else if (salarioBase <= 4664.68) {
        aliquota = 0.225;
        deducao = 662.77;
    } else {
        aliquota = 0.275;
        deducao = 896.00;
    }

    return salarioBase * aliquota - deducao;
}