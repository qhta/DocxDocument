using System.Globalization;
using System.Text;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for VClipboardData type serialization in both XML and JSON formats.
/// </summary>
public static class VClipboardDataTest
{
  /// <summary>
  /// Runs all VClipboardData serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== VClipboardData Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestVClipboardDataConstruction()) return false;
    if (!TestVClipboardDataProperties()) return false;
    if (!TestVClipboardDataEquality()) return false;
    if (!TestVClipboardDataClipboardFormats()) return false;
    if (!TestVClipboardDataXmlSerialization()) return false;
    if (!TestVClipboardDataJsonSerialization()) return false;
    if (!TestVClipboardDataEdgeCases()) return false;
    if (!TestVClipboardDataPerformance()) return false;

    return true;
  }

  
  static bool TestVClipboardDataConstruction()
  {
    Console.WriteLine("--- Testing VClipboardData Construction ---");      // Test constructor with text data
    Console.WriteLine("Testing construction with text data:");
    byte[] textBytes = System.Text.Encoding.UTF8.GetBytes("Hello, World!");
    VClipboardData textData = new VClipboardData(1, textBytes); // CF_TEXT
    Console.WriteLine($"\n✓ Created text clipboard data: Format={textData.Format}, Size={textData.Size}");

    // Test constructor with binary data
    Console.WriteLine("\nTesting construction with binary data:");
    byte[] binaryData = new byte[] { 0xDE, 0xAD, 0xBE, 0xEF };
    VClipboardData binaryClipData = new VClipboardData(2, binaryData); // CF_BITMAP
    Console.WriteLine($"\n✓ Created binary clipboard data: Format={binaryClipData.Format}, Size={binaryClipData.Size}");

    // Test constructor with empty data
    Console.WriteLine("\nTesting construction with empty data:");
    byte[] emptyData = Array.Empty<byte>();
    VClipboardData emptyClipData = new VClipboardData(13, emptyData); // CF_UNICODETEXT
    Console.WriteLine($"\n✓ Created empty clipboard data: Format={emptyClipData.Format}, Size={emptyClipData.Size}");

    // Test constructor with large data
    Console.WriteLine("\nTesting construction with large data:");
    byte[] largeData = new byte[10000];
    for (int i = 0; i < largeData.Length; i++)
    {
      largeData[i] = (byte)(i % 256);
    }
    VClipboardData largeClipData = new VClipboardData(8, largeData); // CF_DIB
    Console.WriteLine($"\n✓ Created large clipboard data: Format={largeClipData.Format}, Size={largeClipData.Size}");

    Console.WriteLine("\n✓ All construction tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVClipboardDataProperties()
  {
    Console.WriteLine("--- Testing VClipboardData Properties ---");      // Test Format property
    Console.WriteLine("Testing Format property:");
    byte[] data1 = System.Text.Encoding.UTF8.GetBytes("Test");
    VClipboardData clipData1 = new VClipboardData(1, data1);
    Console.WriteLine($"  Format: {clipData1.Format}");
    if (clipData1.Format != 1)
    {
      Console.WriteLine("✗ Format property test FAILED");
      return false;
    }
    Console.WriteLine("\n✓ Format property works correctly");

    // Test Size property
    Console.WriteLine("\nTesting Size property:");
    Console.WriteLine($"  Size: {clipData1.Size}");
    Console.WriteLine($"  Data Length: {clipData1.Data.Length}");
    if (clipData1.Size != clipData1.Data.Length)
    {
      Console.WriteLine("✗ Size property test FAILED - size doesn't match data length");
      return false;
    }
    Console.WriteLine("\n✓ Size property matches data length");

    // Test Data property
    Console.WriteLine("\nTesting Data property:");
    byte[] originalData = new byte[] { 1, 2, 3, 4, 5 };
    VClipboardData clipData2 = new VClipboardData(8, originalData);
    Console.WriteLine($"  Data length: {clipData2.Data.Length}");
    Console.WriteLine($"  Data bytes: {string.Join(", ", clipData2.Data)}");

    bool dataMatches = true;
    for (int i = 0; i < originalData.Length; i++)
    {
      if (clipData2.Data[i] != originalData[i])
      {
        dataMatches = false;
        break;
      }
    }

    if (!dataMatches)
    {
      Console.WriteLine("✗ Data property test FAILED");
      return false;
    }
    Console.WriteLine("\n✓ Data property preserves original bytes");

    // Test with Unicode text
    Console.WriteLine("\nTesting with Unicode text:");
    string unicodeText = "Hello 世界 🌍";
    byte[] unicodeBytes = System.Text.Encoding.UTF8.GetBytes(unicodeText);
    VClipboardData unicodeClipData = new VClipboardData(13, unicodeBytes); // CF_UNICODETEXT
    Console.WriteLine($"  Original text: '{unicodeText}'");
    Console.WriteLine($"  Size: {unicodeClipData.Size} bytes");
    string reconstructed = System.Text.Encoding.UTF8.GetString(unicodeClipData.Data);
    Console.WriteLine($"  Reconstructed: '{reconstructed}'");
    if (reconstructed != unicodeText)
    {
      Console.WriteLine("✗ Unicode text test FAILED");
      return false;
    }
    Console.WriteLine("\n✓ Unicode text preserved correctly");

    Console.WriteLine("\n✓ All property tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVClipboardDataEquality()
  {
    Console.WriteLine("--- Testing VClipboardData Equality ---");      // Test equal instances
    Console.WriteLine("Testing equal instances:");
    byte[] data1 = new byte[] { 1, 2, 3, 4 };
    VClipboardData clip1 = new VClipboardData(1, data1);
    VClipboardData clip2 = new VClipboardData(1, new byte[] { 1, 2, 3, 4 });
    Console.WriteLine($"  clip1.Equals(clip2): {clip1.Equals(clip2)}");
    if (!clip1.Equals(clip2))
    {
      Console.WriteLine("✗ Equal instances test FAILED");
      return false;
    }

    // Test different format
    Console.WriteLine("\nTesting different format:");
    VClipboardData clip3 = new VClipboardData(2, data1);
    Console.WriteLine($"  clip1.Equals(clip3): {clip1.Equals(clip3)}");
    if (clip1.Equals(clip3))
    {
      Console.WriteLine("✗ Different format test FAILED");
      return false;
    }

    // Test different data
    Console.WriteLine("\nTesting different data:");
    VClipboardData clip4 = new VClipboardData(1, new byte[] { 5, 6, 7, 8 });
    Console.WriteLine($"  clip1.Equals(clip4): {clip1.Equals(clip4)}");
    if (clip1.Equals(clip4))
    {
      Console.WriteLine("✗ Different data test FAILED");
      return false;
    }

    // Test different length
    Console.WriteLine("\nTesting different length:");
    VClipboardData clip5 = new VClipboardData(1, new byte[] { 1, 2 });
    Console.WriteLine($"  clip1.Equals(clip5): {clip1.Equals(clip5)}");
    if (clip1.Equals(clip5))
    {
      Console.WriteLine("✗ Different length test FAILED");
      return false;
    }

    // Test hash code consistency
    Console.WriteLine("\nTesting hash code consistency:");
    VClipboardData clipA = new VClipboardData(1, new byte[] { 10, 20, 30 });
    VClipboardData clipB = new VClipboardData(1, new byte[] { 10, 20, 30 });
    Console.WriteLine($"  clipA.GetHashCode(): {clipA.GetHashCode()}");
    Console.WriteLine($"  clipB.GetHashCode(): {clipB.GetHashCode()}");
    if (clipA.GetHashCode() != clipB.GetHashCode())
    {
      Console.WriteLine("✗ Hash code consistency test FAILED");
      return false;
    }
    Console.WriteLine("\n✓ Equal instances have same hash code");

    // Test empty data equality
    Console.WriteLine("\nTesting empty data equality:");
    VClipboardData emptyA = new VClipboardData(1, Array.Empty<byte>());
    VClipboardData emptyB = new VClipboardData(1, Array.Empty<byte>());
    Console.WriteLine($"  emptyA.Equals(emptyB): {emptyA.Equals(emptyB)}");
    if (!emptyA.Equals(emptyB))
    {
      Console.WriteLine("✗ Empty data equality test FAILED");
      return false;
    }

    Console.WriteLine("\n✓ All equality tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVClipboardDataClipboardFormats()
  {
    Console.WriteLine("--- Testing VClipboardData Clipboard Formats ---");      // Test CF_TEXT (1)
    Console.WriteLine("Testing CF_TEXT format (1):");
    string ansiText = "ANSI Text";
    byte[] ansiBytes = System.Text.Encoding.ASCII.GetBytes(ansiText);
    VClipboardData textClip = new VClipboardData(1, ansiBytes);
    Console.WriteLine($"\n✓ CF_TEXT: Format={textClip.Format}, Size={textClip.Size}");

    // Test CF_BITMAP (2)
    Console.WriteLine("\nTesting CF_BITMAP format (2):");
    byte[] bitmapBytes = new byte[] { 0x42, 0x4D }; // BM header
    VClipboardData bitmapClip = new VClipboardData(2, bitmapBytes);
    Console.WriteLine($"\n✓ CF_BITMAP: Format={bitmapClip.Format}, Size={bitmapClip.Size}");

    // Test CF_METAFILEPICT (3)
    Console.WriteLine("\nTesting CF_METAFILEPICT format (3):");
    byte[] metaBytes = new byte[100];
    VClipboardData metaClip = new VClipboardData(3, metaBytes);
    Console.WriteLine($"\n✓ CF_METAFILEPICT: Format={metaClip.Format}, Size={metaClip.Size}");

    // Test CF_DIB (8)
    Console.WriteLine("\nTesting CF_DIB format (8):");
    byte[] dibBytes = new byte[256];
    VClipboardData dibClip = new VClipboardData(8, dibBytes);
    Console.WriteLine($"\n✓ CF_DIB: Format={dibClip.Format}, Size={dibClip.Size}");

    // Test CF_UNICODETEXT (13)
    Console.WriteLine("\nTesting CF_UNICODETEXT format (13):");
    string unicodeText = "Unicode Text: 你好";
    byte[] unicodeBytes = System.Text.Encoding.Unicode.GetBytes(unicodeText);
    VClipboardData unicodeClip = new VClipboardData(13, unicodeBytes);
    Console.WriteLine($"\n✓ CF_UNICODETEXT: Format={unicodeClip.Format}, Size={unicodeClip.Size}");

    // Test CF_ENHMETAFILE (14)
    Console.WriteLine("\nTesting CF_ENHMETAFILE format (14):");
    byte[] emfBytes = new byte[512];
    VClipboardData emfClip = new VClipboardData(14, emfBytes);
    Console.WriteLine($"\n✓ CF_ENHMETAFILE: Format={emfClip.Format}, Size={emfClip.Size}");

    // Test CF_HDROP (15)
    Console.WriteLine("\nTesting CF_HDROP format (15):");
    byte[] hdropBytes = System.Text.Encoding.Unicode.GetBytes("file1.txt\0file2.txt\0\0");
    VClipboardData hdropClip = new VClipboardData(15, hdropBytes);
    Console.WriteLine($"\n✓ CF_HDROP: Format={hdropClip.Format}, Size={hdropClip.Size}");

    // Test custom format (>= 0xC000)
    Console.WriteLine("\nTesting custom format (0xC000):");
    byte[] customBytes = System.Text.Encoding.UTF8.GetBytes("Custom Format Data");
    VClipboardData customClip = new VClipboardData(0xC000, customBytes);
    Console.WriteLine($"\n✓ Custom format: Format={customClip.Format}, Size={customClip.Size}");

    Console.WriteLine("\n✓ All clipboard format tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVClipboardDataXmlSerialization()
  {
    Console.WriteLine("--- Testing VClipboardData XML Serialization ---");      // Create test object
    var testData = CreateTestData();

    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(VClipboardDataTestData));
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

    Console.WriteLine("Serialized XML (first 500 chars):");
    Console.WriteLine(xmlString.Substring(0, System.Math.Min(500, xmlString.Length)));
    Console.WriteLine("...");
    Console.WriteLine();

    // Deserialize from XML
    VClipboardDataTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (VClipboardDataTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(VClipboardDataTestData? deserializedData, VClipboardDataTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  TextClipboard: Format={deserializedData.TextClipboard.Format}, Size={deserializedData.TextClipboard.Size}");
    if (!testData.TextClipboard.Equals(deserializedData.TextClipboard))
      return false;
    Console.WriteLine($"  BitmapClipboard: Format={deserializedData.BitmapClipboard.Format}, Size={deserializedData.BitmapClipboard.Size}");
    if (!testData.BitmapClipboard.Equals(deserializedData.BitmapClipboard))
      return false;
    Console.WriteLine($"  BinaryClipboard: Format={deserializedData.BinaryClipboard.Format}, Size={deserializedData.BinaryClipboard.Size}");
    if (!testData.BinaryClipboard.Equals(deserializedData.BinaryClipboard))
      return false;
    Console.WriteLine($"  EmptyClipboard: Format={deserializedData.EmptyClipboard.Format}, Size={deserializedData.EmptyClipboard.Size}");
    if (!testData.EmptyClipboard.Equals(deserializedData.EmptyClipboard))
      return false;
    Console.WriteLine($"  LargeClipboard: Format={deserializedData.LargeClipboard.Format}, Size={deserializedData.LargeClipboard.Size}");
    if (!testData.LargeClipboard.Equals(deserializedData.LargeClipboard))
      return false;

    return true;
  }

  
  
  static bool TestVClipboardDataJsonSerialization()
  {
    Console.WriteLine("--- Testing VClipboardData JSON Serialization ---");      // Create test object
    var testData = CreateTestData();

    ShowOriginalData(testData);

    // Serialize to JSON
    var jsonOptions = new JsonSerializerOptions
    {
      WriteIndented = true,
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    string jsonString = JsonSerializer.Serialize(testData, jsonOptions);

    Console.WriteLine("Serialized JSON (first 500 chars):");
    Console.WriteLine(jsonString.Substring(0, System.Math.Min(500, jsonString.Length)));
    Console.WriteLine("...");
    Console.WriteLine();

    // Deserialize from JSON
    var deserializedData = JsonSerializer.Deserialize<VClipboardDataTestData>(jsonString, jsonOptions);

    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }
    if (!VerifyDeserializedData(deserializedData, testData))
      return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVClipboardDataEdgeCases()
  {
    Console.WriteLine("--- Testing VClipboardData Edge Cases ---");      // Test with all zeros
    Console.WriteLine("Testing with all zeros:");
    byte[] zeros = new byte[100];
    VClipboardData zeroData = new VClipboardData(1, zeros);
    Console.WriteLine($"\n✓ All zeros: Size={zeroData.Size}");

    // Test with all 0xFF
    Console.WriteLine("\nTesting with all 0xFF:");
    byte[] ones = Enumerable.Repeat((byte)0xFF, 100).ToArray();
    VClipboardData onesData = new VClipboardData(2, ones);
    Console.WriteLine($"\n✓ All 0xFF: Size={onesData.Size}");

    // Test with single byte
    Console.WriteLine("\nTesting with single byte:");
    byte[] singleByte = new byte[] { 0x42 };
    VClipboardData singleData = new VClipboardData(3, singleByte);
    Console.WriteLine($"\n✓ Single byte: Size={singleData.Size}");

    // Test with very large format number
    Console.WriteLine("\nTesting with large format number:");
    VClipboardData largeFormatData = new VClipboardData(0xFFFF, new byte[] { 1, 2, 3 });
    Console.WriteLine($"\n✓ Large format: Format={largeFormatData.Format}");

    // Test with binary patterns
    Console.WriteLine("\nTesting with repeating pattern:");
    byte[] pattern = new byte[256];
    for (int i = 0; i < pattern.Length; i++)
    {
      pattern[i] = (byte)(i % 16);
    }
    VClipboardData patternData = new VClipboardData(8, pattern);
    Console.WriteLine($"\n✓ Pattern data: Size={patternData.Size}");

    // Test hash code for edge cases
    Console.WriteLine("\nTesting hash codes:");
    VClipboardData hash1 = new VClipboardData(1, Array.Empty<byte>());
    VClipboardData hash2 = new VClipboardData(1, new byte[] { 0 });
    VClipboardData hash3 = new VClipboardData(2, Array.Empty<byte>());
    Console.WriteLine($"  Empty (format 1): {hash1.GetHashCode()}");
    Console.WriteLine($"  Single zero (format 1): {hash2.GetHashCode()}");
    Console.WriteLine($"  Empty (format 2): {hash3.GetHashCode()}");
    Console.WriteLine("\n✓ Hash codes generated for edge cases");

    // Test with special characters in text
    Console.WriteLine("\nTesting with special characters:");
    string specialText = "Tab:\t Newline:\n Quote:\" Backslash:\\";
    byte[] specialBytes = System.Text.Encoding.UTF8.GetBytes(specialText);
    VClipboardData specialData = new VClipboardData(1, specialBytes);
    string reconstructed = System.Text.Encoding.UTF8.GetString(specialData.Data);
    if (reconstructed != specialText)
    {
      Console.WriteLine("✗ Special characters test FAILED");
      return false;
    }
    Console.WriteLine("\n✓ Special characters preserved");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestVClipboardDataPerformance()
  {
    Console.WriteLine("--- Testing VClipboardData Performance ---"); const int iterations = 10000;

    // Test construction
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      byte[] data = new byte[] { 1, 2, 3, 4, 5 };
      VClipboardData clipData = new VClipboardData(1, data);
    }
    sw.Stop();
    Console.WriteLine($"Construction x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test equality comparison
    VClipboardData clipA = new VClipboardData(1, CreateTestData(100));
    VClipboardData clipB = new VClipboardData(1, CreateTestData(100));
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      bool equal = clipA.Equals(clipB);
    }
    sw.Stop();
    Console.WriteLine($"Equality comparison x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test hash code generation
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int hash = clipA.GetHashCode();
    }
    sw.Stop();
    Console.WriteLine($"GetHashCode() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization
    var testObj = new VClipboardDataTestData
    {
      TextClipboard = new VClipboardData(1, System.Text.Encoding.UTF8.GetBytes("Performance test")),
      BitmapClipboard = new VClipboardData(2, CreateTestData(100)),
      BinaryClipboard = new VClipboardData(8, CreateTestData(50)),
      EmptyClipboard = new VClipboardData(13, Array.Empty<byte>()),
      LargeClipboard = new VClipboardData(14, CreateTestData(200))
    };

    sw.Restart();
    for (int i = 0; i < iterations / 100; i++)
    {
      string json = JsonSerializer.Serialize(testObj);
    }
    sw.Stop();
    Console.WriteLine($"JSON Serialization x {iterations / 100}: {sw.ElapsedMilliseconds}ms");

    // Test Deserialization
    string jsonData = JsonSerializer.Serialize(testObj);
    sw.Restart();
    for (int i = 0; i < iterations / 100; i++)
    {
      var obj = JsonSerializer.Deserialize<VClipboardDataTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 100}: {sw.ElapsedMilliseconds}ms");

    // Test with large data
    Console.WriteLine("\nTesting with large data (10KB):");
    byte[] largeData = CreateTestData(10240);
    sw.Restart();
    for (int i = 0; i < 1000; i++)
    {
      VClipboardData largeClip = new VClipboardData(8, largeData);
    }
    sw.Stop();
    Console.WriteLine($"Large data construction x 1000: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  
  
  private static VClipboardDataTestData CreateTestData()
  {
    return new VClipboardDataTestData
    {
      TextClipboard = new VClipboardData(1, System.Text.Encoding.UTF8.GetBytes("Hello, World!")),
      BitmapClipboard = new VClipboardData(2, new byte[] { 0x42, 0x4D, 0x00, 0x00 }),
      BinaryClipboard = new VClipboardData(8, new byte[] { 0xDE, 0xAD, 0xBE, 0xEF }),
      EmptyClipboard = new VClipboardData(13, Array.Empty<byte>()),
      LargeClipboard = new VClipboardData(14, CreateTestData(1000))
    };
  }

  private static void ShowOriginalData(VClipboardDataTestData testData)
  {
    Console.WriteLine($"Original data:");

    Console.WriteLine($"  TextClipboard: Format={testData.TextClipboard.Format}, Size={testData.TextClipboard.Size}");
    Console.WriteLine($"  BitmapClipboard: Format={testData.BitmapClipboard.Format}, Size={testData.BitmapClipboard.Size}");
    Console.WriteLine($"  BinaryClipboard: Format={testData.BinaryClipboard.Format}, Size={testData.BinaryClipboard.Size}");
    Console.WriteLine($"  EmptyClipboard: Format={testData.EmptyClipboard.Format}, Size={testData.EmptyClipboard.Size}");
    Console.WriteLine($"  LargeClipboard: Format={testData.LargeClipboard.Format}, Size={testData.LargeClipboard.Size}");
    Console.WriteLine();
  }

  /// <summary>
  /// Creates test data of specified size with predictable content.
  /// </summary>
  private static byte[] CreateTestData(int size)
  {
    byte[] data = new byte[size];
    for (int i = 0; i < size; i++)
    {
      data[i] = (byte)(i % 256);
    }
    return data;
  }

  }


/// <summary>
/// Test data class containing various VClipboardData properties.
/// </summary>
[XmlRoot("VClipboardDataTestData")]
public class VClipboardDataTestData
{
  [XmlElement("TextClipboard")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public VClipboardData TextClipboard { get; set; }

  [XmlElement("BitmapClipboard")]
  public VClipboardData BitmapClipboard { get; set; }

  [XmlElement("BinaryClipboard")]
  public VClipboardData BinaryClipboard { get; set; }

  [XmlElement("EmptyClipboard")]
  public VClipboardData EmptyClipboard { get; set; }

  [XmlElement("LargeClipboard")]
  public VClipboardData LargeClipboard { get; set; }
}

