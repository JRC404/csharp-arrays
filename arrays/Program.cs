using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays...
            /*   fixed sized... 
             * 
             *   type of array that we want... double, int, string etc...
             *   declare the length of the array 
             *   
             *   lists - a little bit different - collection
             */

            string[] firstNames = new string[11];
            int[] numbers = new int[10];
            int i;
            //firstNames[0] = "Jacob";
            //firstNames[1] = "Danny";
            //firstNames[2] = "Danny";
            //firstNames[3] = "Danny";
            //firstNames[4] = "Danny";
            //firstNames[5] = "Danny";
            //firstNames[6] = "Danny";
            //firstNames[7] = "Danny"; // creation of the value
            //firstNames[8] = "Danny";
            //firstNames[9] = "Danny";
            ////firstNames[10] = "Danny";
            //firstNames[7] = "Jacob";
            for (i = 0; i < 10; i++)
            {
                numbers[i] = i + 1;
                Console.WriteLine(numbers[i]);
            }

            double[] decimalNumbers = new double[3] { 34, 55, 77 };
            float[] floatingNumbers = new float[3] { 34.6f, 22.4f, 55.8f };
            float[] floatWithoutNewFloat = { 34.6f, 34.5f };


            // floatWithoutNewFloat[2] = 44.5f; // index out of range - only 0,1 can be modified
            //string[] errorChecker = new string[]; // must have size or initialiser
            //string[] errorChecker = new string[3] { "Jacob", "Ebuka" }; // array length of 3 expected


            //floatingNumbers[3] = 56.5f;
            Console.WriteLine(decimalNumbers[2]);
            decimalNumbers[2] = 78;
            decimalNumbers[2] = 80;
            Console.WriteLine(decimalNumbers[2]);
            Console.ReadKey();
            
        }
    }
}
