using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KomanichRM.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            // x = 1305
            // y = 275
            res[0] = x - 1030 == y;
            res[1] = x != y + 1030;
            res[2] = x - 1031 < y;
            res[3] = x - 1031 > y;
            res[4] = x <= y;
            res[5] = x >= y;

            return res;
        }
    }
}
