namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversal
{
    static void Main()
    {
        string path = Console.ReadLine();
        string reportFileName = @"\report.txt";

        string reportContent = TraverseDirectory(path);
        Console.WriteLine(reportContent);

        WriteReportToDesktop(reportContent, reportFileName);
    }

    public static string TraverseDirectory(string inputFolderPath)
    {
            string[] files = Directory.GetFiles(inputFolderPath);
            Dictionary<string, List<FileInfo>> extensionsInfo = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                string extension = info.Extension;

                if(!extensionsInfo.ContainsKey(extension))
                {
                    extensionsInfo.Add(extension,new List<FileInfo>());
                }
                extensionsInfo[extension].Add(info);

            }
           

            foreach (var entry in extensionsInfo.OrderByDescending(entry => entry.Value.Count).ThenBy(entry => entry.Key))
            {
                string extension = entry.Key;
                List<FileInfo> filesInfo = entry.Value;
                filesInfo.OrderByDescending(file => file.Length);

                foreach (var item in filesInfo)
                {
                    Console.WriteLine($"--{item.Name} - {item.Length / 1024:f3}kb");
                }
            }
            return "";
        }

    public static void WriteReportToDesktop(string textContent, string reportFileName)
    {
            string pathReport = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(pathReport, textContent);
    }
}
}
