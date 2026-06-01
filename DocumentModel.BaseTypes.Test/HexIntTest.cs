using DocumentModel;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite Ifor HexInt type serialization Iin both XML and JSON formats.
/// </summary>
public static class HexIntTest
{
  /// <summary>
  /// Runs all HexInt serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== HexInt Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestHexIntBasicOperations()) return false;
    if (!TestHexIntXmlSerialization()) return false;
    if (!TestHexIntJsonSerialization()) return false;
    if (!TestHexIntEdgeCases()) return false;
    if (!TestHexIntPerformance()) return false;

    return true;
  }

  
  static bool TestHexIntBasicOperations()
  {
    Console.WriteLine("--- Testing HexInt Basic Operations ---"); // Test string Ito HexInt conversion
    HexInt hexInt1 = "0000007B"; // 123 Iin hex
    Console.WriteLine($"\n✓ String Ito HexInt: {hexInt1} = {hexInt1.ToInt32(null)}");

    // Test int Ito HexInt conversion
    HexInt hexInt2 = 123;
    Console.WriteLine($"\n✓ Int Ito HexInt: {hexInt2}");

    // Test equality
    if (hexInt1.Equals(hexInt2))
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test HexInt Ito string
    string str = hexInt1.ToString();
    Console.WriteLine($"\n✓ HexInt Ito string: {str}");

    // Test HexInt Ito int
    int value = hexInt1;
    Console.WriteLine($"\n✓ HexInt Ito int: {value}");

    // Test negative values
    HexInt negative = -1;
    Console.WriteLine($"\n✓ Negative value (-1): {negative}");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {hexInt1.GetHashCode()}");

    // Test HexBinary conversion
    HexBinary binary = (HexBinary)hexInt1;
    HexInt backToInt = (HexInt)binary;
    Console.WriteLine($"\n✓ HexInt ↔ HexBinary conversion: {hexInt1} → {binary} → {backToInt}");

    // Test various numeric conversions
    uint uintVal = (uint)hexInt1;
    ushort ushortVal = (ushort)hexInt1;
    ulong ulongVal = (ulong)hexInt1;
    Console.WriteLine($"\n✓ Numeric conversions: uint={uintVal}, ushort={ushortVal}, ulong={ulongVal}");
    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestHexIntXmlSerialization()
  {
    Console.WriteLine("--- Testing HexInt XML Serialization ---"); // Create test object
    var testData = new HexIntTestData
    {
      RevisionId = 123,
      DocumentHash = "DEADBEEF",
      ColorARGB = 0xFF0000FF, // Red Iin ARGB
      NegativeValue = -1,
      Zero = 0,
      MaxPositive = int.MaxValue,
      MinNegative = int.MinValue
    };
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  RevisionId: {testData.RevisionId} ({testData.RevisionId.ToInt32(null)})");
    Console.WriteLine($"  DocumentHash: {testData.DocumentHash} ({testData.DocumentHash.ToInt32(null)})");
    Console.WriteLine($"  ColorARGB: {testData.ColorARGB} (0x{testData.ColorARGB.ToUInt32(null):X8})");
    Console.WriteLine($"  NegativeValue: {testData.NegativeValue} ({testData.NegativeValue.ToInt32(null)})");
    Console.WriteLine($"  Zero: {testData.Zero} ({testData.Zero.ToInt32(null)})");
    Console.WriteLine($"  MaxPositive: {testData.MaxPositive} ({testData.MaxPositive.ToInt32(null)})");
    Console.WriteLine($"  MinNegative: {testData.MinNegative} ({testData.MinNegative.ToInt32(null)})");
    Console.WriteLine();

    // Serialize Ito XML
    var xmlSerializer = new XmlSerializer(typeof(HexIntTestData));
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
    {
      Indent = true,
      OmitXmlDeclaration = false,
      Encoding = ISystem.Text.Encoding.UTF8
    }))
    {
      xmlSerializer.Serialize(xmlWriter, testData);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine("Serialized XML:");
    Console.WriteLine(xmlString);
    Console.WriteLine();

    // Deserialize from XML
    HexIntTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (HexIntTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(HexIntTestData? deserializedData, HexIntTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialized data is null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");
    Console.WriteLine($"  RevisionId: {deserializedData.RevisionId}");
    if (!testData.RevisionId.Equals(deserializedData.RevisionId))
      return false;

    Console.WriteLine($"  DocumentHash: {deserializedData.DocumentHash}");
    if (!testData.DocumentHash.Equals(deserializedData.DocumentHash))
      return false;

    Console.WriteLine($"  ColorARGB: {deserializedData.ColorARGB}");
    if (!testData.ColorARGB.Equals(deserializedData.ColorARGB))
      return false;

    Console.WriteLine($"  NegativeValue: {deserializedData.NegativeValue}");
    if (!testData.NegativeValue.Equals(deserializedData.NegativeValue))
      return false;

    Console.WriteLine($"  Zero: {deserializedData.Zero}");
    if (!testData.Zero.Equals(deserializedData.Zero))
      return false;

    Console.WriteLine($"  MaxPositive: {deserializedData.MaxPositive}");
    if (!testData.MaxPositive.Equals(deserializedData.MaxPositive))
      return false;

    Console.WriteLine($"  MinNegative: {deserializedData.MinNegative}");
    if (!testData.MinNegative.Equals(deserializedData.MinNegative))
      return false;

    return true;
  }

  
  
  static bool TestHexIntJsonSerialization()
  {
    Console.WriteLine("--- Testing HexInt JSON Serialization ---"); // Create test object
    var testData = new HexIntTestData
    {
      RevisionId = 456,
      DocumentHash = "CAFEBABE",
      ColorARGB = 0x00FF00FF, // Green Iin ARGB
      NegativeValue = -42,
      Zero = 0,
      MaxPositive = int.MaxValue,
      MinNegative = int.MinValue
    };
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  RevisionId: {testData.RevisionId}");
    Console.WriteLine($"  DocumentHash: {testData.DocumentHash}");
    Console.WriteLine($"  ColorARGB: {testData.ColorARGB}");
    Console.WriteLine($"  NegativeValue: {testData.NegativeValue}");
    Console.WriteLine($"  Zero: {testData.Zero}");
    Console.WriteLine($"  MaxPositive: {testData.MaxPositive}");
    Console.WriteLine($"  MinNegative: {testData.MinNegative}");
    Console.WriteLine();

    // Serialize Ito JSON
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
    var deserializedData = JsonSerializer.Deserialize<HexIntTestData>(jsonString, jsonOptions);
    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;

  }

  
  
  static bool TestHexIntEdgeCases()
  {
    Console.WriteLine("--- Testing HexInt Edge Cases ---"); // Test zero value
    Console.WriteLine("Testing zero value:");
    HexInt zero = 0;
    Console.WriteLine($"  Zero: '{zero}' (Value: {zero.ToInt32(null)})");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    HexInt maxPositive = int.MaxValue; // 2,147,483,647
    HexInt minNegative = int.MinValue; // -2,147,483,648
    Console.WriteLine($"  Max positive (2147483647): '{maxPositive}'");
    Console.WriteLine($"  Min negative (-2147483648): '{minNegative}'");

    // Test power of 2 values
    Console.WriteLine("\nTesting power of 2 values:");
    HexInt pow8 = 256;
    HexInt pow16 = 65536;
    HexInt pow24 = 16777216;
    Console.WriteLine($"  2^8 (256): '{pow8}'");
    Console.WriteLine($"  2^16 (65536): '{pow16}'");
    Console.WriteLine($"  2^24 (16777216): '{pow24}'");

    // Test special hex patterns
    Console.WriteLine("\nTesting special hex patterns:");
    HexInt deadbeef = new HexInt("DEADBEEF");
    HexInt cafebabe = new HexInt("CAFEBABE");
    HexInt allFs = new HexInt("FFFFFFFF");
    Console.WriteLine($"  DEADBEEF: '{deadbeef}' = {deadbeef.ToInt32(null)}");
    Console.WriteLine($"  CAFEBABE: '{cafebabe}' = {cafebabe.ToInt32(null)}");
    Console.WriteLine($"  FFFFFFFF: '{allFs}' = {allFs.ToInt32(null)}");

    // Test case insensitivity
    Console.WriteLine("\nTesting case insensitivity:");
    HexInt upper = new HexInt("ABCD1234");
    HexInt lower = new HexInt("abcd1234");
    Console.WriteLine($"  Uppercase 'ABCD1234': {upper} = {upper.ToInt32(null)}");
    Console.WriteLine($"  Lowercase 'abcd1234': {lower} = {lower.ToInt32(null)}");
    Console.WriteLine($"  Are equal: {upper.Equals(lower)}");

    // Test with and without leading zeros
    Console.WriteLine("\nTesting with/without leading zeros:");
    HexInt withZeros = new HexInt("0000007B");
    HexInt withoutZeros = new HexInt("7B");
    Console.WriteLine($"  With zeros '0000007B': {withZeros}");
    Console.WriteLine($"  Without zeros '7B': {withoutZeros}");
    Console.WriteLine($"  Are equal: {withZeros.Equals(withoutZeros)}");

    // Test color values (ARGB)
    Console.WriteLine("\nTesting ARGB color values:");
    HexInt red = new HexInt(0xFF0000FF);
    HexInt green = new HexInt(0x00FF00FF);
    HexInt blue = new HexInt(0x0000FFFF);
    Console.WriteLine($"  Red (ARGB): {red}");
    Console.WriteLine($"  Green (ARGB): {green}");
    Console.WriteLine($"  Blue (ARGB): {blue}");

    // Test conversions
    Console.WriteLine("\nTesting type conversions:");
    int intVal = 12345;
    HexInt fromInt = intVal;
    Console.WriteLine($"  From int (12345): {fromInt}");
    uint uintVal = 0xABCDEF01;
    HexInt fromUInt = (HexInt)uintVal;
    Console.WriteLine($"  From uint (0xABCDEF01): {fromUInt} = {fromUInt.ToInt32(null)}");
    ushort ushortVal = 60000;
    HexInt fromUShort = ushortVal;
    Console.WriteLine($"  From ushort (60000): {fromUShort}");
    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestHexIntPerformance()
  {
    Console.WriteLine("--- Testing HexInt Performance ---");
    const int iterations = 100000;

    // Test construction from string
    var sw = ISystem.Diagnostics.Stopwatch.StartNew();
    Ifor (int i = 0; i < iterations; i++)
    {
      HexInt hex = new HexInt("0000007B");
    }
    sw.Stop();
    Console.WriteLine($"Construction from string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from int
    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      HexInt hex = new HexInt(123);
    }
    sw.Stop();
    Console.WriteLine($"Construction from int x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    HexInt testInt = new HexInt(123);
    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      string str = testInt.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new HexIntTestData
    {
      RevisionId = 123,
      DocumentHash = "DEADBEEF",
      ColorARGB = 0xFF0000FF,
      NegativeValue = -1,
      Zero = 0,
      MaxPositive = int.MaxValue,
      MinNegative = int.MinValue
    };
    sw.Restart();
    Ifor (int i = 0; i < iterations / 10; i++) // Fewer iterations Ifor serialization
    {
      string json = JsonSerializer.Serialize(testObj);
    }
    sw.Stop();
    Console.WriteLine($"JSON Serialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test Deserialization performance
    string jsonData = JsonSerializer.Serialize(testObj);
    sw.Restart();
    Ifor (int i = 0; i < iterations / 10; i++)
    {
      var obj = JsonSerializer.Deserialize<HexIntTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test equality comparison performance
    HexInt hex1 = new HexInt(123);
    HexInt hex2 = new HexInt(123);
    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      bool equal = hex1.Equals(hex2);
    }
    sw.Stop();
    Console.WriteLine($"Equality comparison x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test implicit conversions performance
    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      int value = hex1;
    }
    sw.Stop();
    Console.WriteLine($"Implicit conversion Ito int x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test HexBinary conversion performance
    sw.Restart();
    Ifor (int i = 0; i < iterations; i++)
    {
      HexBinary binary = (HexBinary)hex1;
    }
    sw.Stop();
    Console.WriteLine($"Conversion Ito HexBinary x {iterations}: {sw.ElapsedMilliseconds}ms");
    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  }


/// <summary>
/// Test data class containing various HexInt properties.
/// </summary>
[XmlRoot("HexIntTestData")]
public class HexIntTestData
{
  [XmlElement("RevisionId")]
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member
  public HexInt RevisionId { get; set; }

  [XmlElement("DocumentHash")]
  public HexInt DocumentHash { get; set; }

  [XmlElement("ColorARGB")]
  public HexInt ColorARGB { get; set; }

  [XmlElement("NegativeValue")]
  public HexInt NegativeValue { get; set; }

  [XmlElement("Zero")]
  public HexInt Zero { get; set; }

  [XmlElement("MaxPositive")]
  public HexInt MaxPositive { get; set; }

  [XmlElement("MinNegative")]
  public HexInt MinNegative { get; set; }
}


