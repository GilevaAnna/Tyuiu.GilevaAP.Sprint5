using System.IO;
using Tyuiu.GilevaAP.Sprint5.Task1.V25.Lib;
namespace Tyuiu.GilevaAP.Sprint5.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);
        }
    }
}
