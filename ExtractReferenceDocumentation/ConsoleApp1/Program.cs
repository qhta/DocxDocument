using ModelDocumentation;

namespace ConsoleApp1;

internal class Program
{
  static void Main(string[] args)
  {
    ModelDoc.Instance.LoadData();
    var filename = ModelDoc.Instance.GetFilename();
    ModelDoc.Instance.SaveData(Path.ChangeExtension(filename,"chk"));
  }
}
