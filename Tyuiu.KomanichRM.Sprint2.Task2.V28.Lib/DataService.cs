using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KomanichRM.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3) && (x < 6) && (y >= 3) && (y < 8))
            {
                res = true; 
            }
            else
            {
                res = false;
            }
            return res;
            if ((x >= 5) && (x < 10) && (y >= 5) && (y < 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
            if ((x == 9) && (y == 3))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
            if ((x == 9) && (y == 4))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
            if ((x == 10) && (y >= 5) && (y < 8))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
            if ((y == 11) && (x >= 3) && (x < 13))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
            if ((y == 12) && (x >= 7) && (x < 11))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
