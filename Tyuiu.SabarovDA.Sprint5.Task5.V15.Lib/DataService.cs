using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO; 
namespace Tyuiu.SabarovDA.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            double minNum = double.MaxValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 5 == 0 && Convert.ToDouble(line) < minNum)
                    {
                        minNum = Convert.ToDouble(line);
                    }
                }
            }
            return minNum;
        }
    }
}
