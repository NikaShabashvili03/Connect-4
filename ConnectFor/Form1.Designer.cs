namespace ConnectFor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoadGame = new Button();
            Options = new Button();
            creator = new Button();
            SuspendLayout();
            // 
            // LoadGame
            // 
            LoadGame.BackColor = Color.FromArgb(208, 7, 0);
            LoadGame.BackgroundImageLayout = ImageLayout.Stretch;
            LoadGame.Cursor = Cursors.Hand;
            LoadGame.FlatAppearance.BorderSize = 0;
            LoadGame.FlatStyle = FlatStyle.Flat;
            LoadGame.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadGame.ForeColor = Color.FromArgb(255, 222, 0);
            LoadGame.Location = new Point(459, 267);
            LoadGame.Name = "LoadGame";
            LoadGame.Size = new Size(90, 90);
            LoadGame.TabIndex = 0;
            LoadGame.Text = "Start";
            LoadGame.UseVisualStyleBackColor = false;
            LoadGame.Click += LoadGame_Click;
            // 
            // Options
            // 
            Options.BackColor = Color.FromArgb(255, 222, 0);
            Options.BackgroundImageLayout = ImageLayout.Stretch;
            Options.Cursor = Cursors.Hand;
            Options.FlatAppearance.BorderSize = 0;
            Options.FlatStyle = FlatStyle.Flat;
            Options.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Options.ForeColor = Color.FromArgb(208, 7, 0);
            Options.Location = new Point(226, 118);
            Options.Name = "Options";
            Options.Size = new Size(90, 90);
            Options.TabIndex = 2;
            Options.Text = "Options";
            Options.UseVisualStyleBackColor = false;
            Options.Click += Options_Click;
            // 
            // creator
            // 
            creator.BackColor = Color.White;
            creator.Cursor = Cursors.Hand;
            creator.FlatAppearance.BorderSize = 0;
            creator.FlatStyle = FlatStyle.Flat;
            creator.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            creator.Location = new Point(629, 406);
            creator.Name = "creator";
            creator.Size = new Size(159, 32);
            creator.TabIndex = 3;
            creator.Text = "Create by Nika";
            creator.UseVisualStyleBackColor = false;
            creator.Click += creator_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ConnectFourLogoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(creator);
            Controls.Add(Options);
            Controls.Add(LoadGame);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            FormClosed += MenuScreenClose;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button LoadGame;
        private Button Options;
        private Button creator;
    }
}
