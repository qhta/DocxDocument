using System;

namespace DocumentModel.InOpenXml.Test;

internal class Program
{
  static void Main(string[] args)
  {
    // Ensure Unicode characters display correctly
    Console.OutputEncoding = System.Text.Encoding.UTF8;

    Console.WriteLine("╔═════════════════════════════════════════════╗");
    Console.WriteLine("║   DocumentModel InOpenXml Test Suite        ║");
    Console.WriteLine("╚═════════════════════════════════════════════╝");
    Console.WriteLine();

    if (!Exec(CorePropertiesTest.Run)) return;
    if (!Exec(ContentPropertiesTest.Run)) return;
    if (!Exec(StatisticPropertiesTest.Run)) return;
    if (!Exec(CustomPropertiesTest.Run)) return;
    if (!Exec(DocumentSettingsTest.Run)) return;
    if (!Exec(RsidsTest.Run)) return;
    if (!Exec(DocumentVariablesTest.Run)) return;
    if (!Exec(FontTableTest.Run)) return;
    if (!Exec(LatentStylesTest.Run))  return;

    Console.WriteLine("All tests passed.");
  }

  /// <summary>
  /// Runs the specified test method and reports the result to the console.
  /// </summary>
  /// <param name="runMethod"></param>
  /// <returns></returns>
  public static bool Exec(Func<bool> runMethod)
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

