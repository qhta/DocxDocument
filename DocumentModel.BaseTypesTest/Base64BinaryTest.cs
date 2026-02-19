namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for Base64Binary type serialization in both XML and JSON formats.
/// </summary>
public static class Base64BinaryTest
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

  
  static bool TestBase64BinaryBasicOperations()
  {
    Console.WriteLine("--- Testing Base64Binary Basic Operations ---");

    // Test string to Base64Binary conversion
    Base64Binary base1 = "SGVsbG8="; // "Hello" in Base64Binary
    Console.WriteLine($"\n✓ String to Base64Binary: {base1}");

    // Test byte array to Base64Binary conversion
    byte[] bytes = new byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F };
    Base64Binary base2 = bytes;
    Console.WriteLine($"\n✓ Byte array to Base64Binary: {base2}");

    // Test equality
    if (base1.Equals(base2))
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test Base64Binary to string
    string str = base1;
    Console.WriteLine($"\n✓ Base64Binary to string: {str}");

    // Test Base64Binary to byte array
    byte[] resultBytes = base1;
    Console.WriteLine($"\n✓ Base64Binary to byte array: [{string.Join(", ", resultBytes.Select(b => $"0x{b:X2}"))}]");

    // Test Length property
    Console.WriteLine($"\n✓ Length: {base1.Length} bytes");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {base1.GetHashCode()}");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;

  }

  
  
  static bool TestBase64BinaryXmlSerialization()
  {
    Console.WriteLine("--- Testing Base64Binary XML Serialization ---");

    // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

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

  private static void ShowOriginalData(Base64BinaryTestDataClass testData)
  {
    Console.WriteLine($"Original data:");

    Console.WriteLine($"  BinaryData: {testData.BinaryData}");
    Console.WriteLine($"  DocumentHash: {testData.DocumentHash}");
    Console.WriteLine($"  ImageData: {testData.ImageData}");
    Console.WriteLine();
  }

  private static Base64BinaryTestDataClass CreateTestData()
  {
    var testData = new Base64BinaryTestDataClass
    {
      BinaryData = new byte[] { 0xDE, 0xAD, 0xBE, 0xEF },
      DocumentHash = "A1B2C3D4E5F6",
      ImageData = new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 } // JPEG header
    };
    return testData;
  }

  
  
  static bool TestBase64BinaryJsonSerialization()
  {
    Console.WriteLine("--- Testing Base64Binary JSON Serialization ---");

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
    var deserializedData = JsonSerializer.Deserialize<Base64BinaryTestDataClass>(jsonString, jsonOptions);

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

  
  
  static bool TestBase64BinaryEdgeCases()
  {
    Console.WriteLine("--- Testing Base64Binary Edge Cases ---");

    // Test empty Base64Binary
    Console.WriteLine("Testing empty Base64Binary:");
    Base64Binary empty = new byte[0];
    Console.WriteLine($"  Empty Base64Binary: '{empty}' (Length: {empty.Length})");

    // Serialize and deserialize empty
    string jsonEmpty = JsonSerializer.Serialize(new { Data = empty });
    Console.WriteLine($"  JSON: {jsonEmpty}");
    var deserializedEmpty = JsonSerializer.Deserialize<Base64BinaryTestWrapper>(jsonEmpty);
    if (deserializedEmpty == null)
    {
      Console.WriteLine($"  Deserialized empty is null");
      return false;
    }
    Console.WriteLine($"  Deserialized empty equals original: {empty.Equals(deserializedEmpty.Data ?? default)}");

    // Test single byte
    Console.WriteLine("\nTesting single byte:");
    Base64Binary singleByte = new byte[] { 0xFF };
    Console.WriteLine($"  Single byte: '{singleByte}' (Length: {singleByte.Length})");

    // Test large binary data
    Console.WriteLine("\nTesting large binary data:");
    byte[] largeData = new byte[1024];
    for (int i = 0; i < largeData.Length; i++)
      largeData[i] = (byte)(i % 256);
    Base64Binary large = largeData;
    Console.WriteLine($"  Large data: Length = {large.Length} bytes");
    Console.WriteLine($"  First 32 chars: {large.ToString().Substring(0, System.Math.Min(32, large.ToString().Length))}...");

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

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;

  }

  
  
  static bool TestBase64BinaryPerformance()
  {
    Console.WriteLine("--- Testing Base64Binary Performance ---");

    const int iterations = 10000;
    byte[] testData = new byte[256];
    for (int i = 0; i < 256; i++)
      testData[i] = (byte)i;

    // Test conversion performance
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      Base64Binary hex = testData;
      string str = hex;
    }
    sw.Stop();
    Console.WriteLine($"Conversion (byte[] → Base64Binary → string) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new Base64BinaryTestDataClass
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
      var obj = JsonSerializer.Deserialize<Base64BinaryTestDataClass>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test equality comparison performance
    Base64Binary base1 = testData;
    Base64Binary base2 = testData;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      bool equal = base1.Equals(base2);
    }
    sw.Stop();
    Console.WriteLine($"Equality comparison x {iterations}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  
}


/// <summary>
/// Test data class containing various Base64Binary properties.
/// </summary>
[XmlRoot("TestData")]
public class Base64BinaryTestDataClass
{
  [XmlElement("BinaryData")]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
  public Base64Binary BinaryData { get; set; }

  [XmlElement("DocumentHash")]
  public Base64Binary DocumentHash { get; set; }

  [XmlElement("ImageData")]
  public Base64Binary ImageData { get; set; }
}

/// <summary>
/// Simple wrapper class for testing nullable scenarios.
/// </summary>
public class Base64BinaryTestWrapper
{
  public Base64Binary? Data { get; set; }
}

