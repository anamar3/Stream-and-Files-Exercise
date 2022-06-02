namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if(Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
   

            Directory.CreateDirectory(outputPath);
            string [] files = Directory.GetFiles(inputPath);
            foreach (var item in files)
            {
                var fileName = Path.GetFileName(item);
                var copyDestination = Path.Combine(outputPath, fileName);
                File.Copy(fileName, copyDestination);
            }
           
            
            
        }
    }
}
