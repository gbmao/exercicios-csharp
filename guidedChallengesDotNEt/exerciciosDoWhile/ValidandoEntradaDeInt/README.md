# Validando entrada de INT
- Desafio do curso learn da microsoft para validar a entrada de int
#### Observações pessoais

Dificuldade em tentar entender o conceito de trocar uma string para int e validar

``` csharp
    bool intNumber = false; // gera um valor false para intNumber

    intNumber = int.TryParse(input, out number); // transforma number em int  
    
    if (intNumber == true) // se number virou int, intNumber se trasnforma em true
```



## REGRAS:
1. *A solução deve incluir uma iteração do-while ou while.*

2. Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.

*Dentro do bloco de iteração:*

3. A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
4. A solução deve garantir que a entrada seja uma representação válida de um inteiro.
5. Se o valor inteiro não estiver entre 5 e 10, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
6. A solução deve garantir que o valor inteiro esteja entre 5 e 10 antes de sair da iteração.
7. Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.

### Como abrir

1. navegue até a pasta do arquivo no bash
2. Digite :
```bash
code .



