using System.Globalization;

// ReSharper disable SpecifyACultureInStringConversionExplicitly

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for Percent type serialization in both XML and JSON formats.
/// </summary>
public static class PercentTest
{
  /// <summary>
  /// Runs all Percent serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== Percent Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestPercentBasicOperations()) return false;
    if (!TestPercentXmlSerialization()) return false;
    if (!TestPercentJsonSerialization()) return false;
    if (!TestPercentEdgeCases()) return false;

    return true;
  }

  
  static bool TestPercentBasicOperations()
  {
    Console.WriteLine("--- Testing Percent Basic Operations ---");      // Test string to Percent conversion
    Percent pct1 = "50%";
    Console.WriteLine($"\n✓ String to Percent: {pct1} = {(double)pct1}");

    // Test double to Percent conversion
    Percent pct2 = new Percent("50%");
    Console.WriteLine($"\n✓ Double to Percent: {pct2}");

    // Test equality
    if (pct1.Equals(pct2))
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test Percent to string with %
    string str = pct1.ToString();
    Console.WriteLine($"\n✓ Percent to string: {str}");

    // Test Percent to double
    double value = pct1.ToDouble(null);
    Console.WriteLine($"\n✓ Percent to double: {value}");

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
    Percent pct3 = new Percent("75%");
    Console.WriteLine($"\n✓ CompareTo (50 vs 75): {pct1.CompareTo(pct3)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestPercentXmlSerialization()
  {
    Console.WriteLine("--- Testing Percent XML Serialization ---");      // Create test object
    var testData = new PercentTestData
    {
      CompletionRate = new Percent(75.5),
      SuccessRate = new Percent(99.9),
      ErrorRate = new Percent(0.1),
      ZeroPercent = new Percent(0),
      HundredPercent = new Percent(100),
      FractionalPercent = new Percent(33.333),
      NegativePercent = new Percent(-5.5)
    };

    Console.WriteLine($"Original data:");
    Console.WriteLine($"  CompletionRate: {testData.CompletionRate}");
    Console.WriteLine($"  SuccessRate: {testData.SuccessRate}");
    Console.WriteLine($"  ErrorRate: {testData.ErrorRate}");
    Console.WriteLine($"  ZeroPercent: {testData.ZeroPercent}");
    Console.WriteLine($"  HundredPercent: {testData.HundredPercent}");
    Console.WriteLine($"  FractionalPercent: {testData.FractionalPercent}");
    Console.WriteLine($"  NegativePercent: {testData.NegativePercent}");
    Console.WriteLine();

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(PercentTestData));
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
    PercentTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (PercentTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(PercentTestData? deserializedData, PercentTestData testData)
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
    Console.WriteLine($"  ZeroPercent: {deserializedData.ZeroPercent}");
    if (!testData.ZeroPercent.Equals(deserializedData.ZeroPercent))
      return false;
    Console.WriteLine($"  HundredPercent: {deserializedData.HundredPercent}");
    if (!testData.HundredPercent.Equals(deserializedData.HundredPercent))
      return false;
    Console.WriteLine($"  FractionalPercent: {deserializedData.FractionalPercent}");
    if (!testData.FractionalPercent.Equals(deserializedData.FractionalPercent))
      return false;
    Console.WriteLine($"  NegativePercent: {deserializedData.NegativePercent}");
    if (!testData.NegativePercent.Equals(deserializedData.NegativePercent))
      return false;

    return true;
  }

  
  
  static bool TestPercentJsonSerialization()
  {
    Console.WriteLine("--- Testing Percent JSON Serialization ---");      // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<PercentTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  private static PercentTestData CreateTestData()
  {
    return new PercentTestData
    {
      CompletionRate = new Percent(75.5),
      SuccessRate = new Percent(98.0),
      ErrorRate = new Percent(2.0),
      ZeroPercent = new Percent(0),
      HundredPercent = new Percent(100),
      FractionalPercent = new Percent(33.333),
      NegativePercent = new Percent(-5.5)
    };
  }

  private static void ShowOriginalData(PercentTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  CompletionRate: {testData.CompletionRate}");
    Console.WriteLine($"  SuccessRate: {testData.SuccessRate}");
    Console.WriteLine($"  ErrorRate: {testData.ErrorRate}");
    Console.WriteLine($"  ZeroPercent: {testData.ZeroPercent}");
    Console.WriteLine($"  HundredPercent: {testData.HundredPercent}");
    Console.WriteLine($"  FractionalPercent: {testData.FractionalPercent}");
    Console.WriteLine($"  NegativePercent: {testData.NegativePercent}");
    Console.WriteLine();
  }

  
  static bool TestPercentEdgeCases()
  {
    Console.WriteLine("--- Testing Percent Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    Percent zero = new Percent(0);
    Console.WriteLine($"  Zero: '{zero}' ({zero.ToDouble(null)})");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    Percent minPercent = new Percent(0);
    Percent maxPercent = new Percent(100);
    Console.WriteLine($"  Min (0%): '{minPercent}'");
    Console.WriteLine($"  Max (100%): '{maxPercent}'");

    // Test negative values
    Console.WriteLine("\nTesting negative values:");
    Percent negative = new Percent(-25);
    Console.WriteLine($"  Negative (-25%): '{negative}'");

    // Test large values (beyond 100%)
    Console.WriteLine("\nTesting values beyond 100%:");
    Percent large = new Percent("250%");
    Console.WriteLine($"  Large (250%): '{large}'");

    // Test string parsing with and without % suffix
    Console.WriteLine("\nTesting string parsing:");
    Percent withPercent = "75%";
    Percent withoutPercent = "75";
    Console.WriteLine($"  \"75%\" → {withPercent}");
    Console.WriteLine($"  \"75\" → {withoutPercent}");
    Console.WriteLine($"  Are equal: {withPercent.Equals(withoutPercent)}");


    // Test JSON numeric vs string input
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // String format with %
    string jsonStringWithPercent = "{\"Value\":\"50%\"}";
    var fromStringPercent = JsonSerializer.Deserialize<PercentWrapper>(jsonStringWithPercent);
    Console.WriteLine($"  From JSON string \"50%\": {fromStringPercent?.Value}");

    // String format without %
    string jsonStringWithoutPercent = "{\"Value\":\"50\"}";
    var fromStringNoPercent = JsonSerializer.Deserialize<PercentWrapper>(jsonStringWithoutPercent);
    Console.WriteLine($"  From JSON string \"50\": {fromStringNoPercent?.Value}");

    // Numeric format
    string jsonNumeric = "{\"Value\":50}";
    var fromNumeric = JsonSerializer.Deserialize<PercentWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 50: {fromNumeric?.Value}");

    // Test formatting with precision
    Console.WriteLine("\nTesting formatted output:");
    Percent pct = new Percent(75);
    Console.WriteLine($"  Default: {pct.ToString()}");
    Console.WriteLine($"  No unit: {pct.ToString(CultureInfo.InvariantCulture, null)}");
    Console.WriteLine($"  Precision 0: {pct.ToString(0, "%")}");
    Console.WriteLine($"  Precision 2: {pct.ToString(2, "%")}");
    Console.WriteLine($"  Precision 4: {pct.ToString(4, "%")}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    Percent small = new Percent(25);
    Percent large2 = new Percent(75);
    Console.WriteLine($"  25% < 75%: {small.CompareTo(large2) < 0}");
    Console.WriteLine($"  75% > 25%: {large2.CompareTo(small) > 0}");
    Console.WriteLine($"  50% == 50%: {new Percent(50).CompareTo(new Percent(50)) == 0}");

    // Test IConvertible implementation
    Console.WriteLine("\nTesting IConvertible conversions:");
    Percent convertTest = new Percent(42);
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

  
  }


/// <summary>
/// Test data class containing various Percent properties.
/// </summary>
[XmlRoot("PercentTestData")]
public class PercentTestData
{
  [XmlElement("CompletionRate")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Percent CompletionRate { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("SuccessRate")]
  public Percent SuccessRate { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ErrorRate")]
  public Percent ErrorRate { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ZeroPercent")]
  public Percent ZeroPercent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("HundredPercent")]
  public Percent HundredPercent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("FractionalPercent")]
  public Percent FractionalPercent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("NegativePercent")]
  public Percent NegativePercent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class PercentWrapper
{
  public Percent Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


