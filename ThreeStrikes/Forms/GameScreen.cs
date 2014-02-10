using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using ThreeStrikes.Domain;
using ThreeStrikes.Forms;

namespace ThreeStrikes
{
    public partial class GameScreen : Form
    {
        private readonly Player player;
        private Bag bag;
        private Prize prize;
        private int strikeCount;
        private PrizePanel prizePanel;
        private List<Label> panelLabels; 
        public GameScreen(Player player)
        {
            InitializeComponent();
            this.player = player;
            RestartGame();
        }

        public void RestartGame()
        {
            lblStrikes.Text = "Strikes: ";
            lblPanel0.Text = "X";
            lblPanel1.Text = "X";
            lblPanel2.Text = "X";
            lblPanel3.Text = "X";
            lblPanel4.Text = "X";
            RemoveHandlers();
            prize = GetRandomPrize();
            SetPrizeText(prize.Name);
            SetPrizeValuePanel(prize.Value);
            ResetStrikes();
            bag = new Bag(prize.Value);
            HideOnHand();
            SetProbabilites();
            panelLabels = new List<Label>();
            panelLabels.Add(lblPanel0);
            panelLabels.Add(lblPanel1);
            panelLabels.Add(lblPanel2);
            panelLabels.Add(lblPanel3);
            panelLabels.Add(lblPanel4);
        }

        private void SetProbabilites()
        {
            double strikeProb = SelectStrikeProbability();
            double numProb = SelectNumberProbability();
            lblPickStrike.Text = string.Format("Draw a strike: {0}%", Math.Round(strikeProb * 100, 2));
            lblPickingNumber.Text = string.Format("Draw a number: {0}%", Math.Round(numProb * 100, 2));
        }

        private double SelectStrikeProbability()
        {
            int strikes=0;
            int numbers=0;
            foreach (Disk disk in bag)
            {
                if (disk as NumberDisk != null)
                {
                    numbers++;
                }
                else
                {
                    strikes++;
                }
            }

            return (double)strikes / bag.Count;
        }

        private double SelectNumberProbability()
        {
            int strikes = 0;
            int numbers = 0;
            foreach (Disk disk in bag)
            {
                if (disk as NumberDisk != null)
                {
                    numbers++;
                }
                else
                {
                    strikes++;
                }
            }

            return (double)numbers / bag.Count;
        }

        private void ShowOnHand(NumberDisk onHand)
        {
            lblOnHand.Visible = true;
            lblOnHand.Text = string.Format("On Hand: {0}", onHand.Value);

        }

        private void HideOnHand()
        {
            lblOnHand.Visible = false;
        }

        private void AddHandlers()
        {
            lblPanel0.Click += lblPanel0_Click;
            lblPanel1.Click += lblPanel1_Click;
            lblPanel2.Click += lblPanel2_Click;
            lblPanel3.Click += lblPanel3_Click;
            lblPanel4.Click += lblPanel4_Click;
            btnPick.Visible = false;
        }

        private void RemoveHandlers()
        {
            lblPanel0.Click -= lblPanel0_Click;
            lblPanel1.Click -= lblPanel1_Click;
            lblPanel2.Click -= lblPanel2_Click;
            lblPanel3.Click -= lblPanel3_Click;
            lblPanel4.Click -= lblPanel4_Click;
            HideOnHand();
            btnPick.Visible = true;
            try
            {
                SetProbabilites();
            }
            catch { }
        }

        private void SetPrizeValuePanel(int prizeValue)
        {
            prizePanel = new PrizePanel(prizeValue);
        }

        private void SetPrizeText(string prize)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Prize: {0}", prize);
            lblPrize.Text = sb.ToString();
        }

        private Prize GetRandomPrize()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(Res.Prizes);
            XmlNodeList prizes = doc.SelectNodes("//Prize");
            List<Prize> Prizes = new List<Prize>();
            foreach (XmlNode prize in prizes)
            {
                string prizeName = prize.FirstChild.InnerText;
                string prizeValue = prize.LastChild.InnerText;
                Prizes.Add(new Prize(prizeName, int.Parse(prizeValue)));
            }

