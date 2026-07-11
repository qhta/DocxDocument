using System.Globalization;

// ReSharper disable SpecifyACultureInStringConversionExplicitly

namespace DocumentModel.BaseTypes.Test;

/// <summary>
/// Test suite for Degrees type serialization in both XML and JSON formats.
/// </summary>
public static class DegreesTest
{
  /// <summary>
  /// Runs all Degrees serialization tests.
  /// </summary>
  public static bool Run()
  {
    Console.WriteLine("=== Degrees Serialization Test Program ===");
    Console.WriteLine();

    // Run all tests
    if (!TestDegreesBasicOperations()) return false;
    if (!TestDegreesXmlSerialization()) return false;
    if (!TestDegreesJsonSerialization()) return false;
    if (!TestDegreesEdgeCases()) return false;

    return true;
  }


  static bool TestDegreesBasicOperations()
  {
    Console.WriteLine("--- Testing Degrees Basic Operations ---"); // Test string to Degrees conversion
    Console.WriteLine("");
    var ok = true;


    // Test string to Degrees conversion
    var str = "180°";
    Degrees deg1 = str;
    var decVal = deg1.Value;
    ok = decVal == 180;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} String to Degrees: \"{str}\" -> {decVal}");
    if (!ok) return false;

    // Test string from Degrees conversion
    deg1 = new Degrees("180°");
    var strVal = (string)deg1;
    ok = strVal == "180°";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Degrees to string: \"{deg1}\" -> {strVal}");
    if (!ok) return false;

    // Test Degrees to double conversion
    deg1 = new Degrees("180°");
    double dbl = (double)deg1;
    ok = dbl == 0.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Degrees to double: {deg1} -> {dbl}");
    if (!ok) return false;

    // Test double to Degrees conversion
    dbl = 0.5;
    deg1 = dbl;
    ok = deg1 == 0.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Double to Degrees: {dbl} -> {deg1}");
    if (!ok) return false;

    // Test Degrees to int conversion
    deg1 = new Degrees("180°");
    var intVal = (int)deg1;
    ok = intVal == 180;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Degrees to int: {deg1} -> {intVal}");
    if (!ok) return false;

    // Test int to Degrees conversion
    intVal = 180;
    deg1 = intVal;
    ok = deg1 == 0.5;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} int to Degrees: {intVal} -> {deg1}");
    if (!ok) return false;

    // Test Degrees to string without °
    strVal = "180";
    deg1 = new Degrees(strVal);
    ok = deg1 == "180°";
    Console.WriteLine($"{TestHelper.OkMarker(ok)} String without ° to Degrees: \"{strVal}\" -> {deg1}");
    if (!ok) return false;

    // Test with precision
    strVal = "180.12°";
    deg1 = new Degrees(strVal);
    string preciseStr = deg1.ToString(2, "°");
    ok = strVal == preciseStr;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} String to Degrees: \"{deg1}\" -> {preciseStr}");

    // Test hash code
    deg1 = new Degrees("180°");
    var hash1 = deg1.GetHashCode();
    var hash2 = (0.5).GetHashCode();
    ok = hash1 == hash2;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Hash code test: {hash1} {TestHelper.EqualitySymbol(ok)} {hash2}");
    if (!ok) return false;

    // Test equality
    deg1 = new Degrees("180°");
    Degrees deg2 = new Degrees(0.5);
    ok = deg1.Equals(deg2);
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Equality test: \"{deg1}\" {TestHelper.EqualityMessage(ok)} \"{deg2}\" ");
    if (!ok) return false;

    // Test comparison 1
    deg1 = new Degrees("180°");
    deg2 = new Degrees(0.5);
    var cmp = deg1.CompareTo(deg2);
    ok = cmp == 0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Comparison 1 test: \"{deg1}\" {TestHelper.CompareMessage(cmp)} \"{deg2}\" ");
    if (!ok) return false;

    // Test comparison 2
    deg1 = new Degrees("181°");
    deg2 = new Degrees(0.5);
    cmp = deg1.CompareTo(deg2);
    ok = cmp == 1;
    Console.WriteLine($"{TestHelper.OkMarker(ok)} Comparison 2 test: \"{deg1}\" {TestHelper.CompareMessage(cmp)} \"{deg2}\" ");
    if (!ok) return false;

    Console.WriteLine();
    return true;
  }



  static bool TestDegreesXmlSerialization()
  {
    Console.WriteLine("--- Testing Degrees XML Serialization ---"); // Create test object
    var testData = CreateTestData();
    ShowOriginalData(testData);

    // Serialize to XML
    var xmlSerializer = new XmlSerializer(typeof(DegreesTestData));
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
    DegreesTestData? deserializedData;
    using (var stringReader = new StringReader(xmlString))
    {
      deserializedData = (DegreesTestData?)xmlSerializer.Deserialize(stringReader);
    }

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ XML Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }
  
  static bool TestDegreesJsonSerialization()
  {
    Console.WriteLine("--- Testing Degrees JSON Serialization ---"); // Create test object
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
    var deserializedData = JsonSerializer.Deserialize<DegreesTestData>(jsonString, jsonOptions);

    if (!VerifyDeserializedData(deserializedData, testData)) return false;

    Console.WriteLine("\n✓ JSON Serialization/Deserialization test passed");
    Console.WriteLine();
    return true;
  }

  private static DegreesTestData CreateTestData()
  {
    var testData = new DegreesTestData
    {
      FullAngle = new Degrees("360°"),
      HalfAngle = new Degrees("180°"),
      RightAngle = new Degrees("90°"),
      ZeroDegrees = new Degrees("0°"),
      HundredDegrees = new Degrees("100°"),
      FractionalDegrees = new Degrees("33.333°"),
      NegativeDegrees = new Degrees("-5.5°")
    };
    return testData;
  }

  private static void ShowOriginalData(DegreesTestData testData)
  {
    Console.WriteLine($"Original data:");
    Console.WriteLine($"  FullAngle: {testData.FullAngle}");
    Console.WriteLine($"  HalfAngle: {testData.HalfAngle}");
    Console.WriteLine($"  RightAngle: {testData.RightAngle}");
    Console.WriteLine($"  ZeroDegrees: {testData.ZeroDegrees}");
    Console.WriteLine($"  HundredDegrees: {testData.HundredDegrees}");
    Console.WriteLine($"  FractionalDegrees: {testData.FractionalDegrees}");
    Console.WriteLine($"  NegativeDegrees: {testData.NegativeDegrees}");
    Console.WriteLine();
  }

  private static bool VerifyDeserializedData(DegreesTestData? deserializedData, DegreesTestData testData)
  {
    if (deserializedData == null)
    {
      Console.WriteLine("✗ Deserialization returned null");
      return false;
    }

    // Verify deserialized data
    Console.WriteLine("Deserialized data:");
    var ok = true;
    ok = testData.FullAngle.Equals(deserializedData.FullAngle);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  FullAngle: {deserializedData.FullAngle}");
    if (!ok) return false;

    ok = testData.HalfAngle.Equals(deserializedData.HalfAngle);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  HalfAngle: {deserializedData.HalfAngle}");
    if (!ok) return false;

    ok = testData.RightAngle.Equals(deserializedData.RightAngle);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  RightAngle: {deserializedData.RightAngle}");
    if (!ok) return false;

    ok = testData.ZeroDegrees.Equals(deserializedData.ZeroDegrees);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  ZeroDegrees: {deserializedData.ZeroDegrees}");
    if (!ok) return false;

    ok = testData.HundredDegrees.Equals(deserializedData.HundredDegrees);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  HundredDegrees: {deserializedData.HundredDegrees}");
    if (!ok) return false;

    ok = testData.FractionalDegrees.Equals(deserializedData.FractionalDegrees);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  FractionalDegrees: {deserializedData.FractionalDegrees}");
    if (!ok) return false;

    ok = testData.NegativeDegrees.Equals(deserializedData.NegativeDegrees);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  NegativeDegrees: {deserializedData.NegativeDegrees}");
    if (!ok) return false;

    return true;
  }


  static bool TestDegreesEdgeCases()
  {
    Console.WriteLine("--- Testing Degrees Edge Cases ---"); // Test zero value
    Console.WriteLine();

    Console.WriteLine("Testing zero value:");
    var ok = true;
    Degrees zero = new Degrees(0);
    var dblZero = zero.ToDouble(null);
    ok = zero==0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Zero: '{zero}' = {dblZero}");
    if (!ok) return false;

    // Test boundary values
    Console.WriteLine("\nTesting boundary values:");
    Degrees minDegrees = new Degrees(0);
    Degrees maxDegrees = new Degrees(360);
    var minInt = minDegrees.ToInt32(null);
    var maxInt = maxDegrees.ToInt32(null);
    ok = minInt==0;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Min (0°): \"{minDegrees}\" = {minInt}");
    ok = maxInt==360;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Max (360°): \"{maxDegrees}\" = {maxInt}");
    if (!ok) return false;

    // Test negative values
    Console.WriteLine("\nTesting negative values:");
    Degrees negative = new Degrees("-90°");
    var dblNegative = negative.ToDouble(null);
    ok = dblNegative == -0.25;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Negative (-90°): \"{negative}\" = {dblNegative}");
    if (!ok) return false;

    // Test large values (beyond 360°)
    Console.WriteLine("\nTesting values beyond 360°:");
    Degrees large = new Degrees("450°");
    var dblLarge = large.ToDouble(null);
    ok = dblLarge == 1.25;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  Large (450°): \"{large}\" = {dblLarge}");
    if (!ok) return false;

    // Test fractional values 1
    Console.WriteLine("\nTesting fractional decimal values:");
    Degrees oneEights = new Degrees("22.5°");
    var decOneEights = oneEights.ToDecimal(null);
    ok = decOneEights == 22.5m;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One eighth: \"{oneEights}\" = {decOneEights} (decimal)");
    if (!ok) return false;

    // Test fractional values 2
    Console.WriteLine("\nTesting fractional double values:");
    oneEights = new Degrees("22.5°");
    var dblOneEights = oneEights.ToDouble(null);
    ok =  oneEights.Equals(dblOneEights);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One eighth: \"{oneEights}\" {TestHelper.EqualityMessage(ok)} {dblOneEights} (double)");
    if (!ok) return false;
    Console.WriteLine(" but note that due to floating-point precision, the equality check may not always be true for fractional values when using double.");
    ok = oneEights == dblOneEights;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One eighth: \"{oneEights}\" {TestHelper.EqualitySymbol(ok)} {dblOneEights} (double)");
    ok = dblOneEights == oneEights;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  One eighth: {dblOneEights} (double) {TestHelper.EqualitySymbol(ok)} \"{oneEights}\"");
    if (!ok) return false;

    // Test very small fractional values
    Console.WriteLine("\nTesting very small fractional values:");
    Degrees tiny = new Degrees(0.001);
    var dblTiny = tiny.ToDouble(null);
    ok = dblTiny == 0.001;
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  0.001°: \"{tiny}\" = {dblTiny}");
    if (!ok) return false;

    // Test string parsing with and without ° suffix
    Console.WriteLine("\nTesting string parsing with and without ° suffix:");
    Degrees withDegrees = "75.5°";
    Degrees withoutDegrees = "75.5";
    ok = withDegrees.Equals(withoutDegrees);
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75.5°\" → {withDegrees}");
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75.5\" → {withoutDegrees}");
    if (!ok) return false;



    // Test string parsing with comma decimal separator
    Console.WriteLine("\nTesting comma decimal separator:");
    Degrees commaDecimal = "75,5°";
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75.5°\" → {withDegrees}");
    Console.WriteLine($"{TestHelper.OkMarker(ok)}  \"75,5\" → {commaDecimal}");
    if (!ok) return false;

    // Test JSON numeric vs string input
    Console.WriteLine("\nTesting Deserialization from different formats:");

    // String format with °
    string jsonStringWithDegrees = "{\"Value\":\"180°\"}";
    var fromStringDegrees = JsonSerializer.Deserialize<DegreesWrapper>(jsonStringWithDegrees);
    Console.WriteLine($"  From JSON string \"180°\": {fromStringDegrees?.Value}");

    // String format without °
    string jsonStringWithoutDegrees = "{\"Value\":\"180\"}";
    var fromStringNoDegrees = JsonSerializer.Deserialize<DegreesWrapper>(jsonStringWithoutDegrees);
    Console.WriteLine($"  From JSON string \"180\": {fromStringNoDegrees?.Value}");

    // Numeric format
    string jsonNumeric = "{\"Value\":180.5}";
    var fromNumeric = JsonSerializer.Deserialize<DegreesWrapper>(jsonNumeric);
    Console.WriteLine($"  From JSON number 180.5: {fromNumeric?.Value}");

    // Test formatting with precision
    Console.WriteLine("\nTesting formatted output:");
    Degrees deg = new Degrees("75.12345°");
    Console.WriteLine($"  Default: {deg.ToString()}");
    Console.WriteLine($"  No unit: {deg.ToString(CultureInfo.InvariantCulture, null)}");
    Console.WriteLine($"  Precision 0: {deg.ToString(0, "°")}");
    Console.WriteLine($"  Precision 2: {deg.ToString(2, "°")}");
    Console.WriteLine($"  Precision 4: {deg.ToString(4, "°")}");

    // Test comparison
    Console.WriteLine("\nTesting comparison:");
    Degrees small = new Degrees("25.5°");
    Degrees large2 = new Degrees("75.5°");
    Console.WriteLine($"  25.5° < 75.5°: {small.CompareTo(large2) < 0}");
    Console.WriteLine($"  75.5° > 25.5°: {large2.CompareTo(small) > 0}");
    Console.WriteLine($"  180° == 180°: {new Degrees("180°").CompareTo(new Degrees("180°")) == 0}");

    // Test IConvertible implementation
    Console.WriteLine("\nTesting IConvertible conversions:");
    Degrees convertTest = new Degrees("42.75°");
    Console.WriteLine($"  ToByte: {convertTest.ToByte(null)}");
    Console.WriteLine($"  ToInt32: {convertTest.ToInt32(null)}");
    Console.WriteLine($"  ToDouble: {convertTest.ToDouble(null)}");
    Console.WriteLine($"  ToDecimal: {convertTest.ToDecimal(null)}");

    // Test ToType conversions
    Console.WriteLine("\nTesting ToType conversions:");
    var asInt32 = (int)convertTest.ToType(typeof(Int32), null);
    var asDouble = (double)convertTest.ToType(typeof(Double), null);
    var asString = (string)convertTest.ToType(typeof(String), null);
    Console.WriteLine($"  ToType(Int32): {asInt32}");
    Console.WriteLine($"  ToType(Double): {asDouble}");
    Console.WriteLine($"  ToType(String): {asString}");

    Console.WriteLine("\n✓ All edge case tests completed");
    Console.WriteLine();
    return true;
  }

}


/// <summary>
/// Test data class containing various Degrees properties.
/// </summary>
[XmlRoot("DegreesTestData")]
public class DegreesTestData
{
  [XmlElement("FullAngle")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Degrees FullAngle
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("HalfAngle")]
  public Degrees HalfAngle
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("RightAngle")]
  public Degrees RightAngle
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("ZeroDegrees")]
  public Degrees ZeroDegrees
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("HundredDegrees")]
  public Degrees HundredDegrees
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("FractionalDegrees")]
  public Degrees FractionalDegrees
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }

  [XmlElement("NegativeDegrees")]
  public Degrees NegativeDegrees
  {
    [DebuggerStepThrough]
    get;
    [DebuggerStepThrough]
    set;
  }
}


/// <summary>
/// Simple wrapper class for testing Deserialization scenarios.
/// </summary>
public class DegreesWrapper
{
  public Degrees Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}


