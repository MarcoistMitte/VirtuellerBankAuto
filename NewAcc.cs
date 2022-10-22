using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class NewAcc
    {
        public void AccAdd(string number, int pincode,string Owner, decimal Balance)
        {
            string filepath = @"C:\temp\kekw.txt";
            string s = ",";
            List<string> input = new List<string>();
            string space = (number + s + Owner + s + pincode + s + Balance);
            input.Add(space);
            File.AppendAllLines(filepath, input);
        }
    }
    }
}
