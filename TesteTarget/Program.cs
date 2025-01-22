using System.Text.Json;
using TesteTarget;

//1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } Imprimir(SOMA); Ao final do processamento, qual será o valor da variável SOMA?

Console.WriteLine("Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } Imprimir(SOMA); Ao final do processamento, qual será o valor da variável SOMA?");
int INDICE = 13, SOMA = 0, K = 0;

while (K < INDICE)
{
    K++;
    SOMA += K;
}

Console.WriteLine($"O Valor da soma após processamento é = {SOMA}");

Console.WriteLine("");





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
Console.Write("Informe um numero para verificar se ele pertence a sequência Fibonnaci: ");
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
    Console.WriteLine($"O número {numberToTest} pertence a sequência Fibonnaci");
}
else
{
    Console.WriteLine($"O número {numberToTest} não pertence a sequência Fibonnaci");
}

Console.WriteLine("");





//3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.


List<Faturamento> faturamentos = [];

string jsonString = File.ReadAllText("dados.json");
faturamentos = JsonSerializer.Deserialize<List<Faturamento>>(jsonString);


var ordenamentoDecrecenteFaturamento = faturamentos.OrderBy(f => f.Valor);
var menoresFaturamentosRepetidos = ordenamentoDecrecenteFaturamento.Where(f => f.Valor == ordenamentoDecrecenteFaturamento.First().Valor).ToList();
if (menoresFaturamentosRepetidos.Count > 1)
{
    List<int> dias = menoresFaturamentosRepetidos.Select(f => f.Dia).ToList();
    string messageDias = string.Join(", ", dias);
    Console.WriteLine($"Os dias {messageDias} apresentaram o faturamento = {menoresFaturamentosRepetidos.FirstOrDefault().Valor}");

}
else
{
    var menorFaturamento = menoresFaturamentosRepetidos.OrderBy(f => f.Dia).First();
    Console.WriteLine($"O menor valor de faturamento ocorrido: {menorFaturamento.Valor:C} no dia {menorFaturamento.Dia}");
}
var maioresFaturamentoOrdemCrescente = faturamentos.OrderByDescending(f => f.Valor);
var maioresFaturamentosRepetidos = ordenamentoDecrecenteFaturamento.Where(f => f.Valor == maioresFaturamentoOrdemCrescente.First().Valor).ToList();
if (maioresFaturamentosRepetidos.Count > 1)
{
    List<int> dias = maioresFaturamentosRepetidos.Select(f => f.Dia).ToList();
    string messageDias = string.Join(", ", dias);
    Console.WriteLine($"Os dias {messageDias} apresentaram o faturamento = {maioresFaturamentosRepetidos.FirstOrDefault().Valor}");
}
else
{
    var maiorFaturamento = maioresFaturamentoOrdemCrescente.First();
    Console.WriteLine($"O maior valor de faturamento ocorrido: {maiorFaturamento.Valor:C} no dia {maiorFaturamento.Dia}");
}
var mediaMensal = faturamentos.Average(f => f.Valor);
var diasAcimaDaMedia = faturamentos.Count(f => f.Valor > mediaMensal);
Console.WriteLine($"A quantidade de dias acima da média foi: {diasAcimaDaMedia}");

Console.WriteLine("");


//Questão 4
decimal sp = 67836.43m;
decimal rj = 36678.66m;
decimal mg = 29229.88m;
decimal es = 27165.48m;
decimal outros = 19849.53m;
decimal total = sp + rj + mg + es + outros;

decimal percentualSp = (sp / total);
decimal percentualRj = (rj / total);
decimal percentualMg = (mg / total);
decimal percentualEs = (es / total);
decimal percentualOutros = (outros / total);

Console.WriteLine($"Faturamento total: R$" + total);
Console.WriteLine($"Percentual SP:  {percentualSp:P}");
Console.WriteLine($"Percentual RJ:  {percentualRj:P}");
Console.WriteLine($"Percentual MG:  {percentualMg:P}");
Console.WriteLine($"Percentual ES:  {percentualEs:P}");
Console.WriteLine($"Percentual dos demais estados:  {percentualOutros:P}");

Console.WriteLine("");





//Questão 5
Console.Write("Favor informar uma palavra para ser escrita ao contrario: ");

var stringEntry = Console.ReadLine();
if (string.IsNullOrEmpty(stringEntry))
{
    Console.WriteLine("Entrada nula");
    return;
}
List<char> splittedStringEntry = stringEntry.ToCharArray().ToList();
string reversedString = string.Empty;
for (int i = splittedStringEntry.Count; i > 0; i--)
{
    reversedString += splittedStringEntry[i - 1];
}
Console.WriteLine($"A palavra invertida é: {reversedString}, Palavra Original: {stringEntry}");


