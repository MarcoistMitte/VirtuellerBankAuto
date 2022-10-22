//using System;
//using System.Buffers;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
using ATM;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    class TextFileRead
    {
        static void Main(string[] args)
        {
            Menu start = new Menu();
            start.MenuAn();
        }
    }
}
//            // Path to Save
//            string filePath = @"C:\atm\test.txt";


//            List<string> lines = new List<string>();
//            lines = File.ReadAllLines(filePath).ToList();

//            // New Account Add
//            int Number = 132456789;
//            string Owner = "Marco";
//            int Balance = 400;

//            string input = (Number + Owner + Balance).ToString();
//            lines.Add(input);
//            File.WriteAllLines(filePath, lines);

//            foreach (string line in lines)
//            {
//                if (line == input)
//                {
//                    Console.WriteLine("Valid");
//                }
//                else
//                {
//                    Console.WriteLine("Not Valid");
//                }

//            }



//        }
//    }
//}