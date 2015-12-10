namespace _7HighScore
{
    partial class GuessTheLetter
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
            //manually added to close file
            writter.Close();
            reader.Close();
            highScoreFile.Close();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessTheLetter));
            this.lblHighScore = new System.Windows.Forms.Label();
            this.btnPlayRound = new System.Windows.Forms.Button();
            this.lblRandomLetter = new System.Windows.Forms.Label();
            this.lblUserGuess = new System.Windows.Forms.Label();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.lblGuessAnswer = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblNextGuess = new System.Windows.Forms.Label();
            this.lblNewHighScore = new System.Windows.Forms.Label();
            this.clbUserGuess = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(12, 9);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(72, 13);
            this.lblHighScore.TabIndex = 0;
            this.lblHighScore.Text = "High Score: 0";
            // 
            // btnPlayRound
            // 
            this.btnPlayRound.Location = new System.Drawing.Point(133, 122);
            this.btnPlayRound.Name = "btnPlayRound";
            this.btnPlayRound.Size = new System.Drawing.Size(119, 37);
            this.btnPlayRound.TabIndex = 1;
            this.btnPlayRound.Text = "Play";
            this.btnPlayRound.UseVisualStyleBackColor = true;
            this.btnPlayRound.Click += new System.EventHandler(this.btnPlayRound_Click);
            // 
            // lblRandomLetter
            // 
            this.lblRandomLetter.AutoSize = true;
            this.lblRandomLetter.Location = new System.Drawing.Point(130, 33);
            this.lblRandomLetter.Name = "lblRandomLetter";
            this.lblRandomLetter.Size = new System.Drawing.Size(83, 13);
            this.lblRandomLetter.TabIndex = 4;
            this.lblRandomLetter.Text = "Random Letter: ";
            // 
            // lblUserGuess
            // 
            this.lblUserGuess.AutoSize = true;
            this.lblUserGuess.Location = new System.Drawing.Point(130, 9);
            this.lblUserGuess.Name = "lblUserGuess";
            this.lblUserGuess.Size = new System.Drawing.Size(68, 13);
            this.lblUserGuess.TabIndex = 5;
            this.lblUserGuess.Text = "Your Guess: ";
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.Location = new System.Drawing.Point(12, 239);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(241, 108);
            this.lblHowToPlay.TabIndex = 6;
            this.lblHowToPlay.Text = resources.GetString("lblHowToPlay.Text");
            this.lblHowToPlay.Visible = false;
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Location = new System.Drawing.Point(15, 213);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(109, 23);
            this.btnHowToPlay.TabIndex = 7;
            this.btnHowToPlay.Text = "HowToPlay";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // lblGuessAnswer
            // 
            this.lblGuessAnswer.AutoSize = true;
            this.lblGuessAnswer.Location = new System.Drawing.Point(130, 57);
            this.lblGuessAnswer.Name = "lblGuessAnswer";
            this.lblGuessAnswer.Size = new System.Drawing.Size(41, 13);
            this.lblGuessAnswer.TabIndex = 8;
            this.lblGuessAnswer.Text = "Correct";
            this.lblGuessAnswer.Visible = false;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(12, 57);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(51, 13);
            this.lblRound.TabIndex = 9;
            this.lblRound.Text = "Round: 0";
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Location = new System.Drawing.Point(12, 33);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(47, 13);
            this.lblUserScore.TabIndex = 10;
            this.lblUserScore.Text = "Score: 0";
            // 
            // lblNextGuess
            // 
            this.lblNextGuess.Location = new System.Drawing.Point(12, 89);
            this.lblNextGuess.Name = "lblNextGuess";
            this.lblNextGuess.Size = new System.Drawing.Size(112, 18);
            this.lblNextGuess.TabIndex = 11;
            this.lblNextGuess.Text = "Enter your next guess ";
            // 
            // lblNewHighScore
            // 
            this.lblNewHighScore.AutoSize = true;
            this.lblNewHighScore.Location = new System.Drawing.Point(12, 181);
            this.lblNewHighScore.Name = "lblNewHighScore";
            this.lblNewHighScore.Size = new System.Drawing.Size(94, 13);
            this.lblNewHighScore.TabIndex = 12;
            this.lblNewHighScore.Text = "New High Score!!!";
            this.lblNewHighScore.Visible = false;
            // 
            // clbUserGuess
            // 
            this.clbUserGuess.CheckOnClick = true;
            this.clbUserGuess.FormattingEnabled = true;
            this.clbUserGuess.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.clbUserGuess.Location = new System.Drawing.Point(15, 110);
            this.clbUserGuess.Name = "clbUserGuess";
            this.clbUserGuess.Size = new System.Drawing.Size(109, 49);
            this.clbUserGuess.TabIndex = 13;
            this.clbUserGuess.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbUserGuess_ItemCheck);
            // 
            // GuessTheLetter
            // 
            this.AcceptButton = this.btnPlayRound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 352);
            this.Controls.Add(this.clbUserGuess);
            this.Controls.Add(this.lblNewHighScore);
            this.Controls.Add(this.lblNextGuess);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblGuessAnswer);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.lblHowToPlay);
            this.Controls.Add(this.lblUserGuess);
            this.Controls.Add(this.lblRandomLetter);
            this.Controls.Add(this.btnPlayRound);
            this.Controls.Add(this.lblHighScore);
            this.MaximumSize = new System.Drawing.Size(280, 390);
            this.MinimumSize = new System.Drawing.Size(280, 280);
            this.Name = "GuessTheLetter";
            this.Text = "Guess The Letter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblRandomLetter;
        private System.Windows.Forms.Label lblUserGuess;
        private System.Windows.Forms.Label lblGuessAnswer;
        private System.Windows.Forms.Button btnPlayRound;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Label lblNextGuess;
        private System.Windows.Forms.Label lblNewHighScore;
        private System.Windows.Forms.CheckedListBox clbUserGuess;
    }
}

