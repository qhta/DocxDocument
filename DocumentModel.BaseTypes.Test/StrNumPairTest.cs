namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for StrNumPair type serialization in both XML and JSON formats.
/// </summary>
public static class StrNumPairTest
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


  static bool TestStrNumPairBasicOperations()
  {
    Console.WriteLine("--- Testing StrNumPair Basic Operations ---");      // Test string-only constructor
    StrNumPair pair1 = new StrNumPair("test");
    Console.WriteLine($"\n✓ String constructor: {pair1} (Str='{pair1.Str}', Num={pair1.Num})");

    // Test string + number constructor
    StrNumPair pair2 = new StrNumPair("abc", 123);
    Console.WriteLine($"\n✓ String+Number constructor: {pair2} (Str='{pair2.Str}', Num={pair2.Num})");

    // Test parsing format "(Str,Num)"
    StrNumPair pair3 = new StrNumPair("(xyz,456)");
    Console.WriteLine($"\n✓ Parsing format: {pair3} (Str='{pair3.Str}', Num={pair3.Num})");

    // Test equality
    StrNumPair pair4 = new StrNumPair("abc", 123);
    if (pair2.Equals(pair4))
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test ToString
    string str = pair2.ToString();
    Console.WriteLine($"\n✓ ToString: {str}");

    // Test round-trip parsing
    StrNumPair pair5 = new StrNumPair(str);
    if (pair2.Equals(pair5))
      Console.WriteLine("\n✓ Round-trip parsing passed");
    else
      Console.WriteLine("✗ Round-trip parsing FAILED");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {pair2.GetHashCode()}");

    // Test implicit conversions
    StrNumPair fromString = "text";
    StrNumPair fromInt = 42;
    Console.WriteLine($"\n✓ Implicit from string: {fromString}");
    Console.WriteLine($"\n✓ Implicit from int: {fromInt}");

    string? backToString = fromString;
    int? backToInt = fromInt;
    Console.WriteLine($"\n✓ Back to string: '{backToString}'");
    Console.WriteLine($"\n✓ Back to int: {backToInt}");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }



  static bool TestStrNumPairParsing()
  {
    Console.WriteLine("--- Testing StrNumPair Parsing ---");      // Test format "(Str,Num)" with both values
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



  static bool TestStrNumPairXmlSerialization()
  {
    Console.WriteLine("--- Testing StrNumPair XML Serialization ---");      // Create test object
    var testData = new StrNumPairTestData
    {
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

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(StrNumPairTestData? deserializedData, StrNumPairTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  StringOnly: {deserializedData.StringOnly}");
    if (!testData.StringOnly.Equals(deserializedData.StringOnly))
      return false;
    Console.WriteLine($"  NumberOnly: {deserializedData.NumberOnly}");
    if (!testData.NumberOnly.Equals(deserializedData.NumberOnly))
      return false;
    Console.WriteLine($"  Both: {deserializedData.Both}");
    if (!testData.Both.Equals(deserializedData.Both))
      return false;
    Console.WriteLine($"  Empty: {deserializedData.Empty}");
    if (!testData.Empty.Equals(deserializedData.Empty))
      return false;
    Console.WriteLine($"  Negative: {deserializedData.Negative}");
    if (!testData.Negative.Equals(deserializedData.Negative))
      return false;
    Console.WriteLine($"  Zero: {deserializedData.Zero}");
    if (!testData.Zero.Equals(deserializedData.Zero))
      return false;
    Console.WriteLine($"  LongString: {deserializedData.LongString}");
    if (!testData.LongString.Equals(deserializedData.LongString))
      return false;
    Console.WriteLine($"  ParsedFormat: {deserializedData.ParsedFormat}");
    if (!testData.ParsedFormat.Equals(deserializedData.ParsedFormat))
      return false;

    return true;
  }



  static bool TestStrNumPairJsonSerialization()
  {
    Console.WriteLine("--- Testing StrNumPair JSON Serialization ---");      // Create test object
    var testData = new StrNumPairTestData
    {
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
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }



  static bool TestStrNumPairEdgeCases()
  {
    Console.WriteLine("--- Testing StrNumPair Edge Cases ---");      // Test null values
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

    // Test Deserialization from different formats
    Console.WriteLine("\nTesting Deserialization from different formats:");

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



  static bool TestStrNumPairPerformance()
  {
    Console.WriteLine("--- Testing StrNumPair Performance ---"); const int iterations = 100000;

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

    // Test Deserialization performance
    string jsonData = JsonSerializer.Serialize(testObj);
    sw.Restart();
    for (int i = 0; i < iterations / 10; i++)
    {
      var obj = JsonSerializer.Deserialize<StrNumPairTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

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

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

}


/// <summary>
/// Test data class containing various StrNumPair properties.
/// </summary>
[XmlRoot("StrNumPairTestData")]
public class StrNumPairTestData
{
  [XmlElement("StringOnly")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public StrNumPair StringOnly { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("NumberOnly")]
  public StrNumPair NumberOnly { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("Both")]
  public StrNumPair Both { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("Empty")]
  public StrNumPair Empty { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("Negative")]
  public StrNumPair Negative { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("Zero")]
  public StrNumPair Zero { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LongString")]
  public StrNumPair LongString { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ParsedFormat")]
  public StrNumPair ParsedFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class StrNumPairWrapper
{
  public StrNumPair Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


