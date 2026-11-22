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
                double s = Math.Sin(x);
                double kk = Math.Cos(x);
                double p = Math.Pow(x, 2);
                y = ((2*s))/(3  * x + 1.2) + kk - 7*p;
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
