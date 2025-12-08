using Tyuiu.Kucherenkonm.Sprint6.Task4.V6.Lib;
namespace Tyuiu.Kucherenkonm.Sprint6.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[] { 23.92, 18.88, 13.1, 7.24, 1.8, -8, -5.7, -11.26, -17.12, -22.88, -27.92 };

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
