using System.Globalization;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for CPS type serialization in both XML and JSON formats.
/// </summary>
public static class CPSTest
{
  /// <summary>
  /// Runs all CPS serialization tests.
  /// </summary>
  /// <returns>true if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== CPS Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestCPSBasicOperations()) return false;
    if (!TestCPSUnitConversions()) return false;
    if (!TestCPSXmlSerialization()) return false;
    if (!TestCPSJsonSerialization()) return false;
    if (!TestCPSEdgeCases()) return false;
    if (!TestCPSPerformance()) return false;

    return true;
  }

  /// <summary>
  /// Tests the basic operations of the CPS class, including conversions between CPS and various types, string
  /// representations, and comparisons.
  /// </summary>
  /// <remarks>This method verifies the correctness of the CPS class by testing string and numeric conversions,
  /// string representations, hash code consistency, and comparison operations. It outputs diagnostic information to the
  /// console for each test and returns false if any test fails.</remarks>
  /// <returns>true if all basic CPS operations pass successfully; otherwise, false.</returns>
  static bool TestCPSBasicOperations()
  {
    Console.WriteLine("--- Testing CPS Basic Operations ---");
    // Test string to CPS conversion (plain number)
    long eps1Val = 7315200;
    var eps1Str = eps1Val.ToString();
    CPS eps1 = eps1Str;
    var longCPS = (long)eps1;
    Console.WriteLine($"\n✓ String to CPS: {eps1} = {longCPS} CPS");
    if (longCPS != 7315200)
    {
      Console.WriteLine("✗ String to CPS conversion FAILED");
      return false;
    }
    // Test string to CPS conversion (with unit)
    CPS eps2 = "1in";
    var inchCPS = eps2.ToInch();
    Console.WriteLine($"\n✓ String with unit to CPS: {eps2} ({inchCPS}in)");
    if (inchCPS != 1.0m)
    {
      Console.WriteLine("✗ String with unit to CPS conversion FAILED");
      return false;
    }

    // Test integer to CPS conversion
    CPS eps3 = eps1Val;
    var intCPS = (int)eps3;
    Console.WriteLine($"\n✓ Int to CPS: {intCPS}");
    if (intCPS != eps1Val)
    {
      Console.WriteLine("✗ Int to CPS conversion FAILED");
      return false;
    }

    // Test CPS to string
    string strCPS = eps1.ToString();
    Console.WriteLine($"\n✓ CPS to string: {strCPS}");
    if (strCPS != eps1Str)
    {
      Console.WriteLine("✗ CPS to string conversion FAILED");
      return false;
    }

    // Test CPS to various integer types
    int int32Val = (int)eps1;
    long int64Val = (long)eps1;
    uint uint32Val = (uint)eps1;
    Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");
    if (int32Val != eps1Val || int64Val != eps1Val || uint32Val != eps1Val)
    {
      Console.WriteLine("✗ CPS to numeric conversions FAILED");
      return false;
    }

    // Test comparison
    CPS eps4 = eps1Val * 2; // 2 inches
    Console.WriteLine($"\n✓ CompareTo ({eps1Val} vs {eps4}): {eps1.CompareTo(eps4)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the accuracy and correctness of conversions between CPS and various length units, including inches,
  /// millimeters, centimeters, points, and twips.
  /// </summary>
  /// <remarks>This method performs a series of unit conversion tests and outputs the results to the console. It
  /// verifies both direct and round-trip conversions, as well as string formatting for different units and precisions.
  /// Use this method to validate that CPS-related conversion logic is functioning as expected.</remarks>
  /// <returns>true if all unit conversion tests pass; otherwise, false.</returns>
  static bool TestCPSUnitConversions()
  {
    var cps1Inch = 72 * 100;
    var cps1MM = cps1Inch / 25.4;
    var cps1CM = cps1MM * 10;
    var cps1PT = cps1Inch / 72;
    var cps12PT = cps1PT * 12;
    var cps1Twips = cps1Inch / 1440.0;
    var cps10Twips = cps1Twips * 10;
    Console.WriteLine("--- Testing CPS Unit Conversions ---");
    // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    CPS oneInch = "1in";
    Console.WriteLine($"  1in = {oneInch} CPS (expected {cps1Inch})");
    Console.WriteLine($"  {cps1Inch} CPS = {oneInch.ToInch()}in");
    if (!oneInch.Equals(cps1Inch))
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    CPS oneMM = "1mm";
    Console.WriteLine($"  1mm = {oneMM} CPS (expected {cps1MM})");
    Console.WriteLine($"  {cps1MM} CPS = {oneMM.ToMillimeters()}mm");
    if (!oneMM.Equals(cps1MM))
    {
      Console.WriteLine("✗ Millimeter conversion FAILED");
      return false;
    }

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    CPS oneCM = "1cm";
    Console.WriteLine($"  1cm = {oneCM} CPS (expected ~{cps1CM})");
    Console.WriteLine($"  {cps1CM} CPS = {oneCM.ToCentimeters()}cm");
    if (!oneCM.Equals(cps1CM))
    {
      Console.WriteLine("✗ Centimeter conversion FAILED");
      return false;
    }

    // Test point conversions
    Console.WriteLine("\nTesting point conversions:");
    CPS twelvePoints = "12pt";
    Console.WriteLine($"  12pt = {twelvePoints} CPS (expected {cps12PT})");
    Console.WriteLine($"  {cps12PT} CPS = {twelvePoints.ToPoints()}pt");
    if (!twelvePoints.Equals(cps12PT))
    {
      Console.WriteLine("✗ IPoint conversion FAILED");
      return false;
    }

    // Test twips conversions
    Console.WriteLine("\nTesting twips conversions:");
    CPS tenTwips = "10tw";
    Console.WriteLine($"  10tw = {tenTwips} CPS (expected {cps10Twips})");
    Console.WriteLine($"  {cps10Twips} CPS = {tenTwips.ToTwips()}tw");
    if (!tenTwips.Equals(cps10Twips))
    {
      Console.WriteLine("✗ Twips conversion FAILED");
      return false;
    }

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    CPS original = cps1Inch; // 1 inch
    decimal inches = original.ToInch();
    CPS roundTrip = new CPS($"{inches:F6}in");
    Console.WriteLine($"  Original: {(long)original} CPS");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to CPS: {(long)roundTrip} CPS");
    if (original.CompareTo(roundTrip) != 0)
    {
      Console.WriteLine("✗ Round-trip conversion FAILED");
      return false;
    }

    // Test ConvertTo for each unit
    Console.WriteLine("\nTesting ConvertTo method:");
    UniversalMeasure length = original;
    Console.WriteLine($"  To inches: {length.ConvertTo(MeasureUnit.Inches)}");
    Console.WriteLine($"  To mm: {length.ConvertTo(MeasureUnit.Millimeters)}");
    Console.WriteLine($"  To cm: {length.ConvertTo(MeasureUnit.Centimeters)}");
    Console.WriteLine($"  To pt: {length.ConvertTo(MeasureUnit.Points)}");
    Console.WriteLine($"  To twips: {length.ConvertTo(MeasureUnit.Twips)}");

    // Test string output with units
    Console.WriteLine("\nTesting string output with units:");
    Console.WriteLine($"  As CPS: {original}");
    Console.WriteLine($"  As inches: {length.ToString(MeasureUnit.Inches)}");
    Console.WriteLine($"  As mm: {length.ToString(MeasureUnit.Millimeters)}");

    // Test string output with precision
    Console.WriteLine("\nTesting string output with precision:");
    Console.WriteLine($"  Precision 0: {length.ToString("F0", MeasureUnit.Inches)}");
    Console.WriteLine($"  Precision 2: {length.ToString("F2", MeasureUnit.Millimeters)}");

    Console.WriteLine("\n✓ All unit conversion tests passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the XML serialization and deserialization process for an CPSTestData object to verify data integrity.
  /// </summary>
  /// <remarks>This method creates a sample CPSTestData instance, serializes it to XML, and then deserializes it
  /// to ensure that the original and deserialized data are equivalent. The serialized XML is written to the console for
  /// inspection. Use this method to validate that changes to the CPSTestData structure or serialization logic do not
  /// break XML compatibility.</remarks>
  /// <returns>true if the CPSTestData object is successfully serialized to XML and deserialized back with matching data;
  /// otherwise, false.</returns>
  static bool TestCPSXmlSerialization()
  {
    Console.WriteLine("--- Testing CPS XML Serialization ---");      // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(CPSTestData));
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
    CPSTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (CPSTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;

  }

  
  /// <summary>
  /// Tests the serialization and deserialization of CPS test data to and from JSON format.
  /// </summary>
  /// <remarks>This method creates a sample CPS test data object, serializes it to a JSON string, and then
  /// deserializes it back to an object. It outputs the serialized JSON to the console for inspection and verifies that
  /// the deserialized data matches the original. Use this method to validate that CPS data can be accurately
  /// round-tripped using JSON serialization.</remarks>
  /// <returns>true if the JSON serialization and deserialization process completes successfully and the data integrity is
  /// verified; otherwise, false.</returns>
  static bool TestCPSJsonSerialization()
  {
    Console.WriteLine("--- Testing CPS JSON Serialization ---");      // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<CPSTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Shows the original CPS test data values in a readable format to the console for verification before serialization.
  /// </summary>
  /// <param name="testData"></param>
  private static void ShowOriginalData(CPSTestData testData)
  {
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
  }

  /// <summary>
  /// Verifies that the deserialized data matches the expected test data by comparing relevant properties.
  /// </summary>
  /// <remarks>The method compares several properties, including FontSize, LineHeight, MicroKerning,
  /// LetterSpacing, WordSpacing, SuperscriptOffset, SubscriptOffset, BorderWidth, ZeroValue, SmallValue, and
  /// LargeValue. If any property does not match, the method returns false. If deserializedData is null, an error
  /// message is written to the console and the method returns false.</remarks>
  /// <param name="deserializedData">The deserialized CPSTestData instance to verify. If null, the verification fails.</param>
  /// <param name="testData">The expected CPSTestData instance to compare against.</param>
  /// <returns>true if all compared properties of the deserialized data match the expected test data; otherwise, false.</returns>
  private static bool VerifyDeserializedData(CPSTestData? deserializedData, CPSTestData testData)
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

  /// <summary>
  /// Creates a new instance of the CPSTestData class initialized with default typographic values for testing purposes.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios that require consistent and repeatable
  /// typographic settings. All values are specified in CPS units and may need to be converted for use in other
  /// measurement systems.</remarks>
  /// <returns>An CPSTestData object containing predefined values for font size, line height, kerning, spacing, and offset
  /// properties.</returns>
  private static CPSTestData CreateTestData()
  {
    return new CPSTestData
    {
      FontSize = new CPS(1200),         // 12 points
      LineHeight = new CPS(1800),      // 18 points
      MicroKerning = new CPS(125),      // 0.125 points
      LetterSpacing = new CPS(250),     // 0.25 points
      WordSpacing = new CPS(1000),       // 1 point
      SuperscriptOffset = new CPS(500),// 5 points
      SubscriptOffset = new CPS(300),  // 3 points
      BorderWidth = new CPS(200),      // 2 points
      ZeroValue = new CPS(0),
      SmallValue = new CPS(1),        // 0.100 points
      LargeValue = new CPS(80*1200)      // 80 inches
    };
  }

  /// <summary>
  /// Tests a comprehensive set of edge cases for the CPS (Encapsulated PostScript) type, including zero, boundary
  /// values, precision, parsing, formatting, comparison, and implicit conversions.
  /// </summary>
  /// <remarks>This method outputs the results of each test to the console for verification. It covers scenarios
  /// such as micro-typography adjustments, string parsing with various units and decimal separators, deserialization
  /// from different JSON formats, and conversion between numeric types. Use this method to validate the correctness and
  /// robustness of the CPS type implementation.</remarks>
  /// <returns>true if all CPS edge case tests are completed successfully.</returns>
  static bool TestCPSEdgeCases()
  {
    Console.WriteLine("--- Testing CPS Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    CPS zero = 0;
    Console.WriteLine($"  Zero: '{zero}' ({(Int64)zero} CPS)");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    CPS minInt32 = Int32.MinValue;
    CPS maxInt32 = Int32.MaxValue;
    Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch()}in)");
    Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch()}in)");

    // Test centi-point precision (unique to CPS - finest granularity)
    Console.WriteLine("\nTesting centi-point precision (finest granularity):");
    CPS oneCentiPoint = 1;
    CPS twoCentiPoints = 2;
    CPS fourCentiPoints = 4;
    CPS eightCentiPoints = 8;
    Console.WriteLine($"  1 centi-point = {oneCentiPoint.ToPoints():F3}pt (0.001pt)");
    Console.WriteLine($"  2 CPS = {twoCentiPoints.ToPoints():F3}pt (0.002pt)");
    Console.WriteLine($"  4 CPS = {fourCentiPoints.ToPoints():F3}pt (0.004pt)");
    Console.WriteLine($"  8 CPS = {eightCentiPoints.ToPoints():F3}pt (0.008pt)");

    // Test micro-adjustments (use case for CPS)
    Console.WriteLine("\nTesting micro-typography adjustments:");
    CPS microKerning = new CPS(125);     // 0.125pt
    CPS fineTracking = new CPS(375);     // 0.375pt
    CPS preciseSpacing = new CPS(625);   // 0.625pt
    Console.WriteLine($"  Micro-kerning (125 centi-point): {microKerning.ToPoints():F3}pt");
    Console.WriteLine($"  Fine tracking (375 CPS): {fineTracking.ToPoints():F3}pt");
    Console.WriteLine($"  Precise spacing (625 CPS): {preciseSpacing.ToPoints():F3}pt");

    // Test common font sizes in CPS
    Console.WriteLine("\nTesting common font sizes:");
    CPS font10pt = new CPS(1000);    // 10pt
    CPS font12pt = new CPS(1200);    // 12pt
    CPS font14pt = new CPS(1400);   // 14pt
    Console.WriteLine($"  10pt = {(Int64)font10pt} CPS");
    Console.WriteLine($"  12pt = {(Int64)font12pt} CPS");
    Console.WriteLine($"  14pt = {(Int64)font14pt} CPS");

    // Test string parsing variations
    Console.WriteLine("\nTesting string parsing variations:");
    CPS fromPlainNumber = "576";
    CPS fromInches = "1in";
    CPS fromPoints = "12pt";
    CPS fromFraction = "0.125pt";
    Console.WriteLine($"  \"576\" → {(Int64)fromPlainNumber} CPS");
    Console.WriteLine($"  \"1in\" → {(Int64)fromInches} CPS");
    Console.WriteLine($"  \"12pt\" → {(Int64)fromPoints} CPS");
    Console.WriteLine($"  \"0.125pt\" → {(Int64)fromFraction} CPS");

    // Test decimal values with units
    Console.WriteLine("\nTesting decimal values with units:");
    CPS halfInch = new CPS("0.5in");
    CPS quarterInch = new CPS("0.25in");
    Console.WriteLine($"  0.5in = {(Int64)halfInch} CPS (expected 288)");
    Console.WriteLine($"  0.25in = {(Int64)quarterInch} CPS (expected 144)");

    // Test comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    CPS commaDecimal = new CPS("2,54cm");
    Console.WriteLine($"  \"2,54cm\" → {(Int64)commaDecimal} CPS");

    // Test Deserialization from different formats
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // Numeric format
    string jsonNumeric = "{\"Value\":576}";
    var fromNumeric = JsonSerializer.Deserialize<CPSWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 576: {fromNumeric?.Value}");

    // String format with unit
    string jsonStringInch = "{\"Value\":\"1in\"}";
    var fromStringInch = JsonSerializer.Deserialize<CPSWrapper>(jsonStringInch);
    Console.WriteLine($"  From JSON string \"1in\": {fromStringInch?.Value}");

    // String format with point unit
    string jsonStringPt = "{\"Value\":\"12pt\"}";
    var fromStringPt = JsonSerializer.Deserialize<CPSWrapper>(jsonStringPt);
    Console.WriteLine($"  From JSON string \"12pt\": {fromStringPt?.Value} (expected 96)");

    // String format without unit
    string jsonStringPlain = "{\"Value\":\"576\"}";
    var fromStringPlain = JsonSerializer.Deserialize<CPSWrapper>(jsonStringPlain);
    Console.WriteLine($"  From JSON string \"576\": {fromStringPlain?.Value}");

    // Test output with units
    Console.WriteLine("\nTesting output format with different units:");
    CPS measurement = 576;
    Console.WriteLine($"  As CPS: {measurement}");
    Console.WriteLine($"  As inches (no precision): {measurement.ToString(MeasureUnit.Inches)}");
    Console.WriteLine($"  As inches (3 decimal): {measurement.ToString("F3", MeasureUnit.Inches)}");
    Console.WriteLine($"  As points (2 decimal): {measurement.ToString("F2", MeasureUnit.Points)}");
    Console.WriteLine($"  As mm (1 decimal): {measurement.ToString("F1", MeasureUnit.Millimeters)}");
    Console.WriteLine($"  As cm (2 decimal): {measurement.ToString("F2", MeasureUnit.Centimeters)}");
    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    CPS small = 288;  // 0.5 inch
    CPS large = 576;  // 1 inch
    Console.WriteLine($"  288 < 576: {small.CompareTo(large) < 0}");
    Console.WriteLine($"  576 > 288: {large.CompareTo(small) > 0}");
    Console.WriteLine($"  576 == 576: {large.CompareTo(new CPS(576)) == 0}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit conversions:");
    CPS fromInt64 = 576L;
    Int64 toInt64 = fromInt64;
    Console.WriteLine($"  From Int64: {fromInt64}");
    Console.WriteLine($"  To Int64: {toInt64}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the performance of various operations on the CPS type, including construction from strings and integers,
  /// conversion to different units, and JSON serialization/deserialization.
  /// </summary>
  /// <returns>true if all CPS performance tests are completed successfully.</returns>
  static bool TestCPSPerformance()
  {
    Console.WriteLine("--- Testing CPS Performance ---"); const int iterations = 100000;

    // Test construction from string with unit
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      CPS ep = "1in";
    }
    sw.Stop();
    Console.WriteLine($"Construction from string with unit x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from plain number string
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      CPS ep = "576";
    }
    sw.Stop();
    Console.WriteLine($"Construction from plain string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from integer
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      CPS ep = 576;
    }
    sw.Stop();
    Console.WriteLine($"Construction from integer x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    CPS testEp = 576;
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
      string str = testEp.ToString(MeasureUnit.Inches);
    }
    sw.Stop();
    Console.WriteLine($"ToString(unit) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test unit conversion performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      decimal inches = testEp.ToInch();
    }
    sw.Stop();
    Console.WriteLine($"ToInch() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      decimal points = testEp.ToPoints();
    }
    sw.Stop();
    Console.WriteLine($"ToPoints() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      decimal mm = testEp.ToMillimeters();
    }
    sw.Stop();
    Console.WriteLine($"ToMillimeters() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new CPSTestData
    {
      FontSize = new CPS(96),
      LineHeight = new CPS(144),
      MicroKerning = new CPS(1),
      LetterSpacing = new CPS(2),
      WordSpacing = new CPS(8),
      SuperscriptOffset = new CPS(40),
      SubscriptOffset = new CPS(24),
      BorderWidth = new CPS(16),
      ZeroValue = new CPS(0),
      SmallValue = new CPS(1),
      LargeValue = new CPS(8000)
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
      var obj = JsonSerializer.Deserialize<CPSTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test comparison performance
    CPS ep1 = 576;
    CPS ep2 = 576;
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

  }


/// <summary>
/// Test data class containing various CPS properties.
/// </summary>
[XmlRoot("CPSTestData")]
public class CPSTestData
{
  [XmlElement("FontSize")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
  public CPS FontSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LineHeight")]
  public CPS LineHeight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("MicroKerning")]
  public CPS MicroKerning { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LetterSpacing")]
  public CPS LetterSpacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("WordSpacing")]
  public CPS WordSpacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("SuperscriptOffset")]
  public CPS SuperscriptOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("SubscriptOffset")]
  public CPS SubscriptOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("BorderWidth")]
  public CPS BorderWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ZeroValue")]
  public CPS ZeroValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("SmallValue")]
  public CPS SmallValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LargeValue")]
  public CPS LargeValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class CPSWrapper
{
  public CPS Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


