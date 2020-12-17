using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarisi
{
    public class at
    {
        public int StartingPosition=21, RacetrackLength=241, Location=21;
        public PictureBox MyPictureBox= null;
        public Random Randomizer;

        public bool Run()
        {
            Location = Randomizer.Next(1, 5);
            MyPictureBox.Left += Location;
            if (RacetrackLength <= MyPictureBox.Left)
                return true;
            else
                return false;
        }

        public void TakestartingPosition()
        {
            MyPictureBox.Left = StartingPosition;
        }
    }
}
