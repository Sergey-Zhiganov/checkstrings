using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TDD.Tests
{
    [TestClass]
    public class CheckStringsTests
    {
        [TestMethod]
        public void ShortestWord_findShortestWord_etoreturned()
        {
            string text = "Москва - это столица России";
            string expected = "это";

            CheckStrings checkStrings = new CheckStrings();
            string actual = checkStrings.ShortestWord(text);

            Assert.IsNotNull(actual, "Короткое слово не должно быть null");
            Assert.IsTrue(actual.All(c => !char.IsDigit(c)), "В слове не должно быть цифр");
            Assert.AreEqual(expected, actual, "Неверное короткое слово");
        }

        [TestMethod]
        public void CountWords_countingWord_5returned()
        {
            string text = "Поддержка и тестирование программных модулей";
            int expected = 5;

            CheckStrings checkStrings = new CheckStrings();
            int actual = checkStrings.CountWords(text);

            Assert.IsFalse(actual == 0, "Количество слов не должно быть 0");
            Assert.AreEqual(expected, actual, "Неверное количество слов");
        }

        [TestMethod]
        public void CountChars_couningChars_1returned()
        {
            string text = "В этом предложении ровно 36 символов";
            int expected = 36;

            CheckStrings checkStrings = new CheckStrings();
            int actual = checkStrings.CountChars(text);

            Assert.IsNotNull(actual, "Количество символов не должно быть null");
            Assert.AreEqual(expected, actual, "Неверное количество символов (включая пробелы)");
        }

        [TestMethod]
        public void NinthChar_findChar_rreturned()
        {
            string text = "Я очень рад";
            char? expected = 'р';

            CheckStrings checkStrings = new CheckStrings();
            char? actual = checkStrings.NinthChar(text);

            Assert.IsNotNull(actual, "Девятый символ не должен быть null");
            Assert.IsFalse(char.IsDigit((char)actual), "Девятый символ не должен быть цифрой");
            Assert.AreEqual(expected, actual, "Неверный девятый символ");
        }

        [TestMethod]
        public void CountNumbers_countingNumbers_14returned()
        {
            string text = "Всего цифр у нас 10: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9." +
                "Однако в данном предложении сразу 14 цифр";
            int expected = 14;

            CheckStrings checkStrings = new CheckStrings();
            int actual = checkStrings.CountNumbers(text);

            Assert.IsNotNull(actual, "Количество цифр не должно быть null");
            Assert.IsTrue(actual > 0, "Количество цифр должно быть больше 0");
            Assert.AreEqual(expected, actual, "Неверное количество цифр");
        }

        [TestMethod]
        public void LargestConsecutiveNumbers_findConsecutiveNumbers_5retruned()
        {
            string text = "В данном предложении представлено 3 числа: 14, 156, 19753";
            int expected = 5;

            CheckStrings checkStrings = new CheckStrings();
            int actual = checkStrings.LargestConsecutiveNumbers(text);

            Assert.IsTrue(actual > 0, "Последовательность цифр не найдена");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindSubstring_findingSubstring_2returned()
        {
            string text = "Моя мама - самый близкий мой человек";
            int expected = 2;

            CheckStrings checkStrings = new CheckStrings();
            int actual = checkStrings.FindSubstring(text);

            Assert.AreEqual(expected, actual);
        }
    }
}
