using System;

namespace DocumentModel.InOpenXml.Test;

internal class Program
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

    // Run CoreProperties tests
    if (!CorePropertiesTest.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run ContentProperties tests
    if (!ContentPropertiesTest.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run StatisticProperties tests
    if (!StatisticPropertiesTest.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run CustomProperties tests
    if (!CustomPropertiesTest.Run())
      allTestsPassed = false;

    //Console.WriteLine();
    //Console.WriteLine("═══════════════════════════════════════════════════════════");
    //Console.WriteLine();

    //// Run DocumentSettingsSerialization tests
    //if (!DocumentSettingsSerializationTest.Run())
    //  allTestsPassed = false;

    //Console.WriteLine();
    //Console.WriteLine("═══════════════════════════════════════════════════════════");
    //Console.WriteLine();


    Console.WriteLine(allTestsPassed ? "All tests passed." : "Some tests failed.");
  }
}

