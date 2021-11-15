using System;
using System.Collections.Generic;
using System.Text;

namespace Connect4
{
    public class BoardChecker : IWinner
    {
        //Game Board Variables
        public char[,] GameBoard = new char[6, 7];
        public char playerTurn = 'X';

        //Previous Game Variables
        public double XWins, OWins, totalGames = 0.00;
        public bool gameWinner = false;

        //Game Display Variables
        public string displayWinner = " ";
        public string[] records = { " ", " " };

        //Create field to hold Form1 object reference
        private Form1 mainForm;

        //Setup and clear GameBoard
        public BoardChecker(Form1 form1)
        {
            //Assign form and populate pictureBox array
            mainForm = form1;
            mainForm.populateGameBoard();

            //Since multidimensional arrays aren't enuerable, clear GameBoard the old fashioned way
            for (int i = 0; i < this.GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < this.GameBoard.GetLength(1); j++)
                {
                    this.GameBoard[i, j] = ' ';
                }
            }
        }

        //Progresses the game after a player's turn
        public void Accumulate(int r, int c)
        {
            //Check if column is full
            if (this.GameBoard[5, c] == ' ')
            {
                //Set gameboard to players turn (bottom most space)
                for (int i = this.GameBoard.GetLength(0) - 1; i >= 0; i--)
                {
                    if (this.GameBoard[i, c] == ' ')
                    {
                        r = i;
                    }
                }
                this.GameBoard[r, c] = this.playerTurn;

                //Check to see if there is a winner
                if (straightup(r, c) == true || straightdown(r, c) == true || left(r, c) == true || right(r, c) == true ||
                diagleftdown(r, c) == true || diagleftup(r, c) == true || diagrightdown(r, c) == true || diagrightup(r, c) == true)
                {
                    //WINNER!
                    this.gameWinner = true;

                    //Add win to proper player, increase game count, and set displays
                    if (this.playerTurn == 'X')
                    {
                        this.XWins++;
                        this.displayWinner = "Winner: X";
                    }
                    else
                    {
                        this.OWins++;
                        this.displayWinner = "Winner: O";
                    }
                    this.records[0] = "X wins: " + this.XWins;
                    this.records[1] = "O wins: " + this.OWins;
                    this.totalGames++;
                }

                //Change player's turn
                if (this.playerTurn == 'X')
                {
                    this.playerTurn = 'O';
                }
                else
                {
                    this.playerTurn = 'X';
                }

                //Update GameBoard
                mainForm.updateGameBoard(r, c);
            }
        }

        //find winner in column c going up starting from (r,c)
        public bool straightup(int r, int c)
        {
            //Stores how many placements a player has in a row
            int total = 0;

            //Checks if there are 4 in a row
            for (int i = 0; i < this.GameBoard.GetLength(0); i++)
            {
                if (this.GameBoard[i, c] == this.playerTurn)
                {
                    total++;
                    if (total == 4)
                    {
                        //Return true if there are 4 in a row
                        return true;
                    }
                }
                else
                {
                    //Reset total if condition fails
                    total = 0;
                }
            }

            //Return false if there has not been a return yet
            return false;
        }

        //Find winner in column c going down starting from (r,c)
        public bool straightdown(int r, int c)
        {
            //Since both look the same, just call straightup
            return straightup(r, c);
        }

        //find a winner in row r going left starting from (r,c)
        public bool left(int r, int c)
        {
            //Stores how many placements a player has in a row
            int total = 0;

            //Checks if there are 4 in a row
            for (int i = 0; i < this.GameBoard.GetLength(1); i++)
            {
                if (this.GameBoard[r, i] == this.playerTurn)
                {
                    total++;
                    if (total == 4)
                    {
                        //Return true if there are 4 in a row
                        return true;
                    }
                }
                else
                {
                    //Reset total if condition fails
                    total = 0;
                }
            }

            //Return false if there has not been a return yet
            return false;
        }

        //find a winner in row r going right starting from (r,c)
        public bool right(int r, int c)
        {
            //Since both look the same, just call left
            return left(r, c);
        }

        //find a winner in diagonal left going up starting from (r,c)
        public bool diagleftup(int r, int c)
        {
            //Stores how many placements a player has in a row
            int total = 0;

            //Sets point to bottom right in diagnal sequence
            while (r > 0 && c < this.GameBoard.GetLength(1) - 1)
            {
                r--;
                c++;
            }

            //Checks if there are 4 in a row
            for (int i = r, j = c; i < this.GameBoard.GetLength(0) && j > 0; i++, j--)
            {
                if (this.GameBoard[i, j] == this.playerTurn)
                {
                    total++;
                    if (total == 4)
                    {
                        //Return true if there are 4 in a row
                        return true;
                    }
                }
                else
                {
                    //Reset total if condition fails
                    total = 0;
                }
            }

            //Return false if there has not been a return yet
            return false;
        }

        //find a winner in diagonal right going down starting from(r, c)
        public bool diagrightdown(int r, int c)
        {
            //Since both look the same, just call diagleftup
            return diagleftup(r, c);
        }

        //find a winner in diagonal left going down starting from(r, c)
        public bool diagleftdown(int r, int c)
        {
            //Stores how many placements a player has in a row
            int total = 0;

            //Sets point to bottom right in diagnal sequence
            while (r > 0 && c > 0)
            {
                r--;
                c--;
            }

            //Checks if there are 4 in a row
            for (int i = r, j = c; i < this.GameBoard.GetLength(0) && j < this.GameBoard.GetLength(1); i++, j++)
            {
                if (this.GameBoard[i, j] == this.playerTurn)
                {
                    total++;
                    if (total == 4)
                    {
                        //Return true if there are 4 in a row
                        return true;
                    }
                }
                else
                {
                    //Reset total if condition fails
                    total = 0;
                }
            }

            //Return false if there has not been a return yet
            return false;
        }

        //find a winner in diagonal right going up starting from(r, c)
        public bool diagrightup(int r, int c)
        {
            //Since both look the same, just call diagleftdown
            return diagleftdown(r, c);
        }

        //return true if there is winner this function should use the previous one
        public bool winner()
        {
            return false;
        }
    }
}