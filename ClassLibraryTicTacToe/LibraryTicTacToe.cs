using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicTacToe
{
    public class LibraryTicTacToe
    {
        private int[,]  GameField;
        private String  NamePlayer1;
        private String  NamePlayer2;

        //constructors

        public LibraryTicTacToe()
        {
            this.NamePlayer1 = "";
            this.NamePlayer2 = "";
            this.GameField = new int[0,0];
        }

        ~LibraryTicTacToe()
        {

        }


        //setters

        public void SetNamePlayer1(String Name)
        {
            this.NamePlayer1 = Name;
        }

        public void SetNamePlayer2(String Name)
        {
            this.NamePlayer2 = Name;
        }

        //getters

        public String GetNamePlayer1()
        {
            return this.NamePlayer1;
        }

        public String GetNamePlayer2()
        {
            return this.NamePlayer2;
        }

        //methods

        public void CreateGameField(int size)
        {
            this.GameField = new int[size, size];
        }

        public int getSizeGameField()
        {
            return Convert.ToInt32(Math.Sqrt(Convert.ToDouble(this.GameField.Length)));
        }
    }
}
