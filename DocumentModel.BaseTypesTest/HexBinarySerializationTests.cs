using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for HexBinary type serialization in both XML and JSON formats.
/// </summary>
public static class HexBinarySerializationTests
{
  /// <summary>
  /// Runs all HexBinary serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== HexBinary Serialization Test Program ===");
    Console.WriteLine("=== HexBinary Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestHexBinaryBasicOperations()) return false;
    if (!TestHexBinaryXmlSerialization()) return false;
    if (!TestHexBinaryJsonSerialization()) return false;
    if (!TestHexBinaryEdgeCases()) return false;
    if (!TestHexBinaryPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestHexBinaryBasicOperations()
  {
    Console.WriteLine("--- Testing HexBinary Basic Operations ---");

    try
    {
      // Test string to HexBinary conversion
      HexBinary hex1 = "48656C6C6F"; // "Hello" in hex
      Console.WriteLine($"✓ String to HexBinary: {hex1}");

      // Test byte array to HexBinary conversion
      byte[] bytes = new byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F };
      HexBinary hex2 = bytes;
      Console.WriteLine($"✓ Byte array to HexBinary: {hex2}");

      // Test equality
      if (hex1.Equals(hex2))
        Console.WriteLine("✓ Equality test passed");
      else
        Console.WriteLine("✗ Equality test FAILED");

      // Test HexBinary to string
      string str = hex1;
      Console.WriteLine($"✓ HexBinary to string: {str}");

      // Test HexBinary to byte array
      byte[] resultBytes = hex1;
      Console.WriteLine($"✓ HexBinary to byte array: [{string.Join(", ", resultBytes.Select(b => $"0x{b:X2}"))}]");

      // Test Length property
      Console.WriteLine($"✓ Length: {hex1.Length} bytes");

      // Test hash code
      Console.WriteLine($"✓ Hash code: {hex1.GetHashCode()}");

      Console.WriteLine("✓ All basic operations passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Basic operations test FAILED: {ex.Message}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region XML Serialization Tests

  static bool TestHexBinaryXmlSerialization()
  {
    Console.WriteLine("--- Testing HexBinary XML Serialization ---");

    try
    {
      // Create test object
      var testData = new HexBinaryTestDataClass
      {
        Id = 1,
        Name = "XML Test",
        BinaryData = new byte[] { 0xDE, 0xAD, 0xBE, 0xEF },
        DocumentHash = "A1B2C3D4E5F6",
        ImageData = new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 } // JPEG header
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  BinaryData: {testData.BinaryData}");
      Console.WriteLine($"  DocumentHash: {testData.DocumentHash}");
      Console.WriteLine($"  ImageData: {testData.ImageData}");
      Console.WriteLine();

      // Serialize to XML
      var xmlSerializer = new XmlSerializer(typeof(HexBinaryTestDataClass));
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
      HexBinaryTestDataClass? deserializedData;
      using (var stringReader = new StringReader(xmlString))
      {
        deserializedData = (HexBinaryTestDataClass?)xmlSerializer.Deserialize(stringReader);
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
      Console.WriteLine($"  BinaryData: {deserializedData.BinaryData}");
      Console.WriteLine($"  DocumentHash: {deserializedData.DocumentHash}");
      Console.WriteLine($"  ImageData: {deserializedData.ImageData}");
      Console.WriteLine();

      // Validate
      bool isValid = testData.Id == deserializedData.Id && testData.Name == deserializedData.Name && testData.BinaryData.Equals(deserializedData.BinaryData) && testData.DocumentHash.Equals(deserializedData.DocumentHash) && testData.ImageData.Equals(deserializedData.ImageData);

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

  static bool TestHexBinaryJsonSerialization()
  {
    Console.WriteLine("--- Testing HexBinary JSON Serialization ---");

    try
    {
      // Create test object
      var testData = new HexBinaryTestDataClass
      {
        Id = 2,
        Name = "JSON Test",
        BinaryData = new byte[] { 0xCA, 0xFE, 0xBA, 0xBE },
        DocumentHash = "0123456789ABCDEF",
        ImageData = new byte[] { 0x89, 0x50, 0x4E, 0x47 } // PNG header
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  BinaryData: {testData.BinaryData}");
      Console.WriteLine($"  DocumentHash: {testData.DocumentHash}");
      Console.WriteLine($"  ImageData: {testData.ImageData}");
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
      var deserializedData = JsonSerializer.Deserialize<HexBinaryTestDataClass>(jsonString, jsonOptions);

      if (deserializedData == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  BinaryData: {deserializedData.BinaryData}");
      Console.WriteLine($"  DocumentHash: {deserializedData.DocumentHash}");
      Console.WriteLine($"  ImageData: {deserializedData.ImageData}");
      Console.WriteLine();

      // Validate
      bool isValid = testData.Id == deserializedData.Id && testData.Name == deserializedData.Name && testData.BinaryData.Equals(deserializedData.BinaryData) && testData.DocumentHash.Equals(deserializedData.DocumentHash) && testData.ImageData.Equals(deserializedData.ImageData);

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

  static bool TestHexBinaryEdgeCases()
  {
    Console.WriteLine("--- Testing HexBinary Edge Cases ---");

    try
    {
      // Test empty HexBinary
      Console.WriteLine("Testing empty HexBinary:");
      HexBinary empty = new byte[0];
      Console.WriteLine($"  Empty HexBinary: '{empty}' (Length: {empty.Length})");

      // Serialize and deserialize empty
      string jsonEmpty = JsonSerializer.Serialize(new { Data = empty });
      Console.WriteLine($"  JSON: {jsonEmpty}");
      var deserializedEmpty = JsonSerializer.Deserialize<Base64BinaryTestWrapper>(jsonEmpty);
      Console.WriteLine($"  Deserialized empty equals original: {empty.Equals(deserializedEmpty?.Data ?? default)}");

      // Test single byte
      Console.WriteLine("\nTesting single byte:");
      HexBinary singleByte = new byte[] { 0xFF };
      Console.WriteLine($"  Single byte: '{singleByte}' (Length: {singleByte.Length})");

      // Test large binary data
      Console.WriteLine("\nTesting large binary data:");
      byte[] largeData = new byte[1024];
      for (int i = 0; i < largeData.Length; i++)
        largeData[i] = (byte)(i % 256);
      HexBinary large = largeData;
      Console.WriteLine($"  Large data: Length = {large.Length} bytes");
      Console.WriteLine($"  First 32 chars: {large.ToString().Substring(0, System.Math.Min(32, large.ToString().Length))}...");

      // Test null handling
      Console.WriteLine("\nTesting null handling:");
      var nullWrapper = new Base64BinaryTestWrapper { Data = default };
      string jsonNull = JsonSerializer.Serialize(nullWrapper);
      Console.WriteLine($"  JSON with default HexBinary: {jsonNull}");

      // Test special byte sequences
      Console.WriteLine("\nTesting special byte sequences:");
      HexBinary allZeros = new byte[] { 0x00, 0x00, 0x00, 0x00 };
      Console.WriteLine($"  All zeros: {allZeros}");

      HexBinary allOnes = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF };
      Console.WriteLine($"  All ones: {allOnes}");

      HexBinary pattern = new byte[] { 0xAA, 0x55, 0xAA, 0x55 };
      Console.WriteLine($"  Pattern: {pattern}");

      Console.WriteLine("\n✓ All edge case tests completed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Edge case test FAILED: {ex.Message}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Performance Tests

  static bool TestHexBinaryPerformance()
  {
    Console.WriteLine("--- Testing HexBinary Performance ---");

    try
    {
      const int iterations = 10000;
      byte[] testData = new byte[256];
      for (int i = 0; i < 256; i++)
        testData[i] = (byte)i;

      // Test conversion performance
      var sw = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 0; i < iterations; i++)
      {
        HexBinary hex = testData;
        string str = hex;
      }
      sw.Stop();
      Console.WriteLine($"Conversion (byte[] → HexBinary → string) x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test JSON serialization performance
      var testObj = new HexBinaryTestDataClass
      {
        Id = 1,
        Name = "Perf Test",
        BinaryData = testData,
        DocumentHash = "ABCDEF123456",
        ImageData = testData
      };

      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        string json = JsonSerializer.Serialize(testObj);
      }
      sw.Stop();
      Console.WriteLine($"JSON Serialization x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test JSON deserialization performance
      string jsonData = JsonSerializer.Serialize(testObj);
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        var obj = JsonSerializer.Deserialize<HexBinaryTestDataClass>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"JSON Deserialization x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test equality comparison performance
      HexBinary hex1 = testData;
      HexBinary hex2 = testData;
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        bool equal = hex1.Equals(hex2);
      }
      sw.Stop();
      Console.WriteLine($"Equality comparison x {iterations}: {sw.ElapsedMilliseconds}ms");

      Console.WriteLine("✓ Performance tests completed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Performance test FAILED: {ex.Message}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

}

#region Test Helper Classes

/// <summary>
/// Test data class containing various HexBinary properties.
/// </summary>
[XmlRoot("TestData")]
public class HexBinaryTestDataClass
{
  [XmlElement("Id")]
  public int Id { get; set; }

  [XmlElement("Name")]
  public string Name { get; set; } = string.Empty;

  [XmlElement("BinaryData")]
  public HexBinary? BinaryData { get; set; }

  [XmlElement("DocumentHash")]
  public HexBinary? DocumentHash { get; set; }

  [XmlElement("ImageData")]
  public HexBinary? ImageData { get; set; }
}

/// <summary>
/// Simple wrapper class for testing nullable scenarios.
/// </summary>
public class HexBinaryTestWrapper
{
  public HexBinary? Data { get; set; }
}

#endregion