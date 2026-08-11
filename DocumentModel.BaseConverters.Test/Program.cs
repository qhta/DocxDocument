namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Entry point for the DocumentModel BaseConverters test suite. Runs all converter tests and reports results to the console.
/// </summary>
internal class Program
{
  /// <summary>
  ///   Main method that executes all converter tests and prints the results. Exits early if any test fails.
  /// </summary>
  /// <param name="args">Command-line arguments (not used).</param>
  static void Main(string[] args)
  {
    // Ensure Unicode characters display correctly
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine("╔══════════════════════════════════════════════════╗");
    Console.WriteLine("║   DocumentModel BaseConverters Test Suite        ║");
    Console.WriteLine("╚══════════════════════════════════════════════════╝");
    Console.WriteLine();
    if (!Exec(BooleanConverterTest.Run)) return;
    if (!Exec(TSBooleanConverterTest.Run)) return;
    if (!Exec(StringConverterTest.Run)) return;
    if (!Exec(Int32ConverterTest.Run)) return;
    if (!Exec(Int64ConverterTest.Run)) return;
    if (!Exec(Int16ConverterTest.Run)) return;
    if (!Exec(SByteConverterTest.Run)) return;
    if (!Exec(ByteConverterTest.Run)) return;
    if (!Exec(UInt16ConverterTest.Run)) return;
    if (!Exec(UInt32ConverterTest.Run)) return;
    if (!Exec(UInt64ConverterTest.Run)) return;
    if (!Exec(HexIntConverterTest.Run)) return;
    if (!Exec(HexLongConverterTest.Run)) return;
    if (!Exec(HexCharConverterTest.Run)) return;
    if (!Exec(StringListConverterTest.Run)) return;
    if (!Exec(RgbConverterTest.Run)) return;
    if (!Exec(HexBinaryConverterTest.Run)) return;
    if (!Exec(DecimalConverterTest.Run)) return;
    if (!Exec(SingleConverterTest.Run)) return;
    if (!Exec(DoubleConverterTest.Run)) return;
    if (!Exec(EnumConverterTest.Run)) return;
    if (!Exec(BytePercentConverterTest.Run)) return;
    if (!Exec(PercentageConverterTest.Run)) return;
    if (!Exec(HexPercentConverterTest.Run)) return;
    if (!Exec(DegreesConverterTest.Run)) return;
    if (!Exec(TwipsConverterTest.Run)) return;
    if (!Exec(SimpleValueConverterTest.Run)) return;

    Console.WriteLine("All tests passed.");
  }

  private static bool Exec(Func<bool> runMethod)
  {
    if (!runMethod())
    {
      Console.WriteLine("\nSome tests failed."); return false;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine(); return true;
  }
}
