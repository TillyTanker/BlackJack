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
            11, 11, 11, 11, // 36-39
            10, 10, 10, 10,
            10, 10, 10, 10,
            10, 10, 10, 10};
        List<Int32> cardPlaced = new List<Int32>();
        List<PictureBox> onBoard = new List<PictureBox>();
        
        int card1, card2, card3, card4, stack = 100, playerScore = 0, dealerScore = 0, bet = 0;
        int posX = 66, posY = 275, hit = 0, dPosX = 66, dPosY = 136;
        bool play = false, bust = false;

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
            labelPlayerScore.Hide();
            labelDealerScore.Hide();

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

        private void labelBet_Click(object sender, EventArgs e)
        {

        }

        private void labelPlayerScore_Click(object sender, EventArgs e)
        {

        }

        private void labelStack_Click(object sender, EventArgs e)
        {

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
            bet = Convert.ToInt32(numericUpDownBet.Value);
        }

        private async void StandBtn_Click(object sender, EventArgs e)
        {
            HitBtn.Enabled = false;
            StandBtn.Enabled = false;
            Dcard2.Show();
            labelDealerScore.Show();
            dealerScore += cardValues[card1] + cardValues[card2];
            labelDealerScore.Text = dealerScore.ToString();
            if (bust)
            {
                await Task.Delay(2000);
                MessageBox.Show("You Lost!");
                stack -= bet;
                labelStack.Text = "Stack: $" + stack;
                PlayBtn.Enabled = true;
                if (stack <= 0)
                {
                    MessageBox.Show("You are out of money, good bye!");
                    Environment.Exit(0);
                }
            }
            else
            {
                while (dealerScore < 17)
                {
                    await Task.Delay(2000);
                    dealerDraw();
                }
                await Task.Delay(2000);
                if (dealerScore == playerScore)
                {
                    MessageBox.Show("Tie!");
                }
                else if (dealerScore > playerScore && dealerScore <= 21)
                {
                    MessageBox.Show("You Lost!");
                    stack -= bet;
                    labelStack.Text = "Stack: $" + stack;
                    if(stack == 0)
                    {
                        MessageBox.Show("You are out of money, good bye!");
                        Environment.Exit(0); 
                    }
                }
                else
                {
                    MessageBox.Show("You Won!");
                    stack += bet;
                    labelStack.Text = "Stack: $" + stack;
                }

            }
            PlayBtn.Enabled = true;
            numericUpDownBet.Enabled = true;
        }

        private void dealerDraw()
        {
            int nextCard = random.Next(0, 51);

            PictureBox newCard = new PictureBox();
            Point placement = new Point(dPosX, dPosY);

            // makes sure there are no duplicate cards
            do
            {
                for (int i = 0; i < cardPlaced.Count; i++)
                {
                    if (nextCard == cardPlaced[i])
                    {
                        nextCard = random.Next(0, 51);
                        i = 0;
                    }
                }
                break;
            } while (true);

                newCard.ImageLocation = cardPath[nextCard];
                newCard.SizeMode = PictureBoxSizeMode.Zoom;
                newCard.Width = Card1.Width; // width of initial card on form
                newCard.Height = Card1.Height; // height of initial card on form
                newCard.Location = placement;

                this.Controls.Add(newCard);
                newCard.BringToFront();
                dPosX += 20;

                cardPlaced.Add(nextCard);
                onBoard.Add(newCard);
                dealerScore += cardValues[nextCard];
                labelDealerScore.Text = dealerScore.ToString();

        }


        private void startEvents()
        {
            play = true;
            bust = false;
            HitBtn.Enabled = true;
            StandBtn.Enabled = true;
            PlayBtn.Enabled = false;
            numericUpDownBet.Enabled = false;
            playerScore = 0;
            dealerScore = 0;
            labelPlayerScore.Show();
            labelDealerScore.Hide();
            for (int i = 0; i < onBoard.Count; i++)
            {
                onBoard[i].Dispose();
            }
            cardPlaced.Clear();
            onBoard.Clear();
            posX = 66;
            dPosX = 66;
            Dcard2.Hide();
            if(bet > stack)
            {
                bet = stack;
                numericUpDownBet.Value = bet;
            }
        }


        private void PlayBtn_Click(object sender, EventArgs e)
        {
            // events once play begins
            startEvents();

            // gets random card
            card1 = random.Next(0, 51); card2 = random.Next(0, 51);
            card3 = random.Next(0, 51); card4 = random.Next(0, 51);
            // verifies card is not already on board
            do
            {
                for (int i = 0; i < cardPlaced.Count; i++)
                {
                    if (card1 == cardPlaced[i])
                    {
                        card1 = random.Next(0, 51);
                        i = 0;
                    }
                    if (card2 == cardPlaced[i])
                    {
                        card2 = random.Next(0, 51);
                        i = 0;
                    }
                    if (card3 == cardPlaced[i])
                    {
                        card3 = random.Next(0, 51);
                        i = 0;
                    }
                    if (card4 == cardPlaced[i])
                    {
                        card4 = random.Next(0, 51);
                        i = 0;
                    }
                }
                break;
            } while (true);
            // adds cards to list
            cardPlaced.Add(card1); cardPlaced.Add(card2);
            cardPlaced.Add(card3); cardPlaced.Add(card4);
            // dealer cards
            DshowCard.ImageLocation = cardPath[card1];
            DshowCard.SizeMode = PictureBoxSizeMode.Zoom;
            Dcard2.ImageLocation = cardPath[card2];
            Dcard2.SizeMode = PictureBoxSizeMode.Zoom;
            // player cards
            Card1.ImageLocation = cardPath[card3];
            Card1.SizeMode = PictureBoxSizeMode.Zoom;
            Card2.ImageLocation = cardPath[card4];
            Card2.SizeMode = PictureBoxSizeMode.Zoom;

            if (cardValues[card3] == 11 || cardValues[card4] == 11)
            {
                if (cardValues[card3] == 11)
                {
                    playerScore += 11;
                    getPlayerScore(card4);
                }
                else
                {
                    playerScore += 11;
                    getPlayerScore(card3);
                }
            }
            else
            {
                getPlayerScore(card3);
                getPlayerScore(card4);
            }

        }

        private void getPlayerScore(int card) {
            if (cardValues[card] == 11)
            {
                if(playerScore + 11 > 21)
                {
                    playerScore += 1;
                    labelPlayerScore.Text = playerScore.ToString();
                }
            }
            else
            {
                playerScore += cardValues[card];
                labelPlayerScore.Text = playerScore.ToString();
            }
            if(playerScore > 21)
            {
                bust = true;
                StandBtn.PerformClick();
            }
        }

        private void HitBtn_Click(object sender, EventArgs e)
        {
            int nextCard = random.Next(0, 51);

            PictureBox newCard = new PictureBox();
            Point placement = new Point(posX, posY);

            // makes sure there are no duplicate cards
            do
            {
                for(int i = 0; i < cardPlaced.Count; i++)
                {
                    if(nextCard == cardPlaced[i])
                    {
                        nextCard = random.Next(0, 51);
                        i = 0;
                    }
                }
                break;
            } while (true);


            if (play == true)
            {
                newCard.ImageLocation = cardPath[nextCard];
                newCard.SizeMode = PictureBoxSizeMode.Zoom;
                newCard.Width = Card1.Width; // width of initial card on form
                newCard.Height = Card1.Height; // height of initial card on form
                newCard.Location = placement;
                
                this.Controls.Add(newCard);
                newCard.BringToFront();

                posX += 20;

                /* up down stacking
                switch (hit)
                {
                    case 0:
                        posX += 20;
                        hit++;
                        break;
                    case 1:
                        posX -= 20;
                        posY -= 40;
                        hit = 0;
                        break;
                }
                */
                cardPlaced.Add(nextCard);
                onBoard.Add(newCard);
                getPlayerScore(nextCard);
            }
        }
    }
    
}
