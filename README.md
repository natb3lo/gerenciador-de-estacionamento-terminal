# Mini Sistema de Estacionamento em Linha de Comando

Projeto em C# usando .NET 9 para gerenciar veículos em um estacionamento via terminal.

---

## 🛠 Tecnologias
- C# 12 / .NET 9
- Aplicação em Console

---

## 🚀 Funcionalidades
1. **Cadastrar Veículo**  
   - Permite registrar um veículo no estacionamento.
   - Valida a placa (antigo e Mercosul) antes de adicionar.

2. **Remover Veículo**  
   - Remove um veículo cadastrado do estacionamento.
   - Calcula o valor total baseado no tempo estacionado (Preço Inicial + Preço por Hora).

3. **Listar Veículos**  
   - Exibe todos os veículos atualmente cadastrados no estacionamento.

---

## 📦 Como usar

1. Clone o repositório:
   ```bash
   git clone https://github.com/natb3lo/gerenciador-de-estacionamento-terminal.git

2. Entre no Diretório do Projeto:
   ```bash
   cd gerenciador-de-estacionamento-terminal

3. Certifique-se de que o .NET 9 (ou superior) está instalado na sua máquina:
   ```bash
   dotnet --version

4. Compile e Execute o projeto:
   ```bash
   dotnet run
