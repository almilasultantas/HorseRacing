using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarisi
{
    public class adam
    {
        public string Name;
        public bahis MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + "has" + Cash + "bucks.";
           
        }

        
        public bool PlaceBet(int Amount,int At)
        {
            if (Amount <= Cash)
            {
                MyBet = new bahis() { Amount = Amount, At = At, Bettor = this };
                UpdateLabels();
                return true;
                
            }
            else
                return false;


        }

        public void Collect (int winner)
        {
            Cash += MyBet.PayOut(winner);
            UpdateLabels();
        }
    }
}
