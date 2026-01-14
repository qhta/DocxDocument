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

    // Run CorePropertiesSerialization tests
    if (!CorePropertiesSerializationTest.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run ContentPropertiesSerialization tests
    if (!ContentPropertiesSerializationTest.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();


    // Run CustomPropertiesSerialization tests
    if (!CustomPropertiesSerializationTest.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();

    // Run DocumentSettingsSerialization tests
    if (!DocumentSettingsSerializationTest.Run())
      allTestsPassed = false;

    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();


    Console.WriteLine(allTestsPassed ? "All tests passed." : "Some tests failed.");
  }
}

