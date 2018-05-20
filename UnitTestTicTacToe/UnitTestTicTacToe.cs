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

            Assert.AreEqual(Library.GetNamePlayer1(), TestName1);
            Assert.AreEqual(Library.GetNamePlayer2(), TestName2);
        }

        [TestMethod]
        public void TestMethod_SetPlayerName_1()
        {
            LibraryTicTacToe Library = new LibraryTicTacToe();

            String TestName1 = "Player1";
            String TestName2 = "Player2";

            Library.SetNamePlayer1(TestName1);
            Library.SetNamePlayer2(TestName2);

            Assert.AreEqual(Library.GetNamePlayer1(), TestName1);
            Assert.AreEqual(Library.GetNamePlayer2(), TestName2);
        }
    }
}
