using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GilevaAP.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path.Trim());
            strX = strX.Replace(',', '.');
            double x = double.Parse(strX, CultureInfo.InvariantCulture);
            double res = (0.5 + (Math.Sin(Math.Pow(x, 2))));
            res = Math.Round(res, 3);

            return res;
        }
    }
}