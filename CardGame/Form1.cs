using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

namespace CardGame
{
    public partial class CardGameForm : Form
    {
        private string selectedWinner = "";
        private List<string> cards = new List<string>
        {
            "2@", "2#", "2^", "2*", "3@", "3#", "3^", "3*", "4@", "4#", "4^", "4*",
            "5@", "5#", "5^", "5*", "6@", "6#", "6^", "6*", "7@", "7#", "7^", "7*",
            "8@", "8#", "8^", "8*", "9@", "9#", "9^", "9*", "10@", "10#", "10^", "10*",
            "J@", "J#", "J^", "J*", "Q@", "Q#", "Q^", "Q*", "K@", "K#", "K^", "K*",
            "A@", "A#", "A^", "A*"
        };

        private Dictionary<string, Panel> playerPanels = new Dictionary<string, Panel>();
        private Dictionary<string, List<string>> playerCards = new Dictionary<string, List<string>>();


        public CardGameForm()
        {
            InitializeComponent();

            InitializePlayerPanels();

        }

        private void ReInitializeCards()
        {
            cards = new List<string>
            {
                "2@", "2#", "2^", "2*", "3@", "3#", "3^", "3*", "4@", "4#", "4^", "4*",
                "5@", "5#", "5^", "5*", "6@", "6#", "6^", "6*", "7@", "7#", "7^", "7*",
                "8@", "8#", "8^", "8*", "9@", "9#", "9^", "9*", "10@", "10#", "10^", "10*",
                "J@", "J#", "J^", "J*", "Q@", "Q#", "Q^", "Q*", "K@", "K#", "K^", "K*",
                "A@", "A#", "A^", "A*"
            };
        }

        private void InitializePlayerPanels()
        {
            playerPanels.Add("panelAntony", panelAntony);
            playerPanels.Add("panelSharon", panelSharon);
            playerPanels.Add("panelDavid", panelDavid);
            playerPanels.Add("panelWilleam", panelWilleam);

            foreach (var playerPanel in playerPanels.Values)
            {
                playerCards.Add(playerPanel.Name, new List<string>());
            }
        }



        private void DistributeCards()
        {
            var random = new Random();

            while (cards.Count > 0)
            {
                foreach (var playerName in playerPanels.Keys)
                {
                    if (cards.Count == 0)
                        break;

                    int randomIndex = random.Next(cards.Count);
                    string card = cards[randomIndex];
                    cards.RemoveAt(randomIndex);

                    playerCards[playerName].Add(card);

                    // Add label with card value to player panel with a delay
                    AddLabelWithDelay(playerPanels[playerName], card, 100);
                }
            }
        }

        private void AddLabelWithDelay(Panel playerPanel, string card, int delayMilliseconds)
        {
            int labelTop = 0;

            Label cardLabel = new Label
            {
                Text = card,
                Size = new Size(42, 52),
                Font = new Font("Calibri", 12),
                BackColor = Color.LightBlue,
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.Green,
                //Top = labelTop,
                AutoSize = false
            };

            //labelTop += cardLabel.Height + 15; // Adjust the spacing between labels

            playerPanel.Controls.Add(cardLabel);
            playerPanel.Refresh();
            Thread.Sleep(delayMilliseconds);
        }

        //private void DisplayPlayerCards()
        //{
        //    foreach (var playerName in playerPanels.Keys)
        //    {
        //        MessageBox.Show($"{playerName}'s Cards: {string.Join(", ", playerCards[playerName])}");
        //    }
        //}

