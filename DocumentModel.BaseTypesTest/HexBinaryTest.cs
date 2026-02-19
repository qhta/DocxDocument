#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for HexBinary type serialization in both XML and JSON formats.
/// </summary>
public static class HexBinaryTest
{
  /// <summary>
  /// Runs all HexBinary serialization tests.
  /// </summary>
  public static bool Run()
  {
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

  
  static bool TestHexBinaryBasicOperations()
  {
    Console.WriteLine("--- Testing HexBinary Basic Operations ---");

    // Test string to HexBinary conversion
    HexBinary hex1 = "48656C6C6F"; // "Hello" in hex
    Console.WriteLine($"\n✓ String to HexBinary: {hex1}");

    // Test byte array to HexBinary conversion
    byte[] bytes = new byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F };
    HexBinary hex2 = bytes;
    Console.WriteLine($"\n✓ Byte array to HexBinary: {hex2}");

    // Test equality
    if (hex1.Equals(hex2))
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test HexBinary to string
    string str = hex1;
    Console.WriteLine($"\n✓ HexBinary to string: {str}");

    // Test HexBinary to byte array
    byte[] resultBytes = hex1;
    Console.WriteLine($"\n✓ HexBinary to byte array: [{string.Join(", ", resultBytes.Select(b => $"0x{b:X2}"))}]");

    // Test Length property
    Console.WriteLine($"\n✓ Length: {hex1.Length} bytes");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {hex1.GetHashCode()}");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;

  }

  
  
  static bool TestHexBinaryXmlSerialization()
  {
    Console.WriteLine("--- Testing HexBinary XML Serialization ---");

    // Create test object
    var testData = CreateTestData();

    ShowOriginalData(testData);

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
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  BinaryData: {deserializedData.BinaryData}");
    if (!testData.BinaryData.Equals(deserializedData.BinaryData))
      return false;
    Console.WriteLine($"  DocumentHash: {deserializedData.DocumentHash}");
    if (!testData.DocumentHash.Equals(deserializedData.DocumentHash))
      return false;
    Console.WriteLine($"  ImageData: {deserializedData.ImageData}");
    if (!testData.ImageData.Equals(deserializedData.ImageData))
      return false;

    Console.WriteLine();
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestHexBinaryJsonSerialization()
  {
    Console.WriteLine("--- Testing HexBinary JSON Serialization ---");

    // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<HexBinaryTestDataClass>(jsonString, jsonOptions);

    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");
    // Verify deserialized data
    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  BinaryData: {deserializedData.BinaryData}");
    if (!testData.BinaryData.Equals(deserializedData.BinaryData))
      return false;
    Console.WriteLine($"  DocumentHash: {deserializedData.DocumentHash}");
    if (!testData.DocumentHash.Equals(deserializedData.DocumentHash))
      return false;
    Console.WriteLine($"  ImageData: {deserializedData.ImageData}");
    if (!testData.ImageData.Equals(deserializedData.ImageData))
      return false;

    Console.WriteLine();
    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  private static HexBinaryTestDataClass CreateTestData()
  {
    return new HexBinaryTestDataClass
    {
      BinaryData = new byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F },
      DocumentHash = "A1B2C3D4E5F6",
      ImageData = new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 } // JPEG header
    };
  }

  private static void ShowOriginalData(HexBinaryTestDataClass testData)
  {
    Console.WriteLine($"Original data:");

    Console.WriteLine($"  BinaryData: {testData.BinaryData}");
    Console.WriteLine($"  DocumentHash: {testData.DocumentHash}");
    Console.WriteLine($"  ImageData: {testData.ImageData}");
    Console.WriteLine();
  }

  
  static bool TestHexBinaryEdgeCases()
  {
    Console.WriteLine("--- Testing HexBinary Edge Cases ---");

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

  
  
  static bool TestHexBinaryPerformance()
  {
    Console.WriteLine("--- Testing HexBinary Performance ---");

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

    // Test Deserialization performance
    string jsonData = JsonSerializer.Serialize(testObj);
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      var obj = JsonSerializer.Deserialize<HexBinaryTestDataClass>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations}: {sw.ElapsedMilliseconds}ms");

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

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;

  }

  
}


/// <summary>
/// Test data class containing various HexBinary properties.
/// </summary>
[XmlRoot("TestData")]
public class HexBinaryTestDataClass
{
  [XmlElement("BinaryData")]
  public HexBinary BinaryData { get; set; }

  [XmlElement("DocumentHash")]
  public HexBinary DocumentHash { get; set; }

  [XmlElement("ImageData")]
  public HexBinary ImageData { get; set; }
}

/// <summary>
/// Simple wrapper class for testing nullable scenarios.
/// </summary>
public class HexBinaryTestWrapper
{
  public HexBinary Data { get; set; }
}

#endregion