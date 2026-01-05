using System.Globalization;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for RGB type serialization in both XML and JSON formats.
/// </summary>
public static class RGBSerializationTests
{
  /// <summary>
  /// Runs all RGB serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== RGB Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestRGBBasicOperations()) return false;
    if (!TestRGBColorOperations()) return false;
    if (!TestRGBXmlSerialization()) return false;
    if (!TestRGBJsonSerialization()) return false;
    if (!TestRGBEdgeCases()) return false;
    if (!TestRGBPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestRGBBasicOperations()
  {
    Console.WriteLine("--- Testing RGB Basic Operations ---");

    try
    {
      // Test string to RGB conversion
      RGB color1 = new RGB("FF0000");
      Console.WriteLine($"✓ String to RGB: {color1} = Red({color1.R}), Green({color1.G}), Blue({color1.B})");

      // Test UInt32 to RGB conversion
      RGB color2 = new RGB(0xFF0000U);
      Console.WriteLine($"✓ UInt32 to RGB: {color2}");

      // Test byte components constructor
      RGB color3 = new RGB(255, 0, 0);
      Console.WriteLine($"✓ Byte components to RGB: {color3}");

      // Test equality
      if (color1.Equals(color2) && color2.Equals(color3))
        Console.WriteLine("✓ Equality test passed (all three reds are equal)");
      else
        Console.WriteLine("✗ Equality test FAILED");

      // Test RGB to string
      string str = color1.ToString();
      Console.WriteLine($"✓ RGB to string: {str}");

      // Test component access
      Console.WriteLine($"✓ Component access: R={color1.R}, G={color1.G}, B={color1.B}");

      // Test component modification
      RGB mutableColor = new RGB(100, 150, 200);
      Console.WriteLine($"✓ Original color: {mutableColor}");
      mutableColor.R = 255;
      Console.WriteLine($"✓ After setting R=255: {mutableColor}");
      mutableColor.G = 128;
      Console.WriteLine($"✓ After setting G=128: {mutableColor}");
      mutableColor.B = 64;
      Console.WriteLine($"✓ After setting B=64: {mutableColor}");

      // Test hash code
      Console.WriteLine($"✓ Hash code: {color1.GetHashCode()}");

      // Test implicit conversions
      UInt32 uintVal = color1;
      Int32 intVal = color1;
      Console.WriteLine($"✓ Implicit conversions: UInt32={uintVal:X6}, Int32={intVal:X6}");

      RGB fromUInt = uintVal;
      RGB fromInt = intVal;
      Console.WriteLine($"✓ Back to RGB: fromUInt={fromUInt}, fromInt={fromInt}");

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

  #region Color Operations Tests

  static bool TestRGBColorOperations()
  {
    Console.WriteLine("--- Testing RGB Color Operations ---");

    try
    {
      // Test primary colors
      Console.WriteLine("Testing primary colors:");
      RGB red = new RGB(255, 0, 0);
      RGB green = new RGB(0, 255, 0);
      RGB blue = new RGB(0, 0, 255);
      Console.WriteLine($"  Red: {red} (R={red.R}, G={red.G}, B={red.B})");
      Console.WriteLine($"  Green: {green} (R={green.R}, G={green.G}, B={green.B})");
      Console.WriteLine($"  Blue: {blue} (R={blue.R}, G={blue.G}, B={blue.B})");

      // Test secondary colors
      Console.WriteLine("\nTesting secondary colors:");
      RGB yellow = new RGB(255, 255, 0);
      RGB cyan = new RGB(0, 255, 255);
      RGB magenta = new RGB(255, 0, 255);
      Console.WriteLine($"  Yellow: {yellow} (R={yellow.R}, G={yellow.G}, B={yellow.B})");
      Console.WriteLine($"  Cyan: {cyan} (R={cyan.R}, G={cyan.G}, B={cyan.B})");
      Console.WriteLine($"  Magenta: {magenta} (R={magenta.R}, G={magenta.G}, B={magenta.B})");

      // Test grayscale colors
      Console.WriteLine("\nTesting grayscale colors:");
      RGB black = new RGB(0, 0, 0);
      RGB white = new RGB(255, 255, 255);
      RGB gray50 = new RGB(128, 128, 128);
      RGB gray25 = new RGB(64, 64, 64);
      RGB gray75 = new RGB(192, 192, 192);
      Console.WriteLine($"  Black: {black}");
      Console.WriteLine($"  White: {white}");
      Console.WriteLine($"  Gray 50%: {gray50}");
      Console.WriteLine($"  Gray 25%: {gray25}");
      Console.WriteLine($"  Gray 75%: {gray75}");

      // Test common web colors
      Console.WriteLine("\nTesting common web colors:");
      RGB orange = new RGB("FFA500");
      RGB purple = new RGB("800080");
      RGB brown = new RGB("A52A2A");
      RGB pink = new RGB("FFC0CB");
      Console.WriteLine($"  Orange: {orange}");
      Console.WriteLine($"  Purple: {purple}");
      Console.WriteLine($"  Brown: {brown}");
      Console.WriteLine($"  Pink: {pink}");

      // Test color string parsing (case insensitive)
      Console.WriteLine("\nTesting case-insensitive parsing:");
      RGB upperCase = new RGB("FF00FF");
      RGB lowerCase = new RGB("ff00ff");
      Console.WriteLine($"  Uppercase 'FF00FF': {upperCase}");
      Console.WriteLine($"  Lowercase 'ff00ff': {lowerCase}");
      Console.WriteLine($"  Are equal: {upperCase.Equals(lowerCase)}");

      // Test bit manipulation correctness
      Console.WriteLine("\nTesting bit manipulation correctness:");
      RGB testColor = new RGB(0x12, 0x34, 0x56);
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
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Color operation test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region XML Serialization Tests

  static bool TestRGBXmlSerialization()
  {
    Console.WriteLine("--- Testing RGB XML Serialization ---");

    try
    {
      // Create test object
      var testData = new RGBTestData
      {
        Id = 1,
        Name = "XML Color Test",
        PrimaryRed = new RGB(255, 0, 0),
        PrimaryGreen = new RGB(0, 255, 0),
        PrimaryBlue = new RGB(0, 0, 255),
        SecondaryYellow = new RGB(255, 255, 0),
        Black = new RGB(0, 0, 0),
        White = new RGB(255, 255, 255),
        Gray = new RGB(128, 128, 128),
        CustomColor1 = new RGB("A1B2C3"),
        CustomColor2 = new RGB(0x456789)
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
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

      // Serialize to XML
      var xmlSerializer = new XmlSerializer(typeof(RGBTestData));
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
      RGBTestData? deserializedData;
      using (var stringReader = new StringReader(xmlString))
      {
        deserializedData = (RGBTestData?)xmlSerializer.Deserialize(stringReader);
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
      Console.WriteLine($"  PrimaryRed: {deserializedData.PrimaryRed}");
      Console.WriteLine($"  PrimaryGreen: {deserializedData.PrimaryGreen}");
      Console.WriteLine($"  PrimaryBlue: {deserializedData.PrimaryBlue}");
      Console.WriteLine($"  SecondaryYellow: {deserializedData.SecondaryYellow}");
      Console.WriteLine($"  Black: {deserializedData.Black}");
      Console.WriteLine($"  White: {deserializedData.White}");
      Console.WriteLine($"  Gray: {deserializedData.Gray}");
      Console.WriteLine($"  CustomColor1: {deserializedData.CustomColor1}");
      Console.WriteLine($"  CustomColor2: {deserializedData.CustomColor2}");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name &&
        testData.PrimaryRed.Equals(deserializedData.PrimaryRed) &&
        testData.PrimaryGreen.Equals(deserializedData.PrimaryGreen) &&
        testData.PrimaryBlue.Equals(deserializedData.PrimaryBlue) &&
        testData.SecondaryYellow.Equals(deserializedData.SecondaryYellow) &&
        testData.Black.Equals(deserializedData.Black) &&
        testData.White.Equals(deserializedData.White) &&
        testData.Gray.Equals(deserializedData.Gray) &&
        testData.CustomColor1.Equals(deserializedData.CustomColor1) &&
        testData.CustomColor2.Equals(deserializedData.CustomColor2);

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

  static bool TestRGBJsonSerialization()
  {
    Console.WriteLine("--- Testing RGB JSON Serialization ---");

    try
    {
      // Create test object
      var testData = new RGBTestData
      {
        Id = 2,
        Name = "JSON Color Test",
        PrimaryRed = new RGB(255, 0, 0),
        PrimaryGreen = new RGB(0, 255, 0),
        PrimaryBlue = new RGB(0, 0, 255),
        SecondaryYellow = new RGB(255, 255, 0),
        Black = new RGB(0, 0, 0),
        White = new RGB(255, 255, 255),
        Gray = new RGB(128, 128, 128),
        CustomColor1 = new RGB("FF8800"),
        CustomColor2 = new RGB(0x00CC99)
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
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
      var deserializedData = JsonSerializer.Deserialize<RGBTestData>(jsonString, jsonOptions);

      if (deserializedData == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  PrimaryRed: {deserializedData.PrimaryRed}");
      Console.WriteLine($"  PrimaryGreen: {deserializedData.PrimaryGreen}");
      Console.WriteLine($"  PrimaryBlue: {deserializedData.PrimaryBlue}");
      Console.WriteLine($"  SecondaryYellow: {deserializedData.SecondaryYellow}");
      Console.WriteLine($"  Black: {deserializedData.Black}");
      Console.WriteLine($"  White: {deserializedData.White}");
      Console.WriteLine($"  Gray: {deserializedData.Gray}");
      Console.WriteLine($"  CustomColor1: {deserializedData.CustomColor1}");
      Console.WriteLine($"  CustomColor2: {deserializedData.CustomColor2}");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name &&
        testData.PrimaryRed.Equals(deserializedData.PrimaryRed) &&
        testData.PrimaryGreen.Equals(deserializedData.PrimaryGreen) &&
        testData.PrimaryBlue.Equals(deserializedData.PrimaryBlue) &&
        testData.SecondaryYellow.Equals(deserializedData.SecondaryYellow) &&
        testData.Black.Equals(deserializedData.Black) &&
        testData.White.Equals(deserializedData.White) &&
        testData.Gray.Equals(deserializedData.Gray) &&
        testData.CustomColor1.Equals(deserializedData.CustomColor1) &&
        testData.CustomColor2.Equals(deserializedData.CustomColor2);

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

  static bool TestRGBEdgeCases()
  {
    Console.WriteLine("--- Testing RGB Edge Cases ---");

    //try
    {
      // Test boundary values
      Console.WriteLine("Testing boundary values:");
      RGB minColor = new RGB(0, 0, 0);
      RGB maxColor = new RGB(255, 255, 255);
      Console.WriteLine($"  Min (Black): {minColor} (0x{((UInt32)minColor):X6})");
      Console.WriteLine($"  Max (White): {maxColor} (0x{((UInt32)maxColor):X6})");

      // Test individual component boundaries
      Console.WriteLine("\nTesting individual component boundaries:");
      RGB maxRed = new RGB(255, 0, 0);
      RGB maxGreen = new RGB(0, 255, 0);
      RGB maxBlue = new RGB(0, 0, 255);
      Console.WriteLine($"  Max Red: {maxRed}");
      Console.WriteLine($"  Max Green: {maxGreen}");
      Console.WriteLine($"  Max Blue: {maxBlue}");

      // Test HexInt conversions
      Console.WriteLine("\nTesting HexInt conversions:");
      RGB color = new RGB(0xABCDEF);
      HexInt hexColor = color;
      RGB backToRgb = hexColor;
      Console.WriteLine($"  Original RGB: {color}");
      Console.WriteLine($"  As HexInt: {hexColor}");
      Console.WriteLine($"  Back to RGB: {backToRgb}");
      Console.WriteLine($"  Are equal: {color.Equals(backToRgb)}");

      // Test JSON deserialization from different formats
      Console.WriteLine("\nTesting JSON deserialization from different formats:");

      // String format
      string jsonString = "{\"Value\":\"FF0000\"}";
      var fromString = JsonSerializer.Deserialize<RGBWrapper>(jsonString);
      Console.WriteLine($"  From JSON string \"FF0000\": {fromString?.Value}");

      // Numeric format
      string jsonNumeric = "{\"Value\":16711680}";
      var fromNumeric = JsonSerializer.Deserialize<RGBWrapper>(jsonNumeric);
      Console.WriteLine($"  From JSON number 16711680: {fromNumeric?.Value}");

      // Test component modification
      Console.WriteLine("\nTesting component modification:");
      RGB mutable = new RGB(100, 100, 100);
      Console.WriteLine($"  Original: {mutable} (R={mutable.R}, G={mutable.G}, B={mutable.B})");
      
      mutable.R = 200;
      Console.WriteLine($"  After R=200: {mutable} (R={mutable.R}, G={mutable.G}, B={mutable.B})");
      
      mutable.G = 150;
      Console.WriteLine($"  After G=150: {mutable} (R={mutable.R}, G={mutable.G}, B={mutable.B})");
      
      mutable.B = 50;
      Console.WriteLine($"  After B=50: {mutable} (R={mutable.R}, G={mutable.G}, B={mutable.B})");

      // Test 24-bit masking
      Console.WriteLine("\nTesting 24-bit masking:");
      RGB masked = new RGB(0xFFABCDEF);
      Console.WriteLine($"  Input: 0xFFABCDEF");
      Console.WriteLine($"  Masked RGB: {masked} (should be ABCDEF)");
      if (masked.ToString() != "ABCDEF")
      {
        Console.WriteLine("✗ 24-bit masking test FAILED");
        return false;
      }

      // Test equality and hash code
      Console.WriteLine("\nTesting equality and hash code:");
      RGB color1 = new RGB("123456");
      RGB color2 = new RGB(0x123456);
      RGB color3 = new RGB(0x12, 0x34, 0x56);
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
    //catch (Exception ex)
    //{
    //  Console.WriteLine($"✗ Edge case test FAILED: {ex.Message}");
    //  Console.WriteLine($"  Stack trace: {ex.StackTrace}");
    //  Console.WriteLine();
    //  return false;
    //}
  }

  #endregion

  #region Performance Tests

  static bool TestRGBPerformance()
  {
    Console.WriteLine("--- Testing RGB Performance ---");

    try
    {
      const int iterations = 100000;

      // Test construction from string
      var sw = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 0; i < iterations; i++)
      {
        RGB color = new RGB("FF0000");
      }
      sw.Stop();
      Console.WriteLine($"Construction from string x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test construction from UInt32
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        RGB color = new RGB(0xFF0000U);
      }
      sw.Stop();
      Console.WriteLine($"Construction from UInt32 x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test construction from bytes
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        RGB color = new RGB(255, 0, 0);
      }
      sw.Stop();
      Console.WriteLine($"Construction from bytes x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test ToString performance
      RGB testColor = new RGB(255, 128, 64);
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
      RGB mutableColor = new RGB(100, 100, 100);
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
      var testObj = new RGBTestData
      {
        Id = 1,
        Name = "Perf Test",
        PrimaryRed = new RGB(255, 0, 0),
        PrimaryGreen = new RGB(0, 255, 0),
        PrimaryBlue = new RGB(0, 0, 255),
        SecondaryYellow = new RGB(255, 255, 0),
        Black = new RGB(0, 0, 0),
        White = new RGB(255, 255, 255),
        Gray = new RGB(128, 128, 128),
        CustomColor1 = new RGB("A1B2C3"),
        CustomColor2 = new RGB(0x456789)
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
        var obj = JsonSerializer.Deserialize<RGBTestData>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"JSON Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

      // Test Equals performance
      RGB color1 = new RGB(128, 128, 128);
      RGB color2 = new RGB(128, 128, 128);
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
/// Test data class containing various RGB color properties.
/// </summary>
[XmlRoot("RGBTestData")]
public class RGBTestData
{
  [XmlElement("Id")]
  public int Id { get; set; }

  [XmlElement("Name")]
  public string Name { get; set; } = string.Empty;

  [XmlElement("PrimaryRed")]
  public RGB PrimaryRed { get; set; }

  [XmlElement("PrimaryGreen")]
  public RGB PrimaryGreen { get; set; }

  [XmlElement("PrimaryBlue")]
  public RGB PrimaryBlue { get; set; }

  [XmlElement("SecondaryYellow")]
  public RGB SecondaryYellow { get; set; }

  [XmlElement("Black")]
  public RGB Black { get; set; }

  [XmlElement("White")]
  public RGB White { get; set; }

  [XmlElement("Gray")]
  public RGB Gray { get; set; }

  [XmlElement("CustomColor1")]
  public RGB CustomColor1 { get; set; }

  [XmlElement("CustomColor2")]
  public RGB CustomColor2 { get; set; }
}

/// <summary>
/// Simple wrapper class for testing JSON deserialization scenarios.
/// </summary>
public class RGBWrapper
{
  public RGB Value { get; set; }
}

#endregion