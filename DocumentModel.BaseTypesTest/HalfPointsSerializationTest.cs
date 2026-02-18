using System.Globalization;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for HalfPoints type serialization in both XML and JSON formats.
/// </summary>
public static class HalfPointsSerializationTests
{
  /// <summary>
  /// Runs all HalfPoints serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== HalfPoints Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestHalfPointsBasicOperations()) return false;
    if (!TestHalfPointsUnitConversions()) return false;
    if (!TestHalfPointsXmlSerialization()) return false;
    if (!TestHalfPointsJsonSerialization()) return false;
    if (!TestHalfPointsEdgeCases()) return false;
    if (!TestHalfPointsPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestHalfPointsBasicOperations()
  {
    Console.WriteLine("--- Testing HalfPoints Basic Operations ---");

    try
    {
      // Test string to HalfPoints conversion (plain number)
      HalfPoints hp1 = "144";
      Console.WriteLine($"\n✓ String to HalfPoints: {hp1} = {(Int64)hp1} half-points");

      // Test integer to HalfPoints conversion
      HalfPoints hp2 = 144;
      Console.WriteLine($"\n✓ Int to HalfPoints: {hp2}");

      // Test equality
      if (hp1.CompareTo(hp2) == 0)
        Console.WriteLine("\n✓ Equality test passed");
      else
        Console.WriteLine("✗ Equality test FAILED");

      // Test HalfPoints to string
      string str = hp1.ToString();
      Console.WriteLine($"\n✓ HalfPoints to string: {str}");

      // Test HalfPoints to various integer types
      Int32 int32Val = (Int32)hp1;
      Int64 int64Val = (Int64)hp1;
      UInt32 uint32Val = (UInt32)hp1;
      Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");

      // Test hash code
      Console.WriteLine($"\n✓ Hash code: {hp1.GetHashCode()}");

      // Test comparison
      HalfPoints hp3 = 288; // 2 inches
      Console.WriteLine($"\n✓ CompareTo (144 vs 288): {hp1.CompareTo(hp3)} (expected < 0)");

      Console.WriteLine("\n✓ All basic operations passed");
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

  #region Unit Conversion Tests

  static bool TestHalfPointsUnitConversions()
  {
    Console.WriteLine("--- Testing HalfPoints Unit Conversions ---");

    try
    {
      // Test inch conversions
      Console.WriteLine("Testing inch conversions:");
      HalfPoints oneInch = "1in";
      Console.WriteLine($"  1in = {(Int64)oneInch} half-points (expected 144)");
      Console.WriteLine($"  144 half-points = {oneInch.ToInch():F2}in");
      if ((Int64)oneInch != 144)
      {
        Console.WriteLine("✗ Inch conversion FAILED");
        return false;
      }

      // Test point conversions
      Console.WriteLine("\nTesting point conversions:");
      HalfPoints onePoint = "1pt";
      Console.WriteLine($"  1pt = {(Int64)onePoint} half-points (expected 2)");
      Console.WriteLine($"  2 half-points = {onePoint.ToPoints():F2}pt");
      if ((Int64)onePoint != 2)
      {
        Console.WriteLine("✗ Point conversion FAILED");
        return false;
      }

      // Test half-point precision
      Console.WriteLine("\nTesting half-point precision:");
      HalfPoints halfPoint = "0.5pt";
      Console.WriteLine($"  0.5pt = {(Int64)halfPoint} half-points (expected 1)");
      Console.WriteLine($"  Back to points: {halfPoint.ToPoints():F1}pt");

      // Test millimeter conversions
      Console.WriteLine("\nTesting millimeter conversions:");
      HalfPoints tenMM = "10mm";
      double expectedHalfPoints = 10 * HalfPoints.HalfPointsInMM;
      Console.WriteLine($"  10mm = {(Int64)tenMM} half-points (expected ~{expectedHalfPoints:F0})");
      Console.WriteLine($"  Back to mm: {tenMM.ToMM():F2}mm");

      // Test centimeter conversions
      Console.WriteLine("\nTesting centimeter conversions:");
      HalfPoints oneCM = "1cm";
      expectedHalfPoints = HalfPoints.HalfPointsInCM;
      Console.WriteLine($"  1cm = {(Int64)oneCM} half-points (expected ~{expectedHalfPoints:F0})");
      Console.WriteLine($"  Back to cm: {oneCM.ToCM():F2}cm");

      // Test conversion accuracy
      Console.WriteLine("\nTesting round-trip conversion accuracy:");
      HalfPoints original = 144; // 1 inch
      double inches = original.ToInch();
      HalfPoints roundTrip = new HalfPoints($"{inches:F6}in");
      Console.WriteLine($"  Original: {(Int64)original} half-points");
      Console.WriteLine($"  To inches: {inches:F6}in");
      Console.WriteLine($"  Back to half-points: {(Int64)roundTrip} half-points");
      Console.WriteLine($"  Match: {original.CompareTo(roundTrip) == 0}");

      // Test relationship between half-points and points
      Console.WriteLine("\nTesting half-point/point relationships:");
      HalfPoints twelvePoints = "12pt";
      Console.WriteLine($"  12pt = {(Int64)twelvePoints} half-points (expected 24)");
      Console.WriteLine($"  Back to points: {twelvePoints.ToPoints():F1}pt");

      // Test string output with units
      Console.WriteLine("\nTesting string output with units:");
      HalfPoints measurement = 144;
      Console.WriteLine($"  As half-points: {measurement}");
      Console.WriteLine($"  As inches: {measurement.ToString("in")}");
      Console.WriteLine($"  As points: {measurement.ToString("pt")}");
      Console.WriteLine($"  As mm: {measurement.ToString("mm")}");
      Console.WriteLine($"  As cm: {measurement.ToString("cm")}");

      // Test string output with precision
      Console.WriteLine("\nTesting string output with precision:");
      Console.WriteLine($"  Precision 0: {measurement.ToString(0, "in")}");
      Console.WriteLine($"  Precision 2: {measurement.ToString(2, "pt")}");
      Console.WriteLine($"  Precision 4: {measurement.ToString(4, "mm")}");

      Console.WriteLine("\n✓ All unit conversion tests passed");
      Console.WriteLine();
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"✗ Unit conversion test FAILED: {ex.Message}");
      Console.WriteLine($"  Stack trace: {ex.StackTrace}");
      Console.WriteLine();
      return false;
    }
  }

  #endregion

  #region XML Serialization Tests

  static bool TestHalfPointsXmlSerialization()
  {
    Console.WriteLine("--- Testing HalfPoints XML Serialization ---");

    // Create test object
    var testData = new HalfPointsTestData
    {
      Id = 1,
      Name = "XML Test",
      FontSize = new HalfPoints(24),       // 12 points
      LineHeight = new HalfPoints(36),     // 18 points
      LetterSpacing = new HalfPoints(1),   // 0.5 points
      WordSpacing = new HalfPoints(2),     // 1 point
      SuperscriptOffset = new HalfPoints(10), // 5 points
      SubscriptOffset = new HalfPoints(6), // 3 points
      BorderWidth = new HalfPoints(4),     // 2 points
      ZeroValue = new HalfPoints(0),
      SmallValue = new HalfPoints(1),      // 0.5 points
      LargeValue = new HalfPoints(2000)    // ~13.9 inches
    };

    Console.WriteLine($"Original data:");


    Console.WriteLine($"  FontSize: {testData.FontSize} ({testData.FontSize.ToPoints():F1}pt)");
    Console.WriteLine($"  LineHeight: {testData.LineHeight} ({testData.LineHeight.ToPoints():F1}pt)");
    Console.WriteLine($"  LetterSpacing: {testData.LetterSpacing} ({testData.LetterSpacing.ToPoints():F1}pt)");
    Console.WriteLine($"  WordSpacing: {testData.WordSpacing} ({testData.WordSpacing.ToPoints():F1}pt)");
    Console.WriteLine($"  SuperscriptOffset: {testData.SuperscriptOffset} ({testData.SuperscriptOffset.ToPoints():F1}pt)");
    Console.WriteLine($"  SubscriptOffset: {testData.SubscriptOffset} ({testData.SubscriptOffset.ToPoints():F1}pt)");
    Console.WriteLine($"  BorderWidth: {testData.BorderWidth} ({testData.BorderWidth.ToPoints():F1}pt)");
    Console.WriteLine($"  ZeroValue: {testData.ZeroValue}");
    Console.WriteLine($"  SmallValue: {testData.SmallValue}");
    Console.WriteLine($"  LargeValue: {testData.LargeValue}");
    Console.WriteLine();

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(HalfPointsTestData));
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
    HalfPointsTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (HalfPointsTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData))
      return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(HalfPointsTestData? deserializedData, HalfPointsTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  FontSize: {deserializedData.FontSize} ({deserializedData.FontSize.ToPoints():F1}pt)");
    if (testData.FontSize.CompareTo(deserializedData.FontSize) != 0)
      return false;
    Console.WriteLine($"  LineHeight: {deserializedData.LineHeight} ({deserializedData.LineHeight.ToPoints():F1}pt)");
    if (testData.LineHeight.CompareTo(deserializedData.LineHeight) != 0)
      return false;
    Console.WriteLine($"  LetterSpacing: {deserializedData.LetterSpacing} ({deserializedData.LetterSpacing.ToPoints():F1}pt)");
    if (testData.LetterSpacing.CompareTo(deserializedData.LetterSpacing) != 0)
      return false;
    Console.WriteLine($"  WordSpacing: {deserializedData.WordSpacing} ({deserializedData.WordSpacing.ToPoints():F1}pt)");
    if (testData.WordSpacing.CompareTo(deserializedData.WordSpacing) != 0)
      return false;
    Console.WriteLine($"  SuperscriptOffset: {deserializedData.SuperscriptOffset} ({deserializedData.SuperscriptOffset.ToPoints():F1}pt)");
    if (testData.SuperscriptOffset.CompareTo(deserializedData.SuperscriptOffset) != 0)
      return false;
    Console.WriteLine($"  SubscriptOffset: {deserializedData.SubscriptOffset} ({deserializedData.SubscriptOffset.ToPoints():F1}pt)");
    if (testData.SubscriptOffset.CompareTo(deserializedData.SubscriptOffset) != 0)
      return false;
    Console.WriteLine($"  BorderWidth: {deserializedData.BorderWidth} ({deserializedData.BorderWidth.ToPoints():F1}pt)");
    if (testData.BorderWidth.CompareTo(deserializedData.BorderWidth) != 0)
      return false;
    Console.WriteLine($"  ZeroValue: {deserializedData.ZeroValue}");
    if (testData.ZeroValue.CompareTo(deserializedData.ZeroValue) != 0)
      return false;
    Console.WriteLine($"  SmallValue: {deserializedData.SmallValue}");
    if (testData.SmallValue.CompareTo(deserializedData.SmallValue) != 0)
      return false;
    Console.WriteLine($"  LargeValue: {deserializedData.LargeValue}");
    if (testData.LargeValue.CompareTo(deserializedData.LargeValue) != 0)
      return false;
    return true;
  }

  #endregion

  #region JSON Serialization Tests

  static bool TestHalfPointsJsonSerialization()
  {
    Console.WriteLine("--- Testing HalfPoints JSON Serialization ---");

    // Create test object
    var testData = new HalfPointsTestData
    {
      Id = 2,
      Name = "JSON Test",
      FontSize = new HalfPoints(28),       // 14 points
      LineHeight = new HalfPoints(42),     // 21 points
      LetterSpacing = new HalfPoints(2),   // 1 point
      WordSpacing = new HalfPoints(4),     // 2 points
      SuperscriptOffset = new HalfPoints(12), // 6 points
      SubscriptOffset = new HalfPoints(8), // 4 points
      BorderWidth = new HalfPoints(6),     // 3 points
      ZeroValue = new HalfPoints(0),
      SmallValue = new HalfPoints(1),      // 0.5 points
      LargeValue = new HalfPoints(2000)    // ~13.9 inches
    };

    Console.WriteLine($"Original data:");


    Console.WriteLine($"  FontSize: {testData.FontSize}");
    Console.WriteLine($"  LineHeight: {testData.LineHeight}");
    Console.WriteLine($"  LetterSpacing: {testData.LetterSpacing}");
    Console.WriteLine($"  WordSpacing: {testData.WordSpacing}");
    Console.WriteLine($"  SuperscriptOffset: {testData.SuperscriptOffset}");
    Console.WriteLine($"  SubscriptOffset: {testData.SubscriptOffset}");
    Console.WriteLine($"  BorderWidth: {testData.BorderWidth}");
    Console.WriteLine($"  ZeroValue: {testData.ZeroValue}");
    Console.WriteLine($"  SmallValue: {testData.SmallValue}");
    Console.WriteLine($"  LargeValue: {testData.LargeValue}");
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
    var deserializedData = JsonSerializer.Deserialize<HalfPointsTestData>(jsonString, jsonOptions);

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

  static bool TestHalfPointsEdgeCases()
  {
    Console.WriteLine("--- Testing HalfPoints Edge Cases ---");

    try
    {
      // Test zero value
      Console.WriteLine("Testing zero value:");
      HalfPoints zero = 0;
      Console.WriteLine($"  Zero: '{zero}' ({(Int64)zero} half-points)");

      // Test boundary values
      Console.WriteLine("\nTesting boundary values:");
      HalfPoints minInt32 = Int32.MinValue;
      HalfPoints maxInt32 = Int32.MaxValue;
      Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch():F2}in)");
      Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch():F2}in)");

