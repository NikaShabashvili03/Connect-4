using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFor
{
    public partial class OptionScreen : Form
    {
        public OptionScreen()
        {
            InitializeComponent();
        }
        static int selectedMaxRound = 4;
        static int selectedWinLength = 4;
        static int selectedGameSize = 50;
        static int choosen = 0;
        Image[,] player_tokens = new Image[8, 4] {
                                          {Properties.Resources.Player1_Token1, Properties.Resources.Player2_Token1, Properties.Resources.Basic, Properties.Resources.BasicBG},
                                          {Properties.Resources.Player1_Token2, Properties.Resources.Player2_Token2, Properties.Resources.FireAndIce, Properties.Resources.FireAndIceBG},
                                          {Properties.Resources.Player1_Token3, Properties.Resources.Player2_Token3, Properties.Resources.ClashOfQueens, Properties.Resources.ClashOfQueensBG},
                                          {Properties.Resources.Player1_Token4, Properties.Resources.Player2_Token4, Properties.Resources.BattleOfBots, Properties.Resources.BattleOfBotsBG},
                                          {Properties.Resources.Player1_Token5, Properties.Resources.Player2_Token5, Properties.Resources.MarvelousStandoff, Properties.Resources.MarvelStandoffBG},
                                          {Properties.Resources.Player1_Token6, Properties.Resources.Player2_Token6, Properties.Resources.SimpsonVsGriffin, Properties.Resources.SimpsonVsGriffinBG},
                                          {Properties.Resources.Player1_Token7, Properties.Resources.Player2_Token7, Properties.Resources.ClashOfKings, Properties.Resources.ClashOfKingsBG},
                                          {Properties.Resources.Player1_Token8, Properties.Resources.Player2_Token8, Properties.Resources.AttackOfLegends, Properties.Resources.AttackOfLegendsBG}
        };

        private void LeftClick_Click(object sender, EventArgs e)
        {
            if (player_tokens.GetLength(0) == 1)
            {
                return;
            }
            if (choosen <= 0)
            {
                return;
            }
            RightClick.Enabled = true;
            LeftClick.Enabled = true;
            choosen -= 1;
            Player1PictureBox.BackgroundImage = player_tokens[choosen, 0];
            Player2PictureBox.BackgroundImage = player_tokens[choosen, 1];
            Theme.BackgroundImage = player_tokens[choosen, 2];
            this.BackgroundImage = player_tokens[choosen, 3];
        }

        private void RightClick_Click(object sender, EventArgs e)
        {
            if (player_tokens.GetLength(0) == 1)
            {
                return;
            }
            if (choosen >= player_tokens.GetLength(0) - 1)
            {
                return;
            }
            RightClick.Enabled = true;
            LeftClick.Enabled = true;
            choosen += 1;
            Player1PictureBox.BackgroundImage = player_tokens[choosen, 0];
            Player2PictureBox.BackgroundImage = player_tokens[choosen, 1];
            Theme.BackgroundImage = player_tokens[choosen, 2];
            this.BackgroundImage = player_tokens[choosen, 3];
        }

        private void OptionScreen_Load(object sender, EventArgs e)
        {
            Player1PictureBox.BackgroundImage = player_tokens[choosen, 0];
            Player2PictureBox.BackgroundImage = player_tokens[choosen, 1];
            Theme.BackgroundImage = player_tokens[choosen, 2];
            this.BackgroundImage = player_tokens[choosen, 3];

            // Win Length
            SelectWinLength.Items.Add(3);
            SelectWinLength.Items.Add(4);
            SelectWinLength.Items.Add(6);

            // Max Round
            SelectMaxRound.Items.Add(1);
            SelectMaxRound.Items.Add(2);
            SelectMaxRound.Items.Add(3);
            SelectMaxRound.Items.Add(4);
            SelectMaxRound.Items.Add(5);
            SelectMaxRound.Items.Add(6);

            // Size
            GameSizeCombobox.Items.Add("1X");
            GameSizeCombobox.Items.Add("2X");
            GameSizeCombobox.Items.Add("3X");

            SelectWinLength.Text = selectedWinLength.ToString();
            SelectMaxRound.Text = selectedMaxRound.ToString();
            if (selectedGameSize == 50) GameSizeCombobox.Text = "1X";
            else if (selectedGameSize == 60) GameSizeCombobox.Text = "2X";
            else if (selectedGameSize == 70) GameSizeCombobox.Text = "3X";
        }

        private void SaveTokens_Click(object sender, EventArgs e)
        {
            GameScene gc = new GameScene();
            gc.setOptions(
                player_tokens[choosen, 0],
                player_tokens[choosen, 1],
                player_tokens[choosen, 2],
                player_tokens[choosen, 3]
            );
            gc.setMaxRound(selectedMaxRound);
            gc.setWinLength(selectedWinLength);
            gc.setGameSize(selectedGameSize);
            gc.Show();
            this.Hide();
        }

        private void Theme_Click(object sender, EventArgs e)
        {

        }

        private void OptionScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void SelectWinLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWinLength = Int32.Parse(SelectWinLength.Text);
        }

        private void SelectMaxRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMaxRound = Int32.Parse(SelectMaxRound.Text);
        }

        private void SelectWinLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SelectMaxRound_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Player2Label_Click(object sender, EventArgs e)
        {

        }

        private void GameSizeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameSizeCombobox.Text == "1X")
            {
                selectedGameSize = 50;
            }
            if (GameSizeCombobox.Text == "2X")
            {
                selectedGameSize = 60;
            }
            if (GameSizeCombobox.Text == "3X")
            {
                selectedGameSize = 70;
            }
        }

        private void GameSizeCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ResetOptions_Click(object sender, EventArgs e)
        {
            selectedWinLength = 4;
            selectedMaxRound = 4;
            choosen = 0;
            selectedGameSize = 50;



            GameSizeCombobox.Text = "1X";
            SelectMaxRound.Text = selectedMaxRound.ToString();  
            SelectWinLength.Text = selectedWinLength.ToString();
            Player1PictureBox.BackgroundImage = player_tokens[choosen, 0];
            Player2PictureBox.BackgroundImage = player_tokens[choosen, 1];
            Theme.BackgroundImage = player_tokens[choosen, 2];
            this.BackgroundImage = player_tokens[choosen, 3];
        }
    }
}
