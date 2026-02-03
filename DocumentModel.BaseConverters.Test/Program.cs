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
    if (!Run(BooleanConverterTest.Run))
      return;
    if (!Run(TSBooleanConverterTest.Run))
      return;
    if (!Run(StringConverterTest.Run))
      return;
    if (!Run(Int32ConverterTest.Run))
      return;
    if (!Run(Int64ConverterTest.Run))
      return;
    if (!Run(Int16ConverterTest.Run))
      return;
    if (!Run(SByteConverterTest.Run))
      return;
    if (!Run(ByteConverterTest.Run))
      return;
    if (!Run(UInt16ConverterTest.Run))
      return;
    if (!Run(UInt32ConverterTest.Run))
      return;
    if (!Run(UInt64ConverterTest.Run))
      return;
    if (!Run(HexIntConverterTest.Run))
      return;
    if (!Run(HexLongConverterTest.Run))
      return;
    if (!Run(HexCharConverterTest.Run))
      return;
    if (!Run(StringListConverterTest.Run))
      return;
    if (!Run(RgbConverterTest.Run))
      return;
    if (!Run(HexBinaryConverterTest.Run))
      return;
    if (!Run(DecimalConverterTest.Run))
      return;
    if (!Run(SingleConverterTest.Run))
      return;
    if (!Run(EnumConverterTest.Run))
      return;
    if (!Run(SimpleValueConverterTest.Run))
      return;

    Console.WriteLine("All tests passed.");
  }

  private static bool Run(Func<bool> runMethod)
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