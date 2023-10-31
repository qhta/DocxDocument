public static class Program
{
  public static void Main(params string[] args)
  {
    RunReadTest();
  }

  private static void RunReadTest()
  {
  {
    var test = new DocxDocument.Test.ReadWriteTest();
    test.Output = Console.Out;
    test.Initialize();
    Console.WriteLine($"Opening directory: {test.SamplesPath}");
    Console.WriteLine();
    test.TestOpen();
    test.TestReadProperties();
    test.TestReadSettings();
  }
  }

  private static void RunReadWriteTest()
  {
    var test = new DocxDocument.Test.ReadWriteTest();
    test.Output = Console.Out;
    test.Initialize();
    Console.WriteLine($"Opening directory: {test.SamplesPath}");
    Console.WriteLine();
    test.TestCreate();
    test.TestCopyProperties();
  }
}