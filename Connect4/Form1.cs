using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {
        //Initialize game objects
        BoardChecker game;
        private void Form1_Load(object sender, EventArgs e)
        {
            // instantiate Class1 and pass it a reference to Form1
            this.game = new BoardChecker(this);
        }
        PictureBox[,] GameBoard = new PictureBox[6, 7];

        public Form1()
        {
            InitializeComponent();
        }

        //Update the GameBoard image and textBox displays
        public void updateGameBoard(int r, int c)
        {
            //Update GameBoard image
            try
            {
                //Use r and c cordinates to update image
                GameBoard[r, c].Image = Image.FromFile(Application.StartupPath + "\\" + game.playerTurn + ".png");
            }
            catch
            {
                //Inform user that there has been an error
                textBox1.Text = "Error displaying image.";
            }

            //Update textBoxes
            textBox1.Text = Convert.ToString(game.playerTurn);
            if (game.gameWinner == true)
            {
                textBox2.Text = game.displayWinner;
                textBox3.Lines = game.records;
            }
        }

        private void clearGameBoard()
        {
            //Clear images and placements
            for (int i = 0; i < this.GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < this.GameBoard.GetLength(1); j++)
                {
                    GameBoard[i, j].Image = null;
                    game.GameBoard[i, j] = ' ';
                }
            }

            //Clear and reset displays
            game.playerTurn = 'X';
            textBox1.Text = Convert.ToString(game.playerTurn);

            game.displayWinner = " ";
            textBox2.Text = game.displayWinner;

            textBox3.Lines = game.records;

            //Reset gameWinner
            game.gameWinner = false;
        }

        //Play again button
        private void button1_Click(object sender, EventArgs e)
        {
            if (game.gameWinner == true)
            {
                clearGameBoard();
            }
        }

        //Reset button
        private void button2_Click(object sender, EventArgs e)
        {
            //Reset any remaining values
            game.XWins = 0;
            game.OWins = 0;
            game.totalGames = 0;
            game.records[0] = " "; game.records[1] = " ";

            clearGameBoard();
        }

        

        /** Wasteland Code **/
        private void pictureBox0_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(0, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(1, 0);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(2, 0);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(3, 0);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(4, 0);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(5, 0);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(0, 1);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(1, 1);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(2, 1);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(3, 1);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(4, 1);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(5, 1);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(0, 2);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(1, 2);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(2, 2);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(3, 2);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(4, 2);
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(5, 2);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(0, 3);
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(1, 3);
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(2, 3);
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(3, 3);
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(4, 3);
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(5, 3);
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(0, 4);
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(1, 4);
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(2, 4);
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(3, 4);
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(4, 4);
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(5, 4);
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(0, 5);
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(1, 5);
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(2, 5);
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(3, 5);
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(4, 5);
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(5, 5);
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(0, 6);
            }
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(1, 6);
            }
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(2, 6);
            }
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(3, 6);
            }
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(4, 6);
            }
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            //Call Accumulate function and give cordinates
            if (game.gameWinner == false)
            {
                game.Accumulate(5, 6);
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Load GameBoard object on start
        public void populateGameBoard()
        {
            //Column 0
            this.GameBoard[0, 0] = pictureBox0;
            this.GameBoard[1, 0] = pictureBox1;
            this.GameBoard[2, 0] = pictureBox2;
            this.GameBoard[3, 0] = pictureBox3;
            this.GameBoard[4, 0] = pictureBox4;
            this.GameBoard[5, 0] = pictureBox5;

            //Column 1
            this.GameBoard[0, 1] = pictureBox6;
            this.GameBoard[1, 1] = pictureBox7;
            this.GameBoard[2, 1] = pictureBox8;
            this.GameBoard[3, 1] = pictureBox9;
            this.GameBoard[4, 1] = pictureBox10;
            this.GameBoard[5, 1] = pictureBox11;

            //Column 2
            this.GameBoard[0, 2] = pictureBox12;
            this.GameBoard[1, 2] = pictureBox13;
            this.GameBoard[2, 2] = pictureBox14;
            this.GameBoard[3, 2] = pictureBox15;
            this.GameBoard[4, 2] = pictureBox16;
            this.GameBoard[5, 2] = pictureBox17;

            //Column 3
            this.GameBoard[0, 3] = pictureBox18;
            this.GameBoard[1, 3] = pictureBox19;
            this.GameBoard[2, 3] = pictureBox20;
            this.GameBoard[3, 3] = pictureBox21;
            this.GameBoard[4, 3] = pictureBox22;
            this.GameBoard[5, 3] = pictureBox23;

            //Column 4
            this.GameBoard[0, 4] = pictureBox24;
            this.GameBoard[1, 4] = pictureBox25;
            this.GameBoard[2, 4] = pictureBox26;
            this.GameBoard[3, 4] = pictureBox27;
            this.GameBoard[4, 4] = pictureBox28;
            this.GameBoard[5, 4] = pictureBox29;

            //Column 5
            this.GameBoard[0, 5] = pictureBox30;
            this.GameBoard[1, 5] = pictureBox31;
            this.GameBoard[2, 5] = pictureBox32;
            this.GameBoard[3, 5] = pictureBox33;
            this.GameBoard[4, 5] = pictureBox34;
            this.GameBoard[5, 5] = pictureBox35;

            //Column 6
            this.GameBoard[0, 6] = pictureBox36;
            this.GameBoard[1, 6] = pictureBox37;
            this.GameBoard[2, 6] = pictureBox38;
            this.GameBoard[3, 6] = pictureBox39;
            this.GameBoard[4, 6] = pictureBox40;
            this.GameBoard[5, 6] = pictureBox41;
        }

        
    }
}
