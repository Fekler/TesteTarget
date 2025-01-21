//1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
//Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
//Imprimir(SOMA);
//Ao final do processamento, qual será o valor da variável SOMA?
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using System.Text.Json.Serialization;

int INDICE = 13, SOMA = 0, K = 0;

while (K < INDICE)
{
    K++;
    SOMA += K;
}

Console.WriteLine(SOMA);

// Soma = 91





//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

//IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

static bool IsFibonnaci(int number)
{
    if (number < 0) return false;

    int a = 0;
    int b = 1;

    while (a < number)
    {
        int temp = a;
        a = b;
        b = temp + b;
    }

    return a == number;
}
Console.WriteLine("Informe um numero para verificar se ele percetence a sequência Fibonnaci ");
string numberToTestIN = Console.ReadLine();
int numberToTest;
if (string.IsNullOrEmpty(numberToTestIN))
{
    Console.WriteLine(" Entrada nula");
    return;
}
if (!int.TryParse(numberToTestIN, out numberToTest))
{
    Console.WriteLine(" numero invalido");
    return;
}
var isFibonnaci = IsFibonnaci(numberToTest);
if (isFibonnaci)
{
    Console.WriteLine($"{numberToTest} pertence a sequência Fibonnaci");
}
else
{
    Console.WriteLine($"{numberToTest} não pertence a sequência  Fibonnaci");
}


//3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.


List<Faturamento> faturamentos = [];
string jsonString = File.ReadAllText("dados.json");
faturamentos = JsonSerializer.Deserialize<List<Faturamento>>(jsonString);
var menorFaturamento = faturamentos.OrderBy(f => f.Valor).First();
var maiorFaturamento = faturamentos.OrderByDescending(f => f.Valor).First();
var mediaMensal = faturamentos.Average(f => f.Valor);
var diasAcimaDaMedia = faturamentos.Count(f => f.Valor > mediaMensal);
Console.WriteLine($"O menor valor de faturamento ocorrido: {menorFaturamento.Valor} no dia {menorFaturamento.Dia}");
Console.WriteLine($"O maior valor de faturamento ocorrido: {maiorFaturamento.Valor} no dia {maiorFaturamento.Dia}");
Console.WriteLine($"A quantidade de dias acima da média foi: {diasAcimaDaMedia}");
public class Faturamento
{
    public int Dia { get; set; }
    public decimal Valor { get; set; }
}


