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
            this.CreateGameField(0);
            this.SetNamePlayer1("");
            this.SetNamePlayer2("");
        }

        ~LibraryTicTacToe()
        {

        }


        //setters

        private void setSizeGameField(int Size)
        {
            this.SizeGameField = Size;
        }

        public void SetNamePlayer1(String Name)
        {
            this.NamePlayer1 = Name;
        }

        public void SetNamePlayer2(String Name)
        {
            this.NamePlayer2 = Name;
        }

        public void SetCellValue(int x, int y, int Value)
        {
            this.GameField[x, y] = 1;
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

        public int GetCellValue(int x, int y)
        {
            return 1;
        }

        //methods

        public void CreateGameField(int Size)
        {
            this.setSizeGameField(Size);
            this.GameField = new int[Size, Size];
        }
    }
}
