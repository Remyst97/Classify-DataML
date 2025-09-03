using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.ML.Data;
using System.Globalization;
using Microsoft.ML;
using ClassifyDataML.ConsoleApp;
using ClassifyDataML.Model;

namespace ClassifyData
{
    class Program
    {
        static void Main(string[] args)
        {

            //****************************read test evaluation data from text file *******************
            // ***************************************************************************************
            string theline = "";
            int count = 0;

            string line = "";

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:\\Users\\redju\\source\\repos\\ClassifyData\\bin\\Data\\testdata.txt"))
                {

                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (count == 0)
                            theline = line;

                        Console.WriteLine(line);
                        Console.WriteLine($"\n");

                        char[] delimiterChars = { ',' };

                        System.Console.WriteLine($"Test Data: '{line}'");

                        string[] words = theline.Split(delimiterChars);
                        System.Console.WriteLine($"{words.Length} numbers are:");


                        float column0 = 0, column1 = 0, column2 = 0, column3 = 0, column4 = 0;
                        int x = 0;

                        // convert string to a float

                        foreach (var word in words)
                        {
                            if (x == 0)
                            {
                                column0 = float.Parse(word, CultureInfo.InvariantCulture.NumberFormat);
                            }
                            if (x == 1)
                            {
                                column1 = float.Parse(word, CultureInfo.InvariantCulture.NumberFormat);
                            }
                            if (x == 2)
                            {
                                column2 = float.Parse(word, CultureInfo.InvariantCulture.NumberFormat);
                            }
                            if (x == 3)
                            {
                                column3 = float.Parse(word, CultureInfo.InvariantCulture.NumberFormat);
                            }

                            if (x == 4)
                            {
                                column4 = float.Parse(word, CultureInfo.InvariantCulture.NumberFormat);
                            }

                            x = x + 1;

                            System.Console.WriteLine($"{word}");
                        }

                        // answer from text file 

                        Console.WriteLine($"\n\n");

                        //*********************train model ******************************
                        //***************************************************************
                        ModelBuilder.CreateModel();

                        //***********************************************************


                        // Create single instance of sample data from first line of dataset for model input
                        ModelInput sampleData = new ModelInput()
                        {
                            Sepallength = column1,
                            Sepalwidth = column2,
                            Petallength = column3,
                            Petalwidth = column4,

                        };

                        // Make a single prediction on the sample data and print results
                        var predictionResult = ConsumeModel.Predict(sampleData);

                        Console.WriteLine("Using model to make single prediction -- Comparing actual Col0 with predicted Col0 from sample data...\n\n");
                        Console.WriteLine($"Col1: {sampleData.Sepallength}");
                        Console.WriteLine($"Col2: {sampleData.Sepalwidth }");
                        Console.WriteLine($"Col3: {sampleData.Petallength}");
                        Console.WriteLine($"Col4: {sampleData.Petalwidth}");

                        Console.WriteLine($"\n\nPredicted Col0 value {predictionResult.PredictedLabel} \nPredicted Col0 scores: [{String.Join(",", predictionResult.Score)}]\n\n");
                        Console.WriteLine("=============== End of process, hit any key to finish ===============");

                        Console.WriteLine($"\nThe real answer is {column0}\n\n");

                        Console.WriteLine($"\nThe predicted value is ");
                        string type = "no answer";


                        if (predictionResult.PredictedLabel == 0)
                            type = "setosa";
                        else if (predictionResult.PredictedLabel == 1)
                            type = "versicolor";
                        else if (predictionResult.PredictedLabel == 2)
                            type = "virginica";

                        Console.WriteLine($"type is  {type}");


                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }




    }
}
