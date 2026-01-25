namespace DocumentModel.BaseConverters.Test;

internal class Program
{
  static void Main(string[] args)
  {
    // Ensure Unicode characters display correctly
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine("╔══════════════════════════════════════════════════╗");
    Console.WriteLine("║   DocumentModel BaseConverters Test Suite        ║");
    Console.WriteLine("╚══════════════════════════════════════════════════╝");
    Console.WriteLine();
    if (!StringOpenXmlConverterTest.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    if (!BooleanOpenXmlConverterTest.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    if (!Int32OpenXmlConverterTest.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    if (!Int64OpenXmlConverterTest.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    if (!Int16OpenXmlConverterTest.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    if (!SByteOpenXmlConverterTest.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    if (!ByteOpenXmlConverterTest.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    if (!UInt16OpenXmlConverterTest.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    if (!UInt32OpenXmlConverterTest.Run())
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