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

    if (!CorePropertiesTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    if (!ContentPropertiesTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    if (!StatisticPropertiesTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    if (!CustomPropertiesTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    if (!DocumentSettingsTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    if (!RsidsTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    if (!FontsTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    Console.WriteLine("All tests passed.");
  }
}

