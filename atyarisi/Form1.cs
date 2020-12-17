using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarisi
{
    public partial class Form1 : Form
    {
        at at1 = new at();
        at at2 = new at();
        at at3 = new at();
        at at4 = new at();
       
        adam Joe = new adam();
        adam Bob = new adam();
        adam Al = new adam();
        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
            at1 = new at()
            {

                MyPictureBox = horse1,
                Randomizer = random
            };
            at2 = new at()
            {
                MyPictureBox = horse2,
                Randomizer = random
            };
            at3 = new at()
            {
                MyPictureBox = horse3,
                Randomizer = random
            };
            at4 = new at()
            {
                MyPictureBox = horse4,
                Randomizer = random
            };
            

            Joe = new adam()
            {
                Name = "Joe",
                Cash = 50,
                MyRadioButton = joebttn,
                MyLabel = label2
            };
            Bob = new adam()
            {
                Name = "Bob",
                Cash = 75,
                MyRadioButton = bobbttn,
                MyLabel = label3
            };
            Al = new adam()
            {
                Name = "Al",
                Cash = 45,
                MyRadioButton = alBttn,
                MyLabel = label4
            };
            
            yenile();
            

        }

        public void yenile()
        {
            Joe.PlaceBet(0, 0);
            Bob.PlaceBet(0, 0);
            Al.PlaceBet(0, 0);

         

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Racebttn_Click(object sender, EventArgs e)
        {
          
            at1.TakestartingPosition();
            at2.TakestartingPosition();
            at3.TakestartingPosition();
            at4.TakestartingPosition();
            timer1.Start();
            groupBox1.Enabled = false;

        }

        private void joebttn_CheckedChanged(object sender, EventArgs e)
        {
            bettorLbl.Text="Joe";
        }

        private void bobbttn_CheckedChanged(object sender, EventArgs e)
        {
            bettorLbl.Text = "Bob";
        }

        private void alBttn_CheckedChanged(object sender, EventArgs e)
        {
            bettorLbl.Text = "Al";
        }

        private void betsBttn_Click(object sender, EventArgs e)
        {
            if (joebttn.Checked)
                Joe.PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            if (bobbttn.Checked)
                Bob.PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            if (alBttn.Checked)
                Al.PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int winner = 0;
            if (at1.Run() == true)
            {
                timer1.Stop();
                winner = 1;
                Joe.Collect(winner);
                Bob.Collect(winner);
                Al.Collect(winner);
                MessageBox.Show("The horse number " + 1 + "won the race");
                yenile();
                groupBox1.Enabled = true;

            }
            if (at2.Run() == true)
            {
                timer1.Stop();
                winner = 2;
                Joe.Collect(winner);
                Bob.Collect(winner);
                Al.Collect(winner);
                MessageBox.Show("The horse number " + 2 + "won the race");
                yenile();
                groupBox1.Enabled = true;

            }
            if (at3.Run() == true)
            {
                timer1.Stop();
                winner = 3;
                Joe.Collect(winner);
                Bob.Collect(winner);
                Al.Collect(winner);

                MessageBox.Show("The horse number " + 3 + "won the race");
                yenile();
                groupBox1.Enabled = true;
            }
            if (at4.Run() == true)
            {
                timer1.Stop();
                winner = 4;
                Joe.Collect(winner);
                Bob.Collect(winner);
                Al.Collect(winner);
                MessageBox.Show("The horse number " + 4 + "won the race");
                yenile();
                groupBox1.Enabled = true;

            }
           


        }
    }
}
