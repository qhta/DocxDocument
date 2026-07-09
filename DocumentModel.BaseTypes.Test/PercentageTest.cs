using System.Globalization;

// ReSharper disable SpecifyACultureInStringConversionExplicitly

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for Percentage type serialization in both XML and JSON formats.
/// </summary>
public static class PercentageTest
{
  /// <summary>
  /// Runs all Percentage serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== Percentage Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestPercentageBasicOperations()) return false;
    if (!TestPercentageXmlSerialization()) return false;
    if (!TestPercentageJsonSerialization()) return false;
    if (!TestPercentageEdgeCases()) return false;
    if (!TestPercentagePerformance()) return false;

    return true;
  }

  
  static bool TestPercentageBasicOperations()
  {
    Console.WriteLine("--- Testing Percentage Basic Operations ---");      // Test string to Percentage conversion
    Percentage pct1 = "50%";
    Console.WriteLine($"\n✓ String to Percentage: {pct1} = {(double)pct1}");

    // Test double to Percentage conversion
    Percentage pct2 = new Percentage("50%");
    Console.WriteLine($"\n✓ Double to Percentage: {pct2}");

    // Test equality
    if (pct1.Equals(pct2))
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test Percentage to string with %
    string str = pct1.ToString();
    Console.WriteLine($"\n✓ Percentage to string: {str}");

    // Test Percentage to double
    double value = pct1.ToDouble(null);
    Console.WriteLine($"\n✓ Percentage to double: {value}");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {pct1.GetHashCode()}");

    // Test various numeric conversions
    int intVal = (int)pct1;
    uint uintVal = (uint)pct1;
    short shortVal = (short)pct1;
    Console.WriteLine($"\n✓ Numeric conversions: int={intVal}, uint={uintVal}, short={shortVal}");

    // Test with precision
    string preciseStr = pct1.ToString(2, "%");
    Console.WriteLine($"\n✓ ToString with precision 2: {preciseStr}");

    // Test comparison
    Percentage pct3 = new Percentage("75%");
    Console.WriteLine($"\n✓ CompareTo (50 vs 75): {pct1.CompareTo(pct3)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestPercentageXmlSerialization()
  {
    Console.WriteLine("--- Testing Percentage XML Serialization ---");      // Create test object
    var testData = new PercentageTestData
    {
      CompletionRate = new Percentage(75.5),
      SuccessRate = new Percentage(99.9),
      ErrorRate = new Percentage(0.1),
      ZeroPercentage = new Percentage(0),
      HundredPercentage = new Percentage(100),
      FractionalPercentage = new Percentage(33.333),
      NegativePercentage = new Percentage(-5.5)
    };

    Console.WriteLine($"Original data:");
    Console.WriteLine($"  CompletionRate: {testData.CompletionRate}");
    Console.WriteLine($"  SuccessRate: {testData.SuccessRate}");
    Console.WriteLine($"  ErrorRate: {testData.ErrorRate}");
    Console.WriteLine($"  ZeroPercentage: {testData.ZeroPercentage}");
    Console.WriteLine($"  HundredPercentage: {testData.HundredPercentage}");
    Console.WriteLine($"  FractionalPercentage: {testData.FractionalPercentage}");
    Console.WriteLine($"  NegativePercentage: {testData.NegativePercentage}");
    Console.WriteLine();

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(PercentageTestData));
    string xmlString;

    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
    {
      Indent = true,
      OmitXmlDeclaration = false,
      Encoding = System.Text.Encoding.UTF8
    }))
    {
      xmlSerializer.Serialize(xmlWriter, testData);
      xmlString = stringWriter.ToString();
    }

    Console.WriteLine("Serialized XML:");
    Console.WriteLine(xmlString);
    Console.WriteLine();

    // Deserialize from XML
    PercentageTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (PercentageTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(PercentageTestData? deserializedData, PercentageTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  CompletionRate: {deserializedData.CompletionRate}");
    if (!testData.CompletionRate.Equals(deserializedData.CompletionRate))
      return false;
    Console.WriteLine($"  SuccessRate: {deserializedData.SuccessRate}");
    if (!testData.SuccessRate.Equals(deserializedData.SuccessRate))
      return false;
    Console.WriteLine($"  ErrorRate: {deserializedData.ErrorRate}");
    if (!testData.ErrorRate.Equals(deserializedData.ErrorRate))
      return false;
    Console.WriteLine($"  ZeroPercentage: {deserializedData.ZeroPercentage}");
    if (!testData.ZeroPercentage.Equals(deserializedData.ZeroPercentage))
      return false;
    Console.WriteLine($"  HundredPercentage: {deserializedData.HundredPercentage}");
    if (!testData.HundredPercentage.Equals(deserializedData.HundredPercentage))
      return false;
    Console.WriteLine($"  FractionalPercentage: {deserializedData.FractionalPercentage}");
    if (!testData.FractionalPercentage.Equals(deserializedData.FractionalPercentage))
      return false;
    Console.WriteLine($"  NegativePercentage: {deserializedData.NegativePercentage}");
    if (!testData.NegativePercentage.Equals(deserializedData.NegativePercentage))
      return false;

    return true;
  }

  
  
  static bool TestPercentageJsonSerialization()
  {
    Console.WriteLine("--- Testing Percentage JSON Serialization ---");      // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to JSON
    var jsonOptions = new JsonSerializerOptions
    {
      WriteIndented = true,
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    string jsonString = JsonSerializer.Serialize(testData, jsonOptions);

    Console.WriteLine("Serialized JSON:");
    Console.WriteLine(jsonString);
    Console.WriteLine();

    // Deserialize from JSON
    var deserializedData = JsonSerializer.Deserialize<PercentageTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  private static PercentageTestData CreateTestData()
  {
    return new PercentageTestData
    {
      CompletionRate = new Percentage(75.5),
      SuccessRate = new Percentage(98.0),
      ErrorRate = new Percentage(2.0),
      ZeroPercentage = new Percentage(0),
      HundredPercentage = new Percentage(100),
      FractionalPercentage = new Percentage(33.333),
      NegativePercentage = new Percentage(-5.5)
    };
  }

  private static void ShowOriginalData(PercentageTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  CompletionRate: {testData.CompletionRate}");
    Console.WriteLine($"  SuccessRate: {testData.SuccessRate}");
    Console.WriteLine($"  ErrorRate: {testData.ErrorRate}");
    Console.WriteLine($"  ZeroPercentage: {testData.ZeroPercentage}");
    Console.WriteLine($"  HundredPercentage: {testData.HundredPercentage}");
    Console.WriteLine($"  FractionalPercentage: {testData.FractionalPercentage}");
    Console.WriteLine($"  NegativePercentage: {testData.NegativePercentage}");
    Console.WriteLine();
  }

  
  static bool TestPercentageEdgeCases()
  {
    Console.WriteLine("--- Testing Percentage Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    Percentage zero = new Percentage(0);
    Console.WriteLine($"  Zero: '{zero}' ({zero.ToDouble(null)})");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    Percentage minPercentage = new Percentage(0);
    Percentage maxPercentage = new Percentage(100);
    Console.WriteLine($"  Min (0%): '{minPercentage}'");
    Console.WriteLine($"  Max (100%): '{maxPercentage}'");

    // Test negative values
    Console.WriteLine("\nTesting negative values:");
    Percentage negative = new Percentage(-25.5);
    Console.WriteLine($"  Negative (-25.5%): '{negative}'");

    // Test large values (beyond 100%)
    Console.WriteLine("\nTesting values beyond 100%:");
    Percentage large = new Percentage(250.0);
    Console.WriteLine($"  Large (250%): '{large}'");

    // Test fractional values
    Console.WriteLine("\nTesting fractional values:");
    Percentage third = new Percentage(33.333333);
    Percentage twoThirds = new Percentage(66.666667);
    Console.WriteLine($"  One third: '{third}'");
    Console.WriteLine($"  Two thirds: '{twoThirds}'");

    // Test very small fractional values
    Console.WriteLine("\nTesting very small fractional values:");
    Percentage tiny = new Percentage(0.001);
    Console.WriteLine($"  0.001%: '{tiny}'");

    // Test string parsing with and without % suffix
    Console.WriteLine("\nTesting string parsing:");
    Percentage withPercentage = "75.5%";
    Percentage withoutPercentage = "75.5";
    Console.WriteLine($"  \"75.5%\" → {withPercentage}");
    Console.WriteLine($"  \"75.5\" → {withoutPercentage}");
    Console.WriteLine($"  Are equal: {withPercentage.Equals(withoutPercentage)}");

    // Test string parsing with comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    Percentage commaDecimal = "75,5";
    Console.WriteLine($"  \"75,5\" → {commaDecimal}");

    // Test JSON numeric vs string input
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // String format with %
    string jsonStringWithPercentage = "{\"Value\":\"50%\"}";
    var fromStringPercentage = JsonSerializer.Deserialize<PercentageWrapper>(jsonStringWithPercentage);
    Console.WriteLine($"  From JSON string \"50%\": {fromStringPercentage?.Value}");

    // String format without %
    string jsonStringWithoutPercentage = "{\"Value\":\"50\"}";
    var fromStringNoPercentage = JsonSerializer.Deserialize<PercentageWrapper>(jsonStringWithoutPercentage);
    Console.WriteLine($"  From JSON string \"50\": {fromStringNoPercentage?.Value}");

    // Numeric format
    string jsonNumeric = "{\"Value\":50.5}";
    var fromNumeric = JsonSerializer.Deserialize<PercentageWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 50.5: {fromNumeric?.Value}");

    // Test formatting with precision
    Console.WriteLine("\nTesting formatted output:");
    Percentage pct = new Percentage(75.12345);
    Console.WriteLine($"  Default: {pct.ToString()}");
    Console.WriteLine($"  No unit: {pct.ToString(CultureInfo.InvariantCulture, null)}");
    Console.WriteLine($"  Precision 0: {pct.ToString(0, "%")}");
    Console.WriteLine($"  Precision 2: {pct.ToString(2, "%")}");
    Console.WriteLine($"  Precision 4: {pct.ToString(4, "%")}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    Percentage small = new Percentage(25.5);
    Percentage large2 = new Percentage(75.5);
    Console.WriteLine($"  25.5% < 75.5%: {small.CompareTo(large2) < 0}");
    Console.WriteLine($"  75.5% > 25.5%: {large2.CompareTo(small) > 0}");
    Console.WriteLine($"  50% == 50%: {new Percentage(50).CompareTo(new Percentage(50)) == 0}");

    // Test IConvertible implementation
    Console.WriteLine("\nTesting IConvertible conversions:");
    Percentage convertTest = new Percentage(42.75);
    Console.WriteLine($"  ToByte: {convertTest.ToByte(null)}");
    Console.WriteLine($"  ToInt32: {convertTest.ToInt32(null)}");
    Console.WriteLine($"  ToDouble: {convertTest.ToDouble(null)}");
    Console.WriteLine($"  ToDecimal: {convertTest.ToDecimal(null)}");

    // Test ToType conversions
    Console.WriteLine("\nTesting ToType conversions:");
    var asInt32 = (int)convertTest.ToType(typeof(Int32), null);
    var asDouble = (double)convertTest.ToType(typeof(Double), null);
    var asString = (string)convertTest.ToType(typeof(String), null);
    Console.WriteLine($"  ToType(Int32): {asInt32}");
    Console.WriteLine($"  ToType(Double): {asDouble}");
    Console.WriteLine($"  ToType(String): {asString}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestPercentagePerformance()
  {
    Console.WriteLine("--- Testing Percentage Performance ---"); const int iterations = 100000;

    // Test construction from string
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      Percentage pct = "50.5%";
    }
    sw.Stop();
    Console.WriteLine($"Construction from string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from double
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      Percentage pct = new Percentage(50.5);
    }
    sw.Stop();
    Console.WriteLine($"Construction from double x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    Percentage testPct = new Percentage(50.5);
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testPct.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString with precision
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testPct.ToString(2, "%");
    }
    sw.Stop();
    Console.WriteLine($"ToString(precision) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new PercentageTestData
    {
      CompletionRate = new Percentage(75.5),
      SuccessRate = new Percentage(99.9),
      ErrorRate = new Percentage(0.1),
      ZeroPercentage = new Percentage(0),
      HundredPercentage = new Percentage(100),
      FractionalPercentage = new Percentage(33.333),
      NegativePercentage = new Percentage(-5.5)
    };

    sw.Restart();
    for (int i = 0; i < iterations / 10; i++)
    {
      string json = JsonSerializer.Serialize(testObj);
    }
    sw.Stop();
    Console.WriteLine($"JSON Serialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test Deserialization performance
    string jsonData = JsonSerializer.Serialize(testObj);
    sw.Restart();
    for (int i = 0; i < iterations / 10; i++)
    {
      var obj = JsonSerializer.Deserialize<PercentageTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test comparison performance
    Percentage pct1 = new Percentage(50.5);
    Percentage pct2 = new Percentage(50.5);
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int result = pct1.CompareTo(pct2);
    }
    sw.Stop();
    Console.WriteLine($"CompareTo() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test equality performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      bool result = pct1.Equals(pct2);
    }
    sw.Stop();
    Console.WriteLine($"Equals() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test implicit conversions performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double value = pct1.ToDouble(null);
    }
    sw.Stop();
    Console.WriteLine($"ToDouble() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int value = (int)pct1;
    }
    sw.Stop();
    Console.WriteLine($"Implicit conversion to int x {iterations}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  }


/// <summary>
/// Test data class containing various Percentage properties.
/// </summary>
[XmlRoot("PercentageTestData")]
public class PercentageTestData
{
  [XmlElement("CompletionRate")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Percentage CompletionRate { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("SuccessRate")]
  public Percentage SuccessRate { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ErrorRate")]
  public Percentage ErrorRate { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ZeroPercentage")]
  public Percentage ZeroPercentage { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("HundredPercentage")]
  public Percentage HundredPercentage { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("FractionalPercentage")]
  public Percentage FractionalPercentage { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("NegativePercentage")]
  public Percentage NegativePercentage { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class PercentageWrapper
{
  public Percentage Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


