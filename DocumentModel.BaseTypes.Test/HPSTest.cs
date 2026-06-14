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
  /// Tests the basic operations of the HPS class, including conversions between HPS and various types, string
  /// representations, and comparisons.
  /// </summary>
  /// <remarks>This method verifies the correctness of the HPS class by testing string and numeric conversions,
  /// string representations, hash code consistency, and comparison operations. It outputs diagnostic information to the
  /// console for each test and returns false if any test fails.</remarks>
  /// <returns>true if all basic HPS operations pass successfully; otherwise, false.</returns>
  static bool TestHPSBasicOperations()
  {
    Console.WriteLine("--- Testing HPS Basic Operations ---");
    // Test string to HPS conversion (plain number)
    long hps1Val = 7315200;
    var hps1Str = hps1Val.ToString();
    HPS hps1 = hps1Str;
    var longHPS = (long)hps1;
    Console.WriteLine($"\n✓ String to HPS: {hps1} = {longHPS} HPS");
    if (longHPS != 7315200)
    {
      Console.WriteLine("✗ String to HPS conversion FAILED");
      return false;
    }
    // Test string to HPS conversion (with unit)
    HPS hps2 = "1in";
    var inchHPS = hps2.ToInch();
    Console.WriteLine($"\n✓ String with unit to HPS: {hps2} ({inchHPS}in)");
    if (inchHPS != 1.0)
    {
      Console.WriteLine("✗ String with unit to HPS conversion FAILED");
      return false;
    }

    // Test integer to HPS conversion
    HPS hps3 = hps1Val;
    var intHPS = (int)hps3;
    Console.WriteLine($"\n✓ Int to HPS: {intHPS}");
    if (intHPS != hps1Val)
    {
      Console.WriteLine("✗ Int to HPS conversion FAILED");
      return false;
    }

    // Test HPS to string
    string strHPS = hps1.ToString();
    Console.WriteLine($"\n✓ HPS to string: {strHPS}");
    if (strHPS != hps1Str)
    {
      Console.WriteLine("✗ HPS to string conversion FAILED");
      return false;
    }

    // Test HPS to various integer types
    int int32Val = (int)hps1;
    long int64Val = (long)hps1;
    uint uint32Val = (uint)hps1;
    Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");
    if (int32Val != hps1Val || int64Val != hps1Val || uint32Val != hps1Val)
    {
      Console.WriteLine("✗ HPS to numeric conversions FAILED");
      return false;
    }

    // Test comparison
    HPS hps4 = hps1Val * 2; // 2 inches
    Console.WriteLine($"\n✓ CompareTo ({hps1Val} vs {hps4}): {hps1.CompareTo(hps4)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the accuracy and correctness of conversions between HPS and various length units, including inches,
  /// millimeters, centimeters, points, and twips.
  /// </summary>
  /// <remarks>This method performs a series of unit conversion tests and outputs the results to the console. It
  /// verifies both direct and round-trip conversions, as well as string formatting for different units and precisions.
  /// Use this method to validate Ithat HPS-related conversion logic is functioning as expected.</remarks>
  /// <returns>true if all unit conversion tests pass; otherwise, false.</returns>
  static bool TestHPSUnitConversions()
  {
    var hps1Inch = 72 * 2;
    var hps1MM = hps1Inch / 25.4;
    var hps1CM = hps1MM * 10;
    var hps1PT = hps1Inch / 72;
    var hps12PT = hps1PT * 12;
    var hps1Twips = hps1Inch / 1440.0;
    var hps10Twips = hps1Twips * 10;

    Console.WriteLine("--- Testing HPS Unit Conversions ---");
    // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    HPS oneInch = "1in";
    Console.WriteLine($"  1in = {oneInch} HPS (expected {hps1Inch})");
    Console.WriteLine($"  {hps1Inch} HPS = {oneInch.ToInch()}in");
    if (!oneInch.Equals(hps1Inch))
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    HPS oneMM = "1mm";
    Console.WriteLine($"  1mm = {oneMM} HPS (expected {hps1MM})");
    Console.WriteLine($"  {hps1MM} HPS = {oneMM.ToMillimeters()}mm");
    if (!oneMM.Equals(hps1MM))
    {
      Console.WriteLine("✗ Millimeter conversion FAILED");
      return false;
    }

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    HPS oneCM = "1cm";
    Console.WriteLine($"  1cm = {oneCM} HPS (expected ~{hps1CM})");
    Console.WriteLine($"  {hps1CM} HPS = {oneCM.ToCentimeters()}cm");
    if (!oneCM.Equals(hps1CM))
    {
      Console.WriteLine("✗ Centimeter conversion FAILED");
      return false;
    }

    // Test point conversions
    Console.WriteLine("\nTesting point conversions:");
    HPS twelvePoints = "12pt";
    Console.WriteLine($"  12pt = {twelvePoints} HPS (expected {hps12PT})");
    Console.WriteLine($"  {hps12PT} HPS = {twelvePoints.ToPoints()}pt");
    if (!twelvePoints.Equals(hps12PT))
    {
      Console.WriteLine("✗ IPoint conversion FAILED");
      return false;
    }

    // Test twips conversions
    Console.WriteLine("\nTesting twips conversions:");
    HPS tenTwips = "10tw";
    Console.WriteLine($"  10tw = {tenTwips} HPS (expected {hps10Twips})");
    Console.WriteLine($"  {hps10Twips} HPS = {tenTwips.ToTwips()}tw");
    if (!tenTwips.Equals(hps10Twips))
    {
      Console.WriteLine("✗ Twips conversion FAILED");
      return false;
    }

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    HPS original = hps1Inch; // 1 inch
    double inches = original.ToInch();
    HPS roundTrip = new HPS($"{inches:F6}in");
    Console.WriteLine($"  Original: {(long)original} HPS");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to HPS: {(long)roundTrip} HPS");
    if (original.CompareTo(roundTrip) != 0)
    {
      Console.WriteLine("✗ Round-trip conversion FAILED");
      return false;
    }

    // Test ConvertTo for each unit
    Console.WriteLine("\nTesting ConvertTo method:");
    UniversalMeasure length = original;
    Console.WriteLine($"  To inches: {length.ConvertTo(LengthUnit.Inches)}");
    Console.WriteLine($"  To mm: {length.ConvertTo(LengthUnit.Millimeters)}");
    Console.WriteLine($"  To cm: {length.ConvertTo(LengthUnit.Centimeters)}");
    Console.WriteLine($"  To pt: {length.ConvertTo(LengthUnit.Points)}");
    Console.WriteLine($"  To twips: {length.ConvertTo(LengthUnit.Twips)}");

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

  /// <summary>
  /// Tests the serialization and deserialization of HPS values within an XML format using the XmlSerializer. This test
  /// ensures Ithat HPS values are correctly preserved during the XML serialization and deserialization process.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
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

  /// <summary>
  /// Displays the original formatting values from the specified HPSTestData instance in a readable format.
  /// </summary>
  /// <remarks>This method outputs various formatting properties, such as font size, line height, letter
  /// spacing, word spacing, superscript and subscript offsets, border width, and value thresholds, to the console.
  /// Measurements are shown in both their original units and converted to points where applicable.</remarks>
  /// <param name="testData">The HPSTestData instance containing the formatting values to display.</param>
  private static void ShowOriginalData(HPSTestData testData)
  {
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
  }

  /// <summary>
  /// Determines whether the deserialized HPSTestData object matches the expected test data values.
  /// </summary>
  /// <remarks>If deserializedData is null, the method returns false. Each property of deserializedData is
  /// compared to the corresponding property in testData, and the method returns false on the first mismatch.</remarks>
  /// <param name="deserializedData">The HPSTestData instance obtained from deserialization to verify. This parameter can be null.</param>
  /// <param name="testData">The original HPSTestData instance containing the expected values for comparison.</param>
  /// <returns>true if all properties of the deserialized data are equal to the corresponding properties in the test data;
  /// otherwise, false.</returns>
  private static bool VerifyDeserializedData(HPSTestData? deserializedData, HPSTestData testData)
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

  /// <summary>
  /// Tests the serialization and deserialization of HPS data to and from JSON format.
  /// </summary>
  /// <remarks>This method creates a test object, serializes it to JSON, and then deserializes it back to verify
  /// the integrity of the data. It outputs the serialized JSON string to the console for inspection.</remarks>
  /// <returns>true if the JSON serialization and deserialization process is successful; otherwise, false.</returns>
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

  /// <summary>
  /// Creates a new instance of HPSTestData with predefined test values.
  /// </summary>
  /// <returns>A new HPSTestData instance populated with test values.</returns>
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

  /// <summary>
  /// Tests a comprehensive set of edge cases for the HPS (Half-IPoint Size) type, including zero, boundary values,
  /// precision, string parsing, unit conversions, deserialization, and implicit conversions.
  /// </summary>
  /// <remarks>This method outputs detailed results to the console, providing insights into the behavior of the
  /// HPS type under various scenarios. It is intended for use in validating the correctness and robustness of HPS
  /// handling, especially when dealing with different input formats, units, and conversions.</remarks>
  /// <returns>true if all edge case tests complete successfully; otherwise, false.</returns>
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
      Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch()}in)");
      Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch()}in)");

      // Test half-point precision (unique to HPS)
      Console.WriteLine("\nTesting half-point precision:");
      HPS oneHalfPoint = 1;
      HPS twoHPS = 2;
      Console.WriteLine($"  1 half-point = {oneHalfPoint.ToPoints():F1}pt");
      Console.WriteLine($"  2 HPS = {twoHPS.ToPoints():F1}pt (1 full point)");

      // Test common fine-grained adjustments
      Console.WriteLine("\nTesting fine-grained typography adjustments:");
      HPS letterSpacing = new HPS(1);    // 0.5pt letter spacing
      HPS kerning = new HPS(2);          // 1pt kerning
      HPS tracking = new HPS(3);         // 1.5pt tracking
      Console.WriteLine($"  Letter spacing (1 half-point): {letterSpacing.ToPoints():F1}pt");
      Console.WriteLine($"  Kerning (2 HPS): {kerning.ToPoints():F1}pt");
      Console.WriteLine($"  Tracking (3 HPS): {tracking.ToPoints():F1}pt");

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

  /// <summary>
  /// Measures and reports the performance of various operations related to the HPS class, including construction,
  /// string conversion, unit conversion, JSON serialization, deserialization, comparison, and hashing.
  /// </summary>
  /// <remarks>This method executes multiple iterations of each tested operation and outputs the elapsed time
  /// for each to the console. It is intended to help identify performance bottlenecks in the HPS class and related
  /// serialization routines. If an exception occurs during testing, the method reports the failure and returns
  /// false.</remarks>
  /// <returns>true if all performance tests complete successfully; otherwise, false.</returns>
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
        double points = testHp.ToPoints();
      }
      sw.Stop();
      Console.WriteLine($"ToPoints() x {iterations}: {sw.ElapsedMilliseconds}ms");

      sw.Restart();
      for (int i = 0; i < iterations; i++)
      {
        double mm = testHp.ToMillimeters();
      }
      sw.Stop();
      Console.WriteLine($"ToMillimeters() x {iterations}: {sw.ElapsedMilliseconds}ms");

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
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
  public HPS FontSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LineHeight")]
  public HPS LineHeight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LetterSpacing")]
  public HPS LetterSpacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("WordSpacing")]
  public HPS WordSpacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("SuperscriptOffset")]
  public HPS SuperscriptOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("SubscriptOffset")]
  public HPS SubscriptOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("BorderWidth")]
  public HPS BorderWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ZeroValue")]
  public HPS ZeroValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("SmallValue")]
  public HPS SmallValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LargeValue")]
  public HPS LargeValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class HPSWrapper
{
  public HPS Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


