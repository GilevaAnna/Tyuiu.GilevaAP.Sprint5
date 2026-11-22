using System.IO;
using Tyuiu.GilevaAP.Sprint5.Task0.V7.Lib;
namespace Tyuiu.GilevaAP.Sprint5.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Anna\source\repos\Tyuiu.GilevaAP.Sprint5\Tyuiu.GilevaAP.Sprint5.Task0.V7\bin\Debug\net8.0\OutPutFileTask0.txt";
            //Assert.IsTrue(File.Exists(path));
            //string result = File.ReadAllText(path);
            //Assert.AreEqual("-6", result);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = File.Exists(path);
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}
