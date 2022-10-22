using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Atm
    {
        
        string filePath = @"C:\temp\kekw.txt";

        List<string> lines = new List<string>();

        List<string> linesC = File.ReadAllLines(@"C:\temp\kekw.txt").ToList();


        public void NewAccountAdd(string Number, int PinCode, string Owner, decimal Balance)
        {
            string s = ",";
            string input = (Number + s + PinCode + s + Owner + s + Balance).ToString();
            lines.Add(input);
            File.WriteAllLines(filePath, lines);
        }
            


        public bool LoginAccount(string Number, int PinCode)
        {
            
            foreach (string line in linesC)
            {
                
                int counter = 0;
                string[] arr = line.Split(',');

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == Number)
                    {
                        if (arr[j + 2] == PinCode.ToString())
                        {                            
                            return true;
                        }
                        else
                        {
                           continue;
                        }

                    }
                    else if (arr[j] != Number )
                    {
                        continue;
                    }  
                }
            }
            return false;
        }

        public string Account(string Number, int PinCode)
        {

            foreach (string line in linesC)
            {
                string Spaceholder = line;

                string[] arr = line.Split(',');
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == Number)
                    {
                        if (arr[j + 2] == PinCode.ToString())
                        {
                            return Spaceholder;
                        }
                        else
                        {
                            continue;
                        }

                    }
                    else if (arr[j] != Number)
                    {
                        continue;
                    }
                }
            }
            return "Error";
        }


    }
    //public class AccGetter
    //{
    //    List<string> linesC = File.ReadAllLines(@"C:\temp\kekw.txt").ToList();
    //    public string Account(string Number, int PinCode)
    //    {

    //        foreach (string line in linesC)
    //        {
    //            string Spaceholder = line;

    //            string[] arr = line.Split(',');
    //            for (int j = 0; j < arr.Length; j++)
    //            {
    //                if (arr[j] == Number)
    //                {
    //                    if (arr[j + 2] == PinCode.ToString())
    //                    {
    //                        return Spaceholder;
    //                        break;
    //                    }
    //                    else 
    //                    { 
    //                        return "Error"; 
    //                    }
    //                }
    //                else
    //                {
    //                    return "Error";
    //                }
    //            }
    //            else 
    //            {
    //                return "Error";
    //            }
    //        }
           

    //    }

    //}

}
