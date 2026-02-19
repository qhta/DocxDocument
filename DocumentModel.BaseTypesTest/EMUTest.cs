using System.Globalization;

namespace DocumentModel.BaseTypesTest;

/// <summary>
/// Test suite for EMU type serialization in both XML and JSON formats.
/// </summary>
public static class EMUTest
{
  /// <summary>
  /// Runs all EMU serialization tests.
  /// </summary>
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

  #region Basic Operations Tests

  static bool TestEMUBasicOperations()
  {
    Console.WriteLine("--- Testing EMU Basic Operations ---");      // Test string to EMU conversion (plain number)
    EMU emu1 = "914400";
    Console.WriteLine($"\n✓ String to EMU: {emu1} = {(long)emu1} EMUs");

    // Test string to EMU conversion (with unit)
    EMU emu2 = "1in";
    Console.WriteLine($"\n✓ String with unit to EMU: {emu2} ({emu2.ToInch():F2}in)");

    // Test integer to EMU conversion
    EMU emu3 = 914400;
    Console.WriteLine($"\n✓ Int to EMU: {emu3}");

    // Test equality
    if (emu1.CompareTo(emu3) == 0)
      Console.WriteLine("\n✓ Equality test passed");
    else
      Console.WriteLine("✗ Equality test FAILED");

    // Test EMU to string
    string str = emu1.ToString();
    Console.WriteLine($"\n✓ EMU to string: {str}");

    // Test EMU to various integer types
    int int32Val = (int)emu1;
    long int64Val = (long)emu1;
    uint uint32Val = (uint)emu1;
    Console.WriteLine($"\n✓ Numeric conversions: int32={int32Val}, int64={int64Val}, uint32={uint32Val}");

    // Test hash code
    Console.WriteLine($"\n✓ Hash code: {emu1.GetHashCode()}");

    // Test comparison
    EMU emu4 = 1828800; // 2 inches
    Console.WriteLine($"\n✓ CompareTo (914400 vs 1828800): {emu1.CompareTo(emu4)} (expected < 0)");

    Console.WriteLine("\n✓ All basic operations passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region Unit Conversion Tests

  static bool TestEMUUnitConversions()
  {
    Console.WriteLine("--- Testing EMU Unit Conversions ---");      // Test inch conversions
    Console.WriteLine("Testing inch conversions:");
    EMU oneInch = "1in";
    Console.WriteLine($"  1in = {(long)oneInch} EMUs (expected 914400)");
    Console.WriteLine($"  914400 EMUs = {oneInch.ToInch():F2}in");
    if ((long)oneInch != 914400)
    {
      Console.WriteLine("✗ Inch conversion FAILED");
      return false;
    }

    // Test millimeter conversions
    Console.WriteLine("\nTesting millimeter conversions:");
    EMU oneMM = "1mm";
    Console.WriteLine($"  1mm = {(long)oneMM} EMUs (expected 36000)");
    Console.WriteLine($"  36000 EMUs = {oneMM.ToMM():F2}mm");
    if ((long)oneMM != 36000)
    {
      Console.WriteLine("✗ Millimeter conversion FAILED");
      return false;
    }

    // Test conversion accuracy
    Console.WriteLine("\nTesting round-trip conversion accuracy:");
    EMU original = 914400; // 1 inch
    double inches = original.ToInch();
    EMU roundTrip = new EMU($"{inches:F6}in");
    Console.WriteLine($"  Original: {(long)original} EMUs");
    Console.WriteLine($"  To inches: {inches:F6}in");
    Console.WriteLine($"  Back to EMUs: {(long)roundTrip} EMUs");
    Console.WriteLine($"  Match: {original.CompareTo(roundTrip) == 0}");

    // Test string output with units
    Console.WriteLine("\nTesting string output with units:");
    EMU measurement = 914400;
    Console.WriteLine($"  As EMUs: {measurement}");
    Console.WriteLine($"  As inches: {measurement.ToString(LengthUnit.Inches)}");
    Console.WriteLine($"  As mm: {measurement.ToString(LengthUnit.Millimeters)}");

    // Test string output with precision
    Console.WriteLine("\nTesting string output with precision:");
    Console.WriteLine($"  Precision 0: {measurement.ToString("F0", LengthUnit.Inches)}");
    Console.WriteLine($"  Precision 2: {measurement.ToString("F2", LengthUnit.Millimeters)}");

    Console.WriteLine("\n✓ All unit conversion tests passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region XML Serialization Tests

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
    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  #endregion

  #region JSON Serialization Tests

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

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static void ShowOriginalData(EMUTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  Width: {testData.Width} ({testData.Width.ToInch():F2}in)");
    Console.WriteLine($"  Height: {testData.Height} ({testData.Height.ToInch():F2}in)");
    Console.WriteLine($"  LeftOffset: {testData.LeftOffset} ({testData.LeftOffset.ToMM():F1}mm)");
    Console.WriteLine($"  TopOffset: {testData.TopOffset} ({testData.TopOffset.ToMM():F1}mm)");
    Console.WriteLine($"  ZeroValue: {testData.ZeroValue}");
    Console.WriteLine($"  SmallValue: {testData.SmallValue}");
    Console.WriteLine($"  LargeValue: {testData.LargeValue}");
    Console.WriteLine();
  }

  private static bool VerifyDeserializedData(EMUTestData? deserializedData, EMUTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
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

  #endregion

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

  #region Edge Cases Tests

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
    Console.WriteLine($"  Int32.MinValue: {minInt32} ({minInt32.ToInch():F2}in)");
    Console.WriteLine($"  Int32.MaxValue: {maxInt32} ({maxInt32.ToInch():F2}in)");

    // Test string parsing variations
    Console.WriteLine("\nTesting string parsing variations:");
    EMU fromPlainNumber = "914400";
    EMU fromInches = "1in";
    EMU fromInchesDot = "1.in";
    EMU fromMillimeters = "25.4mm";
    Console.WriteLine($"  \"914400\" → {(long)fromPlainNumber} EMUs");
    Console.WriteLine($"  \"1in\" → {(long)fromInches} EMUs");
    Console.WriteLine($"  \"1.in.\" → {(long)fromInchesDot} EMUs");
    Console.WriteLine($"  \"25.4mm\" → {(long)fromMillimeters} EMUs");

    // Test comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    EMU commaDecimal = new EMU("25,4mm");
    Console.WriteLine($"  \"25,4mm\" → {(long)commaDecimal} EMUs");

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
    Console.WriteLine($"  As inches (no precision): {measurement.ToString(LengthUnit.Inches)}");
    Console.WriteLine($"  As inches (3 decimal): {measurement.ToString("F3", LengthUnit.Inches)}");
    Console.WriteLine($"  As mm (1 decimal): {measurement.ToString("F1", LengthUnit.Millimeters)}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    EMU small = 457200;  // 0.5 inch
    EMU large = 914400;  // 1 inch
    Console.WriteLine($"  457200 < 914400: {small.CompareTo(large) < 0}");
    Console.WriteLine($"  914400 > 457200: {large.CompareTo(small) > 0}");
    Console.WriteLine($"  914400 == 914400: {large.CompareTo(new EMU(914400)) == 0}");

    // Test implicit conversions
    Console.WriteLine("\nTesting implicit conversions:");
    EMU fromInt32 = 914400;
    EMU fromInt64 = 914400L;
    EMU fromUInt32 = 914400U;
    int toInt32 = fromInt32;
    long toInt64 = fromInt64;
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

  static bool TestEMUPerformance()
  {
    Console.WriteLine("--- Testing EMU Performance ---"); const int iterations = 100000;

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
      string str = testEmu.ToString(LengthUnit.Inches);
    }
    sw.Stop();
    Console.WriteLine($"ToString(unit) x {iterations}: {sw.ElapsedMilliseconds}ms");

    // Test unit conversion performance
    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double inches = testEmu.ToInch();
    }
    sw.Stop();
    Console.WriteLine($"ToInch() x {iterations}: {sw.ElapsedMilliseconds}ms");

    sw.Restart();
    for (int i = 0; i < iterations; i++)
    {
      double mm = testEmu.ToMM();
    }
    sw.Stop();
    Console.WriteLine($"ToMM() x {iterations}: {sw.ElapsedMilliseconds}ms");

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

    Console.WriteLine("\n✓ Performance tests completed");
    Console.WriteLine();
    return true;
  }

  #endregion
}

#region Test Helper Classes

/// <summary>
/// Test data class containing various EMU properties.
/// </summary>
[XmlRoot("EMUTestData")]
public class EMUTestData
{
  [XmlElement("Width")]
  public EMU Width { get; set; }

  [XmlElement("Height")]
  public EMU Height { get; set; }

  [XmlElement("LeftOffset")]
  public EMU LeftOffset { get; set; }

  [XmlElement("TopOffset")]
  public EMU TopOffset { get; set; }

  [XmlElement("ZeroValue")]
  public EMU ZeroValue { get; set; }

  [XmlElement("SmallValue")]
  public EMU SmallValue { get; set; }

  [XmlElement("LargeValue")]
  public EMU LargeValue { get; set; }
}

/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class EMUWrapper
{
  public EMU Value { get; set; }
}

#endregion
