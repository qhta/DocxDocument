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
    if (!BooleanConverterTest.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    if (!SimpleValueConverterTest.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    Console.WriteLine("All tests passed.");
  }
}