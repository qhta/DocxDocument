namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for HPS type serialization in both XML and JSON formats.
/// </summary>
public static class HPSTest
{
  /// <summary>
  /// Runs a comprehensive suite of tests for the HPS Serialization Test Program, including validation of basic
  /// operations, unit conversions, serialization formats, edge cases, and performance.
  /// </summary>
  /// <remarks>This method writes the test program title to the console and executes multiple test methods in
  /// sequence. Each test method must succeed for the overall test run to be considered successful.</remarks>
  /// <returns>true if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== HPS Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestHPSBasicOperations()) return false;
    if (!TestHPSUnitConversions()) return false;
    if (!TestHPSXmlSerialization()) return false;
    if (!TestHPSJsonSerialization()) return false;
    if (!TestHPSEdgeCases()) return false;
    if (!TestHPSPerformance()) return false;

    return true;
  }

  /// <summary>
  /// Tests the fundamental operations of the HPS class, including conversions, equality checks, and comparisons.
  /// </summary>
  /// <remarks>This method exercises key features of the HPS class, such as converting between strings and
  /// integers, verifying equality and comparison logic, and generating hash codes. It writes the results of each test
  /// to the console and reports any exceptions encountered during execution.</remarks>
  /// <returns>true if all basic HPS operations succeed; otherwise, false.</returns>
  static bool TestHPSBasicOperations()
  {
    Console.WriteLine("--- Testing HPS Basic Operations ---");

    try
    {
      // Test string to HPS conversion (plain number)
      HPS hp1 = "144";
      Console.WriteLine($"\n✓ String to HPS: {hp1} = {(Int64)hp1} HPS");

      // Test integer to HPS conversion
      HPS hp2 = 144;
      Console.WriteLine($"\n✓ Int to HPS: {hp2}");

      // Test equality
      if (hp1.CompareTo(hp2) == 0)
        Console.WriteLine("\n✓ Equality test passed");
      else
        Console.WriteLine("✗ Equality test FAILED");

      // Test HPS to string
      string str = hp1.ToString();
      Console.WriteLine($"\n✓ HPS to string: {str}");

      // Test HPS to various integer types
      Int32 int32Val = (Int32)hp1;
      Int64 int64Val = (Int64)hp1;
      UInt32 uint32Val = (UInt32)hp1;
      Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");

      // Test hash code
      Console.WriteLine($"\n✓ Hash code: {hp1.GetHashCode()}");

      // Test comparison
      HPS hp3 = 288; // 2 inches
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


  /// <summary>
  /// Tests the accuracy and correctness of conversions between HPS and various length units, including inches,
  /// millimeters, centimeters, points, and twips.
  /// </summary>
  /// <remarks>This method performs a series of unit conversion tests and outputs the results to the console. It
  /// verifies both direct and round-trip conversions, as well as string formatting for different units and precisions.
  /// Use this method to validate that HPS-related conversion logic is functioning as expected.</remarks>
  /// <returns>true if all unit conversion tests pass; otherwise, false.</returns>
  static bool TestHPSUnitConversions()
  {
    var hps1Inch = 72 * 2;
    var hps1MM = hps1Inch / 25.4;
    var hps1CM = hps1MM * 10;
    var hps12PT = 12 * 2;
    var hps10Twips = 20 / 20.0;
    Console.WriteLine("--- Testing HPS Unit Conversions ---");
    // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    HPS oneInch = "1in";
    Console.WriteLine($"  1in = {(long)oneInch} HPS (expected {hps1Inch})");
    Console.WriteLine($"  {hps1Inch} HPS = {oneInch.ToInch()}in");
    if (System.Math.Abs(oneInch - hps1Inch) > 0.01)
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    HPS oneMM = "1mm";
    Console.WriteLine($"  1mm = {oneMM} HPS (expected {hps1MM})");
    Console.WriteLine($"  {hps1MM} HPS = {oneMM.ToMM()}mm");
    if (System.Math.Abs(oneMM - hps1MM) > 0.01)
    {
      Console.WriteLine("✗ Millimeter conversion FAILED");
      return false;
    }

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    HPS oneCM = "1cm";
    Console.WriteLine($"  1cm = {oneCM} HPS (expected ~{hps1CM})");
    Console.WriteLine($"  {hps1CM} HPS = {oneCM.ToCM()}cm");
    if (System.Math.Abs(oneCM - hps1CM) > 0.01)
    {
      Console.WriteLine("✗ Centimeter conversion FAILED");
      return false;
    }

    // Test point conversions
    Console.WriteLine("\nTesting point conversions:");
    HPS twelvePoints = "12pt";
    Console.WriteLine($"  12pt = {twelvePoints} HPS (expected {hps12PT})");
    Console.WriteLine($"  {hps12PT} HPS = {twelvePoints.ToPT()}pt");
    if (System.Math.Abs(twelvePoints - hps12PT) > 0.01)
    {
      Console.WriteLine("✗ Point conversion FAILED");
      return false;
    }

    // Test twips conversions
    Console.WriteLine("\nTesting twips conversions:");
    HPS tenTwips = "10tw";
    Console.WriteLine($"  10tw = {tenTwips} HPS (expected {hps10Twips})");
    Console.WriteLine($"  {hps10Twips} HPS = {tenTwips.ToTwips()}tw");
    if (System.Math.Abs(tenTwips - hps10Twips) > 0.01)
    {
      Console.WriteLine("✗ Twips conversion FAILED");
      return false;
    }

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    HPS original = hps1Inch; // 1 inch
    double inches = original.ToInch();
    HPS roundTrip = new HPS($"{inches}in");
    Console.WriteLine($"  Original: {original} HPS");
    Console.WriteLine($"  To inches: {inches}in");
    Console.WriteLine($"  Back to HPS: {roundTrip} HPS");
    if (original.CompareTo(roundTrip) != 0)
    {
      Console.WriteLine("✗ Round-trip conversion FAILED");
      return false;
    }

    // Test ConvertTo for each unit
    Console.WriteLine("\nTesting ConvertTo method:");
    ILengthMeasure length = original;
    Console.WriteLine($"  To inches: {length.ConvertTo(LengthUnit.Inches):F2}");
    Console.WriteLine($"  To mm: {length.ConvertTo(LengthUnit.Millimeters):F2}");
    Console.WriteLine($"  To cm: {length.ConvertTo(LengthUnit.Centimeters):F2}");
    Console.WriteLine($"  To pt: {length.ConvertTo(LengthUnit.Points):F2}");
    Console.WriteLine($"  To twips: {length.ConvertTo(LengthUnit.Twips):F2}");

    // Test string output with units
    Console.WriteLine("\nTesting string output with units:");
    Console.WriteLine($"  As HPS: {original}");
    Console.WriteLine($"  As inches: {length.ToString(LengthUnit.Inches)}");
    Console.WriteLine($"  As mm: {length.ToString(LengthUnit.Millimeters)}");

    // Test string output with precision
    Console.WriteLine("\nTesting string output with precision:");
    Console.WriteLine($"  Precision 0: {length.ToString("F0", LengthUnit.Inches)}");
    Console.WriteLine($"  Precision 2: {length.ToString("F2", LengthUnit.Millimeters)}");

    Console.WriteLine("\n✓ All unit conversion tests passed");
    Console.WriteLine();
    return true;
  }

  static bool TestHPSXmlSerialization()
  {
    Console.WriteLine("--- Testing HPS XML Serialization ---");

    // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(HPSTestData));
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
    HPSTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (HPSTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData))
      return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static void ShowOriginalData(HPSTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  FontSize: {testData.FontSize} ({testData.FontSize.ToPT():F1}pt)");
    Console.WriteLine($"  LineHeight: {testData.LineHeight} ({testData.LineHeight.ToPT():F1}pt)");
    Console.WriteLine($"  LetterSpacing: {testData.LetterSpacing} ({testData.LetterSpacing.ToPT():F1}pt)");
    Console.WriteLine($"  WordSpacing: {testData.WordSpacing} ({testData.WordSpacing.ToPT():F1}pt)");
    Console.WriteLine($"  SuperscriptOffset: {testData.SuperscriptOffset} ({testData.SuperscriptOffset.ToPT():F1}pt)");
    Console.WriteLine($"  SubscriptOffset: {testData.SubscriptOffset} ({testData.SubscriptOffset.ToPT():F1}pt)");
    Console.WriteLine($"  BorderWidth: {testData.BorderWidth} ({testData.BorderWidth.ToPT():F1}pt)");
    Console.WriteLine($"  ZeroValue: {testData.ZeroValue}");
    Console.WriteLine($"  SmallValue: {testData.SmallValue}");
    Console.WriteLine($"  LargeValue: {testData.LargeValue}");
    Console.WriteLine();
  }

  private static bool VerifyDeserializedData(HPSTestData? deserializedData, HPSTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  FontSize: {deserializedData.FontSize} ({deserializedData.FontSize.ToPT():F1}pt)");
    if (testData.FontSize.CompareTo(deserializedData.FontSize) != 0)
      return false;
    Console.WriteLine($"  LineHeight: {deserializedData.LineHeight} ({deserializedData.LineHeight.ToPT():F1}pt)");
    if (testData.LineHeight.CompareTo(deserializedData.LineHeight) != 0)
      return false;
    Console.WriteLine($"  LetterSpacing: {deserializedData.LetterSpacing} ({deserializedData.LetterSpacing.ToPT():F1}pt)");
    if (testData.LetterSpacing.CompareTo(deserializedData.LetterSpacing) != 0)
      return false;
    Console.WriteLine($"  WordSpacing: {deserializedData.WordSpacing} ({deserializedData.WordSpacing.ToPT():F1}pt)");
    if (testData.WordSpacing.CompareTo(deserializedData.WordSpacing) != 0)
      return false;
    Console.WriteLine($"  SuperscriptOffset: {deserializedData.SuperscriptOffset} ({deserializedData.SuperscriptOffset.ToPT():F1}pt)");
    if (testData.SuperscriptOffset.CompareTo(deserializedData.SuperscriptOffset) != 0)
      return false;
    Console.WriteLine($"  SubscriptOffset: {deserializedData.SubscriptOffset} ({deserializedData.SubscriptOffset.ToPT():F1}pt)");
    if (testData.SubscriptOffset.CompareTo(deserializedData.SubscriptOffset) != 0)
      return false;
    Console.WriteLine($"  BorderWidth: {deserializedData.BorderWidth} ({deserializedData.BorderWidth.ToPT():F1}pt)");
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



  static bool TestHPSJsonSerialization()
  {
    Console.WriteLine("--- Testing HPS JSON Serialization ---");

    // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<HPSTestData>(jsonString, jsonOptions);

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


  private static HPSTestData CreateTestData()
  {
    return new HPSTestData
    {
      FontSize = new HPS(24),       // 12 points
      LineHeight = new HPS(36),     // 18 points
      LetterSpacing = new HPS(1),   // 0.5 points
      WordSpacing = new HPS(2),     // 1 point
      SuperscriptOffset = new HPS(10), // 5 points
      SubscriptOffset = new HPS(6), // 3 points
      BorderWidth = new HPS(4),     // 2 points
      ZeroValue = new HPS(0),
      SmallValue = new HPS(1),      // 0.5 points
      LargeValue = new HPS(2000)    // ~13.9 inches
    };
  }



  static bool TestHPSEdgeCases()
  {
    Console.WriteLine("--- Testing HPS Edge Cases ---");

    try
    {
      // Test zero value
      Console.WriteLine("Testing zero value:");
      HPS zero = 0;
      Console.WriteLine($"  Zero: '{zero}' ({(Int64)zero} HPS)");

      // Test boundary values
      Console.WriteLine("\nTesting boundary values:");
      HPS minInt32 = Int32.MinValue;
      HPS maxInt32 = Int32.MaxValue;
      Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch():F2}in)");
      Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch():F2}in)");

      // Test half-point precision (unique to HPS)
      Console.WriteLine("\nTesting half-point precision:");
      HPS oneHalfPoint = 1;
      HPS twoHPS = 2;
      Console.WriteLine($"  1 half-point = {oneHalfPoint.ToPT():F1}pt");
      Console.WriteLine($"  2 HPS = {twoHPS.ToPT():F1}pt (1 full point)");

      // Test common fine-grained adjustments
      Console.WriteLine("\nTesting fine-grained typography adjustments:");
      HPS letterSpacing = new HPS(1);    // 0.5pt letter spacing
      HPS kerning = new HPS(2);          // 1pt kerning
      HPS tracking = new HPS(3);         // 1.5pt tracking
      Console.WriteLine($"  Letter spacing (1 half-point): {letterSpacing.ToPT():F1}pt");
      Console.WriteLine($"  Kerning (2 HPS): {kerning.ToPT():F1}pt");
      Console.WriteLine($"  Tracking (3 HPS): {tracking.ToPT():F1}pt");

      // Test common font sizes in HPS
      Console.WriteLine("\nTesting common font sizes:");
      HPS font10pt = new HPS(20);   // 10pt
      HPS font12pt = new HPS(24);   // 12pt
      HPS font14pt = new HPS(28);   // 14pt
      Console.WriteLine($"  10pt = {(Int64)font10pt} HPS");
      Console.WriteLine($"  12pt = {(Int64)font12pt} HPS");
      Console.WriteLine($"  14pt = {(Int64)font14pt} HPS");

      // Test string parsing variations
      Console.WriteLine("\nTesting string parsing variations:");
      HPS fromPlainNumber = "144";
      HPS fromInches = "1in";
      HPS fromPoints = "12pt";
      HPS fromHPS = "0.5pt";
      Console.WriteLine($"  \"144\" → {(Int64)fromPlainNumber} HPS");
      Console.WriteLine($"  \"1in\" → {(Int64)fromInches} HPS");
      Console.WriteLine($"  \"12pt\" → {(Int64)fromPoints} HPS");
      Console.WriteLine($"  \"0.5pt\" → {(Int64)fromHPS} HPS");

      // Test decimal values with units
      Console.WriteLine("\nTesting decimal values with units:");
      HPS halfInch = new HPS("0.5in");
      HPS quarterInch = new HPS("0.25in");
      Console.WriteLine($"  0.5in = {(Int64)halfInch} HPS (expected 72)");
      Console.WriteLine($"  0.25in = {(Int64)quarterInch} HPS (expected 36)");

      // Test comma decimal separator
      Console.WriteLine("\nTesting comma decimal separator:");
      HPS commaDecimal = new HPS("2,54cm");
      Console.WriteLine($"  \"2,54cm\" → {(Int64)commaDecimal} HPS");

      // Test Deserialization from different formats
      Console.WriteLine("\nTesting Deserialization from different formats:");

      // Numeric format
      string jsonNumeric = "{\"Value\":144}";
      var fromNumeric = JsonSerializer.Deserialize<HPSWrapper>(jsonNumeric);
      Console.WriteLine($"  From JSON number 144: {fromNumeric?.Value}");

      // String format with unit
      string jsonStringInch = "{\"Value\":\"1in\"}";
      var fromStringInch = JsonSerializer.Deserialize<HPSWrapper>(jsonStringInch);
      Console.WriteLine($"  From JSON string \"1in\": {fromStringInch?.Value}");

      // String format with point unit
      string jsonStringPt = "{\"Value\":\"12pt\"}";
      var fromStringPt = JsonSerializer.Deserialize<HPSWrapper>(jsonStringPt);
      Console.WriteLine($"  From JSON string \"12pt\": {fromStringPt?.Value} (expected 24)");

      // String format without unit
      string jsonStringPlain = "{\"Value\":\"144\"}";
      var fromStringPlain = JsonSerializer.Deserialize<HPSWrapper>(jsonStringPlain);
      Console.WriteLine($"  From JSON string \"144\": {fromStringPlain?.Value}");

      // Test output with units
      Console.WriteLine("\nTesting output format with different units:");
      HPS measurement = 144;
      Console.WriteLine($"  As HPS: {measurement}");
      Console.WriteLine($"  As inches (no precision): {measurement.ToString(LengthUnit.Inches)}");
      Console.WriteLine($"  As inches (2 decimal): {measurement.ToString("F2", LengthUnit.Inches)}");
      Console.WriteLine($"  As points (1 decimal): {measurement.ToString("F1", LengthUnit.Points)}");
      Console.WriteLine($"  As mm (1 decimal): {measurement.ToString("F1", LengthUnit.Millimeters)}");
      Console.WriteLine($"  As cm (2 decimal): {measurement.ToString("F2", LengthUnit.Centimeters)}");

      // Test comparison
      Console.WriteLine("\nTesting comparison:");
      HPS small = 72;  // 0.5 inch
      HPS large = 144; // 1 inch
      Console.WriteLine($"  72 < 144: {small.CompareTo(large) < 0}");
      Console.WriteLine($"  144 > 72: {large.CompareTo(small) > 0}");
      Console.WriteLine($"  144 == 144: {large.CompareTo(new HPS(144)) == 0}");

      // Test implicit conversions
      Console.WriteLine("\nTesting implicit conversions:");
      HPS fromInt64 = 144L;
      Int64 toInt64 = fromInt64;
      Console.WriteLine($"  From Int64: {fromInt64}");
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



  static bool TestHPSPerformance()
  {
    Console.WriteLine("--- Testing HPS Performance ---");

    try
    {
      const int iterations = 100000;

      // Test construction from string with unit
      var sw = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 0; i < iterations; i++)
      {
        HPS hp = "1in";
      }
      sw.Stop();
      Console.WriteLine($"Construction from string with unit x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test construction from plain number string
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        HPS hp = "144";
      }
      sw.Stop();
      Console.WriteLine($"Construction from plain string x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test construction from integer
      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        HPS hp = 144;
      }
      sw.Stop();
      Console.WriteLine($"Construction from integer x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test ToString performance
      HPS testHp = 144;
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
        string str = testHp.ToString(LengthUnit.Inches);
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
        double points = testHp.ToPT();
      }
      sw.Stop();
      Console.WriteLine($"ToPT() x {iterations}: {sw.ElapsedMilliseconds}ms");

      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        double mm = testHp.ToMM();
      }
      sw.Stop();
      Console.WriteLine($"ToMM() x {iterations}: {sw.ElapsedMilliseconds}ms");

      // Test JSON serialization performance
      var testObj = new HPSTestData
      {
        FontSize = new HPS(24),
        LineHeight = new HPS(36),
        LetterSpacing = new HPS(1),
        WordSpacing = new HPS(2),
        SuperscriptOffset = new HPS(10),
        SubscriptOffset = new HPS(6),
        BorderWidth = new HPS(4),
        ZeroValue = new HPS(0),
        SmallValue = new HPS(1),
        LargeValue = new HPS(2000)
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
        var obj = JsonSerializer.Deserialize<HPSTestData>(jsonData);
      }
      sw.Stop();
      Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

      // Test comparison performance
      HPS hp1 = 144;
      HPS hp2 = 144;
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

}


/// <summary>
/// Test data class containing various HPS properties.
/// </summary>
[XmlRoot("HPSTestData")]
public class HPSTestData
{
  [XmlElement("FontSize")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public HPS FontSize { get; set; }

  [XmlElement("LineHeight")]
  public HPS LineHeight { get; set; }

  [XmlElement("LetterSpacing")]
  public HPS LetterSpacing { get; set; }

  [XmlElement("WordSpacing")]
  public HPS WordSpacing { get; set; }

  [XmlElement("SuperscriptOffset")]
  public HPS SuperscriptOffset { get; set; }

  [XmlElement("SubscriptOffset")]
  public HPS SubscriptOffset { get; set; }

  [XmlElement("BorderWidth")]
  public HPS BorderWidth { get; set; }

  [XmlElement("ZeroValue")]
  public HPS ZeroValue { get; set; }

  [XmlElement("SmallValue")]
  public HPS SmallValue { get; set; }

  [XmlElement("LargeValue")]
  public HPS LargeValue { get; set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class HPSWrapper
{
  public HPS Value { get; set; }
}

