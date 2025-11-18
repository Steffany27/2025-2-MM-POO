Este projeto realiza o cálculo completo de **INSS**, **salário base** e **IRRF (Imposto de Renda Retido na Fonte)**.

---

##  Como funciona o cálculo

### 1️ Cálculo do INSS  
O INSS é calculado de acordo com as faixas salariais definidas pela legislação.

### 2️ Cálculo do salário base  
salário base = salário bruto – desconto do INSS


### 3️ Cálculo do IRRF  
Localiza a faixa do salário base na tabela do IRRF, aplica a alíquota e subtrai a dedução:

IRRF = (salário base × alíquota) – dedução

---

##  Como compilar

Use o GCC:

gcc main.c inss.c irrf.c -o calculo

---

##  Como executar

./calculo


---

##  Arquivos do projeto

| Arquivo             | Função                                           |
|---------------------|---------------------------------------------------|
| **main.c**          | Entrada do programa e fluxo de cálculo            |
| **inss.c / inss.h** | Funções relacionadas ao cálculo do INSS           |
| **irrf.c / irrf.h** | Funções relacionadas ao cálculo do IRRF           |
| **README.md**       | Documentação do projeto                           |

---

## 👩‍💻 Autor

**Steffany**  
Projeto da disciplina de Programação Orientada a Objetos.
