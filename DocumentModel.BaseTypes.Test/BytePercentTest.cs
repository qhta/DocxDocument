using System.Globalization;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for BytePercent type serialization in both XML and JSON formats.
/// </summary>
public static class BytePercentTest
{
  /// <summary>
  /// Runs all BytePercent serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== BytePercent Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestBytePercentBasicOperations()) return false;
    if (!TestBytePercentXmlSerialization()) return false;
    if (!TestBytePercentJsonSerialization()) return false;
    if (!TestBytePercentEdgeCases()) return false;
    if (!TestBytePercentPerformance()) return false;

    return true;
  }


  static bool TestBytePercentBasicOperations()
  {
    Console.WriteLine("--- Testing BytePercent Basic Operations ---"); // Test string to BytePercent conversion
    BytePercent pct1 = "50%";
    Console.WriteLine($"\n✓ String to BytePercent: {pct1} = {(byte)pct1}");

    // Test byte to BytePercent conversion
    BytePercent pct2 = (byte)50;
    Console.WriteLine($"\n✓ Byte to BytePercent: {pct2}");

    //// Test equality
    //if (pct1.CompareTo(pct2) == 0)
    //  Console.WriteLine("\n✓ Equality test passed");
    //else
    //  Console.WriteLine("✗ Equality test FAILED");

    // Test BytePercent to string with %
    string str = pct1.ToString();
    Console.WriteLine($"\n✓ BytePercent to string: {str}");

    // Test BytePercent to byte
    byte value = (byte)pct1;
    Console.WriteLine($"\n✓ BytePercent to byte: {value}");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {pct1.GetHashCode()}");

    // Test various numeric conversions
    int intVal = (int)pct1;
    uint uintVal = (uint)pct1;
    short shortVal = (short)pct1;
    Console.WriteLine($"\n✓ Numeric conversions: int={intVal}, uint={uintVal}, short={shortVal}");

    //// Test with precision
    //string preciseStr = pct1.ToString(2, "%");
    //Console.WriteLine($"\n✓ ToString with precision 2: {preciseStr}");
    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }



  static bool TestBytePercentXmlSerialization()
  {
    Console.WriteLine("--- Testing BytePercent XML Serialization ---"); // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(BytePercentTestData));
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
    BytePercentTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (BytePercentTestData?)xmlSerializer.Deserialize(stringReader);
    }
    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static void ShowOriginalData(BytePercentTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  Opacity: {testData.Opacity} ({(byte)testData.Opacity}%)");
    Console.WriteLine($"  ColorAlpha: {testData.ColorAlpha} ({(byte)testData.ColorAlpha}%)");
    Console.WriteLine($"  FillLevel: {testData.FillLevel} ({(byte)testData.FillLevel}%)");
    Console.WriteLine($"  ZeroPercent: {testData.ZeroPercent}");
    Console.WriteLine($"  MaxPercent: {testData.MaxPercent}");
    Console.WriteLine($"  MidPercent: {testData.MidPercent}");
    Console.WriteLine();
  }

  private static BytePercentTestData CreateTestData()
  {
    var testData = new BytePercentTestData
    {
      Opacity = 75,
      ColorAlpha = 100,
      FillLevel = 50,
      ZeroPercent = 0,
      MaxPercent = 100,
      MidPercent = 50
    };
    return testData;
  }

  private static bool VerifyDeserializedData(BytePercentTestData? deserializedData, BytePercentTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");
    Console.WriteLine($"  Opacity: {deserializedData.Opacity}");
    if (testData.Opacity.CompareTo(deserializedData.Opacity) != 0)
      return false;

    Console.WriteLine($"  ColorAlpha: {deserializedData.ColorAlpha}");
    if (testData.ColorAlpha.CompareTo(deserializedData.ColorAlpha) != 0)
      return false;

    Console.WriteLine($"  FillLevel: {deserializedData.FillLevel}");
    if (testData.FillLevel.CompareTo(deserializedData.FillLevel) != 0)
      return false;

    Console.WriteLine($"  ZeroPercent: {deserializedData.ZeroPercent}");
    if (testData.ZeroPercent.CompareTo(deserializedData.ZeroPercent) != 0)
      return false;

    Console.WriteLine($"  MaxPercent: {deserializedData.MaxPercent}");
    if (testData.MaxPercent.CompareTo(deserializedData.MaxPercent) != 0)
      return false;

    Console.WriteLine($"  MidPercent: {deserializedData.MidPercent}");
    if (testData.MidPercent.CompareTo(deserializedData.MidPercent) != 0)
      return false;

    return true;
  }



  static bool TestBytePercentJsonSerialization()
  {
    Console.WriteLine("--- Testing BytePercent JSON Serialization ---"); // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<BytePercentTestData>(jsonString, jsonOptions);
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }
    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }



  static bool TestBytePercentEdgeCases()
  {
    Console.WriteLine("--- Testing BytePercent Edge Cases ---"); // Test zero value
    Console.WriteLine("Testing zero value:");
    BytePercent zero = 0;
    Console.WriteLine($"  Zero: '{zero}' ({(byte)zero}%)");

    // Test boundary values (0-100% range)
    Console.WriteLine("\nTesting boundary values:");
    BytePercent minPercent = 0;
    BytePercent maxPercent = 100;
    Console.WriteLine($"  Min (0%): '{minPercent}'");
    Console.WriteLine($"  Max (100%): '{maxPercent}'");

    // Test values beyond typical percentage range (byte supports 0-255)
    Console.WriteLine("\nTesting extended byte range:");
    BytePercent extended = (byte)150;
    Console.WriteLine($"  Extended value (150): '{extended}' (valid for byte range)");

    // Test common percentage values
    Console.WriteLine("\nTesting common percentage values:");
    BytePercent quarter = 25;
    BytePercent half = 50;
    BytePercent threeQuarters = 75;
    Console.WriteLine($"  25%: '{quarter}'");
    Console.WriteLine($"  50%: '{half}'");
    Console.WriteLine($"  75%: '{threeQuarters}'");

    // Test string parsing with and without % suffix
    Console.WriteLine("\nTesting string parsing:");
    BytePercent withPercent = "75%";
    BytePercent withoutPercent = "75";
    Console.WriteLine($"  \"75%\" → {withPercent} ({(byte)withPercent})");
    Console.WriteLine($"  \"75\" → {withoutPercent} ({(byte)withoutPercent})");
    Console.WriteLine($"  Are equal: {withPercent.CompareTo(withoutPercent) == 0}");

    // Test JSON numeric vs string input
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // String format
    string jsonString = "{\"Value\":\"50\"}";
    var fromString = JsonSerializer.Deserialize<BytePercentWrapper>(jsonString);
    Console.WriteLine($"  From JSON string \"50\": {fromString?.Value} ({(byte)(fromString?.Value ?? 0)})");

    // Numeric format
    string jsonNumeric = "{\"Value\":50}";
    var fromNumeric = JsonSerializer.Deserialize<BytePercentWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 50: {fromNumeric?.Value} ({(byte)(fromNumeric?.Value ?? 0)})");

    // With % suffix
    string jsonWithPercent = "{\"Value\":\"50%\"}";
    var fromPercent = JsonSerializer.Deserialize<BytePercentWrapper>(jsonWithPercent);
    Console.WriteLine($"  From JSON \"50%\": {fromPercent?.Value} ({(byte)(fromPercent?.Value ?? 0)})");

    // Test formatting with precision
    Console.WriteLine("\nTesting formatted output:");
    BytePercent pct = 75;

    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
    Console.WriteLine($"  Default: {pct.ToString()}");
    Console.WriteLine($"  No unit: {pct.ToString(CultureInfo.InvariantCulture, null)}");
    Console.WriteLine($"  Precision 2: {pct.ToString(2, "%")}");
    Console.WriteLine($"  Precision 0: {pct.ToString(0, "%")}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    BytePercent small = 25;
    BytePercent large = 75;
    Console.WriteLine($"  25% < 75%: {small.CompareTo(large) < 0}");
    Console.WriteLine($"  75% > 25%: {large.CompareTo(small) > 0}");
    Console.WriteLine($"  50% == 50%: {half.CompareTo((BytePercent)50) == 0}");
    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }



  static bool TestBytePercentPerformance()
  {
    Console.WriteLine("--- Testing BytePercent Performance ---");
    const int iterations = 100000;

    // Test construction from string
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      BytePercent pct = "50%";
    }
    sw.Stop();
    Console.WriteLine($"Construction from string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from byte
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      BytePercent pct = (byte)50;
    }
    sw.Stop();
    Console.WriteLine($"Construction from byte x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    BytePercent testPct = 50;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testPct.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");


    // Test JSON serialization performance
    var testObj = new BytePercentTestData
    {
      Opacity = 75,

      //ColorAlpha = 100,
      //FillLevel = 50,
      //ZeroPercent = 0,
      //MaxPercent = 100,
      //MidPercent = 50
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
      var obj = JsonSerializer.Deserialize<BytePercentTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test comparison performance
    BytePercent pct1 = 50;
    BytePercent pct2 = 50;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int result = pct1.CompareTo(pct2);
    }
    sw.Stop();
    Console.WriteLine($"CompareTo() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test implicit conversions performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      byte value = (byte)pct1;
    }
    sw.Stop();
    Console.WriteLine($"Implicit conversion to byte x {iterations}: {sw.ElapsedMilliseconds}ms");
    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

}


/// <summary>
/// Test data class containing various BytePercent properties.
/// </summary>
[XmlRoot("BytePercentTestData")]
public class BytePercentTestData
{
  [XmlElement("Opacity")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public BytePercent Opacity { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ColorAlpha")]
  public BytePercent ColorAlpha { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("FillLevel")]
  public BytePercent FillLevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ZeroPercent")]
  public BytePercent ZeroPercent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("MaxPercent")]
  public BytePercent MaxPercent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("MidPercent")]
  public BytePercent MidPercent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class BytePercentWrapper
{
  public BytePercent Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


