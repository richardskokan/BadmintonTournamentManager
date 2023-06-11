using BadmintonTournamentManager.Model.Helpers;
using BadmintonTournamentManager.Model.Exceptions;

namespace BadmintonTournamentManager.Model.Objects
{
    public class Game
    {
        public int ScorePlayer1 { get; set; }
        public int ScorePlayer2 { get; set; }

        public Game() { }

        public Game(int player1Score, int player2Score)
        {
            if (player1Score < 0 || player1Score > 30)
                throw new AppInvalidDataException("Score of Player 1 out of range");
            if (player2Score < 0 || player2Score > 30)
                throw new AppInvalidDataException("Score of Player 2 out of range");

            ScorePlayer1 = player1Score;
            ScorePlayer2 = player2Score;

            if (GetWinner() == GameWinnerEnum.UNDETERMINED)
                throw new AppInvalidDataException("The game needs to be finished");
        }

        public GameWinnerEnum GetWinner()
        {
            if (ScorePlayer1 < 21 && ScorePlayer2 < 21)
                return GameWinnerEnum.UNDETERMINED;
            
            if (ScorePlayer1 >= 20 && ScorePlayer1 <= 29
                && ScorePlayer2 >= 20 && ScorePlayer2 <= 29)
            {
                if (Math.Abs(ScorePlayer1 - ScorePlayer2) < 2)
                    return GameWinnerEnum.UNDETERMINED;
            }

            return ScorePlayer1 > ScorePlayer2 ? GameWinnerEnum.PLAYER_ONE : GameWinnerEnum.PLAYER_TWO;
        }

        public string GetScoreString()
        {
            return ScorePlayer1 + ":" + ScorePlayer2;
        }
    }
}
