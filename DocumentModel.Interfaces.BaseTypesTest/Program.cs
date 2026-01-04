namespace DocumentModel.Interfaces.BaseTypesTest;

/// <summary>
/// Test program for HexBinary type serialization in both XML and JSON formats.
/// </summary>
class Program
{
  static void Main(string[] args)
  {
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    if (!HexBinarySerializationTests.Run()) return;
    if (!HexCharSerializationTests.Run()) return;
    Console.WriteLine();
    Console.WriteLine("=== All Tests Completed ===");
    Console.ReadKey();
  }
}


