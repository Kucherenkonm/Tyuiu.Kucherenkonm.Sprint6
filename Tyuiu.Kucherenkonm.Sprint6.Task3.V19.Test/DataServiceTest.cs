using Tyuiu.Kucherenkonm.Sprint6.Task3.V19.Lib;
namespace Tyuiu.Kucherenkonm.Sprint6.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                {4,  5, -20,  27,  21},
                {17, 15, -1, -2, -1},
                {-3, 18, 12, 6, 29},
                {7, -15, 2, -8, 12},
                {-10, 25, 5, 27, 21}
            };
            int[,] res = ds.Calculate(matrix);
            int[,] wait =
            {
                {4,  5, -20,  27,  -1},
                {17, 15, -1, -2, 12},
                {-3, 18, 12, 6, 21},
                {7, -15, 2, -8, 21},
                {-10, 25, 5, 27, 29}
            };

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
