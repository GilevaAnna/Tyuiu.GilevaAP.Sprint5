using System.IO;
using Tyuiu.GilevaAP.Sprint5.Task4.V29.Lib;
namespace Tyuiu.GilevaAP.Sprint5.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName(); ;
            FileInfo fileinfo = new FileInfo(path);
            File.WriteAllText(path, "-3.57");
            double res = ds.LoadFromDataFile(path);
            double wait = 0.678;
            Assert.AreEqual(wait, res);
            File.Delete(path);
        }

    }
}