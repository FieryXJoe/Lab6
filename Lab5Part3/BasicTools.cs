using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace MidTermProject
{
    class BasicTools
    {
        public static void pause()
        {
            Console.WriteLine("\nPress Any Key to Continue\n");
            Console.ReadKey();
        }

        //Used Week4_Sample2_Class2.pdf from Canvas as reference point for this function
        public static bool isValidEmail(String s)
        {
            bool rtrn = true;
            int atLocation = s.IndexOf("@"), nextAtLocation = s.IndexOf("@", atLocation + 1), periodLocation = s.LastIndexOf(".");
            if (s.Length < 8)
                rtrn = false;
            else if (atLocation < 2)
                rtrn = false;
            else if (periodLocation == -1 || atLocation == -1)
                rtrn = false;
            else if (periodLocation + 2 > s.Length)
                rtrn = false;
            return rtrn;

        }
        public static bool isValidURL(String s)
        {
            bool rtrn = true;
            int periodLocation = s.LastIndexOf(".");
            if (s.Length < 4)
                rtrn = false;
            else if (periodLocation + 1 > s.Length)
                rtrn = false;
            return rtrn;
        }

        public static bool isValidStateCode(String s)
        {
            bool rtrn = true;
            if (s.Length != 2)
                rtrn = false;
            return rtrn;
        }

        public static bool isValidZipCode(String s)
        {
            bool rtrn = true;
            long temp;
            if (s.Length != 5 || !Int64.TryParse(s, out temp))
                rtrn = false;
            return rtrn;
        }
        public static bool isValidPhoneNum(String s)
        {
            bool rtrn = true;
            long temp;
            if (s.Length != 10 || !Int64.TryParse(s, out temp))
                rtrn = false;
            return rtrn;
        }

        //for part 3 date validation
        public static bool isFutureDate(DateTime date)
        {
            DateTime now = DateTime.Now;
            if (date > now)
                return true;
            else
                return false;
        }
        //feels dumb making these functions
        public static bool isNegative(double d)
        {
            return d < 0;
        }
        public static bool isNegative(int i)
        {
            return i < 0;
        }

        public static bool isNow(DateTime d)
        {
            DateTime temp = DateTime.Now;
            if (d < temp.AddSeconds(1) && d > temp.AddSeconds(-1))
                return true;
            else
                return false;
        }

        public static bool isValidDouble(String s)
        {
            double temp;
            return Double.TryParse(s, out temp);
        }

        public static bool isValidInt(String s)
        {
            long temp;
            return Int64.TryParse(s, out temp);
        }
        public static bool isValidInstaURL(String s)
        {
            bool rtrn = true;
            int slashLocation = s.LastIndexOf("/");
            if (s.Length < 4)
                rtrn = false;
            else if (!s.ToLower().Contains("instagram.com/"))
                rtrn = false;
            else if (slashLocation + 2 > s.Length)
                rtrn = false;
            return rtrn;
        }
    }
}