        private void DetermineWinner()
        {
            string winner = null;
            int maxMatchingCards = 0;

            foreach (var playerName in playerCards.Keys)
            {
                var cardGroups = playerCards[playerName].GroupBy(card => card.Substring(0, 2));

                foreach (var group in cardGroups)
                {
                    int matchingCardsCount = group.Count();

                    if (matchingCardsCount > maxMatchingCards)
                    {
                        maxMatchingCards = matchingCardsCount;
                        winner = playerName;
                    }
                    else if (matchingCardsCount == maxMatchingCards)
                    {
                        // If tie, compare alphanumeric and symbol part
                        string currentMaxCard = playerCards[winner].First();
                        string newCard = group.First();

                        if (CompareCards(newCard, currentMaxCard) > 0)
                        {
                            winner = playerName;
                        }
                    }
                }
            }

            DisplayWinner(winner);

            CheckUserGuess(selectedWinner, winner);
        }


        private void CheckUserGuess(string selectedWinner,string actualWinner)
        {
            actualWinner = actualWinner.Replace("panel", "");

            if (selectedWinner.Equals(actualWinner))
                MessageBox.Show("Congratulation ! You won the game");
            else
                MessageBox.Show("You guess the wrong person.Please try again");
        }

        private void DisplayWinner(string winner)
        {
            if (playerPanels.TryGetValue(winner, out Panel winnerPanel))
            {
                winnerPanel.BackColor = Color.Red; 
            }

            winner = winner.Replace("panel", "");
            labelWinner.Text = "The Winner is : " + winner;
        }

        private void ResetPanelColors()
        {
            foreach (var playerPanel in playerPanels.Values)
            {
                playerPanel.BackColor = SystemColors.Control; 
            }

            labelWinner.Text = "The Winner is : ";
        }

        private int CompareCards(string card1, string card2)
        {
            // Compare alphanumeric part
            int result = card1.Substring(0, 1).CompareTo(card2.Substring(0, 1));

            if (result == 0)
            {
                // If alphanumeric part is the same, compare symbol part
                result = card1.Substring(1).CompareTo(card2.Substring(1));
            }

            return result;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (selectedWinner.Equals(""))
            {
                MessageBox.Show("Please guess which player will win this round before start");
                return;
            }

            btnStartGame.Enabled = false;
            DistributeCards();
            //DisplayPlayerCards();
            DetermineWinner();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetPanelColors();
            ReInitializeCards();
            ClearLabelsFromPanel();
            ClearSelectedWinner();
            ResetValue();
            btnStartGame.Enabled = true;
        }

        private void ResetValue()
        {
            // Clear player cards record
            foreach (var player in playerCards.Keys)
            {
                playerCards[player].Clear();
            }
            selectedWinner = "";
        }

        private void ClearLabelsFromPanel()
        {
            panelAntony.Controls.Clear();
            panelSharon.Controls.Clear();
            panelDavid.Controls.Clear();
            panelWilleam.Controls.Clear();
        }

        private void ClearSelectedWinner()
        {
            AntonyCheckBox.Checked = false;
            SharonCheckBox.Checked = false;
            DavidCheckBox.Checked = false;
            WilleamCheckBox.Checked = false;
        }

        private void AntonyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedWinner.Equals("Antony"))
                AntonyCheckBox.Checked = true;

            SharonCheckBox.Checked = false;
            DavidCheckBox.Checked = false;
            WilleamCheckBox.Checked = false;
            selectedWinner = "Antony";
        }

        private void SharonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedWinner.Equals("Sharon"))
                SharonCheckBox.Checked = true;

            AntonyCheckBox.Checked = false;
            DavidCheckBox.Checked = false;
            WilleamCheckBox.Checked = false;
            selectedWinner = "Sharon";

        }

        private void DavidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedWinner.Equals("David"))
                DavidCheckBox.Checked = true;

            AntonyCheckBox.Checked = false;
            SharonCheckBox.Checked = false;
            WilleamCheckBox.Checked = false;
            selectedWinner = "David";
        }

        private void WilleamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedWinner.Equals("Willeam"))
                WilleamCheckBox.Checked = true;

            AntonyCheckBox.Checked = false;
            SharonCheckBox.Checked = false;
            DavidCheckBox.Checked = false;
            selectedWinner = "Willeam";
        }
    }
}
