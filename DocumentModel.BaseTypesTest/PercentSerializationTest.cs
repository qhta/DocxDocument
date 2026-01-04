using System.Globalization;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for Percent type serialization in both XML and JSON formats.
/// </summary>
public static class PercentSerializationTests
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
    if (!TestPercentPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestPercentBasicOperations()
  {
    Console.WriteLine("--- Testing Percent Basic Operations ---");

    try
    {
      // Test string to Percent conversion
      Percent pct1 = "50%";
      Console.WriteLine($"✓ String to Percent: {pct1} = {(double)pct1}");

      // Test double to Percent conversion
      Percent pct2 = new Percent(50.0);
      Console.WriteLine($"✓ Double to Percent: {pct2}");

      // Test equality
      if (pct1.Equals(pct2))
        Console.WriteLine("✓ Equality test passed");
      else
        Console.WriteLine("✗ Equality test FAILED");

      // Test Percent to string with %
      string str = pct1.ToString();
      Console.WriteLine($"✓ Percent to string: {str}");

      // Test Percent to double
      double value = pct1.ToDouble(null);
      Console.WriteLine($"✓ Percent to double: {value}");

      // Test hash code
      Console.WriteLine($"✓ Hash code: {pct1.GetHashCode()}");

      // Test various numeric conversions
      int intVal = (int)pct1;
      uint uintVal = (uint)pct1;
      short shortVal = (short)pct1;
      Console.WriteLine($"✓ Numeric conversions: int={intVal}, uint={uintVal}, short={shortVal}");

      // Test with precision
      string preciseStr = pct1.ToString(2, "%");
      Console.WriteLine($"✓ ToString with precision 2: {preciseStr}");

      // Test comparison
      Percent pct3 = new Percent(75.0);
      Console.WriteLine($"✓ CompareTo (50 vs 75): {pct1.CompareTo(pct3)} (expected < 0)");

      Console.WriteLine("✓ All basic operations passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Basic operations test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region XML Serialization Tests

  static bool TestPercentXmlSerialization()
  {
    Console.WriteLine("--- Testing Percent XML Serialization ---");

    try
    {
      // Create test object
      var testData = new PercentTestData
      {
        Id = 1,
        Name = "XML Test",
        CompletionRate = new Percent(75.5),
        SuccessRate = new Percent(99.9),
        ErrorRate = new Percent(0.1),
        ZeroPercent = new Percent(0),
        HundredPercent = new Percent(100),
        FractionalPercent = new Percent(33.333),
        NegativePercent = new Percent(-5.5)
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
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

      if (deserializedData == null)
      {
        Console.WriteLine("✗ XML Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  CompletionRate: {deserializedData.CompletionRate}");
      Console.WriteLine($"  SuccessRate: {deserializedData.SuccessRate}");
      Console.WriteLine($"  ErrorRate: {deserializedData.ErrorRate}");
      Console.WriteLine($"  ZeroPercent: {deserializedData.ZeroPercent}");
      Console.WriteLine($"  HundredPercent: {deserializedData.HundredPercent}");
      Console.WriteLine($"  FractionalPercent: {deserializedData.FractionalPercent}");
      Console.WriteLine($"  NegativePercent: {deserializedData.NegativePercent}");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name &&
        testData.CompletionRate.Equals(deserializedData.CompletionRate) &&
        testData.SuccessRate.Equals(deserializedData.SuccessRate) &&
        testData.ErrorRate.Equals(deserializedData.ErrorRate) &&
        testData.ZeroPercent.Equals(deserializedData.ZeroPercent) &&
        testData.HundredPercent.Equals(deserializedData.HundredPercent) &&
        testData.FractionalPercent.Equals(deserializedData.FractionalPercent) &&
        testData.NegativePercent.Equals(deserializedData.NegativePercent);

      if (isValid)
      {
        Console.WriteLine("✓ XML Serialization/Deserialization test passed");
        Console.WriteLine();
        return true;
      }
      else
      {
        Console.WriteLine("✗ XML Serialization/Deserialization test FAILED - data mismatch");
        Console.WriteLine();
        return false;
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ XML Serialization test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region JSON Serialization Tests

  static bool TestPercentJsonSerialization()
  {
    Console.WriteLine("--- Testing Percent JSON Serialization ---");

    try
    {
      // Create test object
      var testData = new PercentTestData
      {
        Id = 2,
        Name = "JSON Test",
        CompletionRate = new Percent(80.25),
        SuccessRate = new Percent(95.5),
        ErrorRate = new Percent(4.5),
        ZeroPercent = new Percent(0),
        HundredPercent = new Percent(100),
        FractionalPercent = new Percent(66.667),
        NegativePercent = new Percent(-10.0)
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  CompletionRate: {testData.CompletionRate}");
      Console.WriteLine($"  SuccessRate: {testData.SuccessRate}");
      Console.WriteLine($"  ErrorRate: {testData.ErrorRate}");
      Console.WriteLine($"  ZeroPercent: {testData.ZeroPercent}");
      Console.WriteLine($"  HundredPercent: {testData.HundredPercent}");
      Console.WriteLine($"  FractionalPercent: {testData.FractionalPercent}");
      Console.WriteLine($"  NegativePercent: {testData.NegativePercent}");
      Console.WriteLine();

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

      if (deserializedData == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  CompletionRate: {deserializedData.CompletionRate}");
      Console.WriteLine($"  SuccessRate: {deserializedData.SuccessRate}");
      Console.WriteLine($"  ErrorRate: {deserializedData.ErrorRate}");
      Console.WriteLine($"  ZeroPercent: {deserializedData.ZeroPercent}");
      Console.WriteLine($"  HundredPercent: {deserializedData.HundredPercent}");
      Console.WriteLine($"  FractionalPercent: {deserializedData.FractionalPercent}");
      Console.WriteLine($"  NegativePercent: {deserializedData.NegativePercent}");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name &&
        testData.CompletionRate.Equals(deserializedData.CompletionRate) &&
        testData.SuccessRate.Equals(deserializedData.SuccessRate) &&
        testData.ErrorRate.Equals(deserializedData.ErrorRate) &&
        testData.ZeroPercent.Equals(deserializedData.ZeroPercent) &&
        testData.HundredPercent.Equals(deserializedData.HundredPercent) &&
        testData.FractionalPercent.Equals(deserializedData.FractionalPercent) &&
        testData.NegativePercent.Equals(deserializedData.NegativePercent);

      if (isValid)
      {
        Console.WriteLine("✓ JSON Serialization/Deserialization test passed");
        Console.WriteLine();
        return true;
      }
      else
      {
        Console.WriteLine("✗ JSON Serialization/Deserialization test FAILED - data mismatch");
        Console.WriteLine();
        return false;
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ JSON Serialization test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Edge Cases Tests

  static bool TestPercentEdgeCases()
  {
    Console.WriteLine("--- Testing Percent Edge Cases ---");

    try
    {
      // Test zero value
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
      Percent negative = new Percent(-25.5);
      Console.WriteLine($"  Negative (-25.5%): '{negative}'");

      // Test large values (beyond 100%)
      Console.WriteLine("\nTesting values beyond 100%:");
      Percent large = new Percent(250.0);
      Console.WriteLine($"  Large (250%): '{large}'");

      // Test fractional values
      Console.WriteLine("\nTesting fractional values:");
      Percent third = new Percent(33.333333);
      Percent twoThirds = new Percent(66.666667);
      Console.WriteLine($"  One third: '{third}'");
      Console.WriteLine($"  Two thirds: '{twoThirds}'");

      // Test very small fractional values
      Console.WriteLine("\nTesting very small fractional values:");
      Percent tiny = new Percent(0.001);
      Console.WriteLine($"  0.001%: '{tiny}'");

      // Test string parsing with and without % suffix
      Console.WriteLine("\nTesting string parsing:");
      Percent withPercent = "75.5%";
      Percent withoutPercent = "75.5";
      Console.WriteLine($"  \"75.5%\" → {withPercent}");
      Console.WriteLine($"  \"75.5\" → {withoutPercent}");
      Console.WriteLine($"  Are equal: {withPercent.Equals(withoutPercent)}");

      // Test string parsing with comma decimal separator
      Console.WriteLine("\nTesting comma decimal separator:");
      Percent commaDecimal = "75,5";
      Console.WriteLine($"  \"75,5\" → {commaDecimal}");

      // Test JSON numeric vs string input
      Console.WriteLine("\nTesting JSON deserialization from different formats:");

      // String format with %
      string jsonStringWithPercent = "{\"Value\":\"50%\"}";
      var fromStringPercent = JsonSerializer.Deserialize<PercentWrapper>(jsonStringWithPercent);
      Console.WriteLine($"  From JSON string \"50%\": {fromStringPercent?.Value}");

      // String format without %
      string jsonStringWithoutPercent = "{\"Value\":\"50\"}";
      var fromStringNoPercent = JsonSerializer.Deserialize<PercentWrapper>(jsonStringWithoutPercent);
      Console.WriteLine($"  From JSON string \"50\": {fromStringNoPercent?.Value}");

      // Numeric format
      string jsonNumeric = "{\"Value\":50.5}";
      var fromNumeric = JsonSerializer.Deserialize<PercentWrapper>(jsonNumeric);
      Console.WriteLine($"  From JSON number 50.5: {fromNumeric?.Value}");

      // Test formatting with precision
      Console.WriteLine("\nTesting formatted output:");
      Percent pct = new Percent(75.12345);
      Console.WriteLine($"  Default: {pct.ToString()}");
      Console.WriteLine($"  No unit: {pct.ToString(CultureInfo.InvariantCulture, null)}");
      Console.WriteLine($"  Precision 0: {pct.ToString(0, "%")}");
      Console.WriteLine($"  Precision 2: {pct.ToString(2, "%")}");
      Console.WriteLine($"  Precision 4: {pct.ToString(4, "%")}");

      // Test comparison
      Console.WriteLine("\nTesting comparison:");
      Percent small = new Percent(25.5);
      Percent large2 = new Percent(75.5);
      Console.WriteLine($"  25.5% < 75.5%: {small.CompareTo(large2) < 0}");
      Console.WriteLine($"  75.5% > 25.5%: {large2.CompareTo(small) > 0}");
      Console.WriteLine($"  50% == 50%: {new Percent(50).CompareTo(new Percent(50)) == 0}");

      // Test IConvertible implementation
      Console.WriteLine("\nTesting IConvertible conversions:");
      Percent convertTest = new Percent(42.75);
      Console.WriteLine($"  ToBoolean: {convertTest.ToBoolean(null)}");
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
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Edge case test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Performance Tests

  static bool TestPercentPerformance()
  {
    Console.WriteLine("--- Testing Percent Performance ---");

    try
    {
      const int iterations = 100000;

      // Test construction from string
      var sw = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 0; i < iterations; i++)
      {
        Percent pct = "50.5%";
      }
      sw.Stop();
      Console.WriteLine($"Construction from string x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test construction from double
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        Percent pct = new Percent(50.5);
      }
      sw.Stop();
      Console.WriteLine($"Construction from double x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test ToString performance
      Percent testPct = new Percent(50.5);
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
      var testObj = new PercentTestData
      {
        Id = 1,
        Name = "Perf Test",
        CompletionRate = new Percent(75.5),
        SuccessRate = new Percent(99.9),
        ErrorRate = new Percent(0.1),
        ZeroPercent = new Percent(0),
        HundredPercent = new Percent(100),
        FractionalPercent = new Percent(33.333),
        NegativePercent = new Percent(-5.5)
      };

      sw.Restart();
      for (int i = 0; i < iterations / 10; i++)
      {
        string json = JsonSerializer.Serialize(testObj);
      }
      sw.Stop();
      Console.WriteLine($"JSON Serialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

      // Test JSON deserialization performance
      string jsonData = JsonSerializer.Serialize(testObj);
      sw.Restart();
      for (int i = 0; i < iterations / 10; i++)
      {
        var obj = JsonSerializer.Deserialize<PercentTestData>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"JSON Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

      // Test comparison performance
      Percent pct1 = new Percent(50.5);
      Percent pct2 = new Percent(50.5);
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

      Console.WriteLine("✓ Performance tests completed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Performance test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion
}

#region Test Helper Classes

/// <summary>
/// Test data class containing various Percent properties.
/// </summary>
[XmlRoot("PercentTestData")]
public class PercentTestData
{
  [XmlElement("Id")]
  public int Id { get; set; }

  [XmlElement("Name")]
  public string Name { get; set; } = string.Empty;

  [XmlElement("CompletionRate")]
  public Percent CompletionRate { get; set; }

  [XmlElement("SuccessRate")]
  public Percent SuccessRate { get; set; }

  [XmlElement("ErrorRate")]
  public Percent ErrorRate { get; set; }

  [XmlElement("ZeroPercent")]
  public Percent ZeroPercent { get; set; }

  [XmlElement("HundredPercent")]
  public Percent HundredPercent { get; set; }

  [XmlElement("FractionalPercent")]
  public Percent FractionalPercent { get; set; }

  [XmlElement("NegativePercent")]
  public Percent NegativePercent { get; set; }
}

/// <summary>
/// Simple wrapper class for testing JSON deserialization scenarios.
/// </summary>
public class PercentWrapper
{
  public Percent Value { get; set; }
}

#endregion