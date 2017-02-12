using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace IntegerFactors
{
    public static class FileIO
    {
        public static List<int> ReadtheFile(string FileName)
        {
            List<int> inputInts = new List<int>();
            // using will make sure the file is closed
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(FileName))
                {
                    string line = file.ReadLine();
                    while (line != null)
                    {
                        int inputInt;

                        if (int.TryParse(line, out inputInt) == true)
                        {
                            inputInts.Add(inputInt);
                        }
                        else
                        {
                            throw new InvalidDataException();
                        }
                        line = file.ReadLine();
                    }


                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
                //Console.WriteLine("File not Found....try again");
            }
            catch (FileLoadException)
            {
                throw new FileLoadException();
            }

            catch (InvalidDataException)
            {
                throw new InvalidDataException();
            }
            catch (Exception)
            {
                Console.WriteLine("File Error...try again");
                return inputInts;
            }

            return inputInts;
        }
    }
}
