using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atyarisi
{
    public class bahis
    {
        public int Amount=0, At;
        public adam Bettor;

        public string GetDescription()
        {
            if (Amount == 0)
                return Bettor.Name + " hasn't placed a bet.";
            else
                return Bettor.Name + "bets" + Amount + "on horse #" + At;
        }

        public int PayOut(int winner)
        {
            if (At == winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
