using Tyuiu.Kucherenkonm.Sprint6.Task5.V12.Lib;
namespace Tyuiu.Kucherenkonm.Sprint6.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V12.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask5V12.txt";
            var res = ds.LoadFromDataFile(path);
            double[] wait =
            { -13, -19, -9.82, 13, 11.49, -9.71, 3.36, 14.52, 16, 13.66, 0.48, 4.13, -0.11, 19, -17.36, 11, 11.28, -12, -12.35 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
