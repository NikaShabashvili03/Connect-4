using System.Media;
using System.Runtime.InteropServices;

namespace ConnectFor
{
    public partial class GameScene : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

        Panel GamePanel = new Panel();
        Panel SelectedCol = new Panel();
        Button[] gridCols = new Button[gridSize];
        Button resetGameBtn = new Button();

        // 
        PictureBox[] selectedColTokenForDrop = new PictureBox[gridSize];
        // Score Board
        Panel ScoreBoard = new Panel();
        Panel P1ScoreBoard = new Panel();
        Panel P2ScoreBoard = new Panel();
        Panel isPlayer1Move = new Panel();
        // Stats
        private const int gridSize = 8;
        private static int buttonSize = 50;
        private static int winLength = 4;
        private const int padding = 10;
        private Button[,] gridButtons;
        private char[,] gridState; // Represents the current state of the grid ('X', 'O', or empty)
        private bool isPlayerX = true; // Indicates whether it's player X's turn
        private static Image
            Player1_Token = Properties.Resources.Player1_Token1,
            Player2_Token = Properties.Resources.Player2_Token1,
            Theme = Properties.Resources.Basic,
            Background = Properties.Resources.BasicBG;
        private static int P1Score = 0;
        private static int P2Score = 0;
        private static int Round = 0;
        private static int MaxRound = 4;
        Label round = new Label();
        SoundPlayer DropSoundEffect = new SoundPlayer(Properties.Resources.drop);

        public void setOptions(Image player1, Image player2, Image TitleTheme, Image Bg)
        {
            Player1_Token = player1;
            Player2_Token = player2;
            Theme = TitleTheme;
            Background = Bg;
        }

        public void setGameSize(int size)
        {
            buttonSize = size;
        }
        public void setWinLength(int WinLength)
        {
            winLength = WinLength;
        }
        public void setMaxRound(int rounds)
        {
            MaxRound = rounds;
        }

        public GameScene()
        {
            InitializeComponent();
        }


