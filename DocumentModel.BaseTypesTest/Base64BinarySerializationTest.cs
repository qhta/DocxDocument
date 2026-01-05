using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for Base64Binary type serialization in both XML and JSON formats.
/// </summary>
public static class Base64BinarySerializationTests
{
  /// <summary>
  /// Runs all Base64Binary serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== Base64Binary Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestBase64BinaryBasicOperations()) return false;
    if (!TestBase64BinaryXmlSerialization()) return false;
    if (!TestBase64BinaryJsonSerialization()) return false;
    if (!TestBase64BinaryEdgeCases()) return false;
    if (!TestBase64BinaryPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestBase64BinaryBasicOperations()
  {
    Console.WriteLine("--- Testing Base64Binary Basic Operations ---");

    try
    {
      // Test string to Base64Binary conversion
      Base64Binary b64_1 = "SGVsbG8="; // "Hello" in Base64
      Console.WriteLine($"✓ String to Base64Binary: {b64_1}");

      // Test byte array to Base64Binary conversion
      byte[] bytes = new byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F };
      Base64Binary b64_2 = bytes;
      Console.WriteLine($"✓ Byte array to Base64Binary: {b64_2}");

      // Test equality
      if (b64_1.Equals(b64_2))
        Console.WriteLine("✓ Equality test passed");
      else
        Console.WriteLine("✗ Equality test FAILED");

      // Test Base64Binary to string
      string str = b64_1;
      Console.WriteLine($"✓ Base64Binary to string: {str}");

      // Test Base64Binary to byte array
      byte[] resultBytes = b64_1;
      Console.WriteLine($"✓ Base64Binary to byte array: [{string.Join(", ", resultBytes.Select(b => $"0x{b:X2}"))}]");

      // Test ToString method
      Console.WriteLine($"✓ ToString: {b64_1.ToString()}");

      // Test hash code
      Console.WriteLine($"✓ Hash code: {b64_1.GetHashCode()}");

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

  static bool TestBase64BinaryXmlSerialization()
  {
    Console.WriteLine("--- Testing Base64Binary XML Serialization ---");

    try
    {
      // Create test object
      var testData = new Base64BinaryTestDataClass
      {
        Id = 1,
        Name = "XML Test",
        BinaryData = new byte[] { 0xDE, 0xAD, 0xBE, 0xEF },
        EmbeddedImage = "/9j/4A==", // JPEG header in Base64
        EncryptedContent = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 }
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  BinaryData: {testData.BinaryData}");
      Console.WriteLine($"  EmbeddedImage: {testData.EmbeddedImage}");
      Console.WriteLine($"  EncryptedContent: {testData.EncryptedContent}");
      Console.WriteLine();

      // Serialize to XML
      var xmlSerializer = new XmlSerializer(typeof(Base64BinaryTestDataClass));
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
      Base64BinaryTestDataClass? deserializedData;
      using (var stringReader = new StringReader(xmlString))
      {
        deserializedData = (Base64BinaryTestDataClass?)xmlSerializer.Deserialize(stringReader);
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
      Console.WriteLine($"  EmbeddedImage: {deserializedData.EmbeddedImage}");
      Console.WriteLine($"  EncryptedContent: {deserializedData.EncryptedContent}");
      Console.WriteLine();

      // Validate
      bool isValid = testData.Id == deserializedData.Id && testData.Name == deserializedData.Name && testData.BinaryData.Equals(deserializedData.BinaryData) && testData.EmbeddedImage.Equals(deserializedData.EmbeddedImage) && testData.EncryptedContent.Equals(deserializedData.EncryptedContent);

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

  static bool TestBase64BinaryJsonSerialization()
  {
    Console.WriteLine("--- Testing Base64Binary JSON Serialization ---");

    try
    {
      // Create test object
      var testData = new Base64BinaryTestDataClass
      {
        Id = 2,
        Name = "JSON Test",
        BinaryData = new byte[] { 0xCA, 0xFE, 0xBA, 0xBE },
        EmbeddedImage = "iVBORw0KGgo=", // PNG header in Base64
        EncryptedContent = new byte[] { 0xFF, 0xEE, 0xDD, 0xCC, 0xBB, 0xAA }
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  BinaryData: {testData.BinaryData}");
      Console.WriteLine($"  EmbeddedImage: {testData.EmbeddedImage}");
      Console.WriteLine($"  EncryptedContent: {testData.EncryptedContent}");
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
      var deserializedData = JsonSerializer.Deserialize<Base64BinaryTestDataClass>(jsonString, jsonOptions);

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
      Console.WriteLine($"  EmbeddedImage: {deserializedData.EmbeddedImage}");
      Console.WriteLine($"  EncryptedContent: {deserializedData.EncryptedContent}");
      Console.WriteLine();

      // Validate
      bool isValid = testData.Id == deserializedData.Id && testData.Name == deserializedData.Name && testData.BinaryData.Equals(deserializedData.BinaryData) && testData.EmbeddedImage.Equals(deserializedData.EmbeddedImage) && testData.EncryptedContent.Equals(deserializedData.EncryptedContent);

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

  static bool TestBase64BinaryEdgeCases()
  {
    Console.WriteLine("--- Testing Base64Binary Edge Cases ---");

    try
    {
      // Test empty Base64Binary
      Console.WriteLine("Testing empty Base64Binary:");
      Base64Binary empty = new byte[0];
      Console.WriteLine($"  Empty Base64Binary: '{empty}' (Length: {((byte[])empty).Length})");

      // Serialize and deserialize empty
      string jsonEmpty = JsonSerializer.Serialize(new { Data = empty });
      Console.WriteLine($"  JSON: {jsonEmpty}");
      var deserializedEmpty = JsonSerializer.Deserialize<Base64BinaryTestWrapper>(jsonEmpty);
      Console.WriteLine($"  Deserialized empty equals original: {empty.Equals(deserializedEmpty?.Data ?? default)}");

      // Test single byte
      Console.WriteLine("\nTesting single byte:");
      Base64Binary singleByte = new byte[] { 0xFF };
      Console.WriteLine($"  Single byte: '{singleByte}' (Base64)");

      // Test two bytes (needs padding)
      Console.WriteLine("\nTesting two bytes (padding test):");
      Base64Binary twoBytes = new byte[] { 0x12, 0x34 };
      string twoByteString = twoBytes;
      Console.WriteLine($"  Two bytes as Base64: '{twoByteString}' (should have == padding)");

      // Test three bytes (no padding)
      Console.WriteLine("\nTesting three bytes (no padding):");
      Base64Binary threeBytes = new byte[] { 0x12, 0x34, 0x56 };
      string threeByteString = threeBytes;
      Console.WriteLine($"  Three bytes as Base64: '{threeByteString}' (should have no padding)");

      // Test large binary data
      Console.WriteLine("\nTesting large binary data:");
      byte[] largeData = new byte[1024];
      for (int i = 0; i < largeData.Length; i++)
        largeData[i] = (byte)(i % 256);
      Base64Binary large = largeData;
      string largeBase64 = large;
      Console.WriteLine($"  Large data: Length = {((byte[])large).Length} bytes");
      Console.WriteLine($"  Base64 length: {largeBase64.Length} chars");
      Console.WriteLine($"  First 32 chars: {largeBase64.Substring(0, System.Math.Min(32, largeBase64.Length))}...");

      // Test null handling
      Console.WriteLine("\nTesting null handling:");
      var nullWrapper = new Base64BinaryTestWrapper { Data = default };
      string jsonNull = JsonSerializer.Serialize(nullWrapper);
      Console.WriteLine($"  JSON with default Base64Binary: {jsonNull}");

      // Test special byte sequences
      Console.WriteLine("\nTesting special byte sequences:");
      Base64Binary allZeros = new byte[] { 0x00, 0x00, 0x00, 0x00 };
      Console.WriteLine($"  All zeros: {allZeros}");

      Base64Binary allOnes = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF };
      Console.WriteLine($"  All ones: {allOnes}");

      Base64Binary pattern = new byte[] { 0xAA, 0x55, 0xAA, 0x55 };
      Console.WriteLine($"  Pattern: {pattern}");

      // Test known Base64 conversions
      Console.WriteLine("\nTesting known Base64 conversions:");
      Base64Binary hello = new byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F }; // "Hello"
      string helloBase64 = hello;
      Console.WriteLine($"  'Hello' bytes: {helloBase64} (expected: SGVsbG8=)");

      Base64Binary jpegHeader = new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 };
      string jpegBase64 = jpegHeader;
      Console.WriteLine($"  JPEG header: {jpegBase64} (expected: /9j/4A==)");

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

  static bool TestBase64BinaryPerformance()
  {
    Console.WriteLine("--- Testing Base64Binary Performance ---");

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
        Base64Binary b64 = testData;
        string str = b64;
      }
      sw.Stop();
      Console.WriteLine($"Conversion (byte[] → Base64Binary → string) x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test JSON serialization performance
      var testObj = new Base64BinaryTestDataClass
      {
        Id = 1,
        Name = "Perf Test",
        BinaryData = testData,
        EmbeddedImage = "ABCDEF123456",
        EncryptedContent = testData
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
        var obj = JsonSerializer.Deserialize<Base64BinaryTestDataClass>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"JSON Deserialization x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test equality comparison performance
      Base64Binary b64_1 = testData;
      Base64Binary b64_2 = testData;
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        bool equal = b64_1.Equals(b64_2);
      }
      sw.Stop();
      Console.WriteLine($"Equality comparison x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test Base64 encoding/decoding performance
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        string base64 = Convert.ToBase64String(testData);
        byte[] decoded = Convert.FromBase64String(base64);
      }
      sw.Stop();
      Console.WriteLine($"Base64 encode/decode x {iterations}: {sw.ElapsedMilliseconds}ms");

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
/// Test data class containing various Base64Binary properties.
/// </summary>
[XmlRoot("TestData")]
public class Base64BinaryTestDataClass
{
  [XmlElement("Id")]
  public int Id { get; set; }

  [XmlElement("Name")]
  public string Name { get; set; } = string.Empty;

  [XmlElement("BinaryData")]
  public Base64Binary? BinaryData { get; set; }

  [XmlElement("EmbeddedImage")]
  public Base64Binary? EmbeddedImage { get; set; }

  [XmlElement("EncryptedContent")]
  public Base64Binary? EncryptedContent { get; set; }
}

/// <summary>
/// Simple wrapper class for testing nullable scenarios.
/// </summary>
public class Base64BinaryTestWrapper
{
  public Base64Binary? Data { get; set; }
}

#endregion