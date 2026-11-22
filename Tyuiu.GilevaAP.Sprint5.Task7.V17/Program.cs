using Tyuiu.GilevaAP.Sprint5.Task7.V17.Lib;
namespace Tyuiu.GilevaAP.Sprint5.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\", "DataSprint5", "InPutDataFileTask7V17.txt");

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string savepath = ds.LoadDataAndSave(path);
            string res = File.ReadAllText(savepath);
            Console.WriteLine("Результат обработки данных находится в файле: " + savepath);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
