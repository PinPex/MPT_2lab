using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForEvenMul()
        {
            double[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double product1 = Program.SumEvenIndexes(array1);
            Assert.AreEqual(25, product1);

            double[,] array2 = { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
            double product2 = Program.SumEvenIndexes(array2);
            Assert.AreEqual(50, product2);

            double[,] array3 = { { 1.5, 2.5 }, { 3.5, 4.5 }, { 5.5, 6.5 } };
            double product3 = Program.SumEvenIndexes(array3);
            Assert.AreEqual(11.5, product3); // Expected output: 17.0625
        }
        [TestMethod]
        public void TestForMinUnderAndOnDiagonal()
        {
            double[,] A1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double expected1 = 8;
            double result1 = Program.MaxUnderAndOnDiagonal(A1);
            Assert.AreEqual(expected1, result1);

            // “ест 2
            double[,] A2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            double expected2 = 6;
            double result2 = Program.MaxUnderAndOnDiagonal(A2);
            Assert.AreEqual(expected2, result2);

            // “ест 3 (пустой массив)
            double[,] A3 = { };
            double expected3 = double.MaxValue; // возвращаем минимальное значение double, если массив пустой
            double result3 = Program.MaxUnderAndOnDiagonal(A3);
            Assert.AreEqual(expected3, result3);
        }
        [TestMethod]
        public void TestForMinOfThreeNums()
        {
            int result = Program.MinOfThreeNumbers(8, 4, 12);
            Assert.AreEqual(4, result);
            result = Program.MinOfThreeNumbers(10, 10, 10);
            Assert.AreEqual(10, result);

            result = Program.MinOfThreeNumbers(2, 6, 3);
            Assert.AreEqual(2, result);

            result = Program.MinOfThreeNumbers(-5, 0, -10);
            Assert.AreEqual(-10, result);

            result = Program.MinOfThreeNumbers(100, 50, 75);
            Assert.AreEqual(50, result);
        }
    }
}