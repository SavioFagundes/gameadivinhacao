# 🎯 Jogo de Adivinhação (POO)

Um jogo interativo de adivinhação de números desenvolvido em C# usando conceitos de Programação Orientada a Objetos (POO).

## 📋 Descrição

O **Jogo de Adivinhação** é uma aplicação console onde o jogador deve descobrir um número secreto entre 1 e 100. O jogo oferece diferentes níveis de dificuldade, sistema de pontuação e recursos como dicas para ajudar o jogador.

## ✨ Funcionalidades

- **Três níveis de dificuldade:**
  - 🟢 **Fácil**: 10 chances
  - 🟡 **Médio**: 7 chances  
  - 🔴 **Difícil**: 5 chances

- **Sistema de pontuação:** Acompanha o melhor desempenho (menor número de tentativas) para cada nível
- **Sistema de dicas:** Digite "dica" para receber informações sobre o número secreto
- **Cronômetro:** Mede o tempo total de cada rodada
- **Detecção de recordes:** Notifica quando você estabelece um novo recorde
- **Interface amigável:** Mensagens coloridas e organizadas

## 🎮 Como Jogar

1. Execute o programa
2. Selecione o nível de dificuldade (1-3)
3. Digite seus palpites para descobrir o número secreto
4. Use dicas quando necessário digitando "dica"
5. Tente acertar o número com o menor número de tentativas possível!

### Exemplo de Gameplay

```
========================================
 Bem-vindo ao Jogo de Adivinhação (POO)!
========================================

Selecione o nível de dificuldade:
1. Fácil (10 chances)
2. Médio (7 chances)
3. Difícil (5 chances)
Digite sua escolha (1-3): 1

Ótimo! Você selecionou o nível Fácil e tem 10 chances.
Estou pensando em um número entre 1 e 100.
Você pode digitar 'dica' a qualquer momento para receber uma ajuda!
----------------------------------------

Você tem 10 chance(s) restantes.
Digite seu palpite: 50
Incorreto! O número secreto é MAIOR que 50.

Você tem 9 chance(s) restantes.
Digite seu palpite: dica
DICA: O número é par.
DICA: O número é maior que 50.
```

## 🏗️ Arquitetura do Projeto

O projeto segue princípios de POO com separação clara de responsabilidades:

### Classes Principais

- **`Program`**: Ponto de entrada da aplicação
- **`Jogo`**: Controla o fluxo principal do jogo e sistema de pontuação
- **`Rodada`**: Gerencia uma rodada individual do jogo
- **`ConsoleUI`**: Responsável por toda interface com o usuário

### Estrutura de Arquivos

```
JogoAdivinhacao/
├── Program.cs          # Ponto de entrada
├── Jogo.cs            # Classe principal do jogo
├── Rodada.cs          # Lógica de uma rodada
├── ConsoleUI.cs       # Interface do usuário
├── JogoAdivinhacao.csproj
├── JogoAdivinhacao.sln
├── .gitignore
└── README.md
```

## 🛠️ Tecnologias Utilizadas

- **C# 12.0**
- **.NET 9.0**
- **Console Application**

## 📦 Pré-requisitos

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) ou superior

## 🚀 Como Executar

### Opção 1: Via Visual Studio
1. Abra o arquivo `JogoAdivinhacao.sln`
2. Pressione `F5` ou clique em "Iniciar"

### Opção 2: Via Terminal/Command Prompt
1. Clone o repositório:
   ```bash
   git clone https://github.com/SavioFagundes/gameadivinhacao.git
   cd gameadivinhacao
   ```

2. Execute o projeto:
   ```bash
   dotnet run
   ```

### Opção 3: Compilar e Executar
1. Compile o projeto:
   ```bash
   dotnet build
   ```

2. Execute o arquivo gerado:
   ```bash
   dotnet bin/Debug/net9.0/JogoAdivinhacao.dll
   ```

## 🎯 Conceitos de POO Aplicados

- **Encapsulamento**: Propriedades privadas e métodos públicos bem definidos
- **Separação de Responsabilidades**: Cada classe tem um propósito específico
- **Abstração**: Interface limpa entre as classes
- **Reutilização**: Métodos estáticos para funcionalidades comuns

## 🏆 Sistema de Pontuação

- A pontuação é baseada no **menor número de tentativas** para acertar
- Cada nível de dificuldade mantém seu próprio recorde
- O sistema notifica quando um novo recorde é estabelecido
- Recordes são mantidos durante a sessão do jogo

## 🎨 Características da Interface

- **Cores contextuais**: Mensagens de sucesso, erro e informação em cores diferentes
- **Layout organizado**: Separadores visuais e formatação clara
- **Feedback imediato**: Respostas instantâneas para todas as ações do usuário
- **Navegação intuitiva**: Menus simples e diretos

## 📈 Possíveis Melhorias Futuras

- [ ] Salvar recordes em arquivo para persistência entre sessões
- [ ] Adicionar mais níveis de dificuldade
- [ ] Implementar sistema de usuários múltiplos
- [ ] Adicionar mais tipos de dicas
- [ ] Criar versão com interface gráfica
- [ ] Implementar multiplayer

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 👨‍💻 Autor

**Savio Fagundes**
- GitHub: [@SavioFagundes](https://github.com/SavioFagundes)

---

⭐ Se você gostou deste projeto, não esqueça de dar uma estrela!
