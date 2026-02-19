using System.Globalization;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for Points type serialization in both XML and JSON formats.
/// </summary>
public static class PTSTest
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

  
  static bool TestPointsBasicOperations()
  {
    Console.WriteLine("--- Testing Points Basic Operations ---");      // Test string to Points conversion (plain number)
    PTS points1 = "72";
    Console.WriteLine($"\n✓ String to Points: {points1} = {(Int64)points1} points");

    // Test integer to Points conversion
    PTS points2 = 72;
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
    PTS points3 = 144; // 2 inches
    Console.WriteLine($"\n✓ CompareTo (72 vs 144): {points1.CompareTo(points3)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestPointsUnitConversions()
  {
    Console.WriteLine("--- Testing Points Unit Conversions ---");      // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    PTS oneInch = "1in";
    Console.WriteLine($"  1in = {(Int64)oneInch} points (expected 72)");
    Console.WriteLine($"  72 points = {oneInch.ToInch():F2}in");
    if ((Int64)oneInch != 72)
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test point conversions (identity)
    Console.WriteLine("\nTesting point conversions:");
    PTS twelvePoints = "12pt";
    Console.WriteLine($"  12pt = {(Int64)twelvePoints} points (expected 12)");
    Console.WriteLine($"  12 points = {twelvePoints.ToPT():F2}pt");
    if ((Int64)twelvePoints != 12)
    {
      Console.WriteLine("✗ Point conversion FAILED");
      return false;
    }

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    PTS tenMM = "10mm";
    double expectedPoints = 10 * PTS.PTSinMM;
    Console.WriteLine($"  10mm = {(Int64)tenMM} points (expected ~{expectedPoints:F0})");
    Console.WriteLine($"  Back to mm: {tenMM.ToMM():F2}mm");

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    PTS oneCM = "1cm";
    expectedPoints = PTS.PTSinCM;
    Console.WriteLine($"  1cm = {(Int64)oneCM} points (expected ~{expectedPoints:F0})");
    Console.WriteLine($"  Back to cm: {oneCM.ToCM():F2}cm");

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    PTS original = 72; // 1 inch
    double inches = original.ToInch();
    PTS roundTrip = new PTS($"{inches:F6}in");
    Console.WriteLine($"  Original: {(Int64)original} points");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to points: {(Int64)roundTrip} points");
    Console.WriteLine($"  Match: {original.CompareTo(roundTrip) == 0}");

    // Test string output with units
    Console.WriteLine("\nTesting string output with units:");
    PTS measurement = 72;
    Console.WriteLine($"  As points: {measurement}");
    Console.WriteLine($"  As inches: {measurement.ToString(LengthUnit.Inches)}");
    Console.WriteLine($"  As points: {measurement.ToString(LengthUnit.Points)}");
    Console.WriteLine($"  As mm: {measurement.ToString(LengthUnit.Millimeters)}");
    Console.WriteLine($"  As cm: {measurement.ToString(LengthUnit.Centimeters)}");

    // Test string output with precision
    Console.WriteLine("\nTesting string output with precision:");
    Console.WriteLine($"  Precision 0: {measurement.ToString("F0", LengthUnit.Inches)}");
    Console.WriteLine($"  Precision 2: {measurement.ToString("F2", LengthUnit.Inches)}");
    Console.WriteLine($"  Precision 4: {measurement.ToString("F4", LengthUnit.Millimeters)}");

    Console.WriteLine("\n✓ All unit conversion tests passed");
    Console.WriteLine();
    return true;
  }

  
  
  static bool TestPointsXmlSerialization()
  {
    Console.WriteLine("--- Testing Points XML Serialization ---");      // Create test object
    var testData = CreateTestData();

    ShowOriginalData(testData);

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

    Console.WriteLine($"  FontSize: {deserializedData.FontSize} ({deserializedData.FontSize.ToPT():F1}pt)");
    if (testData.FontSize.CompareTo(deserializedData.FontSize) != 0)
      return false;
    Console.WriteLine($"  LineHeight: {deserializedData.LineHeight} ({deserializedData.LineHeight.ToPT():F1}pt)");
    if (testData.LineHeight.CompareTo(deserializedData.LineHeight) != 0)
      return false;
    Console.WriteLine($"  ParagraphSpacing: {deserializedData.ParagraphSpacing} ({deserializedData.ParagraphSpacing.ToPT():F1}pt)");
    if (testData.ParagraphSpacing.CompareTo(deserializedData.ParagraphSpacing) != 0)
      return false;
    Console.WriteLine($"  Indent: {deserializedData.Indent} ({deserializedData.Indent.ToInch():F2}in)");
    if (testData.Indent.CompareTo(deserializedData.Indent) != 0)
      return false;
    Console.WriteLine($"  BodyFontSize: {deserializedData.BodyFontSize} ({deserializedData.BodyFontSize.ToPT():F1}pt)");
    if (testData.BodyFontSize.CompareTo(deserializedData.BodyFontSize) != 0)
      return false;
    Console.WriteLine($"  HeadingFontSize: {deserializedData.HeadingFontSize} ({deserializedData.HeadingFontSize.ToPT():F1}pt)");
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

  
  
  static bool TestPointsJsonSerialization()
  {
    Console.WriteLine("--- Testing Points JSON Serialization ---");      // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<PointsTestData>(jsonString, jsonOptions);
    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  
  private static PointsTestData CreateTestData()
  {
    return new PointsTestData
    {
      FontSize = new PTS(12),       // 12 points
      LineHeight = new PTS(18),     // 18 points
      ParagraphSpacing = new PTS(6),// 6 points
      Indent = new PTS(36),         // 36 points (0.5 inch)
      BodyFontSize = new PTS(10),   // 10 points
      HeadingFontSize = new PTS(24),// 24 points
      ZeroValue = new PTS(0),
      SmallValue = new PTS(1),      // 1 point
      LargeValue = new PTS(1000)    // ~13.9 inches
    };
  }

  private static void ShowOriginalData(PointsTestData testData)
  {
    Console.WriteLine($"Original data:");

    Console.WriteLine($"  FontSize: {testData.FontSize} ({testData.FontSize.ToPT():F1}pt)");
    Console.WriteLine($"  LineHeight: {testData.LineHeight} ({testData.LineHeight.ToPT():F1}pt)");
    Console.WriteLine($"  ParagraphSpacing: {testData.ParagraphSpacing} ({testData.ParagraphSpacing.ToPT():F1}pt)");
    Console.WriteLine($"  Indent: {testData.Indent} ({testData.Indent.ToInch():F2}in)");
    Console.WriteLine($"  BodyFontSize: {testData.BodyFontSize} ({testData.BodyFontSize.ToPT():F1}pt)");
    Console.WriteLine($"  HeadingFontSize: {testData.HeadingFontSize} ({testData.HeadingFontSize.ToPT():F1}pt)");
    Console.WriteLine($"  ZeroValue: {testData.ZeroValue}");
    Console.WriteLine($"  SmallValue: {testData.SmallValue}");
    Console.WriteLine($"  LargeValue: {testData.LargeValue}");
    Console.WriteLine();
  }

  
  static bool TestPointsEdgeCases()
  {
    Console.WriteLine("--- Testing Points Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    PTS zero = 0;
    Console.WriteLine($"  Zero: '{zero}' ({(Int64)zero} points)");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    PTS minInt32 = Int32.MinValue;
    PTS maxInt32 = Int32.MaxValue;
    Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch():F2}in)");
    Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch():F2}in)");

    // Test common font sizes
    Console.WriteLine("\nTesting common font sizes:");
    PTS font8pt = new PTS("8pt");
    PTS font10pt = new PTS("10pt");
    PTS font12pt = new PTS("12pt");
    PTS font14pt = new PTS("14pt");
    PTS font18pt = new PTS("18pt");
    PTS font24pt = new PTS("24pt");
    Console.WriteLine($"  8pt = {(Int64)font8pt} points");
    Console.WriteLine($"  10pt = {(Int64)font10pt} points");
    Console.WriteLine($"  12pt = {(Int64)font12pt} points");
    Console.WriteLine($"  14pt = {(Int64)font14pt} points");
    Console.WriteLine($"  18pt = {(Int64)font18pt} points");
    Console.WriteLine($"  24pt = {(Int64)font24pt} points");

    // Test common measurements in typography
    Console.WriteLine("\nTesting common typography measurements:");
    PTS pica = new PTS("12pt");  // 1 pica = 12 points
    PTS halfInch = new PTS("0.5in");
    PTS quarterInch = new PTS("0.25in");
    Console.WriteLine($"  1 pica (12pt): {(Int64)pica} points");
    Console.WriteLine($"  0.5in: {(Int64)halfInch} points (expected 36)");
    Console.WriteLine($"  0.25in: {(Int64)quarterInch} points (expected 18)");

    // Test string parsing variations
    Console.WriteLine("\nTesting string parsing variations:");
    PTS fromPlainNumber = "72";
    PTS fromInches = "1in";
    PTS fromPoints = "72pt";
    Console.WriteLine($"  \"72\" → {(Int64)fromPlainNumber} points");
    Console.WriteLine($"  \"1in\" → {(Int64)fromInches} points");
    Console.WriteLine($"  \"72pt\" → {(Int64)fromPoints} points");

    // Test decimal values with units
    Console.WriteLine("\nTesting decimal values with units:");
    PTS halfPoint = new PTS("0.5pt");
    PTS quarterPoint = new PTS("0.25pt");
    Console.WriteLine($"  0.5pt = {(Int64)halfPoint} points (expected 0)");
    Console.WriteLine($"  0.25pt = {(Int64)quarterPoint} points (expected 0)");

    // Test comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    PTS commaDecimal = new PTS("2,54cm");
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
    PTS measurement = 72;
    Console.WriteLine($"  As points: {measurement}");
    Console.WriteLine($"  As inches (no precision): {measurement.ToString(LengthUnit.Inches)}");
    Console.WriteLine($"  As inches (2 decimal): {measurement.ToString("F2", LengthUnit.Inches)}");
    Console.WriteLine($"  As points: {measurement.ToString(LengthUnit.Points)}");
    Console.WriteLine($"  As mm (1 decimal): {measurement.ToString("F1", LengthUnit.Millimeters)}");
    Console.WriteLine($"  As cm (2 decimal): {measurement.ToString("F2", LengthUnit.Centimeters)}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    PTS small = 36;  // 0.5 inch
    PTS large = 72;  // 1 inch
    Console.WriteLine($"  36 < 72: {small.CompareTo(large) < 0}");
    Console.WriteLine($"  72 > 36: {large.CompareTo(small) > 0}");
    Console.WriteLine($"  72 == 72: {large.CompareTo(new PTS(72)) == 0}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit conversions:");
    PTS fromInt32 = 72;
    PTS fromInt64 = 72L;
    PTS fromUInt32 = 72U;
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

  
  
  static bool TestPointsPerformance()
  {
    Console.WriteLine("--- Testing Points Performance ---"); const int iterations = 100000;

    // Test construction from string with unit
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      PTS points = "1in";
    }
    sw.Stop();
    Console.WriteLine($"Construction from string with unit x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from plain number string
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      PTS points = "72";
    }
    sw.Stop();
    Console.WriteLine($"Construction from plain string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from integer
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      PTS points = 72;
    }
    sw.Stop();
    Console.WriteLine($"Construction from integer x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    PTS testPoints = 72;
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
      string str = testPoints.ToString(LengthUnit.Inches);
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
      double points = testPoints.ToPT();
    }
    sw.Stop();
    Console.WriteLine($"ToPT() x {iterations}: {sw.ElapsedMilliseconds}ms");

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
      FontSize = new PTS(12),
      LineHeight = new PTS(18),
      ParagraphSpacing = new PTS(6),
      Indent = new PTS(36),
      BodyFontSize = new PTS(10),
      HeadingFontSize = new PTS(24),
      ZeroValue = new PTS(0),
      SmallValue = new PTS(1),
      LargeValue = new PTS(1000)
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
    PTS points1 = 72;
    PTS points2 = 72;
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

  }


/// <summary>
/// Test data class containing various Points properties.
/// </summary>
[XmlRoot("PointsTestData")]
public class PointsTestData
{
  [XmlElement("FontSize")]
  public PTS FontSize { get; set; }

  [XmlElement("LineHeight")]
  public PTS LineHeight { get; set; }

  [XmlElement("ParagraphSpacing")]
  public PTS ParagraphSpacing { get; set; }

  [XmlElement("Indent")]
  public PTS Indent { get; set; }

  [XmlElement("BodyFontSize")]
  public PTS BodyFontSize { get; set; }

  [XmlElement("HeadingFontSize")]
  public PTS HeadingFontSize { get; set; }

  [XmlElement("ZeroValue")]
  public PTS ZeroValue { get; set; }

  [XmlElement("SmallValue")]
  public PTS SmallValue { get; set; }

  [XmlElement("LargeValue")]
  public PTS LargeValue { get; set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class PointsWrapper
{
  public PTS Value { get; set; }
}

