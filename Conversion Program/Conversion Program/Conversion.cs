using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversion_Program
{
    class Conversion
    {
        private string name1, name2;
        private double rate;
        private List<double> outputList = new List<double>();

        //The constructor for the conversion object that sets all the global variable values with the ones given.
        public Conversion(string name1, string name2, double rate)
        {
            this.name1 = name1;
            this.name2 = name2;
            this.rate = rate;  
        }

        public void Convert(int loop)
        {
            double last = 0.5;
            double answer;
            double lastAnswer = 0;
            int count = 1;

            //Loops to do the ammount of conversions wanted
            do
            {
                //Calculates the conversion
                answer = count * rate;
                //Checks to see if the converstion is past 1 or a half of the second object
                if ((answer > last) && (lastAnswer != last))
                {
                    outputList.Add(last / rate);
                    outputList.Add(last);
                    last = last + 0.5;                   
                }
                lastAnswer = answer;
                //Adds both numbers, the original and conversion to the output list
                outputList.Add(count);
                outputList.Add(answer);
                
                //increases the count by 1 for the loop
                count++;
            } while (loop > count);
        }

        public void Output()
        {
            int x = 0;
            
            //Writes the names of the conversion items at the top.
            Console.WriteLine(name1 + "\t\t" + name2);
            //Loop for outputing each conversion
            foreach (double num in outputList)
            {
                //Trys to write it on the screen but if x is too large it will catch the error
                try
                {
                    Console.WriteLine(outputList[x].ToString("0.000") + "\t\t" + outputList[x + 1].ToString("0.000"));
                }
                catch (ArgumentOutOfRangeException)
                {
                    break;
                }
                //increases the x value by 2
                x++;
                x++;
            }
        }

    }
}
