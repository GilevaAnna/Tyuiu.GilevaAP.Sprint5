using System.IO;
using Tyuiu.GilevaAP.Sprint5.Task3.V6.Lib;
namespace Tyuiu.GilevaAP.Sprint5.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            string path = ds.SaveToFileTextData(3);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = File.Exists(path);
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
