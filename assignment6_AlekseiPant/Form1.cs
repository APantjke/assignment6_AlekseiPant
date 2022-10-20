using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6_AlekseiPant
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int playerChoice = 0;
        int numberOfWins = 0;
        int numberOfLoses = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void rockButton(object sender, EventArgs e)
        {
            playerChoice = 1;
            label1.Text = "Your current choice: Rock";
        }

        private void paperButton(object sender, EventArgs e)
        {
            playerChoice = 2;
            label1.Text = "Your current choice: Paper";
        }

        private void scissorsButton(object sender, EventArgs e)
        {
            playerChoice = 3;
            label1.Text = "Your current choice: Scissors";
        }

        private void playButton(object sender, EventArgs e)
        {
            int computerChoice = random.Next(1, 4);
            showResult(computerChoice, playerChoice);
            winsLabel.Text = "" + numberOfWins + "";
            losesLabel.Text = "" + numberOfLoses + "";
        }

        public void showResult(int computerScore, int playerScore)
        {
            if (computerScore == 1 && playerScore == 2)
            {
                MessageBox.Show("Paper wraps rock.", "You won!");
                numberOfWins+=1;
            }
            else if (computerScore == 2 && playerScore == 3)
            {
                MessageBox.Show("Scissors cuts paper.", "You won!");
                numberOfWins+=1;
            }
            else if (computerScore == 3 && playerScore == 1)
            {
                MessageBox.Show("Rock smashes scissors.", "You won!");
                numberOfWins+=1;
            }
            else if (computerScore == 2 && playerScore == 1)
            {
                MessageBox.Show("Paper wraps rock.", "The computer won");
                numberOfLoses+=1;
            }
            else if (computerScore == 3 && playerScore == 2)
            {
                MessageBox.Show("Scissors cuts paper.", "The computer won");
                numberOfLoses+=1;
            }
            else if (computerScore == 1 && playerScore == 3)
            {
                MessageBox.Show("Rock smashes scissors.", "The computer won");
                numberOfLoses+=1;
            }
            else
            {
                MessageBox.Show("Play again to determine the winner.", "it's a draw!");
            }
        }
    }
}
