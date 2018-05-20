﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicTacToe;


namespace UnitTestTicTacToe
{
    [TestClass]
    public class UnitTestTicTacToe
    {
        [TestMethod]
        public void TestMethod_SetPlayerName()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            String TestName1 = "Olga1";
            String TestName2 = "Olga2";

            Library.SetNamePlayer1(TestName1);
            Library.SetNamePlayer2(TestName2);

            Assert.AreEqual(TestName1, Library.GetNamePlayer1());
            Assert.AreEqual(TestName2, Library.GetNamePlayer2());
        }

        [TestMethod]
        public void TestMethod_SetPlayerName_1()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            String TestName1 = "Player1";
            String TestName2 = "Player2";

            Library.SetNamePlayer1(TestName1);
            Library.SetNamePlayer2(TestName2);

            Assert.AreEqual(TestName1, Library.GetNamePlayer1());
            Assert.AreEqual(TestName2, Library.GetNamePlayer2());
        }

        [TestMethod]
        public void TestMethod_CreateGameField()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;

            Library.CreateGameField(TestSize);

            Assert.AreEqual(TestSize, Library.GetSizeGameField());
        }

        [TestMethod]
        public void TestMethod_CreateGameField_1()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 4;

            Library.CreateGameField(TestSize);

            Assert.AreEqual(TestSize, Library.GetSizeGameField());
        }

        [TestMethod]
        public void TestMethod_SetCellValue()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize  = 3;
            int TestX     = 0;
            int TestY     = 0;
            int TestValue = 4;

            Library.CreateGameField(TestSize);
            Library.SetCellValue(TestX, TestY, TestValue);

            Assert.AreEqual(TestValue, Library.GetCellValue(TestX, TestY));
        }

        [TestMethod]
        public void TestMethod_SetCellValue_1()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestX = 0;
            int TestY = 0;
            int TestValue = 3;

            Library.CreateGameField(TestSize);
            Library.SetCellValue(TestX, TestY, TestValue);

            Assert.AreEqual(TestValue, Library.GetCellValue(TestX, TestY));
        }

        [TestMethod]
        public void TestMethod_CellsGameFieldAreZero()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;

            Library.CreateGameField(TestSize);

            for (int i = 0; i < TestSize; i++)
            {
                for (int j = 0; j < TestSize; j++)
                {
                    Assert.AreEqual(0, Library.GetCellValue(i, j));
                }
            }
        }

        [TestMethod]
        public void TestMethod_SetTokenPalyer()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestToken1 = 2;
            int TestToken2 = 3;

            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);

            Assert.AreEqual(TestToken1, Library.GetTokenPlayer1());
            Assert.AreEqual(TestToken2, Library.GetTokenPlayer2());
        }
    }
}
