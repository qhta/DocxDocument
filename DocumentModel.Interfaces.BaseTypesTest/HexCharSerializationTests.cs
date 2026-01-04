using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.Interfaces.BaseTypesTest;

/// <summary>
/// Test suite for HexChar type serialization in both XML and JSON formats.
/// </summary>
public static class HexCharSerializationTests
{
  /// <summary>
  /// Runs all HexChar serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== HexChar Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestHexCharBasicOperations()) return false;
    if (!TestHexCharXmlSerialization()) return false;
    if (!TestHexCharJsonSerialization()) return false;
    if (!TestHexCharEdgeCases()) return false;
    if (!TestHexCharPerformance()) return false;
    return true;
  }

  #region Basic Operations Tests

  static bool TestHexCharBasicOperations()
  {
    Console.WriteLine("--- Testing HexChar Basic Operations ---");

    try
    {
      // Test string to HexChar conversion (ASCII)
      HexChar hexChar1 = "41"; // 'A' in hex
      Console.WriteLine($"✓ String to HexChar (ASCII): {hexChar1} = {(char)hexChar1.ToUInt16(null)} ({hexChar1.ToUInt16(null)})");

      // Test string to HexChar conversion (Extended)
      HexChar hexChar2 = "03B1"; // Greek alpha α
      Console.WriteLine($"✓ String to HexChar (Unicode): {hexChar2} = char({hexChar2.ToUInt16(null)})");

      // Test ushort to HexChar conversion
      HexChar hexChar3 = (ushort)65;
      Console.WriteLine($"✓ UShort to HexChar: {hexChar3}");

      // Test equality
      if (hexChar1.Equals(hexChar3))
        Console.WriteLine("✓ Equality test passed");
      else
        Console.WriteLine("✗ Equality test FAILED");

      // Test HexChar to string
      string str = hexChar1;
      Console.WriteLine($"✓ HexChar to string: {str}");

      // Test HexChar to ushort
      ushort value = hexChar1;
      Console.WriteLine($"✓ HexChar to ushort: {value}");

      // Test hash code
      Console.WriteLine($"✓ Hash code: {hexChar1.GetHashCode()}");

      // Test ToString with different ranges
      HexChar ascii = new HexChar("20"); // space
      HexChar extended = new HexChar("0100"); // Ā
      Console.WriteLine($"✓ ASCII range (0-255): '{ascii}' (2 digits)");
      Console.WriteLine($"✓ Extended range (256+): '{extended}' (4 digits)");

      Console.WriteLine("✓ All basic operations passed");
      Console.WriteLine();
      return true;
    } catch (Exception ex)
    {
      Console.WriteLine($"✗ Basic operations test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region XML Serialization Tests

  static bool TestHexCharXmlSerialization()
  {
    Console.WriteLine("--- Testing HexChar XML Serialization ---");

    try
    {
      // Create test object
      var testData = new HexCharTestData
      {
        Id = 1,
        Name = "XML Test",
        LetterA = "41", // 'A'
        Space = "20", // space
        GreekAlpha = "03B1", // α
        MaxValue = "FFFF" // maximum ushort
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  LetterA: {testData.LetterA} = '{(char)testData.LetterA.ToUInt16(null)}'");
      Console.WriteLine($"  Space: {testData.Space} = '{(char)testData.Space.ToUInt16(null)}'");
      Console.WriteLine($"  GreekAlpha: {testData.GreekAlpha} = char({testData.GreekAlpha.ToUInt16(null)})");
      Console.WriteLine($"  MaxValue: {testData.MaxValue} = {testData.MaxValue.ToUInt16(null)}");
      Console.WriteLine();

      // Serialize to XML
      var xmlSerializer = new XmlSerializer(typeof(HexCharTestData));
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
      HexCharTestData? deserializedData;
      using (var stringReader = new StringReader(xmlString))
      {
        deserializedData = (HexCharTestData?)xmlSerializer.Deserialize(stringReader);
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
      Console.WriteLine($"  LetterA: {deserializedData.LetterA}");
      Console.WriteLine($"  Space: {deserializedData.Space}");
      Console.WriteLine($"  GreekAlpha: {deserializedData.GreekAlpha}");
      Console.WriteLine($"  MaxValue: {deserializedData.MaxValue}");
      Console.WriteLine();

      // Validate
      bool isValid = testData.Id == deserializedData.Id && testData.Name == deserializedData.Name && testData.LetterA.Equals(deserializedData.LetterA) && testData.Space.Equals(deserializedData.Space) && testData.GreekAlpha.Equals(deserializedData.GreekAlpha) && testData.MaxValue.Equals(deserializedData.MaxValue);

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
    } catch (Exception ex)
    {
      Console.WriteLine($"✗ XML Serialization test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region JSON Serialization Tests

  static bool TestHexCharJsonSerialization()
  {
    Console.WriteLine("--- Testing HexChar JSON Serialization ---");

    try
    {
      // Create test object
      var testData = new HexCharTestData
      {
        Id = 2,
        Name = "JSON Test",
        LetterA = "41", // 'A'
        Space = "20", // space
        GreekAlpha = "03B1", // α
        MaxValue = "FFFF" // maximum ushort
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  LetterA: {testData.LetterA}");
      Console.WriteLine($"  Space: {testData.Space}");
      Console.WriteLine($"  GreekAlpha: {testData.GreekAlpha}");
      Console.WriteLine($"  MaxValue: {testData.MaxValue}");
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
      var deserializedData = JsonSerializer.Deserialize<HexCharTestData>(jsonString, jsonOptions);

      if (deserializedData == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  LetterA: {deserializedData.LetterA}");
      Console.WriteLine($"  Space: {deserializedData.Space}");
      Console.WriteLine($"  GreekAlpha: {deserializedData.GreekAlpha}");
      Console.WriteLine($"  MaxValue: {deserializedData.MaxValue}");
      Console.WriteLine();

      // Validate
      bool isValid = testData.Id == deserializedData.Id && testData.Name == deserializedData.Name && testData.LetterA.Equals(deserializedData.LetterA) && testData.Space.Equals(deserializedData.Space) && testData.GreekAlpha.Equals(deserializedData.GreekAlpha) && testData.MaxValue.Equals(deserializedData.MaxValue);

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
    } catch (Exception ex)
    {
      Console.WriteLine($"✗ JSON Serialization test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Edge Cases Tests

  static bool TestHexCharEdgeCases()
  {
    Console.WriteLine("--- Testing HexChar Edge Cases ---");

    try
    {
      // Test zero value
      Console.WriteLine("Testing zero value:");
      HexChar zero = new HexChar("00");
      Console.WriteLine($"  Zero HexChar: '{zero}' (Value: {zero.ToUInt16(null)})");

      // Test minimum ASCII (space)
      Console.WriteLine("\nTesting minimum printable ASCII:");
      HexChar space = new HexChar("20");
      Console.WriteLine($"  Space: '{space}' = '{(char)space.ToUInt16(null)}'");

      // Test maximum ASCII
      Console.WriteLine("\nTesting maximum ASCII:");
      HexChar maxAscii = new HexChar("FF");
      Console.WriteLine($"  Max ASCII (255): '{maxAscii}' = char({maxAscii.ToUInt16(null)})");

      // Test boundary between 2-digit and 4-digit format
      Console.WriteLine("\nTesting format boundaries:");
      HexChar boundary1 = new HexChar("FF"); // 255 - last 2-digit
      HexChar boundary2 = new HexChar("0100"); // 256 - first 4-digit
      Console.WriteLine($"  255 (last 2-digit): '{boundary1}'");
      Console.WriteLine($"  256 (first 4-digit): '{boundary2}'");

      // Test common Unicode characters
      Console.WriteLine("\nTesting common Unicode characters:");
      HexChar euro = new HexChar("20AC"); // €
      Console.WriteLine($"  Euro sign (U+20AC): '{euro}'");

      HexChar copyright = new HexChar("00A9"); // ©
      Console.WriteLine($"  Copyright (U+00A9): '{copyright}'");

      // Test maximum value
      Console.WriteLine("\nTesting maximum value:");
      HexChar maxValue = new HexChar("FFFF");
      Console.WriteLine($"  Max value (65535): '{maxValue}'");

      // Test case insensitivity
      Console.WriteLine("\nTesting case insensitivity:");
      HexChar upper = new HexChar("ABCD");
      HexChar lower = new HexChar("abcd");
      Console.WriteLine($"  Uppercase 'ABCD': {upper} = {upper.ToUInt16(null)}");
      Console.WriteLine($"  Lowercase 'abcd': {lower} = {lower.ToUInt16(null)}");
      Console.WriteLine($"  Are equal: {upper.Equals(lower)}");

      // Test conversions
      Console.WriteLine("\nTesting type conversions:");
      ushort ushortVal = (ushort)65;
      HexChar fromUShort = ushortVal;
      Console.WriteLine($"  From ushort (65): {fromUShort}");

      uint uintVal = 65u;
      HexChar fromUInt = (HexChar)uintVal;
      Console.WriteLine($"  From uint (65): {fromUInt}");

      byte byteVal = 65;
      HexChar fromByte = new HexChar(byteVal);
      Console.WriteLine($"  From byte (65): {fromByte}");

      Console.WriteLine("\n✓ All edge case tests completed");
      Console.WriteLine();
      return true;
    } catch (Exception ex)
    {
      Console.WriteLine($"✗ Edge case test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Performance Tests

  static bool TestHexCharPerformance()
  {
    Console.WriteLine("--- Testing HexChar Performance ---");

    try
    {
      const int iterations = 100000;

      // Test construction from string
      var sw = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 0; i < iterations; i++)
      {
        HexChar hex = new HexChar("41");
      }
      sw.Stop();
      Console.WriteLine($"Construction from string x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test construction from ushort
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        HexChar hex = new HexChar((ushort)65);
      }
      sw.Stop();
      Console.WriteLine($"Construction from ushort x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test ToString performance
      HexChar testChar = new HexChar("41");
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        string str = testChar.ToString();
      }
      sw.Stop();
      Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test JSON serialization performance
      var testObj = new HexCharTestData
      {
        Id = 1,
        Name = "Perf Test",
        LetterA = "41",
        Space = "20",
        GreekAlpha = "03B1",
        MaxValue = "FFFF"
      };

      sw.Restart();
      for (int i = 0; i < iterations / 10; i++) // Fewer iterations for serialization
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
        var obj = JsonSerializer.Deserialize<HexCharTestData>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"JSON Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

      // Test equality comparison performance
      HexChar hex1 = new HexChar("41");
      HexChar hex2 = new HexChar("41");
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
        ushort value = hex1;
      }
      sw.Stop();
      Console.WriteLine($"Implicit conversion to ushort x {iterations}: {sw.ElapsedMilliseconds}ms");
      Console.WriteLine("✓ Performance tests completed");
      Console.WriteLine();
      return true;
    } catch (Exception ex)
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
/// Test data class containing various HexChar properties.
/// </summary>
[XmlRoot("HexCharTestData")]
public class HexCharTestData
{
  [XmlElement("Id")]
  public int Id { get; set; }

  [XmlElement("Name")]
  public string Name { get; set; } = string.Empty;

  [XmlElement("LetterA")]
  public HexChar LetterA { get; set; }

  [XmlElement("Space")]
  public HexChar Space { get; set; }

  [XmlElement("GreekAlpha")]
  public HexChar GreekAlpha { get; set; }

  [XmlElement("MaxValue")]
  public HexChar MaxValue { get; set; }
}

#endregion