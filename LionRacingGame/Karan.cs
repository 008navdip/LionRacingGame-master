using System.Windows.Forms;

namespace LionRacingGame
{
    public class Karan : Punter
    {
        public Karan(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setPunterName()
        {
            Name = "Karan";
        }
    }
}
