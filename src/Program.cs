using System.Text;
using System.Text.Json;
using Models;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
          if (args.Length != 2)
          {
              Console.WriteLine("Usage: app.exe <in.json> <out.md>");
              Environment.Exit(1);
          }

          var fileName = args[0];
          if (!File.Exists(fileName))
          {
              Console.WriteLine($"File {fileName} not found");
              Environment.Exit(1);
          }

          string jsonString = System.IO.File.ReadAllText(fileName);
          Root? tasks = JsonSerializer.Deserialize<Root>(jsonString);

          if (tasks is null)
          {
              Console.WriteLine("Invalid JSON");
              Environment.Exit(1);
          }

          StringBuilder sb = GetTasksConverted(tasks);

          var fileDest = args[1];
          SaveTasks(sb, fileDest);

          Console.WriteLine("File successfully converted");
        }

        static StringBuilder GetTasksConverted(Root? tasks)
        {
          var sb = new StringBuilder();
          foreach (var task in tasks.data)
          {
            sb.AppendLine("- **" + task.name + "** - due " + task.due_on);
            foreach (var subtask in task.subtasks)
            {
              sb.AppendLine("\t- " + subtask.name);
            }
          }

          return sb;
        }

        static void SaveTasks(StringBuilder sb, string fileDest)
        {
          StreamWriter sw = new StreamWriter(fileDest, true);
          sw.Write(sb.ToString());
          sw.Close();
        }
    }
}

