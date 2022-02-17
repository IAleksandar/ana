using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class TextCalculator
    {

        public List<string> num = new List<string>();

        float sum = 0;

        public string Add(string number)
        {
            if (number.LastOrDefault() == ',')
            {
                return "Missing number in last position";
            }

            num = number.Split(',').ToList();

            if (num.Count > 3)
            {
                return "Too many elements!";
            }
            else if (number.Contains('-'))
                return "Negative not allowed: " + CheckNegative(num);
            else
            {
                for (int i = 0; i < num.Count; i++)
                {
                    float temp = 0;
                    bool success = float.TryParse(num[i], out temp);
                    if (success)
                    {
                        sum+=temp;
                    }
                    else
                    {
                        return "Characters not allowed!";
                    }
                }
            }   

            return sum.ToString();
        }

        private string CheckNegative(List<string> num)
        {
            string negative = "";

            foreach(string i in num)
            {
                float tmp;
                bool success = float.TryParse(i.Trim(), out tmp);
                if (success && tmp < 0)
                {
                    if (!string.IsNullOrEmpty(negative))
                        negative += ", ";
                    negative += i.ToString();
                }
            }

            return negative;
        }
    }
}
