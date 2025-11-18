#Projeto: Cálculo de IRRF em C#

Este projeto implementa o cálculo completo do INSS, salário base e IRRF (Imposto de Renda Retido na Fonte) utilizando Programação Orientada a Objetos (POO) em C#.

O objetivo é aplicar as regras oficiais das tabelas de INSS e IRRF para determinar os descontos sobre o salário bruto do trabalhador.

 Lógica do cálculo
1️ Cálculo do INSS

O desconto do INSS é calculado conforme as faixas salariais:

Até 1.412,00 → 7,5%

De 1.412,01 até 2.666,68 → 9%

De 2.666,69 até 4.000,03 → 12%

De 4.000,04 até 7.786,02 → 14%

2️ Cálculo do salário base
salário base = salário bruto – desconto do INSS

3 Cálculo do IRRF

Após obter o salário base, aplica-se a tabela do IRRF:

Faixa (R$)	Alíquota	Dedução
Até 2.259,20	0%	0,00
2.259,21 – 2.826,65	7,5%	169,44
2.826,66 – 3.751,05	15%	381,44
3.751,06 – 4.664,68	22,5%	662,77
Acima de 4.664,68	27,5%	896,00

Fórmula:

IRRF = (salário base × alíquota) – dedução

Estrutura do projeto

O projeto foi desenvolvido utilizando classes separadas, conforme solicitado:

ProjetoIRRF/
│
├── INSS.cs             → Classe responsável pelo cálculo do INSS
├── IRRF.cs             → Classe responsável pelo cálculo do IRRF
├── FolhaPagamento.cs   → Classe que integra INSS + IRRF
└── Program.cs          → Ponto de entrada do programa (Main)

 Como executar o projeto
 Pelo Visual Studio ou Visual Studio Code

Abra a pasta do projeto.

Compile o programa.

Execute pressionando F5 ou clicando em Run.

 Pelo terminal

Na pasta do projeto:

dotnet run

 Exemplo de execução

Entrada:

Digite o salário bruto: 3000


Saída:

Desconto INSS: 258,83
Desconto IRRF: 36,14

 Autor

Steffany
Projeto da disciplina de Programação Orientada a Objetos.
