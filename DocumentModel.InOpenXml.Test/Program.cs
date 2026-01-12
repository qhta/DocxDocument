using System;

namespace DocumentModel.InOpenXml.Test
{
  internal class Program
  {
    static void Main(string[] args)
    {
      bool result = CorePropertiesSerializationTest.Run();
      Console.WriteLine(result ? "All tests passed." : "Some tests failed.");
    }
  }
}
