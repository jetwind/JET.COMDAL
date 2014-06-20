
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EasyDataAccess
{
    public class TestHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        public static void TimerAction(Action action)
        {
            var sw = new Stopwatch();
            sw.Start();
            action();
            sw.Stop();
            Debug.WriteLine(sw.ElapsedMilliseconds + " ms");
        }
    }
}
