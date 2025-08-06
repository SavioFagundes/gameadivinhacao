public static class ConsoleUI
    {
        public static void ExibirBoasVindas()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine(" Bem-vindo ao Jogo de Adivinhação (POO)!");
            Console.WriteLine("========================================");
        }

        public static (int, string) SelecionarDificuldade()
        {
            Console.WriteLine("\nSelecione o nível de dificuldade:");
            Console.WriteLine("1. Fácil (10 chances)");
            Console.WriteLine("2. Médio (7 chances)");
            Console.WriteLine("3. Difícil (5 chances)");
            Console.Write("Digite sua escolha (1-3): ");

            switch (Console.ReadLine())
            {
                case "1": return (10, "Fácil");
                case "2": return (7, "Médio");
                case "3": return (5, "Difícil");
                default:
                    ExibirMensagem("Escolha inválida. Tente novamente.", ConsoleColor.Red);
                    return (0, "Inválido");
            }
        }
        
        public static void ExibirInicioRodada(int chances, string dificuldade)
        {
            Console.WriteLine($"\nÓtimo! Você selecionou o nível {dificuldade} e tem {chances} chances.");
            Console.WriteLine("Estou pensando em um número entre 1 e 100.");
            Console.WriteLine("Você pode digitar 'dica' a qualquer momento para receber uma ajuda!");
            Console.WriteLine("Vamos começar! Boa sorte!");
            Console.WriteLine("----------------------------------------");
        }

        public static void ExibirStatusRodada(int chances)
        {
            Console.WriteLine($"\nVocê tem {chances} chance(s) restantes.");
        }

        public static string ObterPalpite()
        {
            Console.Write("Digite seu palpite: ");
            return Console.ReadLine() ?? "";
        }

        public static void ExibirDicaPalpite(string dica, int palpite)
        {
            Console.WriteLine($"Incorreto! O número secreto é {dica} que {palpite}.");
        }

        public static void ExibirResultadoVitoria(int numero, int tentativas, TimeSpan tempo)
        {
            Console.WriteLine("----------------------------------------");
            ExibirMensagem($"Parabéns! Você acertou o número {numero}!", ConsoleColor.Green);
            Console.WriteLine($"Você precisou de {tentativas} tentativa(s).");
            Console.WriteLine($"Tempo total: {tempo.Minutes:00}:{tempo.Seconds:00} minutos.");
        }

        public static void ExibirResultadoDerrota(int numero)
        {
            Console.WriteLine("----------------------------------------");
            ExibirMensagem("Fim de jogo! Você não conseguiu adivinhar o número.", ConsoleColor.Red);
            Console.WriteLine($"O número secreto era: {numero}");
        }
        
        public static void ExibirNovoRecorde(string dificuldade)
        {
            ExibirMensagem("🎉 Novo recorde para o nível " + dificuldade + "! 🎉", ConsoleColor.Yellow);
        }
        
        public static void ExibirPontuacao(int pontuacao, string dificuldade)
        {
            if (pontuacao == int.MaxValue)
            {
                 Console.WriteLine($"\nMelhor pontuação ({dificuldade}): Nenhuma ainda.");
            }
            else
            {
                 Console.WriteLine($"\nMelhor pontuação ({dificuldade}): {pontuacao} tentativas.");
            }
        }

        public static bool PerguntarJogarNovamente()
        {
            Console.Write("\nDeseja jogar novamente? (s/n): ");
            string resposta = Console.ReadLine()?.ToLower() ?? "n";
            Console.Clear();
            return resposta == "s";
        }

        public static void DarDica(int numero)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(numero % 2 == 0 ? "DICA: O número é par." : "DICA: O número é ímpar.");
            if (numero > 50) Console.WriteLine("DICA: O número é maior que 50.");
            else if (numero < 50) Console.WriteLine("DICA: O número é menor que 50.");
            else Console.WriteLine("DICA: O número é exatamente 50!");
            Console.ResetColor();
        }

        public static void ExibirMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public static void ExibirDespedida()
        {
            Console.WriteLine("Obrigado por jogar! Até a próxima.");
        }
    }