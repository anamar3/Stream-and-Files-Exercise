
using System;
using System.IO;
using System.Linq;

namespace EvenLines
{

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            int count = 0;
            var reader = new StreamReader(inputFilePath);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {

                    if (count % 2 == 0)
                    {
                        Console.WriteLine(ProcessLines(line));
                    }
                    line = reader.ReadLine();
                        
            }
        }

                       
        }

        public static string ProcessLines(string line)
        {
            
            
                        foreach (var item in line)
                        {
                            if (item == '-' || item == ',' || item == '.' || item == '!' || item == '?')
                            {
                                line = line.Replace(item, '@');
                            }
                        }
                        line = string.Join(" ",line.Split().Reverse());
            return line;
           }
                  
                   
       }


     }


