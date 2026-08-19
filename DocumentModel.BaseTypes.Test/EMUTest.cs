using System.Globalization;

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for EMU type serialization in both XML and JSON formats.
/// </summary>
public static class EMUTest
{

  /// <summary>
  /// Runs a comprehensive suite of tests to validate the EMU serialization functionality, including basic operations,
  /// unit conversions, serialization formats, edge cases, and performance.
  /// </summary>
  /// <remarks>This method writes test results to the console. It is intended for use in verifying the
  /// correctness and reliability of the EMU serialization components during development or maintenance.</remarks>
  /// <returns>true if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== EMU Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestEMUBasicOperations()) return false;
    if (!TestEMUUnitConversions()) return false;
    if (!TestEMUXmlSerialization()) return false;
    if (!TestEMUJsonSerialization()) return false;
    if (!TestEMUEdgeCases()) return false;
    if (!TestEMUPerformance()) return false;

    return true;
  }

  /// <summary>
  /// Tests the fundamental operations of the EMU class, including conversions between strings, integers, and EMU
  /// instances, as well as comparison and hash code consistency.
  /// </summary>
  /// <remarks>This method verifies that the EMU class correctly handles conversions from string and integer
  /// representations, supports accurate numeric type conversions, produces consistent hash codes, and implements
  /// comparison logic as expected. It is intended for use in validating the core functionality of the EMU
  /// type.</remarks>
  /// <returns>true if all basic EMU operations succeed; otherwise, false.</returns>
  static bool TestEMUBasicOperations()
  {
    Console.WriteLine("--- Testing EMU Basic Operations ---");
    // Test string to EMU conversion (plain number)
    long emu1Val = 914400;
    var emu1Str = emu1Val.ToString();
    EMU emu1 = emu1Str;
    var longEMU = (long)emu1;
    Console.WriteLine($"\nâś“ String to EMU: {emu1} = {longEMU} EMUs");
    if (longEMU != 914400)
    {
      Console.WriteLine("âś— String to EMU conversion FAILED");
      return false;
    }
    // Test string to EMU conversion (with unit)
    EMU emu2 = "1in";
    var inchEMU = emu2.ToInch();
    Console.WriteLine($"\nâś“ String with unit to EMU: {emu2} ({inchEMU}in)");
    if (inchEMU != 1.0m)
    {
      Console.WriteLine("âś— String with unit to EMU conversion FAILED");
      return false;
    }

    // Test integer to EMU conversion
    EMU emu3 = emu1Val;
    var intEMU = (int)emu3;
    Console.WriteLine($"\nâś“ Int to EMU: {intEMU}");
    if (intEMU != emu1Val)
    {
      Console.WriteLine("âś— Int to EMU conversion FAILED");
      return false;
    }
    
    // Test EMU to string
    string strEMU = emu1.ToString();
    Console.WriteLine($"\nâś“ EMU to string: {strEMU}");
    if (strEMU != emu1Str)
    {
      Console.WriteLine("âś— EMU to string conversion FAILED");
      return false;
    }

    // Test EMU to various integer types
    int int32Val = (int)emu1;
    long int64Val = (long)emu1;
    uint uint32Val = (uint)emu1;
    Console.WriteLine($"\nâś“ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");
    if (int32Val != emu1Val || int64Val != emu1Val || uint32Val != emu1Val)
    {
      Console.WriteLine("âś— EMU to numeric conversions FAILED");
      return false;
    }

    // Test comparison
    EMU emu4 = emu1Val * 2; // 2 inches
    Console.WriteLine($"\nâś“ CompareTo ({emu1Val} vs {emu4}): {emu1.CompareTo(emu4)} (expected < 0)");

    Console.WriteLine("\nâś“ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the accuracy and correctness of conversions between EMUs and various length units, including inches,
  /// millimeters, centimeters, points, and twips.
  /// </summary>
  /// <remarks>This method performs a series of unit conversion tests and outputs the results to the console. It
  /// verifies both direct and round-trip conversions, as well as string formatting for different units and precisions.
  /// Use this method to validate that EMU-related conversion logic is functioning as expected.</remarks>
  /// <returns>true if all unit conversion tests pass; otherwise, false.</returns>
  static bool TestEMUUnitConversions()
  {
    var emu1Inch = 914400;
    var emu1MM = emu1Inch / 25.4;
    var emu1CM = emu1MM * 10;
    var emu1PT = emu1Inch / 72;
    var emu12PT = emu1PT * 12;
    var emu1Twips = emu1Inch / 1440.0;
    var emu10Twips = emu1Twips * 10;

    Console.WriteLine("--- Testing EMU Unit Conversions ---");      
    // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    EMU oneInch = "1in";
    Console.WriteLine($"  1in = {(long)oneInch} EMUs (expected {emu1Inch})");
    Console.WriteLine($"  {emu1Inch} EMUs = {oneInch.ToInch()}in");
    if (!oneInch.Equals(emu1Inch))
    {
      Console.WriteLine("âś— Inch conversion FAILED");
      return false;
    }

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    EMU oneMM = "1mm";
    Console.WriteLine($"  1mm = {(long)oneMM} EMUs (expected {emu1MM})");
    Console.WriteLine($"  {emu1MM} EMUs = {oneMM.ToMillimeters()}mm");
    if (!oneMM.Equals(emu1MM))
    {
      Console.WriteLine("âś— Millimeter conversion FAILED");
      return false;
    }

    // Test centimeter conversions
    Console.WriteLine("\nTesting centimeter conversions:");
    EMU oneCM = "1cm";
    Console.WriteLine($"  1cm = {(long)oneCM} EMUs (expected ~{emu1CM})");
    Console.WriteLine($"  {emu1CM} EMUs = {oneCM.ToCentimeters()}cm");
    if (!oneCM.Equals(emu1CM))
    {
      Console.WriteLine("âś— Centimeter conversion FAILED");
      return false;
    }

    // Test point conversions
    Console.WriteLine("\nTesting point conversions:");
    EMU twelvePoints = "12pt";
    Console.WriteLine($"  12pt = {(long)twelvePoints} EMUs (expected {emu12PT})");
    Console.WriteLine($"  {emu12PT} EMUs = {twelvePoints.ToPoints()}pt");
    if (!twelvePoints.Equals(emu12PT))
    {
      Console.WriteLine("âś— IPoint conversion FAILED");
      return false;
    }

    // Test twips conversions
    Console.WriteLine("\nTesting twips conversions:");
    EMU tenTwips = "10tw";
    Console.WriteLine($"  10tw = {(long)tenTwips} EMUs (expected {emu10Twips})");
    Console.WriteLine($"  {emu10Twips} EMUs = {tenTwips.ToTwips()}tw");
    if (!tenTwips.Equals(emu10Twips))
    {
      Console.WriteLine("âś— Twips conversion FAILED");
      return false;
    }

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    EMU original = emu1Inch; // 1 inch
    decimal inches = original.ToInch();
    EMU roundTrip = new EMU($"{inches:F6}in");
    Console.WriteLine($"  Original: {(long)original} EMUs");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to EMUs: {(long)roundTrip} EMUs");
    if (original.CompareTo(roundTrip) != 0)
    {
      Console.WriteLine("âś— Round-trip conversion FAILED");
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
    Console.WriteLine($"  As EMUs: {original}");
    Console.WriteLine($"  As inches: {length.ToString(MeasureUnit.Inches)}");
    Console.WriteLine($"  As mm: {length.ToString(MeasureUnit.Millimeters)}");

    // Test string output with precision
    Console.WriteLine("\nTesting string output with precision:");
    Console.WriteLine($"  Precision 0: {length.ToString("F0", MeasureUnit.Inches)}");
    Console.WriteLine($"  Precision 2: {length.ToString("F2", MeasureUnit.Millimeters)}");

    Console.WriteLine("\nâś“ All unit conversion tests passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the XML serialization and deserialization process for an EMUTestData object and verifies data integrity.
  /// </summary>
  /// <remarks>This method creates a sample EMUTestData instance, serializes it to an XML string, and then
  /// deserializes it back to an object. It compares the deserialized data to the original to ensure that the
  /// serialization process preserves all relevant information. This is intended for use in validating the correctness
  /// of XML serialization logic for EMUTestData.</remarks>
  /// <returns>true if the EMUTestData object is correctly serialized to XML and deserialized back with matching data; otherwise,
  /// false.</returns>
  static bool TestEMUXmlSerialization()
  {
    Console.WriteLine("--- Testing EMU XML Serialization ---");      // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(EMUTestData));
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
    EMUTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (EMUTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;
    Console.WriteLine("\nâś“ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Tests the serialization and deserialization of EMU test data using JSON format.
  /// </summary>
  /// <remarks>This method creates a sample EMU test data object, serializes it to a JSON string, and then
  /// deserializes it back to an object to verify that the original and deserialized data are equivalent. The serialized
  /// JSON output is written to the console for inspection. This method is intended for diagnostic or validation
  /// purposes and is not typically used in production code.</remarks>
  /// <returns>true if the JSON serialization and deserialization process completes successfully and the data integrity is
  /// verified; otherwise, false.</returns>
  static bool TestEMUJsonSerialization()
  {
    Console.WriteLine("--- Testing EMU JSON Serialization ---");      // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<EMUTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\nâś“ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Displays the original dimensions and values of the specified EMUTestData instance in a formatted output.
  /// </summary>
  /// <remarks>This method outputs the original data to the console, including conversions of width and height
  /// to inches and offsets to millimeters.</remarks>
  /// <param name="testData">The EMUTestData instance containing the original data to be displayed, including width, height, offsets, and
  /// values.</param>
  private static void ShowOriginalData(EMUTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  Width: {testData.Width} ({testData.Width.ToInch()}in)");
    Console.WriteLine($"  Height: {testData.Height} ({testData.Height.ToInch()}in)");
    Console.WriteLine($"  LeftOffset: {testData.LeftOffset} ({testData.LeftOffset.ToMillimeters():F1}mm)");
    Console.WriteLine($"  TopOffset: {testData.TopOffset} ({testData.TopOffset.ToMillimeters():F1}mm)");
    Console.WriteLine($"  ZeroValue: {testData.ZeroValue}");
    Console.WriteLine($"  SmallValue: {testData.SmallValue}");
    Console.WriteLine($"  LargeValue: {testData.LargeValue}");
    Console.WriteLine();
  }

  /// <summary>
  /// Verifies that the deserialized EMUTestData object matches the expected test data values.
  /// </summary>
  /// <remarks>If the deserializedData parameter is null, the method returns false and logs an error message.
  /// The method compares several properties of the deserialized data with the expected values to ensure
  /// correctness.</remarks>
  /// <param name="deserializedData">The deserialized EMUTestData object to verify against the expected values. This parameter can be null.</param>
  /// <param name="testData">The expected EMUTestData object containing the values to compare against the deserialized data.</param>
  /// <returns>true if the deserialized data matches the expected test data; otherwise, false.</returns>
  private static bool VerifyDeserializedData(EMUTestData? deserializedData, EMUTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("âś— Deserialization returned null");
      return false;
    }

    Console.WriteLine("Deserialized data:");

    Console.WriteLine($"  Width: {deserializedData.Width}");
    if (testData.Width.CompareTo(deserializedData.Width) != 0)
      return false;
    Console.WriteLine($"  Height: {deserializedData.Height}");
    if (testData.Height.CompareTo(deserializedData.Height) != 0)
      return false;
    Console.WriteLine($"  LeftOffset: {deserializedData.LeftOffset}");
    if (testData.LeftOffset.CompareTo(deserializedData.LeftOffset) != 0)
      return false;
    Console.WriteLine($"  TopOffset: {deserializedData.TopOffset}");
    if (testData.TopOffset.CompareTo(deserializedData.TopOffset) != 0)
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
  /// Creates and initializes a new instance of the EMUTestData class with predefined values for width, height, offsets,
  /// and various test values.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios where a standard set of EMUTestData values is
  /// required. The dimensions and offsets are specified in various measurement units, ensuring flexibility in testing
  /// different configurations.</remarks>
  /// <returns>A new instance of EMUTestData containing initialized properties for testing purposes.</returns>
  private static EMUTestData CreateTestData()
  {
    return new EMUTestData
    {
      Width = new EMU("1in"),
      Height = new EMU("2in"),
      LeftOffset = new EMU("10mm"),
      TopOffset = new EMU("15mm"),
      ZeroValue = new EMU(0),
      SmallValue = new EMU(36000),
      LargeValue = new EMU(9144000)
    };
  }

  /// <summary>
  /// Tests a variety of edge cases for the EMU (English Metric Unit) class, including zero values, boundary values,
  /// string parsing, deserialization, formatting, comparisons, and implicit conversions.
  /// </summary>
  /// <remarks>This method outputs the results of each test to the console, providing insight into the behavior
  /// of the EMU class under different scenarios. It is intended for diagnostic or validation purposes and does not
  /// throw exceptions for failed cases.</remarks>
  /// <returns>true if all edge case tests are completed successfully; otherwise, false.</returns>
  static bool TestEMUEdgeCases()
  {
    Console.WriteLine("--- Testing EMU Edge Cases ---");      // Test zero value
    Console.WriteLine("Testing zero value:");
    EMU zero = 0;
    Console.WriteLine($"  Zero: '{zero}' ({(long)zero} EMUs)");

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    EMU minInt32 = int.MinValue;
    EMU maxInt32 = int.MaxValue;
    Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch()}in)");
    Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch()}in)");

    // Test string parsing variations
    Console.WriteLine("\nTesting string parsing variations:");
    EMU fromPlainNumber = "914400";
    EMU fromInches = "1in";
    EMU fromInchesDot = "1.in";
    EMU fromMillimeters = "25.4mm";
    Console.WriteLine($"  \"914400\" â†’ {(long)fromPlainNumber} EMUs");
    Console.WriteLine($"  \"1in\" â†’ {(long)fromInches} EMUs");
    Console.WriteLine($"  \"1.in.\" â†’ {(long)fromInchesDot} EMUs");
    Console.WriteLine($"  \"25.4mm\" â†’ {(long)fromMillimeters} EMUs");

    // Test comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    EMU commaDecimal = new EMU("25,4mm");
    Console.WriteLine($"  \"25,4mm\" â†’ {(long)commaDecimal} EMUs");

    // Test Deserialization from different formats
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // Numeric format
    string jsonNumeric = "{\"Value\":914400}";
    var fromNumeric = JsonSerializer.Deserialize<EMUWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 914400: {fromNumeric?.Value}");

    // String format with unit
    string jsonStringInch = "{\"Value\":\"1in\"}";
    var fromStringInch = JsonSerializer.Deserialize<EMUWrapper>(jsonStringInch);
    Console.WriteLine($"  From JSON string \"1in\": {fromStringInch?.Value}");

    // String format without unit
    string jsonStringPlain = "{\"Value\":\"914400\"}";
    var fromStringPlain = JsonSerializer.Deserialize<EMUWrapper>(jsonStringPlain);
    Console.WriteLine($"  From JSON string \"914400\": {fromStringPlain?.Value}");

    // Test output with units
    Console.WriteLine("\nTesting output format with different units:");
    EMU measurement = 914400;
    Console.WriteLine($"  As EMUs: {measurement}");
    Console.WriteLine($"  As inches (no precision): {measurement.ToString(MeasureUnit.Inches)}");
    Console.WriteLine($"  As inches (3 decimal): {measurement.ToString("F3", MeasureUnit.Inches)}");
    Console.WriteLine($"  As mm (1 decimal): {measurement.ToString("F1", MeasureUnit.Millimeters)}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    EMU small = 457200;  // 0.5 inch
    EMU large = 914400;  // 1 inch
    Console.WriteLine($"  457200 < 914400: {small.CompareTo(large) < 0}");
    Console.WriteLine($"  914400 > 457200: {large.CompareTo(small) > 0}");
    Console.WriteLine($"  914400 == 914400: {large.CompareTo(new EMU(914400)) == 0}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit conversions:");
    EMU fromInt64 = 914400L;
    long toInt64 = fromInt64;
    Console.WriteLine($"  From Int64: {fromInt64}");
    Console.WriteLine($"  To Int64: {toInt64}");

    Console.WriteLine("\nâś“ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

  /// <summary>
  /// Measures and reports the performance of various operations related to the EMU class, including construction,
  /// string conversion, unit conversion, JSON serialization, deserialization, comparison, and hashing.
  /// </summary>
  /// <remarks>This method executes a series of timed tests for different EMU class operations, outputting the
  /// elapsed time for each to the console. It is intended for use in evaluating the efficiency of EMU-related methods
  /// and conversions. The results can help identify performance bottlenecks or verify optimizations.</remarks>
  /// <returns>true if all performance tests complete successfully.</returns>
  static bool TestEMUPerformance()
  {
    Console.WriteLine("--- Testing EMU Performance ---"); 
    const int iterations = 100000;

    // Test construction from string with unit
    var sw = System.Diagnostics.Stopwatch.StartNew();
    for (int i = 0; i < iterations; i++)
    {
      EMU emu = "1in";
    }
    sw.Stop();
    Console.WriteLine($"Construction from string with unit x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from plain number string
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      EMU emu = "914400";
    }
    sw.Stop();
    Console.WriteLine($"Construction from plain string x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test construction from integer
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      EMU emu = 914400;
    }
    sw.Stop();
    Console.WriteLine($"Construction from integer x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString performance
    EMU testEmu = 914400;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testEmu.ToString();
    }
    sw.Stop();
    Console.WriteLine($"ToString() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test ToString with unit
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      string str = testEmu.ToString(MeasureUnit.Inches);
    }
    sw.Stop();
    Console.WriteLine($"ToString(unit) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test unit conversion performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      decimal inches = testEmu.ToInch();
    }
    sw.Stop();
    Console.WriteLine($"ToInch() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      decimal mm = testEmu.ToMillimeters();
    }
    sw.Stop();
    Console.WriteLine($"ToMillimeters() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test JSON serialization performance
    var testObj = CreateTestData();

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
      var obj = JsonSerializer.Deserialize<EMUTestData>(jsonData);
    }
    sw.Stop();
    Console.WriteLine($"Deserialization x {iterations / 10}: {sw.ElapsedMilliseconds}ms");

    // Test comparison performance
    EMU emu1 = 914400;
    EMU emu2 = 914400;
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int result = emu1.CompareTo(emu2);
    }
    sw.Stop();
    Console.WriteLine($"CompareTo() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test hash code performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      int hash = emu1.GetHashCode();
    }
    sw.Stop();
    Console.WriteLine($"GetHashCode() x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test implicit conversions performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      long value = emu1;
    }
    sw.Stop();
    Console.WriteLine($"Implicit conversion to Int64 x {iterations}: {sw.ElapsedMilliseconds}ms");

    Console.WriteLine("\nâś“ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  }


/// <summary>
/// Test data class containing various EMU properties.
/// </summary>
[XmlRoot("EMUTestData")]
public class EMUTestData
{
  [XmlElement("Width")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
  public EMU Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("Height")]
  public EMU Height { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LeftOffset")]
  public EMU LeftOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("TopOffset")]
  public EMU TopOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("ZeroValue")]
  public EMU ZeroValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("SmallValue")]
  public EMU SmallValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  [XmlElement("LargeValue")]
  public EMU LargeValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class EMUWrapper
{
  public EMU Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


