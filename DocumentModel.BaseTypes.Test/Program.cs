using System.Globalization;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Entry point for the base types serialization test program.
/// </summary>
class Program
{
  static void Main(string[] args)
  {
    // Set culture to invariant to ensure consistent formatting across tests
    CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
    // Ensure Unicode characters display correctly
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║   DocumentModel Base Types Serialization Test Suite        ║");
    Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
    Console.WriteLine();
    //if (!Exec(ArrayVariantTests.Run)) return;
    //if (!Exec(Base64BinaryTest.Run)) return;
    //if (!Exec(BytePercentTest.Run)) return;
    if (!Exec(EMUTest.Run)) return;
    if (!Exec(HPSTest.Run)) return;
    //if (!Exec(HPSTest.Run)) return;
    //if (!Exec(HexBinaryTest.Run)) return;
    //if (!Exec(HexCharTest.Run)) return;
    //if (!Exec(HexIntTest.Run)) return;
    //if (!Exec(HexLongTest.Run)) return;
    //if (!Exec(HexRgbTest.Run)) return;
    //if (!Exec(ListOfTest.Run)) return;
    //if (!Exec(PercentTest.Run)) return;
    //if (!Exec(PTSTest.Run)) return;
    //if (!Exec(TSBooleanTest.Run)) return;
    //if (!Exec(StringListTest.Run)) return;
    //if (!Exec(StrNumPairTest.Run)) return;
    //if (!Exec(TwipsTest.Run)) return;
    //if (!Exec(VariantTest.Run)) return;
    //if (!Exec(VClipboardDataTest.Run)) return;
    //if (!Exec(VectorVariantTest.Run)) return;
    //if (!Exec(VStreamDataTest.Run)) return;

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