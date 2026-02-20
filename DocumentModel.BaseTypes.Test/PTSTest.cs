using System.Globalization;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for PTS type serialization in both XML and JSON formats.
/// </summary>
public static class PTSTest
{
  /// <summary>
  /// Runs all PTS serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== PTS Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestPTSBasicOperations()) return false;
    if (!TestPTSUnitConversions()) return false;
    if (!TestPTSXmlSerialization()) return false;
    if (!TestPTSJsonSerialization()) return false;
    if (!TestPTSEdgeCases()) return false;
    if (!TestPTSPerformance()) return false;

    return true;
  }
  
  /// <summary>
  /// Tests the basic operations of the PTS class, including conversions between PTS and various types, string
  /// representations, and comparisons.
  /// </summary>
  /// <remarks>This method verifies the correctness of the PTS class by testing string and numeric conversions,
  /// string representations, hash code consistency, and comparison operations. It outputs diagnostic information to the
  /// console for each test and returns false if any test fails.</remarks>
  /// <returns>true if all basic PTS operations pass successfully; otherwise, false.</returns>
  static bool TestPTSBasicOperations()
  {
    Console.WriteLine("--- Testing PTS Basic Operations ---");
    // Test string to PTS conversion (plain number)
    long pts1Val = 7315200;
    var pts1Str = pts1Val.ToString();
    PTS pts1 = pts1Str;
    var longPTS = (long)pts1;
    Console.WriteLine($"\n✓ String to PTS: {pts1} = {longPTS} PTS");
    if (longPTS != 7315200)
    {
      Console.WriteLine("✗ String to PTS conversion FAILED");
      return false;
    }
    // Test string to PTS conversion (with unit)
    PTS pts2 = "1in";
    var inchPTS = pts2.ToInch();
    Console.WriteLine($"\n✓ String with unit to PTS: {pts2} ({inchPTS}in)");
    if (inchPTS != 1.0)
    {
      Console.WriteLine("✗ String with unit to PTS conversion FAILED");
      return false;
    }

    // Test integer to PTS conversion
    PTS pts3 = pts1Val;
    var intPTS = (int)pts3;
    Console.WriteLine($"\n✓ Int to PTS: {intPTS}");
    if (intPTS != pts1Val)
    {
      Console.WriteLine("✗ Int to PTS conversion FAILED");
      return false;
    }

    // Test PTS to string
    string strPTS = pts1.ToString();
    Console.WriteLine($"\n✓ PTS to string: {strPTS}");
    if (strPTS != pts1Str)
    {
      Console.WriteLine("✗ PTS to string conversion FAILED");
      return false;
    }

    // Test PTS to various integer types
    int int32Val = (int)pts1;
    long int64Val = (long)pts1;
    uint uint32Val = (uint)pts1;
    Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");
    if (int32Val != pts1Val || int64Val != pts1Val || uint32Val != pts1Val)
    {
      Console.WriteLine("✗ PTS to numeric conversions FAILED");
      return false;
    }

    // Test comparison
    PTS pts4 = pts1Val * 2; // 2 inches
    Console.WriteLine($"\n✓ CompareTo ({pts1Val} vs {pts4}): {pts1.CompareTo(pts4)} (expected < 0)");


    // Test hash code
    var pts1HashCode = pts1.GetHashCode();
    PTS pts5 = pts1Str;
    Console.WriteLine($"\n✓ Hash code: {pts1HashCode}");
    var pts5HashCode = pts5.GetHashCode();
    if (pts1HashCode != pts5HashCode)
    {
      Console.WriteLine($"✗ GetHashCode consistency FAILED pts1Hash={pts1HashCode}, pts1ValHash={pts5HashCode}");
      return false;
    }

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the accuracy and correctness of conversions between PTS and various length units, including inches,
  /// millimeters, centimeters, pts, and twips.
  /// </summary>
  /// <remarks>This method performs a series of unit conversion tests and outputs the results to the console. It
  /// verifies both direct and round-trip conversions, as well as string formatting for different units and precisions.
  /// Use this method to validate that PTS-related conversion logic is functioning as expected.</remarks>
  /// <returns>true if all unit conversion tests pass; otherwise, false.</returns>
  static bool TestPTSUnitConversions()
  {
    var pts1Inch = 72.0;
    var pts1MM = pts1Inch / 25.4;
    var pts1CM = pts1MM * 10;
    var pts1PT = pts1Inch / 72.0;
    var pts12PT = pts1PT * 12;
    var pts1Twips = pts1Inch / 1440.0;
    var pts10Twips = pts1Twips * 10;

    Console.WriteLine("--- Testing PTS Unit Conversions ---");
    // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    PTS oneInch = "1in";
    Console.WriteLine($"  1in = {oneInch} PTS (expected {pts1Inch})");
    Console.WriteLine($"  {pts1Inch} PTS = {oneInch.ToInch()}in");
    if (!oneInch.Equals(pts1Inch))
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    PTS oneMM = "1mm";
    Console.WriteLine($"  1mm = {oneMM} PTS (expected {pts1MM})");
    Console.WriteLine($"  {pts1MM} PTS = {oneMM.ToMM()}mm");
    if (!oneMM.Equals(pts1MM))
    {
      Console.WriteLine("✗ Millimeter conversion FAILED");
      return false;
    }

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    PTS oneCM = "1cm";
    Console.WriteLine($"  1cm = {oneCM} PTS (expected ~{pts1CM})");
    Console.WriteLine($"  {pts1CM} PTS = {oneCM.ToCM()}cm");
    if (!oneCM.Equals(pts1CM))
    {
      Console.WriteLine("✗ Centimeter conversion FAILED");
      return false;
    }

    // Test point conversions
    Console.WriteLine("\nTesting point conversions:");
    PTS twelvePTS = "12pt";
    Console.WriteLine($"  12pt = {twelvePTS} PTS (expected {pts12PT})");
    Console.WriteLine($"  {pts12PT} PTS = {twelvePTS.ToPT()}pt");
    if (!twelvePTS.Equals(pts12PT))
    {
      Console.WriteLine("✗ Point conversion FAILED");
      return false;
    }

    // Test twips conversions
    Console.WriteLine("\nTesting twips conversions:");
    PTS tenTwips = "10tw";
    Console.WriteLine($"  10tw = {tenTwips} PTS (expected {pts10Twips})");
    Console.WriteLine($"  {pts10Twips} PTS = {tenTwips.ToTwips()}tw");
    if (!tenTwips.Equals(pts10Twips))
    {
      Console.WriteLine("✗ Twips conversion FAILED");
      return false;
    }

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    PTS original = pts1Inch; // 1 inch
    double inches = original.ToInch();
    PTS roundTrip = new PTS($"{inches:F6}in");
    Console.WriteLine($"  Original: {(long)original} PTS");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to PTS: {(long)roundTrip} PTS");
    if (original.CompareTo(roundTrip) != 0)
    {
      Console.WriteLine("✗ Round-trip conversion FAILED");
      return false;
    }

    // Test ConvertTo for each unit
    Console.WriteLine("\nTesting ConvertTo method:");
    ILengthMeasure length = original;
    Console.WriteLine($"  To inches: {length.ConvertTo(LengthUnit.Inches)}");
    Console.WriteLine($"  To mm: {length.ConvertTo(LengthUnit.Millimeters)}");
    Console.WriteLine($"  To cm: {length.ConvertTo(LengthUnit.Centimeters)}");
    Console.WriteLine($"  To pt: {length.ConvertTo(LengthUnit.Points)}");
    Console.WriteLine($"  To twips: {length.ConvertTo(LengthUnit.Twips)}");

    // Test string output with units
    Console.WriteLine("\nTesting string output with units:");
    Console.WriteLine($"  As PTS: {original}");
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

  /// <summary>
  /// Tests the XML serialization and deserialization of a PTSTestData object containing various PTS properties.
  /// This method verifies that the original data is accurately preserved through the serialization process
  /// by comparing the deserialized object to the original test data.
  /// It outputs the original data, the serialized XML, and the deserialized data to the console for diagnostic purposes.
  /// If any discrepancies are found during verification, it returns false; otherwise, it confirms that the test passed successfully.
  /// </summary>
  /// <returns></returns>
  static bool TestPTSXmlSerialization()
  {
    Console.WriteLine("--- Testing PTS XML Serialization ---");      
    // Create test object
    var testData = CreateTestData();

    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(PTSTestData));
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
    PTSTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (PTSTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the JSON serialization and deserialization of a PTSTestData object containing various PTS properties.
  /// This method verifies that the original data is accurately preserved through the serialization process
  /// by comparing the deserialized object to the original test data.
  /// It outputs the original data, the serialized JSON, and the deserialized data to the console for diagnostic purposes.
  /// If any discrepancies are found during verification, it returns false;
  /// otherwise, it confirms that the test passed successfully.
  /// </summary>
  /// <param name="deserializedData">The deserialized PTSTestData object to verify.</param>
  /// <param name="testData">The original PTSTestData object used for comparison.</param>
  /// <returns>true if the deserialized data matches the original data; otherwise, false.</returns>
  private static bool VerifyDeserializedData(PTSTestData? deserializedData, PTSTestData testData)
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
    Console.WriteLine($"  Indent: {deserializedData.Indent} ({deserializedData.Indent.ToInch()}in)");
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

  /// <summary>
  /// Tests the serialization and deserialization of PTS data to and from JSON format.
  /// </summary>
  /// <remarks>This method creates a test object, serializes it to JSON, and then deserializes it back to verify
  /// the integrity of the data. It outputs the serialized JSON string to the console for inspection.</remarks>
  /// <returns>true if the JSON serialization and deserialization test passes; otherwise, false.</returns>
  static bool TestPTSJsonSerialization()
  {
    Console.WriteLine("--- Testing PTS JSON Serialization ---");      // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<PTSTestData>(jsonString, jsonOptions);
    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Creates a new instance of the PTSTestData class initialized with standard typographic values for testing purposes.
  /// </summary>
  /// <remarks>Use this method to obtain consistent formatting values when writing tests that require predefined
  /// typographic settings. The returned data reflects commonly used values in document formatting scenarios.</remarks>
  /// <returns>A PTSTestData object populated with default values for font size, line height, paragraph spacing, indentation, and
  /// related properties.</returns>
  private static PTSTestData CreateTestData()
  {
    return new PTSTestData
    {
      FontSize = new PTS(12),       // 12 pts
      LineHeight = new PTS(18),     // 18 pts
      ParagraphSpacing = new PTS(6),// 6 pts
      Indent = new PTS(36),         // 36 pts (0.5 inch)
      BodyFontSize = new PTS(10),   // 10 pts
      HeadingFontSize = new PTS(24),// 24 pts
      ZeroValue = new PTS(0),
      SmallValue = new PTS(1),      // 1 point
      LargeValue = new PTS(1000)    // ~13.9 inches
    };
  }

  /// <summary>
  /// Displays the original formatting values from the specified test data to the console in a human-readable format.
  /// </summary>
  /// <remarks>The output includes font sizes, line height, paragraph spacing, indentation, and additional value
  /// fields. Measurements are converted to points or inches where applicable for clarity.</remarks>
  /// <param name="testData">The PTSTestData instance containing the original formatting values to display.</param>
  private static void ShowOriginalData(PTSTestData testData)
  {
    Console.WriteLine($"Original data:");

    Console.WriteLine($"  FontSize: {testData.FontSize} ({testData.FontSize.ToPT():F1}pt)");
    Console.WriteLine($"  LineHeight: {testData.LineHeight} ({testData.LineHeight.ToPT():F1}pt)");
    Console.WriteLine($"  ParagraphSpacing: {testData.ParagraphSpacing} ({testData.ParagraphSpacing.ToPT():F1}pt)");
    Console.WriteLine($"  Indent: {testData.Indent} ({testData.Indent.ToInch()}in)");
    Console.WriteLine($"  BodyFontSize: {testData.BodyFontSize} ({testData.BodyFontSize.ToPT():F1}pt)");
    Console.WriteLine($"  HeadingFontSize: {testData.HeadingFontSize} ({testData.HeadingFontSize.ToPT():F1}pt)");
    Console.WriteLine($"  ZeroValue: {testData.ZeroValue}");
    Console.WriteLine($"  SmallValue: {testData.SmallValue}");
    Console.WriteLine($"  LargeValue: {testData.LargeValue}");
    Console.WriteLine();
  }

  /// <summary>
  /// Tests various edge cases for the PTS struct, including zero values, boundary values, common font sizes,
  /// and different measurement units.
  /// </summary>
  /// <returns>true if all edge case tests pass; otherwise, false.</returns>
  static bool TestPTSEdgeCases()
  {
    Console.WriteLine("--- Testing PTS Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    PTS zero = 0;
    Console.WriteLine($"  Zero: '{zero}' ({(Int64)zero} pts)");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    PTS minInt32 = Int32.MinValue;
    PTS maxInt32 = Int32.MaxValue;
    Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch()}in)");
    Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch()}in)");

    // Test common font sizes
    Console.WriteLine("\nTesting common font sizes:");
    PTS font8pt = new PTS("8pt");
    PTS font10pt = new PTS("10pt");
    PTS font12pt = new PTS("12pt");
    PTS font14pt = new PTS("14pt");
    PTS font18pt = new PTS("18pt");
    PTS font24pt = new PTS("24pt");
    Console.WriteLine($"  8pt = {(Int64)font8pt} pts");
    Console.WriteLine($"  10pt = {(Int64)font10pt} pts");
    Console.WriteLine($"  12pt = {(Int64)font12pt} pts");
    Console.WriteLine($"  14pt = {(Int64)font14pt} pts");
    Console.WriteLine($"  18pt = {(Int64)font18pt} pts");
    Console.WriteLine($"  24pt = {(Int64)font24pt} pts");

    // Test common measurements in typography
    Console.WriteLine("\nTesting common typography measurements:");
    PTS pica = new PTS("12pt");  // 1 pica = 12 pts
    PTS halfInch = new PTS("0.5in");
    PTS quarterInch = new PTS("0.25in");
    Console.WriteLine($"  1 pica (12pt): {(Int64)pica} pts");
    Console.WriteLine($"  0.5in: {(Int64)halfInch} pts (expected 36)");
    Console.WriteLine($"  0.25in: {(Int64)quarterInch} pts (expected 18)");

    // Test string parsing variations
    Console.WriteLine("\nTesting string parsing variations:");
    PTS fromPlainNumber = "72";
    PTS fromInches = "1in";
    PTS fromPTS = "72pt";
    Console.WriteLine($"  \"72\" → {(Int64)fromPlainNumber} pts");
    Console.WriteLine($"  \"1in\" → {(Int64)fromInches} pts");
    Console.WriteLine($"  \"72pt\" → {(Int64)fromPTS} pts");

    // Test decimal values with units
    Console.WriteLine("\nTesting decimal values with units:");
    PTS halfPoint = new PTS("0.5pt");
    PTS quarterPoint = new PTS("0.25pt");
    Console.WriteLine($"  0.5pt = {(Int64)halfPoint} pts (expected 0)");
    Console.WriteLine($"  0.25pt = {(Int64)quarterPoint} pts (expected 0)");

    // Test comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    PTS commaDecimal = new PTS("2,54cm");
    Console.WriteLine($"  \"2,54cm\" → {(Int64)commaDecimal} pts");

    // Test Deserialization from different formats
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // Numeric format
    string jsonNumeric = "{\"Value\":72}";
    var fromNumeric = JsonSerializer.Deserialize<PTSWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 72: {fromNumeric?.Value}");

    // String format with unit
    string jsonStringInch = "{\"Value\":\"1in\"}";
    var fromStringInch = JsonSerializer.Deserialize<PTSWrapper>(jsonStringInch);
    Console.WriteLine($"  From JSON string \"1in\": {fromStringInch?.Value}");

    // String format without unit
    string jsonStringPlain = "{\"Value\":\"72\"}";
    var fromStringPlain = JsonSerializer.Deserialize<PTSWrapper>(jsonStringPlain);
    Console.WriteLine($"  From JSON string \"72\": {fromStringPlain?.Value}");

    // Test output with units match input
    Console.WriteLine("\nTesting output format with different units:");
    PTS measurement = 72;
    Console.WriteLine($"  As pts: {measurement}");
    Console.WriteLine($"  As inches (no precision): {measurement.ToString(LengthUnit.Inches)}");
    Console.WriteLine($"  As inches (2 decimal): {measurement.ToString("F2", LengthUnit.Inches)}");
    Console.WriteLine($"  As pts: {measurement.ToString(LengthUnit.Points)}");
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
    PTS fromInt64 = 72L;
    Int64 toInt64 = fromInt64;
    Console.WriteLine($"  From Int64: {fromInt64}");
    Console.WriteLine($"  To Int64: {toInt64}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Measures and reports the performance of various operations related to the PTS class, including construction,
  /// conversion, comparison, and serialization.
  /// </summary>
  /// <remarks>This method executes a series of timed tests for PTS operations, such as constructing instances
  /// from different input types, converting between units, serializing and deserializing objects, and comparing or
  /// hashing values. The elapsed time for each operation is output to the console to assist with performance analysis.
  /// This method is intended for diagnostic or benchmarking purposes and does not validate correctness of the
  /// operations.</remarks>
  /// <returns>true if all performance tests complete successfully.</returns>
  static bool TestPTSPerformance()
  {
    Console.WriteLine("--- Testing PTS Performance ---"); const int iterations = 100000;

    // Test construction from string with unit
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      PTS pts = "1in";
    }
    sw.Stop();
    Console.WriteLine($"Construction from string with unit x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from plain number string
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      PTS pts = "72";
    }
    sw.Stop();
    Console.WriteLine($"Construction from plain string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from integer
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      PTS pts = 72;
    }
    sw.Stop();
    Console.WriteLine($"Construction from integer x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    PTS testPTS = 72;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testPTS.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString with unit
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testPTS.ToString(LengthUnit.Inches);
    }
    sw.Stop();
    Console.WriteLine($"ToString(unit) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test unit conversion performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double inches = testPTS.ToInch();
    }
    sw.Stop();
    Console.WriteLine($"ToInch() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double pts = testPTS.ToPT();
    }
    sw.Stop();
    Console.WriteLine($"ToPT() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double mm = testPTS.ToMM();
    }
    sw.Stop();
    Console.WriteLine($"ToMM() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = new PTSTestData
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
      var obj = JsonSerializer.Deserialize<PTSTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test comparison performance
    PTS pts1 = 72;
    PTS pts2 = 72;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int result = pts1.CompareTo(pts2);
    }
    sw.Stop();
    Console.WriteLine($"CompareTo() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test hash code performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int hash = pts1.GetHashCode();
    }
    sw.Stop();
    Console.WriteLine($"GetHashCode() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test implicit conversions performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      Int64 value = pts1;
    }
    sw.Stop();
    Console.WriteLine($"Implicit conversion to Int64 x {iterations}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  }


/// <summary>
/// Test data class containing various PTS properties.
/// </summary>
[XmlRoot("PTSTestData")]
public class PTSTestData
{
  [XmlElement("FontSize")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
public class PTSWrapper
{
  public PTS Value { get; set; }
}

