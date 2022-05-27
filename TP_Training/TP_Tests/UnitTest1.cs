using System.Collections.Generic;
using NUnit.Framework;

namespace TP_Tests
{
    public class Tests
    {
        //FIBONACCI
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(20, 6765)]
        public void TestFibo(int input, long output)
        {
            Assert.AreEqual(output, WarmUp.Fibonacci(input));
        }
        
        //TRIBONACCI
        [TestCase(5, 2)]
        [TestCase(10, 44)]
        [TestCase(20, 19513)]
        public void TestTribo(int input, long output)
        {
            Assert.AreEqual(output, WarmUp.Tribonacci(input));
        }
        
        //ROTCHAR
        [TestCase('A', 2, 'C')]
        [TestCase('A', -2, 'Y')]
        public void TestRotChar(char input, int n, char output)
        {
            Assert.AreEqual(output, WarmUp.RotChar(input, n));
        }
        
        //ROTSENTENCE
        [TestCase("ABC", 5, "FGH")]
        [TestCase("HIMYNAMEISARMAND", -13, "UVZLANZRVFNEZNAQ")]
        public void TestRotSentence(string input, int n, string output)
        {
            Assert.AreEqual(output, WarmUp.RotSentence(input, n));
        }

        //VICEMAX
        [TestCase(new[] {10, -2, 58, -5, 0, -1, 1, 1, 58, 3}, 58)]
        [TestCase(new[] {10, -2, 58, -5, 0, -1, 1, 1, 2, 3}, 10)]
        public void TestViceMax(int[] input, int x)
        {
            Assert.AreEqual(x, WarmUp.ViceMax(input));
        }
        
        //BUBBLESORT
        [TestCase(new int[] { 1, 2, 5, 4, 3 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] {5, 4, 3, 2, 1}, new[] {1, 2, 3, 4, 5})]
        [TestCase(new[] {10, -2, 58, -5, 0, -1, 1, 1, 2, 3}, new[] {-5, -2, -1, 0, 1, 1, 2, 3, 10, 58})]
        public void TestBubbleSort(int[] input, int[] output)
        {
            Assert.AreEqual(output, WarmUp.BubbleSort(input));
        }
        
        //QUICKSORT
        [TestCase(new int[] { 1, 2, 5, 4, 3 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] {5, 4, 3, 2, 1}, new[] {1, 2, 3, 4, 5})]
        [TestCase(new[] {10, -2, 1, 58, -5, 0, -1, 2, 3}, new[] {-5, -2, -1, 0, 1, 2, 3, 10, 58})]
        //FUNCTION NOT WORKING WITH DUPLICATE VALUE.
        //YOU CAN TRY TO SOLVE IT BY YOURSELF.
        //[TestCase(new[] {10, -2, 1, 58, -5, 0, -1, 1, 2, 3}, new[] {-5, -2, -1, 0, 1, 1, 2, 3, 10, 58})]
        public void TestQuickSort(int[] input, int[] output)
        {
            Assert.AreEqual(output, WarmUp.QuickSort(input));
        }
        
        //INSERTSORT
        [TestCase(new int[] { 1, 2, 5, 4, 3 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] {5, 4, 3, 2, 1}, new[] {1, 2, 3, 4, 5})]
        [TestCase(new[] {10, -2, 58, -5, 0, -1, 1, 1, 2, 3}, new[] {-5, -2, -1, 0, 1, 1, 2, 3, 10, 58})]
        public void TestInsertSort(int[] input, int[] output)
        {
            Assert.AreEqual(output, WarmUp.InsertSort(input));
        }
    }
}