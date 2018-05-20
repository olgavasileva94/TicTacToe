﻿using System;
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
        private int     TokenPlayer1;
        private int     TokenPlayer2;

        //constructors

        public LibraryTicTacToe()
        {
            this.CreateGameField(0);
            this.SetNamePlayer1("");
            this.SetNamePlayer2("");
            this.SetTokenPalyer1(1);
            this.SetTokenPalyer1(2);
        }

        ~LibraryTicTacToe()
        {

        }


        //setters

        private void SetSizeGameField(int Size)
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
            this.GameField[x, y] = Value;
        }

        public void SetTokenPalyer1(int Token)
        {
            this.TokenPlayer1 = Token;
        }

        public void SetTokenPalyer2(int Token)
        {
            this.TokenPlayer2 = Token;
        }

        //getters

        public int GetSizeGameField()
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
            return this.GameField[x, y];
        }

        public int GetTokenPlayer1()
        {
            return this.TokenPlayer1;
        }

        public int GetTokenPlayer2()
        {
            return this.TokenPlayer2;
        }

        //methods

        public void CreateGameField(int Size)
        {
            this.SetSizeGameField(Size);
            this.GameField = new int[Size, Size];
        }

        public void SetCellPlayer1(int x, int y)
        {
            this.SetCellValue(x, y, this.GetTokenPlayer1());
        }

        public void SetCellPlayer2(int x, int y)
        {
            this.SetCellValue(x, y, this.GetTokenPlayer2());
        }
    }
}
