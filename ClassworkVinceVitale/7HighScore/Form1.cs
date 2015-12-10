using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _7HighScore
{
    public partial class GuessTheLetter : Form
    {
        const string FILENAME = @"C:\Users\Vince Vitale\Documents\Visual Studio 2015\Projects\Chapter14\7HighScore\GuessTheLetterHighScore.txt";
        int fileInfoInt = -1, highScore = -1, countRound = 0, userScore = 0, selected = 0;
        string fileInfoString = "", userLetter = "", randomLetter = "";
        bool previousHighScore = false, howToPlayButton = false;
        Random ranNumberGenerator = new Random();
        //FileStream must be static
        static FileStream highScoreFile = new FileStream(FILENAME, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        StreamReader reader = new StreamReader(highScoreFile);
        StreamWriter writter = new StreamWriter(highScoreFile);

        public GuessTheLetter()
        {
            InitializeComponent();
            MaximumSize = new Size(280, 280);
            btnPlayRound.Enabled = false;
        }
        
        private void clbUserGuess_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            selected = clbUserGuess.SelectedIndex;
            if (highScore == -1)
            {
                try
                {
                    highScoreFile.Seek(0, SeekOrigin.Begin);
                    fileInfoString = reader.ReadLine();
                    previousHighScore = int.TryParse(fileInfoString, out fileInfoInt);
                    if (previousHighScore == true)
                    {
                        lblHighScore.Text = "High Score: " + fileInfoString;
                        highScore = fileInfoInt;
                    }
                    else
                    {
                        highScore = 0;
                        lblHighScore.Text = "High Score: 0";
                    }
                }
                catch (Exception ex)
                {
                    lblHighScore.Text = "Exception: " + ex.Message;
                }
            }
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < clbUserGuess.Items.Count; ++ix)
                {
                    if (e.Index != ix) clbUserGuess.SetItemChecked(ix, false);
                }
            }
            try
            {
                if (selected != -1)
                {
                    switch (selected)
                    {
                        case 0:
                            userLetter = "A";
                            break;
                        case 1:
                            userLetter = "B";
                            break;
                        case 2:
                            userLetter = "C";
                            break;
                        default:
                            userLetter = "A";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                lblUserGuess.Text = "Exception: " + ex.Message;
            }
            if (e.NewValue == CheckState.Unchecked)
            {
                btnPlayRound.Enabled = false;
            }
            else
            {
                btnPlayRound.Enabled = true;
            }
        }
        
        private void btnPlayRound_Click(object sender, EventArgs e)
        {
            lblGuessAnswer.Visible = true;
            switch (ranNumberGenerator.Next(0, 3))
            {
                case 0:
                    randomLetter = "A";
                    break;
                case 1:
                    randomLetter = "B";
                    break;
                case 2:
                    randomLetter = "C";
                    break;
                default:
                    randomLetter = "A";
                    break;
            }
            ++countRound;
            btnPlayRound.Text = "Next Round";
            lblRound.Text = string.Format("Round: {0}", Convert.ToString(countRound));
            lblUserGuess.Text = string.Format("Your Guess: {0}", userLetter);
            lblRandomLetter.Text = string.Format("Random Letter: {0}", randomLetter);
            if (userLetter == randomLetter)
            {
                lblGuessAnswer.Text = "Correct Guess!!!";
                ++userScore;
            }
            else
            {
                lblGuessAnswer.Text = "Incorrect Guess";
            }
            lblUserScore.Text = string.Format("Score: {0}", Convert.ToString(userScore));
            if (countRound == 10)
            {
                if (userScore > highScore)
                {
                    lblNewHighScore.Text = "New High Score!!!";
                    btnPlayRound.Text = "=D";
                }
                else
                {
                    lblNewHighScore.Text = "Try again";
                    if (userScore <= 2)
                    {
                        btnPlayRound.Text = "R.I.P";
                    }
                    else
                    {
                        btnPlayRound.Text = "G_G";
                    }
                }
                if (userScore > highScore || highScore == 0)
                {
                    try
                    {
                        highScoreFile.Seek(0, SeekOrigin.Begin);
                        highScore = userScore;
                        writter.WriteLine(highScore);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: " + ex.Message);
                    }
                }
                btnPlayRound.Enabled = false;
                clbUserGuess.Enabled = false;
                lblNewHighScore.Visible = true;
                btnHowToPlay.Enabled = false;
                btnHowToPlay.Text = "Game over man";
                lblHowToPlay.Visible = false;
                MinimumSize = new Size(280, 280);
                MaximumSize = new Size(280, 280);
            }
        }
        
        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            if (howToPlayButton == false)
            {
                MinimumSize = new Size(280, 390);
                MaximumSize = new Size(280, 390);
                lblHowToPlay.Visible = true;
                btnHowToPlay.Text = "Hide Info";
                howToPlayButton = true;
            }
            else
            {
                MinimumSize = new Size(280, 280);
                MaximumSize = new Size(280, 280);
                lblHowToPlay.Visible = false;
                btnHowToPlay.Text = "How To Play";
                howToPlayButton = false;
            }
        }
    }
}