      // Test half-point precision (unique to HalfPoints)
      Console.WriteLine("\nTesting half-point precision:");
      HalfPoints oneHalfPoint = 1;
      HalfPoints twoHalfPoints = 2;
      Console.WriteLine($"  1 half-point = {oneHalfPoint.ToPoints():F1}pt");
      Console.WriteLine($"  2 half-points = {twoHalfPoints.ToPoints():F1}pt (1 full point)");

      // Test common fine-grained adjustments
      Console.WriteLine("\nTesting fine-grained typography adjustments:");
      HalfPoints letterSpacing = new HalfPoints(1);    // 0.5pt letter spacing
      HalfPoints kerning = new HalfPoints(2);          // 1pt kerning
      HalfPoints tracking = new HalfPoints(3);         // 1.5pt tracking
      Console.WriteLine($"  Letter spacing (1 half-point): {letterSpacing.ToPoints():F1}pt");
      Console.WriteLine($"  Kerning (2 half-points): {kerning.ToPoints():F1}pt");
      Console.WriteLine($"  Tracking (3 half-points): {tracking.ToPoints():F1}pt");

      // Test common font sizes in half-points
      Console.WriteLine("\nTesting common font sizes:");
      HalfPoints font10pt = new HalfPoints(20);   // 10pt
      HalfPoints font12pt = new HalfPoints(24);   // 12pt
      HalfPoints font14pt = new HalfPoints(28);   // 14pt
      Console.WriteLine($"  10pt = {(Int64)font10pt} half-points");
      Console.WriteLine($"  12pt = {(Int64)font12pt} half-points");
      Console.WriteLine($"  14pt = {(Int64)font14pt} half-points");

