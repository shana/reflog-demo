﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingCollectionTests
{
    class Output : ITestOutputHelper
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }

    class Program
    {
        public static void Main()
        {
//#if DEBUG
//            new TrackingTests(new Output()).OrderByDoesntMatchOriginalOrderTimings();
//#else
//            new TrackingTests().OrderByDoesntMatchOriginalOrderTimings();
//#endif
        }
    }
}
