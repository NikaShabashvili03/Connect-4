namespace ConnectFor
{
    partial class OptionScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LeftClick = new Button();
            Player1PictureBox = new PictureBox();
            Player2PictureBox = new PictureBox();
            RightClick = new Button();
            SaveTokens = new Button();
            p1 = new Label();
            Theme = new PictureBox();
            panel1 = new Panel();
            GameSizeLabel = new Label();
            GameSizeCombobox = new ComboBox();
            MaxRoundLabel = new Label();
            Player2Label = new Label();
            SelectMaxRound = new ComboBox();
            WinLengthLabel = new Label();
            SelectWinLength = new ComboBox();
            ResetOptions = new Button();
            ((System.ComponentModel.ISupportInitialize)Player1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Theme).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LeftClick
            // 
            LeftClick.BackColor = Color.Transparent;
            LeftClick.BackgroundImage = Properties.Resources.left_arrow;
            LeftClick.BackgroundImageLayout = ImageLayout.Stretch;
            LeftClick.Cursor = Cursors.Hand;
            LeftClick.FlatAppearance.BorderSize = 0;
            LeftClick.FlatAppearance.MouseDownBackColor = Color.Transparent;
            LeftClick.FlatAppearance.MouseOverBackColor = Color.Transparent;
            LeftClick.FlatStyle = FlatStyle.Flat;
            LeftClick.Location = new Point(3, 65);
            LeftClick.Name = "LeftClick";
            LeftClick.Size = new Size(70, 70);
            LeftClick.TabIndex = 1;
            LeftClick.UseVisualStyleBackColor = false;
            LeftClick.Click += LeftClick_Click;
            // 
            // Player1PictureBox
            // 
            Player1PictureBox.BackColor = Color.Transparent;
            Player1PictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            Player1PictureBox.Location = new Point(84, 48);
            Player1PictureBox.Name = "Player1PictureBox";
            Player1PictureBox.Size = new Size(126, 115);
            Player1PictureBox.TabIndex = 2;
            Player1PictureBox.TabStop = false;
            // 
            // Player2PictureBox
            // 
            Player2PictureBox.BackColor = Color.Transparent;
            Player2PictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            Player2PictureBox.Location = new Point(522, 48);
            Player2PictureBox.Name = "Player2PictureBox";
            Player2PictureBox.Size = new Size(126, 115);
            Player2PictureBox.TabIndex = 3;
            Player2PictureBox.TabStop = false;
            // 
            // RightClick
            // 
            RightClick.BackColor = Color.Transparent;
            RightClick.BackgroundImage = Properties.Resources.right_arrow;
            RightClick.BackgroundImageLayout = ImageLayout.Stretch;
            RightClick.Cursor = Cursors.Hand;
            RightClick.FlatAppearance.BorderSize = 0;
            RightClick.FlatAppearance.MouseDownBackColor = Color.Transparent;
            RightClick.FlatAppearance.MouseOverBackColor = Color.Transparent;
            RightClick.FlatStyle = FlatStyle.Flat;
            RightClick.Location = new Point(669, 65);
            RightClick.Name = "RightClick";
            RightClick.Size = new Size(70, 70);
            RightClick.TabIndex = 4;
            RightClick.UseVisualStyleBackColor = false;
            RightClick.Click += RightClick_Click;
            // 
            // SaveTokens
            // 
            SaveTokens.Cursor = Cursors.Hand;
            SaveTokens.FlatAppearance.BorderSize = 0;
            SaveTokens.FlatStyle = FlatStyle.Flat;
            SaveTokens.Location = new Point(202, 405);
            SaveTokens.Name = "SaveTokens";
            SaveTokens.Size = new Size(123, 33);
            SaveTokens.TabIndex = 5;
            SaveTokens.Text = "Save";
            SaveTokens.UseVisualStyleBackColor = true;
            SaveTokens.Click += SaveTokens_Click;
            // 
            // p1
            // 
            p1.AutoSize = true;
            p1.BackColor = Color.Transparent;
            p1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p1.ForeColor = Color.White;
            p1.Location = new Point(84, 20);
            p1.Name = "p1";
            p1.Size = new Size(83, 25);
            p1.TabIndex = 6;
            p1.Text = "Player 1";
            // 
            // Theme
            // 
            Theme.BackColor = Color.Transparent;
            Theme.BackgroundImageLayout = ImageLayout.Stretch;
            Theme.Location = new Point(228, 48);
            Theme.Name = "Theme";
            Theme.Size = new Size(274, 115);
            Theme.TabIndex = 8;
            Theme.TabStop = false;
            Theme.Click += Theme_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(GameSizeLabel);
            panel1.Controls.Add(GameSizeCombobox);
            panel1.Controls.Add(MaxRoundLabel);
            panel1.Controls.Add(Player2Label);
            panel1.Controls.Add(SelectMaxRound);
            panel1.Controls.Add(WinLengthLabel);
            panel1.Controls.Add(RightClick);
            panel1.Controls.Add(Player2PictureBox);
            panel1.Controls.Add(LeftClick);
            panel1.Controls.Add(Theme);
            panel1.Controls.Add(SelectWinLength);
            panel1.Controls.Add(p1);
            panel1.Controls.Add(Player1PictureBox);
            panel1.Location = new Point(25, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 344);
            panel1.TabIndex = 9;
            // 
            // GameSizeLabel
            // 
            GameSizeLabel.AutoSize = true;
            GameSizeLabel.BackColor = Color.Transparent;
            GameSizeLabel.FlatStyle = FlatStyle.Flat;
            GameSizeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameSizeLabel.ForeColor = Color.White;
            GameSizeLabel.Location = new Point(84, 286);
            GameSizeLabel.Name = "GameSizeLabel";
            GameSizeLabel.Size = new Size(71, 17);
            GameSizeLabel.TabIndex = 15;
            GameSizeLabel.Text = "Game Size";
            // 
            // GameSizeCombobox
            // 
            GameSizeCombobox.FormattingEnabled = true;
            GameSizeCombobox.Location = new Point(84, 306);
            GameSizeCombobox.Name = "GameSizeCombobox";
            GameSizeCombobox.Size = new Size(121, 23);
            GameSizeCombobox.TabIndex = 14;
            GameSizeCombobox.SelectedIndexChanged += GameSizeCombobox_SelectedIndexChanged;
            GameSizeCombobox.KeyPress += GameSizeCombobox_KeyPress;
            // 
            // MaxRoundLabel
            // 
            MaxRoundLabel.AutoSize = true;
            MaxRoundLabel.BackColor = Color.Transparent;
            MaxRoundLabel.FlatStyle = FlatStyle.Flat;
            MaxRoundLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaxRoundLabel.ForeColor = Color.White;
            MaxRoundLabel.Location = new Point(84, 240);
            MaxRoundLabel.Name = "MaxRoundLabel";
            MaxRoundLabel.Size = new Size(78, 17);
            MaxRoundLabel.TabIndex = 13;
            MaxRoundLabel.Text = "Max Round";
            // 
            // Player2Label
            // 
            Player2Label.AutoSize = true;
            Player2Label.BackColor = Color.Transparent;
            Player2Label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Player2Label.ForeColor = Color.White;
            Player2Label.Location = new Point(522, 20);
            Player2Label.Name = "Player2Label";
            Player2Label.Size = new Size(83, 25);
            Player2Label.TabIndex = 9;
            Player2Label.Text = "Player 2";
            Player2Label.Click += Player2Label_Click;
            // 
            // SelectMaxRound
            // 
            SelectMaxRound.FormattingEnabled = true;
            SelectMaxRound.Location = new Point(84, 260);
            SelectMaxRound.Name = "SelectMaxRound";
            SelectMaxRound.Size = new Size(121, 23);
            SelectMaxRound.TabIndex = 11;
            SelectMaxRound.SelectedIndexChanged += SelectMaxRound_SelectedIndexChanged;
            SelectMaxRound.KeyPress += SelectMaxRound_KeyPress;
            // 
            // WinLengthLabel
            // 
            WinLengthLabel.AutoSize = true;
            WinLengthLabel.BackColor = Color.Transparent;
            WinLengthLabel.FlatStyle = FlatStyle.Flat;
            WinLengthLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WinLengthLabel.ForeColor = Color.White;
            WinLengthLabel.Location = new Point(82, 194);
            WinLengthLabel.Name = "WinLengthLabel";
            WinLengthLabel.Size = new Size(80, 17);
            WinLengthLabel.TabIndex = 12;
            WinLengthLabel.Text = "Win Length";
            // 
            // SelectWinLength
            // 
            SelectWinLength.FormattingEnabled = true;
            SelectWinLength.Location = new Point(84, 214);
            SelectWinLength.Name = "SelectWinLength";
            SelectWinLength.Size = new Size(121, 23);
            SelectWinLength.TabIndex = 10;
            SelectWinLength.SelectedIndexChanged += SelectWinLength_SelectedIndexChanged;
            SelectWinLength.KeyPress += SelectWinLength_KeyPress;
            // 
            // ResetOptions
            // 
            ResetOptions.BackColor = Color.White;
            ResetOptions.Cursor = Cursors.Hand;
            ResetOptions.FlatAppearance.BorderSize = 0;
            ResetOptions.FlatStyle = FlatStyle.Flat;
            ResetOptions.Location = new Point(475, 405);
            ResetOptions.Name = "ResetOptions";
            ResetOptions.Size = new Size(123, 33);
            ResetOptions.TabIndex = 10;
            ResetOptions.Text = "Reset Options";
            ResetOptions.UseVisualStyleBackColor = false;
            ResetOptions.Click += ResetOptions_Click;
            // 
            // OptionScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ResetOptions);
            Controls.Add(panel1);
            Controls.Add(SaveTokens);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "OptionScreen";
            Text = "OptionScreen";
            FormClosed += OptionScreen_FormClosed;
            Load += OptionScreen_Load;
            ((System.ComponentModel.ISupportInitialize)Player1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Theme).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button LeftClick;
        private PictureBox Player1PictureBox;
        private PictureBox Player2PictureBox;
        private Button RightClick;
        private Button SaveTokens;
        private Label p1;
        private PictureBox Theme;
        private Panel panel1;
        private ComboBox SelectWinLength;
        private ComboBox SelectMaxRound;
        private Label WinLengthLabel;
        private Label MaxRoundLabel;
        private Label Player2Label;
        private Label GameSizeLabel;
        private ComboBox GameSizeCombobox;
        private Button ResetOptions;
    }
}