      // Test string parsing variations
      Console.WriteLine("\nTesting string parsing variations:");
      HalfPoints fromPlainNumber = "144";
      HalfPoints fromInches = "1in";
      HalfPoints fromPoints = "12pt";
      HalfPoints fromHalfPoints = "0.5pt";
      Console.WriteLine($"  \"144\" → {(Int64)fromPlainNumber} half-points");
      Console.WriteLine($"  \"1in\" → {(Int64)fromInches} half-points");
      Console.WriteLine($"  \"12pt\" → {(Int64)fromPoints} half-points");
      Console.WriteLine($"  \"0.5pt\" → {(Int64)fromHalfPoints} half-points");

      // Test decimal values with units
      Console.WriteLine("\nTesting decimal values with units:");
      HalfPoints halfInch = new HalfPoints("0.5in");
      HalfPoints quarterInch = new HalfPoints("0.25in");
      Console.WriteLine($"  0.5in = {(Int64)halfInch} half-points (expected 72)");
      Console.WriteLine($"  0.25in = {(Int64)quarterInch} half-points (expected 36)");

      // Test comma decimal separator
      Console.WriteLine("\nTesting comma decimal separator:");
      HalfPoints commaDecimal = new HalfPoints("2,54cm");
      Console.WriteLine($"  \"2,54cm\" → {(Int64)commaDecimal} half-points");

