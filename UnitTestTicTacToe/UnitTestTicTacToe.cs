using System;
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

        [TestMethod]
        public void TestMethod_SetTokenPalyer_1()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestToken1 = 1;
            int TestToken2 = 2;

            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);

            Assert.AreEqual(TestToken1, Library.GetTokenPlayer1());
            Assert.AreEqual(TestToken2, Library.GetTokenPlayer2());
        }

        [TestMethod]
        public void TestMethod_SetTokenPalyerIsNotEmpty()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestToken1 = 1;
            int TestToken2 = 2;

            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);

            Assert.AreEqual(false, Library.SetTokenPalyer1(TestToken1));
            Assert.AreEqual(false, Library.SetTokenPalyer1(TestToken1));
        }

        [TestMethod]
        public void TestMethod_SetTokenPalyerIsNotEmpty_1()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestToken1 = 1;
            int TestToken2 = 2;

            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);

            Assert.AreEqual(false, Library.SetTokenPalyer1(TestToken1));
            Assert.AreEqual(false, Library.SetTokenPalyer1(TestToken2));
        }

        [TestMethod]
        public void TestMethod_SetTokenPalyerIsEmpty()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestToken1 = 1;
            int TestToken2 = 2;

            Assert.AreEqual(true, Library.SetTokenPalyer1(TestToken1));
            Assert.AreEqual(true, Library.SetTokenPalyer1(TestToken2));
        }

        [TestMethod]
        public void TestMethod_SetCellPlayer()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize     = 3;
            int TestToken1   = 1;
            int TestToken2   = 2;
            int TestXPlayer1 = 1;
            int TestYPlayer1 = 1;
            int TestXPlayer2 = 2;
            int TestYPlayer2 = 2;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer1(TestXPlayer1, TestYPlayer1);
            Library.SetCellPlayer2(TestXPlayer2, TestYPlayer2);

            Assert.AreEqual(TestToken1, Library.GetCellValue(TestXPlayer1, TestYPlayer1));
            Assert.AreEqual(TestToken2, Library.GetCellValue(TestXPlayer2, TestYPlayer2));
        }

        [TestMethod]
        public void TestMethod_SetCellPlayer_1()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize     = 4;
            int TestToken1   = 2;
            int TestToken2   = 3;
            int TestXPlayer1 = 1;
            int TestYPlayer1 = 2;
            int TestXPlayer2 = 1;
            int TestYPlayer2 = 3;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer1(TestXPlayer1, TestYPlayer1);
            Library.SetCellPlayer2(TestXPlayer2, TestYPlayer2);

            Assert.AreEqual(TestToken1, Library.GetCellValue(TestXPlayer1, TestYPlayer1));
            Assert.AreEqual(TestToken2, Library.GetCellValue(TestXPlayer2, TestYPlayer2));
        }

        [TestMethod]
        public void TestMethod_SetCellPlayerIsNotEmpty()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 2;
            int TestToken2 = 3;
            int TestXPlayer1 = 1;
            int TestYPlayer1 = 1;
            int TestXPlayer2 = 1;
            int TestYPlayer2 = 1;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer1(TestXPlayer1, TestYPlayer1);

            Assert.AreEqual(false, Library.SetCellPlayer1(TestXPlayer1, TestYPlayer1));
            Assert.AreEqual(false, Library.SetCellPlayer2(TestXPlayer2, TestYPlayer2));
        }

        [TestMethod]
        public void TestMethod_SetCellPlayerIsNotEmpty_1()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 2;
            int TestToken2 = 3;
            int TestXPlayer1 = 0;
            int TestYPlayer1 = 2;
            int TestXPlayer2 = 0;
            int TestYPlayer2 = 1;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer1(TestXPlayer1, TestYPlayer1);
            Library.SetCellPlayer2(TestXPlayer2, TestYPlayer2);

            Assert.AreEqual(false, Library.SetCellPlayer1(TestXPlayer1, TestYPlayer1));
            Assert.AreEqual(false, Library.SetCellPlayer2(TestXPlayer2, TestYPlayer2));
        }

        [TestMethod]
        public void TestMethod_SetCellPlayerIsEmpty()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 2;
            int TestToken2 = 3;
            int TestXPlayer1 = 0;
            int TestYPlayer1 = 2;
            int TestXPlayer2 = 0;
            int TestYPlayer2 = 1;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);

            Assert.AreEqual(true, Library.SetCellPlayer1(TestXPlayer1, TestYPlayer1));
            Assert.AreEqual(true, Library.SetCellPlayer2(TestXPlayer2, TestYPlayer2));
        }

        [TestMethod]
        public void TestMethod_GameIsOver()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 1;
            int TestToken2 = 2;
            int TestX1 = 0;
            int TestY1 = 0;
            int TestX2 = 0;
            int TestY2 = 1;
            int TestX3 = 0;
            int TestY3 = 2;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer1(TestX1, TestY1);
            Library.SetCellPlayer1(TestX2, TestY2);
            Library.SetCellPlayer1(TestX3, TestY3);

            Assert.AreEqual(true, Library.GameIsOver());
        }

        [TestMethod]
        public void TestMethod_GameIsOver_1()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 1;
            int TestToken2 = 2;
            int TestX1 = 0;
            int TestY1 = 0;
            int TestX2 = 0;
            int TestY2 = 1;
            int TestX3 = 0;
            int TestY3 = 2;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer2(TestX1, TestY1);
            Library.SetCellPlayer2(TestX2, TestY2);
            Library.SetCellPlayer2(TestX3, TestY3);

            Assert.AreEqual(true, Library.GameIsOver());
        }

        [TestMethod]
        public void TestMethod_GameIsOver_2()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 1;
            int TestToken2 = 2;
            int TestX1 = 1;
            int TestY1 = 0;
            int TestX2 = 1;
            int TestY2 = 1;
            int TestX3 = 1;
            int TestY3 = 2;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer2(TestX1, TestY1);
            Library.SetCellPlayer2(TestX2, TestY2);
            Library.SetCellPlayer2(TestX3, TestY3);

            Assert.AreEqual(true, Library.GameIsOver());
        }

        [TestMethod]
        public void TestMethod_GameIsOver_3()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 1;
            int TestToken2 = 2;
            int TestX1 = 1;
            int TestY1 = 0;
            int TestX2 = 1;
            int TestY2 = 1;
            int TestX3 = 1;
            int TestY3 = 2;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer1(TestX1, TestY1);
            Library.SetCellPlayer1(TestX2, TestY2);
            Library.SetCellPlayer1(TestX3, TestY3);

            Assert.AreEqual(true, Library.GameIsOver());
        }

        [TestMethod]
        public void TestMethod_GameIsOver_4()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 1;
            int TestToken2 = 2;
            int TestX1 = 1;
            int TestY1 = 0;
            int TestX2 = 1;
            int TestY2 = 1;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer2(TestX1, TestY1);
            Library.SetCellPlayer2(TestX2, TestY2);

            Assert.AreEqual(false, Library.GameIsOver());
        }

        [TestMethod]
        public void TestMethod_GameIsOver_5()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 1;
            int TestToken2 = 2;
            int TestX2 = 1;
            int TestY2 = 1;
            int TestX3 = 1;
            int TestY3 = 2;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer1(TestX2, TestY2);
            Library.SetCellPlayer1(TestX3, TestY3);

            Assert.AreEqual(false, Library.GameIsOver());
        }

        [TestMethod]
        public void TestMethod_GameIsOver_6()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 1;
            int TestToken2 = 2;
            int TestX1 = 1;
            int TestY1 = 0;
            int TestX2 = 1;
            int TestY2 = 1;
            int TestX3 = 1;
            int TestY3 = 2;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer1(TestX1, TestY1);
            Library.SetCellPlayer2(TestX2, TestY2);
            Library.SetCellPlayer1(TestX3, TestY3);

            Assert.AreEqual(true, Library.GameIsOver());
        }

        [TestMethod]
        public void TestMethod_GameIsOver_7()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            int TestSize = 3;
            int TestToken1 = 1;
            int TestToken2 = 2;
            int TestX1 = 1;
            int TestY1 = 0;
            int TestX2 = 1;
            int TestY2 = 1;
            int TestX3 = 1;
            int TestY3 = 2;

            Library.CreateGameField(TestSize);
            Library.SetTokenPalyer1(TestToken1);
            Library.SetTokenPalyer2(TestToken2);
            Library.SetCellPlayer2(TestX1, TestY1);
            Library.SetCellPlayer1(TestX2, TestY2);
            Library.SetCellPlayer1(TestX3, TestY3);

            Assert.AreEqual(true, Library.GameIsOver());
        }
    }
}
