# CalculadoraWinFormsApp

# Integrantes
Nome: Gustavo Dantas
RM: 560685

## Sobre o projeto
Essa é uma calculadora simples desenvolvida em **C#** usando **Windows Forms**.  
Ela faz operações básicas como adição, subtração, multiplicação e divisão, e também tem funções extras como raiz quadrada e potenciação.  

O layout é simples, com todos os botões bem posicionados e um visor para mostrar os números e resultados.

## Funcionalidades
- Operações básicas: `+`, `-`, `*`, `/`  
- Potenciação: `x^y`  
- Raiz quadrada: `√`  
- Uso de vírgula como separador decimal  
- Limpar o visor com o botão `C`  
- Mostrar o resultado com `=`  
- Prevenção de divisão por zero  

## Como usar
1. Abra o projeto no **Visual Studio**.  
2. Certifique-se de que é um **Windows Forms App** compatível com sua versão do .NET.  
3. Compile o projeto (`Ctrl+Shift+B`).  
4. Rode o projeto (`F5`) e a calculadora vai abrir.  

## Estrutura do projeto
- **Form1.cs** – Contém toda a lógica da calculadora.  
- **Form1.Designer.cs** – Define os botões e o layout do formulário.  
- **Program.cs** – Ponto de entrada da aplicação.  

## Observações
- O layout do formulário é fixo, então a calculadora não se adapta a diferentes tamanhos de janela.  
- Para adicionar novos botões ou funções, é só usar o **Designer do Visual Studio** e vincular os eventos nos métodos existentes.