      // Test Deserialization from different formats
      Console.WriteLine("\nTesting Deserialization from different formats:");

      // Numeric format
      string jsonNumeric = "{\"Value\":144}";
      var fromNumeric = JsonSerializer.Deserialize<HalfPointsWrapper>(jsonNumeric);
      Console.WriteLine($"  From JSON number 144: {fromNumeric?.Value}");

      // String format with unit
      string jsonStringInch = "{\"Value\":\"1in\"}";
      var fromStringInch = JsonSerializer.Deserialize<HalfPointsWrapper>(jsonStringInch);
      Console.WriteLine($"  From JSON string \"1in\": {fromStringInch?.Value}");

      // String format with point unit
      string jsonStringPt = "{\"Value\":\"12pt\"}";
      var fromStringPt = JsonSerializer.Deserialize<HalfPointsWrapper>(jsonStringPt);
      Console.WriteLine($"  From JSON string \"12pt\": {fromStringPt?.Value} (expected 24)");

      // String format without unit
      string jsonStringPlain = "{\"Value\":\"144\"}";
      var fromStringPlain = JsonSerializer.Deserialize<HalfPointsWrapper>(jsonStringPlain);
      Console.WriteLine($"  From JSON string \"144\": {fromStringPlain?.Value}");

      // Test output with units
      Console.WriteLine("\nTesting output format with different units:");
      HalfPoints measurement = 144;
      Console.WriteLine($"  As half-points: {measurement}");
      Console.WriteLine($"  As inches (no precision): {measurement.ToString("in")}");
      Console.WriteLine($"  As inches (2 decimal): {measurement.ToString(2, "in")}");
      Console.WriteLine($"  As points (1 decimal): {measurement.ToString(1, "pt")}");
      Console.WriteLine($"  As mm (1 decimal): {measurement.ToString(1, "mm")}");
      Console.WriteLine($"  As cm (2 decimal): {measurement.ToString(2, "cm")}");

