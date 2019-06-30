using System;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class MainForm : Form
    {
        private int com,user; // 0 = rock, 1 = paper, 2 = scissors
        private Random rand;
        public MainForm()
        {
            InitializeComponent();
            rock.Click += new EventHandler(rock_Click);
            paper.Click += new EventHandler(paper_Click);
            scissors.Click += new EventHandler(scissors_Click);
            exit.Click += new EventHandler(exit_Click);
        }

        private void MainForm_Load(object sender, EventArgs e){}
        private void rock_Click(object sender,EventArgs e)
        {
            user = 0;
            comSelect.Text= user.ToString();
        }
        private void paper_Click(object sender,EventArgs e)
        {
            user = 1;
        }
        private void scissors_Click(object sender, EventArgs e)
        {
            user = 2;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
