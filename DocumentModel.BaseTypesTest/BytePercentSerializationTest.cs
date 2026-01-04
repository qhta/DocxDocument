using System.Globalization;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for BytePercent type serialization in both XML and JSON formats.
/// </summary>
public static class BytePercentSerializationTests
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

  #region Basic Operations Tests

  static bool TestBytePercentBasicOperations()
  {
    Console.WriteLine("--- Testing BytePercent Basic Operations ---");

    try
    {
      // Test string to BytePercent conversion
      BytePercent pct1 = "50%";
      Console.WriteLine($"✓ String to BytePercent: {pct1} = {(byte)pct1}");

      // Test byte to BytePercent conversion
      BytePercent pct2 = (byte)50;
      Console.WriteLine($"✓ Byte to BytePercent: {pct2}");

      //// Test equality
      //if (pct1.CompareTo(pct2) == 0)
      //  Console.WriteLine("✓ Equality test passed");
      //else
      //  Console.WriteLine("✗ Equality test FAILED");

      // Test BytePercent to string with %
      string str = pct1.ToString();
      Console.WriteLine($"✓ BytePercent to string: {str}");

      // Test BytePercent to byte
      byte value = (byte)pct1;
      Console.WriteLine($"✓ BytePercent to byte: {value}");

      // Test hash code
      Console.WriteLine($"✓ Hash code: {pct1.GetHashCode()}");

      // Test various numeric conversions
      int intVal = (int)pct1;
      uint uintVal = (uint)pct1;
      short shortVal = (short)pct1;
      Console.WriteLine($"✓ Numeric conversions: int={intVal}, uint={uintVal}, short={shortVal}");

      //// Test with precision
      //string preciseStr = pct1.ToString(2, "%");
      //Console.WriteLine($"✓ ToString with precision 2: {preciseStr}");

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

  static bool TestBytePercentXmlSerialization()
  {
    Console.WriteLine("--- Testing BytePercent XML Serialization ---");

    try
    {
      // Create test object
      var testData = new BytePercentTestData
      {
        Id = 1,
        Name = "XML Test",
        Opacity = 75,
        ColorAlpha = 100,
        FillLevel = 50,
        ZeroPercent = 0,
        MaxPercent = 100,
        MidPercent = 50
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  Opacity: {testData.Opacity} ({(byte)testData.Opacity}%)");
      Console.WriteLine($"  ColorAlpha: {testData.ColorAlpha} ({(byte)testData.ColorAlpha}%)");
      Console.WriteLine($"  FillLevel: {testData.FillLevel} ({(byte)testData.FillLevel}%)");
      Console.WriteLine($"  ZeroPercent: {testData.ZeroPercent}");
      Console.WriteLine($"  MaxPercent: {testData.MaxPercent}");
      Console.WriteLine($"  MidPercent: {testData.MidPercent}");
      Console.WriteLine();

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

      if (deserializedData == null)
      {
        Console.WriteLine("✗ XML Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  Opacity: {deserializedData.Opacity}");
      Console.WriteLine($"  ColorAlpha: {deserializedData.ColorAlpha}");
      Console.WriteLine($"  FillLevel: {deserializedData.FillLevel}");
      Console.WriteLine($"  ZeroPercent: {deserializedData.ZeroPercent}");
      Console.WriteLine($"  MaxPercent: {deserializedData.MaxPercent}");
      Console.WriteLine($"  MidPercent: {deserializedData.MidPercent}");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name
        && testData.Opacity.CompareTo(deserializedData.Opacity) == 0
        && testData.ColorAlpha.CompareTo(deserializedData.ColorAlpha) == 0
        && testData.FillLevel.CompareTo(deserializedData.FillLevel) == 0
        && testData.ZeroPercent.CompareTo(deserializedData.ZeroPercent) == 0
        && testData.MaxPercent.CompareTo(deserializedData.MaxPercent) == 0
        && testData.MidPercent.CompareTo(deserializedData.MidPercent) == 0
        ;

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

  static bool TestBytePercentJsonSerialization()
  {
    Console.WriteLine("--- Testing BytePercent JSON Serialization ---");

    try
    {
      // Create test object
      var testData = new BytePercentTestData
      {
        Id = 2,
        Name = "JSON Test",
        Opacity = 80,
        ColorAlpha = 95,
        FillLevel = 25,
        ZeroPercent = 0,
        MaxPercent = 100,
        MidPercent = 50
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  Opacity: {testData.Opacity}");
      Console.WriteLine($"  ColorAlpha: {testData.ColorAlpha}");
      Console.WriteLine($"  FillLevel: {testData.FillLevel}");
      Console.WriteLine($"  ZeroPercent: {testData.ZeroPercent}");
      Console.WriteLine($"  MaxPercent: {testData.MaxPercent}");
      Console.WriteLine($"  MidPercent: {testData.MidPercent}");
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
      var deserializedData = JsonSerializer.Deserialize<BytePercentTestData>(jsonString, jsonOptions);

      if (deserializedData == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  Opacity: {deserializedData.Opacity}");
      Console.WriteLine($"  ColorAlpha: {deserializedData.ColorAlpha}");
      Console.WriteLine($"  FillLevel: {deserializedData.FillLevel}");
      Console.WriteLine($"  ZeroPercent: {deserializedData.ZeroPercent}");
      Console.WriteLine($"  MaxPercent: {deserializedData.MaxPercent}");
      Console.WriteLine($"  MidPercent: {deserializedData.MidPercent}");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name
        && testData.Opacity.CompareTo(deserializedData.Opacity) == 0
        && testData.ColorAlpha.CompareTo(deserializedData.ColorAlpha) == 0
        && testData.FillLevel.CompareTo(deserializedData.FillLevel) == 0
        && testData.ZeroPercent.CompareTo(deserializedData.ZeroPercent) == 0
        && testData.MaxPercent.CompareTo(deserializedData.MaxPercent) == 0
        && testData.MidPercent.CompareTo(deserializedData.MidPercent) == 0
        ;

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

  static bool TestBytePercentEdgeCases()
  {
    Console.WriteLine("--- Testing BytePercent Edge Cases ---");

    try
    {
      // Test zero value
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

      // Test hex conversion (color alpha channel scenario)
      Console.WriteLine("\nTesting hex conversion (color alpha):");
      BytePercent fromHex00 = BytePercent.FromHexString("00"); // 0% opacity
      BytePercent fromHex80 = BytePercent.FromHexString("80"); // ~50% opacity
      BytePercent fromHexFF = BytePercent.FromHexString("FF"); // 100% opacity
      Console.WriteLine($"  0x00 → {fromHex00} ({(byte)fromHex00}%)");
      Console.WriteLine($"  0x80 → {fromHex80} ({(byte)fromHex80}%)");
      Console.WriteLine($"  0xFF → {fromHexFF} ({(byte)fromHexFF}%)");

      // Test reverse hex conversion
      Console.WriteLine("\nTesting reverse hex conversion:");
      BytePercent pct0 = 0;
      BytePercent pct50 = 50;
      BytePercent pct100 = 100;
      Console.WriteLine($"  0% → 0x{pct0.ToHexString()}");
      Console.WriteLine($"  50% → 0x{pct50.ToHexString()}");
      Console.WriteLine($"  100% → 0x{pct100.ToHexString()}");

      // Test string parsing with and without % suffix
      Console.WriteLine("\nTesting string parsing:");
      BytePercent withPercent = "75%";
      BytePercent withoutPercent = "75";
      Console.WriteLine($"  \"75%\" → {withPercent} ({(byte)withPercent})");
      Console.WriteLine($"  \"75\" → {withoutPercent} ({(byte)withoutPercent})");
      Console.WriteLine($"  Are equal: {withPercent.CompareTo(withoutPercent) == 0}");

      // Test JSON numeric vs string input
      Console.WriteLine("\nTesting JSON deserialization from different formats:");

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

  static bool TestBytePercentPerformance()
  {
    Console.WriteLine("--- Testing BytePercent Performance ---");

    try
    {
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

      // Test hex conversion performance
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        string hex = testPct.ToHexString();
      }
      sw.Stop();
      Console.WriteLine($"ToHexString() x {iterations}: {sw.ElapsedMilliseconds}ms");

      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        BytePercent pct = BytePercent.FromHexString("80");
      }
      sw.Stop();
      Console.WriteLine($"FromHexString() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test JSON serialization performance
      var testObj = new BytePercentTestData
      {
        Id = 1,
        Name = "Perf Test",
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

      // Test JSON deserialization performance
      string jsonData = JsonSerializer.Serialize(testObj);
      sw.Restart();
      for (int i = 0; i < iterations / 10; i++)
      {
        var obj = JsonSerializer.Deserialize<BytePercentTestData>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"JSON Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

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
/// Test data class containing various BytePercent properties.
/// </summary>
[XmlRoot("BytePercentTestData")]
public class BytePercentTestData
{
  [XmlElement("Id")]
  public int Id { get; set; }

  [XmlElement("Name")]
  public string Name { get; set; } = string.Empty;

  [XmlElement("Opacity")]
  public BytePercent Opacity { get; set; }

  [XmlElement("ColorAlpha")]
  public BytePercent ColorAlpha { get; set; }

  [XmlElement("FillLevel")]
  public BytePercent FillLevel { get; set; }

  [XmlElement("ZeroPercent")]
  public BytePercent ZeroPercent { get; set; }

  [XmlElement("MaxPercent")]
  public BytePercent MaxPercent { get; set; }

  [XmlElement("MidPercent")]
  public BytePercent MidPercent { get; set; }
}

/// <summary>
/// Simple wrapper class for testing JSON deserialization scenarios.
/// </summary>
public class BytePercentWrapper
{
  public BytePercent Value { get; set; }
}

#endregion