            Random rand = new Random();
            Prizes = Prizes.OrderBy(p => rand.Next()).ToList();

            return Prizes.First();
        }

        private void ResetStrikes()
        {
            strikeCount = 0;
            lblStrikes.Text = "Strikes: ";
        }

        private void AddStrike()
        {
            strikeCount++;

            if (strikeCount == 3)
            {
                GameOver(false);
            }
            else
            {
                // Display strike and then disappear 
                lblStrikes.Text = string.Format("Strikes: {0}", strikeCount);
                lblStrike.Visible = true;
                Timer tmr = new Timer();
                tmr.Interval = 3000;
                tmr.Tick += (sender, args) => { lblStrike.Visible = false; };
                tmr.Start();
            }
        }

        private void GameOver(bool win)
        {
            DialogResult diag = MessageBox.Show(win ? "Congratulations, you win" : "Game Over", "Try Again?", MessageBoxButtons.YesNo);
            if (diag == DialogResult.Yes)
            {
                RestartGame();
            }
            else
                Close();
            
        }

        private void CheckPanel()
        {
            string strPrize = prize.Value.ToString();
            string check = lblPanel0.Text + lblPanel1.Text + lblPanel2.Text + lblPanel3.Text + lblPanel4.Text;

            SetPanelProbability();
            if(strPrize == check)
                GameOver(true);
        }

        #region Click Events

        private void btnPick_Click(object sender, EventArgs e)
        {
            bag.Shuffle();
            Disk disk = player.PickOne(bag);
            if (disk as Strike != null)
            {
                AddStrike();
                bag.Shuffle();
                SetProbabilites();
                return;
            }
            SetProbabilites();
            SetPanelProbability();
            player.OnHand = disk as NumberDisk;
            ShowOnHand(player.OnHand);
            AddHandlers();

        }

        private void SetPanelProbability()
        {
            double prob = SelectPanelProbability();
            lblPickCorPanel.Text = string.Format("Select correct panel: {0}%", Math.Round(prob*100, 2));
        }

        private double SelectPanelProbability()
        {
            double numOfX = 0;
            double numOfNums = 0;

            foreach (Label panelLabel in panelLabels)
            {
                if (panelLabel.Text == "X")
                    numOfX++;
            }

            return 1 / numOfX;
        }

        private void lblPanel0_Click(object sender, EventArgs e)
        {
            if (prizePanel.CheckPanel(0, player.OnHand))
            {
                lblPanel0.Text = player.OnHand.Value.ToString();
                CheckPanel();
            }
            else
                bag.Add(player.OnHand);

            player.OnHand = null;
            RemoveHandlers();
        }

        private void lblPanel1_Click(object sender, EventArgs e)
        {
            if (prizePanel.CheckPanel(1, player.OnHand))
            {
                lblPanel1.Text = player.OnHand.Value.ToString();
                CheckPanel();
            }
            else
                bag.Add(player.OnHand);

            player.OnHand = null;
            RemoveHandlers();
        }

        private void lblPanel2_Click(object sender, EventArgs e)
        {
            if (prizePanel.CheckPanel(2, player.OnHand))
            {
                lblPanel2.Text = player.OnHand.Value.ToString();
                CheckPanel();
            }
            else
                bag.Add(player.OnHand);

            player.OnHand = null;
            RemoveHandlers();
        }

        private void lblPanel3_Click(object sender, EventArgs e)
        {
            if (prizePanel.CheckPanel(3, player.OnHand))
            {
                lblPanel3.Text = player.OnHand.Value.ToString();
                CheckPanel();
            }
            else
                bag.Add(player.OnHand);


            player.OnHand = null;
            RemoveHandlers();
        }

        private void lblPanel4_Click(object sender, EventArgs e)
        {
            if (prizePanel.CheckPanel(4, player.OnHand))
            {
                lblPanel4.Text = player.OnHand.Value.ToString();
                CheckPanel();
            }
            else
                bag.Add(player.OnHand);

            player.OnHand = null;
            RemoveHandlers();
        }

        #endregion

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            help.ShowDialog();
        }
    }
}
