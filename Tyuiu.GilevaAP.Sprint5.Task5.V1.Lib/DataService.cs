using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GilevaAP.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            double result = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(',');
                    foreach (string num in numbers)
                    {
                        string cleanNum = num.Trim();
                        if (string.IsNullOrEmpty(cleanNum))
                            continue;
                        int x = int.Parse(cleanNum);
                        if (x  % 2 == 0)
                        {
                            
                            result += x;
                        }
                    }
                        
                }
            }
            return result;
        }
    }
}
