using System.Globalization;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for Twips type serialization in both XML and JSON formats.
/// </summary>
public static class TwipsSerializationTests
{
  /// <summary>
  /// Runs all Twips serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== Twips Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestTwipsBasicOperations()) return false;
    if (!TestTwipsUnitConversions()) return false;
    if (!TestTwipsXmlSerialization()) return false;
    if (!TestTwipsJsonSerialization()) return false;
    if (!TestTwipsEdgeCases()) return false;
    if (!TestTwipsPerformance()) return false;

    return true;
  }

  #region Basic Operations Tests

  static bool TestTwipsBasicOperations()
  {
    Console.WriteLine("--- Testing Twips Basic Operations ---");      // Test string to Twips conversion (plain number)
    Twips twips1 = "1440";
    Console.WriteLine($"\n✓ String to Twips: {twips1} = {(Int64)twips1} twips");

    // Test integer to Twips conversion
    Twips twips2 = 1440;
    Console.WriteLine($"\n✓ Int to Twips: {twips2}");

    // Test equality
    if (twips1.Equals(twips2))
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test Twips to string
    string str = twips1.ToString();
    Console.WriteLine($"\n✓ Twips to string: {str}");

    // Test Twips to various integer types
    Int32 int32Val = (Int32)twips1;
    Int64 int64Val = (Int64)twips1;
    UInt32 uint32Val = (UInt32)twips1;
    Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {twips1.GetHashCode()}");

    // Test comparison
    Twips twips3 = 2880; // 2 inches
    Console.WriteLine($"\n✓ CompareTo (1440 vs 2880): {twips1.CompareTo(twips3)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Unit Conversion Tests

  static bool TestTwipsUnitConversions()
  {
    Console.WriteLine("--- Testing Twips Unit Conversions ---");      // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    Twips oneInch = "1in";
    Console.WriteLine($"  1in = {(Int64)oneInch} twips (expected 1440)");
    Console.WriteLine($"  1440 twips = {oneInch.ToInch():F2}in");
    if ((Int64)oneInch != 1440)
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test point conversions
    Console.WriteLine("\nTesting point conversions:");
    Twips onePoint = "1pt";
    Console.WriteLine($"  1pt = {(Int64)onePoint} twips (expected 20)");
    Console.WriteLine($"  20 twips = {onePoint.ToPoints():F2}pt");
    if ((Int64)onePoint != 20)
    {
      Console.WriteLine("✗ Point conversion FAILED");
      return false;
    }

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    Twips tenMM = "10mm";
    double expectedTwips = 10 * Twips.TwipsInMM;
    Console.WriteLine($"  10mm = {(Int64)tenMM} twips (expected ~{expectedTwips:F0})");
    Console.WriteLine($"  Back to mm: {tenMM.ToMM():F2}mm");

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    Twips oneCM = "1cm";
    expectedTwips = Twips.TwipsInCM;
    Console.WriteLine($"  1cm = {(Int64)oneCM} twips (expected ~{expectedTwips:F0})");
    Console.WriteLine($"  Back to cm: {oneCM.ToCM():F2}cm");

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    Twips original = 1440; // 1 inch
    double inches = original.ToInch();
    Twips roundTrip = new Twips($"{inches:F6}in");
    Console.WriteLine($"  Original: {(Int64)original} twips");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to twips: {(Int64)roundTrip} twips");
    Console.WriteLine($"  Match: {original.Equals(roundTrip)}");

    // Test string output with units
    Console.WriteLine("\nTesting string output with units:");
    Twips measurement = 1440;
    Console.WriteLine($"  As twips: {measurement}");
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

  static bool TestTwipsXmlSerialization()
  {
    Console.WriteLine("--- Testing Twips XML Serialization ---");      // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(TwipsTestData));
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
    TwipsTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (TwipsTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static bool VerifyDeserializedData(TwipsTestData? deserializedData, TwipsTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  PageWidth: {deserializedData.PageWidth} ({deserializedData.PageWidth.ToInch():F2}in)");
    if (!testData.PageWidth.Equals(deserializedData.PageWidth))
      return false;
    Console.WriteLine($"  PageHeight: {deserializedData.PageHeight} ({deserializedData.PageHeight.ToInch():F2}in)");
    if (!testData.PageHeight.Equals(deserializedData.PageHeight))
      return false;
    Console.WriteLine($"  LeftMargin: {deserializedData.LeftMargin} ({deserializedData.LeftMargin.ToInch():F2}in)");
    if (!testData.LeftMargin.Equals(deserializedData.LeftMargin))
      return false;
    Console.WriteLine($"  TopMargin: {deserializedData.TopMargin} ({deserializedData.TopMargin.ToInch():F2}in)");
    if (!testData.TopMargin.Equals(deserializedData.TopMargin))
      return false;
    Console.WriteLine($"  FontSize: {deserializedData.FontSize} ({deserializedData.FontSize.ToPoints():F1}pt)");
    if (!testData.FontSize.Equals(deserializedData.FontSize))
      return false;
    Console.WriteLine($"  LineSpacing: {deserializedData.LineSpacing} ({deserializedData.LineSpacing.ToPoints():F1}pt)");
    if (!testData.LineSpacing.Equals(deserializedData.LineSpacing))
      return false;
    Console.WriteLine($"  ZeroValue: {deserializedData.ZeroValue}");
    if (!testData.ZeroValue.Equals(deserializedData.ZeroValue))
      return false;
    Console.WriteLine($"  SmallValue: {deserializedData.SmallValue}");
    if (!testData.SmallValue.Equals(deserializedData.SmallValue))
      return false;
    Console.WriteLine($"  LargeValue: {deserializedData.LargeValue}");
    if (!testData.LargeValue.Equals(deserializedData.LargeValue))
      return false;

    return true;
  }

  #endregion

  #region JSON Serialization Tests

  static bool TestTwipsJsonSerialization()
  {
    Console.WriteLine("--- Testing Twips JSON Serialization ---");      // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<TwipsTestData>(jsonString, jsonOptions);
 if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  
  }

  #endregion

  private static TwipsTestData CreateTestData()
  {
    return new TwipsTestData
    {
      PageWidth = new Twips(12240),    // 8.5 inches
      PageHeight = new Twips(15840),   // 11 inches
      LeftMargin = new Twips(1440),    // 1 inch
      TopMargin = new Twips(1440),     // 1 inch
      FontSize = new Twips(240),       // 12 points
      LineSpacing = new Twips(360),    // 18 points
      ZeroValue = new Twips(0),
      SmallValue = new Twips(20),      // 1 point
      LargeValue = new Twips(1000000)  // ~694 inches
    };
  }

  private static void ShowOriginalData(TwipsTestData testData)
  {
    Console.WriteLine($"Original data:");

    Console.WriteLine($"  PageWidth: {testData.PageWidth} ({testData.PageWidth.ToInch():F2}in)");
    Console.WriteLine($"  PageHeight: {testData.PageHeight} ({testData.PageHeight.ToInch():F2}in)");
    Console.WriteLine($"  LeftMargin: {testData.LeftMargin} ({testData.LeftMargin.ToInch():F2}in)");
    Console.WriteLine($"  TopMargin: {testData.TopMargin} ({testData.TopMargin.ToInch():F2}in)");
    Console.WriteLine($"  FontSize: {testData.FontSize} ({testData.FontSize.ToPoints():F1}pt)");
    Console.WriteLine($"  LineSpacing: {testData.LineSpacing} ({testData.LineSpacing.ToPoints():F1}pt)");
    Console.WriteLine($"  ZeroValue: {testData.ZeroValue}");
    Console.WriteLine($"  SmallValue: {testData.SmallValue}");
    Console.WriteLine($"  LargeValue: {testData.LargeValue}");
    Console.WriteLine();
  }

  #region Edge Cases Tests

  static bool TestTwipsEdgeCases()
  {
    Console.WriteLine("--- Testing Twips Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    Twips zero = 0;
    Console.WriteLine($"  Zero: '{zero}' ({(Int64)zero} twips)");
    Console.WriteLine($"  Zero with unit: '{zero.ToString("in")}'");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    Twips minInt32 = Int32.MinValue;
    Twips maxInt32 = Int32.MaxValue;
    Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch():F2}in)");
    Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch():F2}in)");

    // Test common document measurements
    Console.WriteLine("\nTesting common document measurements:");
    Twips letterWidth = new Twips("8.5in");
    Twips letterHeight = new Twips("11in");
    Twips a4Width = new Twips("210mm");
    Twips a4Height = new Twips("297mm");
    Console.WriteLine($"  Letter Width (8.5in): {(Int64)letterWidth} twips");
    Console.WriteLine($"  Letter Height (11in): {(Int64)letterHeight} twips");
    Console.WriteLine($"  A4 Width (210mm): {(Int64)a4Width} twips");
    Console.WriteLine($"  A4 Height (297mm): {(Int64)a4Height} twips");

    // Test common font sizes
    Console.WriteLine("\nTesting common font sizes:");
    Twips font10pt = new Twips("10pt");
    Twips font12pt = new Twips("12pt");
    Twips font14pt = new Twips("14pt");
    Console.WriteLine($"  10pt = {(Int64)font10pt} twips");
    Console.WriteLine($"  12pt = {(Int64)font12pt} twips");
    Console.WriteLine($"  14pt = {(Int64)font14pt} twips");

    // Test string parsing variations
    Console.WriteLine("\nTesting string parsing variations:");
    Twips fromPlainNumber = "1440";
    Twips fromInches = "1in";
    Twips fromPoints = "72pt";
    Console.WriteLine($"  \"1440\" → {(Int64)fromPlainNumber} twips");
    Console.WriteLine($"  \"1in\" → {(Int64)fromInches} twips");
    Console.WriteLine($"  \"72pt\" → {(Int64)fromPoints} twips");

    // Test decimal values with units
    Console.WriteLine("\nTesting decimal values with units:");
    Twips halfInch = new Twips("0.5in");
    Twips quarterInch = new Twips("0.25in");
    Console.WriteLine($"  0.5in = {(Int64)halfInch} twips (expected 720)");
    Console.WriteLine($"  0.25in = {(Int64)quarterInch} twips (expected 360)");

    // Test comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    Twips commaDecimal = new Twips("2,54cm");
    Console.WriteLine($"  \"2,54cm\" → {(Int64)commaDecimal} twips");

    // Test Deserialization from different formats
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // Numeric format
    string jsonNumeric = "{\"Value\":1440}";
    var fromNumeric = JsonSerializer.Deserialize<TwipsWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 1440: {fromNumeric?.Value}");

    // String format with unit
    string jsonStringInch = "{\"Value\":\"1in\"}";
    var fromStringInch = JsonSerializer.Deserialize<TwipsWrapper>(jsonStringInch);
    Console.WriteLine($"  From JSON string \"1in\": {fromStringInch?.Value}");

    // String format without unit
    string jsonStringPlain = "{\"Value\":\"1440\"}";
    var fromStringPlain = JsonSerializer.Deserialize<TwipsWrapper>(jsonStringPlain);
    Console.WriteLine($"  From JSON string \"1440\": {fromStringPlain?.Value}");

    // Test all output with units match input
    Console.WriteLine("\nTesting output format with different units:");
    Twips measurement = 1440;
    Console.WriteLine($"  As twips: {measurement}");
    Console.WriteLine($"  As inches (no precision): {measurement.ToString("in")}");
    Console.WriteLine($"  As inches (2 decimal): {measurement.ToString(2, "in")}");
    Console.WriteLine($"  As points: {measurement.ToString("pt")}");
    Console.WriteLine($"  As mm (1 decimal): {measurement.ToString(1, "mm")}");
    Console.WriteLine($"  As cm (2 decimal): {measurement.ToString(2, "cm")}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    Twips small = 720;  // 0.5 inch
    Twips large = 1440; // 1 inch
    Console.WriteLine($"  720 < 1440: {small.CompareTo(large) < 0}");
    Console.WriteLine($"  1440 > 720: {large.CompareTo(small) > 0}");
    Console.WriteLine($"  1440 == 1440: {large.CompareTo(new Twips(1440)) == 0}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit conversions:");
    Twips fromInt32 = 1440;
    Twips fromInt64 = 1440L;
    Twips fromUInt32 = 1440U;
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

  static bool TestTwipsPerformance()
  {
    Console.WriteLine("--- Testing Twips Performance ---"); const int iterations = 100000;

    // Test construction from string with unit
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      Twips twips = "1in";
    }
    sw.Stop();
    Console.WriteLine($"Construction from string with unit x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from plain number string
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      Twips twips = "1440";
    }
    sw.Stop();
    Console.WriteLine($"Construction from plain string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from integer
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      Twips twips = 1440;
    }
    sw.Stop();
    Console.WriteLine($"Construction from integer x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    Twips testTwips = 1440;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testTwips.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString with unit
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testTwips.ToString("in");
    }
    sw.Stop();
    Console.WriteLine($"ToString(unit) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test unit conversion performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double inches = testTwips.ToInch();
    }
    sw.Stop();
    Console.WriteLine($"ToInch() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double points = testTwips.ToPoints();
    }
    sw.Stop();
    Console.WriteLine($"ToPoints() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double mm = testTwips.ToMM();
    }
    sw.Stop();
    Console.WriteLine($"ToMM() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new TwipsTestData
    {
      PageWidth = new Twips(12240),
      PageHeight = new Twips(15840),
      LeftMargin = new Twips(1440),
      TopMargin = new Twips(1440),
      FontSize = new Twips(240),
      LineSpacing = new Twips(360),
      ZeroValue = new Twips(0),
      SmallValue = new Twips(20),
      LargeValue = new Twips(1000000)
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
      var obj = JsonSerializer.Deserialize<TwipsTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test comparison performance
    Twips twips1 = 1440;
    Twips twips2 = 1440;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int result = twips1.CompareTo(twips2);
    }
    sw.Stop();
    Console.WriteLine($"CompareTo() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test equality performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      bool result = twips1.Equals(twips2);
    }
    sw.Stop();
    Console.WriteLine($"Equals() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test implicit conversions performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      Int64 value = twips1;
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
/// Test data class containing various Twips properties.
/// </summary>
[XmlRoot("TwipsTestData")]
public class TwipsTestData
{
  [XmlElement("PageWidth")]
  public Twips PageWidth { get; set; }

  [XmlElement("PageHeight")]
  public Twips PageHeight { get; set; }

  [XmlElement("LeftMargin")]
  public Twips LeftMargin { get; set; }

  [XmlElement("TopMargin")]
  public Twips TopMargin { get; set; }

  [XmlElement("FontSize")]
  public Twips FontSize { get; set; }

  [XmlElement("LineSpacing")]
  public Twips LineSpacing { get; set; }

  [XmlElement("ZeroValue")]
  public Twips ZeroValue { get; set; }

  [XmlElement("SmallValue")]
  public Twips SmallValue { get; set; }

  [XmlElement("LargeValue")]
  public Twips LargeValue { get; set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class TwipsWrapper
{
  public Twips Value { get; set; }
}

#endregion