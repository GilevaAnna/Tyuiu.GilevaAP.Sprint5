using System.IO;
using Tyuiu.GilevaAP.Sprint5.Task5.V1.Lib;
namespace Tyuiu.GilevaAP.Sprint5.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName(); ;
            FileInfo fileinfo = new FileInfo(path);
            File.WriteAllText(path, "24, 2, 18, 4, -9, 4, 10, 18, 19, 16, 11, -3, -3, 15, 3, 18, -5, -4, 25, 19");
            double res = ds.LoadFromDataFile(path);
            double wait = 110;
            Assert.AreEqual(wait, res);
            File.Delete(path);
        }
    }
}
