using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GilevaAP.Sprint5.Task7.V17.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V17.txt");
            FileInfo fileinfo = new FileInfo(pathSave);
            if (fileinfo.Exists)
            {
                File.Delete(pathSave);
            }
            string str ="";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    str= line.Replace("нн", "");
                    File.AppendAllText(pathSave, str + Environment.NewLine);
                }
            }
            return pathSave;
        }
    }
}
