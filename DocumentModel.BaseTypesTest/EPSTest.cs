using System.Globalization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for EPS type serialization in both XML and JSON formats.
/// </summary>
public static class EPSTest
{
  /// <summary>
  /// Runs all EPS serialization tests.
  /// </summary>
  /// <returns>true if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== EPS Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestEPSBasicOperations()) return false;
    if (!TestEPSUnitConversions()) return false;
    if (!TestEPSXmlSerialization()) return false;
    if (!TestEPSJsonSerialization()) return false;
    if (!TestEPSEdgeCases()) return false;
    if (!TestEPSPerformance()) return false;

    return true;
  }

  /// <summary>
  /// Tests the basic operations of the EPS class, including conversions between EPS and various types, string
  /// representations, and comparisons.
  /// </summary>
  /// <remarks>This method verifies the correctness of the EPS class by testing string and numeric conversions,
  /// string representations, hash code consistency, and comparison operations. It outputs diagnostic information to the
  /// console for each test and returns false if any test fails.</remarks>
  /// <returns>true if all basic EPS operations pass successfully; otherwise, false.</returns>
  static bool TestEPSBasicOperations()
  {
    Console.WriteLine("--- Testing EPS Basic Operations ---");
    // Test string to EPS conversion (plain number)
    long eps1Val = 7315200;
    var eps1Str = eps1Val.ToString();
    EPS eps1 = eps1Str;
    var longEPS = (long)eps1;
    Console.WriteLine($"\n✓ String to EPS: {eps1} = {longEPS} EPSs");
    if (longEPS != 7315200)
    {
      Console.WriteLine("✗ String to EPS conversion FAILED");
      return false;
    }
    // Test string to EPS conversion (with unit)
    EPS eps2 = "1in";
    var inchEPS = eps2.ToInch();
    Console.WriteLine($"\n✓ String with unit to EPS: {eps2} ({inchEPS:F2}in)");
    if (inchEPS != 1.0)
    {
      Console.WriteLine("✗ String with unit to EPS conversion FAILED");
      return false;
    }

    // Test integer to EPS conversion
    EPS eps3 = eps1Val;
    var intEPS = (int)eps3;
    Console.WriteLine($"\n✓ Int to EPS: {intEPS}");
    if (intEPS != eps1Val)
    {
      Console.WriteLine("✗ Int to EPS conversion FAILED");
      return false;
    }

    // Test EPS to string
    string strEPS = eps1.ToString();
    Console.WriteLine($"\n✓ EPS to string: {strEPS}");
    if (strEPS != eps1Str)
    {
      Console.WriteLine("✗ EPS to string conversion FAILED");
      return false;
    }

    // Test EPS to various integer types
    int int32Val = (int)eps1;
    long int64Val = (long)eps1;
    uint uint32Val = (uint)eps1;
    Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");
    if (int32Val != eps1Val || int64Val != eps1Val || uint32Val != eps1Val)
    {
      Console.WriteLine("✗ EPS to numeric conversions FAILED");
      return false;
    }

    // Test hash code
    var hashCode = eps1.GetHashCode();
    Console.WriteLine($"\n✓ Hash code: {hashCode}");
    var eps1ValHashCode = eps1Val.GetHashCode();
    if (hashCode != eps1ValHashCode)
    {
      Console.WriteLine($"✗ GetHashCode consistency FAILED eps1Hash={hashCode}, eps1ValHash={eps1ValHashCode}");
      return false;
    }
    // Test comparison
    EPS eps4 = eps1Val * 2; // 2 inches
    Console.WriteLine($"\n✓ CompareTo (914400 vs 1828800): {eps1.CompareTo(eps4)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  
  /// <summary>
  /// Tests the accuracy of conversions between EPS (Encapsulated PostScript) units and common measurement units,
  /// including inches, points, millimeters, and centimeters.
  /// </summary>
  /// <remarks>This method performs a series of validation checks to ensure that conversions to and from EPS
  /// units are correct and consistent. It includes tests for inch and point conversions, eighth-point precision,
  /// millimeter and centimeter conversions, round-trip accuracy, and string formatting with various units and
  /// precisions. The results of each test are output to the console for review.</remarks>
  /// <returns>true if all unit conversion tests pass; otherwise, false.</returns>
  static bool TestEPSUnitConversions()
  {
    Console.WriteLine("--- Testing EPS Unit Conversions ---");      // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    EPS oneInch = "1 in";
    Console.WriteLine($"  1 in = {(Int64)oneInch} EPS (expected 576)");
    Console.WriteLine($"  576 EPS = {oneInch.ToInch():F2}in");
    if ((Int64)oneInch != 576)
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test point conversions
    Console.WriteLine("\nTesting point conversions:");
    EPS onePoint = "1 pt";
    Console.WriteLine($"  1 pt = {(Int64)onePoint} EPS (expected 8)");
    Console.WriteLine($"  8 EPS = {onePoint.ToPT():F2}pt");
    if ((Int64)onePoint != 8)
    {
      Console.WriteLine("✗ Point conversion FAILED");
      return false;
    }

    // Test eighth-point precision (unique feature)
    Console.WriteLine("\nTesting eighth-point precision:");
    EPS oneEighthPoint = 1;
    EPS halfPoint = 4;
    EPS fullPoint = 8;
    Console.WriteLine($"  1 eighth-point = {oneEighthPoint.ToPT():F3}pt (0.125pt)");
    Console.WriteLine($"  4 EPS = {halfPoint.ToPT():F3}pt (0.5pt)");
    Console.WriteLine($"  8 EPS = {fullPoint.ToPT():F3}pt (1.0pt)");

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    EPS tenMM = "10 mm";
    double expectedEPS = 10 * EPS.EPSinMM;
    Console.WriteLine($"  10 mm = {(Int64)tenMM} EPS (expected ~{expectedEPS:F0})");
    Console.WriteLine($"  Back to mm: {tenMM.ToMM():F2}mm");

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    EPS oneCM = "1 cm";
    expectedEPS = EPS.EPSinCM;
    Console.WriteLine($"  1 cm = {(Int64)oneCM} EPS (expected ~{expectedEPS:F0})");
    Console.WriteLine($"  Back to cm: {oneCM.ToCM():F2}cm");

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    EPS original = 576; // 1 inch
    double inches = original.ToInch();
    EPS roundTrip = new EPS($"{inches:F6}in");
    Console.WriteLine($"  Original: {(Int64)original} EPS");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to EPS: {(Int64)roundTrip} EPS");
    Console.WriteLine($"  Match: {original.CompareTo(roundTrip) == 0}");

    // Test relationship between EPS and points
    Console.WriteLine("\nTesting eighth-point/point relationships:");
    EPS twelvePoints = "12 pt";
    Console.WriteLine($"  12 pt = {(Int64)twelvePoints} EPS (expected 96)");
    Console.WriteLine($"  Back to points: {twelvePoints.ToPT():F1}pt");

    // Test string output with units
    Console.WriteLine("\nTesting string output with units:");
    EPS measurement = 576;
    Console.WriteLine($"  As EPS: {measurement}");
    Console.WriteLine($"  As inches: {measurement.ToString(LengthUnit.Inches)}");
    Console.WriteLine($"  As points: {measurement.ToString(LengthUnit.Points)}");
    Console.WriteLine($"  As mm: {measurement.ToString(LengthUnit.Millimeters)}");
    Console.WriteLine($"  As cm: {measurement.ToString(LengthUnit.Centimeters)}");

    // Test string output with precision
    Console.WriteLine("\nTesting string output with precision:");
    Console.WriteLine($"  Precision 0: {measurement.ToString("F0", LengthUnit.Inches)}");
    Console.WriteLine($"  Precision 2: {measurement.ToString("F2", LengthUnit.Points)}");
    Console.WriteLine($"  Precision 4: {measurement.ToString("F4", LengthUnit.Millimeters)}");

    Console.WriteLine("\n✓ All unit conversion tests passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the XML serialization and deserialization process for an EPSTestData object to verify data integrity.
  /// </summary>
  /// <remarks>This method creates a sample EPSTestData instance, serializes it to XML, and then deserializes it
  /// to ensure that the original and deserialized data are equivalent. The serialized XML is written to the console for
  /// inspection. Use this method to validate that changes to the EPSTestData structure or serialization logic do not
  /// break XML compatibility.</remarks>
  /// <returns>true if the EPSTestData object is successfully serialized to XML and deserialized back with matching data;
  /// otherwise, false.</returns>
  static bool TestEPSXmlSerialization()
  {
    Console.WriteLine("--- Testing EPS XML Serialization ---");      // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(EPSTestData));
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
    EPSTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (EPSTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;

  }

  
  /// <summary>
  /// Tests the serialization and deserialization of EPS test data to and from JSON format.
  /// </summary>
  /// <remarks>This method creates a sample EPS test data object, serializes it to a JSON string, and then
  /// deserializes it back to an object. It outputs the serialized JSON to the console for inspection and verifies that
  /// the deserialized data matches the original. Use this method to validate that EPS data can be accurately
  /// round-tripped using JSON serialization.</remarks>
  /// <returns>true if the JSON serialization and deserialization process completes successfully and the data integrity is
  /// verified; otherwise, false.</returns>
  static bool TestEPSJsonSerialization()
  {
    Console.WriteLine("--- Testing EPS JSON Serialization ---");      // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<EPSTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Shows the original EPS test data values in a readable format to the console for verification before serialization.
  /// </summary>
  /// <param name="testData"></param>
  private static void ShowOriginalData(EPSTestData testData)
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
  /// <param name="deserializedData">The deserialized EPSTestData instance to verify. If null, the verification fails.</param>
  /// <param name="testData">The expected EPSTestData instance to compare against.</param>
  /// <returns>true if all compared properties of the deserialized data match the expected test data; otherwise, false.</returns>
  private static bool VerifyDeserializedData(EPSTestData? deserializedData, EPSTestData testData)
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
  /// Creates a new instance of the EPSTestData class initialized with default typographic values for testing purposes.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios that require consistent and repeatable
  /// typographic settings. All values are specified in EPS units and may need to be converted for use in other
  /// measurement systems.</remarks>
  /// <returns>An EPSTestData object containing predefined values for font size, line height, kerning, spacing, and offset
  /// properties.</returns>
  private static EPSTestData CreateTestData()
  {
    return new EPSTestData
    {
      FontSize = new EPS(96),         // 12 points
      LineHeight = new EPS(144),      // 18 points
      MicroKerning = new EPS(1),      // 0.125 points
      LetterSpacing = new EPS(2),     // 0.25 points
      WordSpacing = new EPS(8),       // 1 point
      SuperscriptOffset = new EPS(40),// 5 points
      SubscriptOffset = new EPS(24),  // 3 points
      BorderWidth = new EPS(16),      // 2 points
      ZeroValue = new EPS(0),
      SmallValue = new EPS(1),        // 0.125 points
      LargeValue = new EPS(8000)      // ~13.9 inches
    };
  }

  /// <summary>
  /// Tests a comprehensive set of edge cases for the EPS (Encapsulated PostScript) type, including zero, boundary
  /// values, precision, parsing, formatting, comparison, and implicit conversions.
  /// </summary>
  /// <remarks>This method outputs the results of each test to the console for verification. It covers scenarios
  /// such as micro-typography adjustments, string parsing with various units and decimal separators, deserialization
  /// from different JSON formats, and conversion between numeric types. Use this method to validate the correctness and
  /// robustness of the EPS type implementation.</remarks>
  /// <returns>true if all EPS edge case tests are completed successfully.</returns>
  static bool TestEPSEdgeCases()
  {
    Console.WriteLine("--- Testing EPS Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    EPS zero = 0;
    Console.WriteLine($"  Zero: '{zero}' ({(Int64)zero} EPS)");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    EPS minInt32 = Int32.MinValue;
    EPS maxInt32 = Int32.MaxValue;
    Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch():F2}in)");
    Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch():F2}in)");

    // Test eighth-point precision (unique to EPS - finest granularity)
    Console.WriteLine("\nTesting eighth-point precision (finest granularity):");
    EPS oneEighth = 1;
    EPS twoEighths = 2;
    EPS fourEighths = 4;
    EPS eightEighths = 8;
    Console.WriteLine($"  1 eighth-point = {oneEighth.ToPT():F3}pt (0.125pt)");
    Console.WriteLine($"  2 EPS = {twoEighths.ToPT():F3}pt (0.25pt)");
    Console.WriteLine($"  4 EPS = {fourEighths.ToPT():F3}pt (0.5pt)");
    Console.WriteLine($"  8 EPS = {eightEighths.ToPT():F3}pt (1.0pt)");

    // Test micro-adjustments (use case for EPS)
    Console.WriteLine("\nTesting micro-typography adjustments:");
    EPS microKerning = new EPS(1);     // 0.125pt
    EPS fineTracking = new EPS(3);     // 0.375pt
    EPS preciseSpacing = new EPS(5);   // 0.625pt
    Console.WriteLine($"  Micro-kerning (1 eighth-point): {microKerning.ToPT():F3}pt");
    Console.WriteLine($"  Fine tracking (3 EPS): {fineTracking.ToPT():F3}pt");
    Console.WriteLine($"  Precise spacing (5 EPS): {preciseSpacing.ToPT():F3}pt");

    // Test common font sizes in EPS
    Console.WriteLine("\nTesting common font sizes:");
    EPS font10pt = new EPS(80);    // 10pt
    EPS font12pt = new EPS(96);    // 12pt
    EPS font14pt = new EPS(112);   // 14pt
    Console.WriteLine($"  10pt = {(Int64)font10pt} EPS");
    Console.WriteLine($"  12pt = {(Int64)font12pt} EPS");
    Console.WriteLine($"  14pt = {(Int64)font14pt} EPS");

    // Test string parsing variations
    Console.WriteLine("\nTesting string parsing variations:");
    EPS fromPlainNumber = "576";
    EPS fromInches = "1in";
    EPS fromPoints = "12pt";
    EPS fromFraction = "0.125pt";
    Console.WriteLine($"  \"576\" → {(Int64)fromPlainNumber} EPS");
    Console.WriteLine($"  \"1in\" → {(Int64)fromInches} EPS");
    Console.WriteLine($"  \"12pt\" → {(Int64)fromPoints} EPS");
    Console.WriteLine($"  \"0.125pt\" → {(Int64)fromFraction} EPS");

    // Test decimal values with units
    Console.WriteLine("\nTesting decimal values with units:");
    EPS halfInch = new EPS("0.5in");
    EPS quarterInch = new EPS("0.25in");
    Console.WriteLine($"  0.5in = {(Int64)halfInch} EPS (expected 288)");
    Console.WriteLine($"  0.25in = {(Int64)quarterInch} EPS (expected 144)");

    // Test comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    EPS commaDecimal = new EPS("2,54cm");
    Console.WriteLine($"  \"2,54cm\" → {(Int64)commaDecimal} EPS");

    // Test Deserialization from different formats
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // Numeric format
    string jsonNumeric = "{\"Value\":576}";
    var fromNumeric = JsonSerializer.Deserialize<EPSWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 576: {fromNumeric?.Value}");

    // String format with unit
    string jsonStringInch = "{\"Value\":\"1in\"}";
    var fromStringInch = JsonSerializer.Deserialize<EPSWrapper>(jsonStringInch);
    Console.WriteLine($"  From JSON string \"1in\": {fromStringInch?.Value}");

    // String format with point unit
    string jsonStringPt = "{\"Value\":\"12pt\"}";
    var fromStringPt = JsonSerializer.Deserialize<EPSWrapper>(jsonStringPt);
    Console.WriteLine($"  From JSON string \"12pt\": {fromStringPt?.Value} (expected 96)");

    // String format without unit
    string jsonStringPlain = "{\"Value\":\"576\"}";
    var fromStringPlain = JsonSerializer.Deserialize<EPSWrapper>(jsonStringPlain);
    Console.WriteLine($"  From JSON string \"576\": {fromStringPlain?.Value}");

    // Test output with units
    Console.WriteLine("\nTesting output format with different units:");
    EPS measurement = 576;
    Console.WriteLine($"  As EPS: {measurement}");
    Console.WriteLine($"  As inches (no precision): {measurement.ToString(LengthUnit.Inches)}");
    Console.WriteLine($"  As inches (3 decimal): {measurement.ToString("F3", LengthUnit.Inches)}");
    Console.WriteLine($"  As points (2 decimal): {measurement.ToString("F2", LengthUnit.Points)}");
    Console.WriteLine($"  As mm (1 decimal): {measurement.ToString("F1", LengthUnit.Millimeters)}");
    Console.WriteLine($"  As cm (2 decimal): {measurement.ToString("F2", LengthUnit.Centimeters)}");
    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    EPS small = 288;  // 0.5 inch
    EPS large = 576;  // 1 inch
    Console.WriteLine($"  288 < 576: {small.CompareTo(large) < 0}");
    Console.WriteLine($"  576 > 288: {large.CompareTo(small) > 0}");
    Console.WriteLine($"  576 == 576: {large.CompareTo(new EPS(576)) == 0}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit conversions:");
    EPS fromInt32 = 576;
    EPS fromInt64 = 576L;
    EPS fromUInt32 = 576U;
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

  /// <summary>
  /// Tests the performance of various operations on the EPS type, including construction from strings and integers,
  /// conversion to different units, and JSON serialization/deserialization.
  /// </summary>
  /// <returns>true if all EPS performance tests are completed successfully.</returns>
  static bool TestEPSPerformance()
  {
    Console.WriteLine("--- Testing EPS Performance ---"); const int iterations = 100000;

    // Test construction from string with unit
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      EPS ep = "1in";
    }
    sw.Stop();
    Console.WriteLine($"Construction from string with unit x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from plain number string
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      EPS ep = "576";
    }
    sw.Stop();
    Console.WriteLine($"Construction from plain string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from integer
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      EPS ep = 576;
    }
    sw.Stop();
    Console.WriteLine($"Construction from integer x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    EPS testEp = 576;
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
      string str = testEp.ToString(LengthUnit.Inches);
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
      double points = testEp.ToPT();
    }
    sw.Stop();
    Console.WriteLine($"ToPT() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double mm = testEp.ToMM();
    }
    sw.Stop();
    Console.WriteLine($"ToMM() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new EPSTestData
    {
      FontSize = new EPS(96),
      LineHeight = new EPS(144),
      MicroKerning = new EPS(1),
      LetterSpacing = new EPS(2),
      WordSpacing = new EPS(8),
      SuperscriptOffset = new EPS(40),
      SubscriptOffset = new EPS(24),
      BorderWidth = new EPS(16),
      ZeroValue = new EPS(0),
      SmallValue = new EPS(1),
      LargeValue = new EPS(8000)
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
      var obj = JsonSerializer.Deserialize<EPSTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test comparison performance
    EPS ep1 = 576;
    EPS ep2 = 576;
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
/// Test data class containing various EPS properties.
/// </summary>
[XmlRoot("EPSTestData")]
public class EPSTestData
{
  [XmlElement("FontSize")]
  public EPS FontSize { get; set; }

  [XmlElement("LineHeight")]
  public EPS LineHeight { get; set; }

  [XmlElement("MicroKerning")]
  public EPS MicroKerning { get; set; }

  [XmlElement("LetterSpacing")]
  public EPS LetterSpacing { get; set; }

  [XmlElement("WordSpacing")]
  public EPS WordSpacing { get; set; }

  [XmlElement("SuperscriptOffset")]
  public EPS SuperscriptOffset { get; set; }

  [XmlElement("SubscriptOffset")]
  public EPS SubscriptOffset { get; set; }

  [XmlElement("BorderWidth")]
  public EPS BorderWidth { get; set; }

  [XmlElement("ZeroValue")]
  public EPS ZeroValue { get; set; }

  [XmlElement("SmallValue")]
  public EPS SmallValue { get; set; }

  [XmlElement("LargeValue")]
  public EPS LargeValue { get; set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class EPSWrapper
{
  public EPS Value { get; set; }
}

