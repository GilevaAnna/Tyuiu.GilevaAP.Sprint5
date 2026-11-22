using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GilevaAP.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strV;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((2*Math.Sin(x))/(3  *x + 1.2)) + Math.Cos(x) - 7*Math.Pow(x, 2);
                y = Math.Round(y, 2);
                strV = Convert.ToString(y);
                
                if (x != stopValue)
                {
                    File.AppendAllText(path, strV + Environment.NewLine);
                }
                else 
                {
                    File.AppendAllText(path, strV);
                }
            }
            return path;
        }
    }
}
