using System.Diagnostics;
using JogoAdivinhacao;

public class Rodada
    {
        private readonly int _numeroSecreto;
        private int _chances;
        private readonly string _dificuldade;
        private bool _acertou;

        public Rodada(int chances, string dificuldade)
        {
            _chances = chances;
            _dificuldade = dificuldade;
            _acertou = false;
            Random random = new Random();
            _numeroSecreto = random.Next(1, 101);
        }

        /// <summary>
        /// Executa o loop principal da rodada de adivinhação.
        /// </summary>
        /// <returns>O número de tentativas se o jogador vencer; 0 se perder.</returns>
        public int Jogar()
        {
            ConsoleUI.ExibirInicioRodada(_chances, _dificuldade);
            Stopwatch cronometro = Stopwatch.StartNew();
            int tentativas = 0;

            while (_chances > 0 && !_acertou)
            {
                ConsoleUI.ExibirStatusRodada(_chances);
                string input = ConsoleUI.ObterPalpite();

                if (input.ToLower() == "dica")
                {
                    ConsoleUI.DarDica(_numeroSecreto);
                    continue;
                }

                if (!int.TryParse(input, out int palpite))
                {
                    ConsoleUI.ExibirMensagem("Entrada inválida. Por favor, digite um número.", ConsoleColor.Yellow);
                    continue;
                }

                tentativas++;
                VerificarPalpite(palpite);
            }

            cronometro.Stop();
            
            if (_acertou)
            {
                ConsoleUI.ExibirResultadoVitoria(_numeroSecreto, tentativas, cronometro.Elapsed);
                return tentativas;
            }
            else
            {
                ConsoleUI.ExibirResultadoDerrota(_numeroSecreto);
                return 0; // Retorna 0 para indicar que o jogador perdeu.
            }
        }

        private void VerificarPalpite(int palpite)
        {
            if (palpite == _numeroSecreto)
            {
                _acertou = true;
            }
            else if (palpite < _numeroSecreto)
            {
                ConsoleUI.ExibirDicaPalpite("MAIOR", palpite);
                _chances--;
            }
            else // palpite > _numeroSecreto
            {
                ConsoleUI.ExibirDicaPalpite("MENOR", palpite);
                _chances--;
            }
        }
    }
