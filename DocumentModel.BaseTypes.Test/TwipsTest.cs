using System.Globalization;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for Twips type serialization in both XML and JSON formats.
/// </summary>
public static class TwipsTest
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


  /// <summary>
  /// Tests the basic operations of the Twips class, including conversions between Twips and various types, string
  /// representations, and comparisons.
  /// </summary>
  /// <remarks>This method verifies the correctness of the Twips class by testing string and numeric conversions,
  /// string representations, hash code consistency, and comparison operations. It outputs diagnostic information to the
  /// console for each test and returns false if any test fails.</remarks>
  /// <returns>true if all basic Twips operations pass successfully; otherwise, false.</returns>
  static bool TestTwipsBasicOperations()
  {
    Console.WriteLine("--- Testing Twips Basic Operations ---");
    // Test string to Twips conversion (plain number)
    long Twips1Val = 7315200;
    var Twips1Str = Twips1Val.ToString();
    Twips Twips1 = Twips1Str;
    var longTwips = (long)Twips1;
    Console.WriteLine($"\n✓ String to Twips: {Twips1} = {longTwips} Twips");
    if (longTwips != 7315200)
    {
      Console.WriteLine("✗ String to Twips conversion FAILED");
      return false;
    }
    // Test string to Twips conversion (with unit)
    Twips Twips2 = "1in";
    var inchTwips = Twips2.ToInch();
    Console.WriteLine($"\n✓ String with unit to Twips: {Twips2} ({inchTwips}in)");
    if (inchTwips != 1.0m)
    {
      Console.WriteLine("✗ String with unit to Twips conversion FAILED");
      return false;
    }

    // Test integer to Twips conversion
    Twips Twips3 = Twips1Val;
    var intTwips = (int)Twips3;
    Console.WriteLine($"\n✓ Int to Twips: {intTwips}");
    if (intTwips != Twips1Val)
    {
      Console.WriteLine("✗ Int to Twips conversion FAILED");
      return false;
    }

    // Test Twips to string
    string strTwips = Twips1.ToString();
    Console.WriteLine($"\n✓ Twips to string: {strTwips}");
    if (strTwips != Twips1Str)
    {
      Console.WriteLine("✗ Twips to string conversion FAILED");
      return false;
    }

    // Test Twips to various integer types
    int int32Val = (int)Twips1;
    long int64Val = (long)Twips1;
    uint uint32Val = (uint)Twips1;
    Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");
    if (int32Val != Twips1Val || int64Val != Twips1Val || uint32Val != Twips1Val)
    {
      Console.WriteLine("✗ Twips to numeric conversions FAILED");
      return false;
    }

    // Test comparison
    Twips Twips4 = Twips1Val * 2; // 2 inches
    Console.WriteLine($"\n✓ CompareTo ({Twips1Val} vs {Twips4}): {Twips1.CompareTo(Twips4)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the accuracy and correctness of conversions between Twips and various length units, including inches,
  /// millimeters, centimeters, Twips, and twips.
  /// </summary>
  /// <remarks>This method performs a series of unit conversion tests and outputs the results to the console. It
  /// verifies both direct and round-trip conversions, as well as string formatting for different units and precisions.
  /// Use this method to validate that Twips-related conversion logic is functioning as expected.</remarks>
  /// <returns>true if all unit conversion tests pass; otherwise, false.</returns>
  static bool TestTwipsUnitConversions()
  {
    var Twips1Inch = 72.0 * 20;
    var Twips1MM = Twips1Inch / 25.4;
    var Twips1CM = Twips1MM * 10;
    var Twips1PT = Twips1Inch / 72.0;
    var Twips12PT = Twips1PT * 12;
    var Twips1Twips = Twips1Inch / 1440.0;
    var Twips10Twips = Twips1Twips * 10;

    Console.WriteLine("--- Testing Twips Unit Conversions ---");
    // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    Twips oneInch = "1in";
    Console.WriteLine($"  1in = {oneInch} Twips (expected {Twips1Inch})");
    Console.WriteLine($"  {Twips1Inch} Twips = {oneInch.ToInch()}in");
    if (!oneInch.Equals(Twips1Inch))
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    Twips oneMM = "1mm";
    Console.WriteLine($"  1mm = {oneMM} Twips (expected {Twips1MM})");
    Console.WriteLine($"  {Twips1MM} Twips = {oneMM.ToMillimeters()}mm");
    if (!oneMM.Equals(Twips1MM))
    {
      Console.WriteLine("✗ Millimeter conversion FAILED");
      return false;
    }

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    Twips oneCM = "1cm";
    Console.WriteLine($"  1cm = {oneCM} Twips (expected ~{Twips1CM})");
    Console.WriteLine($"  {Twips1CM} Twips = {oneCM.ToCentimeters()}cm");
    if (!oneCM.Equals(Twips1CM))
    {
      Console.WriteLine("✗ Centimeter conversion FAILED");
      return false;
    }

    // Test point conversions
    Console.WriteLine("\nTesting point conversions:");
    Twips twelveTwips = "12pt";
    Console.WriteLine($"  12pt = {twelveTwips} Twips (expected {Twips12PT})");
    Console.WriteLine($"  {Twips12PT} Twips = {twelveTwips.ToPoints()}pt");
    if (!twelveTwips.Equals(Twips12PT))
    {
      Console.WriteLine("✗ IPoint conversion FAILED");
      return false;
    }

    // Test twips conversions
    Console.WriteLine("\nTesting twips conversions:");
    Twips tenTwips = "10tw";
    Console.WriteLine($"  10tw = {tenTwips} Twips (expected {Twips10Twips})");
    Console.WriteLine($"  {Twips10Twips} Twips = {tenTwips.ToTwips()}tw");
    if (!tenTwips.Equals(Twips10Twips))
    {
      Console.WriteLine("✗ Twips conversion FAILED");
      return false;
    }

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    Twips original = Twips1Inch; // 1 inch
    decimal inches = original.ToInch();
    Twips roundTrip = new Twips($"{inches:F6}in");
    Console.WriteLine($"  Original: {(long)original} Twips");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to Twips: {(long)roundTrip} Twips");
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
    Console.WriteLine($"  As Twips: {original}");
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

  /// <summary>
  /// Verifies that the deserialized TwipsTestData matches the original test data. It checks each property for equality
  /// and outputs diagnostic information to the console for any discrepancies.
  /// </summary>
  /// <param name="deserializedData">The deserialized TwipsTestData object.</param>
  /// <param name="testData">The original TwipsTestData object used for serialization.</param>
  /// <returns>true if all properties match; otherwise, false.</returns>
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

  /// <summary>
  /// Tests the JSON serialization and deserialization process for TwipsTestData objects to ensure data integrity.
  /// </summary>
  /// <remarks>This method creates a TwipsTestData instance, serializes it to a JSON string, and then
  /// deserializes it back to verify that the original and resulting objects are equivalent. The serialized JSON output
  /// is written to the console for inspection.</remarks>
  /// <returns>true if the serialized and deserialized data match and the test passes; otherwise, false.</returns>
  static bool TestTwipsJsonSerialization()
  {
    Console.WriteLine("--- Testing Twips JSON Serialization ---");
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
    var deserializedData = JsonSerializer.Deserialize<TwipsTestData>(jsonString, jsonOptions);
    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;

  }

  /// <summary>
  /// Creates a new instance of the TwipsTestData class initialized with standard page dimensions, margins, font size,
  /// and spacing values for testing purposes.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios that require consistent and representative
  /// document layout data. All values are specified in twips, a unit commonly used in document formatting.</remarks>
  /// <returns>A TwipsTestData object populated with predefined values for page width, page height, margins, font size, line
  /// spacing, and additional test values.</returns>
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

  /// <summary>
  /// Displays the original data values from the specified TwipsTestData instance, including page dimensions, margins,
  /// font size, line spacing, and specific value properties.
  /// </summary>
  /// <remarks>This method outputs the original data to the console in both Twips and converted units (inches
  /// and points) for better readability.</remarks>
  /// <param name="testData">The TwipsTestData instance containing the original data to be displayed.</param>
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

  /// <summary>
  /// Tests a variety of edge cases for the Twips class, including zero values, boundary values, common document
  /// measurements, font sizes, string parsing, deserialization, output formatting, comparisons, and implicit
  /// conversions.
  /// </summary>
  /// <remarks>This method outputs the results of each test to the console, providing insight into the behavior
  /// of the Twips class under different scenarios. It is intended for diagnostic and validation purposes during
  /// development.</remarks>
  /// <returns>true if all Twips edge case tests are completed successfully; otherwise, false.</returns>
  static bool TestTwipsEdgeCases()
  {
    Console.WriteLine("--- Testing Twips Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    Twips zero = 0;
    Console.WriteLine($"  Zero: '{zero}' ({(Int64)zero} twips)");
    Console.WriteLine($"  Zero with unit: '{zero.ToString(LengthUnit.Inches)}'");

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
    Console.WriteLine($"  As inches (no precision): {measurement.ToString(LengthUnit.Inches)}");
    Console.WriteLine($"  As inches (2 decimal): {measurement.ToString("F2", LengthUnit.Inches)}");
    Console.WriteLine($"  As points: {measurement.ToString(LengthUnit.Points)}");
    Console.WriteLine($"  As mm (1 decimal): {measurement.ToString("F1", LengthUnit.Millimeters)}");
    Console.WriteLine($"  As cm (2 decimal): {measurement.ToString("F2", LengthUnit.Centimeters)}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    Twips small = 720;  // 0.5 inch
    Twips large = 1440; // 1 inch
    Console.WriteLine($"  720 < 1440: {small.CompareTo(large) < 0}");
    Console.WriteLine($"  1440 > 720: {large.CompareTo(small) > 0}");
    Console.WriteLine($"  1440 == 1440: {large.CompareTo(new Twips(1440)) == 0}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit conversions:");
    Twips fromInt64 = 1440L;
    Int64 toInt64 = fromInt64;
    Console.WriteLine($"  From Int64: {fromInt64}");
    Console.WriteLine($"  To Int64: {toInt64}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Measures and reports the performance of various operations related to the Twips class, including construction,
  /// conversion, comparison, and JSON serialization.
  /// </summary>
  /// <remarks>This method executes a series of timed tests for common Twips operations, such as constructing
  /// instances from different formats, converting units, serializing and deserializing with JSON, and performing
  /// equality and comparison checks. The elapsed time for each operation is output to the console to assist developers
  /// in evaluating the performance characteristics of the Twips class.</remarks>
  /// <returns>true if all performance tests complete successfully.</returns>
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
      string str = testTwips.ToString()!;
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString with unit
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testTwips.ToString(LengthUnit.Inches);
    }
    sw.Stop();
    Console.WriteLine($"ToString(unit) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test unit conversion performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      decimal inches = testTwips.ToInch();
    }
    sw.Stop();
    Console.WriteLine($"ToInch() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      decimal points = testTwips.ToPoints();
    }
    sw.Stop();
    Console.WriteLine($"ToPoints() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      decimal mm = testTwips.ToMillimeters();
    }
    sw.Stop();
    Console.WriteLine($"ToMillimeters() x {iterations}: {sw.ElapsedMilliseconds}ms");

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

}


/// <summary>
/// Test data class containing various Twips properties.
/// </summary>
[XmlRoot("TwipsTestData")]
public class TwipsTestData
{
  [XmlElement("PageWidth")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
  public Twips PageWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("PageHeight")]
  public Twips PageHeight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LeftMargin")]
  public Twips LeftMargin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("TopMargin")]
  public Twips TopMargin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("FontSize")]
  public Twips FontSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LineSpacing")]
  public Twips LineSpacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ZeroValue")]
  public Twips ZeroValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("SmallValue")]
  public Twips SmallValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LargeValue")]
  public Twips LargeValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class TwipsWrapper
{
  public Twips Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


