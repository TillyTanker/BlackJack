using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        
        string[] cardPath = Directory.GetFiles(@"..\..\.\Cards\Cards\", "*.png");
        int[] cardValues = {10, 10, 10, 10,
            2, 2, 2, 2,
            3, 3, 3, 3,
            4, 4, 4, 4,
            5, 5, 5, 5,
            6, 6, 6, 6,
            7, 7, 7, 7,
            8, 8, 8, 8,
            9, 9, 9, 9,
            0, 0, 0, 0, // 36-39
            10, 10, 10, 10,
            10, 10, 10, 10,
            10, 10, 10, 10};
        List<PictureBox> cardPlaced = new List<PictureBox>();
        int card1, card2, card3, card4, stack = 100, playerScore = 0, dealerScore = 0;
        int posX = 66, posY = 206, hit = 0;
        bool play = false;

        const string dir = @"..\..\.\Cards\Cards\";
        Random random = new Random();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HitBtn.Enabled = false;
            StandBtn.Enabled = false;
            PlayBtn.Enabled = true;
            numericUpDownBet.Enabled = true;

            DhiddenCard.Image = Image.FromFile(dir + "red_back.png");
            DhiddenCard.SizeMode = PictureBoxSizeMode.Zoom;
            DshowCard.Image = Image.FromFile(dir + "red_back.png");
            DshowCard.SizeMode = PictureBoxSizeMode.Zoom;

            Card1.Image = Image.FromFile(dir + "red_back.png");
            Card1.SizeMode = PictureBoxSizeMode.Zoom;
            Card2.Image = Image.FromFile(dir + "red_back.png");
            Card2.SizeMode = PictureBoxSizeMode.Zoom;


            List<string> images = cardPath.ToList();

        }

        private void Dcard2_Click(object sender, EventArgs e)
        {

        }

        private void Card1_Click(object sender, EventArgs e)
        {

        }

        private void Card2_Click(object sender, EventArgs e)
        {

        }

        private void DhiddenCard_Click(object sender, EventArgs e)
        {
            
        }
        private void DshowCard_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownBet_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownBet.Maximum = stack;
        }

        private void StandBtn_Click(object sender, EventArgs e)
        {

        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            play = true;
            PlayBtn.Enabled = false;
            HitBtn.Enabled = true;
            StandBtn.Enabled = true;
            numericUpDownBet.Enabled = false;

            card1 = random.Next(0, 51); card2 = random.Next(0, 51);
            card3 = random.Next(0, 51); card4 = random.Next(0, 51);


            while ((card1 == card2) || (card1 == card3) || (card1 == card4)
                  || (card2 == card3) || (card2 == card4) || (card4 == card3))
            {
                if ((card1 == card2) || (card1 == card3) || (card1 == card4))
                {
                    card1 = random.Next(0, 51);
                    cardPlaced.Add(card1);
                }
                else if ((card2 == card3) || (card2 == card4))
                {
                    card2 = random.Next(0, 51);
                    cardPlaced.Add(card2);
                }
                else if (card4 == card3)
                {
                    card3 = random.Next(0, 51);
                    cardPlaced.Add(card3);
                }
            }

            DshowCard.ImageLocation = cardPath[card1];
            DshowCard.SizeMode = PictureBoxSizeMode.Zoom;
            Dcard2.ImageLocation = cardPath[card2];
            Dcard2.SizeMode = PictureBoxSizeMode.Zoom;

            Card1.ImageLocation = cardPath[card3];
            Card1.SizeMode = PictureBoxSizeMode.Zoom;
            Card2.ImageLocation = cardPath[card4];
            Card2.SizeMode = PictureBoxSizeMode.Zoom;

            playerScore += cardValues[card3];
            playerScore += cardValues[card4];

            labelPlayerScore.Text = playerScore.ToString();



        }

        private void getPlayerScore() {

            if (cardValues[card3] == 0)
            {
                int calc = playerScore;
                if(playerScore + 11 > 21)
                {

                }

            }


            playerScore += cardValues[card3];
            playerScore += cardValues[card4];

            labelPlayerScore.Text = playerScore.ToString();

        }



        private void HitBtn_Click(object sender, EventArgs e)
        {
            int nextCard = random.Next(0, 51);

            PictureBox newCard = new PictureBox();
            Point placement = new Point(posX, posY);

            /*
            do
            {
                for(int i = 0; i < cardPlaced.Count; i++)
                {
                    if(nextCard == cardPlaced[i])
                    {

                    }
                }
            } while (true);
            */

            if (play == true)
            {
                newCard.ImageLocation = cardPath[nextCard];
                newCard.SizeMode = PictureBoxSizeMode.Zoom;
                newCard.Width = Card1.Width; // width of initial card on form
                newCard.Height = Card1.Height; // height of initial card on form
                newCard.Location = placement;
                this.Controls.Add(newCard);
                
                switch (hit)
                {
                    case 0:
                        posX += 20;
                        hit++;
                        break;
                    case 1:
                        posX -= 20;
                        //posY -= 40;
                        hit = 0;
                        break;
                }
                cardPlaced.Add(newCard);
            }
        }
    }
    
}
