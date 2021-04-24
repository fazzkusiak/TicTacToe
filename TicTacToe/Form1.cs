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
            public static char[,] playground = { { 'a', 'b', 'c' }, { 'd', 'e', 'f'}, { 'g', 'h', 'i' } };
            public static bool isGame = true;
            public static int counter = 0;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void fillArray() 
        {
            var counter = 'A';
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
                textBox1.Text = "Player 1";
                return move;
            }
            else if (move == 'O')
            {
                Attr.move = 'X';
                textBox1.Text = "Player 2";
                return move;
            }
            else return 'l';

        }

      


        // win conditions
        private void checkPlayground()
        {
            if ((Attr.playground[0, 0] == Attr.playground[0, 1] && Attr.playground[0, 1] == Attr.playground[0, 2]) ||
                (Attr.playground[1, 0] == Attr.playground[1, 1] && Attr.playground[1, 1] == Attr.playground[1, 2]) ||
                (Attr.playground[2, 0] == Attr.playground[2, 1] && Attr.playground[2, 1] == Attr.playground[2, 2]) ||
                (Attr.playground[0, 0] == Attr.playground[1, 0] && Attr.playground[1, 0] == Attr.playground[2, 0]) ||
                (Attr.playground[0, 1] == Attr.playground[1, 1] && Attr.playground[1, 1] == Attr.playground[2, 1]) ||
                (Attr.playground[0, 2] == Attr.playground[1, 2] && Attr.playground[1, 2] == Attr.playground[2, 2]) ||
                (Attr.playground[0, 0] == Attr.playground[1, 1] && Attr.playground[1, 1] == Attr.playground[2, 2]) ||
                (Attr.playground[2, 0] == Attr.playground[1, 1] && Attr.playground[1, 1] == Attr.playground[0, 2]))
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


        private void btn_MouseClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {

               
                Attr.counter++;
                btn.Text = Convert.ToString(switchPlayer(Attr.move));

                //if (Attr.counter >= 5)
                checkPlayground();
                if (!Attr.isGame)
                {
                    giveMessage();
                }
                btn.UseVisualStyleBackColor = false;
                btn.BackColor = Color.Transparent;
                btn.Enabled = false;
                if (Attr.counter == 9)
                {
                    System.Windows.Forms.MessageBox.Show("game over, noone won");
                    System.Windows.Forms.Application.Exit();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Attr.playground[0, 0] = Attr.move;
            btn_MouseClick (sender, e);

          





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attr.playground[0, 1] = Attr.move;
            btn_MouseClick(sender, e);
          
          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Attr.playground[0, 2] = Attr.move;
            btn_MouseClick(sender, e);
            
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Attr.playground[1, 0] = Attr.move;
            btn_MouseClick(sender, e);
            
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Attr.playground[1, 1] = Attr.move;
            btn_MouseClick(sender, e);
           
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Attr.playground[1, 2] = Attr.move;
            btn_MouseClick(sender, e);
          
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Attr.playground[2, 0] = Attr.move;
            btn_MouseClick(sender, e);
          
           

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Attr.playground[2, 1] = Attr.move;
            btn_MouseClick(sender, e);
          
          

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Attr.playground[2, 2] = Attr.move;
            btn_MouseClick(sender, e);
          
           
        }

 

       
    }
}
     
