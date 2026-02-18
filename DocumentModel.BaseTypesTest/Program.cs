namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Entry point for the base types serialization test program.
/// </summary>
class Program
{
  static void Main(string[] args)
  {
    // Ensure Unicode characters display correctly
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║   DocumentModel Base Types Serialization Test Suite        ║");
    Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
    Console.WriteLine();
    if (!Exec(HexBinarySerializationTests.Run))
      return;
    if (!Exec(HexCharSerializationTests.Run))
      return;
    if (!Exec(HexIntSerializationTests.Run))
      return;
    if (!Exec(HexLongSerializationTests.Run))
      return;
    if (!Exec(Base64BinarySerializationTests.Run))
      return;
    if (!Exec(BytePercentSerializationTests.Run))
      return;
    if (!Exec(PercentSerializationTests.Run))
      return;
    if (!Exec(PointsSerializationTests.Run))
      return;
    if (!Exec(TwipsSerializationTests.Run))
      return;
    if (!Exec(HalfPointsSerializationTests.Run))
      return;
    if (!Exec(EighthPointsSerializationTests.Run))
      return;
    if (!Exec(HexRgbSerializationTests.Run))
      return;
    if (!Exec(StrNumPairSerializationTests.Run))
      return;
    if (!Exec(StringListSerializationTests.Run))
      return;
    if (!Exec(ListOfSerializationTests.Run))
      return;
    if (!Exec(ArrayVariantSerializationTests.Run))
      return;
    if (!Exec(VectorVariantSerializationTests.Run))
      return;
    if (!Exec(VClipboardDataSerializationTests.Run))
      return;
    if (!Exec(VStreamDataSerializationTests.Run))
      return;
    if (!Exec(VariantSerializationTests.Run))
      return;

    Console.WriteLine();
    Console.WriteLine("All tests passed.");
  }

  private static bool Exec(Func<bool> runMethod)
  {
    if (!runMethod())
    {
      Console.WriteLine("\nSome tests failed.");
      return false;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    return true;
  }
}