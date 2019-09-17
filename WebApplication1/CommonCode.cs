using ControlzEx.Standard;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public static class CommonCode
    {
        public static Dictionary<DateTime,Int32> dict= new Dictionary<DateTime, Int32>();
        public static void test()
        {
            DateTime dt = System.DateTime.Today.AddDays(-2);
            DateTime dt1 = System.DateTime.Today.AddDays(-1);

            addDate(dict, dt, 5);
            addDate(dict, dt1, 15);
        } 
        public static void addDate(Dictionary<DateTime, Int32> dt, DateTime key, int value)
        {
            if (dt.TryGetValue(key, out value))
            {
                dt[key] = ++value;
            }
            else
            {
                dt.Add(key, value);
            }

        }
    }
}