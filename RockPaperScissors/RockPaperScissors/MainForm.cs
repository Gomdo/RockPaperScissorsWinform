using System;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class MainForm : Form
    {
        private int com,user; // 0 = rock, 1 = paper, 2 = scissors
        private Random rand = new Random();
        public MainForm()
        {
            InitializeComponent();
            rock.Click += new EventHandler(Rock_Click);
            paper.Click += new EventHandler(Paper_Click);
            scissors.Click += new EventHandler(Scissors_Click);
            exit.Click += new EventHandler(Exit_Click);
        }

        private void MainForm_Load(object sender, EventArgs e){}
        private void Rock_Click(object sender,EventArgs e)
        {
            com = rand.Next(0, 3);
            user = 0;
            GameResult(user, com);
        }
        private void Paper_Click(object sender,EventArgs e)
        {
            com = rand.Next(0, 3);
            user = 1;
            GameResult(user, com);
        }
        private void Scissors_Click(object sender, EventArgs e)
        {
            com = rand.Next(0, 3);
            user = 2;
            GameResult(user, com);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GameResult(int user,int com) //0 = user win 1 = com win 2 = draw
        {
            switch (com)
            {
                case 0:
                    comSelect.Text = "Rock";
                    break;
                case 1:
                    comSelect.Text = "Paper";
                    break;
                case 2:
                    comSelect.Text = "Scissors";
                    break;
            }
            if(user == com)
            {
                result.Text = "Draw";
            }
            else if((user == 0 && com == 2) || (user == 1 && com == 0) || user == 2 && com == 1)
            {
                result.Text = "You win";
            }
            else
            {
                result.Text = "You lose";
            }
        }
    }
}
