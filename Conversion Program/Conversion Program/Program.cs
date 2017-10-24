using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversion_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisation of variables
            string item1 = "";
            string item2 = "";
            double conversionRate = 0.0;
            int ammount = 5;
            int choice = 0;
            int error = 1;
            bool loop = true;
            //Creates the base conversion object
            Conversion myConversion = new Conversion(item1, item2, conversionRate);

            //Starts the programs loop
            do
            {
                //Outputs the start menu
                Console.WriteLine("Please Choose an option:");
                Console.WriteLine("1. Convert from litres to gallons.");
                Console.WriteLine("2. Pints to gallons.");
                Console.WriteLine("3. Pints to litres.");
                Console.WriteLine("4. Choose own Conversion.");
                //Gets the users choice and clears the window
                choice = int.Parse(Console.ReadLine());
                Console.Clear();

                //Loop for the switch incase of an error
                do
                {
                    //Switch to create edit the conversion object depending on the users choice
                    switch (choice)
                    {
                        //Makes a new conversion object to convert between litres and gallons
                        case 1:
                            myConversion = new Conversion("litres", "Gallons", 0.219969);
                            error = 0;
                            break;
                        //Makes a new conversion object to convert between Pints and gallons
                        case 2:
                            myConversion = new Conversion("Pints", "Gallons", 0.125);
                            error = 0;
                            break;
                        //Makes a new conversion object to convert between Pints and litres
                        case 3:
                            myConversion = new Conversion("Pints", "litres", 0.568261);
                            error = 0;
                            break;
                        //Asks the user for the two items they would wish to convert and asks them the converstion rate,
                        //Then makes a new conversion object for what the user specified
                        case 4:
                            Console.WriteLine("Please input the name of the first conversion item.");
                            item1 = Console.ReadLine();
                            Console.WriteLine("Please input the name of the second conversion item");
                            item2 = Console.ReadLine();
                            Console.WriteLine("Please input the conversion rate between {0} and {1}", item1, item2);
                            conversionRate = double.Parse(Console.ReadLine());
                            myConversion = new Conversion(item1, item2, conversionRate);
                            Console.Clear();
                            error = 0;
                            break;
                        //If no correct choice was made, the program sets the error int to 1 and restarts the switch loop
                        default:
                            Console.WriteLine("Please input a number from 1-4");
                            error = 1;
                            break;
                    }
                } while (error == 1);
                
                //Gets the ammount of conversions that the user specifies
                Console.WriteLine("Please input the ammount you would wish to convert:");
                ammount = int.Parse(Console.ReadLine()) + 1;
                
                //Calls the conversion object and converts the ammoun the user wanted
                myConversion.Convert(ammount);
                //Outputs the conversion list
                myConversion.Output();
                //pauses at the end of the program, then clears the console and loops back
                Console.WriteLine("Press any key to continue.");
                Console.Read();
                Console.Clear();
                Console.Read();
            } while (loop == true);
            Console.Read();
        }
    }
}
