using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IntegerFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            //run the readfile routine until it returns data
            while (intList.Count == 0)
            {
                Console.Write("Enter File Path or enter exit to exit: ");
                string line = Console.ReadLine();
                try
                {
                    if (line == "exit")
                    {
                        System.Environment.Exit(1);
                    }
                    intList = FileIO.ReadtheFile(line);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File Not Found, try a different File Path");
                }
                catch (FileLoadException)
                {
                    Console.WriteLine("There was a problem loading this file, try another");
                }
                catch (InvalidDataException)
                {
                    Console.WriteLine("One of the Data values was not an Integer, Please Repair the File");
                }
                catch (Exception)
                {
                    Console.WriteLine("An unknown Exception occurred, Contact an Administrator");
                }
                
            }
           
            foreach (var number in intList)
            {
                var primeInts = new List<int>();
                int count = 0;
                primeInts = PrimeFactors.Generate(number);
                string results = "";
                foreach (var primeNumber in primeInts)
                {
                    results += primeNumber.ToString() + ", ";
                    ++count;
                }
                if (count > 0)
                {
                    results = results.Remove(results.Length - 2);
                }
                results = number.ToString() + " = " + results;
                Console.WriteLine(results);
            }
            Console.WriteLine("Press <ENTER> to End");
            Console.ReadLine();
        }
  
    }
}
