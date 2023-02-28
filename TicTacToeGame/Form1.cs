using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] gameBoard = new string[9];
        int currentTurn = 0;

        public String returnSymbol(int turn)
        {
            if(turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public System.Drawing.Color determineColor(String symbol)
        {
            if (symbol.Equals("O"))
            {
                return System.Drawing.Color.LightGreen;
            }
            else if(symbol.Equals("X"))
            {
                return System.Drawing.Color.LightBlue;
            }
            return System.Drawing.Color.White;
        }

        public void checkForWinner()
        {
            for (int i=0; i<8; i++)
            {
                String combination = "";
                int one = 0, two = 0, three = 0;


                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                     case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                     case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                     case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        one = 3;
                        two = 4;
                        three = 5;
                        break;
                     case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        one = 6;
                        two = 7;
                        three = 8;
                        break;
                     case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        one = 0;
                        two = 3;
                        three = 6;
                        break;
                     case 6:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[7];
                        one = 2;
                        two = 4;
                        three = 7;
                        break;
                     case 7:
                        combination = gameBoard[3] + gameBoard[5] + gameBoard[8];
                        one = 3;
                        two = 5;
                        three = 8;
                        break;
                }

                if (combination.Equals("OOO"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);
                    MessageBox.Show("O has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(combination.Equals("XXX"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);
                    MessageBox.Show("X has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                checkDraw();
            }
        }

        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
            gameBoard = new string[9];
            currentTurn = 0;

        }

        public void changeColor(int number)
        {
            switch (number)
            {
                case 0:
                    button1.BackColor = System.Drawing.Color.Red; break;
                case 1:
                    button2.BackColor = System.Drawing.Color.Red; break;
                case 2:
                    button3.BackColor = System.Drawing.Color.Red; break;
                case 3:
                    button4.BackColor = System.Drawing.Color.Red; break;
                case 4:
                    button5.BackColor = System.Drawing.Color.Red; break;
                case 5:
                    button6.BackColor = System.Drawing.Color.Red; break;
                case 6:
                    button7.BackColor = System.Drawing.Color.Red; break;
                case 7:
                    button8.BackColor = System.Drawing.Color.Red; break;
                case 8:
                    button9.BackColor = System.Drawing.Color.Red; break;
            }
        }

        public void checkDraw()
        {
            int counter = 0;
            for(int i=0; i<gameBoard.Length; i++)
            {
                if (gameBoard[i] != null) { counter++; }

                if (counter == 9)
                {
                    reset();
                    MessageBox.Show("That's a draw!", "No winner today", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[0] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[0]);
            button1.BackColor = buttonColor;
            button1.Text = gameBoard[0];
            checkForWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[1] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[1]);
            button2.BackColor = buttonColor;
            button2.Text = gameBoard[1];
            checkForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[2] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[2]);
            button3.BackColor = buttonColor;
            button3.Text = gameBoard[2];
            checkForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[3] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[3]);
            button4.BackColor = buttonColor;
            button4.Text = gameBoard[3];
            checkForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[4] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[4]);
            button5.BackColor = buttonColor;
            button5.Text = gameBoard[4];
            checkForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[5] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[5]);
            button6.BackColor = buttonColor;
            button6.Text = gameBoard[5];
            checkForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[6] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[6]);
            button7.BackColor = buttonColor;
            button7.Text = gameBoard[6];
            checkForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[7] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[7]);
            button8.BackColor = buttonColor;
            button8.Text = gameBoard[7];
            checkForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[8] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[8]);
            button9.BackColor = buttonColor;
            button9.Text = gameBoard[8];
            checkForWinner();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
