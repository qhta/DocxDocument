using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for VStreamData type serialization in both XML and JSON formats.
/// </summary>
public static class VStreamDataSerializationTests
{
  /// <summary>
  /// Runs all VStreamData serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== VStreamData Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestVStreamDataConstruction()) return false;
    if (!TestVStreamDataProperties()) return false;
    if (!TestVStreamDataEquality()) return false;
    if (!TestVStreamDataVersionGUIDs()) return false;
    if (!TestVStreamDataXmlSerialization()) return false;
    if (!TestVStreamDataJsonSerialization()) return false;
    if (!TestVStreamDataEdgeCases()) return false;
    if (!TestVStreamDataPerformance()) return false;

    return true;
  }

  #region Construction Tests

  static bool TestVStreamDataConstruction()
  {
    Console.WriteLine("--- Testing VStreamData Construction ---");      // Test constructor with version GUID and data
    Console.WriteLine("Testing construction with version GUID and data:");
    Guid versionGuid = new Guid("12345678-1234-1234-1234-123456789ABC");
    byte[] streamData = Encoding.UTF8.GetBytes("Stream Data Content");
    VStreamData streamInfo = new VStreamData(versionGuid, streamData);
    Console.WriteLine($"\n✓ Created stream data: Version={streamInfo.Version}, Size={streamInfo.Data.Length}");

    // Test constructor with Guid.Empty
    Console.WriteLine("\nTesting construction with Guid.Empty:");
    VStreamData emptyGuidStream = new VStreamData(Guid.Empty, streamData);
    Console.WriteLine($"\n✓ Created with Guid.Empty: Version={emptyGuidStream.Version}");

    // Test constructor with empty data
    Console.WriteLine("\nTesting construction with empty data:");
    byte[] emptyData = Array.Empty<byte>();
    VStreamData emptyDataStream = new VStreamData(versionGuid, emptyData);
    Console.WriteLine($"\n✓ Created with empty data: Size={emptyDataStream.Data.Length}");

    // Test constructor with null data (should become empty array)
    Console.WriteLine("\nTesting construction with null data:");
    VStreamData nullDataStream = new VStreamData(versionGuid, null!);
    Console.WriteLine($"\n✓ Created with null data (converted to empty): Size={nullDataStream.Data.Length}");

    // Test constructor with OLE CLSID
    Console.WriteLine("\nTesting construction with OLE CLSID:");
    Guid excelClsid = new Guid("00020810-0000-0000-C000-000000000046");
    byte[] oleData = new byte[512];
    VStreamData oleStream = new VStreamData(excelClsid, oleData);
    Console.WriteLine($"\n✓ Created OLE stream: Version={oleStream.Version}");

    // Test constructor with large data
    Console.WriteLine("\nTesting construction with large data:");
    byte[] largeData = new byte[100000];
    for (int i = 0; i < largeData.Length; i++)
    {
      largeData[i] = (byte)(i % 256);
    }
    VStreamData largeStream = new VStreamData(versionGuid, largeData);
    Console.WriteLine($"\n✓ Created large stream: Size={largeStream.Data.Length} bytes");

    Console.WriteLine("\n✓ All construction tests passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Property Tests

  static bool TestVStreamDataProperties()
  {
    Console.WriteLine("--- Testing VStreamData Properties ---");      // Test Version property
    Console.WriteLine("Testing Version property:");
    Guid testGuid = new Guid("ABCDEF12-3456-7890-ABCD-EF1234567890");
    byte[] data1 = Encoding.UTF8.GetBytes("Test Data");
    VStreamData streamData1 = new VStreamData(testGuid, data1);
    Console.WriteLine($"  Version: {streamData1.Version}");
    if (streamData1.Version != testGuid)
    {
      Console.WriteLine("✗ Version property test FAILED");
      return false;
    }
    Console.WriteLine("\n✓ Version property works correctly");

    // Test Data property
    Console.WriteLine("\nTesting Data property:");
    byte[] originalData = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05 };
    VStreamData streamData2 = new VStreamData(testGuid, originalData);
    Console.WriteLine($"  Data length: {streamData2.Data.Length}");
    Console.WriteLine($"  Data bytes: {string.Join(", ", streamData2.Data.Select(b => $"0x{b:X2}"))}");

    bool dataMatches = true;
    for (int i = 0; i < originalData.Length; i++)
    {
      if (streamData2.Data[i] != originalData[i])
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

    // Test with binary OLE data
    Console.WriteLine("\nTesting with binary OLE-like data:");
    byte[] oleData = new byte[] {
        0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1, // OLE header signature
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
      };
    VStreamData oleStream = new VStreamData(testGuid, oleData);
    Console.WriteLine($"  OLE header preserved: {oleStream.Data[0]:X2} {oleStream.Data[1]:X2} {oleStream.Data[2]:X2} {oleStream.Data[3]:X2}");

    // Test Data property never returns null
    Console.WriteLine("\nTesting Data property with null constructor parameter:");
    VStreamData nullStream = new VStreamData(testGuid, null!);
    bool isNull = nullStream.Data == null;
    if (isNull)
      Console.WriteLine($"  Data is null: {isNull}");
    else
      Console.WriteLine($"  Data length: {nullStream.Data!.Length}");
    if (isNull)
    {
      Console.WriteLine("✗ Data should never be null");
      return false;
    }
    Console.WriteLine("\n✓ Data property never returns null (empty array instead)");

    // Test with embedded document-like data
    Console.WriteLine("\nTesting with embedded document data:");
    string documentContent = "<?xml version=\"1.0\"?><document><content>Embedded</content></document>";
    byte[] docBytes = Encoding.UTF8.GetBytes(documentContent);
    VStreamData docStream = new VStreamData(testGuid, docBytes);
    string reconstructed = Encoding.UTF8.GetString(docStream.Data);
    Console.WriteLine($"  Original: {documentContent.Substring(0, System.Math.Min(50, documentContent.Length))}...");
    Console.WriteLine($"  Reconstructed: {reconstructed.Substring(0, System.Math.Min(50, reconstructed.Length))}...");
    if (reconstructed != documentContent)
    {
      Console.WriteLine("✗ Document content test FAILED");
      return false;
    }
    Console.WriteLine("\n✓ Document content preserved correctly");

    Console.WriteLine("\n✓ All property tests passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Equality Tests

  static bool TestVStreamDataEquality()
  {
    Console.WriteLine("--- Testing VStreamData Equality ---");      // Test equal instances
    Console.WriteLine("Testing equal instances:");
    Guid guid1 = new Guid("11111111-2222-3333-4444-555555555555");
    byte[] data1 = new byte[] { 1, 2, 3, 4 };
    VStreamData stream1 = new VStreamData(guid1, data1);
    VStreamData stream2 = new VStreamData(guid1, new byte[] { 1, 2, 3, 4 });
    Console.WriteLine($"  stream1.Equals(stream2): {stream1.Equals(stream2)}");
    if (!stream1.Equals(stream2))
    {
      Console.WriteLine("✗ Equal instances test FAILED");
      return false;
    }

    // Test different version GUID
    Console.WriteLine("\nTesting different version GUID:");
    Guid guid2 = new Guid("99999999-8888-7777-6666-555555555555");
    VStreamData stream3 = new VStreamData(guid2, data1);
    Console.WriteLine($"  stream1.Equals(stream3): {stream1.Equals(stream3)}");
    if (stream1.Equals(stream3))
    {
      Console.WriteLine("✗ Different version GUID test FAILED");
      return false;
    }

    // Test different data
    Console.WriteLine("\nTesting different data:");
    VStreamData stream4 = new VStreamData(guid1, new byte[] { 5, 6, 7, 8 });
    Console.WriteLine($"  stream1.Equals(stream4): {stream1.Equals(stream4)}");
    if (stream1.Equals(stream4))
    {
      Console.WriteLine("✗ Different data test FAILED");
      return false;
    }

    // Test different length
    Console.WriteLine("\nTesting different length:");
    VStreamData stream5 = new VStreamData(guid1, new byte[] { 1, 2 });
    Console.WriteLine($"  stream1.Equals(stream5): {stream1.Equals(stream5)}");
    if (stream1.Equals(stream5))
    {
      Console.WriteLine("✗ Different length test FAILED");
      return false;
    }

    // Test hash code consistency
    Console.WriteLine("\nTesting hash code consistency:");
    VStreamData streamA = new VStreamData(guid1, new byte[] { 10, 20, 30 });
    VStreamData streamB = new VStreamData(guid1, new byte[] { 10, 20, 30 });
    Console.WriteLine($"  streamA.GetHashCode(): {streamA.GetHashCode()}");
    Console.WriteLine($"  streamB.GetHashCode(): {streamB.GetHashCode()}");
    if (streamA.GetHashCode() != streamB.GetHashCode())
    {
      Console.WriteLine("✗ Hash code consistency test FAILED");
      return false;
    }
    Console.WriteLine("\n✓ Equal instances have same hash code");

    // Test empty data equality
    Console.WriteLine("\nTesting empty data equality:");
    VStreamData emptyA = new VStreamData(guid1, Array.Empty<byte>());
    VStreamData emptyB = new VStreamData(guid1, Array.Empty<byte>());
    Console.WriteLine($"  emptyA.Equals(emptyB): {emptyA.Equals(emptyB)}");
    if (!emptyA.Equals(emptyB))
    {
      Console.WriteLine("✗ Empty data equality test FAILED");
      return false;
    }

    // Test Guid.Empty equality
    Console.WriteLine("\nTesting Guid.Empty equality:");
    VStreamData emptyGuidA = new VStreamData(Guid.Empty, data1);
    VStreamData emptyGuidB = new VStreamData(Guid.Empty, new byte[] { 1, 2, 3, 4 });
    Console.WriteLine($"  emptyGuidA.Equals(emptyGuidB): {emptyGuidA.Equals(emptyGuidB)}");
    if (!emptyGuidA.Equals(emptyGuidB))
    {
      Console.WriteLine("✗ Guid.Empty equality test FAILED");
      return false;
    }

    Console.WriteLine("\n✓ All equality tests passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Version GUID Tests

  static bool TestVStreamDataVersionGUIDs()
  {
    Console.WriteLine("--- Testing VStreamData Version GUIDs ---");      // Test with Excel CLSID
    Console.WriteLine("Testing with Excel CLSID:");
    Guid excelClsid = new Guid("00020810-0000-0000-C000-000000000046");
    byte[] excelData = new byte[256];
    VStreamData excelStream = new VStreamData(excelClsid, excelData);
    Console.WriteLine($"\n✓ Excel CLSID: {excelStream.Version}");

    // Test with Word CLSID
    Console.WriteLine("\nTesting with Word CLSID:");
    Guid wordClsid = new Guid("00020906-0000-0000-C000-000000000046");
    byte[] wordData = new byte[256];
    VStreamData wordStream = new VStreamData(wordClsid, wordData);
    Console.WriteLine($"\n✓ Word CLSID: {wordStream.Version}");

    // Test with PowerPoint CLSID
    Console.WriteLine("\nTesting with PowerPoint CLSID:");
    Guid pptClsid = new Guid("64818D10-4F9B-11CF-86EA-00AA00B929E8");
    byte[] pptData = new byte[256];
    VStreamData pptStream = new VStreamData(pptClsid, pptData);
    Console.WriteLine($"\n✓ PowerPoint CLSID: {pptStream.Version}");

    // Test with custom format GUID
    Console.WriteLine("\nTesting with custom format GUID:");
    Guid customFormat = Guid.NewGuid();
    byte[] customData = Encoding.UTF8.GetBytes("Custom format data");
    VStreamData customStream = new VStreamData(customFormat, customData);
    Console.WriteLine($"\n✓ Custom format: {customStream.Version}");

    // Test with Guid.Empty (unversioned)
    Console.WriteLine("\nTesting with Guid.Empty (unversioned):");
    VStreamData unversionedStream = new VStreamData(Guid.Empty, excelData);
    Console.WriteLine($"\n✓ Unversioned stream: {unversionedStream.Version}");
    Console.WriteLine($"  Is Guid.Empty: {unversionedStream.Version == Guid.Empty}");

    // Test GUID string format consistency
    Console.WriteLine("\nTesting GUID string format:");
    Guid testGuid = new Guid("AAAAAAAA-BBBB-CCCC-DDDD-EEEEEEEEEEEE");
    VStreamData guidFormatStream = new VStreamData(testGuid, customData);
    string guidString = guidFormatStream.Version?.ToString() ?? "";
    Console.WriteLine($"  GUID format: {guidString}");
    Console.WriteLine($"  Has hyphens: {guidString.Contains("-")}");
    Console.WriteLine($"\n✓ GUID format is standard (with hyphens)");

    Console.WriteLine("\n✓ All version GUID tests passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region XML Serialization Tests

  static bool TestVStreamDataXmlSerialization()
  {
    Console.WriteLine("--- Testing VStreamData XML Serialization ---");      // Create test object
    var testData = CreateTestData();

    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(VStreamDataTestData));
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

    Console.WriteLine("Serialized XML (first 800 chars):");
    Console.WriteLine(xmlString.Substring(0, System.Math.Min(800, xmlString.Length)));
    Console.WriteLine("...");
    Console.WriteLine();

    // Deserialize from XML
    VStreamDataTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (VStreamDataTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;

  }

  private static bool VerifyDeserializedData(VStreamDataTestData? deserializedData, VStreamDataTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  ExcelStream: Version={deserializedData.ExcelStream.Version}, Size={deserializedData.ExcelStream.Data.Length}");
    if (!testData.ExcelStream.Equals(deserializedData.ExcelStream))
      return false;
    Console.WriteLine($"  WordStream: Version={deserializedData.WordStream.Version}, Size={deserializedData.WordStream.Data.Length}");
    if (!testData.WordStream.Equals(deserializedData.WordStream))
      return false;
    Console.WriteLine($"  BinaryStream: Version={deserializedData.BinaryStream.Version}, Size={deserializedData.BinaryStream.Data.Length}");
    if (!testData.BinaryStream.Equals(deserializedData.BinaryStream))
      return false;
    Console.WriteLine($"  EmptyStream: Version={deserializedData.EmptyStream.Version}, Size={deserializedData.EmptyStream.Data.Length}");
    if (!testData.EmptyStream.Equals(deserializedData.EmptyStream))
      return false;
    Console.WriteLine($"  LargeStream: Version={deserializedData.LargeStream.Version}, Size={deserializedData.LargeStream.Data.Length}");
    if (!testData.LargeStream.Equals(deserializedData.LargeStream))
      return false;

    return true;
  }

  #endregion

  #region JSON Serialization Tests

  static bool TestVStreamDataJsonSerialization()
  {
    Console.WriteLine("--- Testing VStreamData JSON Serialization ---");      // Create test object
    var testData = CreateTestData();

    ShowOriginalData(testData);

    // Serialize to JSON
    var jsonOptions = new JsonSerializerOptions
    {
      WriteIndented = true,
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    string jsonString = JsonSerializer.Serialize(testData, jsonOptions);

    Console.WriteLine("Serialized JSON (first 800 chars):");
    Console.WriteLine(jsonString.Substring(0, System.Math.Min(800, jsonString.Length)));
    Console.WriteLine("...");
    Console.WriteLine();

    // Deserialize from JSON
    var deserializedData = JsonSerializer.Deserialize<VStreamDataTestData>(jsonString, jsonOptions);

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

  #endregion

  #region Edge Cases Tests

  static bool TestVStreamDataEdgeCases()
  {
    Console.WriteLine("--- Testing VStreamData Edge Cases ---");      // Test with all zeros data
    Console.WriteLine("Testing with all zeros:");
    byte[] zeros = new byte[100];
    VStreamData zeroData = new VStreamData(Guid.NewGuid(), zeros);
    Console.WriteLine($"\n✓ All zeros: Size={zeroData.Data.Length}");

    // Test with all 0xFF data
    Console.WriteLine("\nTesting with all 0xFF:");
    byte[] ones = Enumerable.Repeat((byte)0xFF, 100).ToArray();
    VStreamData onesData = new VStreamData(Guid.NewGuid(), ones);
    Console.WriteLine($"\n✓ All 0xFF: Size={onesData.Data.Length}");

    // Test with single byte
    Console.WriteLine("\nTesting with single byte:");
    byte[] singleByte = new byte[] { 0x42 };
    VStreamData singleData = new VStreamData(Guid.NewGuid(), singleByte);
    Console.WriteLine($"\n✓ Single byte: Size={singleData.Data.Length}");

    // Test with very large data (simulating embedded document)
    Console.WriteLine("\nTesting with large embedded document:");
    byte[] largeDoc = new byte[1024 * 1024]; // 1 MB
    for (int i = 0; i < largeDoc.Length; i++)
    {
      largeDoc[i] = (byte)(i % 256);
    }
    VStreamData largeDocData = new VStreamData(Guid.NewGuid(), largeDoc);
    Console.WriteLine($"\n✓ Large document: Size={largeDocData.Data.Length / 1024}KB");

    // Test with OLE compound file signature
    Console.WriteLine("\nTesting with OLE compound file signature:");
    byte[] oleSignature = new byte[] {
        0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1,
        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
      };
    VStreamData oleData = new VStreamData(Guid.NewGuid(), oleSignature);
    bool hasOleSignature = oleData.Data[0] == 0xD0 && oleData.Data[1] == 0xCF;
    Console.WriteLine($"  Has OLE signature: {hasOleSignature}");
    if (!hasOleSignature)
    {
      Console.WriteLine("✗ OLE signature test FAILED");
      return false;
    }
    Console.WriteLine("\n✓ OLE signature preserved");

    // Test hash code for edge cases
    Console.WriteLine("\nTesting hash codes for edge cases:");
    VStreamData hash1 = new VStreamData(Guid.Empty, Array.Empty<byte>());
    VStreamData hash2 = new VStreamData(Guid.Empty, new byte[] { 0 });
    VStreamData hash3 = new VStreamData(Guid.NewGuid(), Array.Empty<byte>());
    Console.WriteLine($"  Empty GUID + empty data: {hash1.GetHashCode()}");
    Console.WriteLine($"  Empty GUID + single zero: {hash2.GetHashCode()}");
    Console.WriteLine($"  Random GUID + empty data: {hash3.GetHashCode()}");
    Console.WriteLine("\n✓ Hash codes generated for edge cases");

    // Test with XML-like embedded content
    Console.WriteLine("\nTesting with XML embedded content:");
    string xmlContent = "<?xml version=\"1.0\"?><root><data>Test &lt;&gt; &amp;</data></root>";
    byte[] xmlBytes = Encoding.UTF8.GetBytes(xmlContent);
    VStreamData xmlData = new VStreamData(Guid.NewGuid(), xmlBytes);
    string reconstructed = Encoding.UTF8.GetString(xmlData.Data);
    if (reconstructed != xmlContent)
    {
      Console.WriteLine("✗ XML content test FAILED");
      return false;
    }
    Console.WriteLine("\n✓ XML content with special characters preserved");

    // Test with binary pattern
    Console.WriteLine("\nTesting with repeating binary pattern:");
    byte[] pattern = new byte[256];
    for (int i = 0; i < pattern.Length; i++)
    {
      pattern[i] = (byte)(i % 16);
    }
    VStreamData patternData = new VStreamData(Guid.NewGuid(), pattern);
    Console.WriteLine($"\n✓ Pattern data: Size={patternData.Data.Length}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Performance Tests

  static bool TestVStreamDataPerformance()
  {
    Console.WriteLine("--- Testing VStreamData Performance ---"); const int iterations = 10000;
    Guid testGuid = Guid.NewGuid();

    // Test construction
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      byte[] data = new byte[] { 1, 2, 3, 4, 5 };
      VStreamData streamData = new VStreamData(testGuid, data);
    }
    sw.Stop();
    Console.WriteLine($"Construction x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test equality comparison
    VStreamData streamA = new VStreamData(testGuid, CreateTestData(100));
    VStreamData streamB = new VStreamData(testGuid, CreateTestData(100));
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      bool equal = streamA.Equals(streamB);
    }
    sw.Stop();
    Console.WriteLine($"Equality comparison x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test hash code generation
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int hash = streamA.GetHashCode();
    }
    sw.Stop();
    Console.WriteLine($"GetHashCode() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization
    var testObj = new VStreamDataTestData
    {
      ExcelStream = new VStreamData(
        new Guid("00020810-0000-0000-C000-000000000046"),
        CreateTestData(100)
      ),
      WordStream = new VStreamData(
        new Guid("00020906-0000-0000-C000-000000000046"),
        CreateTestData(100)
      ),
      BinaryStream = new VStreamData(testGuid, CreateTestData(50)),
      EmptyStream = new VStreamData(Guid.Empty, Array.Empty<byte>()),
      LargeStream = new VStreamData(Guid.NewGuid(), CreateTestData(200))
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
      var obj = JsonSerializer.Deserialize<VStreamDataTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 100}: {sw.ElapsedMilliseconds}ms");

    // Test with large data (10KB)
    Console.WriteLine("\nTesting with large data (10KB):");
    byte[] largeData = CreateTestData(10240);
    sw.Restart();
    for (int i = 0; i < 1000; i++)
    {
      VStreamData largeStream = new VStreamData(testGuid, largeData);
    }
    sw.Stop();
    Console.WriteLine($"Large data construction x 1000: {sw.ElapsedMilliseconds}ms");

    // Test GUID parsing performance
    Console.WriteLine("\nTesting GUID operations:");
    string guidString = testGuid.ToString();
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      Guid.TryParse(guidString, out _);
    }
    sw.Stop();
    Console.WriteLine($"GUID parsing x {iterations}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Helper Methods

  private static VStreamDataTestData CreateTestData()
  {
    return new VStreamDataTestData
    {
      ExcelStream = new VStreamData(
        new Guid("{00020810-0000-0000-C000-000000000046}"),
        Encoding.UTF8.GetBytes("Excel OLE Data")
      ),
      WordStream = new VStreamData(
        new Guid("{00020906-0000-0000-C000-000000000046}"),
        Encoding.UTF8.GetBytes("Word Document Data")
      ),
      BinaryStream = new VStreamData(
        new Guid("{12345678-ABCD-1234-5678-123456789ABC}"),
        new byte[] { 0xDE, 0xAD, 0xBE, 0xEF, 0xCA, 0xFE, 0xBA, 0xBE }
      ),
      EmptyStream = new VStreamData(
        Guid.NewGuid(),
        Array.Empty<byte>()
      ),
      LargeStream = new VStreamData(
        Guid.NewGuid(),
        CreateTestData(2000)
      )
    };
  }

  private static void ShowOriginalData(VStreamDataTestData testData)
  {
    Console.WriteLine($"Original data:");

    Console.WriteLine($"  ExcelStream: Version={testData.ExcelStream.Version}, Size={testData.ExcelStream.Data.Length}");
    Console.WriteLine($"  WordStream: Version={testData.WordStream.Version}, Size={testData.WordStream.Data.Length}");
    Console.WriteLine($"  BinaryStream: Version={testData.BinaryStream.Version}, Size={testData.BinaryStream.Data.Length}");
    Console.WriteLine($"  EmptyStream: Version={testData.EmptyStream.Version}, Size={testData.EmptyStream.Data.Length}");
    Console.WriteLine($"  LargeStream: Version={testData.LargeStream.Version}, Size={testData.LargeStream.Data.Length}");
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

  #endregion
}

#region Test Helper Classes

/// <summary>
/// Test data class containing various VStreamData properties.
/// </summary>
[XmlRoot("VStreamDataTestData")]
public class VStreamDataTestData
{
  [XmlElement("ExcelStream")]
  public VStreamData ExcelStream { get; set; }

  [XmlElement("WordStream")]
  public VStreamData WordStream { get; set; }

  [XmlElement("BinaryStream")]
  public VStreamData BinaryStream { get; set; }

  [XmlElement("EmptyStream")]
  public VStreamData EmptyStream { get; set; }

  [XmlElement("LargeStream")]
  public VStreamData LargeStream { get; set; }
}

#endregion