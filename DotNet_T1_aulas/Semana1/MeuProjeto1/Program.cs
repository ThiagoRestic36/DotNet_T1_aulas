/*
sbyte armazena valores de -128 a 127
byte armazena valores de 0 a 255
short armazena valores de -32768 a 32767
ushort armazena valores de 0 a 65535
int armazena valores de -2147483648 a 2147483647
uint armazena valores de 0 a 4294967295
long armazena valores de -9223372036854775808 a 9223372036854775807
ulong armazena valores de 0 a 18446744073709551615
*/
int tipoInteiro = int.MaxValue;
int tipoInteiro2 = int.MinValue;
sbyte ValorMi = sbyte.MinValue;
sbyte maxValue = sbyte.MaxValue;
byte maxbyte = byte.MaxValue;
byte minbyte = byte.MinValue;
short maxsh = short.MaxValue;
short minsh = short.MinValue;
ushort maxus = ushort.MaxValue;
ushort minus = ushort.MinValue;
uint maxui = uint.MaxValue;
uint minui = uint.MinValue;
long maxlo = long.MaxValue;
long minlo = long.MinValue;
ulong maxul = ulong.MaxValue;
ulong minul = ulong.MinValue;
//Exemplo
Console.WriteLine("Questão 02. Tipos de Dados");
Console.WriteLine("Maximo de tipo int: " + tipoInteiro);
Console.WriteLine("Minimo de tipo int: " + tipoInteiro2);
Console.WriteLine("O valor mínimo de sbyte é: " + ValorMi);
Console.WriteLine("O valor máximo de sbyte é: " + maxValue);
Console.WriteLine("O valor máximo de um byte é: " + maxbyte);
Console.WriteLine("O valor mínimo de um byte é: " + minbyte);
Console.WriteLine("O valor máximo de um short é: " + maxsh);
Console.WriteLine("O valor mínimo de um short é: " + minsh);
Console.WriteLine("O valor máximo de um ushort é: " + maxus);
Console.WriteLine("O valor mínimo de um ushort é: " + minus);
Console.WriteLine("O valor máximo de um uint é: " + maxui);
Console.WriteLine("O valor mínimo de um uint é: " + minui);
Console.WriteLine("O valor máximo de um long é: " + maxlo);
Console.WriteLine("O valor mínimo de um long é: " + minlo);
Console.WriteLine("O valor máximo de um ulong é: " + maxul);
Console.WriteLine("O valor mínimo de um ulong é: " + minul);
Console.WriteLine();


Console.WriteLine("Questão 03. Conversão de Tipos de Dados:");

double valorDouble = 9.54;
int valorInt = Convert.ToInt32(valorDouble);
Console.WriteLine(valorInt);

Console.WriteLine();
Console.WriteLine("Questão 04. Operadores Aritméticos:");
int x = 30;
int y = 3;

int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");

Console.WriteLine();
Console.WriteLine("Questão 05. Operadores de Comparação:");
int a = 5;
int b = 8;

if (a > b)
{
    Console.WriteLine("a é maior que b");
}
else
{
    Console.WriteLine("b é maior que a");
}
Console.WriteLine();
Console.WriteLine("Questão 06. Operadores de Igualdade:");
string str1 = "Hello";
string str2 = "World";

if (str1 == str2)
{
    Console.WriteLine("As strings são iguais");
}
else
{
    Console.WriteLine("As strings são diferentes");
}
Console.WriteLine();
Console.WriteLine("Questão 07. Operadores Lógicos:");
bool condicao1 = true;
bool condicao2 = false;

if (condicao1 && condicao2)
{
    Console.WriteLine("As duas condições são verdadeiras");
}
else
{
    Console.WriteLine("Pelo menos uma das condições é falsa");
}
Console.WriteLine();
Console.WriteLine("Questão 08. Desafio de Mistura de Operadores:");

int num1 = 7;
int num2 = 3;
int num3 = 10;

if (num1 > num2 && num3 == num1 + num2)
{
    Console.WriteLine("num1 é maior que num2 e num3 é igual a num1 + num2");
}
else
{
    Console.WriteLine("As condições não são satisfeitas");
}