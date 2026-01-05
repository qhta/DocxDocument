
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

    // ReSharper disable once ReplaceWithSingleAssignment.True
    bool allTestsPassed = true;

    // Run HexBinary tests
    if (!HexBinarySerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run HexChar tests
    if (!HexCharSerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run HexInt tests
    if (!HexIntSerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run BaseBinary tests
    if (!Base64BinarySerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run BytePercent tests
    if (!BytePercentSerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run Percent tests
    if (!PercentSerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run Points tests
    if (!PointsSerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run Twips tests
    if (!TwipsSerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run HalfPoints tests
    if (!HalfPointsSerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run EighthPoints tests
    if (!EighthPointsSerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run RGBPoints tests
    if (!RGBSerializationTests.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine  ("╔════════════════════════════════════════════════════════════╗");
    if (allTestsPassed)
      Console.WriteLine("║         ✓ All Test Suites Passed Successfully              ║");
    else
      Console.WriteLine("║         ✗ Some Tests Failed - Check Output Above           ║");
    Console.WriteLine  ("╚════════════════════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();

    // Exit with appropriate code
    Environment.Exit(allTestsPassed ? 0 : 1);
  }
}