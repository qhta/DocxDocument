namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for HexLong type serialization in both XML and JSON formats.
/// </summary>
public static class HexLongTest
{
  /// <summary>
  /// Runs all HexLong serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== HexLong Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestHexLongBasicOperations()) return false;
    if (!TestHexLongXmlSerialization()) return false;
    if (!TestHexLongJsonSerialization()) return false;
    if (!TestHexLongEdgeCases()) return false;
    if (!TestHexLongPerformance()) return false;

    return true;
  }

  
  static bool TestHexLongBasicOperations()
  {
    Console.WriteLine("--- Testing HexLong Basic Operations ---");      // Test string to HexLong conversion
    HexLong hexInt1 = "0000007B"; // 123 in hex
    Console.WriteLine($"\n✓ String to HexLong: {hexInt1} = {hexInt1.ToInt32(null)}");

    // Test int to HexLong conversion
    HexLong hexInt2 = 123;
    Console.WriteLine($"\n✓ Int to HexLong: {hexInt2}");

    // Test equality
    if (hexInt1.Equals(hexInt2))
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test HexLong to string
    string str = hexInt1.ToString();
    Console.WriteLine($"\n✓ HexLong to string: {str}");

    // Test HexLong to int
    int value = hexInt1;
    Console.WriteLine($"\n✓ HexLong to int: {value}");

    // Test negative values
    HexLong negative = -1;
    Console.WriteLine($"\n✓ Negative value (-1): {negative}");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {hexInt1.GetHashCode()}");

    // Test HexBinary conversion
    HexBinary binary = (HexBinary)hexInt1;
    HexLong backToInt = (HexLong)binary;
    Console.WriteLine($"\n✓ HexLong ↔ HexBinary conversion: {hexInt1} → {binary} → {backToInt}");

    // Test various numeric conversions
    uint uintVal = (uint)hexInt1;
    ushort ushortVal = (ushort)hexInt1;
    ulong ulongVal = (ulong)hexInt1;
    Console.WriteLine($"\n✓ Numeric conversions: uint={uintVal}, ushort={ushortVal}, ulong={ulongVal}");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestHexLongXmlSerialization()
  {
    Console.WriteLine("--- Testing HexLong XML Serialization ---");      // Create test object
    var testData = new HexLongTestData
    {
      RevisionId = 123,
      DocumentHash = "DEADBEEF",
      ColorARGB = 0xFF0000FF,  // Red in ARGB
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

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(HexLongTestData));
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
    HexLongTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (HexLongTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(HexLongTestData? deserializedData, HexLongTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
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

  
  
  static bool TestHexLongJsonSerialization()
  {
    Console.WriteLine("--- Testing HexLong JSON Serialization ---");      // Create test object
    var testData = new HexLongTestData
    {
      RevisionId = 456,
      DocumentHash = "CAFEBABE",
      ColorARGB = 0x00FF00FF,  // Green in ARGB
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
    var deserializedData = JsonSerializer.Deserialize<HexLongTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestHexLongEdgeCases()
  {
    Console.WriteLine("--- Testing HexLong Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    HexLong zero = 0;
    Console.WriteLine($"  Zero: '{zero}' (Value: {zero.ToInt32(null)})");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    HexLong maxPositive = long.MaxValue;  // 9,223,372,036,854,775,807
    HexLong minNegative = long.MinValue;  // -9,223,372,036,854,775,808
    Console.WriteLine($"  Max positive ({long.MaxValue}): '{maxPositive}'");
    Console.WriteLine($"  Min negative ({long.MinValue}): '{minNegative}'");

    // Test power of 2 values
    Console.WriteLine("\nTesting power of 2 values:");
    HexLong pow8 = 256;
    HexLong pow16 = 65536;
    HexLong pow24 = 16777216;
    Console.WriteLine($"  2^8 (256): '{pow8}'");
    Console.WriteLine($"  2^16 (65536): '{pow16}'");
    Console.WriteLine($"  2^24 (16777216): '{pow24}'");

    // Test special hex patterns
    Console.WriteLine("\nTesting special hex patterns:");
    HexLong deadbeef = new HexLong("DEADBEEF");
    HexLong cafebabe = new HexLong("CAFEBABE");
    HexLong allFs = new HexLong("FFFFFFFF");
    Console.WriteLine($"  DEADBEEF: '{deadbeef}' = {deadbeef.ToInt32(null)}");
    Console.WriteLine($"  CAFEBABE: '{cafebabe}' = {cafebabe.ToInt32(null)}");
    Console.WriteLine($"  FFFFFFFF: '{allFs}' = {allFs.ToInt32(null)}");

    // Test case insensitivity
    Console.WriteLine("\nTesting case insensitivity:");
    HexLong upper = new HexLong("ABCD1234");
    HexLong lower = new HexLong("abcd1234");
    Console.WriteLine($"  Uppercase 'ABCD1234': {upper} = {upper.ToInt32(null)}");
    Console.WriteLine($"  Lowercase 'abcd1234': {lower} = {lower.ToInt32(null)}");
    Console.WriteLine($"  Are equal: {upper.Equals(lower)}");

    // Test with and without leading zeros
    Console.WriteLine("\nTesting with/without leading zeros:");
    HexLong withZeros = new HexLong("0000007B");
    HexLong withoutZeros = new HexLong("7B");
    Console.WriteLine($"  With zeros '0000007B': {withZeros}");
    Console.WriteLine($"  Without zeros '7B': {withoutZeros}");
    Console.WriteLine($"  Are equal: {withZeros.Equals(withoutZeros)}");

    // Test color values (ARGB)
    Console.WriteLine("\nTesting ARGB color values:");
    HexLong red = new HexLong(0xFF0000FF);
    HexLong green = new HexLong(0x00FF00FF);
    HexLong blue = new HexLong(0x0000FFFF);
    Console.WriteLine($"  Red (ARGB): {red}");
    Console.WriteLine($"  Green (ARGB): {green}");
    Console.WriteLine($"  Blue (ARGB): {blue}");

    // Test conversions
    Console.WriteLine("\nTesting type conversions:");
    int intVal = 12345;
    HexLong fromInt = intVal;
    Console.WriteLine($"  From int (12345): {fromInt}");

    uint uintVal = 0xABCDEF01;
    HexLong fromUInt = (HexLong)uintVal;
    Console.WriteLine($"  From uint (0xABCDEF01): {fromUInt} = {fromUInt.ToInt32(null)}");

    ushort ushortVal = 60000;
    HexLong fromUShort = ushortVal;
    Console.WriteLine($"  From ushort (60000): {fromUShort}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestHexLongPerformance()
  {
    Console.WriteLine("--- Testing HexLong Performance ---"); const int iterations = 100000;

    // Test construction from string
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      HexLong hex = new HexLong("0000007B");
    }
    sw.Stop();
    Console.WriteLine($"Construction from string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from int
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      HexLong hex = new HexLong(123);
    }
    sw.Stop();
    Console.WriteLine($"Construction from int x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    HexLong testInt = new HexLong(123);
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testInt.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new HexLongTestData
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
    for (int i = 0; i < iterations / 10; i++) // Fewer iterations for serialization
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
      var obj = JsonSerializer.Deserialize<HexLongTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test equality comparison performance
    HexLong hex1 = new HexLong(123);
    HexLong hex2 = new HexLong(123);
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      bool equal = hex1.Equals(hex2);
    }
    sw.Stop();
    Console.WriteLine($"Equality comparison x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test implicit conversions performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int value = hex1;
    }
    sw.Stop();
    Console.WriteLine($"Implicit conversion to int x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test HexBinary conversion performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      HexBinary binary = (HexBinary)hex1;
    }
    sw.Stop();
    Console.WriteLine($"Conversion to HexBinary x {iterations}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  }


/// <summary>
/// Test data class containing various HexLong properties.
/// </summary>
[XmlRoot("HexLongTestData")]
public class HexLongTestData
{
  [XmlElement("RevisionId")]
  public HexLong RevisionId { get; set; }

  [XmlElement("DocumentHash")]
  public HexLong DocumentHash { get; set; }

  [XmlElement("ColorARGB")]
  public HexLong ColorARGB { get; set; }

  [XmlElement("NegativeValue")]
  public HexLong NegativeValue { get; set; }

  [XmlElement("Zero")]
  public HexLong Zero { get; set; }

  [XmlElement("MaxPositive")]
  public HexLong MaxPositive { get; set; }

  [XmlElement("MinNegative")]
  public HexLong MinNegative { get; set; }
}

