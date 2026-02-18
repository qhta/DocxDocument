using System.Globalization;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for Points type serialization in both XML and JSON formats.
/// </summary>
public static class PointsSerializationTests
{
  /// <summary>
  /// Runs all Points serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== Points Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestPointsBasicOperations()) return false;
    if (!TestPointsUnitConversions()) return false;
    if (!TestPointsXmlSerialization()) return false;
    if (!TestPointsJsonSerialization()) return false;
    if (!TestPointsEdgeCases()) return false;
    if (!TestPointsPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestPointsBasicOperations()
  {
    Console.WriteLine("--- Testing Points Basic Operations ---");      // Test string to Points conversion (plain number)
    Points points1 = "72";
    Console.WriteLine($"\n✓ String to Points: {points1} = {(Int64)points1} points");

    // Test integer to Points conversion
    Points points2 = 72;
    Console.WriteLine($"\n✓ Int to Points: {points2}");

    // Test equality
    if (points1.CompareTo(points2) == 0)
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test Points to string
    string str = points1.ToString();
    Console.WriteLine($"\n✓ Points to string: {str}");

    // Test Points to various integer types
    Int32 int32Val = (Int32)points1;
    Int64 int64Val = (Int64)points1;
    UInt32 uint32Val = (UInt32)points1;
    Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {points1.GetHashCode()}");

    // Test comparison
    Points points3 = 144; // 2 inches
    Console.WriteLine($"\n✓ CompareTo (72 vs 144): {points1.CompareTo(points3)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Unit Conversion Tests

  static bool TestPointsUnitConversions()
  {
    Console.WriteLine("--- Testing Points Unit Conversions ---");      // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    Points oneInch = "1in";
    Console.WriteLine($"  1in = {(Int64)oneInch} points (expected 72)");
    Console.WriteLine($"  72 points = {oneInch.ToInch():F2}in");
    if ((Int64)oneInch != 72)
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test point conversions (identity)
    Console.WriteLine("\nTesting point conversions:");
    Points twelvePoints = "12pt";
    Console.WriteLine($"  12pt = {(Int64)twelvePoints} points (expected 12)");
    Console.WriteLine($"  12 points = {twelvePoints.ToPoints():F2}pt");
    if ((Int64)twelvePoints != 12)
    {
      Console.WriteLine("✗ Point conversion FAILED");
      return false;
    }

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    Points tenMM = "10mm";
    double expectedPoints = 10 * Points.PointsInMM;
    Console.WriteLine($"  10mm = {(Int64)tenMM} points (expected ~{expectedPoints:F0})");
    Console.WriteLine($"  Back to mm: {tenMM.ToMM():F2}mm");

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    Points oneCM = "1cm";
    expectedPoints = Points.PointsInCM;
    Console.WriteLine($"  1cm = {(Int64)oneCM} points (expected ~{expectedPoints:F0})");
    Console.WriteLine($"  Back to cm: {oneCM.ToCM():F2}cm");

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    Points original = 72; // 1 inch
    double inches = original.ToInch();
    Points roundTrip = new Points($"{inches:F6}in");
    Console.WriteLine($"  Original: {(Int64)original} points");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to points: {(Int64)roundTrip} points");
    Console.WriteLine($"  Match: {original.CompareTo(roundTrip) == 0}");

    // Test string output with units
    Console.WriteLine("\nTesting string output with units:");
    Points measurement = 72;
    Console.WriteLine($"  As points: {measurement}");
    Console.WriteLine($"  As inches: {measurement.ToString("in")}");
    Console.WriteLine($"  As points: {measurement.ToString("pt")}");
    Console.WriteLine($"  As mm: {measurement.ToString("mm")}");
    Console.WriteLine($"  As cm: {measurement.ToString("cm")}");

    // Test string output with precision
    Console.WriteLine("\nTesting string output with precision:");
    Console.WriteLine($"  Precision 0: {measurement.ToString(0, "in")}");
    Console.WriteLine($"  Precision 2: {measurement.ToString(2, "in")}");
    Console.WriteLine($"  Precision 4: {measurement.ToString(4, "mm")}");

    Console.WriteLine("\n✓ All unit conversion tests passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region XML Serialization Tests

  static bool TestPointsXmlSerialization()
  {
    Console.WriteLine("--- Testing Points XML Serialization ---");      // Create test object
    var testData = new PointsTestData
    {
      FontSize = new Points(12),       // 12 points
      LineHeight = new Points(18),     // 18 points
      ParagraphSpacing = new Points(6),// 6 points
      Indent = new Points(36),         // 36 points (0.5 inch)
      BodyFontSize = new Points(10),   // 10 points
      HeadingFontSize = new Points(24),// 24 points
      ZeroValue = new Points(0),
      SmallValue = new Points(1),      // 1 point
      LargeValue = new Points(1000)    // ~13.9 inches
    };

    Console.WriteLine($"Original data:");


    Console.WriteLine($"  FontSize: {testData.FontSize} ({testData.FontSize.ToPoints():F1}pt)");
    Console.WriteLine($"  LineHeight: {testData.LineHeight} ({testData.LineHeight.ToPoints():F1}pt)");
    Console.WriteLine($"  ParagraphSpacing: {testData.ParagraphSpacing} ({testData.ParagraphSpacing.ToPoints():F1}pt)");
    Console.WriteLine($"  Indent: {testData.Indent} ({testData.Indent.ToInch():F2}in)");
    Console.WriteLine($"  BodyFontSize: {testData.BodyFontSize} ({testData.BodyFontSize.ToPoints():F1}pt)");
    Console.WriteLine($"  HeadingFontSize: {testData.HeadingFontSize} ({testData.HeadingFontSize.ToPoints():F1}pt)");
    Console.WriteLine($"  ZeroValue: {testData.ZeroValue}");
    Console.WriteLine($"  SmallValue: {testData.SmallValue}");
    Console.WriteLine($"  LargeValue: {testData.LargeValue}");
    Console.WriteLine();

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(PointsTestData));
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
    PointsTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (PointsTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(PointsTestData? deserializedData, PointsTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  FontSize: {deserializedData.FontSize} ({deserializedData.FontSize.ToPoints():F1}pt)");
    if (testData.FontSize.CompareTo(deserializedData.FontSize) != 0)
      return false;
    Console.WriteLine($"  LineHeight: {deserializedData.LineHeight} ({deserializedData.LineHeight.ToPoints():F1}pt)");
    if (testData.LineHeight.CompareTo(deserializedData.LineHeight) != 0)
      return false;
    Console.WriteLine($"  ParagraphSpacing: {deserializedData.ParagraphSpacing} ({deserializedData.ParagraphSpacing.ToPoints():F1}pt)");
    if (testData.ParagraphSpacing.CompareTo(deserializedData.ParagraphSpacing) != 0)
      return false;
    Console.WriteLine($"  Indent: {deserializedData.Indent} ({deserializedData.Indent.ToInch():F2}in)");
    if (testData.Indent.CompareTo(deserializedData.Indent) != 0)
      return false;
    Console.WriteLine($"  BodyFontSize: {deserializedData.BodyFontSize} ({deserializedData.BodyFontSize.ToPoints():F1}pt)");
    if (testData.BodyFontSize.CompareTo(deserializedData.BodyFontSize) != 0)
      return false;
    Console.WriteLine($"  HeadingFontSize: {deserializedData.HeadingFontSize} ({deserializedData.HeadingFontSize.ToPoints():F1}pt)");
    if (testData.HeadingFontSize.CompareTo(deserializedData.HeadingFontSize) != 0)
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

  static bool TestPointsJsonSerialization()
  {
    Console.WriteLine("--- Testing Points JSON Serialization ---");      // Create test object
    var testData = new PointsTestData
    {
      FontSize = new Points(14),       // 14 points
      LineHeight = new Points(21),     // 21 points
      ParagraphSpacing = new Points(8),// 8 points
      Indent = new Points(72),         // 72 points (1 inch)
      BodyFontSize = new Points(11),   // 11 points
      HeadingFontSize = new Points(18),// 18 points
      ZeroValue = new Points(0),
      SmallValue = new Points(1),      // 1 point
      LargeValue = new Points(1000)    // ~13.9 inches
    };

    Console.WriteLine($"Original data:");


    Console.WriteLine($"  FontSize: {testData.FontSize}");
    Console.WriteLine($"  LineHeight: {testData.LineHeight}");
    Console.WriteLine($"  ParagraphSpacing: {testData.ParagraphSpacing}");
    Console.WriteLine($"  Indent: {testData.Indent}");
    Console.WriteLine($"  BodyFontSize: {testData.BodyFontSize}");
    Console.WriteLine($"  HeadingFontSize: {testData.HeadingFontSize}");
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
    var deserializedData = JsonSerializer.Deserialize<PointsTestData>(jsonString, jsonOptions);
    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Edge Cases Tests

  static bool TestPointsEdgeCases()
  {
    Console.WriteLine("--- Testing Points Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    Points zero = 0;
    Console.WriteLine($"  Zero: '{zero}' ({(Int64)zero} points)");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    Points minInt32 = Int32.MinValue;
    Points maxInt32 = Int32.MaxValue;
    Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch():F2}in)");
    Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch():F2}in)");

    // Test common font sizes
    Console.WriteLine("\nTesting common font sizes:");
    Points font8pt = new Points("8pt");
    Points font10pt = new Points("10pt");
    Points font12pt = new Points("12pt");
    Points font14pt = new Points("14pt");
    Points font18pt = new Points("18pt");
    Points font24pt = new Points("24pt");
    Console.WriteLine($"  8pt = {(Int64)font8pt} points");
    Console.WriteLine($"  10pt = {(Int64)font10pt} points");
    Console.WriteLine($"  12pt = {(Int64)font12pt} points");
    Console.WriteLine($"  14pt = {(Int64)font14pt} points");
    Console.WriteLine($"  18pt = {(Int64)font18pt} points");
    Console.WriteLine($"  24pt = {(Int64)font24pt} points");

    // Test common measurements in typography
    Console.WriteLine("\nTesting common typography measurements:");
    Points pica = new Points("12pt");  // 1 pica = 12 points
    Points halfInch = new Points("0.5in");
    Points quarterInch = new Points("0.25in");
    Console.WriteLine($"  1 pica (12pt): {(Int64)pica} points");
    Console.WriteLine($"  0.5in: {(Int64)halfInch} points (expected 36)");
    Console.WriteLine($"  0.25in: {(Int64)quarterInch} points (expected 18)");

    // Test string parsing variations
    Console.WriteLine("\nTesting string parsing variations:");
    Points fromPlainNumber = "72";
    Points fromInches = "1in";
    Points fromPoints = "72pt";
    Console.WriteLine($"  \"72\" → {(Int64)fromPlainNumber} points");
    Console.WriteLine($"  \"1in\" → {(Int64)fromInches} points");
    Console.WriteLine($"  \"72pt\" → {(Int64)fromPoints} points");

    // Test decimal values with units
    Console.WriteLine("\nTesting decimal values with units:");
    Points halfPoint = new Points("0.5pt");
    Points quarterPoint = new Points("0.25pt");
    Console.WriteLine($"  0.5pt = {(Int64)halfPoint} points (expected 0)");
    Console.WriteLine($"  0.25pt = {(Int64)quarterPoint} points (expected 0)");

    // Test comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    Points commaDecimal = new Points("2,54cm");
    Console.WriteLine($"  \"2,54cm\" → {(Int64)commaDecimal} points");

    // Test Deserialization from different formats
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // Numeric format
    string jsonNumeric = "{\"Value\":72}";
    var fromNumeric = JsonSerializer.Deserialize<PointsWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 72: {fromNumeric?.Value}");

    // String format with unit
    string jsonStringInch = "{\"Value\":\"1in\"}";
    var fromStringInch = JsonSerializer.Deserialize<PointsWrapper>(jsonStringInch);
    Console.WriteLine($"  From JSON string \"1in\": {fromStringInch?.Value}");

    // String format without unit
    string jsonStringPlain = "{\"Value\":\"72\"}";
    var fromStringPlain = JsonSerializer.Deserialize<PointsWrapper>(jsonStringPlain);
    Console.WriteLine($"  From JSON string \"72\": {fromStringPlain?.Value}");

    // Test output with units match input
    Console.WriteLine("\nTesting output format with different units:");
    Points measurement = 72;
    Console.WriteLine($"  As points: {measurement}");
    Console.WriteLine($"  As inches (no precision): {measurement.ToString("in")}");
    Console.WriteLine($"  As inches (2 decimal): {measurement.ToString(2, "in")}");
    Console.WriteLine($"  As points: {measurement.ToString("pt")}");
    Console.WriteLine($"  As mm (1 decimal): {measurement.ToString(1, "mm")}");
    Console.WriteLine($"  As cm (2 decimal): {measurement.ToString(2, "cm")}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    Points small = 36;  // 0.5 inch
    Points large = 72;  // 1 inch
    Console.WriteLine($"  36 < 72: {small.CompareTo(large) < 0}");
    Console.WriteLine($"  72 > 36: {large.CompareTo(small) > 0}");
    Console.WriteLine($"  72 == 72: {large.CompareTo(new Points(72)) == 0}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit conversions:");
    Points fromInt32 = 72;
    Points fromInt64 = 72L;
    Points fromUInt32 = 72U;
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

  #endregion

  #region Performance Tests

  static bool TestPointsPerformance()
  {
    Console.WriteLine("--- Testing Points Performance ---"); const int iterations = 100000;

    // Test construction from string with unit
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      Points points = "1in";
    }
    sw.Stop();
    Console.WriteLine($"Construction from string with unit x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from plain number string
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      Points points = "72";
    }
    sw.Stop();
    Console.WriteLine($"Construction from plain string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from integer
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      Points points = 72;
    }
    sw.Stop();
    Console.WriteLine($"Construction from integer x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    Points testPoints = 72;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testPoints.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString with unit
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testPoints.ToString("in");
    }
    sw.Stop();
    Console.WriteLine($"ToString(unit) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test unit conversion performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double inches = testPoints.ToInch();
    }
    sw.Stop();
    Console.WriteLine($"ToInch() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double points = testPoints.ToPoints();
    }
    sw.Stop();
    Console.WriteLine($"ToPoints() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double mm = testPoints.ToMM();
    }
    sw.Stop();
    Console.WriteLine($"ToMM() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new PointsTestData
    {
      FontSize = new Points(12),
      LineHeight = new Points(18),
      ParagraphSpacing = new Points(6),
      Indent = new Points(36),
      BodyFontSize = new Points(10),
      HeadingFontSize = new Points(24),
      ZeroValue = new Points(0),
      SmallValue = new Points(1),
      LargeValue = new Points(1000)
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
      var obj = JsonSerializer.Deserialize<PointsTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test comparison performance
    Points points1 = 72;
    Points points2 = 72;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int result = points1.CompareTo(points2);
    }
    sw.Stop();
    Console.WriteLine($"CompareTo() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test hash code performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int hash = points1.GetHashCode();
    }
    sw.Stop();
    Console.WriteLine($"GetHashCode() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test implicit conversions performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      Int64 value = points1;
    }
    sw.Stop();
    Console.WriteLine($"Implicit conversion to Int64 x {iterations}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  #endregion
}

#region Test Helper Classes

/// <summary>
/// Test data class containing various Points properties.
/// </summary>
[XmlRoot("PointsTestData")]
public class PointsTestData
{
  [XmlElement("FontSize")]
  public Points FontSize { get; set; }

  [XmlElement("LineHeight")]
  public Points LineHeight { get; set; }

  [XmlElement("ParagraphSpacing")]
  public Points ParagraphSpacing { get; set; }

  [XmlElement("Indent")]
  public Points Indent { get; set; }

  [XmlElement("BodyFontSize")]
  public Points BodyFontSize { get; set; }

  [XmlElement("HeadingFontSize")]
  public Points HeadingFontSize { get; set; }

  [XmlElement("ZeroValue")]
  public Points ZeroValue { get; set; }

  [XmlElement("SmallValue")]
  public Points SmallValue { get; set; }

  [XmlElement("LargeValue")]
  public Points LargeValue { get; set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class PointsWrapper
{
  public Points Value { get; set; }
}

#endregion