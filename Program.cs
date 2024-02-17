using ProjetoCalculadora.Models;

Calculadora calculadora = new Calculadora();
int num1 = 5;
int num2 = 2;

Console.WriteLine($"Soma de {num1} e {num2} é = {calculadora.Somar(num1, num2)}\n");

Console.WriteLine($"Subtração de {num1} - {num2} = {calculadora.Substrair(num1, num2)}\n");

Console.WriteLine($"Multiplicação de {num1} * {num2} = {calculadora.Multiplicar(num1, num2)}\n");

Console.WriteLine($"Divisão de {num1} / {num2} = {calculadora.Multiplicar(num1, num2)}\n");

double num = 100;
Console.WriteLine($"A raiz quadrada de {num} = {calculadora.RaizQuadrada(num)}\n");

double baseNum = 2;
double expoente = 3;
Console.WriteLine($"{baseNum} elevado a {expoente} = {calculadora.Potencia(baseNum, expoente)}\n");