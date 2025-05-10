teste# Projeto de Código 2 – Validação de Entrada de Cadeia de Caracteres

## Descrição

Este projeto em C# implementa uma validação de entrada onde o usuário deve digitar corretamente uma das funções permitidas: `Administrador`, `Gerente` ou `Usuário`. A entrada é verificada em um loop `do-while` até que um valor válido seja fornecido.

---

## Requisitos

- Solicitar ao usuário que digite um nome de função: `Administrador`, `Gerente` ou `Usuário`.
- Usar um loop `do-while` (ou `while`) para repetir a solicitação até que a entrada seja válida.
- Dentro do loop:
  - Usar `Console.ReadLine()` para capturar a entrada.
  - Usar `.Trim()` para remover espaços em branco desnecessários.
  - Usar `.ToLower()` para ignorar diferenciação de maiúsculas e minúsculas.
  - Verificar se a entrada corresponde a uma das funções permitidas.
  - Se não corresponder, exibir uma mensagem de erro com `Console.WriteLine()`.
- Após a entrada ser aceita, exibir uma mensagem de confirmação.

---

## Como abrir
1. navegue até a pasta 
2. Execute o comando :

´´´ bash
code .


