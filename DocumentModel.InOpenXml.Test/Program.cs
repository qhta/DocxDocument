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

    // Run CoreProperties tests
    if (!CorePropertiesTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run ContentProperties tests
    if (!ContentPropertiesTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run StatisticProperties tests
    if (!StatisticPropertiesTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run CustomProperties tests
    if (!CustomPropertiesTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run DocumentSettingsSerialization tests
    if (!DocumentSettingsTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run Rsids tests
    if (!RsidsTest.Run())
      return;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    Console.WriteLine("All tests passed.");
  }
}

