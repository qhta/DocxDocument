public static class Program
{
  public static void Main(params string[] args)
  {
    //RunReadTest();
    RunReadWriteTest();
    //RunSerializationTest();
  }

  private static void RunReadTest()
  {
    var test = new DocxDocument.Test.ReadWriteTest();
    test.Output = Console.Out;
    test.Initialize();
    Console.WriteLine($"Opening directory: {test.SamplesPath}");
    Console.WriteLine();
    test.TestOpenAllFiles();
    test.TestReadProperties();
    test.TestReadSettings();
  }

  private static void RunReadWriteTest()
  {
    var test = new DocxDocument.Test.ReadWriteTest();
    test.Output = Console.Out;
    test.Initialize();
    Console.WriteLine($"Opening directory: {test.SamplesPath}");
    Console.WriteLine();
    test.TestCreate();
    test.TestCreateProperties();
    test.TestCopyPropertiesOne();
  }

  private static void RunSerializationTest()
  {
    var test = new DocxDocument.Test.SerializationTest();
    test.Output = Console.Out;
    test.Initialize();
    Console.WriteLine($"Opening directory: {test.SamplesPath}");
    Console.WriteLine();
    test.TestSerializeAndDeserializeOne();
    test.TestSerializeAndDeserializeAll();
  }
}

