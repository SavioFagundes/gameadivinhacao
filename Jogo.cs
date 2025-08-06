namespace JogoAdivinhacao
{
    class Jogo
    {

        private readonly Dictionary<string, int> _highScores;

        public Jogo()
        {
            _highScores = new Dictionary<string, int>
            {
                { "Facil", int.MaxValue },
                { "Medio", int.MaxValue },
                { "Dificil", int.MaxValue }
            };
        }

        public void Iniciar()
        {
            ConsoleUI.ExibirBoasVindas();
            bool jogarNovamente = true;

            while (jogarNovamente)
            {
                (int chances, string nomeDificuldade) = ConsoleUI.SelecionarDificuldade();
                if (chances == 0) continue;

                Rodada rodadaAtual = new Rodada(chances, nomeDificuldade);
                int tentativas = rodadaAtual.Jogar();

                if (tentativas < _highScores[nomeDificuldade])
                {
                    _highScores[nomeDificuldade] = tentativas;
                    ConsoleUI.ExibirNovoRecorde(nomeDificuldade);
                }

                ConsoleUI.ExibirPontuacao(_highScores[nomeDificuldade], nomeDificuldade);
                jogarNovamente = ConsoleUI.PerguntarJogarNovamente();
            }
            ConsoleUI.ExibirDespedida();
        }
    }
}