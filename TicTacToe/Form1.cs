using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        static class Attr
        {
            static char player1 = 'O';
            static char player2 = 'X';
            public static char move = 'O';
            public static int[,] playground = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            public static bool isGame = true;
            public static int counter = 0;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void fillArray() 
        {
            var counter = 'a';
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Attr.playground[i, j] = counter;
                    counter++;
                }
            }

        }
        private char switchPlayer(char move)
        {
            if (Attr.move == 'X')
            {
                Attr.move = 'O';
                return move;
            }
            else if (move == 'O')
            {
                Attr.move = 'X';
                return move;
            }
            else return 'l';

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        // win conditions
        private void checkPlayground()
        {
            if (Attr.playground[0, 0] == Attr.playground[0, 1] && Attr.playground[0, 1] == Attr.playground[0, 2] ||
                Attr.playground[1, 0] == Attr.playground[1, 1] && Attr.playground[1, 1] == Attr.playground[1, 2] ||
                Attr.playground[2, 0] == Attr.playground[2, 1] && Attr.playground[2, 1] == Attr.playground[2, 2] ||
                Attr.playground[0, 0] == Attr.playground[1, 0] && Attr.playground[1, 0] == Attr.playground[2, 0] ||
                Attr.playground[0, 1] == Attr.playground[1, 1] && Attr.playground[1, 1] == Attr.playground[2, 1] ||
                Attr.playground[0, 2] == Attr.playground[1, 2] && Attr.playground[1, 2] == Attr.playground[2, 2] ||
                Attr.playground[0, 0] == Attr.playground[1, 1] && Attr.playground[1, 1] == Attr.playground[2, 2] ||
                Attr.playground[2, 0] == Attr.playground[1, 1] && Attr.playground[1, 1] == Attr.playground[0, 2])
            {
                Attr.isGame = false;
            }
            else Attr.isGame = true;


        }

        private void giveMessage()
        {
            var winner = "";

            if (Attr.move == 'X')
            {
                winner = "player 1";

            }
            else if (Attr.move == 'O')
            {
                winner = "player 2";
            }
            System.Windows.Forms.MessageBox.Show("game over, " + winner + " won the game");
            System.Windows.Forms.Application.Exit();
        }


        void Button_Click(object sender, EventArgs e)
        {

        }
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.UseVisualStyleBackColor = false;
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Attr.counter++;
            Attr.playground[0, 0] = Attr.move;
            button1.Text = Convert.ToString(switchPlayer(Attr.move));
           
           


        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Attr.counter++;
            Attr.playground[0, 1] = Attr.move;
            button2.Text = Convert.ToString(switchPlayer(Attr.move));
            if (Attr.counter >= 5) checkPlayground();
            if (!Attr.isGame)
            {
                giveMessage();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Attr.counter++;
            Attr.playground[0, 2] = Attr.move;
            button3.Text = Convert.ToString(switchPlayer(Attr.move));
            if (Attr.counter >= 5) checkPlayground();
            if (!Attr.isGame)
            {
                giveMessage();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Attr.counter++;
            Attr.playground[1, 0] = Attr.move;
            button4.Text = Convert.ToString(switchPlayer(Attr.move));
            if (Attr.counter >= 5) checkPlayground();
            if (!Attr.isGame)
            {
                giveMessage();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Attr.counter++;
            Attr.playground[1, 1] = Attr.move;
            button5.Text = Convert.ToString(switchPlayer(Attr.move));
            if (Attr.counter >= 5) checkPlayground();
            if (!Attr.isGame)
            {
                giveMessage();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Attr.counter++;
            Attr.playground[1, 2] = Attr.move;
            button6.Text = Convert.ToString(switchPlayer(Attr.move));
            if (Attr.counter >= 5) checkPlayground();
            if (!Attr.isGame)
            {
                giveMessage();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Attr.counter++;
            Attr.playground[2, 0] = Attr.move;
            button7.Text = Convert.ToString(switchPlayer(Attr.move));
            if (Attr.counter >= 5) checkPlayground();
            if (!Attr.isGame)
            {
                giveMessage();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Attr.counter++;
            Attr.playground[2, 1] = Attr.move;
            button8.Text = Convert.ToString(switchPlayer(Attr.move));
            if (Attr.counter >= 5) checkPlayground();
            if (!Attr.isGame)
            {
                giveMessage();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Attr.counter++;
            Attr.playground[2, 2] = Attr.move;
            button9.Text = Convert.ToString(switchPlayer(Attr.move));
            if(Attr.counter >= 6) checkPlayground();

            if (!Attr.isGame)
            {
                giveMessage();
            }

        }

    }
}
     
