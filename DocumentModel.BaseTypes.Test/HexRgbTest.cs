using System.Globalization;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for HexRgb type serialization in both XML and JSON formats.
/// </summary>
public static class HexRgbTest
{
  /// <summary>
  /// Runs all HexRgb serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== HexRgb Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestHexRgbBasicOperations()) return false;
    if (!TestHexRgbColorOperations()) return false;
    if (!TestHexRgbConversions()) return false;
    if (!TestHexRgbXmlSerialization()) return false;
    if (!TestHexRgbJsonSerialization()) return false;
    if (!TestHexRgbEdgeCases()) return false;
    if (!TestHexRgbPerformance()) return false;

    return true;
  }

  
  static bool TestHexRgbBasicOperations()
  {
    Console.WriteLine("--- Testing HexRgb Basic Operations ---");      // Test string to HexRgb conversion
    HexColor color1 = new HexColor("FF0000");
    Console.WriteLine($"\n✓ String to HexRgb: {color1} = Red({color1.R}), Green({color1.G}), Blue({color1.B})");

    // Test UInt32 to HexRgb conversion
    HexColor color2 = new HexColor(0xFF0000U);
    Console.WriteLine($"\n✓ UInt32 to HexRgb: {color2}");

    // Test byte components constructor
    HexColor color3 = new HexColor(255, 0, 0);
    Console.WriteLine($"\n✓ Byte components to HexRgb: {color3}");

    // Test equality
    if (color1.Equals(color2) && color2.Equals(color3))
      Console.WriteLine("\n✓ Equality test passed (all three reds are equal)");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test HexRgb to string
    string str = color1.ToString();
    Console.WriteLine($"\n✓ HexRgb to string: {str}");

    // Test component access
    Console.WriteLine($"\n✓ Component access: R={color1.R}, G={color1.G}, B={color1.B}");

    // Test component modification
    HexColor mutableColor = new HexColor(100, 150, 200);
    Console.WriteLine($"\n✓ Original color: {mutableColor}");
    mutableColor.R = 255;
    Console.WriteLine($"\n✓ After setting R=255: {mutableColor}");
    mutableColor.G = 128;
    Console.WriteLine($"\n✓ After setting G=128: {mutableColor}");
    mutableColor.B = 64;
    Console.WriteLine($"\n✓ After setting B=64: {mutableColor}");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {color1.GetHashCode()}");

    // Test implicit conversions
    UInt32 uintVal = color1;
    Int32 intVal = color1;
    Console.WriteLine($"\n✓ Implicit conversions: UInt32={uintVal:X6}, Int32={intVal:X6}");

    HexColor fromUInt = uintVal;
    HexColor fromInt = intVal;
    Console.WriteLine($"\n✓ Back to HexRgb: fromUInt={fromUInt}, fromInt={fromInt}");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestHexRgbColorOperations()
  {
    Console.WriteLine("--- Testing HexRgb Color Operations ---");      // Test primary colors
    Console.WriteLine("Testing primary colors:");
    HexColor red = new HexColor(255, 0, 0);
    HexColor green = new HexColor(0, 255, 0);
    HexColor blue = new HexColor(0, 0, 255);
    Console.WriteLine($"  Red: {red} (R={red.R}, G={red.G}, B={red.B})");
    Console.WriteLine($"  Green: {green} (R={green.R}, G={green.G}, B={green.B})");
    Console.WriteLine($"  Blue: {blue} (R={blue.R}, G={blue.G}, B={blue.B})");

    // Test secondary colors
    Console.WriteLine("\nTesting secondary colors:");
    HexColor yellow = new HexColor(255, 255, 0);
    HexColor cyan = new HexColor(0, 255, 255);
    HexColor magenta = new HexColor(255, 0, 255);
    Console.WriteLine($"  Yellow: {yellow} (R={yellow.R}, G={yellow.G}, B={yellow.B})");
    Console.WriteLine($"  Cyan: {cyan} (R={cyan.R}, G={cyan.G}, B={cyan.B})");
    Console.WriteLine($"  Magenta: {magenta} (R={magenta.R}, G={magenta.G}, B={magenta.B})");

    // Test grayscale colors
    Console.WriteLine("\nTesting grayscale colors:");
    HexColor black = new HexColor(0, 0, 0);
    HexColor white = new HexColor(255, 255, 255);
    HexColor gray50 = new HexColor(128, 128, 128);
    HexColor gray25 = new HexColor(64, 64, 64);
    HexColor gray75 = new HexColor(192, 192, 192);
    Console.WriteLine($"  Black: {black}");
    Console.WriteLine($"  White: {white}");
    Console.WriteLine($"  Gray 50%: {gray50}");
    Console.WriteLine($"  Gray 25%: {gray25}");
    Console.WriteLine($"  Gray 75%: {gray75}");

    // Test common web colors
    Console.WriteLine("\nTesting common web colors:");
    HexColor orange = new HexColor("FFA500");
    HexColor purple = new HexColor("800080");
    HexColor brown = new HexColor("A52A2A");
    HexColor pink = new HexColor("FFC0CB");
    Console.WriteLine($"  Orange: {orange}");
    Console.WriteLine($"  Purple: {purple}");
    Console.WriteLine($"  Brown: {brown}");
    Console.WriteLine($"  Pink: {pink}");

    // Test color string parsing (case insensitive)
    Console.WriteLine("\nTesting case-insensitive parsing:");
    HexColor upperCase = new HexColor("FF00FF");
    HexColor lowerCase = new HexColor("ff00ff");
    Console.WriteLine($"  Uppercase 'FF00FF': {upperCase}");
    Console.WriteLine($"  Lowercase 'ff00ff': {lowerCase}");
    Console.WriteLine($"  Are equal: {upperCase.Equals(lowerCase)}");

    // Test bit manipulation correctness
    Console.WriteLine("\nTesting bit manipulation correctness:");
    HexColor testColor = new HexColor(0x12, 0x34, 0x56);
    UInt32 asUInt = testColor;
    Console.WriteLine($"  Original: R=0x{testColor.R:X2}, G=0x{testColor.G:X2}, B=0x{testColor.B:X2}");
    Console.WriteLine($"  As UInt32: 0x{asUInt:X6} (expected 0x123456)");
    if (asUInt != 0x123456)
    {
      Console.WriteLine("✗ Bit manipulation test FAILED");
      return false;
    }

    Console.WriteLine("\n✓ All color operation tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestHexRgbConversions()
  {
    Console.WriteLine("--- Testing HexRgb IConvertible Conversions ---");      // Test GetTypeCode
    Console.WriteLine("Testing GetTypeCode:");
    HexColor color = new HexColor(0xABCDEF);
    TypeCode typeCode = color.GetTypeCode();
    Console.WriteLine($"  GetTypeCode(): {typeCode}");
    if (typeCode != TypeCode.Object)
    {
      Console.WriteLine("✗ GetTypeCode test FAILED");
      return false;
    }

    // Test ToInt32
    Console.WriteLine("\nTesting ToInt32 (returns HexRgb value):");
    HexColor testColor = new HexColor(0x123456);
    int int32Value = testColor.ToInt32(null);
    Console.WriteLine($"  HexRgb(0x123456) ToInt32: 0x{int32Value:X6}");
    if (int32Value != 0x123456)
    {
      Console.WriteLine("✗ ToInt32 test FAILED");
      return false;
    }

    // Test ToInt64
    Console.WriteLine("\nTesting ToInt64 (returns HexRgb value):");
    long int64Value = testColor.ToInt64(null);
    Console.WriteLine($"  HexRgb(0x123456) ToInt64: 0x{int64Value:X6}");
    if (int64Value != 0x123456L)
    {
      Console.WriteLine("✗ ToInt64 test FAILED");
      return false;
    }

    // Test ToUInt32
    Console.WriteLine("\nTesting ToUInt32 (returns HexRgb value):");
    uint uint32Value = testColor.ToUInt32(null);
    Console.WriteLine($"  HexRgb(0x123456) ToUInt32: 0x{uint32Value:X6}");
    if (uint32Value != 0x123456U)
    {
      Console.WriteLine("✗ ToUInt32 test FAILED");
      return false;
    }

    // Test ToUInt64
    Console.WriteLine("\nTesting ToUInt64 (returns HexRgb value):");
    ulong uint64Value = testColor.ToUInt64(null);
    Console.WriteLine($"  HexRgb(0x123456) ToUInt64: 0x{uint64Value:X6}");
    if (uint64Value != 0x123456UL)
    {
      Console.WriteLine("✗ ToUInt64 test FAILED");
      return false;
    }

    // Test ToString(IFormatProvider)
    Console.WriteLine("\nTesting ToString(IFormatProvider):");
    HexColor HexRgbColor = new HexColor("FF00AA");
    string str = HexRgbColor.ToString(CultureInfo.InvariantCulture);
    Console.WriteLine($"  ToString result: '{str}'");
    if (str != "FF00AA")
    {
      Console.WriteLine("✗ ToString test FAILED");
      return false;
    }

    // Test ToType conversions
    Console.WriteLine("\nTesting ToType conversions:");

    // ToType(typeof(string))
    var asString = testColor.ToType(typeof(string), null);
    Console.WriteLine($"  ToType(typeof(string)): '{asString}'");
    if (asString as string != "123456")
    {
      Console.WriteLine("✗ ToType(string) test FAILED");
      return false;
    }

    // ToType(typeof(int))
    var asInt = testColor.ToType(typeof(int), null);
    Console.WriteLine($"  ToType(typeof(int)): 0x{asInt:X6}");
    if ((int)asInt != 0x123456)
    {
      Console.WriteLine("✗ ToType(int) test FAILED");
      return false;
    }

    // ToType(typeof(long))
    var asLong = testColor.ToType(typeof(long), null);
    Console.WriteLine($"  ToType(typeof(long)): 0x{asLong:X6}");
    if ((long)asLong != 0x123456L)
    {
      Console.WriteLine("✗ ToType(long) test FAILED");
      return false;
    }

    // ToType(typeof(uint))
    var asUInt = testColor.ToType(typeof(uint), null);
    Console.WriteLine($"  ToType(typeof(uint)): 0x{asUInt:X6}");
    if ((uint)asUInt != 0x123456U)
    {
      Console.WriteLine("✗ ToType(uint) test FAILED");
      return false;
    }

    // ToType(typeof(ulong))
    var asULong = testColor.ToType(typeof(ulong), null);
    Console.WriteLine($"  ToType(typeof(ulong)): 0x{asULong:X6}");
    if ((ulong)asULong != 0x123456UL)
    {
      Console.WriteLine("✗ ToType(ulong) test FAILED");
      return false;
    }

    // ToType(typeof(HexInt))
    var asHexInt = testColor.ToType(typeof(HexInt), null);
    Console.WriteLine($"  ToType(typeof(HexInt)): {asHexInt}");
    if (!(asHexInt is HexInt))
    {
      Console.WriteLine("✗ ToType(HexInt) test FAILED");
      return false;
    }

    // ToType(typeof(HexRgb))
    var asHexRgb = testColor.ToType(typeof(HexColor), null);
    Console.WriteLine($"  ToType(typeof(HexRgb)): {asHexRgb == (object)testColor}");
    if (!(asHexRgb is HexColor) || !((HexColor)asHexRgb).Equals(testColor))
    {
      Console.WriteLine("✗ ToType(HexRgb) test FAILED");
      return false;
    }

    Console.WriteLine("\n✓ All IConvertible conversion tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestHexRgbXmlSerialization()
  {
    Console.WriteLine("--- Testing HexRgb XML Serialization ---");      // Create test object
    var testData = CreateTestData();

    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(HexRgbTestData));
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
    HexRgbTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (HexRgbTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("✗ XML Serialization/Deserialization test FAILED - data mismatch");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(HexRgbTestData? deserializedData, HexRgbTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  PrimaryRed: {deserializedData.PrimaryRed}");
    if (!testData.PrimaryRed.Equals(deserializedData.PrimaryRed))
      return false;
    Console.WriteLine($"  PrimaryGreen: {deserializedData.PrimaryGreen}");
    if (!testData.PrimaryGreen.Equals(deserializedData.PrimaryGreen))
      return false;
    Console.WriteLine($"  PrimaryBlue: {deserializedData.PrimaryBlue}");
    if (!testData.PrimaryBlue.Equals(deserializedData.PrimaryBlue))
      return false;
    Console.WriteLine($"  SecondaryYellow: {deserializedData.SecondaryYellow}");
    if (!testData.SecondaryYellow.Equals(deserializedData.SecondaryYellow))
      return false;
    Console.WriteLine($"  Black: {deserializedData.Black}");
    if (!testData.Black.Equals(deserializedData.Black))
      return false;
    Console.WriteLine($"  White: {deserializedData.White}");
    if (!testData.White.Equals(deserializedData.White))
      return false;
    Console.WriteLine($"  Gray: {deserializedData.Gray}");
    if (!testData.Gray.Equals(deserializedData.Gray))
      return false;
    Console.WriteLine($"  CustomColor1: {deserializedData.CustomColor1}");
    if (!testData.CustomColor1.Equals(deserializedData.CustomColor1))
      return false;
    Console.WriteLine($"  CustomColor2: {deserializedData.CustomColor2}");
    if (!testData.CustomColor2.Equals(deserializedData.CustomColor2))
      return false;

    return true;
  }

  
  
  static bool TestHexRgbJsonSerialization()
  {
    Console.WriteLine("--- Testing HexRgb JSON Serialization ---");      // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<HexRgbTestData>(jsonString, jsonOptions);
    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  private static HexRgbTestData CreateTestData()
  {
    return new HexRgbTestData
    {
      PrimaryRed = new HexColor(255, 0, 0),
      PrimaryGreen = new HexColor(0, 255, 0),
      PrimaryBlue = new HexColor(0, 0, 255),
      SecondaryYellow = new HexColor(255, 255, 0),
      Black = new HexColor(0, 0, 0),
      White = new HexColor(255, 255, 255),
      Gray = new HexColor(128, 128, 128),
      CustomColor1 = new HexColor("A1B2C3"),
      CustomColor2 = new HexColor(0x456789)
    };
  }

  private static void ShowOriginalData(HexRgbTestData testData)
  {
    Console.WriteLine($"Original data:");

    Console.WriteLine($"  PrimaryRed: {testData.PrimaryRed}");
    Console.WriteLine($"  PrimaryGreen: {testData.PrimaryGreen}");
    Console.WriteLine($"  PrimaryBlue: {testData.PrimaryBlue}");
    Console.WriteLine($"  SecondaryYellow: {testData.SecondaryYellow}");
    Console.WriteLine($"  Black: {testData.Black}");
    Console.WriteLine($"  White: {testData.White}");
    Console.WriteLine($"  Gray: {testData.Gray}");
    Console.WriteLine($"  CustomColor1: {testData.CustomColor1}");
    Console.WriteLine($"  CustomColor2: {testData.CustomColor2}");
    Console.WriteLine();
  }

  
  static bool TestHexRgbEdgeCases()
  {
    Console.WriteLine("--- Testing HexRgb Edge Cases ---");

    //      // Test boundary values
    Console.WriteLine("Testing boundary values:");
    HexColor minColor = new HexColor(0, 0, 0);
    HexColor maxColor = new HexColor(255, 255, 255);
    Console.WriteLine($"  Min (Black): {minColor} (0x{((UInt32)minColor):X6})");
    Console.WriteLine($"  Max (White): {maxColor} (0x{((UInt32)maxColor):X6})");

    // Test individual component boundaries
    Console.WriteLine("\nTesting individual component boundaries:");
    HexColor maxRed = new HexColor(255, 0, 0);
    HexColor maxGreen = new HexColor(0, 255, 0);
    HexColor maxBlue = new HexColor(0, 0, 255);
    Console.WriteLine($"  Max Red: {maxRed}");
    Console.WriteLine($"  Max Green: {maxGreen}");
    Console.WriteLine($"  Max Blue: {maxBlue}");

    // Test HexInt conversions
    Console.WriteLine("\nTesting HexInt conversions:");
    HexColor color = new HexColor(0xABCDEF);
    HexInt hexColor = color;
    HexColor backToHexRgb = hexColor;
    Console.WriteLine($"  Original HexRgb: {color}");
    Console.WriteLine($"  As HexInt: {hexColor}");
    Console.WriteLine($"  Back to HexRgb: {backToHexRgb}");
    Console.WriteLine($"  Are equal: {color.Equals(backToHexRgb)}");

    // Test Deserialization from different formats
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // String format
    string jsonString = "{\"Value\":\"FF0000\"}";
    var fromString = JsonSerializer.Deserialize<HexRgbWrapper>(jsonString);
    Console.WriteLine($"  From JSON string \"FF0000\": {fromString?.Value}");

    // Numeric format
    string jsonNumeric = "{\"Value\":16711680}";
    var fromNumeric = JsonSerializer.Deserialize<HexRgbWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 16711680: {fromNumeric?.Value}");

    // Test component modification
    Console.WriteLine("\nTesting component modification:");
    HexColor mutable = new HexColor(100, 100, 100);
    Console.WriteLine($"  Original: {mutable} (R={mutable.R}, G={mutable.G}, B={mutable.B})");

    mutable.R = 200;
    Console.WriteLine($"  After R=200: {mutable} (R={mutable.R}, G={mutable.G}, B={mutable.B})");

    mutable.G = 150;
    Console.WriteLine($"  After G=150: {mutable} (R={mutable.R}, G={mutable.G}, B={mutable.B})");

    mutable.B = 50;
    Console.WriteLine($"  After B=50: {mutable} (R={mutable.R}, G={mutable.G}, B={mutable.B})");

    // Test 24-bit masking
    Console.WriteLine("\nTesting 24-bit masking:");
    HexColor masked = new HexColor(0xFFABCDEF);
    Console.WriteLine($"  Input: 0xFFABCDEF");
    Console.WriteLine($"  Masked HexRgb: {masked} (should be ABCDEF)");
    if (masked.ToString() != "ABCDEF")
    {
      Console.WriteLine("✗ 24-bit masking test FAILED");
      return false;
    }

    // Test equality and hash code
    Console.WriteLine("\nTesting equality and hash code:");
    HexColor color1 = new HexColor("123456");
    HexColor color2 = new HexColor(0x123456);
    HexColor color3 = new HexColor(0x12, 0x34, 0x56);
    Console.WriteLine($"  color1: {color1}");
    Console.WriteLine($"  color2: {color2}");
    Console.WriteLine($"  color3: {color3}");
    Console.WriteLine($"  color1 == color2: {color1.Equals(color2)}");
    Console.WriteLine($"  color2 == color3: {color2.Equals(color3)}");
    Console.WriteLine($"  color1 == color3: {color1.Equals(color3)}");
    Console.WriteLine($"  Hash codes: {color1.GetHashCode()}, {color2.GetHashCode()}, {color3.GetHashCode()}");

    if (!color1.Equals(color2) || !color2.Equals(color3) || !color1.Equals(color3))
    {
      Console.WriteLine("✗ Equality test FAILED");
      return false;
    }

    if (color1.GetHashCode() != color2.GetHashCode() || color2.GetHashCode() != color3.GetHashCode())
    {
      Console.WriteLine("✗ Hash code consistency test FAILED");
      return false;
    }

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestHexRgbPerformance()
  {
    Console.WriteLine("--- Testing HexRgb Performance ---"); const int iterations = 100000;

    // Test construction from string
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      HexColor color = new HexColor("FF0000");
    }
    sw.Stop();
    Console.WriteLine($"Construction from string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from UInt32
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      HexColor color = new HexColor(0xFF0000U);
    }
    sw.Stop();
    Console.WriteLine($"Construction from UInt32 x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from bytes
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      HexColor color = new HexColor(255, 0, 0);
    }
    sw.Stop();
    Console.WriteLine($"Construction from bytes x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    HexColor testColor = new HexColor(255, 128, 64);
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testColor.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test component access
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      byte r = testColor.R;
      byte g = testColor.G;
      byte b = testColor.B;
    }
    sw.Stop();
    Console.WriteLine($"Component access (R,G,B) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test component modification
    HexColor mutableColor = new HexColor(100, 100, 100);
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      mutableColor.R = (byte)(i % 256);
      mutableColor.G = (byte)((i * 2) % 256);
      mutableColor.B = (byte)((i * 3) % 256);
    }
    sw.Stop();
    Console.WriteLine($"Component modification (R,G,B) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new HexRgbTestData
    {
      PrimaryRed = new HexColor(255, 0, 0),
      PrimaryGreen = new HexColor(0, 255, 0),
      PrimaryBlue = new HexColor(0, 0, 255),
      SecondaryYellow = new HexColor(255, 255, 0),
      Black = new HexColor(0, 0, 0),
      White = new HexColor(255, 255, 255),
      Gray = new HexColor(128, 128, 128),
      CustomColor1 = new HexColor("A1B2C3"),
      CustomColor2 = new HexColor(0x456789)
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
      var obj = JsonSerializer.Deserialize<HexRgbTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test Equals performance
    HexColor color1 = new HexColor(128, 128, 128);
    HexColor color2 = new HexColor(128, 128, 128);
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      bool result = color1.Equals(color2);
    }
    sw.Stop();
    Console.WriteLine($"Equals() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test GetHashCode performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int hash = color1.GetHashCode();
    }
    sw.Stop();
    Console.WriteLine($"GetHashCode() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test implicit conversions performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      UInt32 value = color1;
    }
    sw.Stop();
    Console.WriteLine($"Implicit conversion to UInt32 x {iterations}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  }


/// <summary>
/// Test data class containing various HexRgb color properties.
/// </summary>
[XmlRoot("HexRgbTestData")]
public class HexRgbTestData
{
  [XmlElement("PrimaryRed")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public HexColor PrimaryRed { get; set; }

  [XmlElement("PrimaryGreen")]
  public HexColor PrimaryGreen { get; set; }

  [XmlElement("PrimaryBlue")]
  public HexColor PrimaryBlue { get; set; }

  [XmlElement("SecondaryYellow")]
  public HexColor SecondaryYellow { get; set; }

  [XmlElement("Black")]
  public HexColor Black { get; set; }

  [XmlElement("White")]
  public HexColor White { get; set; }

  [XmlElement("Gray")]
  public HexColor Gray { get; set; }

  [XmlElement("CustomColor1")]
  public HexColor CustomColor1 { get; set; }

  [XmlElement("CustomColor2")]
  public HexColor CustomColor2 { get; set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class HexRgbWrapper
{
  public HexColor Value { get; set; }
}

