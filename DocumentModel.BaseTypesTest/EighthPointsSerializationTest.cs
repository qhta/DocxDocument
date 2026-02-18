using System.Globalization;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for EighthPoints type serialization in both XML and JSON formats.
/// </summary>
public static class EighthPointsSerializationTests
{
  /// <summary>
  /// Runs all EighthPoints serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== EighthPoints Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestEighthPointsBasicOperations()) return false;
    if (!TestEighthPointsUnitConversions()) return false;
    if (!TestEighthPointsXmlSerialization()) return false;
    if (!TestEighthPointsJsonSerialization()) return false;
    if (!TestEighthPointsEdgeCases()) return false;
    if (!TestEighthPointsPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestEighthPointsBasicOperations()
  {
    Console.WriteLine("--- Testing EighthPoints Basic Operations ---");      // Test string to EighthPoints conversion (plain number)
    EighthPoints ep1 = "576";
    Console.WriteLine($"\n✓ String to EighthPoints: {ep1} = {(Int64)ep1} eighth-points");

    // Test integer to EighthPoints conversion
    EighthPoints ep2 = 576;
    Console.WriteLine($"\n✓ Int to EighthPoints: {ep2}");

    // Test equality
    if (ep1.CompareTo(ep2) == 0)
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test EighthPoints to string
    string str = ep1.ToString();
    Console.WriteLine($"\n✓ EighthPoints to string: {str}");

    // Test EighthPoints to various integer types
    Int32 int32Val = (Int32)ep1;
    Int64 int64Val = (Int64)ep1;
    UInt32 uint32Val = (UInt32)ep1;
    Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {ep1.GetHashCode()}");

    // Test comparison
    EighthPoints ep3 = 1152; // 2 inches
    Console.WriteLine($"\n✓ CompareTo (576 vs 1152): {ep1.CompareTo(ep3)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Unit Conversion Tests

  static bool TestEighthPointsUnitConversions()
  {
    Console.WriteLine("--- Testing EighthPoints Unit Conversions ---");      // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    EighthPoints oneInch = "1in";
    Console.WriteLine($"  1in = {(Int64)oneInch} eighth-points (expected 576)");
    Console.WriteLine($"  576 eighth-points = {oneInch.ToInch():F2}in");
    if ((Int64)oneInch != 576)
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test point conversions
    Console.WriteLine("\nTesting point conversions:");
    EighthPoints onePoint = "1pt";
    Console.WriteLine($"  1pt = {(Int64)onePoint} eighth-points (expected 8)");
    Console.WriteLine($"  8 eighth-points = {onePoint.ToPoints():F2}pt");
    if ((Int64)onePoint != 8)
    {
      Console.WriteLine("✗ Point conversion FAILED");
      return false;
    }

    // Test eighth-point precision (unique feature)
    Console.WriteLine("\nTesting eighth-point precision:");
    EighthPoints oneEighthPoint = 1;
    EighthPoints halfPoint = 4;
    EighthPoints fullPoint = 8;
    Console.WriteLine($"  1 eighth-point = {oneEighthPoint.ToPoints():F3}pt (0.125pt)");
    Console.WriteLine($"  4 eighth-points = {halfPoint.ToPoints():F3}pt (0.5pt)");
    Console.WriteLine($"  8 eighth-points = {fullPoint.ToPoints():F3}pt (1.0pt)");

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    EighthPoints tenMM = "10mm";
    double expectedEighthPoints = 10 * EighthPoints.EighthPointsInMM;
    Console.WriteLine($"  10mm = {(Int64)tenMM} eighth-points (expected ~{expectedEighthPoints:F0})");
    Console.WriteLine($"  Back to mm: {tenMM.ToMM():F2}mm");

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    EighthPoints oneCM = "1cm";
    expectedEighthPoints = EighthPoints.EighthPointsInCM;
    Console.WriteLine($"  1cm = {(Int64)oneCM} eighth-points (expected ~{expectedEighthPoints:F0})");
    Console.WriteLine($"  Back to cm: {oneCM.ToCM():F2}cm");

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    EighthPoints original = 576; // 1 inch
    double inches = original.ToInch();
    EighthPoints roundTrip = new EighthPoints($"{inches:F6}in");
    Console.WriteLine($"  Original: {(Int64)original} eighth-points");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to eighth-points: {(Int64)roundTrip} eighth-points");
    Console.WriteLine($"  Match: {original.CompareTo(roundTrip) == 0}");

    // Test relationship between eighth-points and points
    Console.WriteLine("\nTesting eighth-point/point relationships:");
    EighthPoints twelvePoints = "12pt";
    Console.WriteLine($"  12pt = {(Int64)twelvePoints} eighth-points (expected 96)");
    Console.WriteLine($"  Back to points: {twelvePoints.ToPoints():F1}pt");

    // Test string output with units
    Console.WriteLine("\nTesting string output with units:");
    EighthPoints measurement = 576;
    Console.WriteLine($"  As eighth-points: {measurement}");
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

  #endregion

  #region XML Serialization Tests

  static bool TestEighthPointsXmlSerialization()
  {
    Console.WriteLine("--- Testing EighthPoints XML Serialization ---");      // Create test object
    var testData = new EighthPointsTestData
    {
      FontSize = new EighthPoints(96),         // 12 points
      LineHeight = new EighthPoints(144),      // 18 points
      MicroKerning = new EighthPoints(1),      // 0.125 points
      LetterSpacing = new EighthPoints(2),     // 0.25 points
      WordSpacing = new EighthPoints(8),       // 1 point
      SuperscriptOffset = new EighthPoints(40),// 5 points
      SubscriptOffset = new EighthPoints(24),  // 3 points
      BorderWidth = new EighthPoints(16),      // 2 points
      ZeroValue = new EighthPoints(0),
      SmallValue = new EighthPoints(1),        // 0.125 points
      LargeValue = new EighthPoints(8000)      // ~13.9 inches
    };

    Console.WriteLine($"Original data:");


    Console.WriteLine($"  FontSize: {testData.FontSize} ({testData.FontSize.ToPoints():F1}pt)");
    Console.WriteLine($"  LineHeight: {testData.LineHeight} ({testData.LineHeight.ToPoints():F1}pt)");
    Console.WriteLine($"  MicroKerning: {testData.MicroKerning} ({testData.MicroKerning.ToPoints():F3}pt)");
    Console.WriteLine($"  LetterSpacing: {testData.LetterSpacing} ({testData.LetterSpacing.ToPoints():F3}pt)");
    Console.WriteLine($"  WordSpacing: {testData.WordSpacing} ({testData.WordSpacing.ToPoints():F1}pt)");
    Console.WriteLine($"  SuperscriptOffset: {testData.SuperscriptOffset} ({testData.SuperscriptOffset.ToPoints():F1}pt)");
    Console.WriteLine($"  SubscriptOffset: {testData.SubscriptOffset} ({testData.SubscriptOffset.ToPoints():F1}pt)");
    Console.WriteLine($"  BorderWidth: {testData.BorderWidth} ({testData.BorderWidth.ToPoints():F1}pt)");
    Console.WriteLine($"  ZeroValue: {testData.ZeroValue}");
    Console.WriteLine($"  SmallValue: {testData.SmallValue}");
    Console.WriteLine($"  LargeValue: {testData.LargeValue}");
    Console.WriteLine();

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(EighthPointsTestData));
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
    EighthPointsTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (EighthPointsTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;

  }

  #endregion

  #region JSON Serialization Tests

  static bool TestEighthPointsJsonSerialization()
  {
    Console.WriteLine("--- Testing EighthPoints JSON Serialization ---");      // Create test object
    var testData = new EighthPointsTestData
    {
      FontSize = new EighthPoints(112),        // 14 points
      LineHeight = new EighthPoints(168),      // 21 points
      MicroKerning = new EighthPoints(2),      // 0.25 points
      LetterSpacing = new EighthPoints(4),     // 0.5 points
      WordSpacing = new EighthPoints(16),      // 2 points
      SuperscriptOffset = new EighthPoints(48),// 6 points
      SubscriptOffset = new EighthPoints(32),  // 4 points
      BorderWidth = new EighthPoints(24),      // 3 points
      ZeroValue = new EighthPoints(0),
      SmallValue = new EighthPoints(1),        // 0.125 points
      LargeValue = new EighthPoints(8000)      // ~13.9 inches
    };

    Console.WriteLine($"Original data:");


    Console.WriteLine($"  FontSize: {testData.FontSize}");
    Console.WriteLine($"  LineHeight: {testData.LineHeight}");
    Console.WriteLine($"  MicroKerning: {testData.MicroKerning}");
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
    var deserializedData = JsonSerializer.Deserialize<EighthPointsTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(EighthPointsTestData? deserializedData, EighthPointsTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    Console.WriteLine($"  FontSize: {deserializedData.FontSize}");
    if (testData.FontSize.CompareTo(deserializedData.FontSize) != 0)
      return false;
    Console.WriteLine($"  LineHeight: {deserializedData.LineHeight}");
    if (testData.LineHeight.CompareTo(deserializedData.LineHeight) != 0)
      return false;
    Console.WriteLine($"  MicroKerning: {deserializedData.MicroKerning}");
    if (testData.MicroKerning.CompareTo(deserializedData.MicroKerning) != 0)
      return false;
    Console.WriteLine($"  LetterSpacing: {deserializedData.LetterSpacing}");
    if (testData.LetterSpacing.CompareTo(deserializedData.LetterSpacing) != 0)
      return false;
    Console.WriteLine($"  WordSpacing: {deserializedData.WordSpacing}");
    if (testData.WordSpacing.CompareTo(deserializedData.WordSpacing) != 0)
      return false;
    Console.WriteLine($"  SuperscriptOffset: {deserializedData.SuperscriptOffset}");
    if (testData.SuperscriptOffset.CompareTo(deserializedData.SuperscriptOffset) != 0)
      return false;
    Console.WriteLine($"  SubscriptOffset: {deserializedData.SubscriptOffset}");
    if (testData.SubscriptOffset.CompareTo(deserializedData.SubscriptOffset) != 0)
      return false;
    Console.WriteLine($"  BorderWidth: {deserializedData.BorderWidth}");
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

  #region Edge Cases Tests

  static bool TestEighthPointsEdgeCases()
  {
    Console.WriteLine("--- Testing EighthPoints Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    EighthPoints zero = 0;
    Console.WriteLine($"  Zero: '{zero}' ({(Int64)zero} eighth-points)");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    EighthPoints minInt32 = Int32.MinValue;
    EighthPoints maxInt32 = Int32.MaxValue;
    Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch():F2}in)");
    Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch():F2}in)");

    // Test eighth-point precision (unique to EighthPoints - finest granularity)
    Console.WriteLine("\nTesting eighth-point precision (finest granularity):");
    EighthPoints oneEighth = 1;
    EighthPoints twoEighths = 2;
    EighthPoints fourEighths = 4;
    EighthPoints eightEighths = 8;
    Console.WriteLine($"  1 eighth-point = {oneEighth.ToPoints():F3}pt (0.125pt)");
    Console.WriteLine($"  2 eighth-points = {twoEighths.ToPoints():F3}pt (0.25pt)");
    Console.WriteLine($"  4 eighth-points = {fourEighths.ToPoints():F3}pt (0.5pt)");
    Console.WriteLine($"  8 eighth-points = {eightEighths.ToPoints():F3}pt (1.0pt)");

    // Test micro-adjustments (use case for eighth-points)
    Console.WriteLine("\nTesting micro-typography adjustments:");
    EighthPoints microKerning = new EighthPoints(1);     // 0.125pt
    EighthPoints fineTracking = new EighthPoints(3);     // 0.375pt
    EighthPoints preciseSpacing = new EighthPoints(5);   // 0.625pt
    Console.WriteLine($"  Micro-kerning (1 eighth-point): {microKerning.ToPoints():F3}pt");
    Console.WriteLine($"  Fine tracking (3 eighth-points): {fineTracking.ToPoints():F3}pt");
    Console.WriteLine($"  Precise spacing (5 eighth-points): {preciseSpacing.ToPoints():F3}pt");

    // Test common font sizes in eighth-points
    Console.WriteLine("\nTesting common font sizes:");
    EighthPoints font10pt = new EighthPoints(80);    // 10pt
    EighthPoints font12pt = new EighthPoints(96);    // 12pt
    EighthPoints font14pt = new EighthPoints(112);   // 14pt
    Console.WriteLine($"  10pt = {(Int64)font10pt} eighth-points");
    Console.WriteLine($"  12pt = {(Int64)font12pt} eighth-points");
    Console.WriteLine($"  14pt = {(Int64)font14pt} eighth-points");

    // Test string parsing variations
    Console.WriteLine("\nTesting string parsing variations:");
    EighthPoints fromPlainNumber = "576";
    EighthPoints fromInches = "1in";
    EighthPoints fromPoints = "12pt";
    EighthPoints fromFraction = "0.125pt";
    Console.WriteLine($"  \"576\" → {(Int64)fromPlainNumber} eighth-points");
    Console.WriteLine($"  \"1in\" → {(Int64)fromInches} eighth-points");
    Console.WriteLine($"  \"12pt\" → {(Int64)fromPoints} eighth-points");
    Console.WriteLine($"  \"0.125pt\" → {(Int64)fromFraction} eighth-points");

    // Test decimal values with units
    Console.WriteLine("\nTesting decimal values with units:");
    EighthPoints halfInch = new EighthPoints("0.5in");
    EighthPoints quarterInch = new EighthPoints("0.25in");
    Console.WriteLine($"  0.5in = {(Int64)halfInch} eighth-points (expected 288)");
    Console.WriteLine($"  0.25in = {(Int64)quarterInch} eighth-points (expected 144)");

    // Test comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    EighthPoints commaDecimal = new EighthPoints("2,54cm");
    Console.WriteLine($"  \"2,54cm\" → {(Int64)commaDecimal} eighth-points");

    // Test Deserialization from different formats
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // Numeric format
    string jsonNumeric = "{\"Value\":576}";
    var fromNumeric = JsonSerializer.Deserialize<EighthPointsWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 576: {fromNumeric?.Value}");

    // String format with unit
    string jsonStringInch = "{\"Value\":\"1in\"}";
    var fromStringInch = JsonSerializer.Deserialize<EighthPointsWrapper>(jsonStringInch);
    Console.WriteLine($"  From JSON string \"1in\": {fromStringInch?.Value}");

    // String format with point unit
    string jsonStringPt = "{\"Value\":\"12pt\"}";
    var fromStringPt = JsonSerializer.Deserialize<EighthPointsWrapper>(jsonStringPt);
    Console.WriteLine($"  From JSON string \"12pt\": {fromStringPt?.Value} (expected 96)");

    // String format without unit
    string jsonStringPlain = "{\"Value\":\"576\"}";
    var fromStringPlain = JsonSerializer.Deserialize<EighthPointsWrapper>(jsonStringPlain);
    Console.WriteLine($"  From JSON string \"576\": {fromStringPlain?.Value}");

    // Test output with units
    Console.WriteLine("\nTesting output format with different units:");
    EighthPoints measurement = 576;
    Console.WriteLine($"  As eighth-points: {measurement}");
    Console.WriteLine($"  As inches (no precision): {measurement.ToString("in")}");
    Console.WriteLine($"  As inches (3 decimal): {measurement.ToString(3, "in")}");
    Console.WriteLine($"  As points (2 decimal): {measurement.ToString(2, "pt")}");
    Console.WriteLine($"  As mm (1 decimal): {measurement.ToString(1, "mm")}");
    Console.WriteLine($"  As cm (2 decimal): {measurement.ToString(2, "cm")}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    EighthPoints small = 288;  // 0.5 inch
    EighthPoints large = 576;  // 1 inch
    Console.WriteLine($"  288 < 576: {small.CompareTo(large) < 0}");
    Console.WriteLine($"  576 > 288: {large.CompareTo(small) > 0}");
    Console.WriteLine($"  576 == 576: {large.CompareTo(new EighthPoints(576)) == 0}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit conversions:");
    EighthPoints fromInt32 = 576;
    EighthPoints fromInt64 = 576L;
    EighthPoints fromUInt32 = 576U;
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

  static bool TestEighthPointsPerformance()
  {
    Console.WriteLine("--- Testing EighthPoints Performance ---"); const int iterations = 100000;

    // Test construction from string with unit
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      EighthPoints ep = "1in";
    }
    sw.Stop();
    Console.WriteLine($"Construction from string with unit x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from plain number string
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      EighthPoints ep = "576";
    }
    sw.Stop();
    Console.WriteLine($"Construction from plain string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from integer
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      EighthPoints ep = 576;
    }
    sw.Stop();
    Console.WriteLine($"Construction from integer x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    EighthPoints testEp = 576;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testEp.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString with unit
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testEp.ToString("in");
    }
    sw.Stop();
    Console.WriteLine($"ToString(unit) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test unit conversion performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double inches = testEp.ToInch();
    }
    sw.Stop();
    Console.WriteLine($"ToInch() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double points = testEp.ToPoints();
    }
    sw.Stop();
    Console.WriteLine($"ToPoints() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double mm = testEp.ToMM();
    }
    sw.Stop();
    Console.WriteLine($"ToMM() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new EighthPointsTestData
    {
      FontSize = new EighthPoints(96),
      LineHeight = new EighthPoints(144),
      MicroKerning = new EighthPoints(1),
      LetterSpacing = new EighthPoints(2),
      WordSpacing = new EighthPoints(8),
      SuperscriptOffset = new EighthPoints(40),
      SubscriptOffset = new EighthPoints(24),
      BorderWidth = new EighthPoints(16),
      ZeroValue = new EighthPoints(0),
      SmallValue = new EighthPoints(1),
      LargeValue = new EighthPoints(8000)
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
      var obj = JsonSerializer.Deserialize<EighthPointsTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test comparison performance
    EighthPoints ep1 = 576;
    EighthPoints ep2 = 576;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int result = ep1.CompareTo(ep2);
    }
    sw.Stop();
    Console.WriteLine($"CompareTo() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test hash code performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int hash = ep1.GetHashCode();
    }
    sw.Stop();
    Console.WriteLine($"GetHashCode() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test implicit conversions performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      Int64 value = ep1;
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
/// Test data class containing various EighthPoints properties.
/// </summary>
[XmlRoot("EighthPointsTestData")]
public class EighthPointsTestData
{
  [XmlElement("FontSize")]
  public EighthPoints FontSize { get; set; }

  [XmlElement("LineHeight")]
  public EighthPoints LineHeight { get; set; }

  [XmlElement("MicroKerning")]
  public EighthPoints MicroKerning { get; set; }

  [XmlElement("LetterSpacing")]
  public EighthPoints LetterSpacing { get; set; }

  [XmlElement("WordSpacing")]
  public EighthPoints WordSpacing { get; set; }

  [XmlElement("SuperscriptOffset")]
  public EighthPoints SuperscriptOffset { get; set; }

  [XmlElement("SubscriptOffset")]
  public EighthPoints SubscriptOffset { get; set; }

  [XmlElement("BorderWidth")]
  public EighthPoints BorderWidth { get; set; }

  [XmlElement("ZeroValue")]
  public EighthPoints ZeroValue { get; set; }

  [XmlElement("SmallValue")]
  public EighthPoints SmallValue { get; set; }

  [XmlElement("LargeValue")]
  public EighthPoints LargeValue { get; set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class EighthPointsWrapper
{
  public EighthPoints Value { get; set; }
}

#endregion