        private void InitialP2Score()
        {
            PictureBox[] scores = new PictureBox[P2Score];
            if (P2Score == 0)
            {
                return;
            }

            for (int i = 0; i < P2Score; i++)
            {
                PictureBox scorePictureBox = new PictureBox();
                scorePictureBox.BackgroundImage = Properties.Resources.Winner_Token;
                scorePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                scorePictureBox.Width = buttonSize;
                scorePictureBox.Height = buttonSize;
                scorePictureBox.Left = 200 / 2 - buttonSize / 2;
                scorePictureBox.Top = (Round - 1) * (buttonSize + padding) + padding;
                scorePictureBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, scorePictureBox.Width, scorePictureBox.Height, 100, 100));
                scores[i] = scorePictureBox;
                P2ScoreBoard.Controls.Add(scorePictureBox);
            }
        }

        private void InitialP2ScoreBoard()
        {
            P2ScoreBoard.Width = 200;
            P2ScoreBoard.Top = (MaxRound * 4) + 50;
            P2ScoreBoard.Left = P1ScoreBoard.Width;
            P2ScoreBoard.Height = gridSize * (buttonSize + padding) + padding * 2;
            P2ScoreBoard.BackColor = Color.Transparent;

            ScoreBoard.Controls.Add(P2ScoreBoard);
        }

        private void InitialP1Logo()
        {
            PictureBox pLogo = new PictureBox();
            Label pText = new Label();

            pLogo.Left = 30;
            pLogo.Top = 15;
            pLogo.Width = 35;
            pLogo.Height = 35;
            pLogo.BackgroundImage = Player1_Token;
            pLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pLogo.Width, pLogo.Height, 100, 100));

            pText.Top = 15;
            pText.Text = "Player 1";
            pText.BackColor = Color.Transparent;
            pText.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pText.Left = P1ScoreBoard.Width / 2 - pText.Width / 4;

            ScoreBoard.Controls.Add(pLogo);
            ScoreBoard.Controls.Add(pText);
        }

        private void InitialP2Logo()
        {
            PictureBox pLogo = new PictureBox();
            Label pText = new Label();

            pLogo.Left = P1ScoreBoard.Width + 30;
            pLogo.Top = 15;
            pLogo.Width = 35;
            pLogo.Height = 35;
            pLogo.BackgroundImage = Player2_Token;
            pLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pLogo.Width, pLogo.Height, 100, 100));



            pText.Top = 15;
            pText.Text = "Player 2";
            pText.BackColor = Color.Transparent;
            pText.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pText.Left = P1ScoreBoard.Width + P2ScoreBoard.Width / 2 - pText.Width / 4;

            ScoreBoard.Controls.Add(pLogo);
            ScoreBoard.Controls.Add(pText);
        }
        private void InitialP1Score()
        {
            PictureBox[] scores = new PictureBox[P1Score];
            if (P1Score == 0)
            {
                return;
            }

            for (int i = 0; i < P1Score; i++)
            {
                PictureBox scorePictureBox = new PictureBox();
                scorePictureBox.BackgroundImage = Properties.Resources.Winner_Token;
                scorePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                scorePictureBox.Width = buttonSize;
                scorePictureBox.Height = buttonSize;
                scorePictureBox.Left = 200 / 2 - buttonSize / 2;
                scorePictureBox.Top = (Round - 1) * (buttonSize + padding) + padding;
                scorePictureBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, scorePictureBox.Width, scorePictureBox.Height, 100, 100));
                scores[i] = scorePictureBox;
                P1ScoreBoard.Controls.Add(scorePictureBox);
            }
        }
        private void InitialP1ScoreBoard()
        {
            P1ScoreBoard.Width = 200;
            P1ScoreBoard.Top = (MaxRound * 4) + 50;
            P1ScoreBoard.Height = gridSize * (buttonSize + padding) + padding * 2;
            P1ScoreBoard.BackColor = Color.Transparent;

            ScoreBoard.Controls.Add(P1ScoreBoard);
        }

        private void InitialRoundCounter()
        {
            round.Left = ScoreBoard.Width / 2 - round.Width / 4;
            round.Text = Round + " / " + MaxRound;
            round.BackColor = Color.Transparent;
            round.Font = new Font("Segoe MDL2 Assets", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            round.Top = 15;
            ScoreBoard.Controls.Add(round);
        }

        private void InitialRounds()
        {
            Label[] rounds = new Label[MaxRound];
            // 
            for (int i = 0; i < MaxRound; i++)
            {
                Label roundloop = new Label();
                roundloop.Text = (i + 1).ToString(); 
                roundloop.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
             
             
             
                roundloop.TextAlign = ContentAlignment.MiddleCenter;

                roundloop.Width = 35;
                roundloop.Height = 35;

                roundloop.Left = (ScoreBoard.Width / 2) + roundloop.Width * 2 + 13;

                roundloop.Top = i * (buttonSize + padding) + padding + (MaxRound * 4) + 60;

                //roundloop.ForeColor = Color.Black;
                // Background 
                roundloop.ForeColor = Color.White;
                roundloop.BackColor = Color.FromArgb(0, 107, 223);
                roundloop.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, roundloop.Width, roundloop.Height, 70, 70));




                rounds[i] = roundloop;


                ScoreBoard.Controls.Add(roundloop);
            }
        }

        private void InitialScoreBoards()
        {
            ScoreBoard.Width = 400;
            ScoreBoard.Height = gridSize * (buttonSize + padding) + padding * 2;
            ScoreBoard.Top = 100 + buttonSize + padding;
            ScoreBoard.Left = 100 + GamePanel.Width + 100;
            ScoreBoard.BackgroundImage = Properties.Resources.ScoreBoardBG;
            ScoreBoard.BackgroundImageLayout = ImageLayout.Stretch;
            ScoreBoard.BackColor = Color.Transparent;

            this.Width += ScoreBoard.Width;

         
            // Logos
            InitialP1Logo();
            InitialP2Logo();

            InitialRoundCounter();

            // Scoreboard
            this.Controls.Add(ScoreBoard);
        }
        private void InitialResetButton()
        {
            resetGameBtn.Width = 50;
            resetGameBtn.Height = 50;
            resetGameBtn.Left = (this.Width / 2) - resetGameBtn.Width;
            resetGameBtn.Top = GamePanel.Height + 125 + buttonSize + padding;
            resetGameBtn.BackgroundImageLayout = ImageLayout.Stretch;
            resetGameBtn.Text = "Reset";
            resetGameBtn.FlatStyle = FlatStyle.Flat;
            resetGameBtn.FlatAppearance.BorderSize = 0;
            resetGameBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, resetGameBtn.Width, resetGameBtn.Height, 100, 100));
            resetGameBtn.Enabled = false;
            resetGameBtn.Font = new Font("Segoe MDL2 Assets", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetGameBtn.Click += ResetGame;

            this.Controls.Add(resetGameBtn);
        }
        private void InitialTheme()
        {
            PictureBox title = new PictureBox();
            title.Width = 274;
            title.Height = 120;
            title.BackColor = Color.Transparent;
            title.BackgroundImage = Theme;
            title.BackgroundImageLayout = ImageLayout.Stretch;
            title.Left = (this.Width / 2) - (title.Width / 2);

            this.Controls.Add(title);
        }
        private void InitializeSelectedCol()
        {
            SelectedCol.Width = GamePanel.Width;
            SelectedCol.Height = buttonSize + padding;
            SelectedCol.Left = GamePanel.Left;
            SelectedCol.Top = 100;
            SelectedCol.BackColor = Color.Transparent;
            
            for(int i = 0; i < gridSize; i++)
            {
                PictureBox token = new PictureBox();

                token.Width = buttonSize;
                token.Height = buttonSize;
                token.Left = i * (buttonSize + padding) + padding;
                token.Top = padding / 2;
                token.BackgroundImageLayout = ImageLayout.Stretch;
                selectedColTokenForDrop[i] = token;
                SelectedCol.Controls.Add(token);

            }
            this.Controls.Add(SelectedCol);
        }
        private void InitializeFoots()
        {
            PictureBox LeftFoot = new PictureBox();
            LeftFoot.BackgroundImage = Properties.Resources.leftfoot;
            LeftFoot.Width = buttonSize * 2;
            LeftFoot.Height = buttonSize * 3;
            LeftFoot.Top = GamePanel.Height + 110;
            LeftFoot.Left = 98 - LeftFoot.Width / 2;
            LeftFoot.BackColor = Color.Transparent;
            LeftFoot.BackgroundImageLayout = ImageLayout.Stretch;

            this.Controls.Add(LeftFoot);


            PictureBox RightFoot = new PictureBox();
            RightFoot.BackgroundImage = Properties.Resources.rightfoot;
            RightFoot.Width = buttonSize * 2;
            RightFoot.Height = buttonSize * 3;
            RightFoot.Top = GamePanel.Height + 110;
            RightFoot.Left = 102 - RightFoot.Width / 2 + GamePanel.Width;
            RightFoot.BackColor = Color.Transparent;
            RightFoot.BackgroundImageLayout = ImageLayout.Stretch;

            this.Controls.Add(RightFoot);
        }
        private void InitializeGamePanel(int width, int height)
        {
            GamePanel.Width = width;
            GamePanel.Height = height;
            GamePanel.Left = 100;
            GamePanel.Top = 100 + buttonSize + padding;
            GamePanel.BackColor = Color.FromArgb(0, 107, 223);

            this.Width = (GamePanel.Width + GamePanel.Left * 2 + GamePanel.Left / 2);
            this.Height = GamePanel.Height + GamePanel.Top * 2 - GamePanel.Top / 2 + buttonSize + padding;
            this.Controls.Add(GamePanel);
            InitializeSelectedCol();
            InitializeFoots();
        }

        private void InitializeGrid()
        {
            gridButtons = new Button[gridSize, gridSize];
            gridState = new char[gridSize, gridSize];
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Button button = new Button();
                    button.Name = "button_" + i + "_" + j;
                    button.Text = "";
                    button.Width = buttonSize;
                    button.Height = buttonSize;
                    button.TabIndex = 0;
                    button.Left = j * (buttonSize + padding) + padding;
                    button.Top = i * (buttonSize + padding) + padding;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackgroundImage = Properties.Resources.buttonBackgroundFixed;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = Color.Transparent;
                    button.Click += Button_Click; // Event handler for button click
                    button.MouseEnter += Button_MouseEnter;
                    button.MouseLeave += Button_MouseLeave;
                    button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 45, 45));
                    gridButtons[i, j] = button;
                    gridState[i, j] = ' '; // Initialize grid state with empty cells


                    GamePanel.Controls.Add(button);
                }
            }
            InitialGridCols();
            InitializeGamePanel(gridSize * (buttonSize + padding) + padding, gridSize * (buttonSize + padding) + padding * 2);
        }

        private void InitialGridCols()
        {
            for (int i = 0; i < gridSize; i++)
            {
                gridCols[i] = new Button();
                gridCols[i].BackColor = Color.Transparent;
                gridCols[i].Width = (buttonSize + padding) + padding / 2;
                gridCols[i].Height = gridSize * (buttonSize + padding) + padding * 2;
                gridCols[i].Click += Button_Click;
                gridCols[i].Left = i * (buttonSize + padding);
                gridCols[i].TabIndex = 5;

                gridCols[i].FlatAppearance.BorderSize = 0;
                gridCols[i].MouseEnter += Button_MouseEnter;
                gridCols[i].MouseLeave += Button_MouseLeave;
                gridCols[i].FlatStyle = FlatStyle.Flat;
                gridCols[i].Name = "_" + i;
                GamePanel.Controls.Add(gridCols[i]);
            }
            gridCols[gridSize - 1].Width += padding / 2;

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button MouseEnteredbutton = (sender as Button);
            string[] id = MouseEnteredbutton.Name.Split('_');
            int selectedCol = int.Parse(id[id.Length - 1]);
            gridCols[selectedCol].BackColor = Color.FromArgb(71, 145, 226);
            selectedColTokenForDrop[selectedCol].BackgroundImage = isPlayerX ? Player1_Token : Player2_Token;
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button MouseEnteredbutton = (sender as Button);
            string[] id = MouseEnteredbutton.Name.Split('_');
            int selectedCol = int.Parse(id[id.Length - 1]);
            gridCols[selectedCol].BackColor = Color.Transparent;
            selectedColTokenForDrop[selectedCol].BackgroundImage = null;
        }

        private void HardResetGame()
        {
            P1Score = 0;
            P2Score = 0;
            Round = 0;
            InitialP2Score();
            InitialP1Score();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void endGame()
        {
            if (P1Score > P2Score)
            {
                MessageBox.Show("P 1 Win");
            }
            else if (P1Score < P2Score)
            {
                MessageBox.Show("P 2 Win");
            }
            else
            {
                MessageBox.Show("Draw");
            }
            HardResetGame();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string[] id = clickedButton.Name.Split('_');
                int selectedCol = int.Parse(id[id.Length - 1]);


                for (int i = gridSize - 1; i >= 0; i--)
                {
                    if (gridState[i, selectedCol] == ' ')
                    {
                        DropSoundEffect.Play();
                        selectedColTokenForDrop[selectedCol].BackgroundImage = isPlayerX ? Player2_Token : Player1_Token;
               
                        gridState[i, selectedCol] = isPlayerX ? 'X' : 'O';
                        gridButtons[i, selectedCol].BackgroundImage = isPlayerX ?
                            Player1_Token
                            :
                            Player2_Token;

                       
                        if (CheckForWin(i, selectedCol, isPlayerX ? 'X' : 'O'))
                        {
                            Round += 1;
                            InitialRoundCounter();
                            if (isPlayerX)
                            {
                                P1Score += 1;
                                InitialP1Score();
                                if (Round == MaxRound)
                                {
                                    endGame();
                                    return;
                                }
                            }
                            else if (!isPlayerX)
                            {
                                P2Score += 1;
                                InitialP2Score();
                                if (Round == MaxRound)
                                {
                                    endGame();
                                    return;
                                }
                            }

                            DisableGame();
                        }
                        else if (CheckForDraw())
                        {
                            DisableGame();
                            Round += 1;
                            InitialRoundCounter();
                            InitialRoundCounter();
                            if (Round == MaxRound)
                            {
                                endGame();
                                return;
                            }
                        }

                        // Switch to the other player's turn
                        isPlayerX = !isPlayerX;

                        break;
                    }
                }
            }
        }

        private bool CheckForWin(int row, int col, char player)
        {
            // Check horizontally
            int count = 0;
            for (int j = 0; j < gridSize; j++)
            {
                if (gridState[row, j] == player)
                {
                    count++;
                    if (count == winLength)
                    {
                        // Mark winning buttons
                        for (int k = j - winLength + 1; k <= j; k++)
                        {
                            gridButtons[row, k].BackgroundImage = Properties.Resources.Winner_Token; // Change background color
                        }
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            // Check vertically
            count = 0;
            for (int i = 0; i < gridSize; i++)
            {
                if (gridState[i, col] == player)
                {
                    count++;
                    if (count == winLength)
                    {
                        // Mark winning buttons
                        for (int k = i - winLength + 1; k <= i; k++)
                        {
                            gridButtons[k, col].BackgroundImage = Properties.Resources.Winner_Token; // Change background color
                        }
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            // Check diagonally (from top-left to bottom-right)
            count = 0;
            int startRow = row;
            int startCol = col;
            while (startRow > 0 && startCol > 0)
            {
                startRow--;
                startCol--;
            }

            while (startRow < gridSize && startCol < gridSize)
            {
                if (gridState[startRow, startCol] == player)
                {
                    count++;
                    if (count == winLength)
                    {
                        // Mark winning buttons
                        for (int k = 0; k < winLength; k++)
                        {
                            gridButtons[startRow - k, startCol - k].BackgroundImage = Properties.Resources.Winner_Token; // Change background color
                        }
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }

                startRow++;
                startCol++;
            }

            // Check diagonally (from bottom-left to top-right)
            count = 0;
            startRow = row;
            startCol = col;
            while (startRow < gridSize - 1 && startCol > 0)
            {
                startRow++;
                startCol--;
            }

            while (startRow >= 0 && startCol < gridSize)
            {
                if (gridState[startRow, startCol] == player)
                {
                    count++;
                    if (count == winLength)
                    {
                        // Mark winning buttons
                        for (int k = 0; k < winLength; k++)
                        {
                            gridButtons[startRow + k, startCol - k].BackgroundImage = Properties.Resources.Winner_Token; // Change background color
                        }

                        return true;
                    }
                }
                else
                {
                    count = 0;
                }

                startRow--;
                startCol++;
            }

            return false;
        }

        private bool CheckForDraw()
        {

            // Check if all cells are filled
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (gridState[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    gridButtons[i, j].BackgroundImage = Properties.Resources.Winner_Token;
                    gridButtons[i, j].Enabled = false;
                }
            }
            return true;
        }

        private void DisableGame()
        {
            resetGameBtn.Enabled = true;
            for (int i = 0; i < gridSize; i++)
            {
                gridCols[i].Enabled = false;
                for (int j = 0; j < gridSize; j++)
                {
                    gridState[i, j] = ' ';
                    gridButtons[i, j].Enabled = false;
                }
            }
        }

        private void ResetGame(object sender, EventArgs e)
        {
            resetGameBtn.Enabled = false;
            // Reset grid state and button texts
            for (int i = 0; i < gridSize; i++)
            {
                gridCols[i].Enabled = true;
                for (int j = 0; j < gridSize; j++)
                {
                    gridState[i, j] = ' ';
                    gridButtons[i, j].Text = "";
                    gridButtons[i, j].BackgroundImage = Properties.Resources.buttonBackgroundFixed;
                    gridButtons[i, j].Enabled = true;
                }
            }

            // Reset the player turn to X
            isPlayerX = true;
            isPlayer1Move.Left = 5;
        }


        private void GameScene_Load(object sender, EventArgs e)
        {
            InitializeGrid();

            InitialTheme();
            InitialResetButton();
            InitialRounds();
            InitialP1ScoreBoard();
            InitialP2ScoreBoard();
            InitialScoreBoards();
            InitialP1Score();
            InitialP2Score();

            this.BackgroundImage = Background;


        }

        private void GameScene_FormClosed(object sender, FormClosedEventArgs e)
        {
            HardResetGame();
        }
    }
}