      // Test comparison
      Console.WriteLine("\nTesting comparison:");
      HalfPoints small = 72;  // 0.5 inch
      HalfPoints large = 144; // 1 inch
      Console.WriteLine($"  72 < 144: {small.CompareTo(large) < 0}");
      Console.WriteLine($"  144 > 72: {large.CompareTo(small) > 0}");
      Console.WriteLine($"  144 == 144: {large.CompareTo(new HalfPoints(144)) == 0}");

      // Test implicit conversions
      Console.WriteLine("\nTesting implicit conversions:");
      HalfPoints fromInt32 = 144;
      HalfPoints fromInt64 = 144L;
      HalfPoints fromUInt32 = 144U;
      Int32 toInt32 = fromInt32;
      Int64 toInt64 = fromInt64;
      Console.WriteLine($"  From Int32: {fromInt32}");
      Console.WriteLine($"  From Int64: {fromInt64}");
      Console.WriteLine($"  From UInt32: {fromUInt32}");
      Console.WriteLine($"  To Int32: {toInt32}");
      Console.WriteLine($"  To Int64: {toInt64}");

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

  static bool TestHalfPointsPerformance()
  {
    Console.WriteLine("--- Testing HalfPoints Performance ---");

    try
    {
      const int iterations = 100000;

      // Test construction from string with unit
      var sw = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 0; i < iterations; i++)
      {
        HalfPoints hp = "1in";
      }
      sw.Stop();
      Console.WriteLine($"Construction from string with unit x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test construction from plain number string
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        HalfPoints hp = "144";
      }
      sw.Stop();
      Console.WriteLine($"Construction from plain string x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test construction from integer
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        HalfPoints hp = 144;
      }
      sw.Stop();
      Console.WriteLine($"Construction from integer x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test ToString performance
      HalfPoints testHp = 144;
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        string str = testHp.ToString();
      }
      sw.Stop();
      Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test ToString with unit
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        string str = testHp.ToString("in");
      }
      sw.Stop();
      Console.WriteLine($"ToString(unit) x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test unit conversion performance
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        double inches = testHp.ToInch();
      }
      sw.Stop();
      Console.WriteLine($"ToInch() x {iterations}: {sw.ElapsedMilliseconds}ms");

      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        double points = testHp.ToPoints();
      }
      sw.Stop();
      Console.WriteLine($"ToPoints() x {iterations}: {sw.ElapsedMilliseconds}ms");

      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        double mm = testHp.ToMM();
      }
      sw.Stop();
      Console.WriteLine($"ToMM() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test JSON serialization performance
      var testObj = new HalfPointsTestData
      {
        Id = 1,
        Name = "Perf Test",
        FontSize = new HalfPoints(24),
        LineHeight = new HalfPoints(36),
        LetterSpacing = new HalfPoints(1),
        WordSpacing = new HalfPoints(2),
        SuperscriptOffset = new HalfPoints(10),
        SubscriptOffset = new HalfPoints(6),
        BorderWidth = new HalfPoints(4),
        ZeroValue = new HalfPoints(0),
        SmallValue = new HalfPoints(1),
        LargeValue = new HalfPoints(2000)
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
        var obj = JsonSerializer.Deserialize<HalfPointsTestData>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

      // Test comparison performance
      HalfPoints hp1 = 144;
      HalfPoints hp2 = 144;
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        int result = hp1.CompareTo(hp2);
      }
      sw.Stop();
      Console.WriteLine($"CompareTo() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test hash code performance
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        int hash = hp1.GetHashCode();
      }
      sw.Stop();
      Console.WriteLine($"GetHashCode() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test implicit conversions performance
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        Int64 value = hp1;
      }
      sw.Stop();
      Console.WriteLine($"Implicit conversion to Int64 x {iterations}: {sw.ElapsedMilliseconds}ms");

      Console.WriteLine("\n✓ Performance tests completed");
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
/// Test data class containing various HalfPoints properties.
/// </summary>
[XmlRoot("HalfPointsTestData")]
public class HalfPointsTestData
{
  [XmlElement("Id")]
  public int Id { get; set; }

  [XmlElement("Name")]
  public string Name { get; set; } = string.Empty;

  [XmlElement("FontSize")]
  public HalfPoints FontSize { get; set; }

  [XmlElement("LineHeight")]
  public HalfPoints LineHeight { get; set; }

  [XmlElement("LetterSpacing")]
  public HalfPoints LetterSpacing { get; set; }

  [XmlElement("WordSpacing")]
  public HalfPoints WordSpacing { get; set; }

  [XmlElement("SuperscriptOffset")]
  public HalfPoints SuperscriptOffset { get; set; }

  [XmlElement("SubscriptOffset")]
  public HalfPoints SubscriptOffset { get; set; }

  [XmlElement("BorderWidth")]
  public HalfPoints BorderWidth { get; set; }

  [XmlElement("ZeroValue")]
  public HalfPoints ZeroValue { get; set; }

  [XmlElement("SmallValue")]
  public HalfPoints SmallValue { get; set; }

  [XmlElement("LargeValue")]
  public HalfPoints LargeValue { get; set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class HalfPointsWrapper
{
  public HalfPoints Value { get; set; }
}

#endregion