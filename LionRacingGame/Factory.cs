﻿using System;
using System.Windows.Forms;

namespace LionRacingGame
{
    public class Factory
    {
        public Punter getPunter(String Name, Label MaximumBet, Label bet)
        {
            Punter p;
            switch (Name.ToLower())
            {
                case "jasmeet":
                    p = new Jasmeet(null, MaximumBet, 50, bet);
                    break;

                case "bir":
                    p = new Bir(null, MaximumBet, 50, bet);
                    break;

                case "karan":
                    p = new Karan(null, MaximumBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            p.setPunterName();
            return p;
        }
    }
}
