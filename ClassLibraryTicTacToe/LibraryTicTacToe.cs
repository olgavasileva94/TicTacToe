using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicTacToe
{
    public class LibraryTicTacToe
    {
        private int     SizeGameField;
        private int[,]  GameField;
        private String  NamePlayer1;
        private String  NamePlayer2;

        //constructors

        public LibraryTicTacToe()
        {
            this.SizeGameField = 0;
            this.GameField     = new int[this.SizeGameField, this.SizeGameField];
            this.NamePlayer1   = "";
            this.NamePlayer2   = "";
        }

        ~LibraryTicTacToe()
        {

        }


        //setters

        public void setSizeGameField(int Size)
        {
            this.SizeGameField = 3;
        }

        public void SetNamePlayer1(String Name)
        {
            this.NamePlayer1 = Name;
        }

        public void SetNamePlayer2(String Name)
        {
            this.NamePlayer2 = Name;
        }

        //getters

        public int getSizeGameField()
        {
            return this.SizeGameField;
        }

        public String GetNamePlayer1()
        {
            return this.NamePlayer1;
        }

        public String GetNamePlayer2()
        {
            return this.NamePlayer2;
        }

        //methods

        public void CreateGameField(int Size)
        {
            this.setSizeGameField(Size);
            this.GameField = new int[Size, Size];
        }
    }
}
