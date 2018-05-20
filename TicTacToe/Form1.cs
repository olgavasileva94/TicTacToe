using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTicTacToe;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Random rand;
        private LibraryTicTacToe Library;
        private int step;

        public Form1()
        {
            this.rand = new Random();
            InitializeComponent();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Library = new LibraryTicTacToe();
            this.Library.CreateGameField(3);
            int rand = this.rand.Next(0, 100);

            if (rand < 50)
            {
                this.step = 1;
            }
            else
            {
                this.step = 2;
            }

            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            this.button10.Enabled = true;

            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";
            this.button10.Text = "";

            this.textBox6.Text = "";

            this.panel1.Enabled = true;
            this.panel1.Visible = true;
            this.panel2.Enabled = false;
            this.panel2.Visible = false;
            this.panel3.Enabled = false;
            this.panel3.Visible = false;
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Library = new LibraryTicTacToe();
            this.Library.CreateGameField(4);
            int rand = this.rand.Next(0, 100);

            if (rand < 50)
            {
                this.step = 1;
            }
            else
            {
                this.step = 2;
            }

            this.button11.Enabled = true;
            this.button12.Enabled = true;
            this.button13.Enabled = true;
            this.button14.Enabled = true;
            this.button15.Enabled = true;
            this.button16.Enabled = true;
            this.button17.Enabled = true;
            this.button18.Enabled = true;
            this.button19.Enabled = true;
            this.button20.Enabled = true;
            this.button21.Enabled = true;
            this.button22.Enabled = true;
            this.button23.Enabled = true;
            this.button24.Enabled = true;
            this.button25.Enabled = true;
            this.button26.Enabled = true;

            this.button11.Text = "";
            this.button12.Text = "";
            this.button13.Text = "";
            this.button14.Text = "";
            this.button15.Text = "";
            this.button16.Text = "";
            this.button17.Text = "";
            this.button18.Text = "";
            this.button19.Text = "";
            this.button20.Text = "";
            this.button21.Text = "";
            this.button22.Text = "";
            this.button23.Text = "";
            this.button24.Text = "";
            this.button25.Text = "";
            this.button26.Text = "";

            this.textBox5.Text = "";

            this.panel1.Enabled = true;
            this.panel1.Visible = true;
            this.panel2.Enabled = false;
            this.panel2.Visible = false;
            this.panel3.Enabled = false;
            this.panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String PlayerName1 = this.textBox1.Text;
            if (PlayerName1.Length == 0)
            {
                PlayerName1 = "Player1";
            }

            String PlayerName2 = this.textBox2.Text;
            if (PlayerName2.Length == 0)
            {
                PlayerName2 = "Player2";
            }

            if (PlayerName1 == PlayerName2)
            {
                PlayerName1 = PlayerName1 + "1";
                PlayerName2 = PlayerName2 + "2";
            }

            int IntTokenPlayer1 = 0;
            String PlayerToken1 = this.comboBox1.Text;
            if (PlayerToken1.Length == 0)
            {
                IntTokenPlayer1 = 1;
            }
            else
            {
                IntTokenPlayer1 = this.getIntToken(PlayerToken1);
            }

            int IntTokenPlayer2 = 0;
            String PlayerToken2 = this.comboBox2.Text;
            if (PlayerToken1.Length == 0)
            {
                IntTokenPlayer2 = 5;
            }
            else
            {
                IntTokenPlayer2 = this.getIntToken(PlayerToken2);
            }

            bool result = false;

            this.Library.SetNamePlayer1(PlayerName1);
            this.Library.SetNamePlayer2(PlayerName2);
            result = this.Library.SetTokenPalyer1(IntTokenPlayer1);
            if (!result)
            {
                throw new Exception("Error `SetTokenPalyer1`");
            }
            result = this.Library.SetTokenPalyer2(IntTokenPlayer2);
            if (!result)
            {
                throw new Exception("Error `SetTokenPalyer2`");
            }

            if (this.Library.GetSizeGameField() == 3)
            {
                this.panel1.Enabled = false;
                this.panel1.Visible = false;
                this.panel2.Enabled = true;
                this.panel2.Visible = true;
                this.panel3.Enabled = false;
                this.panel3.Visible = false;

                if (this.step == 1)
                {
                    this.textBox3.Text = this.Library.GetNamePlayer1();
                }
                if (this.step == 2)
                {
                    this.textBox3.Text = this.Library.GetNamePlayer2();
                }
            }

            if (this.Library.GetSizeGameField() == 4)
            {
                this.panel1.Enabled = false;
                this.panel1.Visible = false;
                this.panel2.Enabled = false;
                this.panel2.Visible = false;
                this.panel3.Enabled = true;
                this.panel3.Visible = true;

                if (this.step == 1)
                {
                    this.textBox4.Text = this.Library.GetNamePlayer1();
                }
                if (this.step == 2)
                {
                    this.textBox4.Text = this.Library.GetNamePlayer2();
                }
            }
        }

        private String getStrToken(int IntToken)
        {
            if (IntToken == 1)
            {
                return "Z";
            }
            if (IntToken == 2)
            {
                return "X";
            }
            if (IntToken == 3)
            {
                return "C";
            }
            if (IntToken == 4)
            {
                return "V";
            }
            if (IntToken == 5)
            {
                return "O";
            }
            if (IntToken == 6)
            {
                return "I";
            }
            if (IntToken == 7)
            {
                return "U";
            }
            if (IntToken == 8)
            {
                return "Y";
            }

            return "-";
        }

        private int getIntToken(String StrToken)
        {
            if (StrToken == "Z")
            {
                return 1;
            }
            if (StrToken == "X")
            {
                return 2;
            }
            if (StrToken == "C")
            {
                return 3;
            }
            if (StrToken == "V")
            {
                return 4;
            }
            if (StrToken == "O")
            {
                return 5;
            }
            if (StrToken == "I")
            {
                return 6;
            }
            if (StrToken == "U")
            {
                return 7;
            }
            if (StrToken == "Y")
            {
                return 8;
            }

            return 0;
        }

        private void setCell3(int x, int y, System.Windows.Forms.Button button)
        {
            if (this.step == 1)
            {
                button.Text = this.getStrToken(this.Library.GetTokenPlayer1());
                button.Enabled = false;
                if (!this.Library.SetCellPlayer1(x, y))
                {
                    throw new Exception("Error `SetCellPlayer1`");
                }

                if (this.Library.GameIsOver())
                {
                    this.textBox6.Text = this.Library.GetWinPlayerName();
                    this.panel2.Enabled = false;
                }
                else
                {
                    this.textBox3.Text = this.Library.GetNamePlayer2();
                    this.step = 2;
                }

                return;
            }
            if (this.step == 2)
            {
                button.Text = this.getStrToken(this.Library.GetTokenPlayer2());
                button.Enabled = false;
                if (!this.Library.SetCellPlayer2(x, y))
                {
                    throw new Exception("Error `SetCellPlayer2`");
                }

                if (this.Library.GameIsOver())
                {
                    this.textBox6.Text = this.Library.GetWinPlayerName();
                    this.panel2.Enabled = false;
                }
                else
                {
                    this.textBox3.Text = this.Library.GetNamePlayer1();
                    this.step = 1;
                }

                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.setCell3(0, 0, this.button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.setCell3(0, 1, this.button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.setCell3(0, 2, this.button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.setCell3(1, 0, this.button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.setCell3(1, 1, this.button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.setCell3(1, 2, this.button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.setCell3(2, 0, this.button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.setCell3(2, 1, this.button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.setCell3(2, 2, this.button10);
        }

        private void setCell4(int x, int y, System.Windows.Forms.Button button)
        {
            if (this.step == 1)
            {
                button.Text = this.getStrToken(this.Library.GetTokenPlayer1());
                button.Enabled = false;
                if (!this.Library.SetCellPlayer1(x, y))
                {
                    throw new Exception("Error `SetCellPlayer1`");
                }

                if (this.Library.GameIsOver())
                {
                    this.textBox5.Text = this.Library.GetWinPlayerName();
                    this.panel3.Enabled = false;
                }
                else
                {
                    this.textBox4.Text = this.Library.GetNamePlayer2();
                    this.step = 2;
                }

                return;
            }
            if (this.step == 2)
            {
                button.Text = this.getStrToken(this.Library.GetTokenPlayer2());
                button.Enabled = false;
                if (!this.Library.SetCellPlayer2(x, y))
                {
                    throw new Exception("Error `SetCellPlayer2`");
                }

                if (this.Library.GameIsOver())
                {
                    this.textBox5.Text = this.Library.GetWinPlayerName();
                    this.panel3.Enabled = false;
                }
                else
                {
                    this.textBox4.Text = this.Library.GetNamePlayer1();
                    this.step = 1;
                }

                return;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.setCell4(0, 0, this.button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.setCell4(0, 1, this.button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.setCell4(0, 2, this.button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.setCell4(0, 3, this.button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.setCell4(1, 0, this.button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.setCell4(1, 1, this.button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.setCell4(1, 2, this.button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.setCell4(1, 3, this.button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.setCell4(2, 0, this.button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.setCell4(2, 1, this.button20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.setCell4(2, 2, this.button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.setCell4(2, 3, this.button22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.setCell4(3, 0, this.button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.setCell4(3, 1, this.button24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.setCell4(3, 2, this.button25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.setCell4(3, 3, this.button26);
        }
    }
}
