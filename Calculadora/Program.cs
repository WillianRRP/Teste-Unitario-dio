using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 1;
int num2 = 65;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");