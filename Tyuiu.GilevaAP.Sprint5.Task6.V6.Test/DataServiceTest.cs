using System.IO;
using Tyuiu.GilevaAP.Sprint5.Task6.V6.Lib;
namespace Tyuiu.GilevaAP.Sprint5.Task6.V6.Test
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
            File.WriteAllText(path, "Привет, World! This моя Первая программа.");
            double res = ds.LoadFromDataFile(path);
            double wait = 22;
            Assert.AreEqual(wait, res);
            File.Delete(path);
        }
    }
}
