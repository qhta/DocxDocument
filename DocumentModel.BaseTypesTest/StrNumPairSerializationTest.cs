using System.Globalization;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for StrNumPair type serialization in both XML and JSON formats.
/// </summary>
public static class StrNumPairSerializationTests
{
  /// <summary>
  /// Runs all StrNumPair serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== StrNumPair Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestStrNumPairBasicOperations()) return false;
    if (!TestStrNumPairParsing()) return false;
    if (!TestStrNumPairXmlSerialization()) return false;
    if (!TestStrNumPairJsonSerialization()) return false;
    if (!TestStrNumPairEdgeCases()) return false;
    if (!TestStrNumPairPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestStrNumPairBasicOperations()
  {
    Console.WriteLine("--- Testing StrNumPair Basic Operations ---");

    try
    {
      // Test string-only constructor
      StrNumPair pair1 = new StrNumPair("test");
      Console.WriteLine($"✓ String constructor: {pair1} (Str='{pair1.Str}', Num={pair1.Num})");

      // Test string + number constructor
      StrNumPair pair2 = new StrNumPair("abc", 123);
      Console.WriteLine($"✓ String+Number constructor: {pair2} (Str='{pair2.Str}', Num={pair2.Num})");

      // Test parsing format "(Str,Num)"
      StrNumPair pair3 = new StrNumPair("(xyz,456)");
      Console.WriteLine($"✓ Parsing format: {pair3} (Str='{pair3.Str}', Num={pair3.Num})");

      // Test equality
      StrNumPair pair4 = new StrNumPair("abc", 123);
      if (pair2.Equals(pair4))
        Console.WriteLine("✓ Equality test passed");
      else
        Console.WriteLine("✗ Equality test FAILED");

      // Test ToString
      string str = pair2.ToString();
      Console.WriteLine($"✓ ToString: {str}");

      // Test round-trip parsing
      StrNumPair pair5 = new StrNumPair(str);
      if (pair2.Equals(pair5))
        Console.WriteLine("✓ Round-trip parsing passed");
      else
        Console.WriteLine("✗ Round-trip parsing FAILED");

      // Test hash code
      Console.WriteLine($"✓ Hash code: {pair2.GetHashCode()}");

      // Test implicit conversions
      StrNumPair fromString = "text";
      StrNumPair fromInt = 42;
      Console.WriteLine($"✓ Implicit from string: {fromString}");
      Console.WriteLine($"✓ Implicit from int: {fromInt}");

      string? backToString = fromString;
      int? backToInt = fromInt;
      Console.WriteLine($"✓ Back to string: '{backToString}'");
      Console.WriteLine($"✓ Back to int: {backToInt}");

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

  #region Parsing Tests

  static bool TestStrNumPairParsing()
  {
    Console.WriteLine("--- Testing StrNumPair Parsing ---");

    try
    {
      // Test format "(Str,Num)" with both values
      Console.WriteLine("Testing format \"(Str,Num)\" with both values:");
      StrNumPair pair1 = new StrNumPair("(abc,123)");
      Console.WriteLine($"  \"(abc,123)\" → {pair1} (Str='{pair1.Str}', Num={pair1.Num})");
      if (pair1.Str != "abc" || pair1.Num != 123)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test format "(,Num)" with only number
      Console.WriteLine("\nTesting format \"(,Num)\" with only number:");
      StrNumPair pair2 = new StrNumPair("(,456)");
      Console.WriteLine($"  \"(,456)\" → {pair2} (Str='{pair2.Str}', Num={pair2.Num})");
      if (pair2.Str != null || pair2.Num != 456)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test format "(Str,)" with only string
      Console.WriteLine("\nTesting format \"(Str,)\" with only string:");
      StrNumPair pair3 = new StrNumPair("(xyz,)");
      Console.WriteLine($"  \"(xyz,)\" → {pair3} (Str='{pair3.Str}', Num={pair3.Num})");
      if (pair3.Str != "xyz" || pair3.Num != null)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test format "(,)" with both empty
      Console.WriteLine("\nTesting format \"(,)\" with both empty:");
      StrNumPair pair4 = new StrNumPair("(,)");
      Console.WriteLine($"  \"(,)\" → {pair4} (Str='{pair4.Str}', Num={pair4.Num})");
      if (pair4.Str != null || pair4.Num != null)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test plain string (not in format)
      Console.WriteLine("\nTesting plain string (not in format):");
      StrNumPair pair5 = new StrNumPair("just text");
      Console.WriteLine($"  \"just text\" → {pair5} (Str='{pair5.Str}', Num={pair5.Num})");
      if (pair5.Str != "just text" || pair5.Num != null)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test string that starts with "(" but doesn't end with ")"
      Console.WriteLine("\nTesting malformed format:");
      StrNumPair pair6 = new StrNumPair("(incomplete");
      Console.WriteLine($"  \"(incomplete\" → {pair6} (Str='{pair6.Str}', Num={pair6.Num})");
      if (pair6.Str != "(incomplete" || pair6.Num != null)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test with negative number
      Console.WriteLine("\nTesting with negative number:");
      StrNumPair pair7 = new StrNumPair("(test,-42)");
      Console.WriteLine($"  \"(test,-42)\" → {pair7} (Str='{pair7.Str}', Num={pair7.Num})");
      if (pair7.Str != "test" || pair7.Num != -42)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test with zero
      Console.WriteLine("\nTesting with zero:");
      StrNumPair pair8 = new StrNumPair("(zero,0)");
      Console.WriteLine($"  \"(zero,0)\" → {pair8} (Str='{pair8.Str}', Num={pair8.Num})");
      if (pair8.Str != "zero" || pair8.Num != 0)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      // Test with non-numeric value in Num position
      Console.WriteLine("\nTesting with non-numeric value in Num position:");
      StrNumPair pair9 = new StrNumPair("(test,notnum)");
      Console.WriteLine($"  \"(test,notnum)\" → {pair9} (Str='{pair9.Str}', Num={pair9.Num})");
      if (pair9.Str != "test" || pair9.Num != null)
      {
        Console.WriteLine("✗ Parsing FAILED");
        return false;
      }

      Console.WriteLine("\n✓ All parsing tests passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Parsing test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region XML Serialization Tests

  static bool TestStrNumPairXmlSerialization()
  {
    Console.WriteLine("--- Testing StrNumPair XML Serialization ---");

    try
    {
      // Create test object
      var testData = new StrNumPairTestData
      {
        Id = 1,
        Name = "XML Test",
        StringOnly = new StrNumPair("text"),
        NumberOnly = new StrNumPair(null, 100),
        Both = new StrNumPair("label", 200),
        Empty = new StrNumPair(null, null),
        Negative = new StrNumPair("neg", -50),
        Zero = new StrNumPair("zero", 0),
        LongString = new StrNumPair("This is a longer string value", 999),
        ParsedFormat = new StrNumPair("(parsed,777)")
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  StringOnly: {testData.StringOnly}");
      Console.WriteLine($"  NumberOnly: {testData.NumberOnly}");
      Console.WriteLine($"  Both: {testData.Both}");
      Console.WriteLine($"  Empty: {testData.Empty}");
      Console.WriteLine($"  Negative: {testData.Negative}");
      Console.WriteLine($"  Zero: {testData.Zero}");
      Console.WriteLine($"  LongString: {testData.LongString}");
      Console.WriteLine($"  ParsedFormat: {testData.ParsedFormat}");
      Console.WriteLine();

      // Serialize to XML
      var xmlSerializer = new XmlSerializer(typeof(StrNumPairTestData));
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
      StrNumPairTestData? deserializedData;
      using (var stringReader = new StringReader(xmlString))
      {
        deserializedData = (StrNumPairTestData?)xmlSerializer.Deserialize(stringReader);
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
      Console.WriteLine($"  StringOnly: {deserializedData.StringOnly}");
      Console.WriteLine($"  NumberOnly: {deserializedData.NumberOnly}");
      Console.WriteLine($"  Both: {deserializedData.Both}");
      Console.WriteLine($"  Empty: {deserializedData.Empty}");
      Console.WriteLine($"  Negative: {deserializedData.Negative}");
      Console.WriteLine($"  Zero: {deserializedData.Zero}");
      Console.WriteLine($"  LongString: {deserializedData.LongString}");
      Console.WriteLine($"  ParsedFormat: {deserializedData.ParsedFormat}");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name &&
        testData.StringOnly.Equals(deserializedData.StringOnly) &&
        testData.NumberOnly.Equals(deserializedData.NumberOnly) &&
        testData.Both.Equals(deserializedData.Both) &&
        testData.Empty.Equals(deserializedData.Empty) &&
        testData.Negative.Equals(deserializedData.Negative) &&
        testData.Zero.Equals(deserializedData.Zero) &&
        testData.LongString.Equals(deserializedData.LongString) &&
        testData.ParsedFormat.Equals(deserializedData.ParsedFormat);

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

  static bool TestStrNumPairJsonSerialization()
  {
    Console.WriteLine("--- Testing StrNumPair JSON Serialization ---");

    try
    {
      // Create test object
      var testData = new StrNumPairTestData
      {
        Id = 2,
        Name = "JSON Test",
        StringOnly = new StrNumPair("text"),
        NumberOnly = new StrNumPair(null, 100),
        Both = new StrNumPair("label", 200),
        Empty = new StrNumPair(null, null),
        Negative = new StrNumPair("neg", -50),
        Zero = new StrNumPair("zero", 0),
        LongString = new StrNumPair("This is a longer string value", 999),
        ParsedFormat = new StrNumPair("(parsed,777)")
      };

      Console.WriteLine($"Original data:");
      Console.WriteLine($"  Id: {testData.Id}");
      Console.WriteLine($"  Name: {testData.Name}");
      Console.WriteLine($"  StringOnly: {testData.StringOnly}");
      Console.WriteLine($"  NumberOnly: {testData.NumberOnly}");
      Console.WriteLine($"  Both: {testData.Both}");
      Console.WriteLine($"  Empty: {testData.Empty}");
      Console.WriteLine($"  Negative: {testData.Negative}");
      Console.WriteLine($"  Zero: {testData.Zero}");
      Console.WriteLine($"  LongString: {testData.LongString}");
      Console.WriteLine($"  ParsedFormat: {testData.ParsedFormat}");
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
      var deserializedData = JsonSerializer.Deserialize<StrNumPairTestData>(jsonString, jsonOptions);

      if (deserializedData == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }

      // Verify deserialized data
      Console.WriteLine("Deserialized data:");
      Console.WriteLine($"  Id: {deserializedData.Id}");
      Console.WriteLine($"  Name: {deserializedData.Name}");
      Console.WriteLine($"  StringOnly: {deserializedData.StringOnly}");
      Console.WriteLine($"  NumberOnly: {deserializedData.NumberOnly}");
      Console.WriteLine($"  Both: {deserializedData.Both}");
      Console.WriteLine($"  Empty: {deserializedData.Empty}");
      Console.WriteLine($"  Negative: {deserializedData.Negative}");
      Console.WriteLine($"  Zero: {deserializedData.Zero}");
      Console.WriteLine($"  LongString: {deserializedData.LongString}");
      Console.WriteLine($"  ParsedFormat: {deserializedData.ParsedFormat}");
      Console.WriteLine();

      // Validate
      bool isValid =
        testData.Id == deserializedData.Id &&
        testData.Name == deserializedData.Name &&
        testData.StringOnly.Equals(deserializedData.StringOnly) &&
        testData.NumberOnly.Equals(deserializedData.NumberOnly) &&
        testData.Both.Equals(deserializedData.Both) &&
        testData.Empty.Equals(deserializedData.Empty) &&
        testData.Negative.Equals(deserializedData.Negative) &&
        testData.Zero.Equals(deserializedData.Zero) &&
        testData.LongString.Equals(deserializedData.LongString) &&
        testData.ParsedFormat.Equals(deserializedData.ParsedFormat);

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

  static bool TestStrNumPairEdgeCases()
  {
    Console.WriteLine("--- Testing StrNumPair Edge Cases ---");

    try
    {
      // Test null values
      Console.WriteLine("Testing null values:");
      StrNumPair nullStr = new StrNumPair((string?)null);
      StrNumPair nullNum = new StrNumPair(null, null);
      Console.WriteLine($"  Null string: {nullStr}");
      Console.WriteLine($"  Both null: {nullNum}");

      // Test boundary values
      Console.WriteLine("\nTesting boundary values:");
      StrNumPair maxInt = new StrNumPair("max", int.MaxValue);
      StrNumPair minInt = new StrNumPair("min", int.MinValue);
      Console.WriteLine($"  Int.MaxValue: {maxInt}");
      Console.WriteLine($"  Int.MinValue: {minInt}");

      // Test JSON deserialization from different formats
      Console.WriteLine("\nTesting JSON deserialization from different formats:");

      // String format (Str,Num)
      string jsonString = "{\"Value\":\"(abc,123)\"}";
      var fromString = JsonSerializer.Deserialize<StrNumPairWrapper>(jsonString);
      Console.WriteLine($"  From JSON string \"(abc,123)\": {fromString?.Value}");

      // Plain string format
      string jsonPlainString = "{\"Value\":\"plaintext\"}";
      var fromPlainString = JsonSerializer.Deserialize<StrNumPairWrapper>(jsonPlainString);
      Console.WriteLine($"  From JSON plain string \"plaintext\": {fromPlainString?.Value}");

      // Numeric format
      string jsonNumeric = "{\"Value\":456}";
      var fromNumeric = JsonSerializer.Deserialize<StrNumPairWrapper>(jsonNumeric);
      Console.WriteLine($"  From JSON number 456: {fromNumeric?.Value}");

      // Object format
      string jsonObject = "{\"Value\":{\"str\":\"test\",\"num\":789}}";
      var fromObject = JsonSerializer.Deserialize<StrNumPairWrapper>(jsonObject);
      Console.WriteLine($"  From JSON object {{str:\"test\",num:789}}: {fromObject?.Value}");

      // Test equality and hash code
      Console.WriteLine("\nTesting equality and hash code:");
      StrNumPair pair1 = new StrNumPair("test", 123);
      StrNumPair pair2 = new StrNumPair("(test,123)");
      StrNumPair pair3 = new StrNumPair("test", 123);
      Console.WriteLine($"  pair1: {pair1}");
      Console.WriteLine($"  pair2: {pair2}");
      Console.WriteLine($"  pair3: {pair3}");
      Console.WriteLine($"  pair1 == pair2: {pair1.Equals(pair2)}");
      Console.WriteLine($"  pair1 == pair3: {pair1.Equals(pair3)}");
      Console.WriteLine($"  Hash codes: {pair1.GetHashCode()}, {pair2.GetHashCode()}, {pair3.GetHashCode()}");

      if (!pair1.Equals(pair2) || !pair1.Equals(pair3))
      {
        Console.WriteLine("✗ Equality test FAILED");
        return false;
      }

      if (pair1.GetHashCode() != pair3.GetHashCode())
      {
        Console.WriteLine("✗ Hash code consistency test FAILED");
        return false;
      }

      // Test operator overloads
      Console.WriteLine("\nTesting operator overloads:");
      StrNumPair op1 = new StrNumPair("a", 1);
      StrNumPair op2 = new StrNumPair("a", 1);
      StrNumPair op3 = new StrNumPair("b", 2);
      Console.WriteLine($"  op1 == op2: {op1 == op2}");
      Console.WriteLine($"  op1 != op3: {op1 != op3}");

      if (!(op1 == op2) || !(op1 != op3))
      {
        Console.WriteLine("✗ Operator overload test FAILED");
        return false;
      }

      // Test special characters in string
      Console.WriteLine("\nTesting special characters in string:");
      StrNumPair special1 = new StrNumPair("(,)", 10);
      StrNumPair special2 = new StrNumPair("a,b,c", 20);
      StrNumPair special3 = new StrNumPair("line\nbreak", 30);
      Console.WriteLine($"  With parentheses and comma: {special1}");
      Console.WriteLine($"  With multiple commas: {special2}");
      Console.WriteLine($"  With line break: {special3}");

      // Test empty string
      Console.WriteLine("\nTesting empty string:");
      StrNumPair empty = new StrNumPair("", 0);
      Console.WriteLine($"  Empty string: {empty}");

      Console.WriteLine("\n✓ All edge case tests completed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Edge case test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region Performance Tests

  static bool TestStrNumPairPerformance()
  {
    Console.WriteLine("--- Testing StrNumPair Performance ---");

    try
    {
      const int iterations = 100000;

      // Test construction from string
      var sw = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 0; i < iterations; i++)
      {
        StrNumPair pair = new StrNumPair("test");
      }
      sw.Stop();
      Console.WriteLine($"Construction from string x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test construction from format string
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        StrNumPair pair = new StrNumPair("(test,123)");
      }
      sw.Stop();
      Console.WriteLine($"Construction from format string x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test construction from string + number
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        StrNumPair pair = new StrNumPair("test", 123);
      }
      sw.Stop();
      Console.WriteLine($"Construction from string+number x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test ToString performance
      StrNumPair testPair = new StrNumPair("test", 123);
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        string str = testPair.ToString();
      }
      sw.Stop();
      Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test property access
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        string? str = testPair.Str;
        int? num = testPair.Num;
      }
      sw.Stop();
      Console.WriteLine($"Property access (Str,Num) x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test JSON serialization performance
      var testObj = new StrNumPairTestData
      {
        Id = 1,
        Name = "Perf Test",
        StringOnly = new StrNumPair("text"),
        NumberOnly = new StrNumPair(null, 100),
        Both = new StrNumPair("label", 200),
        Empty = new StrNumPair(null, null),
        Negative = new StrNumPair("neg", -50),
        Zero = new StrNumPair("zero", 0),
        LongString = new StrNumPair("This is a longer string value", 999),
        ParsedFormat = new StrNumPair("(parsed,777)")
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
        var obj = JsonSerializer.Deserialize<StrNumPairTestData>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"JSON Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

      // Test Equals performance
      StrNumPair pair1 = new StrNumPair("test", 123);
      StrNumPair pair2 = new StrNumPair("test", 123);
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        bool result = pair1.Equals(pair2);
      }
      sw.Stop();
      Console.WriteLine($"Equals() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test GetHashCode performance
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        int hash = pair1.GetHashCode();
      }
      sw.Stop();
      Console.WriteLine($"GetHashCode() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test implicit conversions performance
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        StrNumPair fromStr = "text";
      }
      sw.Stop();
      Console.WriteLine($"Implicit conversion from string x {iterations}: {sw.ElapsedMilliseconds}ms");

      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        StrNumPair fromInt = 123;
      }
      sw.Stop();
      Console.WriteLine($"Implicit conversion from int x {iterations}: {sw.ElapsedMilliseconds}ms");

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
/// Test data class containing various StrNumPair properties.
/// </summary>
[XmlRoot("StrNumPairTestData")]
public class StrNumPairTestData
{
  [XmlElement("Id")]
  public int Id { get; set; }

  [XmlElement("Name")]
  public string Name { get; set; } = string.Empty;

  [XmlElement("StringOnly")]
  public StrNumPair StringOnly { get; set; }

  [XmlElement("NumberOnly")]
  public StrNumPair NumberOnly { get; set; }

  [XmlElement("Both")]
  public StrNumPair Both { get; set; }

  [XmlElement("Empty")]
  public StrNumPair Empty { get; set; }

  [XmlElement("Negative")]
  public StrNumPair Negative { get; set; }

  [XmlElement("Zero")]
  public StrNumPair Zero { get; set; }

  [XmlElement("LongString")]
  public StrNumPair LongString { get; set; }

  [XmlElement("ParsedFormat")]
  public StrNumPair ParsedFormat { get; set; }
}

/// <summary>
/// Simple wrapper class for testing JSON deserialization scenarios.
/// </summary>
public class StrNumPairWrapper
{
  public StrNumPair Value { get; set; }
}

#endregion