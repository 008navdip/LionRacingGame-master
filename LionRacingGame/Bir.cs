using System.Windows.Forms;

namespace LionRacingGame
{
    public class Bir : Punter
    {
        public Bir(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setPunterName()
        {
            Name = "Bir";
        }
    }
}
