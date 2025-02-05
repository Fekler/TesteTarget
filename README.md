# Soluções para Problemas em C#

## Visão Geral
Este projeto contém soluções implementadas em C# para uma série de problemas envolvendo lógica de programação e manipulação de dados. As questões abordadas incluem cálculos matemáticos, análise de dados financeiros, manipulação de strings e mais. Cada problema está identificado com comentários no código para facilitar a compreensão.

---

## Requisitos
- .NET SDK 9.0 

---

## Estrutura do Código

1. **Cálculo de Soma em Laço**
   - Calcula o valor acumulado de uma soma em laço iterativo.
   - Exemplo: Soma incremental de 1 a 13.

2. **Validação na Sequência de Fibonacci**
   - Verifica se um número fornecido pertence à sequência de Fibonacci.
   - **Entrada**: Número fornecido via console.
   - **Saída**: Confirmação se pertence ou não.

3. **Análise de Faturamento Diário**
   - Lê dados de faturamento de um arquivo JSON incluído no repositório (`dados.json`).
   - Identifica o menor e o maior faturamento.
   - Calcula a média e o número de dias acima da média.

4. **Percentual de Faturamento por Estado**
   - Analisa percentuais de participação no faturamento total por estado.

5. **Inversão de String**
   - Recebe uma palavra e a inverte.

---

## Configuração e Uso

1. **Clonar o Repositório**
   ```
   git clone https://github.com/Fekler/TesteTarget.git
   cd pasta-do-projeto
   Executar o Projeto
   ```

2. **Navegue até o diretório do projeto.**
Compile e execute:
  ```
  dotnet run
  ```
3. **Interagir com o Programa.**

  - Responda às solicitações do console, como:
  - Inserir números para verificação de Fibonacci.
  - Inserir palavras para inversão.
---

## Funcionalidades e Exemplos
**Cálculo de Soma em Laço**
   - Exemplo de saída:
     ```
     Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } Imprimir(SOMA); Ao final do processamento, qual será o valor da variável SOMA? O Valor da soma após processamento é = 91
     ```
**Validação na Sequência de Fibonacci**
   - Entrada: Informe um numero para verificar se ele pertence a sequência Fibonnaci: 5.
   - Saída: O número 5 pertence a sequência Fibonnaci.
     
  **Análise de Faturamento Diário:**
  - Exemplo de saída:
```
    Os dias 4, 5, 7, 11, 12, 18, 19, 25, 26 apresentaram o faturamento = 0,0
    O maior valor de faturamento ocorrido: R$ 48.924,24 no dia 16
    A quantidade de dias acima da média foi: 12
```

**Percentuais de Faturamento:**
  - Exemplo de saída:
  ```
      Faturamento total: R$180759,98
      Percentual SP:  37,53%
      Percentual RJ:  20,29%
      Percentual MG:  16,17%
      Percentual ES:  15,03%
      Percentual dos demais estados:  10,98%
  ```
**Inversão de String:**
  - Entrada: Programador
  - Saída: rodamargorP
