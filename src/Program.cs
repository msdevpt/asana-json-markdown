using System.Text;
using System.Text.Json;
using models;

if (Environment.GetCommandLineArgs().Count() == 2)
{
    Console.WriteLine("Usage: app.exe <in.json> <out.md>");
    Environment.Exit(1);
}

var fileName = Environment.GetCommandLineArgs()[1];
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

var fileDest = Environment.GetCommandLineArgs()[2];
SaveTasks(sb, fileDest);

Console.WriteLine("File successfully converted");


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