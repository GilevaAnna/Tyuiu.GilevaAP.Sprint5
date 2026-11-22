using System.IO;
using Tyuiu.GilevaAP.Sprint5.Task7.V17.Lib;
namespace Tyuiu.GilevaAP.Sprint5.Task7.V17.Test
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
            File.WriteAllText(path, "Словарные слова с удвоенной согласной нн");
            string savepath = ds.LoadDataAndSave(path);
            string res = File.ReadAllText(savepath).Trim();
            string wait = "Словарные слова с удвоеой согласной";
            Assert.AreEqual(wait, res);
            File.Delete(path);
            File.Delete(savepath);
        }
    }
}
