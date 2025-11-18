#include "inss.h"

double calcularInss(double salarioBruto) {
    if (salarioBruto <= 3305.22) {
        return salarioBruto * 0.078;
    }
    return 258.83;
}