using System;
using System.Windows.Forms;
using ThreeStrikes.Domain;

namespace ThreeStrikes.Forms
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            txtName.Select();
            AcceptButton = btnStart;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Must enter player name!");
                return;
            }

            Player player = new Player(txtName.Text);

            Game game = new Game(player);
            game.ShowDialog();
        }

    }
}
