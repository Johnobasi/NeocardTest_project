using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization;

namespace NeocardTest_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the string for this values
            string str = "fi, fr; q = 0.9, en; q = 0.8, de; q = 0.7, *; q = 0.5";

            string[] res;

            //calling the extract method
            Test test = new Test();
            res = test.ExtractValues(str);

            //ExtractValues(str);
            Console.WriteLine($"result is: {string.Join(",", res)}");
            Console.ReadKey();
        }
    }

    public class Test
    {
        public string[] ExtractValues(string input)
        {           
            if (input == null)
            {
                return null;
            }
            else
            {
                return input
                    .Split(',', ';')
                    .Select(v => v.Trim())
                    .Where(v => !string.IsNullOrEmpty(v) && !
                    v.Contains("="))
                    .ToArray();
            }                   
        }
    }
}
