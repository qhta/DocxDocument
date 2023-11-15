public static class Program
{
  public static void Main(params string[] args)
  {
    bool success = true;
    //RunReadTest();
    if (!RunReadWriteTest()) {success = false;}
    //RunSerializationTest();

    if (success) 
      Console.WriteLine($"All tests PASSED");
    else
      Console.WriteLine($"Tests FAILED");
  }

  private static bool RunReadTest()
  {
    var test = new DocxDocument.Test.ReadWriteTest();
    test.Output = Console.Out;
    test.Initialize();
    Console.WriteLine($"Opening directory: {test.SamplesPath}");
    Console.WriteLine();
    if (!test.TestOpenAllFiles()) return false;
    if (!test.TestReadProperties()) return false;
    if (!test.TestReadSettings()) return false;
    return true;
  }

  private static bool RunReadWriteTest()
  {
    var test = new DocxDocument.Test.ReadWriteTest();
    test.Output = Console.Out;
    test.Initialize();
    Console.WriteLine($"Opening directory: {test.SamplesPath}");
    Console.WriteLine();
    if (!test.TestCreate()) return false;
    if (!test.TestCopyPropertiesOne()) return false;
    if (!test.TestCreateProperties()) return false;
    if (!test.TestCreateSettings()) return false;
    return true;
  }

  private static bool RunSerializationTest()
  {
    var test = new DocxDocument.Test.SerializationTest();
    test.Output = Console.Out;
    test.Initialize();
    Console.WriteLine($"Opening directory: {test.SamplesPath}");
    Console.WriteLine();
    if (!test.TestSerializeAndDeserializeOne()) return false;
    if (!test.TestSerializeAndDeserializeAll()) return false;
    return true;
  }
}

