using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Homework_03102023;
using System.Collections.Generic;

namespace BadWordsCheckerTests
{
    [TestClass]
    public class BadWordsCheckerTests
    {
        /// <summary>
        /// простая проверка замены
        /// </summary>
        [TestMethod]
        public void Censore_StringWith1badword_Returned3Star()
        {
            // Arrange
            string str = "редиска ананас";
            string expected = "*** ананас";
            //Act
            string action = BadWordsChecker.Censore(str);
            //Assert
            Assert.AreEqual(expected, action);
        }
        /// <summary>
        /// двойная проверка замены
        /// </summary>
        [TestMethod]
        public void Censore_StringWith2badword_Returned6Star()
        {
            // Arrange
            string str = "редиска редиска";
            string expected = "*** ***";
            //Act
            string action = BadWordsChecker.Censore(str);
            //Assert
            Assert.AreEqual(expected, action);
        }
        /// <summary>
        /// пустая строка
        /// </summary>
        [TestMethod]
        public void Censore_EmptryString_ReturnedEmptryString()
        {
            // Arrange
            string str = "";
            string expected = "";
            //Act
            string action = BadWordsChecker.Censore(str);
            //Assert
            Assert.AreEqual(expected, action);
        }
        [TestMethod]
        /// <summary>
        /// большая проверка
        /// </summary>
        public void Censore_TenRedisok_Returned30stars()
        {
            // Arrange
            string str = "редиска редиска редиска редиска редиска редиска редиска редиска редиска редиска";
            string expected = "*** *** *** *** *** *** *** *** *** ***";
            //Act
            string action = BadWordsChecker.Censore(str);
            //Assert
            Assert.AreEqual(expected, action);
        }
        /// <summary>
        /// проверка регистра
        /// </summary>
        [TestMethod]
        public void Censore_UpperRediska_Returned3Stars()
        {
            // Arrange
            string str = "РЕДИСКА РУЛИТ";
            string expected = "*** рулит";
            //Act
            string action = BadWordsChecker.Censore(str);
            //Assert
            Assert.AreEqual(expected, action);
        }
    }
}
